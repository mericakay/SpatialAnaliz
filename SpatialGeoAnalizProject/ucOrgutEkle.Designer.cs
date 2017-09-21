namespace SpatialGeoAnalizProject
{
    partial class ucOrgutEkle
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtkisaltma = new System.Windows.Forms.TextBox();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnEkle.Location = new System.Drawing.Point(127, 151);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(139, 66);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 59);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(229, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // txtkisaltma
            // 
            this.txtkisaltma.Location = new System.Drawing.Point(37, 121);
            this.txtkisaltma.Margin = new System.Windows.Forms.Padding(4);
            this.txtkisaltma.Name = "txtkisaltma";
            this.txtkisaltma.Size = new System.Drawing.Size(229, 22);
            this.txtkisaltma.TabIndex = 2;
            this.txtkisaltma.Text = "Kısaltma";
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(37, 91);
            this.txtadi.Margin = new System.Windows.Forms.Padding(4);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(229, 22);
            this.txtadi.TabIndex = 1;
            this.txtadi.Text = "Örgüt Adı";
            // 
            // ucOrgutEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtkisaltma);
            this.Controls.Add(this.txtadi);
            this.Name = "ucOrgutEkle";
            this.Size = new System.Drawing.Size(330, 269);
            this.Load += new System.EventHandler(this.ucOrgutEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtkisaltma;
        private System.Windows.Forms.TextBox txtadi;
    }
}
