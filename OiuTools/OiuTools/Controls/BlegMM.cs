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
using BlegMM.CControl;
using BlegMM.Model;
using DevExpress.XtraEditors;
using ESBasic;

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
        /// 当前是否为文件夹视图
        /// </summary>
        public bool CurIsFolderView => ((FolderView)mainPanel.Controls[0]).ViewType == ViewType.Folder;
        /// <summary>
        /// 当前的文件夹或图片对象
        /// </summary>
        public FiBaseObj CurFiBaseObj => ((FolderView)mainPanel.Controls[0]).FiBaseObj;
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
            foreach (var folderObj in pageList)
            {
                addFolderViewToPanel(folderObj);
            }

            pagerControl1.EventPaging += PagerControl1_OnFolderOnPageChanged;
            pagerControl1.RecordCount = list.Count();
            pagerControl1.Bind();
        }

        /// <summary>
        /// 向主界面中添加文件夹
        /// </summary>
        /// <param name="folderObj"></param>
        void addFolderViewToPanel(FolderObj folderObj)
        {
            var folderView = new ImgControl(folderObj, ViewType.Folder);
            //folderView.FolderViewClicked += FolderViewOnFolderViewClicked;
            folderView.FolderViewMouseDoubleClicked += FolderViewMouseDoubleClicked;
            mainPanel.Controls.Add(folderView);
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

            pagerControl1.PageSize = ss.PageSize;
            pagerControl1.PageIndex = 1;
            pagerControl1.Tag = obj.BaseObj;
            pagerControl1.EventPaging -= PagerControl1_OnFolderOnPageChanged;
            pagerControl1.EventPaging -= PagerControl1_OnImageOnPageChanged;
            pagerControl1.EventPaging += PagerControl1_OnImageOnPageChanged;
            initImageListView(obj.BaseObj as FolderObj, sortEnum);
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
            foreach (var imgObj in list)
            {
                var folderView = new FolderView(imgObj, ViewType.Image, sortEnum, allData);
                //folderView.FolderViewClicked += FolderViewOnFolderViewClicked;
                folderView.FolderViewMouseDoubleClicked += Tools.ImgViewMouseDoubleClicked;
                mainPanel.Controls.Add(folderView);
            }
            pagerControl1.RecordCount = allData.Count();
            pagerControl1.Bind();
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
                initFolderListView();
            }
            else
            {
                BackToHome();
            }
        }


        public void BackToHome()
        {
            pagerControl1.PageIndex = 1;
            pagerControl1.PageSize = LastPageSize;
            pagerControl1.EventPaging -= PagerControl1_OnFolderOnPageChanged;
            pagerControl1.EventPaging -= PagerControl1_OnImageOnPageChanged;
            initFolderListView();
        }


    }
}
