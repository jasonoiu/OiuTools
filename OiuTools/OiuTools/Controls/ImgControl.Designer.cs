
namespace OiuTools.Controls
{
    partial class ImgControl
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
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.pic = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pic.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.Appearance.Options.UseTextOptions = true;
            this.lblName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lblName.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblName.AutoEllipsis = true;
            this.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.lblName.Location = new System.Drawing.Point(0, 272);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(178, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "App Name";
            this.lblName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FolderView_Click);
            this.lblName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FolderView_MouseDoubleClick);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(3, 3);
            this.pic.Name = "pic";
            this.pic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic.Properties.ShowMenu = false;
            this.pic.Size = new System.Drawing.Size(175, 263);
            this.pic.TabIndex = 2;
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FolderView_Click);
            this.pic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FolderView_MouseDoubleClick);
            // 
            // ImgControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pic);
            this.Name = "ImgControl";
            this.Size = new System.Drawing.Size(178, 300);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FolderView_Click);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FolderView_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pic.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.PictureEdit pic;
    }
}
