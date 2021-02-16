
namespace OiuTools.Controls
{
    partial class SingleApp
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
            this.pic = new DevExpress.XtraEditors.PictureEdit();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pic.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(3, 3);
            this.pic.Name = "pic";
            this.pic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic.Properties.ShowMenu = false;
            this.pic.Size = new System.Drawing.Size(60, 60);
            this.pic.TabIndex = 0;
            this.pic.Click += new System.EventHandler(this.SingleApp_Click);
            // 
            // lblName
            // 
            this.lblName.Appearance.Options.UseTextOptions = true;
            this.lblName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblName.AutoEllipsis = true;
            this.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.lblName.Location = new System.Drawing.Point(3, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(57, 34);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "App Name";
            this.lblName.Click += new System.EventHandler(this.SingleApp_Click);
            // 
            // SingleApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pic);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SingleApp";
            this.Size = new System.Drawing.Size(67, 101);
            ((System.ComponentModel.ISupportInitialize)(this.pic.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pic;
        private DevExpress.XtraEditors.LabelControl lblName;
    }
}
