using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlegMM;
using DevExpress.XtraEditors;
using ESBasic;

namespace OiuTools.Views
{
    public partial class frmConfig : BaseForm
    {
        private MySettings ms;
        private SystemSettings ss;
        /// <summary>
        /// 壁纸切换时间改变事件
        /// </summary>
        public event CbGeneric WallPaperIntervalChanged;
        public frmConfig()
        {
            InitializeComponent();
            ms = MySettings.Singleton;
            ss = SystemSettings.Singleton;
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            txtWallPaperInterval.Text = (ss.Intervals / 60000).ToString();
            txtMinPeriod.Text = ss.MinPeriod.ToString();
            txtExtraMinPeriod.Text = ss.ExtraMinPeriod.ToString();
            checkPlayMusic.Checked = ms.IsPlayMusic;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var interval = txtWallPaperInterval.Text.ToInt() * 60000;
            if (interval < 10000)
            {
                XtraMessageBox.Show("壁纸切换时间不能小于10秒", "温馨提示");
                return;
            }

            var oi = ss.Intervals;

            ss.Intervals = interval;
            ss.MinPeriod = txtMinPeriod.Text.ToInt();
            ss.ExtraMinPeriod = txtExtraMinPeriod.Text.ToInt();
            ss.Save();

            if (ms.IsPlayMusic != checkPlayMusic.Checked)
            {
                ms.IsPlayMusic = checkPlayMusic.Checked;
                ms.Save();
            }

            if (oi != interval)
            {
                WallPaperIntervalChanged?.Invoke();
            }

            this.Close();
        }

        



    }
}
