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
using ESBasic;

namespace OiuTools.Controls
{
    public partial class ImgControl : DevExpress.XtraEditors.XtraUserControl
    {
        public FiBaseObj BaseObj;
        private MySettings ms;
        private SystemSettings ss;

        /// <summary>
        /// 控件被点击时
        /// </summary>
        public event CbGeneric<ImgControl> FolderViewClicked;

        /// <summary>
        /// 控件被双击时
        /// </summary>
        public event CbGeneric<ImgControl, SortEnum, IEnumerable<ImgObj>> FolderViewMouseDoubleClicked;

        /// <summary>
        /// 从当前壁纸移除时发生
        /// </summary>
        public event CbGeneric<ImgControl> RemoveFromCurWallPaperList;

        /// <summary>
        /// 从最爱美女列表中移除时发生
        /// </summary>
        public event CbGeneric<ImgControl> RemoveFromTopLoveMMList;

        public ImgControl(FiBaseObj fiBaseObj, ViewType viewType, SortEnum sortEnum = SortEnum.AddTimeAsc,
            IEnumerable<ImgObj> list = null)
        {
            InitializeComponent();
            ms = MySettings.Singleton;
            ss = SystemSettings.Singleton;

            BaseObj = fiBaseObj;
            lblName.Text = fiBaseObj.Name;
            this.CurSortEnum = sortEnum;
            this.CurImgList = list;
            this.ViewType = viewType;

            //如果是文件夹
            if (viewType == ViewType.Folder)
            {
                //this.ContextMenuStrip = skinContextMenu_Folder;
                var fo = (FolderObj)fiBaseObj;
                if (fo.CoverImg != null)
                    this.pic.Image = fo.CoverImg.GetThumbnails();
            }
            else if (viewType == ViewType.Image)
            {
                //this.ContextMenuStrip = skinContextMenu_Image;
                this.pic.Image = ((ImgObj)fiBaseObj).GetThumbnails();
            }
        }

        public IEnumerable<ImgObj> CurImgList { get; set; }
        public SortEnum CurSortEnum { get; set; }
        /// <summary>
        /// 视图类型
        /// </summary>
        public ViewType ViewType { get; }

        public ImgObj imgObj => (ImgObj) BaseObj;

        private void FolderView_Click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (ViewType == ViewType.Folder)
                {
                    popFolderMenu.ShowPopup(this.PointToScreen(e.Location));
                }else if (ViewType == ViewType.Image)
                {
                    popImgMenu.ShowPopup(this.PointToScreen(e.Location));
                }
            }
            FolderViewClicked?.Invoke(this);
        }

        private void FolderView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FolderViewMouseDoubleClicked?.Invoke(this, CurSortEnum, CurImgList);
        }

        private void barAddToWallPaperList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var folderObj = (FolderObj)BaseObj;
            var lists = ss.AllImgFolderObjList.ImgObjList.Where(m =>
                m.Folder == folderObj && m.IsLove);
            foreach (var imgObj in lists)
            {
                if (ss.CurWallPagerList.Any(m => m.Id == imgObj.Id)) continue;
                if (!imgObj.IsSetedSize)
                {
                    Tools.SetImageIsPcSize(imgObj);
                }

                ss.CurWallPagerList.Add(new WallPaper
                {
                    FileUrl = imgObj.FileUrl,
                    Id = imgObj.Id,
                    Name = imgObj.Name
                });
            }

            ss.Save();
        }

        private void barRemoveFromWallPaper_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var folderObj = (FolderObj)BaseObj;
            var lists = ss.AllImgFolderObjList.ImgObjList.Where(m =>
                m.Folder == folderObj && m.IsLove);
            foreach (var imgObj in lists)
            {
                ss.CurWallPagerList.RemoveAll(m => m.Id == imgObj.Id);
            }

            ss.Save();
        }

        private void barAddToNewWallPaperList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var folderObj = (FolderObj)BaseObj;
            var lists = ss.AllImgFolderObjList.ImgObjList.Where(m => m.Folder == folderObj);
            ss.CurWallPagerList = new List<WallPaper>();
            foreach (var imgObj in lists)
            {
                ss.CurWallPagerList.Add(new WallPaper
                {
                    FileUrl = imgObj.FileUrl,
                    Id = imgObj.Id,
                    Name = imgObj.Name
                });
            }

            ss.Save();
        }

        private void barSetAsCover_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            imgObj.Folder.CoverImg = imgObj;
            SystemSettings.Singleton.Save();
        }
    }
}
