using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils;

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

    /// <summary>
    /// 自定义消息框窗体，最多支持8个按钮
    /// </summary>
    class CustomXtraMessageBoxForm : XtraMessageBoxForm
    {
        //调用方法
        //int result = new CustomXtraMessageBoxForm().ShowMessageBox("请选择要存为 Excel 的查询记录：", new string[] { "当前页面记录", "全部查询记录", "取消" });
        //MessageHandler.ShowMessageBox(result.ToString());

        /// <summary>
        /// 按钮对应的结果数组
        /// </summary>
        DialogResult[] dialogResultArray;
        /// <summary>
        /// 按钮对应的文本数组
        /// </summary>
        string[] btnTextArray;

        /// <summary>
        /// 显示自定义消息框，最多支持8个按钮
        /// </summary>
        /// <param name="textStr">消息框文本</param>
        /// <param name="btnTextStrs">按钮对应的文本数组</param>
        public int ShowMessageBox(string textStr, string[] btnTextStrs)
        {
            btnTextArray = btnTextStrs;
            dialogResultArray = new DialogResult[btnTextStrs.Length];
            for (int i = 0; i < btnTextStrs.Length; i++)
            {
                switch (i)
                {
                    case 0:
                        dialogResultArray[0] = DialogResult.Yes;
                        break;
                    case 1:
                        dialogResultArray[1] = DialogResult.No;
                        break;
                    case 2:
                        dialogResultArray[2] = DialogResult.Abort;
                        break;
                    case 3:
                        dialogResultArray[3] = DialogResult.Ignore;
                        break;
                    case 4:
                        dialogResultArray[4] = DialogResult.Retry;
                        break;
                    case 5:
                        dialogResultArray[5] = DialogResult.OK;
                        break;
                    case 6:
                        dialogResultArray[6] = DialogResult.Cancel;
                        break;
                    case 7:
                        dialogResultArray[7] = DialogResult.None;
                        break;
                }
            }

            XtraMessageBoxArgs msgBoxArgs = new XtraMessageBoxArgs(this, textStr, "提示", dialogResultArray, System.Drawing.Icon.FromHandle(System.Drawing.SystemIcons.Exclamation.Handle), 0);
            
            DialogResult result = ShowMessageBoxDialog(msgBoxArgs);
            for (int i = 0; i < dialogResultArray.Length; i++)
            {
                if (dialogResultArray[i] == result)
                    return i;
            }
            return -1;
        }

        /// <summary>
        /// 重写得到按钮文本方法
        /// </summary>
        protected override string GetButtonText(DialogResult target)
        {
            for (int i = 0; i < dialogResultArray.Length; i++)
            {
                if (dialogResultArray[i] == target)
                {
                    return btnTextArray[i];
                }
            }
            return base.GetButtonText(target);
        }

    }
}
