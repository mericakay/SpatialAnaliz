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
    public partial class ucGerceklesmisOlay : UserControl
    {
        public ucGerceklesmisOlay()
        {
            InitializeComponent();
        }
        publicConnectionString connectionstring = new publicConnectionString();
        public void il()
        {
            String query = "SELECT  a.city_id AS id, a.name  AS name,  a.name_eng as description,   CASE (SELECT COUNT(z.id) FROM sys_borough z WHERE z.country_id = a.country_id)  WHEN 0 THEN false  ELSE true END AS kontrol   FROM sys_city a  WHERE a.active = 0 AND a.deleted = 0 and   a.language_id = 647 AND  a.country_id = 91 ORDER BY a.priority ASC, name ";
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
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
            String query = "SELECT boroughs_id as id,   name, name_eng as description   , false AS kontrol  FROM public.sys_borough   where city_id = " + cmbil.SelectedValue + "   order by name";
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbilce.DisplayMember = "name";
            cmbilce.ValueMember = "id";
            cmbilce.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        public void orgut()
        {
            String query = "SELECT id, name, kisaltma as description , false as kontrol FROM  sys_orgutler where active =0 and deleted =0  order by priority , name  ";
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbOrgut.DisplayMember = "name";
            cmbOrgut.ValueMember = "id";
            cmbOrgut.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        public void OlayTipiDoldur()
        {
            String query = "SELECT id, name, description, false as kontrol   FROM sys_action_type  where active = 0 and deleted = 0   order by priority , name ";
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbOlayTipi.DisplayMember = "name";
            cmbOlayTipi.ValueMember = "id";
            cmbOlayTipi.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        public void hedefTipiDoldur()
        {
            String query = "SELECT distinct  id, name,   description ,priority FROM sys_target_type where active = 0 and deleted = 0  order by priority , name   ";
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbHedefTipi.DisplayMember = "name";
            cmbHedefTipi.ValueMember = "id";
            cmbHedefTipi.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        public void spexecute()
        {
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlCommand cmd = new NpgsqlCommand();
            NpgsqlDataReader reader;
            cmd.CommandText = "public.oki_temp_mericdata()";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = dataconnect;
            dataconnect.Open();
            reader = cmd.ExecuteReader();
            dataconnect.Close();

        }
        private void ucGerceklesmisOlay_Load(object sender, EventArgs e)
        {
            il();
            orgut();
            OlayTipiDoldur();
            hedefTipiDoldur();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string aciklama = rtxtAciklama.Text.ToString();
            string adet = "";
            if (txtOluSayisi.Text == "")
            {
                adet = "0";
            }
            else
            {
                adet = txtOluSayisi.Text.ToString();
            }
            string militan = "";
            if (txtMilitan.Text == "")
            {
                militan = "0";
            }
            else
            {
                militan = txtMilitan.Text.ToString();
            }
            int id;
            if (cmbilce.Text == "")
            {
                id = 0;
            }
            else
            {
                id = Convert.ToInt32(cmbilce.SelectedValue.ToString());
            }
            string adi = txtOlayTanimi.Text.ToString();
            var dateAndTime = DateTime.Now;
            var date = dateAndTime.Date;
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlCommand cmd = new NpgsqlCommand();
            dataconnect.Open();
            cmd.Connection = dataconnect;
            cmd.CommandText = "INSERT INTO public.info_olay(name, il_id, ilce_id, description,  orgut_id, olu_sayisi, oldurulen_orgutlu_sayisi,   olay_tarihi,   olay_m, hedef_m) VALUES ( @name, @il_id  , @ilce_id , @description , @orgut_id , @olu_sayisi , @oldurulen_orgutlu_sayisi , @olay_tarihi , @olay_m , @hedef_m ); ";
            cmd.Parameters.AddWithValue("@name", adi);       
            cmd.Parameters.AddWithValue("@il_id", cmbil.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@ilce_id", id);
            cmd.Parameters.AddWithValue("@description", aciklama);
             cmd.Parameters.AddWithValue("@orgut_id", cmbOrgut.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@olu_sayisi", adet);
            cmd.Parameters.AddWithValue("@oldurulen_orgutlu_sayisi", militan);
            cmd.Parameters.AddWithValue("@olay_tarihi", date);
            cmd.Parameters.AddWithValue("@olay_m", cmbOlayTipi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@hedef_m", cmbHedefTipi.SelectedValue.ToString());
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
