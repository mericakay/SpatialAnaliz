namespace SpatialGeoAnalizProject
{
    partial class orgutEkle
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtadi = new System.Windows.Forms.TextBox();
            this.txtkisaltma = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(65, 48);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(151, 20);
            this.txtadi.TabIndex = 0;
            this.txtadi.Text = "Örgüt Adı";
            // 
            // txtkisaltma
            // 
            this.txtkisaltma.Location = new System.Drawing.Point(65, 93);
            this.txtkisaltma.Name = "txtkisaltma";
            this.txtkisaltma.Size = new System.Drawing.Size(151, 20);
            this.txtkisaltma.TabIndex = 0;
            this.txtkisaltma.Text = "Kısaltma";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(261, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Location = new System.Drawing.Point(297, 93);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(104, 54);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // orgutEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SpatialGeoAnalizProject.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 198);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtkisaltma);
            this.Controls.Add(this.txtadi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orgutEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "orgutEkle";
            this.Load += new System.EventHandler(this.orgutEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.TextBox txtkisaltma;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnEkle;
    }
}