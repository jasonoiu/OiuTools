using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlegMM;
using BlegMM.Model;
using OiuTools.Properties;

namespace OiuTools.Views
{
    public partial class frmImgShow : BaseForm
    {
        public frmImgShow(ImgObj imgObj, SortEnum sortEnum, IEnumerable<ImgObj> list)
        {
            InitializeComponent();
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            InitByImgObj(imgObj, sortEnum, list);
        }

        private ImgObj CurImgObj { get; set; }

        private IEnumerable<ImgObj> FolderImgList { get; set; }

        private int CurImgIndex { get; set; }

        private SortEnum CurSort { get; set; }

        void InitByImgObj(ImgObj imgObj, SortEnum sortEnum = SortEnum.AddTimeAsc, IEnumerable<ImgObj> list = null)
        {
            CurImgObj = imgObj;
            //starLevelControl1.Init(imgObj);
            //starLevelControl1.StarLevelClicked -= starLevel_Clicked;
            //starLevelControl1.StarLevelClicked += starLevel_Clicked;

            pic.Image?.Dispose();
            pic.Image = CurImgObj.FileUrl.ToImage();
            this.Text = $"{CurImgObj.MmName}---{CurImgObj.Name}---{CurImgObj.AddTime.ToShortDateString()}";

            this.CurSort = sortEnum;
            if (list == null || !list.Any())
            {
                FolderImgList = SystemSettings.Singleton.AllImgFolderObjList.ImgObjList
                    .Where(m => m.Folder == CurImgObj.Folder).OrderBySortEnum(sortEnum);
            }
            else
            {
                FolderImgList = list;
            }
            CurImgIndex = FolderImgList.Select((obj, index) => new { ImgObj = obj, Index = index })
                .FirstOrDefault(m => m.ImgObj.Id == CurImgObj.Id)
                .Index;
            //btnPre.Enabled = CurImgIndex > 0;
            //btnNext.Enabled = CurImgIndex < FolderImgList.Count() - 1;

            if (CurImgObj.IsLove && CurImgObj.Level == 0)
            {
                CurImgObj.Level = 1;
            }

            picRating.Rating = CurImgObj.Level;

            if (CurImgObj.ThumbnailsUrl.IsNullOrEmpty())
            {
                CurImgObj.buildThumbnails();
            }
        }


        void windowsUIButtonPanel_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Close")
            {
                this.Close();
                this.Dispose();
            }else if (e.Button.Properties.Caption == "Pre")
            {
                Pre();
            }
            else if (e.Button.Properties.Caption == "Next")
            {
                Next();
            }
            else if (e.Button.Properties.Caption == "Delete")
            {
                SystemSettings.Singleton.DelImgObj(CurImgObj);
                Next();
            }
            else if (e.Button.Properties.Caption == "WallPaper")
            {
                Tools.SetWallPaper(pic.Image);
            }
        }

        private void picRating_ItemClick(object sender, DevExpress.XtraEditors.Repository.ItemEventArgs e)
        {
            CurImgObj.Level = picRating.Rating.ToInt();
            if (CurImgObj.Level == 0) CurImgObj.IsLove = false;
        }

        void Pre()
        {
            if (CurImgIndex == 0) return;
            var imgObj = FolderImgList.ElementAtOrDefault(CurImgIndex - 1);
            InitByImgObj(imgObj, this.CurSort, FolderImgList);
        }

        void Next()
        {
            if (CurImgIndex + 1 > FolderImgList.Count() - 1) return;
            var imgObj = FolderImgList.ElementAtOrDefault(CurImgIndex + 1);
            InitByImgObj(imgObj, this.CurSort, FolderImgList);
        }

        void SetImgLevel(int level)
        {
            CurImgObj.IsLove = level > 0;
            CurImgObj.Level = level;
            picRating.Rating = CurImgObj.Level;
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Space:
                    SetImgLevel(1);
                    Next();
                    return true;
                case Keys.Right:
                    Next();
                    return true;
                case Keys.Left:
                    Pre();
                    return true;
                case Keys.Down:
                    SetImgLevel(1);
                    return true;
                case Keys.D1:
                case Keys.NumPad1:
                    SetImgLevel(1);
                    return true;
                case Keys.D2:
                case Keys.NumPad2:
                    SetImgLevel(2);
                    return true;
                case Keys.D3:
                case Keys.NumPad3:
                    SetImgLevel(3);
                    return true;
                case Keys.D4:
                case Keys.NumPad4:
                    SetImgLevel(4);
                    return true;
                case Keys.D5:
                case Keys.NumPad5:
                    SetImgLevel(5);
                    return true;
                case Keys.D0:
                case Keys.NumPad0:
                    SetImgLevel(0);
                    return true;
                case Keys.Escape:
                    this.Close();
                    return true;

            }

            return false;
        }
    }
}
