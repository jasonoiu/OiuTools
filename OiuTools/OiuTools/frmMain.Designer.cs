
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
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer3 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer dockingContainer4 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer();
            this.documentGroup2 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.Calendar = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.documentGroup3 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            this.App = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.Clock = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.BlegMM = new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgSystem = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dm = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.barAndDockingController1 = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.documentGroup1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.App)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlegMM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentGroup2
            // 
            this.documentGroup2.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.Clock,
            this.Calendar});
            // 
            // Calendar
            // 
            this.Calendar.Caption = "Calendar";
            this.Calendar.ControlName = "Calendar";
            this.Calendar.ControlTypeName = "OiuTools.Controls.Calendar";
            this.Calendar.FloatLocation = new System.Drawing.Point(1213, 374);
            this.Calendar.FloatSize = new System.Drawing.Size(248, 118);
            // 
            // documentGroup3
            // 
            this.documentGroup3.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.BlegMM});
            // 
            // App
            // 
            this.App.Caption = "App";
            this.App.ControlName = "App";
            this.App.ControlTypeName = "OiuTools.Controls.App";
            // 
            // Clock
            // 
            this.Clock.Caption = "Clock";
            this.Clock.ControlName = "Clock";
            this.Clock.ControlTypeName = "OiuTools.Controls.Clock";
            // 
            // BlegMM
            // 
            this.BlegMM.Caption = "BlegMM";
            this.BlegMM.ControlName = "BlegMM";
            this.BlegMM.ControlTypeName = "OiuTools.Controls.BlegMM";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 1;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 385;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(914, 166);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgSystem});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // rpgSystem
            // 
            this.rpgSystem.Name = "rpgSystem";
            this.rpgSystem.Text = "System";
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
            dockingContainer1.Element = this.documentGroup3;
            dockingContainer1.Length.UnitValue = 1.4232209737827715D;
            dockingContainer2.Length.UnitValue = 0.54681647940074907D;
            dockingContainer3.Element = this.documentGroup2;
            dockingContainer4.Element = this.documentGroup1;
            dockingContainer4.Length.UnitValue = 1.3283395755305867D;
            dockingContainer2.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer3,
            dockingContainer4});
            dockingContainer2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tabbedView1.RootContainer.Nodes.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer[] {
            dockingContainer1,
            dockingContainer2});
            // 
            // documentGroup1
            // 
            this.documentGroup1.Items.AddRange(new DevExpress.XtraBars.Docking2010.Views.Tabbed.Document[] {
            this.App});
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 679);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.Image = global::OiuTools.Properties.Resources.logo;
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OiuTools";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Calendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.App)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Clock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BlegMM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAndDockingController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentGroup1)).EndInit();
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
    }
}

