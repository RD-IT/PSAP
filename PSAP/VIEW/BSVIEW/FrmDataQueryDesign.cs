using PSAP.DAO.BSDAO;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //参数名称 参数数据类型
            //@datatime   61
            //@date       40
            //@bit        104

            string sqlString = 
                "select name as 参数名称,xusertype 参数数据类型, length 参数数据长度 " +
                "from syscolumns " +
                "where id = (select id from sysobjects where name = 'pub_CreateDataDictionary') ";
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
    }
}
