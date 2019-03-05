using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraTreeList.Nodes;
using PSAP.DAO.INVDAO;
using PSAP.DAO.PURDAO;
using PSAP.PSAPCommon;
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
    public partial class FrmDocumentTemplet : DockContent
    {
        FrmDocumentTempletDAO docDAO = new FrmDocumentTempletDAO();

        /// <summary>
        /// 编辑版本号的源版本号数据值
        /// </summary>
        string oldDocVersionValue = "";

        /// <summary>
        /// 锁定编辑状态
        /// </summary>
        bool lockChange = false;

        public FrmDocumentTemplet()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmDocumentTemplet_Load(object sender, EventArgs e)
        {
            try
            {
                QueryDocTemplet();
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiCtjzsjcw.Text, ex);
            }
        }

        /// <summary>
        /// 上传单据模板事件
        /// </summary>
        private void repItemBtnEdtUpload_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                TreeListNode focusedNode = treeListDocTemp.FocusedNode;
                if (focusedNode == null)
                    return;
                string tableNameStr = DataTypeConvert.GetString(focusedNode["TableName"]).Trim();
                int autoIdInt = DataTypeConvert.GetInt(focusedNode["AutoId"]);
                if (tableNameStr == "")
                    return;
                switch (e.Button.Caption)
                {
                    case "编辑":
                        switch (tableNameStr)
                        {
                            case "PUR_PrReqHead"://请购单
                                new FrmPrReqDAO().PrintHandle("", 3);
                                break;
                            case "PUR_OrderHead"://采购订单
                                new FrmOrderDAO().PrintHandle("", 3);
                                break;
                            case "PUR_SettlementHead"://采购结账单
                                new FrmSettlementDAO().PrintHandle("", 3);
                                break;
                            case "INV_WarehouseWarrantHead"://入库单
                                new FrmWarehouseWarrantDAO().PrintHandle("", 3);
                                break;
                            case "INV_WarehouseReceiptHead"://材料出库单
                                new FrmWarehouseReceiptDAO().PrintHandle("", 3);
                                break;
                            case "INV_InventoryMoveHead"://库存移动单
                                new FrmInventoryMoveDAO().PrintHandle("", 3);
                                break;
                            case "INV_InventoryAdjustmentsHead"://库存调整单
                                new FrmInventoryAdjustmentsDAO().PrintHandle("", 3);
                                break;
                            default:
                                return;
                        }
                        //if (MessageHandler.ShowMessageBox_YesNo("模板设计完是否要上传更新服务器的版本吗?") == DialogResult.Yes)
                        if (MessageHandler.ShowMessageBox_YesNo(tsmiMbsjwsf.Text) == DialogResult.Yes)
                        {
                            //if (MessageHandler.ShowMessageBox_YesNo("模板确认上传更新服务器的版本吗?") == DialogResult.Yes)
                            {
                                if (docDAO.UpdateDocTemplet_File(tableNameStr))
                                {
                                    MessageHandler.ShowMessageBox("上传成功。");
                                }
                            }
                        }
                        break;
                    case "上传":
                        //if (MessageHandler.ShowMessageBox_YesNo("模板确认上传更新服务器的版本吗?") == DialogResult.Yes)
                        if (MessageHandler.ShowMessageBox_YesNo(tsmiMbqrsc.Text) == DialogResult.Yes)
                        {
                            if (docDAO.UpdateDocTemplet_File(tableNameStr))
                            {
                                MessageHandler.ShowMessageBox("上传成功。");
                            }
                        }
                        break;
                    case "版本":
                        lockChange = true;
                        SetEditState(true);
                        treeListDocTemp.FocusedColumn = treeColDocVersion;
                        oldDocVersionValue = DataTypeConvert.GetString(treeListDocTemp.FocusedNode["DocVersion"]);
                        lockChange = false;
                        break;
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--上传单据模板事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiScdjmb.Text, ex);
            }
        }

        /// <summary>
        /// 设定树的单元格显示事件
        /// </summary>
        private void treeListDocTemp_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            try
            {
                if (e.Node == null)
                    return;
                string tableNameStr = DataTypeConvert.GetString(e.Node["TableName"]).Trim();
                if (e.Column.FieldName == "Upload")
                {
                    ButtonEditViewInfo buttonEditViewInfo = (ButtonEditViewInfo)e.EditViewInfo;
                    if (buttonEditViewInfo.RightButtons.Count > 0)
                    {
                        if (tableNameStr != "")
                        {
                            buttonEditViewInfo.RightButtons[0].State = DevExpress.Utils.Drawing.ObjectState.Normal;
                            buttonEditViewInfo.RightButtons[1].State = DevExpress.Utils.Drawing.ObjectState.Normal;
                            buttonEditViewInfo.RightButtons[2].State = DevExpress.Utils.Drawing.ObjectState.Normal;
                        }
                        else
                        {
                            buttonEditViewInfo.RightButtons[0].State = DevExpress.Utils.Drawing.ObjectState.Disabled;
                            buttonEditViewInfo.RightButtons[1].State = DevExpress.Utils.Drawing.ObjectState.Disabled;
                            buttonEditViewInfo.RightButtons[2].State = DevExpress.Utils.Drawing.ObjectState.Disabled;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--设定树的单元格显示事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiSdsddyg.Text, ex);
            }
        }

        /// <summary>
        /// 设定树的显示编辑事件
        /// </summary>
        private void treeListDocTemp_ShowingEditor(object sender, CancelEventArgs e)
        {
            try
            {
                TreeListNode focusedNode = treeListDocTemp.FocusedNode;
                if (focusedNode == null)
                    return;
                string tableNameStr = DataTypeConvert.GetString(focusedNode["TableName"]).Trim();
                if (tableNameStr == "")
                    e.Cancel = true;
                else
                    e.Cancel = false;
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--设定树的显示编辑事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiSdsdxsbj.Text, ex);
            }
        }

        /// <summary>
        /// 单元格改变更新数据库事件
        /// </summary>
        private void treeListDocTemp_CellValueChanged(object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e)
        {
            try
            {
                if (e.Column.FieldName == "DocVersion")
                {
                    string docVersionStr = DataTypeConvert.GetString(e.Node["DocVersion"]);
                    if (oldDocVersionValue != docVersionStr)
                    {
                        string moduleNameStr = DataTypeConvert.GetString(e.Node["ModuleName"]);
                        //if (MessageHandler.ShowMessageBox_YesNo(string.Format("确认更新模块【{0}】的打印模板的版本号吗？（更新版本号后，所有站点将会重新下载最新的打印模板）", moduleNameStr)) == DialogResult.Yes)
                        if (MessageHandler.ShowMessageBox_YesNo(string.Format(tsmiQrgxmk.Text + "【{0}】" + tsmiDdymbd.Text, moduleNameStr)) == DialogResult.Yes)
                        {
                            string tableNameStr = DataTypeConvert.GetString(e.Node["TableName"]).Trim();
                            if (docDAO.UpdateDocTemplet_Version(tableNameStr, docVersionStr))
                            {
                                //MessageHandler.ShowMessageBox(string.Format("模块【{0}】的版本号更新成功。", moduleNameStr));
                                MessageHandler.ShowMessageBox(string.Format(tsmiMk.Text + "【{0}】" + tsmiDbbhgxcg.Text, moduleNameStr));
                            }
                            else
                                //MessageHandler.ShowMessageBox(string.Format("模块【{0}】的版本号更新失败。", moduleNameStr));
                                MessageHandler.ShowMessageBox(string.Format(tsmiMk.Text + "【{0}】" + tsmiDbbhgxsb.Text, moduleNameStr));
                            QueryDocTemplet();
                            SetEditState(false);
                            treeListDocTemp.FocusedNode = e.Node;
                        }
                        else
                        {
                            QueryDocTemplet();
                            SetEditState(false);
                            treeListDocTemp.FocusedNode = e.Node;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--单元格改变更新数据库事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiDyggb.Text, ex);
            }
        }

        /// <summary>
        /// 聚焦的列变更事件
        /// </summary>
        private void treeListDocTemp_FocusedColumnChanged(object sender, DevExpress.XtraTreeList.FocusedColumnChangedEventArgs e)
        {
            try
            {
                if (e.OldColumn != null)
                {
                    if (treeColDocVersion.OptionsColumn.AllowEdit && !lockChange)
                    {
                        SetEditState(false);
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--聚焦的列变更事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiJjdlbg.Text, ex);
            }
        }

        /// <summary>
        /// 聚焦的行变更事件
        /// </summary>
        private void treeListDocTemp_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            try
            {
                if (e.OldNode != null)
                {
                    if (treeColDocVersion.OptionsColumn.AllowEdit && !lockChange)
                    {
                        SetEditState(false);
                    }
                }
            }
            catch (Exception ex)
            {
                //ExceptionHandler.HandleException(this.Text + "--聚焦的行变更事件错误。", ex);
                ExceptionHandler.HandleException(this.Text + "--" + tsmiJjdhbg.Text, ex);
            }
        }

        /// <summary>
        /// 查询打印模板数据库信息
        /// </summary>
        private void QueryDocTemplet()
        {
            treeListDocTemp.DataSource = docDAO.QueryDocTemplet();
            treeListDocTemp.ExpandAll();
        }

        /// <summary>
        /// 设定编辑状态
        /// </summary>
        private void SetEditState(bool editState)
        {
            if (editState)
            {
                treeColDocVersion.OptionsColumn.AllowEdit = editState;
                treeColDocVersion.AppearanceHeader.ForeColor = Color.Red;
                treeListDocTemp.Appearance.FocusedCell.ForeColor = Color.Red;
            }
            else
            {
                treeColDocVersion.OptionsColumn.AllowEdit = editState;
                treeColDocVersion.AppearanceHeader.ForeColor = treeColDocFileName.AppearanceHeader.ForeColor;
                treeListDocTemp.Appearance.FocusedCell.ForeColor = treeColDocFileName.AppearanceHeader.ForeColor;
            }
        }
    }
}
