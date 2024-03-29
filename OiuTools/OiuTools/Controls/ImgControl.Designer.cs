﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImgControl));
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.pic = new DevExpress.XtraEditors.PictureEdit();
            this.popFolderMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barAddToWallPaperList = new DevExpress.XtraBars.BarButtonItem();
            this.barAddToNewWallPaperList = new DevExpress.XtraBars.BarButtonItem();
            this.barRemoveFromWallPaper = new DevExpress.XtraBars.BarButtonItem();
            this.barRescan = new DevExpress.XtraBars.BarButtonItem();
            this.barSetAllToLoveMM = new DevExpress.XtraBars.BarButtonItem();
            this.barDelFolder = new DevExpress.XtraBars.BarButtonItem();
            this.barDelAllMmPhoto = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSetAsCover = new DevExpress.XtraBars.BarButtonItem();
            this.barSetBestLoveMM = new DevExpress.XtraBars.BarButtonItem();
            this.barSetasWallpaper = new DevExpress.XtraBars.BarButtonItem();
            this.barUpload = new DevExpress.XtraBars.BarButtonItem();
            this.barMdiChildrenListItem1 = new DevExpress.XtraBars.BarMdiChildrenListItem();
            this.barPopMergeWallPaper = new DevExpress.XtraBars.BarSubItem();
            this.barFirstWallPaper = new DevExpress.XtraBars.BarButtonItem();
            this.barSecondWallPaper = new DevExpress.XtraBars.BarButtonItem();
            this.barPopAddToWpCollection = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItemTest = new DevExpress.XtraBars.BarButtonItem();
            this.popImgMenu = new DevExpress.XtraBars.PopupMenu(this.components);
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
            this.lblName.Margin = new System.Windows.Forms.Padding(4);
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
            this.pic.Margin = new System.Windows.Forms.Padding(4);
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barRescan),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSetAllToLoveMM),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDelFolder),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDelAllMmPhoto)});
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
            // barSetAllToLoveMM
            // 
            this.barSetAllToLoveMM.Caption = "Set All To LoveMM";
            this.barSetAllToLoveMM.Id = 8;
            this.barSetAllToLoveMM.Name = "barSetAllToLoveMM";
            this.barSetAllToLoveMM.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSetAllToLoveMM_ItemClick);
            // 
            // barDelFolder
            // 
            this.barDelFolder.Caption = "Del";
            this.barDelFolder.Id = 15;
            this.barDelFolder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barDelFolder.ImageOptions.SvgImage")));
            this.barDelFolder.Name = "barDelFolder";
            this.barDelFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDelFolder_ItemClick);
            // 
            // barDelAllMmPhoto
            // 
            this.barDelAllMmPhoto.Caption = "Del All MM Photo";
            this.barDelAllMmPhoto.Id = 16;
            this.barDelAllMmPhoto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barDelAllMmPhoto.ImageOptions.Image")));
            this.barDelAllMmPhoto.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barDelAllMmPhoto.ImageOptions.LargeImage")));
            this.barDelAllMmPhoto.Name = "barDelAllMmPhoto";
            this.barDelAllMmPhoto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDelAllMmPhoto_ItemClick);
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
            this.barSetasWallpaper,
            this.barUpload,
            this.barSetAllToLoveMM,
            this.barMdiChildrenListItem1,
            this.barPopMergeWallPaper,
            this.barFirstWallPaper,
            this.barSecondWallPaper,
            this.barPopAddToWpCollection,
            this.barButtonItemTest,
            this.barDelFolder,
            this.barDelAllMmPhoto});
            this.barManager1.MaxItemId = 17;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(166, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 275);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(166, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 275);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(166, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
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
            // barSetasWallpaper
            // 
            this.barSetasWallpaper.Caption = "Set as Wallpaper";
            this.barSetasWallpaper.Id = 6;
            this.barSetasWallpaper.Name = "barSetasWallpaper";
            this.barSetasWallpaper.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSetasWallpaper_ItemClick);
            // 
            // barUpload
            // 
            this.barUpload.Caption = "Upload";
            this.barUpload.Id = 7;
            this.barUpload.Name = "barUpload";
            this.barUpload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUpload_ItemClick);
            // 
            // barMdiChildrenListItem1
            // 
            this.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1";
            this.barMdiChildrenListItem1.Id = 9;
            this.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1";
            // 
            // barPopMergeWallPaper
            // 
            this.barPopMergeWallPaper.Caption = "Merge WallPaper";
            this.barPopMergeWallPaper.Id = 10;
            this.barPopMergeWallPaper.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barFirstWallPaper),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSecondWallPaper)});
            this.barPopMergeWallPaper.Name = "barPopMergeWallPaper";
            // 
            // barFirstWallPaper
            // 
            this.barFirstWallPaper.Caption = "First WallPaper";
            this.barFirstWallPaper.Id = 11;
            this.barFirstWallPaper.Name = "barFirstWallPaper";
            this.barFirstWallPaper.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barFirstWallPaper_ItemClick);
            // 
            // barSecondWallPaper
            // 
            this.barSecondWallPaper.Caption = "Second WallPaper";
            this.barSecondWallPaper.Id = 12;
            this.barSecondWallPaper.Name = "barSecondWallPaper";
            this.barSecondWallPaper.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSecondWallPaper_ItemClick);
            // 
            // barPopAddToWpCollection
            // 
            this.barPopAddToWpCollection.Caption = "Add To WpCollection";
            this.barPopAddToWpCollection.Id = 13;
            this.barPopAddToWpCollection.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItemTest)});
            this.barPopAddToWpCollection.Name = "barPopAddToWpCollection";
            // 
            // barButtonItemTest
            // 
            this.barButtonItemTest.Caption = "barButtonItem1";
            this.barButtonItemTest.Id = 14;
            this.barButtonItemTest.Name = "barButtonItemTest";
            // 
            // popImgMenu
            // 
            this.popImgMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSetAsCover),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSetBestLoveMM),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSetasWallpaper),
            new DevExpress.XtraBars.LinkPersistInfo(this.barUpload),
            new DevExpress.XtraBars.LinkPersistInfo(this.barPopMergeWallPaper),
            new DevExpress.XtraBars.LinkPersistInfo(this.barPopAddToWpCollection)});
            this.popImgMenu.Manager = this.barManager1;
            this.popImgMenu.Name = "popImgMenu";
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private DevExpress.XtraBars.BarButtonItem barUpload;
        private DevExpress.XtraBars.BarButtonItem barSetAllToLoveMM;
        private DevExpress.XtraBars.BarMdiChildrenListItem barMdiChildrenListItem1;
        private DevExpress.XtraBars.BarSubItem barPopMergeWallPaper;
        private DevExpress.XtraBars.BarButtonItem barFirstWallPaper;
        private DevExpress.XtraBars.BarButtonItem barSecondWallPaper;
        private DevExpress.XtraBars.BarSubItem barPopAddToWpCollection;
        private DevExpress.XtraBars.BarButtonItem barButtonItemTest;
        private DevExpress.XtraBars.BarButtonItem barDelFolder;
        private DevExpress.XtraBars.BarButtonItem barDelAllMmPhoto;
    }
}
