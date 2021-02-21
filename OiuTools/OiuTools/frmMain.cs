using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BlegMM;
using BlegMM.Model;
using DevExpress.LookAndFeel;
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
            timerWallPaper.Enabled = true;
            MmReptile.Singleton.FolderScanFinished += Singleton_FolderScanFinishedEvent;

            if (ms.SkinName.IsNotNullOrEmpty())
            {
                UserLookAndFeel.Default.SetSkinStyle(ms.SkinName, ms.PaletteName);
            }

            if (!ms.LastLocation.IsEmpty)
            {
                Location = ms.LastLocation;
                StartPosition = FormStartPosition.WindowsDefaultLocation;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Size = ms.MainFormSize;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ms.MainFormSize = this.Size;
            ms.LastLocation = this.Location;
            ss.Save();
            ms.Save();

        }


        /// <summary>
        /// 蜘蛛引擎所有文件夹扫描完成时触发
        /// </summary>
        private void Singleton_FolderScanFinishedEvent()
        {
            barStatus.Caption = "Scan finished";
            BeginInvoke(new Action((() =>
            {
                var blegMM = BlegMM.Control as Controls.BlegMM;
                blegMM?.BackToHome();
            })));
        }



        private void OnQueryControl(object sender, QueryControlEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Document.ControlTypeName))
                e.Control = Activator.CreateInstance(Type.GetType(e.Document.ControlTypeName)) as Control;
            else
                e.Control = new Control();
        }

        private void timerWallPaper_Tick(object sender, EventArgs e)
        {

            new Action((() =>
            {
                if (!ss.CurWallPagerList.Any())
                {
                    return;
                }

                try
                {
                    changeCurWallpaper();
                    //ss.Save();
                    var curImgObj = ss.CurWallPaper.getImgObj();
                    if (curImgObj.IsPcWallPaperSize)
                    {
                        Tools.SetWallPaper(curImgObj.FileUrl);
                    }
                    else
                    {
                        //合并2张竖屏壁纸
                        var img1 = curImgObj.FileUrl.FixImgUrl().ToImage();
                        if (img1 == null)
                        {
                            changeCurWallpaper();
                        }

                        var img2 = getAnotherImgObj(curImgObj);
                        var combinImg = Tools.CombinTwoImage(img1, img2);
                        Tools.SetWallPaper(combinImg);

                    }

                    curImgObj = null;
                    BeginInvoke(new Action((() =>
                    {
                        timerWallPaper.Stop();
                        timerWallPaper.Enabled = false;
                        timerWallPaper.Interval = ss.Intervals;
                        timerWallPaper.Enabled = true;
                        timerWallPaper.Start();
                    })));
                }
                catch (Exception exception)
                {
                    //MessageBoxEx.Show(this, exception.Message);
                    //throw;
                }
            })).BeginInvoke(null, null);
        }

        void changeCurWallpaper()
        {
            var randomMax = ss.CurWallPagerList.Count - 1;

            if (ss.CurWallPaper == null ||
                ss.CurWallPagerList.All(m => m.Id != ss.CurWallPaper.Id)
            )
            {
                ss.CurWallPaper = ss.CurWallPagerList[getRandomIndex(randomMax)];
            }
            else
            {
                var index = ss.CurWallPagerList.FindIndex(m =>
                    m.Id == ss.CurWallPaper.Id);
                ss.CurWallPaper = ss.CurWallPagerList[getRandomIndex(randomMax, index)];
            }
        }

        /// <summary>
        /// 随机获取另一张竖屏图片
        /// </summary>
        /// <param name="curImgObj"></param>
        /// <returns></returns>
        Image getAnotherImgObj(ImgObj curImgObj)
        {
            var list = ss.CurWallPagerList;
            var radomImg = list[getRandomIndex(list.Count - 1)];
            if (radomImg.Id == curImgObj.Id || radomImg.getImgObj().IsPcWallPaperSize)
            {
                return getAnotherImgObj(curImgObj);
            }

            var img = radomImg.FileUrl.FixImgUrl().ToImage();
            if (img == null)
            {
                return getAnotherImgObj(curImgObj);
            }

            return img;
        }


        int getRandomIndex(int max, int index = 0)
        {
            var randomNum = Tools.getRandomNum(1, 0, max)[0];
            if (randomNum == index) return getRandomIndex(max, index);
            return randomNum;
        }


        private void barRefreshWallPaper_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            timerWallPaper_Tick(sender, e);
        }

        private void barToggleChanging_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            timerWallPaper.Enabled = barToggleChanging.Checked;
            barToggleChanging.Caption = barToggleChanging.Checked ? " ON" : "OFF";
        }


        private void skinPaletteRibbonGalleryBarItem_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            ms.PaletteName = e.Item.Value.ToString();
        }

        private void skinRibbonGalleryBarItem_GalleryItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {
            ms.SkinName = e.Item.Value.ToString();
        }

        private void barBackUp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var blegMM = BlegMM.Control as Controls.BlegMM;
            blegMM?.BackToUp();
        }

        private void barBackHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var blegMM = BlegMM.Control as Controls.BlegMM;
            blegMM ?.BackToHome();
        }

        private void barScanStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barStatus.Caption = "Start Scanning...";
            new Action(MmReptile.Singleton.Start).BeginInvoke(null, null);

        }

        private void barBuildWallPaper_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new Action((() =>
            {
                foreach (var folderObj in ss.AllImgFolderObjList.FolderObjList.Where(m =>
                    m.FolderNo > ss.MinPeriod))
                {
                    foreach (var imgObj in ss.AllImgFolderObjList.ImgObjList.Where(m =>
                        m.Folder == folderObj))
                    {
                        imgObj.buildThumbnailsAsyc();
                    }

                    this.BeginInvoke(new Action((() =>
                    {
                        barStatus.Caption = $"{folderObj.Name} 生成缩略图完成";
                    })));
                }

                ss.Save();
            })).BeginInvoke(null,null);
        }
    }
}
