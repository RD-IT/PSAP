using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmUserInfo_New : DockContent
    {
        FrmBaseEdit editForm = null;
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        public FrmUserInfo_New()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        private void FrmUserInfo_New_Load(object sender, EventArgs e)
        {
            try
            {
                if (editForm == null)
                {
                    editForm = new FrmBaseEdit();
                    editForm.FormBorderStyle = FormBorderStyle.None;
                    editForm.TopLevel = false;
                    editForm.TableName = "BS_UserInfo";
                    editForm.TableCaption = "用户信息";
                    editForm.Sql = "select BS_UserInfo.*, BS_Department.DepartmentName from BS_UserInfo left join BS_Department on BS_UserInfo.DepartmentNo = BS_Department.DepartmentNo order by AutoId";
                    editForm.PrimaryKeyColumn = "AutoId";
                    editForm.MasterDataSet = dSUserInfo;
                    editForm.MasterBindingSource = bSUserInfo;
                    editForm.MasterEditPanel = pnlEdit;
                    editForm.PrimaryKeyControl = textLoginId;
                    editForm.BrowseXtraGridView = gridViewUserInfo;
                    editForm.CheckControl += CheckControl;
                    editForm.SaveRowBefore += SaveRowBefore;
                    this.pnlToolBar.Controls.Add(editForm);
                    editForm.Dock = DockStyle.Fill;
                    editForm.Show();

                    lookUpDept.Properties.DataSource = commonDAO.QueryDepartment_AllNode(false);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--窗体加载事件错误。", ex);
            }
        }

        /// <summary>
        /// 保存之前的回调方法
        /// </summary>
        public bool CheckControl()
        {
            if (textLoginId.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("登陆名不能为空，请重新操作。");
                textLoginId.Focus();
                return false;
            }
            if (textEmpName.Text.Trim() == "")
            {
                MessageHandler.ShowMessageBox("员工姓名不能为空，请重新操作。");
                textEmpName.Focus();
                return false;
            }
            
            return true;
        }

        /// <summary>
        /// 保存之前进行密码检测
        /// </summary>
        public bool SaveRowBefore(DataRow dr, SqlCommand cmd)
        {
            if (dr.RowState == DataRowState.Added)
            {
                if (string.IsNullOrEmpty(textLoginPwd.Text))//初始密码与用户ID相同
                {
                    EncryptMD5 en = new EncryptMD5(textLoginId.Text);//实例化EncryptMD5
                    dr["LoginPwd"] = en.str2;//加密后的数值
                }
                else
                {
                    EncryptMD5 en = new EncryptMD5(textLoginPwd.Text);//实例化EncryptMD5
                    dr["LoginPwd"] = en.str2;//加密后的数值
                }
            }
            else
            {
                if (DataTypeConvert.GetString(dr["LoginPwd", DataRowVersion.Original]) != DataTypeConvert.GetString(dr["LoginPwd", DataRowVersion.Current]))
                {
                    EncryptMD5 en = new EncryptMD5(textLoginPwd.Text);//实例化EncryptMD5
                    dr["LoginPwd"] = en.str2;//加密后的数值
                }
            }

            return true;
        }

        /// <summary>
        /// 确定行号
        /// </summary>
        private void gridViewUserInfo_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }

        /// <summary>
        /// 设定默认值
        /// </summary>
        private void TableUserInfo_TableNewRow(object sender, DataTableNewRowEventArgs e)
        {
            if(((DataTable)lookUpDept.Properties.DataSource).Rows.Count>0)
                e.Row["DepartmentNo"] = DataTypeConvert.GetString(((DataTable)lookUpDept.Properties.DataSource).Rows[0]["DepartmentNo"]);
            e.Row["Founder"] = SystemInfo.user.EmpName;
            e.Row["CreateDate"] = BaseSQL.GetServerDateTime();
        }
    }
}
