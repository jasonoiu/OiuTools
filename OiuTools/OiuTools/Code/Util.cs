using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;
using BlegMM.Model;
using OiuTools.Controls;
using OiuTools.Views;

namespace OiuTools.Code
{
    /// <summary>
    /// 静态工具类
    /// </summary>
    public static class Util
    {
        public static void ImgViewMouseDoubleClicked(ImgControl obj, SortEnum sortEnum, IEnumerable<ImgObj> list)
        {
            var form = new frmImgShow(obj.BaseObj as ImgObj, sortEnum,list);
            form.Show();
            form.Focus();
        }


        /// <summary>
        /// 播放音乐
        /// </summary>
        /// <param name="musicUrl"></param>
        public static void PlayMusic(string musicUrl)
        {
            var player = new System.Media.SoundPlayer();
            player.SoundLocation = musicUrl;
            player.LoadAsync();
            player.PlaySync();
        }

        



    }
}