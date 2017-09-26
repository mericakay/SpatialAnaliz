using Opulos.Core.UI;
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
    public partial class MasterPage : Form
    {
        public MasterPage()
        {
            InitializeComponent();
            InitializeMenu();
        }
        public void InitializeMenu()
        {
            // Meriç AKAY Accordion Menü button ve diğer ayarlar buradan yapılır
            accordion1.Controls.Clear();
            List<CheckBox> checkboxList = new List<CheckBox>();
            UserControl definitions = null;
            definitions = new UserControl()
            {
                Dock = DockStyle.Fill,
                Controls = {
                }
            };

            //Analizler Başlangıç

            Button btnParametre = new Button { Text = "      Analizler", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 1, BackColor = Color.FromArgb(246, 246, 246) };
            btnParametre.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Analizler");
                ucParametre control = new ucParametre();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);
            };
            Button btnOlayAnaliz = new Button { Text = "      Gerçekleşmiş Olaylar", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 1, BackColor = Color.FromArgb(246, 246, 246) };
            btnOlayAnaliz.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Gerçekleşmiş Olaylar");
                ucOlayAnaliz control = new ucOlayAnaliz();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);
            };
            var tanimlar = new UserControl()
            {
                Dock = DockStyle.Fill,
                Controls = {
                   btnParametre,
                   btnOlayAnaliz
                   }
            };
       checkboxList.Add(accordion1.Add(tanimlar, "Analizler"));

            //Analizler  Bitti

            //data Başlangıç

            Button btnOrgut = new Button { Text = "      Örgüt Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnOrgut.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Örgüt Ekle");
                ucOrgutEkle control = new ucOrgutEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);


            };
            Button btnOlay = new Button { Text = "      Olay Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnOlay.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Olay Ekle");
                ucOlayEkle control = new ucOlayEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);


            };
            Button btnOrgutElemani = new Button { Text = "      Örgüt Elemanı Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnOrgutElemani.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Örgüt Elemanı Ekle");
                ucOrgutElemaniEkle control = new ucOrgutElemaniEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);


            };
            Button btnSecim = new Button { Text = "      Seçim Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnSecim.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Seçim Ekle");
                ucSecimEkle control = new ucSecimEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);


            };
            Button btnSiyasiparti = new Button { Text = "      Siyasi Parti Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnSiyasiparti.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Siyasi Parti Ekle");
                ucSiyasiPartiEkle control = new ucSiyasiPartiEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);


            };
            Button btnNufusBilgisi = new Button { Text = "      Nüfus Bilgisi Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnNufusBilgisi.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Nüfus Bilgisi Ekle");
                ucNufusBilgisiEkle control = new ucNufusBilgisiEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);


            };
            Button btnMutluluk = new Button { Text = "      Mutluluk Oranı Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnMutluluk.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Mutluluk Oranı Ekle");
                ucMutlulukEkle control = new ucMutlulukEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);
            };

            Button btnMuhimmat = new Button { Text = "      Mühimmat Bilgisi Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnMuhimmat.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Muhimmat Bilgisi Ekle");
                ucMuhimmatEkle control = new ucMuhimmatEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);
            };

            Button btnKorucu = new Button { Text = "      Korucu Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnKorucu.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Korucu Ekle");
                ucKorucuEkle control = new ucKorucuEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);


            };

            Button btnIssizlik = new Button { Text = "      İşsizlik Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnIssizlik.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("İşsizlik Ekle");
                ucIssizlikEkle control = new ucIssizlikEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);


            };
            Button btnHedefGrubu = new Button { Text = "      Hedef Grubu Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnHedefGrubu.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Siyasi Parti Ekle");
                ucHedefGrubuEkle control = new ucHedefGrubuEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);


            };
            Button btnHedef = new Button { Text = "      Hedef Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnHedef.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Hedef Ekle");
                ucHedefEkle control = new ucHedefEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);


            };
            Button btnGocHizi = new Button { Text = "      Göç Hızı Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnGocHizi.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Göç Hızı Ekle");
                ucGocHiziEkle control = new ucGocHiziEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);


            };
            Button btnBilgi = new Button { Text = "      Bilgi Ekle", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 0, BackColor = Color.FromArgb(246, 246, 246) };
            btnBilgi.Click += delegate (object sender, EventArgs e)
            {
                tabMain.TabPages.Clear();
                TabPage page = new TabPage("Bilgi Ekle");
                ucBilgiEkle control = new ucBilgiEkle();
                control.Dock = DockStyle.Fill;
                page.Controls.Add(control);
                tabMain.TabPages.Add(page);


            };
            var data = new UserControl()
            {
                Dock = DockStyle.Fill,
                Controls = {
                   btnOrgut,
                   btnOlay,
                   btnOrgutElemani,
                   btnSecim,
                   btnSiyasiparti,
                   btnNufusBilgisi,
                   btnMutluluk,
                   btnMuhimmat,
                   btnKorucu,
                   btnIssizlik,
                   btnHedefGrubu,
                   btnHedef,
                   btnGocHizi,
                   btnBilgi

                   }
            };
            checkboxList.Add(accordion1.Add(data, "Data Ekle"));

            //Data  Bitti
            //Harita Başlangıç
            Button btnHarita = new Button { Text = "      Harita Aç", AutoSize = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 2, BackColor = Color.FromArgb(246, 246, 246) };
            btnHarita.Click += delegate (object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start(@"http://localhost:8081/mapstore/#/viewer/leaflet/0");


            };
            var harita = new UserControl()
            {
                Dock = DockStyle.Fill,
                Controls = {
                  btnHarita
                   }
            };
            checkboxList.Add(accordion1.Add(harita, "Harita Uygulaması"));
            // Harita Bitti

            //Rapor Başlangıç
            Button btnRapor = new Button { Text = "      Rapor Al", AutoSize = false, Enabled = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 3, BackColor = Color.FromArgb(246, 246, 246) };
            btnRapor.Click += delegate (object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start(@"C:\raportest\ssss.pdf");
            };
            var rapor = new UserControl()
            {
                Dock = DockStyle.Fill,
                Controls = {
                  btnRapor
                   }
            };
            checkboxList.Add(accordion1.Add(rapor, "Raporlar"));
            //Raporlar Bitti
            //Advanced Analysis Başlangıç
            Button btnSonar = new Button { Text = "      Social Media Analysis", AutoSize = false, Enabled = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 3, BackColor = Color.FromArgb(246, 246, 246) };
            btnSonar.Click += delegate (object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start(@"C:\raportest\ssss.pdf");
            };
            Button btnAdvanced = new Button { Text = "      Advanced Analysis", AutoSize = false, Enabled = false, TextImageRelation = TextImageRelation.ImageBeforeText, ImageAlign = ContentAlignment.MiddleLeft, TextAlign = ContentAlignment.MiddleRight, BackgroundImageLayout = ImageLayout.Center, Size = new Size(50, 27), Dock = DockStyle.Top, ImageList = ilImages, ImageIndex = 3, BackColor = Color.FromArgb(246, 246, 246) };
            btnAdvanced.Click += delegate (object sender, EventArgs e)
            {
                System.Diagnostics.Process.Start(@"C:\raportest\ssss.pdf");
            };
            var sosyal = new UserControl()
            {
                Dock = DockStyle.Fill,
                Controls = {
                  btnSonar,
                  btnAdvanced
                   }
            };
            checkboxList.Add(accordion1.Add(sosyal, "Advanced Media Analysis"));
            //Raporlar Bitti
            // Menu Sonu
            accordion1.Open(tanimlar,data,harita,rapor,sosyal);
        }

        private void MasterPage_Load(object sender, EventArgs e)
        {

        }
    }
}
