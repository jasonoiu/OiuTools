using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using BlegMM;
using BlegMM.Model;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using OiuTools.Code;
using OiuTools.Views;
using PublicLibrary;

namespace OiuTools
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private MySettings ms;
        private SystemSettings ss;

        #region 公用方法

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        /// <summary>
        /// 获取并打开窗体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="formName"></param>
        /// <param name="func"></param>
        public T GetAndOpenForm<T>(string formName, Func<T> func = null)
            where T : Form, new()
        {
            var form = (T)Application.OpenForms[formName];
            if (form != null)
            {
                SetForegroundWindow(form.Handle);
                return form;
            }
            form = new T();
            form.Show();
            return form;
        }

        #endregion


        public frmMain()
        {
            InitializeComponent();
            
            ms = MySettings.Singleton;
            ss = SystemSettings.Singleton;
            dm.View.QueryControl += OnQueryControl;
            timerWallPaper.Interval = ss.Intervals;
            timerWallPaper.Enabled = true;
            MmReptile.Singleton.FolderScanFinished += Singleton_FolderScanFinishedEvent;
            
            if (ms.SkinName.IsNotNullOrEmpty())
            {
                UserLookAndFeel.Default.SetSkinStyle(ms.SkinName, ms.PaletteName);
            }

            if (!ms.LastLocation.IsEmpty)
            {
                Location = ms.LastLocation;
                //StartPosition = FormStartPosition.WindowsDefaultLocation;
            }

            BackUpSettingEveryDay();

            
        }


        



        private void BestLoveMM_WallPaperChanged()
        {
            BeginInvoke(new Action(timerWallPaperRestart));
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (ms.MainFormSize.Width < 1334)
            {
                this.Size = new Size(1334, 1224);
            }
            else
            {
                this.Size = ms.MainFormSize;
            }
            
            //wallpaper collection
            if (ss.WallPaperCollections.Any())
            {
                foreach (var wallPaperCollection in ss.WallPaperCollections)
                {
                    comboxWpCollection.Items.Add(wallPaperCollection.Name);
                }
            }

            ProcessTempTask();

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ms.MainFormSize = this.Size;
            ms.LastLocation = this.Location;
            ss.Save();
            ms.Save();

        }

        /// <summary>
        /// 处理临时任务
        /// </summary>
        void ProcessTempTask()
        {
            var delMinPeriod = 820;
            if (!ss.AllImgFolderObjList.FolderObjList.Any(m=>m.FolderNo<=delMinPeriod)) return;
            
            new Action((() =>
            {

                try
                {
                    var copyFoldersList = ss.AllImgFolderObjList.FolderObjList.Where(m => m.FolderNo <= delMinPeriod)
                        .ToList().DeepCopyWithBinarySerialize();
                    foreach (var folderObj in copyFoldersList)
                    {
                        ss.DelFolder(folderObj);
                    }
                    ss.Save();
                    BlegMmBackToHome();
                    XMessage.Show("文件夹批量删除完成！");
                }
                catch (Exception e)
                {
                    ss.Save();
                    XMessage.Show(e.Message);
                }


            })).BeginInvoke(null, null);
        }



        void BackUpSettingEveryDay()
        {
            new Action((() =>
            {
                ss.BackUpFile();
            })).BeginInvoke(null, null);
        }

        /// <summary>
        /// 美女相册返回到首页
        /// </summary>
        private void BlegMmBackToHome()
        {
            BeginInvoke(new Action((() =>
            {
                var blegMM = BlegMM.Control as Controls.BlegMM;
                blegMM?.BackToHome();
            })));
        }


        /// <summary>
        /// 蜘蛛引擎所有文件夹扫描完成时触发
        /// </summary>
        private void Singleton_FolderScanFinishedEvent()
        {
            barStatus.Caption = "Scan finished";
            BlegMmBackToHome();
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
            if (!barToggleChanging.Checked)
            {
                timerWallPaper.Enabled = false;
                return;
            }
            new Action((() =>
            {
                if (!ss.CurWallPagerList.Any())
                {
                    return;
                }

                try
                {
                    var img1 = changeCurWallpaper();
                    var curImgObj = ss.CurWallPaper.getImgObj();
                    if (curImgObj == null)
                    {
                        XtraMessageBox.Show($"curImgObj为null值");
                        return;
                    }
                    if (img1.Width > img1.Height)
                    {
                        Tools.SetWallPaper(curImgObj.FileUrl);
                        img1.Dispose();
                    }
                    else
                    {
                        //合并2张竖屏壁纸
                        if (img1 == null)
                        {
                            XtraMessageBox.Show($"img1为null值");
                            return;
                        }

                        var img2 = getAnotherImgObj(curImgObj);

                        if (img2 == null)
                        {
                            XtraMessageBox.Show($"img2为null值");
                            return;
                        }

                        var combinImg = Tools.CombinTwoImage(img1, img2);

                        if (combinImg == null)
                        {
                            XtraMessageBox.Show($"combinImg为null值");
                            return;
                        }

                        Tools.SetWallPaper(combinImg);

                    }

                    curImgObj = null;
                    BeginInvoke(new Action(timerWallPaperRestart));
                }
                catch (Exception exception)
                {
                    XtraMessageBox.Show(this, exception.Message);
                    //throw;
                }
            })).BeginInvoke(null, null);
        }

        void timerWallPaperRestart()
        {
            timerWallPaper.Stop();
            timerWallPaper.Enabled = false;
            timerWallPaper.Interval = ss.Intervals;
            timerWallPaper.Enabled = true;
            timerWallPaper.Start();
        }

        Image changeCurWallpaper()
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

            var img = ss.CurWallPaper.getImgObj().FileUrl.FixImgUrl().ToImage();
            if (img == null)
            {
                return changeCurWallpaper();
            }

            return img;
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
            if (img == null || img.Width > img.Height)
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

        private void barSystemSetting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmConfig = GetAndOpenForm<frmConfig>("frmConfig");
            frmConfig.WallPaperIntervalChanged += FrmConfig_WallPaperIntervalChanged;
        }

        private void FrmConfig_WallPaperIntervalChanged()
        {
            timerWallPaperRestart();
        }

        private void tabbedView1_ControlLoaded(object sender, DeferredControlLoadEventArgs e)
        {
            
        }

        private void tabbedView1_ControlShown(object sender, DeferredControlLoadEventArgs e)
        {
            new Action((() =>
            {
                Thread.Sleep(1000 * 3);
                
                var bestLoveMM = BestLoveMM.Control as Controls.BestLoveMM;
                bestLoveMM.WallPaperChanged += BestLoveMM_WallPaperChanged;
                

                var blegMM = BlegMM.Control as Controls.BlegMM;
                blegMM.FolderRecanThumbnailsBuildFinished += BlegMM_FolderRecanThumbnailsBuildFinished;
                blegMM.FolderAllImagesInited += BlegMM_FolderRecanThumbnailsBuildFinished;

                bestLoveMM.OpenFolderEvent += folderObj =>
                {
                    blegMM.OpenFolder(folderObj);
                };

            })).BeginInvoke(null, null);
        }

        

        private void BlegMM_FolderRecanThumbnailsBuildFinished(string message)
        {
            this.BeginInvoke(new Action((() =>
            {
                barStatus.Caption = message;
            })));
        }

        private void barMergeWallPaper_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oneImgUrl = ss.DicMergeWallPaper["one"];
            var twoImgUrl = ss.DicMergeWallPaper["two"];

            #region 检测是否为空

            if (oneImgUrl.IsNullOrEmpty())
            {
                XtraMessageBox.Show($"第一张图片不能为空！");
                return;
            }

            if (twoImgUrl.IsNullOrEmpty())
            {
                XtraMessageBox.Show($"第二张图片不能为空！");
                return;
            }

            #endregion

            #region 检测是否为竖屏壁纸

            var oneImgObj = ss.AllImgFolderObjList.ImgObjList.FirstOrDefault(m =>
                m.FileUrl.Equals(oneImgUrl, StringComparison.OrdinalIgnoreCase));
            if (oneImgObj == null)
            {
                XtraMessageBox.Show($"第一张图片不存在！");
                return;
            }

            if (oneImgObj.IsPcWallPaperSize)
            {
                XtraMessageBox.Show($"第一张图片不是竖屏图片！");
                return;
            }

            var twoImgObj = ss.AllImgFolderObjList.ImgObjList.FirstOrDefault(m =>
                m.FileUrl.Equals(twoImgUrl, StringComparison.OrdinalIgnoreCase));
            if (twoImgObj == null)
            {
                XtraMessageBox.Show($"第二张图片不存在！");
                return;
            }

            if (twoImgObj.IsPcWallPaperSize)
            {
                XtraMessageBox.Show($"第二张图片不是竖屏图片！");
                return;
            }


            #endregion

            new Action((() =>
            {

                var img1 = oneImgUrl.ToImage();
                var img2 = twoImgUrl.ToImage();

                var combinImg = Tools.CombinTwoImage(img1, img2);

                if (combinImg == null)
                {
                    XtraMessageBox.Show($"combinImg为null值");
                    return;
                }

                Tools.SetWallPaper(combinImg);
            })).BeginInvoke(null, null);
        }

        private void barCreateFolder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = XtraInputBox.Show("Enter Folder Name", "Create Folder", "");
            if (result.IsNullOrEmpty()) return;

            var max = ss.AllImgFolderObjList.FolderObjList.Max(m => m.FolderNo);
            Directory.CreateDirectory(
                $@"{ss.ImgFolderPath}\No.{max + 1} {result} {DateTime.Now:yyyy.MM.dd}");
        }

        
        private void comboxWpCollection_SelectedValueChanged(object sender, EventArgs e)
        {
            var edit = sender as ComboBoxEdit;
            var list = ss.WallPaperCollections.FirstOrDefault(m => m.Name.Equals(edit.SelectedItem));
            ss.CurWallPagerList = list.Lists;
        }

        private void barCreateCollection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var name = XtraInputBox.Show("Enter Collection Name", "Create Collection", "");
            if (name.IsNullOrEmpty()) return;

            if (ss.TagsLists.Exists(m => m.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                XtraMessageBox.Show("集合名称已存在！");
                return;
            }

            ss.TagsLists.Add(name);

            ss.WallPaperCollections.Add(new WallPaperCollection
            {
                Id = Guid.NewGuid(), Lists = new List<WallPaper>(), Name = name
            });
        }
    }
}
