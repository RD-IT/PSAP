
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
    public partial class FrmUserRight : DockContent
    {
        public static MenuStrip mnuSP1 = new MenuStrip();//

        public FrmUserRight()
        {         
           InitializeComponent();
            //初始化treeView1
            treeView1.CheckBoxes = true;
            GetMenu(treeView1, FrmMain.menuStrip1);
            treeView1.ExpandAll();
        }

        //将MenuStrip中的项按照层次加到TreeNode中
        public static void GetMenu(TreeView treeV, MenuStrip menuS)
        {
            //遍历menuStrip中的一级菜单项
            foreach (ToolStripDropDownItem m1 in menuS.Items)
            {
                //循环添加一级菜单
                TreeNode node1 = treeV.Nodes.Add(m1.Text+" "+m1.Name+"|");

                
                if (m1.Enabled == true)
                {
                    node1.Checked = true;
                }
                GetMenu(node1, m1);
            }
        }

        private static void GetMenu(TreeNode node1, ToolStripDropDownItem m1)
        {
            foreach (ToolStripDropDownItem m2 in m1.DropDownItems)
            {
                if (m2 != null)
                {
                    TreeNode node2 = node1.Nodes.Add(m2.Text);
                    if (m2.Enabled == true)
                    {
                        node2.Checked = true;
                    } 
                    GetMenu(node2, m2);//递归
                }
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
    }
}
