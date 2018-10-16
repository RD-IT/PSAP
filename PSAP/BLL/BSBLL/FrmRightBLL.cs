﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PSAP.VIEW.BSVIEW;
using System.Reflection;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using WeifenLuo.WinFormsUI.Docking;
using System.Collections;
using PSAP.DAO.BSDAO;

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
        public static void SaevPersonalRightFromTree(TreeView tvwTmp, DataGridView dgvTmp)
        {
            FrmRightDAO.strSqlLlist.Clear();//将命令行变量清空
            //获取TreeView的所有根节点
            foreach (TreeNode tn in tvwTmp.Nodes)
            {
                SubNode(tn, dgvTmp);
            }
            FrmRightDAO.RunSqlStatement_SaveUserMenuButton((int)dgvTmp.CurrentRow.Cells[0].Value);
        }

        public static void SubNode(TreeNode tn, DataGridView dgvTmp)
        {
            foreach (TreeNode tnSub in tn.Nodes)
            {
                if (tnSub.Checked == true && !tnSub.Tag.ToString().Contains(":Role"))
                {
                    if (tnSub.Tag.ToString() == "button")
                    {
                        //将设定的用户“按钮”权限保存到数据库
                        FrmRightDAO.AddSqlStatement_SaveUserMenuButton((int)dgvTmp.CurrentRow.Cells[0].Value, FrmRightDAO.GetMenuButtonId(tnSub.Parent.Name, tnSub.Name));
                    }
                    else
                    {
                        //将设定的用户“菜单”权限保存到数据库
                        FrmRightDAO.AddSqlStatement_SaveUserMenuButton((int)dgvTmp.CurrentRow.Cells[0].Value, FrmRightDAO.GetMenuButtonId(tnSub.Name, "menuItemFlag"));
                    }
                }
                SubNode(tnSub, dgvTmp);
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
                    node2.Tag = m2.Tag;
                    GetMenu(node2, m2);//递归
                }
            }
        }

        /// <summary>
        /// 遍历窗口及其中控件,并将结果加至数据库表中
        /// </summary>
        public static void TraverseFormControlToTable()
        {
            DockContent DockContectFormN = new DockContent();
            Assembly a = Assembly.LoadFile(Application.ExecutablePath);//.net中的反射
            Type[] types = a.GetTypes();
            FrmRightDAO.CreateButtonsTempTable();//在数据库中建button临时表
            foreach (Type t in types)
            {
                if (t.BaseType.Name == "DockContent")
                {
                    DockContectFormN = (DockContent)Activator.CreateInstance(t, true);
                    //MessageBox.Show(DockContectFormN.Text + " | " + DockContectFormN.Name);
                    foreach (Control ctlForm in DockContectFormN.Controls)//遍历所有“DockContent”窗口
                    {
                        TraverseFormControls(DockContectFormN, ctlForm);
                    }
                }
            }
            FrmRightDAO.RunSqlStatement();//以事务方式执行拼接好的sql语句组
        }

        public static void TraverseFormControls(DockContent DockContentFormN, Control ctlTmp)
        {
            foreach (Control n in ctlTmp.Controls)
            {
                if (n is Button)
                {
                    //MessageBox.Show(DockContentFormN.Name + "==>" + n.Text + "==>" + n.Name);
                    FrmRightDAO.AddSqlStatement(DockContentFormN.Name, n.Name, n.Text);
                }
                if (n is ToolStrip)
                {
                    ToolStrip tsTmp = (ToolStrip)n;
                    for (int i = 0; i < tsTmp.Items.Count; i++)
                    {
                        if (tsTmp.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripButton")//判断是否为ToolStripButton
                        {
                            //MessageBox.Show(DockContentFormN.Name + "==>" + tsTmp.Items[i].Text + "==>" + tsTmp.Items[i].Name);
                            FrmRightDAO.AddSqlStatement(DockContentFormN.Name, tsTmp.Items[i].Name, tsTmp.Items[i].Text);
                        }
                    }
                }
                if (n.Controls.Count > 0)
                {
                    TraverseFormControls(DockContentFormN, n);
                }
            }
        }


        /// <summary>
        /// 遍历TreeView所有叶字节点,并将tag为有效窗口名的节点实例化并添加其中的button类型控件
        /// </summary>
        /// <param name="tvwTmp"></param>
        public static void TreeAddButtonsNode(TreeView tvwTmp, string strUserNo)
        {
            //1.获取TreeView的所有根节点
            foreach (TreeNode tn in tvwTmp.Nodes)
            {
                SubButtonsNode(tn, strUserNo);
            }
        }
        //子过程
        public static void SubButtonsNode(TreeNode tn, string strUserNo)
        {
            foreach (TreeNode tnSub in tn.Nodes)
            {
                //if (tnSub.Checked == true && !tnSub.Tag.ToString().Contains(":Role"))
                if (tnSub.Tag != null)
                {
                    if (tnSub.Nodes.Count == 0 && !string.IsNullOrEmpty(tnSub.Tag.ToString()))
                    {
                        string strTag = tnSub.Tag.ToString();
                        if (strTag.Contains(":Role"))
                        {
                            strTag = strTag.Substring(0, strTag.Length - 5);
                        }
                        TraverseForm(strTag, tnSub, strUserNo);//将窗口控件加入树
                    }
                }
                SubButtonsNode(tnSub, strUserNo);
            }
        }

        /// <summary>
        /// 遍历指定窗口，及其中控件
        /// </summary>
        public static void TraverseForm(string strFormName, TreeNode tn, string strUserNo)
        {
            //Form f = new Form();
            DockContent DockContectFormN = new DockContent();
            Assembly a = Assembly.LoadFile(Application.ExecutablePath);//.net中的反射
            Type[] types = a.GetTypes();
            foreach (Type t in types)
            {
                if (t.BaseType.Name == "DockContent" && t.Name == strFormName)//遍历找到指定“DockContent”窗口
                {
                    DockContectFormN = (DockContent)Activator.CreateInstance(t, true);
                    foreach (Control ctlForm in DockContectFormN.Controls)//遍历
                    {
                        TraverseFormControlsAddTree(DockContectFormN, ctlForm, tn, strUserNo);
                    }
                }
            }
        }
        //字符串中设定的“按钮”不需进行权限设定
        public static string strNotRightButton = "bdnMoveFirstItem " +
                                                "bdnMoveLastItem " +
                                                "bdnMoveNextItem " +
                                                "bdnMovePreviousItem " +
                                                "tsbCancel " +
                                                "tsbClose " +
                                                "tsbSave ";
        public static void TraverseFormControlsAddTree(DockContent DockContentFormN, Control ctlTmp, TreeNode tn, string strUserNo)
        {
            foreach (Control n in ctlTmp.Controls)
            {
                if (n is Button)
                {
                    if (!strNotRightButton.Contains(n.Name))
                    {
                        tn.Nodes.Add(n.Name, n.Text);//增加按钮节点
                    }
                    foreach (TreeNode tn1 in tn.Nodes)
                    {
                        tn1.Tag = "button";//按钮节点
                        VerifyButtonPersonalRight(strUserNo, tn.Name, tn1);

                    }
                }
                if (n is ToolStrip)
                {
                    ToolStrip tsTmp = (ToolStrip)n;
                    for (int i = 0; i < tsTmp.Items.Count; i++)
                    {
                        if (tsTmp.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripButton")//判断是否为ToolStripButton
                        {
                            if (!strNotRightButton.Contains(tsTmp.Items[i].Name))
                            {
                                tn.Nodes.Add(tsTmp.Items[i].Name, tsTmp.Items[i].Text);//增加按钮节点
                            }
                        }
                    }
                    foreach (TreeNode tn1 in tn.Nodes)
                    {
                        tn1.Tag = "button";//按钮节点
                        VerifyButtonPersonalRight(strUserNo, tn.Name, tn1);

                    }
                }
                if (n.Controls.Count > 0)
                {
                    TraverseFormControlsAddTree(DockContentFormN, n, tn, strUserNo);
                }
            }
        }

        /// <summary>
        /// 验证个人按钮权限
        /// </summary>
        /// <param name="intUserNo"></param>
        /// <param name="strMenuName"></param>
        /// <param name="tnTmp"></param>
        public static void VerifyButtonPersonalRight(string strUserNo, string strMenuName, TreeNode tnTmp)
        {
            DataTable dt = FrmRightDAO.GetButtonPersonalRightData(strUserNo, strMenuName);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (tnTmp.Name == dr["buttonName"].ToString())
                    {
                        tnTmp.Checked = true;
                    }
                }
            }
        }
        /// <summary>
        /// 保存设定的角色权限数据
        /// </summary>
        /// <param name="tvwTmp"></param>
        /// <param name="dgvTmp"></param>
        public static void SaveRoleRightFromTree(TreeView tvwTmp, DataGridView dgvTmp)
        {
            FrmRightDAO.strSqlLlist.Clear();//将命令行变量清空
            //获取TreeView的所有根节点
            foreach (TreeNode tn in tvwTmp.Nodes)
            {
                SubNodeRole(tn, dgvTmp);
            }
            FrmRightDAO.RunSqlStatement_SaveRoleMenuButton(dgvTmp.CurrentRow.Cells[1].Value.ToString());
        }

        public static void SubNodeRole(TreeNode tn, DataGridView dgvTmp)
        {
            foreach (TreeNode tnSub in tn.Nodes)
            {
                if (tnSub.Checked == true )
                {
                    if (tnSub.Tag.ToString() == "button")
                    {
                        //将设定的用户“按钮”权限保存到数据库
                        //FrmRightDAO.AddSqlStatement_SaveUserMenuButton(dgvTmp.CurrentRow.Cells[1].Value.ToString(), FrmRightDAO.GetMenuButtonId(tnSub.Parent.Name, tnSub.Name));
                    }
                    else
                    {
                        //将设定的用户“菜单”权限保存到数据库
                        FrmRightDAO.AddSqlStatement_SaveRoleMenuButton(dgvTmp.CurrentRow.Cells[1].Value.ToString(),tnSub.Name);
                    }
                }
                SubNodeRole(tnSub, dgvTmp);
            }
        }


    }
}