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
        }

        private void tvtbQueryList_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //单击展开或收起节点
            if (e.Node.IsExpanded)
            {
                e.Node.Collapse();
            }
            else
            {
                e.Node.Expand();
            }
            if (e.Node.Nodes.Count == 0)
            {
                MessageBox.Show("dfdfdfdfdfdf");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {


        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            /*
            string[,] strsQueryTmp = new string[3, 2];
            DataTable[] dt = new DataTable[strsQueryTmp.GetLongLength(0)];
            strsQueryTmp[0, 0] = "部门编号";
            strsQueryTmp[1, 0] = "部门名称";
            strsQueryTmp[2, 0] = "上级部门编号";
            strsQueryTmp[0, 1] = "txt";
            strsQueryTmp[1, 1] = "cbo";
            strsQueryTmp[2, 1] = "txt";
            dt[1] = BSCommon.getDepartmentList();//下标代表代号
            FrmQueryCondition f = new FrmQueryCondition(strsQueryTmp, dt);
            f.ShowDialog();

            string strFilter;
            strFilter = "DepartmentNo like '*" + strsQueryTmp[0, 1] + "*' " +
                "and DepartmentNo like '*" + strsQueryTmp[1, 1] + "*' " +
                "and ParentDepartmentNo like '*" + strsQueryTmp[2, 1] + "*'";
            this.bS_DepartmentBindingSource.Filter = strFilter;
        */

    }
}
}
