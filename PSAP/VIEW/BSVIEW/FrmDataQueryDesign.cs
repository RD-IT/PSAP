using PSAP.BLL.BSBLL;
using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using PsapUserControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmDataQueryDesign : DockContent
    {
        public FrmDataQueryDesign()
        {
            InitializeComponent();
            FrmDataQueryDesignBLL.tvtbQueryListGetNode(tvtbQueryList);
            tvtbQueryList.ExpandAll();
            InitEnableState();//初始化控件Enable状态
            tvtbQueryList.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tvtbQueryList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvtbQueryList.SelectedNode = e.Node;

            //单击展开或收起节点
            if (e.Node.IsExpanded)
            {
                if (e.Button == MouseButtons.Left)
                {
                    e.Node.Collapse();
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    e.Node.Expand();
                }
            }

            //if (e.Node.Nodes.Count == 0)
            //{
            //    MessageBox.Show("dfdfdfdfdfdf");
            //}

        }

        private void bS_QuerySqlBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bS_QuerySqlBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPSAP);

        }

        private void bS_QuerySqlBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bS_QuerySqlBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsPSAP);

        }

        private void FrmDataQueryDesign_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_QuerySqlParameter”中。您可以根据需要移动或删除它。
            this.bS_QuerySqlParameterTableAdapter.Fill(this.dsPSAP.BS_QuerySqlParameter);
            // TODO: 这行代码将数据加载到表“dsPSAP.BS_QuerySql”中。您可以根据需要移动或删除它。
            this.bS_QuerySqlTableAdapter.Fill(this.dsPSAP.BS_QuerySql);
            dgveParaList.Columns[0].Visible = false;

        }

        private void insertTreeNode_Click(object sender, EventArgs e)
        {
            try
            {
                string nName;
                nName = tvtbQueryList.SelectedNode.Name;
                tvtbQueryList.SelectedNode.Parent.Nodes.Insert(tvtbQueryList.SelectedNode.Index, "插入查询");
                tvtbQueryList.SelectedNode.Expand();
                tvtbQueryList.SelectedNode = tvtbQueryList.SelectedNode.PrevNode;
                string nodeId = BaseSQL.GetMaxID("AutoId", "BS_QuerySql").ToString();
                tvtbQueryList.SelectedNode.Name = nodeId;
                saveNodeToTable();//将新建节点同步到数据库

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }

        private void addChildTreeNode_Click(object sender, EventArgs e)
        {
            if (tvtbQueryList.SelectedNode.Parent == null)
            {
                try
                {

                    tvtbQueryList.SelectedNode.Nodes.Add("新建查询");
                    tvtbQueryList.SelectedNode.Expand();
                    tvtbQueryList.SelectedNode = tvtbQueryList.SelectedNode.LastNode;
                    string nodeId = BaseSQL.GetMaxID("AutoId", "BS_QuerySql").ToString();
                    tvtbQueryList.SelectedNode.Name = nodeId;
                    saveNodeToTable();//将新建节点同步到数据库
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message);
                }
            }

        }

        private void addRootTreeNode_Click(object sender, EventArgs e)
        {
            try
            {
                tvtbQueryList.Nodes.Add("新建文件夹");
                tvtbQueryList.SelectedNode.Expand();
                //选定新建节点
                tvtbQueryList.SelectedNode = tvtbQueryList.Nodes[tvtbQueryList.Nodes.Count - 1];
                string nodeId = BaseSQL.GetMaxID("AutoId", "BS_QuerySql").ToString();
                tvtbQueryList.SelectedNode.Name = nodeId;
                saveNodeToTable();//将新建节点同步到数据库
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }

        private void deleteTreeNode_Click(object sender, EventArgs e)
        {
            try
            {
                if (tvtbQueryList.Nodes.Count > 1 || tvtbQueryList.SelectedNode.Parent != null)
                {
                    if (tvtbQueryList.SelectedNode.Nodes.Count > 0)
                    {
                        MessageBox.Show("当前文件夹包含查询，请先删除查询！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (MessageBox.Show("真的要删除吗？", "删除确认", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            //先删除对此数据有依赖关系的相关数数
                            // FrmRightDAO.DeleteMenuCorrelationData(tvtbQueryList.SelectedNode.Name);//删除与菜单相关数据

                            //删除部门表数据
                            bS_QuerySqlBindingSource.RemoveCurrent();
                            Validate();
                            bS_QuerySqlBindingSource.EndEdit();
                            bS_QuerySqlTableAdapter.Update(dsPSAP.BS_QuerySql);
                            tvtbQueryList.SelectedNode.Remove();


                        }
                    }
                }
                else
                {
                    MessageBox.Show("不能删除最后一个文件夹！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            //catch (System.Data.SqlClient.SqlException)
            //{
            //    MessageBox.Show("当前部门已经被其它数据使用，不能删除！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

        }
        /// <summary>
        /// 将新建节点同步到数据库
        /// </summary>
        private void saveNodeToTable()
        {

            bS_QuerySqlBindingSource.AddNew();
            dgveQueryItemList.CurrentRow.Cells[2].Value = tvtbQueryList.SelectedNode.Text;
            if (tvtbQueryList.SelectedNode.Parent != null)
            {
                dgveQueryItemList.CurrentRow.Cells[1].Value = tvtbQueryList.SelectedNode.Parent.Name;
            }
            dgveQueryItemList.CurrentRow.Cells[4].Value = tvtbQueryList.SelectedNode.Index.ToString();

            if (string.IsNullOrEmpty(querySqlTextBox.Text))
            {
                querySqlTextBox.Text = "";
            }
            dgveQueryItemList.CurrentRow.Cells[3].Value = querySqlTextBox.Text;
            dgveQueryItemList.CurrentRow.Cells[5].Value = reamrksTextBox.Text;

            this.Validate();
            this.bS_QuerySqlBindingSource.EndEdit();
            this.bS_QuerySqlTableAdapter.Update(dsPSAP.BS_QuerySql);
        }

        private void tvtbQueryList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            int index;
            if (tvtbQueryList.SelectedNode.Tag == null)
            {
                reamrksTextBox.Visible = true;
                querySqlTextBox.Visible = true;
                remarksLabel.Visible = true;
                querySqlLabel.Visible = true;
            }
            else
            {
                reamrksTextBox.Visible = false;
                querySqlTextBox.Visible = false;
                remarksLabel.Visible = false;
                querySqlLabel.Visible = false;
            }
            if (tvtbQueryList.SelectedNode.Name != "")
            {
                index = bS_QuerySqlBindingSource.Find("AutoId", (tvtbQueryList.SelectedNode.Name));
                if (index != -1)
                {
                    bS_QuerySqlBindingSource.Position = index;//定位BindingSource
                }
            }
        }

        private void tvtbQueryList_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.Label))
            {
                dgveQueryItemList.CurrentRow.Cells[2].Value = e.Label;
            }
            Validate();
            bS_QuerySqlBindingSource.EndEdit();
            bS_QuerySqlTableAdapter.Update(dsPSAP.BS_QuerySql);
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            ChangeEnabledState();//更改控件状态
            itemOrderTextBox.Focus();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            //createDateDateTimePicker.Value = DateTime.Now;//建立日期设定为保存时间
            //founderTextBox.Text = FrmLoginDAO.user.EmpName;//获取当前登录用户姓名

            if (string.IsNullOrEmpty(querySqlTextBox.Text))
            {
                MessageBox.Show("【查询语句】为必填项！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                querySqlTextBox.Focus();
                return;
            }

            try
            {
                //先更新相关数据
                // FrmOrganizationStruDAO.UpdateDeptmentNoCorrelationData(dgveQuerItemList.CurrentRow.Cells[1].Value.ToString(), departmentNoTextBox1.Text);

                this.Validate();
                this.bS_QuerySqlBindingSource.EndEdit();
                this.bS_QuerySqlTableAdapter.Update(this.dsPSAP);
                ChangeEnabledState();//保存后更新控件状态

                //使sql更改同步到DataGridView
                //this.bS_QuerySqlTableAdapter.Fill(dsPSAP.BS_QuerySql);
                //dgveQueryItemList.DataSource = bS_QuerySqlBindingSource;

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            dgveQueryItemList.Enabled = true;//保存后数据表控件可用

        }

        private void tsbCancel_Click(object sender, EventArgs e)
        {
            dgveQueryItemList.Enabled = true;
            ChangeEnabledState();
            this.bS_QuerySqlBindingSource.CancelEdit();
        }

        private void tsbDGViewExportToCSV_Click(object sender, EventArgs e)
        {
            psapCommon.DataGridViewExportToCSV(dgveQueryItemList, psapCommon.GetDateNumber("Sql查询"));
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 初始化控件Enable状态
        /// </summary>
        private void InitEnableState()
        {
            pnlEdit.Enabled = false;
            tsbSave.Enabled = false;
            tsbCancel.Enabled = false;
        }

        /// <summary>
        /// panel（pnlEdit）的Enabled属性设置为“False”，表示最开始panel里面的控件都设置为不可编辑状态
        /// 保存了、取消初始Enable为"False"
        /// 将数据导航条、GroupBox、新增、修改、删除、保存、取消的Enabled状态取反
        /// </summary>
        private void ChangeEnabledState()
        {
            bS_QuerySqlBindingNavigator.Enabled = !bS_QuerySqlBindingNavigator.Enabled;
            pnlEdit.Enabled = !pnlEdit.Enabled;

            foreach (ToolStripButton b in tsControl.Items)
            {
                b.Enabled = !b.Enabled;
            }
            //检测窗口状态：新增、编辑="EDIT"，保存、取消=""
            if (((Label)this.Controls["lblEditFlag"]).Text == "")
            {
                ((Label)this.Controls["lblEditFlag"]).Text = "EDIT";
            }
            else
            {
                ((Label)this.Controls["lblEditFlag"]).Text = "";
            }

        }

        private void itemOrderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void reamrksTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        private void cmnsQueryItemTree_Opening(object sender, CancelEventArgs e)
        {
            if (tvtbQueryList.SelectedNode.Parent != null)
            {
                addChildTreeNode.Enabled = false;
                insertTreeNode.Enabled = true;
            }
            else
            {
                addChildTreeNode.Enabled = true;
                insertTreeNode.Enabled = false;
            }
        }

        private void querySqlTextBox_Leave(object sender, EventArgs e)
        {
            FrmDataQueryDesignDAO.CreateProcedureParaList(dgveQueryItemList.CurrentRow.Cells[0].Value.ToString(), querySqlTextBox.Text);
            //dgveParaList.DataSource = bS_QuerySqlParameterBindingSource;


            //使sql更改同步到DataGridView
            bS_QuerySqlParameterTableAdapter.Fill(dsPSAP.BS_QuerySqlParameter);
            dgveParaList.DataSource = bS_QuerySqlParameterBindingSource;

        }

        private void dgveQueryItemList_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgveQueryItemList.CurrentRow != null)
            {
                string strFilter;
                strFilter = "QuerySqlId = " + dgveQueryItemList.CurrentRow.Cells[0].Value + " ";
                this.bS_QuerySqlParameterBindingSource.Filter = strFilter;
            }

        }

        private void dgveParaList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            bS_QuerySqlParameterBindingSource.EndEdit();
            bS_QuerySqlParameterTableAdapter.Update(dsPSAP.BS_QuerySqlParameter);
            FrmMain.frmMain.tsrLblCurrentStatusText = "对【参数标题】的修改，已成功保存";
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControl1.SelectedIndex == 1)
            {
                tvtbQueryList_User.Nodes.Clear();
                FrmDataQueryDesignBLL.tvtbQueryListGetNode(tvtbQueryList_User);
                tvtbQueryList_User.ExpandAll();
            }
        }

        //------------------------------------------------------------------------
        private DataGridViewEx[] dgveQuery;
        private Panel[] pnlQuery;
        private TextBox[] txtRemark;
        private TextBox[] txtTabText;//客户端不需要
        private void tvtbQueryList_User_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                tabControl2.TabPages.Clear();
                //调用显示查询条件B
                tableLayoutpnlQueryCondition.Visible = true;
                DataTable dtQueryPara = new DataTable();
                dtQueryPara = FrmDataQueryDesignDAO.GetUserQueryInfo(tvtbQueryList_User.SelectedNode.Name);
                if (!string.IsNullOrEmpty(dtQueryPara.Rows[0].ItemArray[6].ToString().Trim()))
                {
                    int iRowCount = dtQueryPara.Rows.Count;
                    string[,] strsQueryTmp = new string[iRowCount, 2];
                    DataTable[] dtTmp = new DataTable[iRowCount];
                    for (int i = 0; i < iRowCount; i++)
                    {
                        strsQueryTmp[i, 0] = dtQueryPara.Rows[i].ItemArray[5].ToString();
                        //"txt";/"cbo"/"dtp";
                        strsQueryTmp[i, 1] = FrmDataQueryDesignBLL.SqlChangeToControlAbbreviation(dtQueryPara.Rows[i].ItemArray[7].ToString());
                        //dt[1] = BSCommon.getDepartmentList();//下标代表代号控件类型是cbo时用
                    }
                    strsControlTmp = strsQueryTmp;
                    addControl(strsControlTmp);
                }
                //调用显示查询条件E
            }
        }
        //****************************
        /// <summary>
        /// 执行存储过程并生成结果集相关控件
        /// </summary>
        private void CreateResultControl()
        {
            tabControl2.TabPages.Clear();
            DataSet ds = new DataSet();
            DataTable dt = FrmDataQueryDesignDAO.GetUserQueryTabsInfo(tvtbQueryList_User.SelectedNode.Name);
            if (tvtbQueryList_User.SelectedNode.Tag == null)
            {
                ds = FrmDataQueryDesignDAO.ExecUserProcedure(tvtbQueryList_User.SelectedNode.Name);
                if (ds != null)
                {
                    string strTabText;
                    string strTabRemarks;
                    int intTablesCount = ds.Tables.Count;
                    dgveQuery = new DataGridViewEx[intTablesCount];
                    pnlQuery = new Panel[intTablesCount];
                    txtRemark = new TextBox[intTablesCount];
                    txtTabText = new TextBox[intTablesCount];
                    Label[] lbl1 = new Label[intTablesCount];//客户端不用
                    Label[] lbl2 = new Label[intTablesCount];//客户端不用
                    for (int i = 0; i < intTablesCount; i++)
                    {
                        if (!string.IsNullOrEmpty(dt.Rows[i].ItemArray[5].ToString()))
                        {
                            strTabText = dt.Rows[i].ItemArray[5].ToString();
                        }
                        else
                        {
                            strTabText = "报表" + Convert.ToString(i);
                        }

                        if (!string.IsNullOrEmpty(dt.Rows[i].ItemArray[6].ToString()))
                        {
                            strTabRemarks = dt.Rows[i].ItemArray[6].ToString();
                        }
                        else
                        {
                            strTabRemarks = "";
                        }
                        tabControl2.TabPages.Add(strTabText);
                        tabControl2.TabPages[i].Tag = dt.Rows[i].ItemArray[7];

                        pnlQuery[i] = new Panel();
                        pnlQuery[i].Anchor = AnchorStyles.Right & AnchorStyles.Left;
                        pnlQuery[i].Dock = DockStyle.Top;
                        pnlQuery[i].Height = 50;
                        tabControl2.TabPages[i].Controls.Add(pnlQuery[i]);

                        txtTabText[i] = new TextBox();
                        txtTabText[i].Text = tabControl2.TabPages[i].Text;
                        txtTabText[i].Left = 60;
                        pnlQuery[i].Controls.Add(txtTabText[i]);//客户端不需要此控件

                        txtRemark[i] = new TextBox();
                        txtRemark[i].Multiline = true;
                        txtRemark[i].MaxLength = 500;
                        txtRemark[i].Text = strTabRemarks;
                        txtRemark[i].Top = txtTabText[i].Top + txtTabText[i].Height + 5;//客户端不用
                        txtRemark[i].Width = pnlQuery[i].Width - 60;//客户端不用
                        txtRemark[i].Left = 60;//客户端不用
                        //txtRemark[i].Dock = DockStyle.Bottom;
                        //txtRemark[i].Dock = DockStyle.Fill;//客户端使用
                        pnlQuery[i].Controls.Add(txtRemark[i]);

                        lbl1[i] = new Label();
                        lbl1[i].Text = "页名";
                        lbl1[i].Top = 6;
                        lbl1[i].AutoSize = true;
                        pnlQuery[i].Controls.Add(lbl1[i]);//客户端不需要此控件

                        lbl2[i] = new Label();
                        lbl2[i].Text = "报表说明";
                        lbl2[i].Top = txtTabText[i].Top + txtTabText[i].Height + 5;//客户端不用
                        lbl2[i].AutoSize = true;
                        pnlQuery[i].Controls.Add(lbl2[i]);//客户端不需要此控件

                        dgveQuery[i] = new DataGridViewEx();
                        dgveQuery[i].Height = tabControl2.TabPages[i].Height - pnlQuery[i].Height;
                        dgveQuery[i].Anchor = AnchorStyles.Right & AnchorStyles.Bottom & AnchorStyles.Left;
                        dgveQuery[i].Dock = DockStyle.Bottom;
                        dgveQuery[i].DataSource = ds.Tables[i];
                        tabControl2.TabPages[i].Controls.Add(dgveQuery[i]);
                    }
                }
            }
        }

        //*******************************************************************************************************
        //显示查询条件Beg
        string[,] strsControlTmp;
        TableLayoutPanel table = new TableLayoutPanel();
        private TextBox[] txt;
        private ComboBox[] cbo;
        private DataTable[] dt;
        private DateTimePicker[] dtp;

        /// <summary>
        /// 添加控件
        /// </summary>
        /// <param name="strsQueryTmp"></param>
        private void addControl(string[,] strsQueryTmp)
        {
            table.Controls.Clear();
            table.RowStyles.Clear();
            table.ColumnStyles.Clear();
            int intRowHeight = 30;//行高
            table.Dock = DockStyle.Top;
            pnlQueryCondition.Controls.Add(table);
            table.AutoSize = true;
            table.ColumnCount = 2;
            int intColumnW1 = 0;
            int intColumnW2 = 100;
            table.Height = strsControlTmp.GetLength(0) * intRowHeight;
            txt = new TextBox[strsControlTmp.GetLength(0)];//初始化txt控件
            cbo = new ComboBox[strsControlTmp.GetLength(0)];//初始化cbo控件
            dtp = new DateTimePicker[strsControlTmp.GetLength(0)];//初始化dtp控件

            for (int i = 0; i < strsControlTmp.GetLength(0); i++)
            {
                table.RowCount++;// 动态添加一行
                int i1 = table.RowCount - 1;

                // 添加标签
                Label p = new Label();
                p.Anchor = AnchorStyles.Left;
                p.TextAlign = ContentAlignment.MiddleCenter;
                p.AutoSize = true;
                p.Text = strsQueryTmp[i, 0];
                table.Controls.Add(p, 0, i);
                if (p.Width > intColumnW1)//获得最大标签宽度
                {
                    intColumnW1 = p.Width;
                }

                //添加输入控件
                switch (strsQueryTmp[i, 1])
                {
                    case "txt":
                        txt[i] = new TextBox();//实例化
                        txt[i].Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        txt[i].TextAlign = HorizontalAlignment.Left;
                        txt[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(ctl_KeyPress);
                        table.Controls.Add(txt[i], 1, i);
                        break;
                    case "cbo":
                        cbo[i] = new ComboBox();//实例化
                        cbo[i].Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        cbo[i].DataSource = dt[i];
                        cbo[i].DisplayMember = dt[i].Columns[0].ToString();
                        cbo[i].ValueMember = dt[i].Columns[1].ToString();
                        cbo[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(ctl_KeyPress);
                        table.Controls.Add(cbo[i], 1, i);
                        break;
                    case "dtp":
                        dtp[i] = new DateTimePicker();//实例化
                        dtp[i].Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        dtp[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(ctl_KeyPress);
                        table.Controls.Add(dtp[i], 1, i);
                        break;
                }

                //行样式
                table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, intRowHeight));
            }

            //列样式
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize, intColumnW1));
            table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, intColumnW2));

        }

        private void ctl_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.EnterDoTab(e);//按回车键时将焦点调到下一个控件

        }

        /// <summary>
        /// 保存设定的查询条件
        /// </summary>
        /// <returns></returns>
        private void saveQueryParameter()
        {
            for (int i = 0; i < strsControlTmp.GetLength(0); i++)
            {
                if (txt[i] != null)
                {
                    strsControlTmp[i, 1] = txt[i].Text;
                }

                if (cbo[i] != null)
                {
                    strsControlTmp[i, 1] = cbo[i].SelectedValue.ToString();
                }

                if (dtp[i] != null)
                {
                    strsControlTmp[i, 1] = dtp[i].Text;
                }
            }
        }
        ///// <summary>
        /////取消查询给所有查询参数赋“”值
        ///// </summary>
        //private void CancleQueryParameter()
        //{
        //    for (int i = 0; i < strsControlTmp.GetLength(0); i++)
        //    {
        //        strsControlTmp[i, 1] = string.Empty;
        //    }
        //}


        private void btnQuery_Click(object sender, EventArgs e)
        {
            CreateResultControl();
            saveQueryParameter();
        }
        //显示查询条件End

    }
}
