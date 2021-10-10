
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
            ((System.ComponentModel.ISupportInitialize)(this.txtWallPaperInterval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinPeriod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPlayMusic.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(311, 67);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(203, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Wallpaper switching time:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(219, 135);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(301, 25);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Minimum number of periods to crawl:";
            // 
            // txtWallPaperInterval
            // 
            this.txtWallPaperInterval.Location = new System.Drawing.Point(539, 62);
            this.txtWallPaperInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWallPaperInterval.Name = "txtWallPaperInterval";
            this.txtWallPaperInterval.Size = new System.Drawing.Size(143, 32);
            this.txtWallPaperInterval.TabIndex = 2;
            // 
            // txtMinPeriod
            // 
            this.txtMinPeriod.Location = new System.Drawing.Point(539, 130);
            this.txtMinPeriod.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMinPeriod.Name = "txtMinPeriod";
            this.txtMinPeriod.Size = new System.Drawing.Size(143, 32);
            this.txtMinPeriod.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(414, 293);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(107, 38);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(427, 198);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(87, 25);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Play music:";
            // 
            // checkPlayMusic
            // 
            this.checkPlayMusic.Location = new System.Drawing.Point(539, 198);
            this.checkPlayMusic.Name = "checkPlayMusic";
            this.checkPlayMusic.Properties.Caption = "";
            this.checkPlayMusic.Size = new System.Drawing.Size(112, 25);
            this.checkPlayMusic.TabIndex = 6;
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 478);
            this.Controls.Add(this.checkPlayMusic);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtMinPeriod);
            this.Controls.Add(this.txtWallPaperInterval);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frmConfig.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.Name = "frmConfig";
            this.Text = "frmConfig";
            this.Load += new System.EventHandler(this.frmConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtWallPaperInterval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMinPeriod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkPlayMusic.Properties)).EndInit();
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
    }
}