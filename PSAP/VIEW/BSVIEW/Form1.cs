﻿using System;
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
    public partial class Form1 :DockContent
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
            tableLayoutPanel1.Padding=new Padding(20);
            tableLayoutPanel1.RowCount = 20;
            tableLayoutPanel1.Dock = DockStyle.Fill;

            Label[] label1= new Label[10];
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string path = @"..\..\VIEW\REPORT\Report111.rdlc";
            //"RptDt1":报表中的数据源名称
            //dsPSAP.Tables["BS_Menu"])当前界面数据对象名
            dsPSAP ds = new dsPSAP();
            string str = @"select * from BS_Menu ";
            DataTable[] dt = new DataTable[1];//数据由报表数据集个数决定
            dt[0]=PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(str);
            string[] strRptDataSetName = new string[1];
            strRptDataSetName[0] = "Rpt1"; 
            FrmPrintPreview f = new BSVIEW.FrmPrintPreview(path,strRptDataSetName,dt);
            f.ShowDialog();
        }
    }
}