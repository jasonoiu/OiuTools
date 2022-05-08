
namespace OiuTools.Controls
{
    partial class BestLoveMM
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
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            this.imgContainer = new DevExpress.XtraEditors.ImageListBoxControl();
            this.popMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barSetWallPaper = new DevExpress.XtraBars.BarButtonItem();
            this.barDel = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barFirstMergeWp = new DevExpress.XtraBars.BarButtonItem();
            this.barSecondMergeWp = new DevExpress.XtraBars.BarButtonItem();
            this.barOpenFolder = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.imgContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // imgContainer
            // 
            this.imgContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgContainer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.imgContainer.ItemHeight = 113;
            this.imgContainer.Location = new System.Drawing.Point(0, 0);
            this.imgContainer.Name = "imgContainer";
            this.imgContainer.Size = new System.Drawing.Size(329, 660);
            this.imgContainer.SortOrder = System.Windows.Forms.SortOrder.Descending;
            this.imgContainer.TabIndex = 0;
            templatedItemElement1.FieldName = "ImageMember";
            templatedItemElement1.Height = 117;
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.NoScale;
            templatedItemElement1.MaxWidth = 175;
            templatedItemElement1.Text = "ImageMember";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.Width = 175;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Name = "template1";
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            this.imgContainer.Templates.Add(itemTemplateBase1);
            this.imgContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgContainer_MouseClick);
            // 
            // popMenu
            // 
            this.popMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSetWallPaper),
            new DevExpress.XtraBars.LinkPersistInfo(this.barOpenFolder),
            new DevExpress.XtraBars.LinkPersistInfo(this.barDel),
            new DevExpress.XtraBars.LinkPersistInfo(this.barFirstMergeWp),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSecondMergeWp)});
            this.popMenu.Manager = this.barManager1;
            this.popMenu.Name = "popMenu";
            // 
            // barSetWallPaper
            // 
            this.barSetWallPaper.Caption = "Set WallPaper";
            this.barSetWallPaper.Id = 1;
            this.barSetWallPaper.Name = "barSetWallPaper";
            this.barSetWallPaper.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSetWallPaper_ItemClick);
            // 
            // barDel
            // 
            this.barDel.Caption = "Remove";
            this.barDel.Id = 0;
            this.barDel.Name = "barDel";
            this.barDel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDel_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barDel,
            this.barSetWallPaper,
            this.barFirstMergeWp,
            this.barSecondMergeWp,
            this.barOpenFolder});
            this.barManager1.MaxItemId = 5;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(329, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 660);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(329, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 660);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(329, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 660);
            // 
            // barFirstMergeWp
            // 
            this.barFirstMergeWp.Caption = "Set First Merge Wp";
            this.barFirstMergeWp.Id = 2;
            this.barFirstMergeWp.Name = "barFirstMergeWp";
            this.barFirstMergeWp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barFirstMergeWp_ItemClick);
            // 
            // barSecondMergeWp
            // 
            this.barSecondMergeWp.Caption = "Set Second Merge Wp";
            this.barSecondMergeWp.Id = 3;
            this.barSecondMergeWp.Name = "barSecondMergeWp";
            this.barSecondMergeWp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSecondMergeWp_ItemClick);
            // 
            // barOpenFolder
            // 
            this.barOpenFolder.Caption = "Open Folder";
            this.barOpenFolder.Id = 4;
            this.barOpenFolder.Name = "barOpenFolder";
            this.barOpenFolder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barOpenFolder_ItemClick);
            // 
            // BestLoveMM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgContainer);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "BestLoveMM";
            this.Size = new System.Drawing.Size(329, 660);
            this.Load += new System.EventHandler(this.BestLoveMM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ImageListBoxControl imgContainer;
        private DevExpress.XtraBars.PopupMenu popMenu;
        private DevExpress.XtraBars.BarButtonItem barDel;
        private DevExpress.XtraBars.BarButtonItem barSetWallPaper;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barFirstMergeWp;
        private DevExpress.XtraBars.BarButtonItem barSecondMergeWp;
        private DevExpress.XtraBars.BarButtonItem barOpenFolder;
    }
}
