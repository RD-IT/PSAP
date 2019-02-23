using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using PSAP.PSAPCommon;
using PSAP.DAO.BSDAO;

namespace PSAP.VIEW.BSVIEW
{
    public partial class GridBottom : UserControl
    {
        #region 初始化分页显示的参数

        private int rowCount = 0;//总记录数
        private int pageCount = 0;//总页数

        private int curPage = 0;//当前页码

        private int startLine = 0;//从第start行开始返回

        private string queryTableSql = "";//查询数据的SQL
        private string queryCountSql = "";//查询数据总行数的SQL
        private string tableName = "";//查询的DataSet中的表名
        private bool comboxChange = true;//锁定Combox控件

        /// <summary>
        /// 每页记录数
        /// </summary>
        
        [Description("每页记录数")]
        [Browsable(true)]
        public int pageRowCount
        {
            get;
            set;
        }

        /// <summary>
        /// 查询数据的DataSet
        /// </summary>
        private DataSet masterDataSet = null;
        [Description("查询数据的DataSet")]
        [Browsable(true)]
        public DataSet MasterDataSet
        {
            get
            {
                return masterDataSet;
            }
            set
            {
                masterDataSet = value;
                masterDataSet.EnforceConstraints = false;
            }
        }

        #endregion

        public GridBottom()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 绑定控件查询
        /// </summary>
        /// <param name="dataSet">保存的DataSet</param>
        /// <param name="dsTableName">DataSet中的表名</param>
        /// <param name="tableSql">查询数据表的Sql</param>
        /// <param name="countSql">查询数据总数的Sql</param>
        /// <param name="isFirst">是否首次查询</param>
        public void QueryGridData(ref DataSet dataSet, string dsTableName, string tableSql, string countSql, bool isFirst)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                try
                {
                    if (masterDataSet == null)
                        masterDataSet = dataSet;
                    if (masterDataSet.Tables.Count > 0)
                        masterDataSet.Tables[dsTableName].Rows.Clear();

                    conn.Open();
                    SqlCommand cmd = new SqlCommand(countSql, conn);                    
                    rowCount = DataTypeConvert.GetInt(cmd.ExecuteScalar());
                    queryCountSql = countSql;

                    if (rowCount == 0)
                    {
                        btnFirst.Enabled = false;
                        btnLeft.Enabled = false;
                        btnRight.Enabled = false;
                        btnEnd.Enabled = false;
                        curPage = 0;
                        pageCount = 0;
                        rowCount = 0;
                        comboBoxPageNo.Properties.Items.Clear();
                        comboBoxPageNo.Text = "1";
                        lMemo.Text = "共计0条记录，每页显示" + pageRowCount + "条";
                        return;
                    }

                    if (rowCount > 0 && isFirst)
                    {
                        curPage = 1;
                        startLine = 0;
                    }
                    int yushu = rowCount % pageRowCount;
                    if (yushu == 0)
                    {
                        if (rowCount > 0 && rowCount <= pageRowCount)
                        {
                            pageCount = 1;
                        }
                        else
                        {
                            pageCount = rowCount / pageRowCount;
                        }
                    }
                    else
                    {
                        pageCount = rowCount / pageRowCount + 1;
                    }
                    comboxChange = false;
                    if (isFirst)
                    {
                        if (pageCount > 0)
                        {
                            comboBoxPageNo.Properties.Items.Clear();
                            for (int no = 1; no <= pageCount; no++)
                                comboBoxPageNo.Properties.Items.Add(no);
                        }
                        lMemo.Text = "共计" + rowCount.ToString() + "条记录，每页显示" + pageRowCount + "条，共" + pageCount.ToString() + "页";
                        comboBoxPageNo.Text = curPage.ToString();
                    }
                    else
                    {
                        lMemo.Text = "共计" + rowCount.ToString() + "条记录，每页显示" + pageRowCount + "条，共" + pageCount.ToString() + "页";
                        comboBoxPageNo.Text = curPage.ToString();
                    }

                    if (pageCount == 1)
                    {
                        btnFirst.Enabled = false;
                        btnLeft.Enabled = false;
                        btnRight.Enabled = false;
                        btnEnd.Enabled = false;
                    }
                    else
                    {
                        if (curPage == 1)
                        {
                            btnFirst.Enabled = false;
                            btnLeft.Enabled = false;
                            btnRight.Enabled = true;
                            btnEnd.Enabled = true;
                        }
                        else if (curPage == pageCount)
                        {
                            btnFirst.Enabled = true;
                            btnLeft.Enabled = true;
                            btnRight.Enabled = false;
                            btnEnd.Enabled = false;
                        }
                        else
                        {
                            btnFirst.Enabled = true;
                            btnLeft.Enabled = true;
                            btnRight.Enabled = true;
                            btnEnd.Enabled = true;
                        }
                    }

                    comboxChange = true;
                    tableName = dsTableName;
                    queryTableSql = tableSql;

                    cmd.CommandText = queryTableSql;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(masterDataSet, startLine, pageRowCount, dsTableName);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// 查询首页
        /// </summary>
        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                if (pageCount > 1)
                {
                    startLine = 0;
                    curPage = 1;
                    QueryGridData(ref masterDataSet, tableName, queryTableSql, queryCountSql, false);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询首页错误。", ex);
            }
        }

        /// <summary>
        /// 查询上一页
        /// </summary>
        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                if (curPage > 1)
                {
                    curPage--;
                    startLine -= pageRowCount;
                    QueryGridData(ref masterDataSet, tableName, queryTableSql, queryCountSql, false);
                }
                else if (curPage == 1)
                {
                    QueryGridData(ref masterDataSet, tableName, queryTableSql, queryCountSql, false);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询上一页错误。", ex);
            }
        }

        /// <summary>
        /// 查询下一页
        /// </summary>
        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                if (curPage < pageCount)
                {
                    curPage++;
                    startLine += pageRowCount;
                    QueryGridData(ref masterDataSet, tableName, queryTableSql, queryCountSql, false);
                }
                else if (curPage == pageCount)
                {
                    if (tableName == "")
                        MessageHandler.ShowMessageBox("请先点击查询再进行下一页。");
                    else
                        QueryGridData(ref masterDataSet, tableName, queryTableSql, queryCountSql, false);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询下一页错误。", ex);
            }
        }

        /// <summary>
        /// 查询最后一页
        /// </summary>
        private void btnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                if (pageCount > 0)
                {
                    startLine = (pageCount - 1) * pageRowCount;
                    curPage = pageCount;
                    QueryGridData(ref masterDataSet, tableName, queryTableSql, queryCountSql, false);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--查询最后一页错误。", ex);
            }
        }

        /// <summary>
        /// 选择页号查询
        /// </summary>
        private void comboBoxPageNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (pageCount > 0 && comboxChange)
                {
                    startLine = (DataTypeConvert.GetInt(comboBoxPageNo.Text) - 1) * pageRowCount;
                    curPage = DataTypeConvert.GetInt(comboBoxPageNo.Text);
                    QueryGridData(ref masterDataSet, tableName, queryTableSql, queryCountSql, false);
                }
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleException(this.Text + "--选择页号查询错误。", ex);
            }
        }
    }
}
