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
using BlegMM.Model;
using DevExpress.XtraEditors;
using ESBasic;

namespace OiuTools.Controls
{
    
    public partial class BestLoveMM : XtraUserControl
    {
        private DataTable DataSource;
        private MySettings ms;
        private SystemSettings ss;
        /// <summary>
        /// 壁纸改变事件
        /// </summary>
        public event CbGeneric WallPaperChanged;
        /// <summary>
        /// 打开文件夹事件
        /// </summary>
        public event CbGeneric<FolderObj> OpenFolderEvent;
        
        public BestLoveMM()
        {
            InitializeComponent();
            ms = MySettings.Singleton;
            ss = SystemSettings.Singleton;
            SystemSettings.BestLoveMMListChanged += Ss_BestLoveMMListChanged;
            
        }

        private void Ss_BestLoveMMListChanged()
        {
            BindData();
        }

        void BindData()
        {
            DataSource = new DataTable();
            var image = new DataColumn("Image", typeof(Image));
            var caption = new DataColumn("Caption", typeof(string));
            var value = new DataColumn("Value", typeof(Guid));
            DataSource.Columns.AddRange(new[] { image, caption, value });

            foreach (var wallPaper in ss.BestLoveMMWallPaperLists.ReverseOrder())
            {
                DataSource.Rows.Add(new object[] { new Bitmap(wallPaper.getImgObj().ThumbnailsUrl), wallPaper.Name, wallPaper.Id });
            }

            if (DataSource == null || DataSource.Rows.Count == 0) return;
            imgContainer.DisplayMember = "Caption";
            imgContainer.ValueMember = "Value";
            imgContainer.ImageMember = "Image";
            imgContainer.DataSource = DataSource;
        }

        

        private void BestLoveMM_Load(object sender, EventArgs e)
        {
            BindData();
        }

        private void imgContainer_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Left)return;
            popMenu.ShowPopup(this.PointToScreen(e.Location));
        }

        private void barDel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = (Guid) imgContainer.SelectedValue;
            ss.RemoveWallPaperFromBestLoveMM(id);
        }

        private void barSetWallPaper_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = (Guid)imgContainer.SelectedValue;
            var wallPaper = ss.BestLoveMMWallPaperLists.FirstOrDefault(m => m.Id == id);
            if(wallPaper==null) return;
            var imgObj = wallPaper.getImgObj();
            if (imgObj.IsPcWallPaperSize)
            {
                Tools.SetWallPaper(imgObj.FileUrl);
                return;
            }
            //如果是窄图片，如合并两张图片作为壁纸
            var imgObj2 = chooseAnotherImg().ToImage();

            var combinImg = Tools.CombinTwoImage(imgObj.FileUrl.ToImage(), imgObj2);

            if (combinImg == null)
            {
                XtraMessageBox.Show($"combinImg为null值");
                return;
            }

            Tools.SetWallPaper(combinImg);
            WallPaperChanged?.Invoke();
        }

        string chooseAnotherImg()
        {
            var wp = ss.BestLoveMMWallPaperLists.ElementAt(Tools.getRandomNum(1, 0, ss.BestLoveMMWallPaperLists.Count - 1)[0]);
            var img = wp.getImgObj();
            if (!img.IsPcWallPaperSize) return img.FileUrl;

            return chooseAnotherImg();
        }

        private void barFirstMergeWp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = (Guid)imgContainer.SelectedValue;
            var wallPaper = ss.BestLoveMMWallPaperLists.FirstOrDefault(m => m.Id == id);
            if (wallPaper == null) return;
            ss.DicMergeWallPaper["one"] = wallPaper.FileUrl;
        }

        private void barSecondMergeWp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = (Guid)imgContainer.SelectedValue;
            var wallPaper = ss.BestLoveMMWallPaperLists.FirstOrDefault(m => m.Id == id);
            if (wallPaper == null) return;
            ss.DicMergeWallPaper["two"] = wallPaper.FileUrl;
        }

        private void barOpenFolder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var id = (Guid)imgContainer.SelectedValue;
            var folderObj = ss.AllImgFolderObjList.ImgObjList.FirstOrDefault(m => m.Id == id).Folder;
            OpenFolderEvent?.Invoke(folderObj);
        }
    }
}
