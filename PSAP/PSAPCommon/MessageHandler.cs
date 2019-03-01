using DevExpress.XtraEditors;
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
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();
        public MessageHandler()
        {
            PSAP.BLL.BSBLL.BSBLL.language(f);
        }

        /// <summary>
        /// 弹出提示消息框
        /// </summary>
        /// <param name="messageText">消息内容</param>
        public static void ShowMessageBox(string messageText)
        {
            //XtraMessageBox.Show(messageText, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            XtraMessageBox.Show(messageText, f.tsmiTs.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        /// <summary>
        /// 弹出提示消息框，带Yes和No两个按钮
        /// </summary>
        /// <param name="messageText">消息内容</param>
        public static DialogResult ShowMessageBox_YesNo(string messageText)
        {
            //return XtraMessageBox.Show(messageText, "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return XtraMessageBox.Show(messageText, f.tsmiTs.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }

        /// <summary>
        /// 弹出提示消息框，带Yes、No和Cancel三个按钮
        /// </summary>
        /// <param name="messageText">消息内容</param>
        public static DialogResult ShowMessageBox_YesNoCancel(string messageText)
        {
            //return XtraMessageBox.Show(messageText, "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            return XtraMessageBox.Show(messageText, f.tsmiTs.Text, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        }

        /// <summary>
        /// 弹出提示消息框，带OK和Cancel两个按钮
        /// </summary>
        /// <param name="messageText">消息内容</param>
        public static DialogResult ShowMessageBox_OKCancel(string messageText)
        {
            //return XtraMessageBox.Show(messageText, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            return XtraMessageBox.Show(messageText, f.tsmiTs.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        }

    }
}
