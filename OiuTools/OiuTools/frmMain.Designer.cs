﻿
namespace OiuTools
{
    partial class frmMain
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
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer13 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer14 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer15 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer16 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            this.documentGroup3 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.BlegMM = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.documentGroup2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.Clock = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.App = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.Calendar = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barRefreshWallPaper = new DevExpress.XtraBars.BarButtonItem();
            this.barToggleChanging = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgWallPaper = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dm = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.timerWallPaper = new System.Windows.Forms.Timer(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinPaletteRibbonGalleryBarItem = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlegMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.App)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentGroup3
            // 
            this.documentGroup3.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.BlegMM});
            // 
            // BlegMM
            // 
            this.BlegMM.Caption = "BlegMM";
            this.BlegMM.ControlName = "BlegMM";
            this.BlegMM.ControlTypeName = "OiuTools.Controls.BlegMM";
            // 
            // documentGroup2
            // 
            this.documentGroup2.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.Clock});
            // 
            // Clock
            // 
            this.Clock.Caption = "Clock";
            this.Clock.ControlName = "Clock";
            this.Clock.ControlTypeName = "OiuTools.Controls.Clock";
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.App,
            this.Calendar});
            // 
            // App
            // 
            this.App.Caption = "App";
            this.App.ControlName = "App";
            this.App.ControlTypeName = "OiuTools.Controls.App";
            // 
            // Calendar
            // 
            this.Calendar.Caption = "Calendar";
            this.Calendar.ControlName = "Calendar";
            this.Calendar.ControlTypeName = "OiuTools.Controls.Calendar";
            this.Calendar.FloatLocation = new System.Drawing.Point(1152, 545);
            this.Calendar.FloatSize = new System.Drawing.Size(248, 118);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barRefreshWallPaper,
            this.barToggleChanging,
            this.skinRibbonGalleryBarItem,
            this.skinPaletteRibbonGalleryBarItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 7;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(1034, 166);
            // 
            // barRefreshWallPaper
            // 
            this.barRefreshWallPaper.Caption = "Refresh";
            this.barRefreshWallPaper.Id = 1;
            this.barRefreshWallPaper.ImageOptions.Image = global::OiuTools.Properties.Resources.logo;
            this.barRefreshWallPaper.Name = "barRefreshWallPaper";
            this.barRefreshWallPaper.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barRefreshWallPaper.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRefreshWallPaper_ItemClick);
            // 
            // barToggleChanging
            // 
            this.barToggleChanging.BindableChecked = true;
            this.barToggleChanging.Caption = " ON";
            this.barToggleChanging.Checked = true;
            this.barToggleChanging.Id = 2;
            this.barToggleChanging.Name = "barToggleChanging";
            this.barToggleChanging.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barToggleChanging_CheckedChanged);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSystem,
            this.rpgWallPaper});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // rpgSystem
            // 
            this.rpgSystem.Name = "rpgSystem";
            this.rpgSystem.Text = "System";
            // 
            // rpgWallPaper
            // 
            this.rpgWallPaper.ItemLinks.Add(this.barRefreshWallPaper);
            this.rpgWallPaper.ItemLinks.Add(this.barToggleChanging);
            this.rpgWallPaper.Name = "rpgWallPaper";
            this.rpgWallPaper.Text = "WallPaper";
            // 
            // dm
            // 
            this.dm.ContainerControl = this;
            this.dm.MenuManager = this.ribbonControl1;
            this.dm.View = this.tabbedView1;
            this.dm.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.DocumentGroups.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup[] {
            this.documentGroup2,
            this.documentGroup3,
            this.documentGroup1});
            this.tabbedView1.Documents.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseDocument[] {
            this.Clock,
            this.App,
            this.BlegMM,
            this.Calendar});
            this.tabbedView1.EnableFreeLayoutMode = DevExpress.Utils.DefaultBoolean.True;
            dockingContainer13.Element = this.documentGroup3;
            dockingContainer13.Length.UnitValue = 1.583527943012411D;
            dockingContainer14.Length.UnitValue = 0.38650951017110968D;
            dockingContainer15.Element = this.documentGroup2;
            dockingContainer15.Length.UnitValue = 0.38563140612050073D;
            dockingContainer16.Element = this.documentGroup1;
            dockingContainer16.Length.UnitValue = 1.9427081694100861D;
            dockingContainer14.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer15,
            dockingContainer16});
            dockingContainer14.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tabbedView1.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer13,
            dockingContainer14});
            // 
            // timerWallPaper
            // 
            this.timerWallPaper.Enabled = true;
            this.timerWallPaper.Interval = 10000;
            this.timerWallPaper.Tick += new System.EventHandler(this.timerWallPaper_Tick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Skin";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonGalleryBarItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Theme";
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem.Id = 5;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            this.skinRibbonGalleryBarItem.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.skinRibbonGalleryBarItem_GalleryItemClick);
            // 
            // skinPaletteRibbonGalleryBarItem
            // 
            this.skinPaletteRibbonGalleryBarItem.Caption = "skinPaletteRibbonGalleryBarItem1";
            this.skinPaletteRibbonGalleryBarItem.Id = 6;
            this.skinPaletteRibbonGalleryBarItem.Name = "skinPaletteRibbonGalleryBarItem";
            this.skinPaletteRibbonGalleryBarItem.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.skinPaletteRibbonGalleryBarItem_GalleryItemClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 774);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = global::OiuTools.Properties.Resources.logo;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OiuTools";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlegMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.App)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgSystem;
        private DevExpress.XtraBars.Docking2010.DocumentManager dm;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document Clock;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup2;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document Calendar;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document App;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup3;
        private DevExpress.XtraBars.BarAndDockingController barAndDockingController1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.Document BlegMM;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup documentGroup1;
        private System.Windows.Forms.Timer timerWallPaper;
        private DevExpress.XtraBars.BarButtonItem barRefreshWallPaper;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgWallPaper;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleChanging;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}

