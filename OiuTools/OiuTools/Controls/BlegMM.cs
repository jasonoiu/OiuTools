using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlegMM;
using BlegMM.Model;
using DevExpress.XtraEditors;
using ESBasic;
using OiuTools.Code;
using Util = OiuTools.Code.Util;

namespace OiuTools.Controls
{
    public partial class BlegMM : XtraUserControl
    {
        private MySettings ms;
        private SystemSettings ss;
        public BlegMM()
        {
            InitializeComponent();
            ms = MySettings.Singleton;
            ss = SystemSettings.Singleton;
            if (ms.BlegMMPageSize <= 10)
            {
                ms.BlegMMPageSize = 18;
            }

            pagerControl1.PageSize = ms.BlegMMPageSize;
            
        }

        /// <summary>
        /// 文件夹重新扫描后生成单个缩略图完成
        /// </summary>
        public event CbGeneric<string> FolderRecanThumbnailsBuildFinished;
        /// <summary>
        /// 文件夹所有图片初始化完成
        /// </summary>
        public event CbGeneric<string> FolderAllImagesInited;

        /// <summary>
        /// 当前是否为文件夹视图
        /// </summary>
        public bool CurIsFolderView => ((ImgControl)mainPanel.Controls[0]).ViewType == ViewType.Folder;
        /// <summary>
        /// 当前的文件夹或图片对象
        /// </summary>
        public FiBaseObj CurFiBaseObj => ((ImgControl)mainPanel.Controls[0]).BaseObj;
        /// <summary>
        /// 上一次的PageSize
        /// </summary>
        public int LastPageSize { get; set; }
        /// <summary>
        /// 上一次的PageIndex
        /// </summary>
        public int LastPageIndex { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public SortEnum LastSortEnum { get; set; }


        private void BlegMM_Load(object sender, EventArgs e)
        {
            pagerControl1.EventPaging += PagerControl1_OnFolderOnPageChanged;
            initFolderListView();
        }

        /// <summary>
        /// 初始化文件夹列表视图
        /// </summary>
        void initFolderListView(SortEnum sortEnum = SortEnum.FolderNoDesc)
        {
            LastSortEnum = sortEnum;
            mainPanel.Controls.Clear();
            IEnumerable<FolderObj> list = SystemSettings.Singleton.AllImgFolderObjList.FolderObjList;
            switch (sortEnum)
            {
                case SortEnum.NameAsc:
                    list = list.OrderBy(m => m.Name);
                    break;
                case SortEnum.FolderNoAsc:
                    list = list.OrderBy(m => m.FolderNo);
                    break;
                case SortEnum.FolderNoDesc:
                    list = list.OrderByDescending(m => m.FolderNo);
                    break;
                case SortEnum.NameDesc:
                    list = list.OrderByDescending(m => m.Name);
                    break;
                case SortEnum.AddTimeAsc:
                    list = list.OrderBy(m => m.AddTime);
                    break;
                case SortEnum.AddTimeDesc:
                    list = list.OrderByDescending(m => m.AddTime);
                    break;
            }
            var pageList = list.Skip((pagerControl1.PageIndex - 1) * pagerControl1.PageSize).Take(pagerControl1.PageSize);

            var i = 0;
            foreach (var folderObj in pageList)
            {
                addFolderViewToPanel(folderObj, i);
                i++;
            }

            pagerControl1.RecordCount = list.Count();
            pagerControl1.Bind();
        }

        /// <summary>
        /// 向主界面中添加文件夹
        /// </summary>
        /// <param name="folderObj"></param>
        void addFolderViewToPanel(FolderObj folderObj, int index = 0)
        {
            var folderView = new ImgControl(folderObj, ViewType.Folder);
            folderView.FolderViewClicked += FolderView_FolderViewClicked;
            folderView.FolderViewMouseDoubleClicked += FolderViewMouseDoubleClicked;
            folderView.RescanThumbnailsBuildFinished += FolderView_RescanThumbnailsBuildFinished;
            folderView.FolderDeleted += FolderView_FolderDeleted;
            folderView.Tag = index;
            mainPanel.Controls.Add(folderView);
        }

        /// <summary>
        /// 文件夹点击事件处理
        /// </summary>
        /// <param name="imgControl"></param>
        /// <param name="obj2"></param>
        private void FolderView_FolderViewClicked(ImgControl imgControl, Keys? key)
        {
            if (key == null) //没有按组合键，则为单选
            {
                foreach (Control control in mainPanel.Controls)
                {
                    if (control is ImgControl ic)
                    {
                        if (ic != imgControl)
                        {
                            ic.UnSelected();
                        }
                    }
                }
            }else if (key == Keys.Shift)
            {
                var curIndex = imgControl.Tag.ToInt();
                var otherIndex = -1;
                foreach (Control control in mainPanel.Controls)
                {
                    if (control is ImgControl ic)
                    {
                        if (ic != imgControl && ic.IsSelected)
                        {
                            otherIndex = ic.Tag.ToInt();
                            break;
                        }
                    }
                }

                if (otherIndex == -1) return;
                //根据大小确定顺序
                var begin = 0;
                var end = 0;
                if (otherIndex < curIndex)
                {
                    begin = otherIndex;
                    end = curIndex;
                }
                else
                {
                    begin = curIndex;
                    end = otherIndex;
                }
                foreach (Control control in mainPanel.Controls)
                {
                    if (control is ImgControl ic)
                    {
                        var i = ic.Tag.ToInt();
                        if (i >= begin && i <= end)
                        {
                            ic.Selected();
                        }
                    }
                }
            }
        }


        /// <summary>
        /// 删除当前所选择的文件夹或图片
        /// </summary>
        public void DeleteByCurSelected()
        {
            try
            {
                foreach (Control control in mainPanel.Controls)
                {
                    if (control is ImgControl ic)
                    {
                        if (!ic.IsSelected) continue;

                        if (CurIsFolderView) //删除文件夹
                        {
                            ss.DelFolder(ic.BaseObj as FolderObj);
                        }
                        else  //删除文件
                        {
                            ss.DelImgObj(ic.BaseObj as ImgObj);
                        }
                    }
                }
                ss.Save();

                if (CurIsFolderView)
                {
                    initFolderListView();
                }
                else
                {
                    initImageListView(pagerControl1.Tag as FolderObj);
                }

            }
            catch (Exception ex)
            {
                ss.Save();
                XMessage.Show(ex.Message);
            }
            
        }






        /// <summary>
        /// 当文件夹被删除后的回调
        /// </summary>
        /// <param name="obj"></param>
        private void FolderView_FolderDeleted(ImgControl obj)
        {
            initFolderListView();
        }

        private void FolderView_RescanThumbnailsBuildFinished(string message)
        {
            FolderRecanThumbnailsBuildFinished?.Invoke(message);
        }

        private void PagerControl1_OnFolderOnPageChanged(EventPagingArg e)
        {
            initFolderListView();
        }

        private void FolderViewMouseDoubleClicked(ImgControl obj, SortEnum sortEnum = SortEnum.AddTimeAsc, IEnumerable<ImgObj> list = null)
        {
            //存储导航属性
            LastPageIndex = pagerControl1.PageIndex;
            LastPageSize = pagerControl1.PageSize;

            pagerControl1.PageSize = pagerControl1.PageSize;
            pagerControl1.PageIndex = 1;
            pagerControl1.Tag = obj.BaseObj;
            pagerControl1.EventPaging -= PagerControl1_OnFolderOnPageChanged;
            pagerControl1.EventPaging -= PagerControl1_OnImageOnPageChanged;
            pagerControl1.EventPaging += PagerControl1_OnImageOnPageChanged;
            initImageListView(obj.BaseObj as FolderObj, sortEnum);

            PlaySexMusic(); 
        }

        /// <summary>
        /// 打开文件夹
        /// </summary>
        /// <param name="folderObj"></param>
        public void OpenFolder(FolderObj folderObj)
        {
            var folderView = new ImgControl(folderObj, ViewType.Folder);
            FolderViewMouseDoubleClicked(folderView);
        }



        void PlaySexMusic()
        {
            if (!ms.IsPlayMusic) return;
            new Action(() =>
            {
                var url = $@"{AppDomain.CurrentDomain.BaseDirectory}music\";
                var files = Directory.EnumerateFiles(url, "*.wav");
                var num = Tools.getRandomNum(1, 0, files.Count() - 1)[0];
                Util.PlayMusic(files.ElementAt(num));

            }).BeginInvoke(null, null);
        }


        


        void initImageListView(FolderObj folderObj, SortEnum sortEnum = SortEnum.AddTimeAsc)
        {
            mainPanel.Controls.Clear();
            LastSortEnum = sortEnum;

            var allData = SystemSettings.Singleton.AllImgFolderObjList.ImgObjList
                .Where(m => m.Folder == folderObj).OrderBySortEnum(sortEnum);

            var list = allData
                .Skip((pagerControl1.PageIndex - 1) * pagerControl1.PageSize)
                .Take(pagerControl1.PageSize);

            var i = 0;
            foreach (var imgObj in list)
            {
                var folderView = new ImgControl(imgObj, ViewType.Image, sortEnum, allData);
                folderView.FolderViewClicked += FolderView_FolderViewClicked;
                folderView.FolderViewMouseDoubleClicked += Util.ImgViewMouseDoubleClicked;
                folderView.Tag = i;
                mainPanel.Controls.Add(folderView);
                i++;
            }
            pagerControl1.RecordCount = allData.Count();
            pagerControl1.Bind();

            FolderAllImagesInited?.Invoke($"文件夹{folderObj.Name}图片总数量：{pagerControl1.RecordCount}");
        }

        private void PagerControl1_OnImageOnPageChanged(EventPagingArg e)
        {
            initImageListView(e.Tag as FolderObj);
        }

        /// <summary>
        /// 返回上一级
        /// </summary>
        public void BackToUp()
        {
            //当前是图片，直接返回文件夹视图
            if (!CurIsFolderView)
            {
                pagerControl1.PageIndex = LastPageIndex;
                pagerControl1.PageSize = LastPageSize;
                pagerControl1.EventPaging -= PagerControl1_OnFolderOnPageChanged;
                pagerControl1.EventPaging -= PagerControl1_OnImageOnPageChanged;
                pagerControl1.EventPaging += PagerControl1_OnFolderOnPageChanged;
                initFolderListView();
            }
            else
            {
                BackToHome();
            }
        }

        /// <summary>
        /// 返回到首页
        /// </summary>
        public void BackToHome()
        {
            pagerControl1.PageIndex = 1;
            pagerControl1.PageSize = LastPageSize;
            pagerControl1.EventPaging -= PagerControl1_OnFolderOnPageChanged;
            pagerControl1.EventPaging -= PagerControl1_OnImageOnPageChanged;
            pagerControl1.EventPaging += PagerControl1_OnFolderOnPageChanged;
            initFolderListView();
        }


    }
}
