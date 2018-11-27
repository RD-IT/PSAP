using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAP.PSAPCommon
{
    class MessageHandler
    {
        public static void ShowMessageBox(string messageText)
        {
            DevExpress.XtraEditors.XtraMessageBox.Show(messageText, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowMessageBox_YesNo(string messageText)
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(messageText, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult ShowMessageBox_YesNoCancel(string messageText)
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(messageText, "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public static DialogResult ShowMessageBox_OKCancel(string messageText)
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(messageText, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }
    }
}
