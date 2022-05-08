using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BlegMM;

namespace OiuTools
{
    public partial class frmSplashScreen : SplashScreen
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            this.labelCopyright.Text = $@"Copyright © 2000-{DateTime.Now.Year}";

            this.peImage.Image = getAnotherImgObj();

        }

        Image getAnotherImgObj()
        {
            var list = SystemSettings.Singleton.BestLoveMMWallPaperLists;
            var radomImg = list[getRandomIndex(list.Count - 1)];
            if (!radomImg.getImgObj().IsPcWallPaperSize)
            {
                return getAnotherImgObj();
            }

            var img = radomImg.FileUrl.FixImgUrl().ToImage();
            if (img == null)
            {
                return getAnotherImgObj();
            }

            return img;
        }
        int getRandomIndex(int max, int index = 0)
        {
            var randomNum = Tools.getRandomNum(1, 0, max)[0];
            if (randomNum == index) return getRandomIndex(max, index);
            return randomNum;
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

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            this.Location = new Point(this.Location.X, this.Location.Y - 15);
        }
    }
}