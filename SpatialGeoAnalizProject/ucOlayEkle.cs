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
    public partial class ucOlayEkle : UserControl
    {
        public ucOlayEkle()
        {
            InitializeComponent();
        }
        publicConnectionString connectionstring = new publicConnectionString();
        public void tehlikederece()
        {
            String query = "SELECT first_group,  description  FROM sys_specific_definitions where main_group = 42 order by first_group";
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
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
            string hedefAdi = textBox1.Text.ToString();
            string Aciklama = richTextBox1.Text.ToString();
            
            NpgsqlConnection dataconnect = new NpgsqlConnection(connectionstring.connstring.ToString());
            NpgsqlCommand cmd = new NpgsqlCommand();
            dataconnect.Open();
            cmd.Connection = dataconnect;
            cmd.CommandText = "INSERT INTO public.sys_action_type( name, description, derece) VALUES (@name, @description, @derece ); ";
            cmd.Parameters.AddWithValue("@name", hedefAdi);
            cmd.Parameters.AddWithValue("@description", Aciklama);
            cmd.Parameters.AddWithValue("@derece", comboBox1.SelectedValue.ToString());
            
            cmd.ExecuteNonQuery();
            dataconnect.Close();
            MessageBox.Show("Kayıt işlemi başarılı");
        }

        private void ucOlayEkle_Load(object sender, EventArgs e)
        {
            tehlikederece();

        }
    }
}
