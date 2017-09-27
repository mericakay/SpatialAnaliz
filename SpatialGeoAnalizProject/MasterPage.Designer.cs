namespace SpatialGeoAnalizProject
{
    partial class MasterPage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterPage));
            this.tabMain = new System.Windows.Forms.TabControl();
            this.ilImages = new System.Windows.Forms.ImageList(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accordion1 = new Opulos.Core.UI.Accordion();
            this.tabMain.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPage2);
            this.tabMain.Location = new System.Drawing.Point(197, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(833, 606);
            this.tabMain.TabIndex = 0;
            // 
            // ilImages
            // 
            this.ilImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilImages.ImageStream")));
            this.ilImages.TransparentColor = System.Drawing.Color.Transparent;
            this.ilImages.Images.SetKeyName(0, "data-512.png");
            this.ilImages.Images.SetKeyName(1, "20151112_5643eb9384ea9.png");
            this.ilImages.Images.SetKeyName(2, "maps-icon.png");
            this.ilImages.Images.SetKeyName(3, "raporicon.png");
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::SpatialGeoAnalizProject.Properties.Resources.background_home;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Spatial Analiz Project";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpatialGeoAnalizProject.Properties.Resources.sinerjilogo_fw;
            this.pictureBox1.Location = new System.Drawing.Point(213, 155);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // accordion1
            // 
            this.accordion1.AddResizeBars = true;
            this.accordion1.AllowMouseResize = true;
            this.accordion1.AnimateCloseEffect = ((Opulos.Core.UI.AnimateWindowFlags)(((Opulos.Core.UI.AnimateWindowFlags.VerticalNegative | Opulos.Core.UI.AnimateWindowFlags.Hide) 
            | Opulos.Core.UI.AnimateWindowFlags.Slide)));
            this.accordion1.AnimateCloseMillis = 300;
            this.accordion1.AnimateOpenEffect = ((Opulos.Core.UI.AnimateWindowFlags)(((Opulos.Core.UI.AnimateWindowFlags.VerticalPositive | Opulos.Core.UI.AnimateWindowFlags.Show) 
            | Opulos.Core.UI.AnimateWindowFlags.Slide)));
            this.accordion1.AnimateOpenMillis = 300;
            this.accordion1.AutoFixDockStyle = true;
            this.accordion1.AutoScroll = true;
            this.accordion1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.accordion1.CheckBoxFactory = null;
            this.accordion1.CheckBoxMargin = new System.Windows.Forms.Padding(0);
            this.accordion1.ContentBackColor = null;
            this.accordion1.ContentMargin = null;
            this.accordion1.ContentPadding = new System.Windows.Forms.Padding(5);
            this.accordion1.ControlBackColor = null;
            this.accordion1.ControlMinimumHeightIsItsPreferredHeight = true;
            this.accordion1.ControlMinimumWidthIsItsPreferredWidth = true;
            this.accordion1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordion1.DownArrow = null;
            this.accordion1.FillHeight = true;
            this.accordion1.FillLastOpened = false;
            this.accordion1.FillModeGrowOnly = false;
            this.accordion1.FillResetOnCollapse = false;
            this.accordion1.FillWidth = true;
            this.accordion1.GrabCursor = System.Windows.Forms.Cursors.SizeNS;
            this.accordion1.GrabRequiresPositiveFillWeight = true;
            this.accordion1.GrabWidth = 6;
            this.accordion1.GrowAndShrink = true;
            this.accordion1.Insets = new System.Windows.Forms.Padding(0);
            this.accordion1.Location = new System.Drawing.Point(0, 0);
            this.accordion1.Name = "accordion1";
            this.accordion1.OpenOnAdd = false;
            this.accordion1.OpenOneOnly = false;
            this.accordion1.ResizeBarFactory = null;
            this.accordion1.ResizeBarsAlign = 0.5D;
            this.accordion1.ResizeBarsArrowKeyDelta = 10;
            this.accordion1.ResizeBarsFadeInMillis = 800;
            this.accordion1.ResizeBarsFadeOutMillis = 800;
            this.accordion1.ResizeBarsFadeProximity = 24;
            this.accordion1.ResizeBarsFill = 1D;
            this.accordion1.ResizeBarsKeepFocusAfterMouseDrag = false;
            this.accordion1.ResizeBarsKeepFocusIfControlOutOfView = true;
            this.accordion1.ResizeBarsKeepFocusOnClick = true;
            this.accordion1.ResizeBarsMargin = null;
            this.accordion1.ResizeBarsMinimumLength = 50;
            this.accordion1.ResizeBarsStayInViewOnArrowKey = true;
            this.accordion1.ResizeBarsStayInViewOnMouseDrag = true;
            this.accordion1.ResizeBarsStayVisibleIfFocused = true;
            this.accordion1.ResizeBarsTabStop = true;
            this.accordion1.ShowPartiallyVisibleResizeBars = false;
            this.accordion1.ShowToolMenu = true;
            this.accordion1.ShowToolMenuOnHoverWhenClosed = false;
            this.accordion1.ShowToolMenuOnRightClick = true;
            this.accordion1.ShowToolMenuRequiresPositiveFillWeight = false;
            this.accordion1.Size = new System.Drawing.Size(191, 617);
            this.accordion1.TabIndex = 1;
            this.accordion1.UpArrow = null;
            // 
            // MasterPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 617);
            this.Controls.Add(this.accordion1);
            this.Controls.Add(this.tabMain);
            this.Name = "MasterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spatial Analiz Project";
            this.Load += new System.EventHandler(this.MasterPage_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPage2;
        private Opulos.Core.UI.Accordion accordion1;
        private System.Windows.Forms.ImageList ilImages;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}