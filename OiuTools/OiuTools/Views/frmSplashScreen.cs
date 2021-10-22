using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BlegMM;

namespace OiuTools.Views
{
    public partial class frmSplashScreen : SplashScreen
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 2000-" + DateTime.Now.Year.ToString();
            this.peImage.Image = Image.FromFile(SystemSettings.Singleton.BestLoveMMWallPaperLists.ElementAt(Tools.getRandomNum(1,0, SystemSettings.Singleton.BestLoveMMWallPaperLists.Count-1)[0]).FileUrl);
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}