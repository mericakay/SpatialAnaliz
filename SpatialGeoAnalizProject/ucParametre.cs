using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SpatialGeoAnalizProject
{
    public partial class ucParametre : UserControl
    {
        public ucParametre()
        {
            InitializeComponent();
        }
        publicConnectionString connectionstring = new publicConnectionString();
        DataTable tablo = new DataTable();
        // Ana Parametreleri dolduruyor
        public void cmb1doldur()
        {
            String query = "SELECT a.id AS id, a.params  AS name,a.alacagi_param, a.verecegi_param, a.addsql FROM sys_params a WHERE a.active = 0 AND a.deleted = 0 ORDER BY a.priority";
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
          
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            
              DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbbir.DisplayMember = "name";
            cmbbir.ValueMember = "id";
            cmbbir.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        //Seçilen Parametreleri buraya ekliyor
        public void grdDoldur()
        {
           // string connectionString = "Server=78.187.120.6;Port=5432;User Id=postgres;Password=postgres;Database=dd";
            string sql = "SELECT  a.addsql as sqlx FROM sys_params a WHERE a.active = 0 AND a.deleted = 0 and a.id =  " + cmbbir.SelectedValue + " ORDER BY a.priority ";
            NpgsqlConnection connection = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlDataAdapter dataadapter = new NpgsqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "sqlx");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "sqlx";
            string colnum;
            colnum = dataGridView1.Columns[0].Name;
            label1.Text = dataGridView1.Rows[0].Cells[colnum].Value.ToString();

        }
        //Ana parametreye bağlı ikinci parametreleri dolduruyor
        public void cmb2doldur()
        {

            String query = label1.Text.ToString();
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbiki.DisplayMember = "name";
            cmbiki.ValueMember = "id";
            cmbiki.DataSource = ds.Tables[0];
            dataconnect.Close();
            //  cmb1.Text = dgview.Cells[cellIndex].Value.ToString();
        }

        private void ucParametre_Load(object sender, EventArgs e)
        {
        
            cmb1doldur();
            tablo.Columns.Add("Analiz Türü", typeof(string));
            tablo.Columns.Add("Analiz Tipi", typeof(string));
            this.dgview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // dgview.Width = Screen.PrimaryScreen.Bounds.Width;

        }

        private void cmbbir_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdDoldur();
            cmb2doldur();
        }

        private void btnsonuc_Click(object sender, EventArgs e)
        {
            degerEkle();
            // MessageBox.Show("Analiz Tamamlandı Sonuçları Harita ekranından görebilir Rapor ekranından raporlaya bilirsiniz !", "Uyarı");
            
        }

        private void btnanaliz_Click(object sender, EventArgs e)
        {
            string deger = cmbbir.SelectedValue.ToString();
            string deger2 = cmbiki.SelectedValue.ToString();
            tablo.Rows.Add(deger, deger2);

            dgview.DataSource = tablo;
            dgview.Visible = true;
        }
        //Harita katmanını Boşaltıyor
        public void truncateTable()
        {
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            string sqlTrunc = "TRUNCATE TABLE public.info_params ";
            NpgsqlCommand cmd = new NpgsqlCommand(sqlTrunc, dataconnect);
            dataconnect.Open();
            cmd.ExecuteNonQuery();
            dataconnect.Close();

        }
        ProgressBar prg = new ProgressBar();
        //Seçilen Analizin geometrisini insert eden sp'yi çalıştırıyor
        public void spexecute()
        {
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlCommand cmd = new NpgsqlCommand();
            NpgsqlDataReader reader;
            cmd.CommandText = "oki_temp_insert_gisdata()";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = dataconnect;
            DataTable dt = new DataTable();

            dataconnect.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                progressBar1.Minimum = 0;
                progressBar1.Maximum = 100;
                progressBar1.Step = 5;
                progressBar1.Style = ProgressBarStyle.Continuous;

                progressBar1.Value = 10;
                progressBar1.Value = Convert.ToInt32( reader[0].ToString());
                progressBar1.Show();
                progressBar1.Visible = true;
                chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -70;
                chart1.Visible = true;
                chart1.Series["Olasılık"].Points.Add(Convert.ToInt32(reader[0].ToString()));

               // chart1.ChartAreas[0].AxisX.Maximum = 13; chart1.ChartAreas[0].AxisX.Minimum = 0;
                DialogResult dialogResult = MessageBox.Show("Yapılan Analiz Sonucunda olma olasılığı %" + reader[0].ToString() + "  'dir Devam Etmek ister misiniz ?", "Uyarı", MessageBoxButtons.YesNo);
                if ( dialogResult ==  DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(@"http://localhost:8081/mapstore/#/viewer/leaflet/0");
                }
            


            }

            dataconnect.Close();

        }

        public void degerEkle()
        {
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            truncateTable();
            for (int i = 0; i < dgview.Rows.Count; i++)

            {
                dataconnect.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = dataconnect;
                string deger = cmbbir.SelectedValue.ToString();
                string deger2 = cmbiki.SelectedValue.ToString();
                int combobox1_id = Int32.Parse(deger);
                int combobox2_id = Int32.Parse(deger2);
                cmd.CommandText = "insert into public.info_params (combobox1_id, combobox2_id )values ( @combobox1_id, @combobox2_id) ";
                cmd.Parameters.AddWithValue("@combobox1_id", dgview.Rows[i].Cells[0].Value);
                cmd.Parameters.AddWithValue("@combobox2_id", dgview.Rows[i].Cells[1].Value);
                cmd.ExecuteNonQuery();
                dataconnect.Close();
            }
            spexecute();
        }
    }
}
