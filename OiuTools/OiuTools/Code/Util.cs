using System.Collections.Generic;
using BlegMM.Model;
using OiuTools.Controls;
using OiuTools.Views;

namespace OiuTools.Code
{
    public class Util
    {
        public static void ImgViewMouseDoubleClicked(ImgControl obj, SortEnum sortEnum, IEnumerable<ImgObj> list)
        {
            var form = new frmImgShow(obj.BaseObj as ImgObj, sortEnum,list);
            form.Show();
            form.Focus();
        }
    }
}