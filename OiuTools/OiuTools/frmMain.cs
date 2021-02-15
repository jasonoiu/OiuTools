using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BlegMM;
using DevExpress.XtraBars.Docking2010.Views;

namespace OiuTools
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MySettings ms;
        private SystemSettings ss;
        public frmMain()
        {
            InitializeComponent();
            ms = MySettings.Singleton;
            ss = SystemSettings.Singleton;
            dm.View.QueryControl += OnQueryControl;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Size = ms.MainFormSize;
        }

        private void OnQueryControl(object sender, QueryControlEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Document.ControlTypeName))
                e.Control = Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)) as Control;
            else
                e.Control = new Control();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ms.MainFormSize = this.Size;
            ss.Save();
            ms.Save();
            
        }
    }
}
