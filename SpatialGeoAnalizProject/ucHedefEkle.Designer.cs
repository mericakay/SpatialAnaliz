namespace SpatialGeoAnalizProject
{
    partial class ucHedefEkle
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.richtxtAciklama = new System.Windows.Forms.RichTextBox();
            this.cmbHedefTipi = new System.Windows.Forms.ComboBox();
            this.cmbDerece = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(153, 49);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(200, 20);
            this.txtAdi.TabIndex = 0;
            // 
            // richtxtAciklama
            // 
            this.richtxtAciklama.Location = new System.Drawing.Point(153, 99);
            this.richtxtAciklama.Name = "richtxtAciklama";
            this.richtxtAciklama.Size = new System.Drawing.Size(200, 96);
            this.richtxtAciklama.TabIndex = 1;
            this.richtxtAciklama.Text = "";
            // 
            // cmbHedefTipi
            // 
            this.cmbHedefTipi.FormattingEnabled = true;
            this.cmbHedefTipi.Location = new System.Drawing.Point(153, 214);
            this.cmbHedefTipi.Name = "cmbHedefTipi";
            this.cmbHedefTipi.Size = new System.Drawing.Size(200, 21);
            this.cmbHedefTipi.TabIndex = 2;
            // 
            // cmbDerece
            // 
            this.cmbDerece.FormattingEnabled = true;
            this.cmbDerece.Location = new System.Drawing.Point(153, 258);
            this.cmbDerece.Name = "cmbDerece";
            this.cmbDerece.Size = new System.Drawing.Size(200, 21);
            this.cmbDerece.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hedef Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hedef Tipi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tehlike Derecesi";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(268, 300);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(85, 57);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ucHedefEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpatialGeoAnalizProject.Properties.Resources.background_home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDerece);
            this.Controls.Add(this.cmbHedefTipi);
            this.Controls.Add(this.richtxtAciklama);
            this.Controls.Add(this.txtAdi);
            this.Name = "ucHedefEkle";
            this.Size = new System.Drawing.Size(514, 508);
            this.Load += new System.EventHandler(this.ucHedefEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.RichTextBox richtxtAciklama;
        private System.Windows.Forms.ComboBox cmbHedefTipi;
        private System.Windows.Forms.ComboBox cmbDerece;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
    }
}
