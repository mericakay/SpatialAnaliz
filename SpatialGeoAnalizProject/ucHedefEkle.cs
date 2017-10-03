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
using Newtonsoft;

namespace SpatialGeoAnalizProject
{
    public partial class ucHedefEkle : UserControl
    {
        public ucHedefEkle()
        {
            InitializeComponent();
        }
        publicConnectionString connectionstring = new publicConnectionString();
        private void ucHedefEkle_Load(object sender, EventArgs e)
        {
            tehlikederece();
            hedefGrubuDoldur();
        }
        public void tehlikederece()
        {
            String query = "SELECT first_group,  description  FROM sys_specific_definitions where main_group = 42 order by first_group";
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, dataconnect);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataconnect.Open();
            cmbDerece.DisplayMember = "description";
            cmbDerece.ValueMember = "first_group";
            cmbDerece.DataSource = ds.Tables[0];
            dataconnect.Close();

        }
        public void hedefGrubuDoldur()
        {
            String query = " select distinct id, name, description, priority from (SELECT distinct  id, name, description , priority , CAST( CAST (json_array_elements( hedef_tip) AS text) AS integer) as hedef_tip FROM sys_target_type where active =0 and deleted = 0 and id in (SELECT distinct  CAST(CAST (json_array_elements( hedef_tip) AS text) AS integer) as hedef_tip FROM sys_target_type where active =0 and deleted = 0  )    )  as swwww where priority > 0 order by priority , name";
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
        private void btnEkle_Click(object sender, EventArgs e)
        {
            /*int dd = Convert.ToInt32(cmbHedefTipi.SelectedValue.ToString());
            int aa = 1;
            var example1 = @"{""0"":"+aa+","""1"":"+dd+"}";
            string hehe = "(SELECT array_to_json(COALESCE(NULLIF(cxx, '{}'), NULL)) FROM(SELECT ARRAY( SELECT CAST(CAST(VALUE AS text) AS integer) FROM json_each('"+example1+"')) AS cxx) AS zxtable )";

            string hedefAdi = txtAdi.Text.ToString();
            string Aciklama = richtxtAciklama.Text.ToString();
            //int derece = comboBox1.SelectedValue.ToString();
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlCommand cmd = new NpgsqlCommand();
            dataconnect.Open();
            cmd.Connection = dataconnect;
            cmd.CommandText = "INSERT INTO public.sys_target_type( name, description, hedef_tip,  derece) VALUES (@name, @description, @hedef_tip,  @derece ); ";
            cmd.Parameters.AddWithValue("@name", hedefAdi);
            cmd.Parameters.AddWithValue("@description", Aciklama);
            cmd.Parameters.AddWithValue("@hedef_tip", cmbHedefTipi.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@derece", hehe);
            cmd.ExecuteNonQuery();
            dataconnect.Close();
            MessageBox.Show("Kayıt işlemi başarılı");*/
        }
    }
}
