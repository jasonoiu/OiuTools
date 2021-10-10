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


        /// <summary>
        /// 播放音乐
        /// </summary>
        /// <param name="musicUrl"></param>
        public static void PlayMusic(string musicUrl)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = musicUrl;
            player.LoadAsync();
            player.PlaySync();
        }




    }
}