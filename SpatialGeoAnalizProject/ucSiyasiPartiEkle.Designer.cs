namespace SpatialGeoAnalizProject
{
    partial class ucSiyasiPartiEkle
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
            this.txtKisaltma = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(61, 89);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(160, 20);
            this.txtAdi.TabIndex = 0;
            this.txtAdi.Text = "Siyasi Parti Adı";
            // 
            // txtKisaltma
            // 
            this.txtKisaltma.Location = new System.Drawing.Point(61, 136);
            this.txtKisaltma.Name = "txtKisaltma";
            this.txtKisaltma.Size = new System.Drawing.Size(160, 20);
            this.txtKisaltma.TabIndex = 1;
            this.txtKisaltma.Text = "Kısaltması";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(145, 180);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(76, 56);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // ucSiyasiPartiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpatialGeoAnalizProject.Properties.Resources.background_home;
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtKisaltma);
            this.Controls.Add(this.txtAdi);
            this.Name = "ucSiyasiPartiEkle";
            this.Size = new System.Drawing.Size(582, 427);
            this.Load += new System.EventHandler(this.ucSiyasiPartiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtKisaltma;
        private System.Windows.Forms.Button btnEkle;
    }
}
