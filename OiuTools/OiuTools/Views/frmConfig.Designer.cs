
namespace OiuTools.Views
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtWallPaperInterval = new DevExpress.XtraEditors.TextEdit();
            this.txtMinPeriod = new DevExpress.XtraEditors.TextEdit();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checkPlayMusic = new DevExpress.XtraEditors.CheckEdit();
            this.txtExtraMinPeriod = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtWallPaperInterval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPlayMusic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtraMinPeriod.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(280, 56);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(179, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Wallpaper switching time:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(197, 113);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(263, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Minimum number of periods to crawl:";
            // 
            // txtWallPaperInterval
            // 
            this.txtWallPaperInterval.Location = new System.Drawing.Point(485, 52);
            this.txtWallPaperInterval.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWallPaperInterval.Name = "txtWallPaperInterval";
            this.txtWallPaperInterval.Size = new System.Drawing.Size(129, 28);
            this.txtWallPaperInterval.TabIndex = 2;
            // 
            // txtMinPeriod
            // 
            this.txtMinPeriod.Location = new System.Drawing.Point(485, 109);
            this.txtMinPeriod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMinPeriod.Name = "txtMinPeriod";
            this.txtMinPeriod.Size = new System.Drawing.Size(129, 28);
            this.txtMinPeriod.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(364, 308);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 32);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(375, 228);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 21);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Play music:";
            // 
            // checkPlayMusic
            // 
            this.checkPlayMusic.Location = new System.Drawing.Point(476, 228);
            this.checkPlayMusic.Name = "checkPlayMusic";
            this.checkPlayMusic.Properties.Caption = "";
            this.checkPlayMusic.Size = new System.Drawing.Size(101, 25);
            this.checkPlayMusic.TabIndex = 6;
            // 
            // txtExtraMinPeriod
            // 
            this.txtExtraMinPeriod.Location = new System.Drawing.Point(485, 161);
            this.txtExtraMinPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.txtExtraMinPeriod.Name = "txtExtraMinPeriod";
            this.txtExtraMinPeriod.Size = new System.Drawing.Size(129, 28);
            this.txtExtraMinPeriod.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(336, 164);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(124, 21);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Extra Min Periods:";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 402);
            this.Controls.Add(this.txtExtraMinPeriod);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.checkPlayMusic);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMinPeriod);
            this.Controls.Add(this.txtWallPaperInterval);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmConfig.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "frmConfig";
            this.Text = "frmConfig";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtWallPaperInterval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPlayMusic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtExtraMinPeriod.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtWallPaperInterval;
        private DevExpress.XtraEditors.TextEdit txtMinPeriod;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.CheckEdit checkPlayMusic;
        private DevExpress.XtraEditors.TextEdit txtExtraMinPeriod;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}