namespace SpatialGeoAnalizProject
{
    partial class ucParametre
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.cmbiki = new System.Windows.Forms.ComboBox();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.btnanaliz = new System.Windows.Forms.Button();
            this.btnsonuc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbbir = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb1
            // 
            this.cmb1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(13, -31);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(270, 24);
            this.cmb1.TabIndex = 7;
            // 
            // cmbiki
            // 
            this.cmbiki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbiki.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbiki.FormattingEnabled = true;
            this.cmbiki.Location = new System.Drawing.Point(4, 88);
            this.cmbiki.Name = "cmbiki";
            this.cmbiki.Size = new System.Drawing.Size(248, 24);
            this.cmbiki.TabIndex = 8;
            // 
            // dgview
            // 
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Location = new System.Drawing.Point(3, 220);
            this.dgview.Name = "dgview";
            this.dgview.Size = new System.Drawing.Size(393, 194);
            this.dgview.TabIndex = 10;
            // 
            // btnanaliz
            // 
            this.btnanaliz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnanaliz.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanaliz.Location = new System.Drawing.Point(17, 161);
            this.btnanaliz.Name = "btnanaliz";
            this.btnanaliz.Size = new System.Drawing.Size(104, 48);
            this.btnanaliz.TabIndex = 9;
            this.btnanaliz.Text = "Parametre Ekle";
            this.btnanaliz.UseVisualStyleBackColor = true;
            this.btnanaliz.Click += new System.EventHandler(this.btnanaliz_Click);
            // 
            // btnsonuc
            // 
            this.btnsonuc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsonuc.Location = new System.Drawing.Point(148, 161);
            this.btnsonuc.Name = "btnsonuc";
            this.btnsonuc.Size = new System.Drawing.Size(104, 48);
            this.btnsonuc.TabIndex = 11;
            this.btnsonuc.Text = "Analiz";
            this.btnsonuc.UseVisualStyleBackColor = true;
            this.btnsonuc.Click += new System.EventHandler(this.btnsonuc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(502, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(160, 98);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Visible = false;
            // 
            // cmbbir
            // 
            this.cmbbir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbbir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbbir.FormattingEnabled = true;
            this.cmbbir.Location = new System.Drawing.Point(4, 54);
            this.cmbbir.Name = "cmbbir";
            this.cmbbir.Size = new System.Drawing.Size(248, 24);
            this.cmbbir.TabIndex = 16;
            this.cmbbir.SelectedIndexChanged += new System.EventHandler(this.cmbbir_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(324, 185);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 17;
            this.progressBar1.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(455, 43);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Olasılık";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // ucParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cmbbir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsonuc);
            this.Controls.Add(this.btnanaliz);
            this.Controls.Add(this.dgview);
            this.Controls.Add(this.cmbiki);
            this.Controls.Add(this.cmb1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ucParametre";
            this.Size = new System.Drawing.Size(780, 447);
            this.Load += new System.EventHandler(this.ucParametre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.ComboBox cmbiki;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.Button btnanaliz;
        private System.Windows.Forms.Button btnsonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbbir;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
