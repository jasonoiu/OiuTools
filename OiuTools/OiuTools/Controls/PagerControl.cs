using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlegMM;
using DevExpress.XtraEditors;

namespace OiuTools.Controls
{
    public delegate void EventPagingHandler(EventPagingArg e);

    [ToolboxItem(true)]
    public partial class PagerControl : XtraUserControl
    {
        #region 构造函数

        public PagerControl()
        {
            InitializeComponent();

        }

        private void setCountPageText()
        {
            this.lblCountPage.Text = $"{PageIndex}/{this.PageCount}";
        }


        #endregion

        #region 分页字段和属性


        /// <summary>
        /// 当前页面
        /// </summary>
        public int PageIndex { get; set; } = 1;

        /// <summary>
        /// 每页记录数
        /// </summary>
        public int PageSize { get; set; }

        private long recordCount = 0;
        /// <summary>
        /// 总记录数
        /// </summary>
        public long RecordCount
        {
            get => recordCount;
            set
            {
                recordCount = value;
                GetPageCount();
                Bind();
            }
        }

        /// <summary>
        /// 总页数
        /// </summary>
        public int PageCount { get; set; } = 0;

        #endregion

        #region 页码变化触发事件
        public event EventPagingHandler EventPaging;

        private void hideButton()
        {
            for (var i = 0; i < 9; i++)
            {
                var c = (SimpleButton)this.Controls.Find("b" + (i + 1), true)[0];
                c.Visible = true;
            }
        }

        /// <summary>
        /// 翻页控件数据绑定的方法
        /// </summary>
        public void Bind()
        {

            if (this.PageIndex > this.PageCount)
            {
                this.PageIndex = this.PageCount;
            }
            if (this.PageCount == 1)
            {
                this.PageIndex = 1;
            }
            if (PageIndex == 1)
            {

            }
            var reg = new Regex(@"  \d*  ");
            setCountPageText();
            
            //页码设置
            var lst = new List<int>();
            if (PageCount <= 9)
            {
                for (var i = 1; i <= PageCount; i++)
                {
                    lst.Add(i);
                }
            }
            else
            {
                if (this.PageIndex <= 6)
                {
                    for (var i = 1; i <= 7; i++)
                    {
                        lst.Add(i);
                    }
                    lst.Add(-1);
                    lst.Add(PageCount);
                }
                else if (this.PageIndex > PageCount - 6)
                {
                    lst.Add(1);
                    lst.Add(-1);
                    for (var i = PageCount - 6; i <= PageCount; i++)
                    {
                        lst.Add(i);
                    }
                }
                else
                {
                    lst.Add(1);
                    lst.Add(-1);
                    var begin = PageIndex - 2;
                    var end = PageIndex + 2;
                    if (end > PageCount)
                    {
                        end = PageCount;
                        begin = end - 4;
                        if (PageIndex - begin < 2)
                        {
                            begin = begin - 1;
                        }
                    }
                    else if (end + 1 == PageCount)
                    {
                        end = PageCount;
                    }
                    for (var i = begin; i <= end; i++)
                    {
                        lst.Add(i);
                    }
                    if (end != PageCount)
                    {
                        lst.Add(-1);
                        lst.Add(PageCount);
                    }
                }
            }
            var w = 8; //页码间距
            var locationX = btnPrePage.Width + w; //累积的x坐标
            var yPoint = 7;
            //设置页码
            //设置位置
            var visibleCount = 0;
            for (var i = 0; i < 9; i++)
            {
                var c = (SimpleButton)this.Controls.Find("b" + (i + 1), true)[0];
                if (i >= lst.Count)
                {
                    c.Visible = false;
                }
                else
                {
                    if (lst[i] == -1)
                    {
                        c.Text = "...";
                        c.Enabled = false;
                    }
                    else
                    {
                        c.Text = lst[i].ToString();
                        c.Enabled = true;
                    }
                    c.Visible = true;
                    visibleCount++;

                    c.Location = new Point(locationX, yPoint);
                    locationX = locationX + c.Width + w;
                    if (lst[i] == PageIndex || (PageIndex == 0 && lst[i] == 1))
                    {
                        c.ForeColor = Color.SteelBlue;
                        c.Focus();
                    }
                    else
                    {
                        c.ForeColor = Color.Black;
                    }
                }
            }

            this.btnNextPage.Location = new Point(locationX, yPoint);
            locationX = locationX + btnNextPage.Width + w;
            this.lblCountPage.Location = new Point(locationX, yPoint+4);
            locationX = locationX + lblCountPage.Width + w;

            this.txtPageIndex.Location = new Point(locationX + 15, yPoint);
            locationX = locationX + txtPageIndex.Width + 3;
            this.btnGO.Location = new Point(locationX, yPoint);
        }

        #endregion

        #region 分页及相关事件功能实现

        /// <summary>
        /// 计算总页数
        /// </summary>
        /// <returns></returns>
        private void GetPageCount()
        {
            if (PageSize == 0)
            {
                PageSize = 18;
                this.PageCount = 0;
            }
            var pageCount = (int)RecordCount / PageSize;
            if (RecordCount % PageSize == 0)
            {
                this.PageCount = (int)RecordCount / PageSize;
            }
            else
            {
                this.PageCount = (int)RecordCount / PageSize + 1;
            }
            var reg = new Regex(@"  \d*  ");
            setCountPageText();
        }

        #endregion

        #region 相关控件事件
        //下页
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.EventPaging == null || PageIndex == PageCount) return;
                this.PageIndex += 1;
                if (PageIndex > PageCount)
                {
                    PageIndex = PageCount;
                }
                this.Bind();
                this.EventPaging?.Invoke(new EventPagingArg(this.PageIndex,this.Tag));
            }
            catch (Exception)
            {

            }


        }

        //上页
        private void btnPrePage_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.EventPaging == null || PageIndex <= 1) return;
                this.PageIndex -= 1;
                if (PageIndex <= 0)
                {
                    PageIndex = 1;
                }
                this.Bind();
                this.EventPaging?.Invoke(new EventPagingArg(this.PageIndex, this.Tag));
            }
            catch (Exception)
            {

            }


        }

        //页码
        private void Page_BtnClick(object sender, EventArgs e)
        {
            try
            {
                if (this.EventPaging == null) return;
                PageIndex = ((SimpleButton) sender).Text.ToInt();
                this.Bind();
                this.EventPaging?.Invoke(new EventPagingArg(this.PageIndex, this.Tag));
            }
            catch (Exception)
            {

            }


        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            var pageIndex = txtPageIndex.Text.Trim().ToInt();
            if (pageIndex <= 0) return;
            PageIndex = pageIndex;
            this.Bind();
            this.EventPaging?.Invoke(new EventPagingArg(this.PageIndex, this.Tag));
        }
        #endregion

        //private void PageSizeCB_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (this.EventPaging == null) return;
        //        PageSize = int.Parse(PageSizeCB.SelectedItem.ToString());
        //        this.pageIndex = 1;
        //        if (IsSaveXML)
        //        {
        //            ss.PageSize = int.Parse(PageSizeCB.SelectedItem.ToString());
        //            ss.Save();
        //        }
        //        this.Bind();
        //        this.EventPaging(new EventPagingArg(1));
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}
    }

    /// <summary>
    /// 自定义事件数据基类
    /// </summary>
    public class EventPagingArg : EventArgs
    {
        public int PageIndex;
        public object Tag;
        public EventPagingArg(int pageIndex, object tag)
        {
            PageIndex = pageIndex;
            Tag = tag;
        }
    }
}

