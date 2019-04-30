using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Drawing;

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

        /// <summary>
        /// 根据DevExpress的样式不同，改变控件的位置
        /// </summary>
        public static void DevExpressStyle_ChangeControlLocation(string devExpressStyleStr, List<Control> controlList)
        {
            switch (devExpressStyleStr)
            {
                case "DevExpress Style":
                case "Foggy":
                case "Metropolis":
                case "Metropolis Dark":
                case "Office 2010 Black":
                case "Office 2010 Blue":
                case "Office 2010 Silver":
                case "Office 2013":
                case "Office 2013 Dark Gray":
                case "Office 2013 Light Gray":
                case "Office 2016 Colorful":
                case "Office 2016 Dark":
                case "Seven":
                case "Seven Classic":
                case "Sharp":
                case "Sharp Plus":
                case "Visual Studio 2013 Blue":
                case "Visual Studio 2013 Dark":
                case "Visual Studio 2013 Light":
                case "VS2010":
                case "Whiteprint":

                    break;
                default:
                    foreach (Control ctl in controlList)
                    {
                        ctl.Location = new Point(ctl.Location.X + 1, ctl.Location.Y + 1);
                    }
                    break;
            }
        }

        /// <summary>
        /// GridView复制显示的信息到剪贴板中
        /// </summary>
        /// <param name="sender">GridView对象</param>
        /// <param name="e">KeyDown事件的参数</param>
        public static void GridView_GetFocusedCellDisplayText_KeyDown(object sender, KeyEventArgs e)
        {
            GridView gridView = (GridView)sender;
            if (e.Control & e.KeyCode == Keys.C)
            {
                string displayText = DataTypeConvert.GetString(gridView.GetFocusedRowCellDisplayText(gridView.FocusedColumn));
                Clipboard.SetDataObject(displayText);
                e.Handled = true;
            }
        }

        /// <summary>
        /// TreeList复制显示的信息到剪贴板中
        /// </summary>
        /// <param name="sender">TreeList对象</param>
        /// <param name="e">KeyDown事件的参数</param>
        public static void TreeList_GetFocusedCellDisplayText_KeyDown(object sender, KeyEventArgs e)
        {
            TreeList treeList = (TreeList)sender;
            if (e.Control & e.KeyCode == Keys.C)
            {
                string displayText = DataTypeConvert.GetString(treeList.FocusedNode[treeList.FocusedColumn]);
                Clipboard.SetDataObject(displayText);
                e.Handled = true;
            }
        }

        /// <summary>
        /// GridView设置显示的行号
        /// </summary>
        public static void GridView_CustomDrawRowIndicator(RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// TreeList设置显示根节点的行号
        /// </summary>
        public static void TreeList_CustomDrawNodeIndicator_RootNode(object sender, DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventArgs e)
        {
            TreeList tmpTree = sender as TreeList;
            IndicatorObjectInfoArgs args = e.ObjectArgs as IndicatorObjectInfoArgs;
            if (args != null)
            {
                if (tmpTree.Nodes.Contains(e.Node))
                {
                    int rowNum = tmpTree.GetNodeIndex(e.Node) + 1;
                    //this.treeList.IndicatorWidth = rowNum.ToString().Length * 10 + 10;
                    args.DisplayText = rowNum.ToString();
                }
            }
        }

        /// <summary>
        /// TreeList设置显示所有节点的行号
        /// </summary>
        public static void TreeList_CustomDrawNodeIndicator_AllNode(object sender, DevExpress.XtraTreeList.CustomDrawNodeIndicatorEventArgs e)
        {
            TreeList tmpTree = sender as TreeList;
            IndicatorObjectInfoArgs args = e.ObjectArgs as IndicatorObjectInfoArgs;
            if (args != null)
            {
                int rowNum = tmpTree.GetVisibleIndexByNode(e.Node) + 1;
                //this.treeList.IndicatorWidth = rowNum.ToString().Length * 10 + 10;
                args.DisplayText = rowNum.ToString();
            }
        }
    }
}
