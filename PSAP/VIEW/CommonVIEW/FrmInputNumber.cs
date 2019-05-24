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
    public partial class FrmInputNumber : DockContent
    {
        public FrmInputNumber()
        {
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// 显示输入数字的窗体
        /// </summary>
        /// <param name="formText">窗体名称</param>
        /// <param name="textLabel">输入项名称</param>
        /// <param name="defaultValue">默认值</param>
        public static decimal ShowFrmInputNumber(string formText, string textLabel, decimal defaultValue)
        {
            FrmInputNumber form = new FrmInputNumber();
            form.Text = formText;
            form.labNumber.Text = textLabel;
            form.spinNumber.Value = defaultValue;
            if (form.ShowDialog() == DialogResult.OK)
            {
                return form.spinNumber.Value;
            }
            else
                return 0;
        }
    }
}
