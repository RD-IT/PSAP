using PSAP.BLL.BSBLL;
using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using PsapUserControlLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmDataQuery : DockContent
    {
        public FrmDataQuery()
        {
            InitializeComponent();
            tvtbQueryList_User.Nodes.Clear();
            FrmDataQueryDesignBLL.tvtbQueryListGetNode(tvtbQueryList_User);
            tvtbQueryList_User.ExpandAll();
        }

        private DataGridViewEx[] dgveQuery;
        private Panel[] pnlQuery;
        private TextBox[] txtRemark;
        private TreeView[] tvwTablesHeader;
        private void tvtbQueryList_User_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                btnExportData.Enabled =false;
                tabControl2.TabPages.Clear();
                //调用显示查询条件B
                tableLayoutpnlQueryCondition.Visible = true;
                DataTable dtQueryPara = new DataTable();
                dtQueryPara = FrmDataQueryDesignDAO.GetUserQueryInfo(tvtbQueryList_User.SelectedNode.Name);
                if (!string.IsNullOrEmpty(dtQueryPara.Rows[0].ItemArray[6].ToString().Trim()))
                {
                    int iRowCount = dtQueryPara.Rows.Count;
                    string[,] strsQueryTmp = new string[iRowCount, 3];
                    DataTable[] dtTmp = new DataTable[iRowCount];
                    for (int i = 0; i < iRowCount; i++)
                    {
                        strsQueryTmp[i, 0] = dtQueryPara.Rows[i].ItemArray[5].ToString();
                        //"txt";/"cbo"/"dtp";
                        strsQueryTmp[i, 1] = FrmDataQueryDesignBLL.SqlChangeToControlAbbreviation(dtQueryPara.Rows[i].ItemArray[7].ToString());
                        strsQueryTmp[i, 2] = dtQueryPara.Rows[i].ItemArray[7].ToString();
                        //dt[1] = BSCommon.getDepartmentList();//下标代表代号控件类型是cbo时用
                    }
                    strsControlTmp = strsQueryTmp;
                    addControl(strsControlTmp);
                }
                //调用显示查询条件E
            }
        }

        /// <summary>
        /// 执行存储过程并生成结果集相关控件
        /// </summary>
        private void CreateResultControl()
        {
            tabControl2.TabPages.Clear();
            DataSet ds = new DataSet();
            if (tvtbQueryList_User.SelectedNode.Tag == null)
            {
                ds = FrmDataQueryDesignDAO.ExecUserProcedure(tvtbQueryList_User.SelectedNode.Name, strsControlTmp);
                if (ds != null)
                {
                    btnExportData.Enabled = true;
                    string strTabText;
                    string strTabRemarks;
                    int intTablesCount = ds.Tables.Count;
                    dgveQuery = new DataGridViewEx[intTablesCount];
                    pnlQuery = new Panel[intTablesCount];
                    txtRemark = new TextBox[intTablesCount];
                    //Label[] lbl1 = new Label[intTablesCount];//客户端不用
                    //Label[] lbl2 = new Label[intTablesCount];//客户端不用
                    tvwTablesHeader = new TreeView[intTablesCount];
                    for (int i = 0; i < intTablesCount; i++)
                    {
                        strTabText = "报表" + Convert.ToString(i);
                        strTabRemarks = "";
                        FrmDataQueryDesignDAO.InitTabInfo(Convert.ToUInt16(tvtbQueryList_User.SelectedNode.Name), i, strTabText, strTabRemarks);

                    }
                    DataTable dt = FrmDataQueryDesignDAO.GetUserQueryTabsInfo(tvtbQueryList_User.SelectedNode.Name);
                    for (int i = 0; i < intTablesCount; i++)
                    {
                        if (dt != null)
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
                        }
                        else
                        {
                            strTabText = "报表" + Convert.ToString(i);
                            strTabRemarks = dt.Rows[i].ItemArray[6].ToString();

                        }
                        tabControl2.TabPages.Add(strTabText);

                        pnlQuery[i] = new Panel();
                        pnlQuery[i].Anchor = AnchorStyles.Right & AnchorStyles.Left;
                        pnlQuery[i].Dock = DockStyle.Top;
                        pnlQuery[i].Height = 50;
                        tabControl2.TabPages[i].Controls.Add(pnlQuery[i]);

                        txtRemark[i] = new TextBox();
                        txtRemark[i].Multiline = true;
                        txtRemark[i].ScrollBars = ScrollBars.Both;
                        txtRemark[i].MaxLength = 500;
                        txtRemark[i].Text = strTabRemarks;
                        txtRemark[i].Dock = DockStyle.Fill;//客户端使用
                        pnlQuery[i].Controls.Add(txtRemark[i]);

                        //标题设定TreeView
                        tvwTablesHeader[i] = new TreeView();
                        //tvwTablesHeader[i].LabelEdit = true;
                        //tvwTablesHeader[i].Dock = DockStyle.Fill;
                        //tvwTablesHeader[i].ContextMenuStrip = cmnsColumnHeader;
                        //tvwTablesHeader[i].Tag = FrmDataQueryDesignDAO.GetDataSettingId(Convert.ToInt16(tvtbQueryList_User.SelectedNode.Name), i);
                        FrmDataQueryDesignBLL.tvwTableHeaderGetNode(tvwTablesHeader[i], Convert.ToInt16(tvtbQueryList_User.SelectedNode.Name), i);
                        //tvwTablesHeader[i].AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(tvwTablesHeader_AfterLabelEdit);
                        //tvwTablesHeader[i].NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(tvwTablesHeader_NodeMouseClick);
                        //tvwTablesHeader[i].ExpandAll();
                        tvwTablesHeader[i].Visible = false;
                        tabControl2.TabPages[i].Controls.Add(tvwTablesHeader[i]);

                        dgveQuery[i] = new DataGridViewEx();
                        dgveQuery[i].Height = tabControl2.TabPages[i].Height - pnlQuery[i].Height;
                        dgveQuery[i].Anchor = AnchorStyles.Right & AnchorStyles.Bottom & AnchorStyles.Left;
                        dgveQuery[i].Dock = DockStyle.Bottom;
                        dgveQuery[i].DataSource = ds.Tables[i];
                        dgveQuery[i].myColHeaderTreeView = tvwTablesHeader[i];
                        tabControl2.TabPages[i].Controls.Add(dgveQuery[i]);
                    }
                }
            }
        }

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
                        txt[i].Tag = strsQueryTmp[i, 2];//
                        if ("int bigint bit decimal float money numeric real smallint smallmoney tinyint varbinary ".Contains(strsQueryTmp[i, 2]))
                        {
                            txt[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(ctlIsNumeric_KeyPress);
                        }
                        else
                        {
                            txt[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(ctl_KeyPress);
                        }
                        table.Controls.Add(txt[i], 1, i);
                        break;
                    case "cbo":
                        cbo[i] = new ComboBox();//实例化
                        cbo[i].Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        cbo[i].DataSource = dt[i];
                        cbo[i].DisplayMember = dt[i].Columns[0].ToString();
                        cbo[i].ValueMember = dt[i].Columns[1].ToString();
                        cbo[i].Tag = strsQueryTmp[i, 2];//
                        cbo[i].KeyPress += new System.Windows.Forms.KeyPressEventHandler(ctl_KeyPress);
                        table.Controls.Add(cbo[i], 1, i);
                        break;
                    case "dtp":
                        dtp[i] = new DateTimePicker();//实例化
                        dtp[i].Anchor = AnchorStyles.Left | AnchorStyles.Right;
                        dtp[i].Tag = strsQueryTmp[i, 2];//
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
        /// 只能输数字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ctlIsNumeric_KeyPress(object sender, KeyPressEventArgs e)
        {
            psapCommon.TextBoxOnlyInputNumeric(sender, e);//判断按键是不是要输入的类型。
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
                    strsControlTmp[i, 2] = txt[i].Tag.ToString();
                }

                if (cbo[i] != null)
                {
                    strsControlTmp[i, 1] = cbo[i].SelectedValue.ToString();
                    strsControlTmp[i, 2] = cbo[i].Tag.ToString();
                }

                if (dtp[i] != null)
                {
                    strsControlTmp[i, 1] = dtp[i].Text;
                    strsControlTmp[i, 2] = dtp[i].Tag.ToString();
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            saveQueryParameter();
            CreateResultControl();
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            FileHandler.DataGridViewExportToCSV(dgveQuery[tabControl2.SelectedIndex], psapCommon.GetDateNumber(tabControl2.TabPages[ tabControl2.SelectedIndex].Text));

        }
        //显示查询条件End
    }
}
