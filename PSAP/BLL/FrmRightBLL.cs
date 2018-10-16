using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSAP.VIEW.BSVIEW;
using System.Reflection;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.BLL
{
    class FrmRightBLL
    {
        /// <summary>
        /// 生成新建节点ID
        /// </summary>
        /// <returns></returns>
        public static string getNewNodeId()
        {
            return "N" //+ DateTime.Now.Year.ToString()
                    + DateTime.Now.Month.ToString()
                    + DateTime.Now.Day.ToString()
                    + DateTime.Now.Hour.ToString()
                    + DateTime.Now.Minute.ToString()
                    + DateTime.Now.Second.ToString()
                    + DateTime.Now.Millisecond.ToString();
        }

        /// <summary>
        /// 初始化窗口下拉列表
        /// </summary>
        public static void InitDataGridViewComboFormName(DataGridViewComboBoxColumn dgvcbxTmp)
        {
            Assembly a = Assembly.LoadFile(Application.ExecutablePath);//.net中的反射
            Type[] types = a.GetTypes();
            dgvcbxTmp.Items.Add("");
            foreach (Type t in types)
            {
                if (t.BaseType.Name == "Form" || t.BaseType.Name == "DockContent")
                {
                    dgvcbxTmp.Items.Add(t.Name);
                    //MessageBox.Show(t.Name+" " +t.BaseType.Name+" " );
                }
            }
        }

        /// <summary>
        /// 遍历TreeView,并将设定的"个人"权限信息保存到数据库
        /// </summary>
        /// <param name="tvwTmp"></param>
        public static void SaveRightFromTree(TreeView tvwTmp)
        {
            //1.获取TreeView的所有根节点
            foreach (TreeNode tn in tvwTmp.Nodes)
            {
                SubNode(tn);
            }
        }

        public static void SubNode(TreeNode tn)
        {
            foreach (TreeNode tnSub in tn.Nodes)
            {
                if (tnSub.Checked == true && !tnSub.Tag.ToString().Contains(":Role"))
                {
                    MessageBox.Show(tnSub.Text);//需改成向数据库存数据的语句
                }
                SubNode(tnSub);
            }
        }

        /// <summary>
        /// 将MenuStrip中的项按照层次加到TreeNode中
        /// </summary>
        /// <param name="treeV"></param>
        /// <param name="menuS"></param>
        public static void TreeGetNodeForMns(TreeView treeV, MenuStrip menuS)
        {
            //遍历menuStrip中的一级菜单项
            foreach (ToolStripDropDownItem m1 in menuS.Items)
            {
                //循环添加一级菜单
                TreeNode node1 = treeV.Nodes.Add(m1.Name, m1.Text);
                node1.Tag = "";
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
                    TreeNode node2 = node1.Nodes.Add(m2.Name, m2.Text);
                    if (m2.Enabled == true)
                    {
                        node2.Checked = true;
                        if (!string.IsNullOrEmpty(m2.Tag.ToString()))
                        {
                            if (m2.Tag.ToString().Substring(m2.Tag.ToString().Length - 5, 5) == ":Role")//为“角色”权限时
                            {
                                node2.BackColor = System.Drawing.SystemColors.Control;
                                node2.NodeFont = new Font("宋体", 9, FontStyle.Italic);//| FontStyle.Bold)
                            }
                        }
                    }

                    //if (m2.Tag.ToString().Substring(m2.Tag.ToString().Length - 5, 5) == ":Role")//为“角色”权限时
                    //{
                    //    node2.Tag =m2.Tag.ToString().Substring(0, m2.Tag.ToString().Length - 5);
                    //}
                    //else
                    //{
                    node2.Tag = m2.Tag;
                    //}

                    GetMenu(node2, m2);//递归
                }
            }
        }

        /// <summary>
        /// 遍历窗口，及其中控件
        /// </summary>
        public static void TraverseForm()
        {
            //Form f = new Form();
            DockContent DockContectFormN = new DockContent();
            Assembly a = Assembly.LoadFile(Application.ExecutablePath);//.net中的反射
            Type[] types = a.GetTypes();
            foreach (Type t in types)
            {
                if (t.BaseType.Name == "DockContent")
                {
                    DockContectFormN = (DockContent)Activator.CreateInstance(t, true);
                    MessageBox.Show(DockContectFormN.Text + " | " + DockContectFormN.Name);
                    foreach (Control ctlForm in DockContectFormN.Controls)//遍历所有“DockContent”窗口
                    {
                        TraverseFormControls(DockContectFormN, ctlForm);
                    }
                }
            }
        }

        public static void TraverseFormControls(DockContent DockContentFormN, Control ctlTmp)
        {
            foreach (Control n in ctlTmp.Controls)
            {
                if (n is Button)
                {
                    MessageBox.Show(DockContentFormN.Name + "==>" + n.Text + "==>" + n.Name + "==>"+n.GetType().ToString());
                }
                if (n is ToolStrip)
                {
                    ToolStrip tsTmp = (ToolStrip)n;
                    for (int i = 0; i < tsTmp.Items.Count; i++)
                    {
                        if (tsTmp.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripButton")//判断是否为ToolStripButton
                        { MessageBox.Show(DockContentFormN.Name + "==>" + tsTmp.Items[i].Text +"==>"+ tsTmp.Items[i].Name); }
                    }
                }
                if (n.Controls.Count > 0)
                {
                    TraverseFormControls(DockContentFormN, n);
                }
            }
        }
    }
}
