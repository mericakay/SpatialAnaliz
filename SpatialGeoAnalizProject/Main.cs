using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpatialGeoAnalizProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            NpgsqlConnection dataconnect = new NpgsqlConnection(
           "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=dd;");


            string query = "Select kullanic_adi from login where kullanic_adi = '"
               + txtKadi.Text.ToString() + "'" + " and sifre = '" + txtSifre.Text.ToString() + "'";
            dataconnect.Open();

            NpgsqlCommand command = new NpgsqlCommand(query, dataconnect);


            NpgsqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {

                MasterPage frm = new MasterPage();
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show(" Kullanıcı adı ya da Şifre Hatalı Lütfen Bilgileri Kontrol Ederek tekrar deneyiniz.");
            }
            reader.Close();
            dataconnect.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

