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
    }
}
