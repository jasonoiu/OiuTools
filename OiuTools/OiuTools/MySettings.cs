using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using BlegMM;
using BlegMM.Model;
using OiuTools.Model;

namespace OiuTools
{
    /// <summary>
    /// 系统设置。保存用户设置的数据
    /// </summary>
    [Serializable]
    public class MySettings
    {
        public static readonly string SystemSettingsDir = System.AppDomain.CurrentDomain.BaseDirectory;
        private static readonly string SystemSettingsFilePath = SystemSettingsDir + "MySettings.dat";
        public static readonly string AppIconPath = SystemSettingsDir + @"AppIcon\";


        private static MySettings singleton;

        /// <summary>
        /// 单例模式。
        /// </summary>
        public static MySettings Singleton
        {
            get
            {
                if (singleton != null) return singleton;
                singleton = InitAndLoadSystemSettings();
                return singleton;
            }
        }

        private MySettings() { }

        /// <summary>
        /// APP列表
        /// </summary>
        public List<AppModel> AppList { get; set; }

        /// <summary>
        /// 皮肤
        /// </summary>
        public string SkinName { get; set; }

        /// <summary>
        /// 颜色
        /// </summary>
        public string PaletteName { get; set; }

        public int BlegMMPageSize { get; set; }
        /// <summary>
        /// 窗体坐标
        /// </summary>
        public Point LastLocation { get; set; }

        /// <summary>
        /// 点击关闭按钮的时候，是否退出程序。
        /// </summary>
        public bool ExitWhenCloseMainForm { get; set; } = false;

        /// <summary>
        /// 随系统自动启动
        /// </summary>
        public bool AutoStartUp { get; set; } = false;
        

        #region MainFormSize
        private Size mainFormSize = new Size(958, 770);
        /// <summary>
        /// 主窗体的大小
        /// </summary>
        public Size MainFormSize
        {
            get
            {
                if (this.mainFormSize == new Size(0, 0) || this.mainFormSize.Width < 958)
                {
                    this.mainFormSize = new Size(958, 770);
                }
                return mainFormSize;
            }
            set => mainFormSize = value;
        }
        #endregion

        
        /// <summary>
        /// 保存数据和设置
        /// </summary>
        public void Save()
        {
            var data = ESBasic.Helpers.SerializeHelper.SerializeObject(this);
            ESBasic.Helpers.FileHelper.WriteBuffToFile(data, SystemSettingsFilePath);
        }

        /// <summary>
        /// 每天备份文件
        /// </summary>
        public void BackUpFile()
        {
            if (!File.Exists(SystemSettingsFilePath)) return;

            var backFileName = $"{SystemSettingsFilePath.Replace(".dat", "")} - {DateTime.Now:yyyyMMdd}.dat";
            //检查今天是否有备份过
            if (File.Exists(backFileName)) return;

            File.Copy(SystemSettingsFilePath, backFileName);
        }


        /// <summary>
        /// 初始化对象
        /// </summary>
        /// <returns></returns>
        private static MySettings InitAndLoadSystemSettings()
        {
            try
            {
                MySettings ss = null;
                //初次初始化
                if (!File.Exists(SystemSettingsFilePath))
                {
                    ss = new MySettings();
                    ss.Save();
                }
                else
                {
                    var data = ESBasic.Helpers.FileHelper.ReadFileReturnBytes(SystemSettingsFilePath);
                    ss = (MySettings)ESBasic.Helpers.SerializeHelper.DeserializeBytes(data, 0, data.Length);
                }

                PreInitialize(ss);
                return ss;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        /// <summary>
        /// 预初始化
        /// </summary>
        private static void PreInitialize(MySettings ss)
        {
            if (ss.AppList == null)
            {
                ss.AppList = new List<AppModel>();
            }
            


        }

    }
}