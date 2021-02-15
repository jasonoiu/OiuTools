using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OiuTools.Model;

namespace OiuTools.Controls
{
    public partial class SingleApp : DevExpress.XtraEditors.XtraUserControl
    {
        public AppModel Model;


        public SingleApp(AppModel model)
        {
            Model = model;
            InitializeComponent();
            pic.Image = Image.FromFile(model.IconUrl);
            lblName.Text = Model.Name;
        }
    }
}
