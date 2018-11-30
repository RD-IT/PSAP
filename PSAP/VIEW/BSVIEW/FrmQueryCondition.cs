using PSAP.BLL.BSBLL;
using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
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
    public partial class FrmQueryCondition : Form
    {
        string[,] strsControlTmp;
        TableLayoutPanel table = new TableLayoutPanel();
        private TextBox[] txt;
        private ComboBox[] cbo;
        private DataTable[] dt;
        private DateTimePicker[] dtp;
        public FrmQueryCondition(string[,] strsTmp, DataTable[] dtTmp)
        {
            InitializeComponent();
            strsControlTmp = strsTmp;
            dt = dtTmp;

            if (SystemInfo.user.Lanuage != "Chinese")
            {
                BSBLL.SetFormLanguages(this);//设置DockContent中的语种
            }
        }

        public FrmQueryCondition()
        {
            InitializeComponent();

        }
        private void FrmQueryCondition_Load(object sender, EventArgs e)
        {
            addControl(strsControlTmp);
        }

        /// <summary>
        /// 添加控件
        /// </summary>
        /// <param name="strsQueryTmp"></param>
        private void addControl(string[,] strsQueryTmp)
        {
            int intRowHeight = 30;//行高
            table.Dock = DockStyle.Top;
            panel1.Controls.Add(table);
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

            if (table.Height < FrmMain.frmMain.Height * 0.6 / intRowHeight * intRowHeight)
            {
                panel1.Height = table.Height;
            }
            else
            {
                panel1.Height = (int)(FrmMain.frmMain.Height * 0.6 / intRowHeight * intRowHeight);
            }
            this.Height = panel1.Height + btnQuery.Height + 80;
            this.Width = intColumnW1 + intColumnW2 + 70;
            tableLayoutPanel1.Top = panel1.Height + 20;
            this.Top = 100;
            this.Left = FrmMain.frmMain.Width - this.Width - 30;
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

        /// <summary>
        ///取消查询给所有查询参数赋“”值
        /// </summary>
        private void CancleQueryParameter()
        {
            for (int i = 0; i < strsControlTmp.GetLength(0); i++)
            {
                strsControlTmp[i, 1] = string.Empty;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancleQueryParameter();
            this.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            saveQueryParameter();
            this.Close();
        }
    }
}
