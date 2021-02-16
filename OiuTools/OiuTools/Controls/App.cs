using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlegMM;
using DevExpress.XtraEditors;
using OiuTools.Model;

namespace OiuTools.Controls
{
    public partial class App : XtraUserControl
    {
        private MySettings ms;
        public App()
        {
            InitializeComponent();
            ms = MySettings.Singleton;
        }

        private void App_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(MySettings.AppIconPath))
            {
                Directory.CreateDirectory(MySettings.AppIconPath);
            }

            if (ms.AppList.IsNotNullOrEmpty())
            {
                foreach (var app in ms.AppList)
                {
                    sp.Controls.Add(new SingleApp(app));
                }
            }
        }

        private void barAddApp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var file = fileDialog.FileName;

                //判断是否已存在
                if (ms.AppList.IsNotNullOrEmpty() && ms.AppList.Exists(m =>
                    string.Equals(m.AppUrl, file, StringComparison.OrdinalIgnoreCase)))
                {
                    XtraMessageBox.Show("APP已存在！");
                    return;
                }

                var shinfo = new SHFILEINFO();
                Win32.SHGetFileInfo(fileDialog.FileName, 0, ref shinfo, (uint)Marshal.SizeOf(shinfo), Win32.SHGFI_ICON | Win32.SHGFI_LARGEICON);
                var myIcon = Icon.FromHandle(shinfo.hIcon);



                var iconUrl = MySettings.AppIconPath + Guid.NewGuid().ToString().Replace("-","") + ".ico";
                var fileStream = new FileStream(iconUrl, FileMode.Create);
                myIcon.Save(fileStream);
                fileStream.Close();

                var appModel = new AppModel
                {
                    IconUrl = iconUrl,
                    AppUrl = file,
                    Name = fileDialog.SafeFileName.Replace(".exe", "")
                };
                var app = new SingleApp(appModel);
                sp.Controls.Add(app);
                ms.AppList.Add(appModel);
                ms.Save();
            }
        }

        private void flyoutPanelControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button!= MouseButtons.Right) return;
            popupMenu1.ShowPopup(Control.MousePosition);
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public IntPtr iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };
        class Win32
        {
            public const uint SHGFI_ICON = 0x100;
            public const uint SHGFI_LARGEICON = 0x0; // 'Large icon
            public const uint SHGFI_SMALLICON = 0x1; // 'Small icon
            [DllImport("shell32.dll")]
            public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);
            [DllImport("shell32.dll")]
            public static extern uint ExtractIconEx(string lpszFile, int nIconIndex, int[] phiconLarge, int[] phiconSmall, uint nIcons);
        }

        private void barRemoveApp_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }
    }
}
