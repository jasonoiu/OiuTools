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
            this.lblName = new DevExpress.XtraEditors.LabelControl();
            this.pic = new DevExpress.XtraEditors.PictureEdit();
            this.popFolderMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barAddToWallPaperList = new DevExpress.XtraBars.BarButtonItem();
            this.barAddToNewWallPaperList = new DevExpress.XtraBars.BarButtonItem();
            this.barRemoveFromWallPaper = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.popImgMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barSetAsCover = new DevExpress.XtraBars.BarButtonItem();
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
            // popFolderMenu
            // 
            this.popFolderMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barAddToWallPaperList),
            new DevExpress.XtraBars.LinkPersistInfo(this.barAddToNewWallPaperList),
            new DevExpress.XtraBars.LinkPersistInfo(this.barRemoveFromWallPaper)});
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
            this.barSetAsCover});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(178, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 300);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(178, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 300);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(178, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 300);
            // 
            // popImgMenu
            // 
            this.popImgMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSetAsCover)});
            this.popImgMenu.Manager = this.barManager1;
            this.popImgMenu.Name = "popImgMenu";
            // 
            // barSetAsCover
            // 
            this.barSetAsCover.Caption = "Set as Cover";
            this.barSetAsCover.Id = 3;
            this.barSetAsCover.Name = "barSetAsCover";
            this.barSetAsCover.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSetAsCover_ItemClick);
            // 
            // ImgControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ImgControl";
            this.Size = new System.Drawing.Size(178, 300);
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
    }
}
