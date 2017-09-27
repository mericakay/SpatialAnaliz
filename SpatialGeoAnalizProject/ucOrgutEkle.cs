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
    public partial class ucOrgutEkle : UserControl
    {
        public ucOrgutEkle()
        {
            InitializeComponent();
        }
        public void dereceDoldur()
        {
            String query = "SELECT first_group,  description  FROM sys_specific_definitions where main_group = 42 order by first_group";
            NpgsqlConnection dataconnect = new NpgsqlConnection(
             "Server=192.168.1.47;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            comboBox1.DisplayMember = "description";
            comboBox1.ValueMember = "first_group";
            comboBox1.DataSource = ds.Tables[0];
            dataconnect.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            string orgutAdi = txtadi.Text.ToString();
            string kisaltma = txtkisaltma.Text.ToString();
            //int derece = comboBox1.SelectedValue.ToString();
            NpgsqlConnection dataconnect = new NpgsqlConnection(
           "Server=192.168.1.47;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlCommand cmd = new NpgsqlCommand();
            dataconnect.Open();
            cmd.Connection = dataconnect;
            cmd.CommandText = "INSERT INTO sys_orgutler( name, kisaltma, tehlike_derecesi_id) VALUES (@name, @kisaltma, @tehlike_derecesi_id  ); ";
            cmd.Parameters.AddWithValue("@name", orgutAdi);
            cmd.Parameters.AddWithValue("@kisaltma", kisaltma);
            cmd.Parameters.AddWithValue("@tehlike_derecesi_id", comboBox1.SelectedValue.ToString());


            cmd.ExecuteNonQuery();
            dataconnect.Close();
            MessageBox.Show("Kayıt işlemi başarılı");

        }

        private void ucOrgutEkle_Load(object sender, EventArgs e)
        {
            dereceDoldur();
        }
    }
}
