using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraTreeList.Nodes;
using PSAP.DAO.BSDAO;
using PSAP.DAO.PURDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmDocumentTemplet : DockContent
    {
        FrmDocumentTempletDAO docDAO = new FrmDocumentTempletDAO();

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
                treeListDocTemp.DataSource = docDAO.QueryDocTemplet();
                //treeListDocTemp.Nodes[0].Expanded = true;
                treeListDocTemp.ExpandAll();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
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
                if (tableNameStr == "")
                    return;
                switch (e.Button.Index)
                {
                    case 0:
                        switch (tableNameStr)
                        {
                            case "PUR_PrReqHead"://采购请购单
                                new FrmPrReqDAO().PrintHandle("", 3);
                                break;
                            case "PUR_OrderHead"://采购订单
                                new FrmOrderDAO().PrintHandle("", 3);
                                break;

                        }
                        if (MessageHandler.ShowMessageBox_YesNo("模板设计完是否要上传更新服务器的版本吗?") == DialogResult.Yes)
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
                    case 1:
                        if (MessageHandler.ShowMessageBox_YesNo("模板确认上传更新服务器的版本吗?") == DialogResult.Yes)
                        {
                            if (docDAO.UpdateDocTemplet_File(tableNameStr))
                            {
                                MessageHandler.ShowMessageBox("上传成功。");
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--上传单据模板事件错误。", ex);
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
                        }
                        else
                        {
                            buttonEditViewInfo.RightButtons[0].State = DevExpress.Utils.Drawing.ObjectState.Disabled;
                            buttonEditViewInfo.RightButtons[1].State = DevExpress.Utils.Drawing.ObjectState.Disabled;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--设定树的单元格显示事件错误。", ex);
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
                ExceptionHandler.HandleException(this.Text + "--设定树的显示编辑事件错误。", ex);
            }
        }
    }
}
