using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PSAP.DAO.BSDAO;

namespace PSAP.BLL.BSBLL
{
    class FrmOrganizationStruBLL
    {
        /// <summary>
        /// 将表中的项按照层次加到TreeNode中
        /// </summary>
        /// <param name="treeV"></param>
        /// <param name="menuS"></param>
        public static void tvwDepartmentGetNode(TreeView treeV)
        {
            DataTable dt = FrmOrganizationStruDAO.GetTopDepartmentData();//获取根部门数据

            //遍历数据表中的一级菜单项
            foreach (DataRow dr in dt.Rows)
            {
                //循环添加根部门
                TreeNode node1 = treeV.Nodes.Add(dr["DepartmentNo"].ToString(), dr["DepartmentName"].ToString());
                GetChildNode(node1, dr["DepartmentNo"].ToString());
            }
        }
        //生成子部门节点
        private static void GetChildNode(TreeNode node1, string strParentDepartmentNo)
        {
            //ToolStripMenuItem pItem = (ToolStripMenuItem)item;
            DataTable dt1 = FrmOrganizationStruDAO.GetChildDepartmentData(strParentDepartmentNo);//获取子部门数据

            foreach (DataRow dr1 in dt1.Rows)
            {
                if (dr1 != null)
                {
                    TreeNode node2 = node1.Nodes.Add(dr1["DepartmentNo"].ToString(), dr1["DepartmentName"].ToString());
                    GetChildNode(node2, node2.Name);//递归
                }
            }
        }
    }
}
