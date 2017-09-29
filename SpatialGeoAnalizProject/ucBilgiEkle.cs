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
    public partial class ucBilgiEkle : UserControl
    {
        public ucBilgiEkle()
        {
            InitializeComponent();
        }
        public void hedefAlani()
        {
            String query = "select s4.first_group , s4.description from  sys_specific_definitions s4 where s4.main_group = 46   and s4.active =0 and s4.deleted =0  ";
            NpgsqlConnection dataconnect = new NpgsqlConnection(
             "Server=78.187.120.6;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbHedefAlanlar.DisplayMember = "description";
            cmbHedefAlanlar.ValueMember = "first_group";
            cmbHedefAlanlar.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        public void  Bilgikaynak()
        {
            String query = " select s1.first_group , s1.description from  sys_specific_definitions s1 where  s1.main_group = 43  and   s1.active =0 and s1.deleted =0 order by s1.first_group  ";
            NpgsqlConnection dataconnect = new NpgsqlConnection(
             "Server=78.187.120.6;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbBilgikaynagi.DisplayMember = "description";
            cmbBilgikaynagi.ValueMember = "first_group";
            cmbBilgikaynagi.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        public void Hedefkaynak()
        {
            String query = "select s3.first_group , s3.description from  sys_specific_definitions s3 where s3.main_group = 45   and s3.active =0 and s3.deleted =0 ";
            NpgsqlConnection dataconnect = new NpgsqlConnection(
             "Server=78.187.120.6;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbKaynak.DisplayMember = "description";
            cmbKaynak.ValueMember = "first_group";
            cmbKaynak.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        public void mahiyet()
        {
            String query = "select s2.first_group , s2.description from  sys_specific_definitions s2 where s2.main_group = 44   and s2.active =0 and s2.deleted =0   ";
            NpgsqlConnection dataconnect = new NpgsqlConnection(
             "Server=78.187.120.6;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbMahiyet.DisplayMember = "description";
            cmbMahiyet.ValueMember = "first_group";
            cmbMahiyet.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        public void tehlikederece()
        {
            String query = "SELECT first_group,  description  FROM sys_specific_definitions where main_group = 42 order by first_group";
            NpgsqlConnection dataconnect = new NpgsqlConnection(
             "Server=78.187.120.6;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbDerece.DisplayMember = "description";
            cmbDerece.ValueMember = "first_group";
            cmbDerece.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        public void il()
        {
            String query = "SELECT  a.city_id AS id, a.name  AS name,  a.name_eng as description,   CASE (SELECT COUNT(z.id) FROM sys_borough z WHERE z.country_id = a.country_id)  WHEN 0 THEN false  ELSE true END AS kontrol   FROM sys_city a  WHERE a.active = 0 AND a.deleted = 0 and   a.language_id = 647 AND  a.country_id = 91 ORDER BY a.priority ASC, name ";
            NpgsqlConnection dataconnect = new NpgsqlConnection(
             "Server=78.187.120.6;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbil.DisplayMember = "name";
            cmbil.ValueMember = "id";
            cmbil.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        public void ilce()
        {
            String query = "SELECT boroughs_id as id,   name, name_eng as description   , false AS kontrol  FROM public.sys_borough   where city_id = "+cmbil.SelectedValue+"   order by name";
            NpgsqlConnection dataconnect = new NpgsqlConnection(
             "Server=78.187.120.6;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbilce.DisplayMember = "name";
            cmbilce.ValueMember = "id";
            cmbilce.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
           public void spexecute()
        {
            NpgsqlConnection dataconnect = new NpgsqlConnection(
             "Server=78.187.120.6;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlCommand cmd = new NpgsqlCommand();
            NpgsqlDataReader reader;
            cmd.CommandText = "oki_temp_insert_gis_istihbarat()";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = dataconnect;
            dataconnect.Open();
            reader = cmd.ExecuteReader();
            dataconnect.Close();

        }
        private void ucBilgiEkle_Load(object sender, EventArgs e)
        {
            il();
            tehlikederece();
            mahiyet();
            Bilgikaynak();
            hedefAlani();
            Hedefkaynak();
            orgut();


        }
        public void orgut()
        {
            String query = "SELECT id, name, kisaltma as description , false as kontrol FROM  sys_orgutler where active =0 and deleted =0  order by priority , name  ";
            NpgsqlConnection dataconnect = new NpgsqlConnection(
             "Server=78.187.120.6;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbOrgut.DisplayMember = "name";
            cmbOrgut.ValueMember = "id";
            cmbOrgut.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
       
       
        public void insert()
        {
          
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string aciklama = rtxtAciklama.Text.ToString();
            string adet = "";
            if (txtAdet.Text == "")
            {
                adet = "0";
            }
            else
            {
                adet = txtAdet.Text.ToString();
            }
           // string ilceid = "0";
            int id;
            if (cmbilce.Text == "")
            {
                id = 0;
            }
            else
            {
                    id = Convert.ToInt32(cmbilce.SelectedValue.ToString());
            }
            string adi = txtName.Text.ToString();
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            NpgsqlConnection dataconnect = new NpgsqlConnection(
           "Server=78.187.120.6;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlCommand cmd = new NpgsqlCommand();
            dataconnect.Open();
            cmd.Connection = dataconnect;
            cmd.CommandText = "INSERT INTO public.info_istihbarat( name, bilgi_kaynak_tipi, il_id, ilce_id, description, orgut_id, adet, olay_tarihi, derece, hedefin_kaynagi, faaliyetin_mahiyeti, hedef_alanlari) VALUES ( @name, @bilgi_kaynak_tipi, @il_id  , @ilce_id , @description , @orgut_id , @adet , @olay_tarihi , @derece , @hedefin_kaynagi , @faaliyetin_mahiyeti , @hedef_alanlari  ); ";
            cmd.Parameters.AddWithValue("@name", adi);
            cmd.Parameters.AddWithValue("@bilgi_kaynak_tipi", cmbBilgikaynagi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@il_id", cmbil.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@ilce_id", id);
            cmd.Parameters.AddWithValue("@description", aciklama);
            cmd.Parameters.AddWithValue("@orgut_id", cmbOrgut.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@adet", adet);
            cmd.Parameters.AddWithValue("@olay_tarihi", date);
            cmd.Parameters.AddWithValue("@derece", cmbDerece.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@hedefin_kaynagi", cmbKaynak.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@faaliyetin_mahiyeti", cmbMahiyet.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@hedef_alanlari", cmbHedefAlanlar.SelectedValue.ToString());
            cmd.ExecuteNonQuery();
            dataconnect.Close();
            spexecute();
            MessageBox.Show("Kayıt işlemi başarılı");
        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            ilce();
        }
    }
}
