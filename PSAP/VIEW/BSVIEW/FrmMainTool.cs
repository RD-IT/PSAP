using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using UtilityLibrary.WinControls;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmMainTool : DockContent
    {
        OutlookBar outlookBar1 = null;
        TreeViewEx[] treeView = null;//声明
        MenuStrip sp1 = new MenuStrip();
        DockPanel dp1 = new DockPanel();
        public static int frmOpenFlag;

        /// <summary>
        /// 仅用于反射创建实例，取窗口text属性(暂时没用)
        /// </summary>
        public FrmMainTool()
        {
            InitializeComponent();
        }

        public FrmMainTool(MenuStrip mnuS1)
        {
            sp1 = mnuS1;
            treeView = new TreeViewEx[sp1.Items.Count];//实例
            InitializeComponent();
            InitializeTreeControl();//初始化treeView
            InitializeOutlookBar();
        }

        void InitializeOutlookBar()
        {
            outlookBar1 = new OutlookBar();
            /*
            //样式设定《Begin》
            outlookBar1.BackgroundBitmap = (Bitmap)imageList1.Images[4];
            outlookBar1.BackgroundImage = imageList1.Images[4];
            //样式设定《End》
            */

            //增加选项卡《Begin》 
            //将MenuStrip中的一级菜单加到outlookBar1中[遍历menuStrip中的一级菜单项]

            int i = 0;
            foreach (ToolStripDropDownItem m1 in sp1.Items)
            {
                //循环添加一级菜单
                if (m1.Enabled == true)
                {
                    outlookBar1.Bands.Add(new OutlookBarBand(m1.Text, treeView[i]));//, treeView1
                    i++;
                }
            }
            //增加选项卡《End》
            outlookBar1.Dock = DockStyle.Fill;
            outlookBar1.SetCurrentBand(0);
            outlookBar1.AnimationSpeed = 5;
            this.Controls.AddRange(new Control[] { outlookBar1 });
        }

        // Initialize Tree Control 【基本信息】
        #region
        void InitializeTreeControl()
        {
            SuspendLayout();//临时挂起控件的布局逻辑
            GetMenu(sp1);
            //********************************
            /*
            // treeView1
            //treeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //treeView.Dock = System.Windows.Forms.DockStyle.Fill;
            //treeView.Name = "treeView1";
            //treeView.Size = new System.Drawing.Size(292, 266);
            //treeView.TabIndex = 0;
            //treeView.ImageList = imageList1;//sx
            //treeView.ImageIndex = -1;
            //treeView.SelectedImageIndex = -1;
            //treeView.ShowLines = false;
            //treeView.ShowNodeToolTips = true;
            //treeView.FullRowSelect = true;
            //treeView.HotTracking = true;

            //增加事件
            treeView.DoubleClick += new EventHandler(treeView1_DoubleClick);

            //加根目录
            TreeNode rootNode = new TreeNode("部门信息");
            rootNode.ImageIndex = 0;
            rootNode.SelectedImageIndex = 0;
            treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { rootNode });
                // Add the children to the rootNode
                TreeNode myComputer = new TreeNode("My Computer");
                myComputer.ImageIndex = 0;
                myComputer.SelectedImageIndex = 3;
                rootNode.Nodes.Add(myComputer);
            //加根目录1
            TreeNode rootNode1 = new TreeNode("用户权限");
            rootNode1.ImageIndex = 0;
            rootNode1.SelectedImageIndex = 0;
            treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { rootNode1 });


            //treeView.SelectedImageIndex = -1;
            treeView.Size = new System.Drawing.Size(436, 260);
            treeView.TabIndex = 0;
            treeView.Scrollable = false;

            treeView.ExpandAll();
            */
            this.ResumeLayout(false);//恢复正常的布局逻辑
        }

        //将MenuStrip中的项按照层次加到TreeNode中
        public void GetMenu(MenuStrip menuS)//public static void GetMenu(TreeView treeV, MenuStrip menuS)
        {
            int i = 0;
            //遍历menuStrip中的一级菜单项
            foreach (ToolStripDropDownItem m1 in menuS.Items)
            {
                //循环添加一级菜单
                treeView[i] = new TreeViewEx();
                treeView[i].BorderStyle = System.Windows.Forms.BorderStyle.None;
                treeView[i].Dock = System.Windows.Forms.DockStyle.Fill;
                treeView[i].Name = "treeView1";
                treeView[i].Size = new System.Drawing.Size(292, 266);
                treeView[i].TabIndex = 0;
                treeView[i].ImageList = imageList1;//sx
                treeView[i].ImageIndex = 0;
                treeView[i].SelectedImageIndex = 0;
                treeView[i].ShowLines = false;
                treeView[i].ShowNodeToolTips = true;
                treeView[i].FullRowSelect = true;
                treeView[i].HotTracking = true;
                treeView[i].ShowPlusMinus = false;

                // treeView[i].DoubleClick += new EventHandler(treeView1_DoubleClick);//双击
                treeView[i].NodeMouseClick += new TreeNodeMouseClickEventHandler(treeView1_NodeMouseClick);

                if (m1.Enabled == true)
                {
                    TreeNode node1 = treeView[i].Nodes.Add(m1.Name, m1.Text);
                    //node1.Checked = true;
                    node1.Text = "";//隐藏根结点
                    node1.Tag = "";
                    node1.ImageIndex = 3;//根节点图标
                    node1.SelectedImageIndex = 3;//根节点图标
                    GetMenu(node1, m1);
                    i++;
                }
                treeView[i - 1].ExpandAll();
            }
        }

        private static void GetMenu(TreeNode node1, ToolStripDropDownItem m1)
        {
            foreach (ToolStripDropDownItem m2 in m1.DropDownItems)
            {
                if (m2 != null && m2.Enabled == true)
                {
                    TreeNode node2 = node1.Nodes.Add(m2.Name, m2.Text);
                    node2.Tag = m2.Tag;
                    if (m2.DropDownItems.Count > 0)//判断是否为父节点
                    {
                        node2.ImageIndex = 3;//父节点图标
                        node2.SelectedImageIndex = 0;//父节点图标
                    }
                    GetMenu(node2, m2);//递归   
                }
            }
        }

        #endregion
        /*
        // Initialize Tree Control 【系统管理】
        #region
        void InitializeTreeControlOfSystemManagment()
        {
            // Use new support added to the ResourceUtil class
            //treeImageList = ResourceUtil.LoadImageListResource(Type.GetType("Demo.Form1"),
            //    "TreeViewImages", "TreeIcons", new Size(16, 16), true, new Point(0, 0));

            SuspendLayout();//临时挂起控件的布局逻辑

            // treeView2
            treeView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            treeView2.Dock = System.Windows.Forms.DockStyle.Fill;
            treeView2.Name = "treeView2";
            treeView2.Size = new System.Drawing.Size(292, 266);
            treeView2.TabIndex = 0;
            treeView2.ImageIndex = -1;
            treeView2.ImageList = imageList1;//sx
            treeView2.SelectedImageIndex = -1;
            treeView2.ShowLines = false;
            treeView2.ShowNodeToolTips = true;
            treeView2.FullRowSelect = true;
            treeView2.HotTracking = true;

            //加根目录
            TreeNode rootNode = new TreeNode("DeskTop");
            rootNode.ImageIndex = 0;
            rootNode.SelectedImageIndex = 0;
            treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { rootNode });
            //// Add the children to the rootNode
            //TreeNode myComputer = new TreeNode("My Computer");
            //myComputer.ImageIndex = 4;
            //myComputer.SelectedImageIndex = 4;
            //rootNode.Nodes.Add(myComputer);

            //加根目录1
            TreeNode rootNode1 = new TreeNode("口令设定");
            rootNode1.ImageIndex = 0;
            rootNode1.SelectedImageIndex = 0;
            treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { rootNode1 });


            //加根目录2
            TreeNode rootNode2 = new TreeNode("权限管理");
            rootNode2.ImageIndex = 0;
            rootNode2.SelectedImageIndex = 0;
            treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { rootNode2 });

            //树属性设定
            treeView2.SelectedImageIndex = -1;
            treeView2.Size = new System.Drawing.Size(436, 260);
            treeView2.TabIndex = 0;
            treeView2.Scrollable = false;
            treeView2.ExpandAll();
            this.ResumeLayout(false);//恢复正常的布局逻辑
           
        }
       
        #endregion
*/
        /*
         88888888888888888888888888888888888888888888888888888888888888888888888888888888
  
         GetMenu(treeView1, frmM.menuStrip1);

        //将MenuStrip中的项按照层次加到TreeNode中
        public static void GetMenu(TreeView treeV, MenuStrip menuS)
        {
            //遍历menuStrip中的一级菜单项
            foreach (ToolStripDropDownItem m1 in menuS.Items)
            {
                //循环添加一级菜单
                TreeNode node1 = treeV.Nodes.Add(m1.Text+" "+m1.Name);
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
            88888888888888888888888888888888888888888888888888888888888888888888888888888888
         */

        //打开指定窗口【单击】
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {            
            UtilityLibrary.WinControls.TreeViewEx subItemTmp = (UtilityLibrary.WinControls.TreeViewEx)sender;
            string strTag = e.Node.Tag.ToString();
            if (strTag.Contains(":Role"))
            {
                strTag = strTag.Substring(0, strTag.Length - 5);//strTag的值是“窗口”name+“:Role” 
            }
            PSAPCommon.ViewHandler.ShowRightWindow(strTag);
        }

        private void FrmMainTool_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmOpenFlag = 0;
        }

        private void FrmMainTool_Load(object sender, EventArgs e)
        {
            frmOpenFlag = 1;

        }
    }
}
