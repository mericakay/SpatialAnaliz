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
    public partial class ucSiyasiPartiEkle : UserControl
    {
        public ucSiyasiPartiEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string partiAdi = txtAdi.Text.ToString();
            string kisaltma = txtKisaltma.Text.ToString();
            //int derece = comboBox1.SelectedValue.ToString();
            NpgsqlConnection dataconnect = new NpgsqlConnection(
           "Server=192.168.1.47;Port=5432;User Id=postgres;Password=postgres;Database=dd");
            NpgsqlCommand cmd = new NpgsqlCommand();
            dataconnect.Open();
            cmd.Connection = dataconnect;
            cmd.CommandText = "INSERT INTO public.sys_partiler( name, kisaltma) VALUES (@name, @kisaltma ); ";
            cmd.Parameters.AddWithValue("@name", partiAdi);
            cmd.Parameters.AddWithValue("@kisaltma", kisaltma);
           


            cmd.ExecuteNonQuery();
            dataconnect.Close();
            MessageBox.Show("Kayıt işlemi başarılı");
        }
    }
}
