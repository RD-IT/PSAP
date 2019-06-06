using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PSAP.PSAPCommon
{
    class TreeSelectOptimize
    {
        /// <summary>
        /// 选中状态的改变：只要选中一个子节点，其父节点就是选中的
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectChildAndlParent(TreeViewEventArgs e)
        {
            if (e.Action != TreeViewAction.Unknown)
            {
                CheckAllChildNodes(e.Node, e.Node.Checked);
                CheckAllParentNodes(e.Node);
            }
        }

        //选中父节点
        public void CheckAllParentNodes(TreeNode treeNode)
        {
            if (treeNode.Checked & treeNode.Parent!=null)
            {
                treeNode.Parent.Checked = true;
            }
            if (treeNode.Parent != null)
            {
                this.CheckAllParentNodes(treeNode.Parent);
            }            
        }

        //选中子节点 
        public void CheckAllChildNodes(TreeNode treeNode, bool nodeChecked)
        {
            foreach (TreeNode node in treeNode.Nodes)
            {
                node.Checked = nodeChecked;
                if (node.Nodes.Count > 0)
                {
                    this.CheckAllChildNodes(node, nodeChecked);
                }
            }
        }

                /// <summary>
        /// 设置指定的节点为选中状态
        /// </summary>
        /// <param name="treeNode"></param>
        /// <param name="nodeName"></param>
        private void SelectSubNodes(TreeNode treeNode, string nodeName)
        {
            if (treeNode.Text.Equals(nodeName))
            {
                treeNode.Checked = true;
            }
            foreach (TreeNode tn in treeNode.Nodes)
            {
                SelectSubNodes(tn, nodeName);
            }
        }

        private void SelectNodes(TreeView treeView, string nodeName)
        {
            TreeNodeCollection nodes = treeView.Nodes;
            foreach (TreeNode n in nodes)
            {
                SelectSubNodes(n, nodeName);
            }
        }
    }
}
