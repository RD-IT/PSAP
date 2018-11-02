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
    }
}
