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
using System.Collections;
using PSAP.DAO.BSDAO;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using PSAP.PSAPCommon;
using DevExpress.XtraGrid.Views.Grid;

namespace PSAP.BLL.BSBLL
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
        /// 查询全部窗体名称
        /// </summary>
        /// <returns></returns>
        public static DataTable InitFormNameDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("FormName", Type.GetType("System.String"));
            DataRow newRow;
            newRow = table.NewRow();
            newRow["FormName"] = "";
            table.Rows.Add(newRow);

            Assembly a = Assembly.LoadFile(Application.ExecutablePath);//.net中的反射
            Type[] types = a.GetTypes();
            foreach (Type t in types)
            {
                if (t.BaseType.Name == "Form" || t.BaseType.Name == "DockContent")
                {
                    newRow = table.NewRow();
                    newRow["FormName"] = t.Name;
                    table.Rows.Add(newRow);
                }
            }
            return table;
        }

        /// <summary>
        /// 遍历TreeView,并将设定的"个人"权限信息保存到数据库
        /// </summary>
        /// <param name="tvwTmp"></param>
        public static void SavePersonalRightFromTree(TreeView tvwTmp, DataGridView dgvTmp)
        {
            FrmRightDAO.strSqlLlist.Clear();//将命令行变量清空
            //获取TreeView的所有根节点
            foreach (TreeNode tn in tvwTmp.Nodes)
            {
                SubNode(tn, dgvTmp);
            }
            FrmRightDAO.RunSqlStatement_SaveUserMenuButton((int)dgvTmp.CurrentRow.Cells[0].Value);
        }
        public static void SavePersonalRightFromTree(TreeList tvwTmp, GridView dgvTmp)
        {
            FrmRightDAO.strSqlLlist.Clear();//将命令行变量清空
            //获取TreeView的所有根节点
            foreach (TreeListNode tn in tvwTmp.Nodes)
            {
                SubNode(tn, dgvTmp);
            }
            FrmRightDAO.RunSqlStatement_SaveUserMenuButton(DataTypeConvert.GetInt(dgvTmp.GetFocusedDataRow()[0]));
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
        public static void SubNode(TreeListNode tn, GridView dgvTmp)
        {
            foreach (TreeListNode tnSub in tn.Nodes)
            {
                string s1 = tnSub[1].ToString();
                if (tnSub.Checked == true && !DataTypeConvert.GetString(tnSub.Tag).Contains(":Role"))
                {
                    if (DataTypeConvert.GetString(tnSub.Tag) == "button")
                    {
                        //将设定的用户“按钮”权限保存到数据库
                        FrmRightDAO.AddSqlStatement_SaveUserMenuButton(DataTypeConvert.GetInt(dgvTmp.GetFocusedDataRow()[0]), FrmRightDAO.GetMenuButtonId(DataTypeConvert.GetString(tnSub.ParentNode["MenuName"]), DataTypeConvert.GetString(tnSub["MenuName"])));
                    }
                    else
                    {
                        //将设定的用户“菜单”权限保存到数据库
                        FrmRightDAO.AddSqlStatement_SaveUserMenuButton(DataTypeConvert.GetInt(dgvTmp.GetFocusedDataRow()[0]), FrmRightDAO.GetMenuButtonId(DataTypeConvert.GetString(tnSub["MenuName"]), "menuItemFlag"));
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
        public static void TreeGetNodeForMns(TreeList treeV, MenuStrip menuS)
        {
            //遍历menuStrip中的一级菜单项
            foreach (ToolStripDropDownItem m1 in menuS.Items)
            {
                //循环添加一级菜单
                TreeListNode node1 = treeV.Nodes.Add(new object[] { m1.Name, m1.Text });
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
        private static void GetMenu(TreeListNode node1, ToolStripDropDownItem m1)
        {
            foreach (ToolStripDropDownItem m2 in m1.DropDownItems)
            {
                if (m2 != null)
                {
                    TreeListNode node2 = node1.Nodes.Add(new object[] { m2.Name, m2.Text });
                    if (m2.Enabled == true)
                    {
                        node2.Checked = true;
                        if (!string.IsNullOrEmpty(m2.Tag.ToString()))
                        {
                            if (m2.Tag.ToString().Substring(m2.Tag.ToString().Length - 5, 5) == ":Role")//为“角色”权限时
                            {
                                //node2.BackColor = System.Drawing.SystemColors.Control;
                                //node2.NodeFont = new Font("宋体", 9, FontStyle.Italic);//| FontStyle.Bold)
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
            DockContent DockContentFormN = new DockContent();
            Assembly a = Assembly.LoadFile(Application.ExecutablePath);//.net中的反射
            Type[] types = a.GetTypes();
            FrmRightDAO.CreateButtonsTempTable();//在数据库中建button临时表
            foreach (Type t in types)
            {
                if (t.BaseType.Name == "DockContent")
                {
                    DockContentFormN = (DockContent)Activator.CreateInstance(t, true);
                    //MessageBox.Show(DockContectFormN.Text + " | " + DockContectFormN.Name);
                    foreach (Control ctl in DockContentFormN.Controls)//遍历所有“DockContent”窗口
                    {
                        if (ctl is Button)
                        {
                            FrmRightDAO.AddSqlStatement(DockContentFormN.Name, ctl.Name, ctl.Text);
                        }
                        else if (ctl is SimpleButton)
                        {
                            FrmRightDAO.AddSqlStatement(DockContentFormN.Name, ctl.Name, ctl.Text);
                        }
                        else if (ctl is ToolStrip)
                        {
                            ToolStrip tsTmp = (ToolStrip)ctl;
                            for (int i = 0; i < tsTmp.Items.Count; i++)
                            {
                                if (tsTmp.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripButton")//判断是否为ToolStripButton
                                {
                                    FrmRightDAO.AddSqlStatement(DockContentFormN.Name, tsTmp.Items[i].Name, tsTmp.Items[i].Text);
                                }
                            }
                        }
                        if (ctl.Controls.Count > 0)
                        {
                            TraverseFormControls(DockContentFormN, ctl);
                        }
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
                else if (n is SimpleButton)
                {
                    FrmRightDAO.AddSqlStatement(DockContentFormN.Name, n.Name, n.Text);
                }
                else if (n is ToolStrip)
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
        public static void TreeAddButtonsNode(TreeList tvwTmp)
        {
            //1.获取TreeView的所有根节点
            Assembly a = Assembly.LoadFile(Application.ExecutablePath);//.net中的反射
            Type[] types = a.GetTypes();
            foreach (TreeListNode tn in tvwTmp.Nodes)
            {
                SubButtonsNode(tn, types);
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
        public static void SubButtonsNode(TreeListNode tn, Type[] types)
        {
            foreach (TreeListNode tnSub in tn.Nodes)
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
                        TraverseForm(strTag, tnSub, types);//将窗口控件加入树
                    }
                }
                SubButtonsNode(tnSub, types);
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
                    foreach (Control ctl in DockContectFormN.Controls)//遍历
                    {
                        if (ctl is Button)
                        {
                            if (!strNotRightButton.Contains(ctl.Name))
                            {
                                tn.Nodes.Add(ctl.Name, ctl.Text);//增加按钮节点
                            }
                            foreach (TreeNode tn1 in tn.Nodes)
                            {
                                tn1.Tag = "button";//按钮节点
                                VerifyButtonPersonalRight(strUserNo, tn.Name, tn1);

                            }
                        }
                        if (ctl is ToolStrip)
                        {
                            ToolStrip tsTmp = (ToolStrip)ctl;
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
                        TraverseFormControlsAddTree(DockContectFormN, ctl, tn, strUserNo);
                    }
                }
            }
        }
        public static void TraverseForm(string strFormName, TreeListNode tn, Type[] types)
        {
            //Form f = new Form();
            DockContent DockContectFormN = new DockContent();
            foreach (Type t in types)
            {
                if (t.BaseType.Name == "DockContent" && t.Name == strFormName)//遍历找到指定“DockContent”窗口
                {
                    DockContectFormN = (DockContent)Activator.CreateInstance(t, true);
                    foreach (Control ctl in DockContectFormN.Controls)//遍历
                    {
                        if (ctl is Button)
                        {
                            if (!strNotRightButton.Contains(ctl.Name))
                            {
                                tn.Nodes.Add(ctl.Name, ctl.Text, tn["MenuName"]);//增加按钮节点
                            }
                            foreach (TreeListNode tn1 in tn.Nodes)
                            {
                                tn1.Tag = "button";//按钮节点
                                //VerifyButtonPersonalRight(strUserNo, DataTypeConvert.GetString(tn["MenuName"]), tn1);
                                //if (buttonTable.Select(string.Format("buttonName = '{0}'", DataTypeConvert.GetString(tn1["MenuName"]))).Length > 0)
                                //    tn1.Checked = true;
                            }
                        }
                        //if (ctl is ToolStrip)
                        //{
                        //    ToolStrip tsTmp = (ToolStrip)ctl;
                        //    for (int i = 0; i < tsTmp.Items.Count; i++)
                        //    {
                        //        if (tsTmp.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripButton")//判断是否为ToolStripButton
                        //        {
                        //            if (!strNotRightButton.Contains(tsTmp.Items[i].Name))
                        //            {
                        //                tn.Nodes.Add(tsTmp.Items[i].Name, tsTmp.Items[i].Text);//增加按钮节点
                        //            }
                        //        }
                        //    }
                        //    foreach (TreeListNode tn1 in tn.Nodes)
                        //    {
                        //        tn1.Tag = "button";//按钮节点
                        //        VerifyButtonPersonalRight(strUserNo, DataTypeConvert.GetString(tn["MenuName"]), tn1);

                        //    }
                        //}
                        TraverseFormControlsAddTree(DockContectFormN, ctl, tn);
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
                else if (n is SimpleButton)
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
                else if (n is ToolStrip)
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
        public static void TraverseFormControlsAddTree(DockContent DockContentFormN, Control ctlTmp, TreeListNode tn)
        {
            foreach (Control n in ctlTmp.Controls)
            {
                if (n is Button)
                {
                    if (!strNotRightButton.Contains(n.Name))
                    {
                        tn.Nodes.Add(n.Name, n.Text, tn["MenuName"]);//增加按钮节点
                    }
                    foreach (TreeListNode tn1 in tn.Nodes)
                    {
                        tn1.Tag = "button";//按钮节点
                        //VerifyButtonPersonalRight(strUserNo, DataTypeConvert.GetString(tn["MenuName"]), tn1);
                        //if (buttonTable.Select(string.Format("buttonName = '{0}'", DataTypeConvert.GetString(tn1["MenuName"]))).Length > 0)
                        //    tn1.Checked = true;
                    }
                }
                else if (n is SimpleButton)
                {
                    if (!strNotRightButton.Contains(n.Name))
                    {
                        tn.Nodes.Add(n.Name, n.Text, tn["MenuName"]);//增加按钮节点
                    }
                    foreach (TreeListNode tn1 in tn.Nodes)
                    {
                        tn1.Tag = "button";//按钮节点
                        string dsf = DataTypeConvert.GetString(tn["MenuName"]);
                        //VerifyButtonPersonalRight(strUserNo, DataTypeConvert.GetString(tn["MenuName"]), tn1);
                        //if (buttonTable.Select(string.Format("buttonName = '{0}'", DataTypeConvert.GetString(tn1["MenuName"]))).Length > 0)
                        //    tn1.Checked = true;
                    }
                }
                else if (n is ToolStrip)
                {
                    ToolStrip tsTmp = (ToolStrip)n;
                    for (int i = 0; i < tsTmp.Items.Count; i++)
                    {
                        if (tsTmp.Items[i].GetType().ToString() == "System.Windows.Forms.ToolStripButton")//判断是否为ToolStripButton
                        {
                            if (!strNotRightButton.Contains(tsTmp.Items[i].Name))
                            {
                                tn.Nodes.Add(tsTmp.Items[i].Name, tsTmp.Items[i].Text, tn["MenuName"]);//增加按钮节点
                            }
                        }
                    }
                    foreach (TreeListNode tn1 in tn.Nodes)
                    {
                        tn1.Tag = "button";//按钮节点
                        //VerifyButtonPersonalRight(strUserNo, DataTypeConvert.GetString(tn["MenuName"]), tn1);
                    }
                }
                if (n.Controls.Count > 0)
                {
                    TraverseFormControlsAddTree(DockContentFormN, n, tn);
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
        public static void VerifyButtonPersonalRight(string strUserNo, string strMenuName, TreeListNode tnTmp)
        {
            DataTable dt = FrmRightDAO.GetButtonPersonalRightData(strUserNo, strMenuName);
            if (dt.Rows.Count != 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (DataTypeConvert.GetString(tnTmp["MenuName"]) == dr["buttonName"].ToString())
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
                if (tnSub.Checked == true)
                {
                    if (tnSub.Tag.ToString() == "button")
                    {
                        //将设定的用户“按钮”权限保存到数据库
                        //FrmRightDAO.AddSqlStatement_SaveUserMenuButton(dgvTmp.CurrentRow.Cells[1].Value.ToString(), FrmRightDAO.GetMenuButtonId(tnSub.Parent.Name, tnSub.Name));
                    }
                    else
                    {
                        //将设定的用户“菜单”权限保存到数据库
                        FrmRightDAO.AddSqlStatement_SaveRoleMenuButton(dgvTmp.CurrentRow.Cells[1].Value.ToString(), tnSub.Name);
                    }
                }
                SubNodeRole(tnSub, dgvTmp);
            }
        }

        public void SetTreeListNodeState(TreeList treeList, string userNoStr)
        {
            DataTable buttonTable = new FrmRightDAO().GetButtonPersonal(userNoStr);
            foreach (TreeListNode node in treeList.Nodes)
            {
                SetSubTreeListNodeState(node, buttonTable);
            }
        }

        public void SetSubTreeListNodeState(TreeListNode parentNode, DataTable buttonTable)
        {
            foreach (TreeListNode node in parentNode.Nodes)
            {
                string mn = DataTypeConvert.GetString(node["MenuName"]);
                string pmn = DataTypeConvert.GetString(node["ParentMenuName"]);
                if (buttonTable.Select(string.Format("buttonName = '{0}' and MenuName = '{1}'", mn, pmn)).Length > 0)
                    node.Checked = true;
                SetSubTreeListNodeState(node, buttonTable);
            }
        }
    }
}
