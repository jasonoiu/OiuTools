using System;

namespace OiuTools.Model
{
    /// <summary>
    /// APP程序
    /// </summary>
    [Serializable]
    public class AppModel
    {
        public string IconUrl { get; set; }

        public string Name { get; set; }

        public string AppUrl { get; set; }
    }
}