using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Views;

namespace OiuTools
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            dm.View.QueryControl += OnQueryControl;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void OnQueryControl(object sender, QueryControlEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Document.ControlTypeName))
                e.Control = Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)) as Control;
            else
                e.Control = new Control();
        }
    }
}
