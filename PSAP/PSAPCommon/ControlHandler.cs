﻿using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAP.PSAPCommon
{
    public class ControlHandler
    {
        /// <summary>
        /// 设定DevExpress控件的Enabled状态
        /// </summary>
        public void Set_Control_Enabled(Control ctl, bool enabledState)
        {
            string ctlStr = ctl.GetType().ToString();
            switch (ctlStr)
            {
                case "DevExpress.XtraEditors.TextEdit":
                    ((TextEdit)ctl).Enabled = enabledState;
                    break;
                case "DevExpress.XtraEditors.MemoEdit":
                    ((MemoEdit)ctl).Enabled = enabledState;
                    break;
                case "DevExpress.XtraEditors.RadioGroup":
                    ((RadioGroup)ctl).Enabled = enabledState;
                    break;
                case "DevExpress.XtraEditors.CheckEdit":
                    ((CheckEdit)ctl).Enabled = enabledState;
                    break;
                case "DevExpress.XtraEditors.ButtonEdit":
                    ButtonEdit btnEd = ((ButtonEdit)ctl);
                    btnEd.Enabled = enabledState;
                    if (btnEd.Properties.Buttons.Count > 0)
                    {
                        for (int i = 0; i < btnEd.Properties.Buttons.Count; i++)
                        {
                            btnEd.Properties.Buttons[i].Enabled = enabledState;
                        }
                    }
                    break;
                case "DevExpress.XtraEditors.SpinEdit":
                    ((SpinEdit)ctl).Enabled = enabledState;
                    break;
                case "DevExpress.XtraEditors.TimeEdit":
                    ((TimeEdit)ctl).Enabled = enabledState;
                    break;
                case "DevExpress.XtraEditors.DateEdit":
                    ((DateEdit)ctl).Enabled = enabledState;
                    break;
                case "DevExpress.XtraEditors.ComboBoxEdit":
                    ((ComboBoxEdit)ctl).Enabled = enabledState;
                    break;
                case "DevExpress.XtraEditors.LookUpEdit":
                    ((LookUpEdit)ctl).Enabled = enabledState;
                    break;
                case "DevExpress.XtraEditors.SearchLookUpEdit":
                    ((SearchLookUpEdit)ctl).Enabled = enabledState;
                    break;
                case "DevExpress.XtraEditors.ListBoxControl":
                    ((ListBoxControl)ctl).Enabled = enabledState;
                    break;
                case "DevExpress.XtraTreeList.TreeList":
                    ((TreeList)ctl).Enabled = enabledState;
                    break;
            }
        }

        /// <summary>
        /// 设定DevExpress控件的ReadOnly状态
        /// </summary>
        public void Set_Control_ReadOnly(Control ctl, bool readOnlyState)
        {
            string ctlStr = ctl.GetType().ToString();
            switch (ctlStr)
            {
                case "DevExpress.XtraEditors.TextEdit":
                    ((TextEdit)ctl).ReadOnly = readOnlyState;
                    break;
                case "DevExpress.XtraEditors.MemoEdit":
                    ((MemoEdit)ctl).ReadOnly = readOnlyState;
                    break;
                case "DevExpress.XtraEditors.RadioGroup":
                    ((RadioGroup)ctl).ReadOnly = readOnlyState;
                    break;
                case "DevExpress.XtraEditors.CheckEdit":
                    ((CheckEdit)ctl).ReadOnly = readOnlyState;
                    break;
                case "DevExpress.XtraEditors.ButtonEdit":
                    ButtonEdit btnEd = ((ButtonEdit)ctl);
                    btnEd.ReadOnly = readOnlyState;
                    if (btnEd.Properties.Buttons.Count > 0)
                    {
                        for (int i = 0; i < btnEd.Properties.Buttons.Count; i++)
                        {
                            btnEd.Properties.Buttons[i].Enabled = !readOnlyState;
                        }
                    }
                    break;
                case "DevExpress.XtraEditors.SpinEdit":
                    ((SpinEdit)ctl).ReadOnly = readOnlyState;
                    break;
                case "DevExpress.XtraEditors.TimeEdit":
                    ((TimeEdit)ctl).ReadOnly = readOnlyState;
                    break;
                case "DevExpress.XtraEditors.DateEdit":
                    ((DateEdit)ctl).ReadOnly = readOnlyState;
                    break;
                case "DevExpress.XtraEditors.ComboBoxEdit":
                    ((ComboBoxEdit)ctl).ReadOnly = readOnlyState;
                    break;
                case "DevExpress.XtraEditors.LookUpEdit":
                    ((LookUpEdit)ctl).ReadOnly = readOnlyState;
                    break;
                case "DevExpress.XtraEditors.SearchLookUpEdit":
                    ((SearchLookUpEdit)ctl).ReadOnly = readOnlyState;
                    break;
                case "DevExpress.XtraEditors.ListBoxControl":
                    ((ListBoxControl)ctl).Enabled = !readOnlyState;
                    break;
                case "DevExpress.XtraTreeList.TreeList":
                    ((TreeList)ctl).Enabled = !readOnlyState;
                    break;
            }
        }

    }
}
