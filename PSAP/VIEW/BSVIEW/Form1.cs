using DevExpress.XtraGrid;
using Microsoft.Reporting.WinForms;
using PSAP.BLL.BSBLL;
using PSAP.DAO.BSDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class Form1 : DockContent
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmQuery = new Form();
            frmQuery.Text = "查询";

            Panel panel1 = new Panel();
            panel1.Dock = DockStyle.Fill;

            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 20;
            tableLayoutPanel1.Dock = DockStyle.Fill;

            Label[] label1 = new Label[10];
            panel1.Controls.Add(tableLayoutPanel1);
            for (int i = 0; i < 10; i++)
            {
                //label1[i].Text = "AAAAAA";
                tableLayoutPanel1.Controls.Add(label1[i]);
            }
            panel1.Controls.Add(tableLayoutPanel1);
            frmQuery.Controls.Add(panel1);


            frmQuery.ShowDialog();

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void toolStripMenuItem1_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //PageSetupDialog.Document.DefaultPageSettings;
            pageSetupDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // printDocument1.s
        }

        //打印预览功能
        private void btnPrint_Click(object sender, EventArgs e)
        {
            string path = @"..\..\VIEW\REPORT\Report111.rdlc";
            string str = @"select * from BS_Menu ";
            DataTable[] dt = new DataTable[1];//数据由报表数据集个数决定
            dt[0] = BaseSQL.GetTableBySql(str);
            string[] strRptDataSetName = new string[1];
            strRptDataSetName[0] = "Rpt1";//"RptDt1":报表中的数据源名称
            FrmPrintPreview f = new BSVIEW.FrmPrintPreview(path, strRptDataSetName, dt);//数据源可以有多种形式
            f.ShowDialog();
        }

        //****直接打印功能***复杂表可以建视图作为数据源****************
        private void button5_Click(object sender, EventArgs e)
        {
            //打印清单
            string str = @"select * from BS_Menu ";
            DataTable[] dt = new DataTable[1];//数据由报表数据集个数决定
            dt[0] = BaseSQL.GetTableBySql(str);
            ReportViewer rvDoc = new ReportViewer();
            rvDoc.LocalReport.ReportPath = @"..\..\VIEW\REPORT\Report111.rdlc";//设置报表的路径
            rvDoc.LocalReport.DataSources.Add(new ReportDataSource("Rpt1", dt[0]));
            BSBLL.PrintStream(rvDoc.LocalReport);
        }

        string[,] str = new string[10, 2];
        public string buttonBackColor;
        public string formBackColor;
        private void button6_Click(object sender, EventArgs e)
        {
            str[0, 0] = "buttonBackColor";
            str[0, 1] = "info";//大小写无所谓
            str[1, 0] = "formBackColor";
            str[1, 1] = "Red";

            for (int i = 0; i <= 1; i++)
            {

                if (str[i, 0] == "buttonBackColor")
                {
                    buttonBackColor = str[i, 1];
                    //button6.BackColor = Color.FromName(this.GetType().GetField(str[i, 0]).GetValue(this).ToString());
                    button6.BackColor = Color.FromName(str[i, 1]);
                    MessageBox.Show(this.GetType().GetField(str[i, 0]).GetValue(this).ToString());
                }

                if (str[i, 0] == "formBackColor")
                {
                    formBackColor = str[i, 1];
                    this.BackColor = Color.FromName(str[i, 1]);
                    MessageBox.Show(this.GetType().GetField(str[i, 0]).GetValue(this).ToString());
                }
                }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            BSBLL.TraverseFormControlToTable();
            this.Cursor = Cursors.Arrow;
        }

        //test增加多语言控件
        private void button8_Click(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
            object obj = assembly.CreateInstance("PSAP.VIEW.BSVIEW.frmprojectdocument"); //类的完全限定名（即包括命名空间）
            SetFormLanguages((DockContent)obj);

        }
        /// <summary>
        /// 设置窗口语种DockContent(主方法)
        /// </summary>
        public static void SetFormLanguages(DockContent DockContentFormN)
        {
            DataTable dt = new DataTable();
            dt = BSCommon.GetFormLanuageData(DockContentFormN.Name);

            var TextValue = BSCommon.LocationControlsText(dt, DockContentFormN.Name, "TabText");
            if (TextValue.ToList().Count > 0)
            {
                DockContentFormN.TabText = TextValue.ToList().First().Field<string>("LanguageText");
            }

            foreach (Control ctl in DockContentFormN.Controls)//遍历所有“DockContent”窗口控件
            {

                if (ctl.Text != null && ctl.Text != string.Empty && ctl.Text != '0'.ToString() && ctl.Name != string.Empty)
                {
                    TextValue = BSCommon.LocationControlsText(dt, ctl.Name, "Text");
                    if (TextValue.ToList().Count > 0)
                    {
                        ctl.Text = TextValue.ToList().First().Field<string>("LanguageText");
                    }
                    //1.2
                    //BSCommon.TraverseControlTextAdd(DockContentFormN.Name, ctl.GetType().Name, ctl.Name, ctl.Text, "Text");
                }

                if (ctl is DataGridView)
                {
                    DataGridView dg = (DataGridView)ctl;
                    foreach (object ch in dg.Columns)
                    {
                        {
                            if (ch.GetType().Name == "DataGridViewTextBoxColumn")
                            {
                                TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewTextBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewTextBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }
                                //3.1.1

                            }
                            if (ch.GetType().Name == "DataGridViewComboBoxColumn")
                            {
                                TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewComboBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewComboBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                //3.1.2
                            }
                        }
                    }
                }

                if (ctl is ToolStrip)
                {
                    ToolStrip tsTmp = (ToolStrip)ctl;
                    for (int i = 0; i < tsTmp.Items.Count; i++)
                    {
                        if (tsTmp.Items[i].GetType().Name == "ToolStripButton")//判断是否为ToolStripButton
                        {
                            if (tsTmp.Items[i].Text != string.Empty)
                            {
                                TextValue = BSCommon.LocationControlsText(dt, tsTmp.Items[i].Name, "Text");
                                if (TextValue.ToList().Count > 0)
                                {
                                    tsTmp.Items[i].Text = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                TextValue = BSCommon.LocationControlsText(dt, tsTmp.Items[i].Name, "ToolTipText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    tsTmp.Items[i].ToolTipText = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                //1.3
                                //BSCommon.TraverseControlTextAdd(DockContentFormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].Text, "Text");
                                //BSCommon.TraverseControlTextAdd(DockContentFormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].ToolTipText, "ToolTipText");
                            }
                        }
                    }
                }

                //gridView
                if (ctl is GridControl)
                {
                    MessageBox.Show("dfdf");
                    /*
                    DataGridView dg = (DataGridView)ctl;
                    foreach (object ch in dg.Columns)
                    {
                        {
                            if (ch.GetType().Name == "DataGridViewTextBoxColumn")
                            {
                                TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewTextBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewTextBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }
                            }
                            if (ch.GetType().Name == "DataGridViewComboBoxColumn")
                            {
                                TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewComboBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewComboBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }
                            }
                        }
                    }
                    */
                }
                //gridview

                if (ctl.Controls.Count > 0)
                {
                    SetFormControlsLanuages(DockContentFormN, ctl);
                }

                DockContentFormN.Show();
            }
        }

        //-----------------------
        /// <summary>
        /// 设置窗口（DockContent）语种（子方法）
        /// </summary>
        /// <param name="DockContentFormN"></param>
        /// <param name="ctlTmp"></param>
        public static void SetFormControlsLanuages(DockContent DockContentFormN, Control ctlTmp)
        {
            DataTable dt = new DataTable();
            dt = BSCommon.GetFormLanuageData(DockContentFormN.Name);

            foreach (Control n in ctlTmp.Controls)
            {
                if (n.Text != null && n.Text != string.Empty && n.Text != '0'.ToString() && n.Name != string.Empty)
                {
                    var TextValue = BSCommon.LocationControlsText(dt, n.Name, "Text");
                    if (TextValue.ToList().Count > 0)
                    {
                        n.Text = TextValue.ToList().First().Field<string>("LanguageText");
                    }
                    //3.1

                }

                if (n is DataGridView)
                {
                    DataGridView dg = (DataGridView)n;
                    foreach (object ch in dg.Columns)
                    {
                        {
                            if (ch.GetType().Name == "DataGridViewTextBoxColumn")
                            {
                                var TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewTextBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewTextBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }
                                //3.1.1

                            }
                            if (ch.GetType().Name == "DataGridViewComboBoxColumn")
                            {
                                var TextValue = BSCommon.LocationControlsText(dt, ((DataGridViewComboBoxColumn)ch).Name, "HeaderText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    ((DataGridViewComboBoxColumn)ch).HeaderText = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                //3.1.2
                            }
                        }
                    }
                }

                if (n is ToolStrip)
                {
                    ToolStrip tsTmp = (ToolStrip)n;
                    for (int i = 0; i < tsTmp.Items.Count; i++)
                    {
                        if (tsTmp.Items[i].GetType().Name == "ToolStripButton")//判断是否为ToolStripButton
                        {
                            if (tsTmp.Items[i].Text != string.Empty)
                            {
                                var TextValue = BSCommon.LocationControlsText(dt, tsTmp.Items[i].Name, "Text");
                                if (TextValue.ToList().Count > 0)
                                {
                                    tsTmp.Items[i].Text = TextValue.ToList().First().Field<string>("LanguageText");
                                }

                                TextValue = BSCommon.LocationControlsText(dt, tsTmp.Items[i].Name, "ToolTipText");
                                if (TextValue.ToList().Count > 0)
                                {
                                    tsTmp.Items[i].ToolTipText = TextValue.ToList().First().Field<string>("LanguageText");
                                }
                                //3.3
                                //BSCommon.TraverseControlTextAdd(DockContentFormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].Text, "Text");
                                //BSCommon.TraverseControlTextAdd(DockContentFormN.Name, tsTmp.Items[i].GetType().Name, tsTmp.Items[i].Name, tsTmp.Items[i].ToolTipText, "ToolTipText");
                            }
                        }
                    }
                }

                #region ########GridControl
                if (n is GridControl)
                {
                    GridControl gc = (GridControl)n;
                    foreach (object gv in gc.Views)
                    {
                        DevExpress.XtraGrid.Views.Grid.GridView gvo=(DevExpress.XtraGrid.Views.Grid.GridView)gv;
                        foreach (object column in gvo.Columns)
                        {
                            var TextValue = BSCommon.LocationControlsText(dt, ((DevExpress.XtraGrid.Columns.GridColumn)column).Name, "Caption");
                            DevExpress.XtraGrid.Columns.GridColumn column_o = (DevExpress.XtraGrid.Columns.GridColumn)column;
                            MessageBox.Show( column_o.GetTextCaption());
                            ((DevExpress.XtraGrid.Columns.GridColumn)column).Caption = TextValue.ToList().First().Field<string>("LanguageText"); 
                        }
                    }
                }

                #endregion #########GridControl

                if (n.Controls.Count > 0)
                {
                    SetFormControlsLanuages(DockContentFormN, n);
                }
            }
        }


    }
}
