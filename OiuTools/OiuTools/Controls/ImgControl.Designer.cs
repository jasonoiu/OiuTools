
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.pic = new DevExpress.XtraEditors.PictureEdit();
            this.popFolderMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barAddToWallPaperList = new DevExpress.XtraBars.BarButtonItem();
            this.barAddToNewWallPaperList = new DevExpress.XtraBars.BarButtonItem();
            this.barRemoveFromWallPaper = new DevExpress.XtraBars.BarButtonItem();
            this.barRescan = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSetAsCover = new DevExpress.XtraBars.BarButtonItem();
            this.barSetBestLoveMM = new DevExpress.XtraBars.BarButtonItem();
            this.popImgMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barSetasWallpaper = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.pic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popFolderMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popImgMenu)).BeginInit();
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
            this.lblName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.lblName.Location = new System.Drawing.Point(4, 228);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 21);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "App Name";
            this.lblName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FolderView_Click);
            this.lblName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FolderView_MouseDoubleClick);
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(4, 4);
            this.pic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pic.Name = "pic";
            this.pic.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic.Properties.ShowMenu = false;
            this.pic.Size = new System.Drawing.Size(157, 221);
            this.pic.TabIndex = 2;
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FolderView_Click);
            this.pic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FolderView_MouseDoubleClick);
            // 
            // popFolderMenu
            // 
            this.popFolderMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barAddToWallPaperList),
            new DevExpress.XtraBars.LinkPersistInfo(this.barAddToNewWallPaperList),
            new DevExpress.XtraBars.LinkPersistInfo(this.barRemoveFromWallPaper),
            new DevExpress.XtraBars.LinkPersistInfo(this.barRescan)});
            this.popFolderMenu.Manager = this.barManager1;
            this.popFolderMenu.Name = "popFolderMenu";
            // 
            // barAddToWallPaperList
            // 
            this.barAddToWallPaperList.Caption = "Add To WallPaper List";
            this.barAddToWallPaperList.Id = 0;
            this.barAddToWallPaperList.Name = "barAddToWallPaperList";
            this.barAddToWallPaperList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barAddToWallPaperList_ItemClick);
            // 
            // barAddToNewWallPaperList
            // 
            this.barAddToNewWallPaperList.Caption = "Add To New WallPaperList";
            this.barAddToNewWallPaperList.Id = 2;
            this.barAddToNewWallPaperList.Name = "barAddToNewWallPaperList";
            this.barAddToNewWallPaperList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barAddToNewWallPaperList_ItemClick);
            // 
            // barRemoveFromWallPaper
            // 
            this.barRemoveFromWallPaper.Caption = "Remove From WallPaper";
            this.barRemoveFromWallPaper.Id = 1;
            this.barRemoveFromWallPaper.Name = "barRemoveFromWallPaper";
            this.barRemoveFromWallPaper.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRemoveFromWallPaper_ItemClick);
            // 
            // barRescan
            // 
            this.barRescan.Caption = "Rescan";
            this.barRescan.Id = 5;
            this.barRescan.Name = "barRescan";
            this.barRescan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRescan_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barAddToWallPaperList,
            this.barRemoveFromWallPaper,
            this.barAddToNewWallPaperList,
            this.barSetAsCover,
            this.barSetBestLoveMM,
            this.barRescan,
            this.barSetasWallpaper});
            this.barManager1.MaxItemId = 7;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(166, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 275);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(166, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 275);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(166, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 275);
            // 
            // barSetAsCover
            // 
            this.barSetAsCover.Caption = "Set as Cover";
            this.barSetAsCover.Id = 3;
            this.barSetAsCover.Name = "barSetAsCover";
            this.barSetAsCover.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSetAsCover_ItemClick);
            // 
            // barSetBestLoveMM
            // 
            this.barSetBestLoveMM.Caption = "Set BestLoveMM";
            this.barSetBestLoveMM.Id = 4;
            this.barSetBestLoveMM.Name = "barSetBestLoveMM";
            this.barSetBestLoveMM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSetBestLoveMM_ItemClick);
            // 
            // popImgMenu
            // 
            this.popImgMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSetAsCover),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSetBestLoveMM),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSetasWallpaper)});
            this.popImgMenu.Manager = this.barManager1;
            this.popImgMenu.Name = "popImgMenu";
            // 
            // barSetasWallpaper
            // 
            this.barSetasWallpaper.Caption = "Set as Wallpaper";
            this.barSetasWallpaper.Id = 6;
            this.barSetasWallpaper.Name = "barSetasWallpaper";
            this.barSetasWallpaper.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSetasWallpaper_ItemClick);
            // 
            // ImgControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ImgControl";
            this.Size = new System.Drawing.Size(166, 275);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FolderView_Click);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FolderView_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.pic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popFolderMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popImgMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblName;
        private DevExpress.XtraEditors.PictureEdit pic;
        private DevExpress.XtraBars.PopupMenu popFolderMenu;
        private DevExpress.XtraBars.BarButtonItem barAddToWallPaperList;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barRemoveFromWallPaper;
        private DevExpress.XtraBars.BarButtonItem barAddToNewWallPaperList;
        private DevExpress.XtraBars.BarButtonItem barSetAsCover;
        private DevExpress.XtraBars.PopupMenu popImgMenu;
        private DevExpress.XtraBars.BarButtonItem barSetBestLoveMM;
        private DevExpress.XtraBars.BarButtonItem barRescan;
        private DevExpress.XtraBars.BarButtonItem barSetasWallpaper;
    }
}
