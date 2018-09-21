using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PSAP
{
    class TreeGetNodeForMns
    {
        /// <summary>
        /// 将MenuStrip中的项按照层次加到TreeNode中
        /// </summary>
        /// <param name="treeV"></param>
        /// <param name="menuS"></param>
        public static void GetMenu(TreeView treeV, MenuStrip menuS)
        {
            //遍历menuStrip中的一级菜单项
            foreach (ToolStripDropDownItem m1 in menuS.Items)
            {
                //循环添加一级菜单
                TreeNode node1 = treeV.Nodes.Add(m1.Name,m1.Text);

                if (m1.Enabled == true)
                {
                    node1.Checked = true;
                }
                GetMenu(node1, m1);
            }
        }
        //生成子菜单
        private static void GetMenu(TreeNode node1, ToolStripDropDownItem m1)
        {
            foreach (ToolStripDropDownItem m2 in m1.DropDownItems)
            {
                if (m2 != null)
                {
                    TreeNode node2 = node1.Nodes.Add(m2.Name,m2.Text);
                    if (m2.Enabled == true)
                    {
                        node2.Checked = true;
                    }
                    GetMenu(node2, m2);//递归
                }
            }
        }

    }
}
