﻿using System;
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
    public partial class ucOlayAnaliz : UserControl
    {
        public ucOlayAnaliz()
        {
            InitializeComponent();
        }

        publicConnectionString connectionstring = new publicConnectionString();
        public void hedefGrubuDoldur()
        {
            String query = " select distinct id, name, description, priority from (SELECT distinct  id, name, description , priority , CAST( CAST (json_array_elements( hedef_tip) AS text) AS integer) as hedef_tip FROM sys_target_type where active =0 and deleted = 0 and id in (SELECT distinct  CAST(CAST (json_array_elements( hedef_tip) AS text) AS integer) as hedef_tip FROM sys_target_type where active =0 and deleted = 0  )    )  as swwww where priority > 0 order by priority , name";
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbHedefGrubu.DisplayMember = "name";
            cmbHedefGrubu.ValueMember = "id";
            cmbHedefGrubu.DataSource = ds.Tables[0];
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

        public void il()
        {
            String query = "SELECT  a.city_id AS id, a.name  AS name,  a.name_eng as description,   CASE (SELECT COUNT(z.id) FROM sys_borough z WHERE z.country_id = a.country_id)  WHEN 0 THEN false  ELSE true END AS kontrol   FROM sys_city a  WHERE a.active = 0 AND a.deleted = 0 and   a.language_id = 647 AND  a.country_id = 91 ORDER BY a.priority ASC, name ";
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            Cmbil.DisplayMember = "name";
            Cmbil.ValueMember = "id";
            Cmbil.DataSource = ds.Tables[0];
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
        public void silahliSilahsiz()
        {
            String query = "SELECT  first_group as id ,   description as name , description_eng as description ,   false as kontrol  FROM public.sys_specific_definitions  where main_group = 38 order by first_group";
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbSilahliSilahsiz.DisplayMember = "name";
            cmbSilahliSilahsiz.ValueMember = "id";
            cmbSilahliSilahsiz.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        public void spexecute()
        {
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlCommand cmd = new NpgsqlCommand();
            NpgsqlDataReader reader;
            cmd.CommandText = "oki_temp_gisdata_gerceklesmis_olaylar()";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = dataconnect;
            dataconnect.Open();
            reader = cmd.ExecuteReader();
            dataconnect.Close();

        }
        public void truncateTable()
        {
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            string sqlTrunc = "TRUNCATE TABLE public.info_params_olay ";
            NpgsqlCommand cmd = new NpgsqlCommand(sqlTrunc, dataconnect);
            dataconnect.Open();
            cmd.ExecuteNonQuery();
            dataconnect.Close();

        }
        private void ucOlayAnaliz_Load(object sender, EventArgs e)
        {
         
            hedefGrubuDoldur();
            hedefTipiDoldur();

            OlayTipiDoldur();
            il();
            orgut();
            silahliSilahsiz();
        }
        public void degerEkle()
        {
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            truncateTable();

            dataconnect.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = dataconnect;
            int yil = 0;
            int ay = 0;
            string deger = cmbHedefGrubu.SelectedValue.ToString();
            string deger2 = cmbHedefTipi.SelectedValue.ToString();
            string deger3 = "0";
            string deger4 = cmbOlayTipi.SelectedValue.ToString();
            string deger5 = Cmbil.SelectedValue.ToString();
            string deger6 = cmbOrgut.SelectedValue.ToString();
            string deger7 = cmbSilahliSilahsiz.SelectedValue.ToString();
  
            cmd.CommandText = "insert into public.info_params_olay (combobox1_id, combobox2_id , combobox3_id , combobox4_id , combobox5_id , combobox6_id , combobox7_id,  tarih1, tarih2 ) values ( @combobox1_id, @combobox2_id , @combobox3_id , @combobox4_id , @combobox5_id , @combobox6_id , @combobox7_id ,  @tarih1, @tarih2) ";
            cmd.Parameters.AddWithValue("@combobox1_id", cmbHedefGrubu.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@combobox2_id", cmbHedefTipi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@combobox3_id", deger3);
            cmd.Parameters.AddWithValue("@combobox4_id", cmbOlayTipi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@combobox5_id", Cmbil.SelectedValue.ToString() );
            cmd.Parameters.AddWithValue("@combobox6_id", cmbOrgut.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@combobox7_id", cmbSilahliSilahsiz.SelectedValue.ToString());

            cmd.Parameters.AddWithValue("@tarih1", date1.Value.Date);
            cmd.Parameters.AddWithValue("@tarih2", date2.Value.Date);
            cmd.ExecuteNonQuery();
            dataconnect.Close();

            spexecute();
        }
        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            degerEkle();
            MessageBox.Show("Analiz Tamamlandı Sonuçları Harita ekranından görebilir Rapor ekranından raporlaya bilirsiniz !", "Uyarı");
        }
    }
}
