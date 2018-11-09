using PSAP.DAO.BSDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAP.BLL.BSBLL
{
    class FrmDataQueryDesignBLL
    {

        /// <summary>
        /// 将表中的项按照层次加到TreeNode中
        /// </summary>
        /// <param name="treeV"></param>
        /// <param name="menuS"></param>
        public static void tvtbQueryListGetNode(TreeView treeV)
        {
            DataTable dt = FrmDataQueryDesignDAO.GetTopQuerySqlData() ;//获取分组数据

            //遍历数据表中的一级菜单项
            foreach (DataRow dr in dt.Rows)
            {
                //循环添加根部门
                TreeNode node1 = treeV.Nodes.Add(dr["AutoId"].ToString(), dr["QueryText"].ToString());
                node1.Tag = "G";
                GetChildNode(node1, dr["AutoId"].ToString());
            }
        }
        //生成子部门节点
        private static void GetChildNode(TreeNode node1, string strParentId)
        {
            //ToolStripMenuItem pItem = (ToolStripMenuItem)item;
            DataTable dt1 = FrmDataQueryDesignDAO.GetChildQuerySqlData(strParentId);//获取查询数据

            foreach (DataRow dr1 in dt1.Rows)
            {
                if (dr1 != null)
                {
                    TreeNode node2 = node1.Nodes.Add(dr1["AutoId"].ToString(), dr1["QueryText"].ToString());
                    GetChildNode(node2, node2.Name);//递归
                }
            }
        }

        /// <summary>
        /// 将SQL数据类型转换为控件简称
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string SqlChangeToControlAbbreviation(string type)
        {
            //case "txt"
            //case "cbo"
            //case "dtp"
            string reval = string.Empty;
            switch (type.ToLower())
            {
                case "datetime":
                    reval = "dtp";
                    break;
                case "smalldatetime":
                    reval = "dtp";
                    break;
                 case "timestamp":
                    reval = "dtp";
                    break;
                default:
                    reval = "txt";
                    break;
            }
            return reval;
        }

    }
}
