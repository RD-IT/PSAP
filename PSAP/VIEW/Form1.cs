using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW
{
    public partial class Form1 :DockContent
    {
        public Form1()
        {
            InitializeComponent();
        }

        //用于从功能导航窗口调用此窗口
        private static Form1 _initialize = null;

        public static Form1 getinstance(DockPanel p)
        {
            if (_initialize == null || _initialize.IsDisposed)
            {
                _initialize = new Form1();
            }
            _initialize.Show(p);
            _initialize.Activate();

            return _initialize;
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


        /*
        */
    }
}
