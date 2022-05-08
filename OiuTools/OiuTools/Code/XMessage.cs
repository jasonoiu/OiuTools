using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OiuTools.Code
{
    /// <summary>
    /// 弹出消息提示框
    /// </summary>
    public static class XMessage
    {

        /// <summary>
        /// 弹出确认提示框
        /// </summary>
        /// <param name="message">消息</param>
        /// <returns></returns>
        public static DialogResult Confirm(string message)
        {
            return XtraMessageBox.Show(message, "温馨提示", MessageBoxButtons.YesNo);
        }


        /// <summary>
        /// 显示提示框
        /// </summary>
        /// <param name="message">消息</param>
        /// <returns></returns>
        public static DialogResult Show(string message)
        {
            return XtraMessageBox.Show(message, "温馨提示");
        }

    }
}