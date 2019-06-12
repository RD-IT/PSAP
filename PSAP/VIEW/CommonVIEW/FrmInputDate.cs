using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmInputDate : DockContent
    {
        public FrmInputDate()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 显示输入日期的窗体
        /// </summary>
        /// <param name="formText">窗体名称</param>
        /// <param name="textLabel">输入项名称</param>
        /// <param name="defaultValue">默认值</param>
        public static bool ShowFrmInputDate(string formText, string textLabel, DateTime defaultValue,ref DateTime DateValue)
        {
            FrmInputDate form = new FrmInputDate();
            form.Text = formText;
            form.labNumber.Text = textLabel;
            form.dateValue.DateTime = defaultValue;
            if (form.ShowDialog() == DialogResult.OK)
            {
                DateValue = form.dateValue.DateTime.Date;
                return true;
            }
            else
                return false;
        }
    }
}
