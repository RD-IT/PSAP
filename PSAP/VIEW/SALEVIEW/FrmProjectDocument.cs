using DevExpress.XtraTreeList.Nodes;
using PSAP.BLL.SALEBLL;
using PSAP.DAO.SALEDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmProjectDocument : DockContent
    {
        /// <summary>
        /// 本地根目录
        /// </summary>
        public static string rootDir = @"\RongDa Project Documents";

        /// <summary>
        /// Ftp根目录
        /// </summary>
        public static string FtpRootDir = @"RongDa Project Documents";

        /// <summary>
        /// 建立FTP连接
        /// </summary>
        public static FtpOperations ftp = new FtpOperations(@"192.168.0.2", @"", "ftpAdministrator", "a");

        /// <summary>
        /// 本地磁盘
        /// </summary>
        public static string diskLocal = @"d:";//需改成设定值//////

        /// <summary>
        /// 本地根路径
        /// </summary>
        private string rootPathLocal = diskLocal + rootDir;

        /// <summary>
        /// 当前路径
        /// </summary>
        private string curFilePath = "";

        /// <summary>
        /// 当前选中的树节点（目录节点）
        /// </summary>
        private TreeNode curSelectedNode = null;

        /// <summary>
        /// 是否移动文件
        /// </summary>
        private bool isMove = false;

        /// <summary>
        /// 待复制并粘贴的文件\文件夹的源路径
        /// </summary>
        private string[] copyFilesSourcePaths = new string[5000];

        /// <summary>
        /// 用户的历史访问路径的第一个路径节点
        /// </summary>
        public static DoublyLinkedListNode firstPathNode = new DoublyLinkedListNode();

        /// <summary>
        /// 当前路径节点
        /// </summary>
        public static DoublyLinkedListNode curPathNode = new DoublyLinkedListNode();

        /// <summary>
        /// 要搜索的文件名
        /// </summary>
        private string fileName;

        /// <summary>
        /// 是否第一次初始化tvwDirectory
        /// </summary>
        private bool isInitializeTvwDirectory = true;

        /// <summary>
        /// 是否查询状态
        /// </summary>
        public static Boolean isQueryStatus = false;

        /// <summary>
        /// 是否高级搜索状态
        /// </summary>
        public static Boolean advancedQuery = false;

        /// <summary>
        /// 窗口初始化
        /// </summary>
        public FrmProjectDocument()
        {
            InitializeComponent();
            FrmProjectDocumentBLL.intiFtpDir();
            initIlRight();
            //--------------------------------
            InitViewChecks();//初始化相关“查看”选项
            InitDisplay(1);//初始化管理器界面的显示
            tsbtnAdvancedQuery_Click(null, null);//初始化高级搜索选项卡

        }

        /// <summary>
        /// 在新窗口中打开，窗口初始化
        /// </summary>
        public FrmProjectDocument(int projectID)
        {
            InitializeComponent();
            FrmProjectDocumentBLL.intiFtpDir();
            initIlRight();
            //-----------------------------
            InitViewChecks();//初始化相关“查看”选项
            InitDisplay(projectID);//初始化管理器界面的显示
            tsbtnAdvancedQuery_Click(null, null);//初始化高级搜索选项卡

        }

        /// <summary>
        /// 窗口装入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProjectDocument_Load(object sender, EventArgs e)
        {
            //InitViewChecks();//初始化相关“查看”选项
            //InitDisplay();//初始化管理器界面的显示
            //tsbtnAdvancedQuery_Click(null, null);//初始化高级搜索选项卡
        }

        /// <summary>
        /// 初始化图象列表控件
        /// </summary>
        public void initIlRight()
        {
            FtpOperations ftp = new FtpOperations(@"192.168.0.2", @"", "ftpAdministrator", "a");//建立FTP连接
            //ftp.GotoDirectory(@"\RongDa Project Documents\img", false);
            ftp.GotoDirectory(@"\" + FrmProjectDocument.FtpRootDir + @"\img", false);
            string[] filesIco = ftp.GetFileList("");
            if (filesIco != null)
            {
                foreach (string file in filesIco)
                {
                    if (file != "")
                    {
                        if (Path.GetExtension(file) == ".ico")
                        {
                            if (!File.Exists(Application.StartupPath + @"\img\" + Path.GetFileNameWithoutExtension(file) + ".ico"))
                            {
                                ftp.Download(Application.StartupPath + @"\img\", Path.GetFileNameWithoutExtension(file) + ".ico");
                            }

                            if (!ilRight.Images.ContainsKey(Path.GetFileNameWithoutExtension(file)))
                            {
                                Icon ico = new Icon(Application.StartupPath + @"\img\" + Path.GetFileNameWithoutExtension(file) + ".ico");
                                ilRight.Images.Add(Path.GetFileNameWithoutExtension(file), ico);
                            }
                        }
                        else if (Path.GetExtension(file) == ".png")
                        {
                            if (!File.Exists(Application.StartupPath + @"\img\" + Path.GetFileNameWithoutExtension(file) + ".png"))
                            {
                                ftp.Download(Application.StartupPath + @"\img\", Path.GetFileNameWithoutExtension(file) + ".png");
                            }

                            if (!ilRight.Images.ContainsKey(Path.GetFileNameWithoutExtension(file)))
                            {
                                ilRight.Images.Add(Path.GetFileNameWithoutExtension(file), Image.FromFile(Application.StartupPath + @"\img\" + Path.GetFileName(file)));
                            }

                        }
                    }
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //窗体大小改变时，地址栏长度也随之改变
            tscboAddress.Width = this.Width - 290;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            //窗体大小改变时，地址栏长度也随之改变
            tscboAddress.Width = this.Width - 290;
        }

        private void tsmiNewFolder_Click(object sender, EventArgs e)
        {
            //新建文件夹
            string newDirName = CreateFolderLocal();
            ////刷新文件列表
            //ShowFilesList(curPathNode.iProjectID, false, curPathNode.Path);
            //刷新文件列表
            tsmiRefresh_Click(null, null);
            int index = FrmProjectDocumentBLL.FindRowIndex(lvwFiles, newDirName, 0);
            lvwFiles.Items[index].Selected = true;
            lvwFiles.Items[index].EnsureVisible(); //确保可见
            lvwFiles.Items[index].BeginEdit();
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            //复制文件
            CopyFiles();
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            //粘贴文件
            PasteFiles();
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            //剪切文件
            CutFiles();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            //删除文件
            FrmProjectDocumentBLL.DeleteVirtual(lvwFiles);
            //刷新文件列表
            tsmiRefresh_Click(null, null);
            tsslblFilesNum.Text = "已成功删除所选项目";
            this.Cursor = Cursors.Arrow;
        }

        private void tsmiToolbar_Click(object sender, EventArgs e)
        {
            //设置工具栏是否可见
            tsMain.Visible = !tsMain.Visible;
            if (tsMain.Visible == false)
            {
                tableLayoutPanel1.RowStyles[0].Height = tableLayoutPanel1.RowStyles[0].Height - tsmiAddToFtp.Height;
            }
            else
            {
                tableLayoutPanel1.RowStyles[0].Height = tableLayoutPanel1.RowStyles[0].Height + tsmiAddToFtp.Height;
            }
            tsmiToolbar.Checked = !tsmiToolbar.Checked;
        }

        private void tsmiStatusbar_Click(object sender, EventArgs e)
        {
            //设置状态栏是否可见
            ssFooter.Visible = !ssFooter.Visible;
            tsmiStatusbar.Checked = !tsmiStatusbar.Checked;
            if (tableLayoutPanel2.RowStyles[1].Height == 0)
            {
                tableLayoutPanel2.RowStyles[1].Height = 30;
            }
            else
            {
                tableLayoutPanel2.RowStyles[1].Height = 0;
            }
        }

        private void tsmiBigIcon_Click(object sender, EventArgs e)
        {
            ResetViewChecks();
            tsmiBigIcon.Checked = true;
            tsmiBigIcon1.Checked = true;
            lvwFiles.View = View.LargeIcon;
            ilRight.ImageSize = new System.Drawing.Size(48, 48);//改变图标大小
            ilRight.Images.Clear();
            initIlRight();
            tsmiRefresh_Click(null, null);
        }

        private void tsmiSmallIcon_Click(object sender, EventArgs e)
        {
            ResetViewChecks();
            tsmiSmallIcon.Checked = true;
            tsmiSmallIcon1.Checked = true;
            lvwFiles.View = View.SmallIcon;
            ilRight.ImageSize = new System.Drawing.Size(32, 32);//改变图标大小
            ilRight.Images.Clear();
            initIlRight();
            tsmiRefresh_Click(null, null);
        }

        private void tsmiList_Click(object sender, EventArgs e)
        {
            ResetViewChecks();
            tsmiList.Checked = true;
            tsmiList1.Checked = true;
            lvwFiles.View = View.List;
            ilRight.ImageSize = new System.Drawing.Size(16, 16);//改变图标大小
            ilRight.Images.Clear();
            initIlRight();
            tsmiRefresh_Click(null, null);
        }

        private void tsmiDetailedInfo_Click(object sender, EventArgs e)
        {
            ResetViewChecks();
            tsmiDetailedInfo.Checked = true;
            tsmiDetailedInfo1.Checked = true;
            lvwFiles.View = View.Details;
            ilRight.ImageSize = new System.Drawing.Size(16, 16);//改变图标大小
            ilRight.Images.Clear();
            initIlRight();
            //刷新listView
            tsmiRefresh_Click(null, null);
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRefresh_Click(object sender, EventArgs e)
        {
            //if (isQueryStatus == false)
            if (curPathNode.isQueryStatus == 0)//不是查询状态
            {
                ShowFilesList(curPathNode.iProjectID, false, curPathNode.Path);//刷新右侧窗口
            }
            else
            {
                if (curPathNode.isQueryStatus == 1)//简单查询状态
                {
                    ShowQueryFilesList(curPathNode.queryString, curPathNode.Path, false, curPathNode.iProjectID);
                }

                if (curPathNode.isQueryStatus == 2)//高级查询状态
                {
                    ShowQueryFilesList(curPathNode.queryString, curPathNode.Path, false, curPathNode.iProjectID);
                }

            }
        }

        private void tsmiMonitor_Click(object sender, EventArgs e)
        {
            // FrmFileMonitor monitorForm = new FrmFileMonitor();
            // monitorForm.Show();
        }

        //后退(注意：在后退和前进的逻辑中，不创建新的路径节点，而是基于已有的路径节点引用）
        private void tsbtnBack_Click(object sender, EventArgs e)
        {
            if (curPathNode.PreNode.iProjectID != 0)
            {
                curPathNode = curPathNode.PreNode;
                int preProjectID = curPathNode.iProjectID;
                tscboAddress.Text = curPathNode.Path;
                //ShowFilesList(preProjectID, false, curPathNode.Path);
                //刷新文件列表
                tsmiRefresh_Click(null, null);


                //前进按钮可用
                tsbtnAdvance.Enabled = true;
            }
            else
            {
                //ShowQueryFilesList("", curPathNode.Path, false);///////
                //后退按钮不可用
                tsbtnBack.Enabled = false;
            }
        }

        //前进
        private void tsbtnAdvance_Click(object sender, EventArgs e)
        {
            if (curPathNode.NextNode != null)
            {
                curPathNode = curPathNode.NextNode;
                int nextProjectID = curPathNode.iProjectID;
                tscboAddress.Text = curPathNode.Path;
                //ShowFilesList(nextProjectID, false, "");
                //刷新文件列表
                tsmiRefresh_Click(null, null);


                //后退按钮可用
                tsbtnBack.Enabled = true;
            }
            else
            {
                //前进按钮不可用
                tsbtnAdvance.Enabled = false;
            }
        }

        /// <summary>
        /// 刷新前进和后退按钮状态
        /// </summary>
        private void RefreshBackAdvanceButtonEnable()
        {
            if (curPathNode.PreNode.iProjectID == 0)
            {
                //后退按钮不可用
                tsbtnBack.Enabled = false;
            }

            if (curPathNode.NextNode == null)
            {
                //前进按钮不可用
                tsbtnAdvance.Enabled = false;
            }
        }

        private void tscboAddress_KeyDown(object sender, KeyEventArgs e)
        {
            //回车输入新地址
            if (e.KeyCode == Keys.Enter)
            {
                string newPath = tscboAddress.Text;

                if (newPath == "")
                {
                    return;
                }
                else if (!Directory.Exists(newPath))
                {
                    return;
                }
                //ShowFilesList(newPath, true);
            }
        }

        private void tscboSearch_Enter(object sender, EventArgs e)
        {
            tsTxtQuery.Text = "";
        }

        private void tscboSearch_Leave(object sender, EventArgs e)
        {
            tsTxtQuery.Text = "快速搜索";
        }

        private void tscboSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //回车输入文件名
            if (e.KeyCode == Keys.Enter)
            {
                string fileName = tsTxtQuery.Text;

                if (string.IsNullOrEmpty(fileName))
                {
                    return;
                }

                //使用多线程搜索文件/文件夹
                SearchWithMultiThread(curFilePath, fileName);
            }
        }

        //上下文菜单打开时
        private void cmsMain_Opening(object sender, CancelEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmProjectDocumentBLL.MenuEnableForFiles(cmsMain, lvwFiles, tsControl);
            if (lvwFiles.SelectedItems.Count > 0)
            {
                if (lvwFiles.SelectedItems[0].SubItems[4].Text == "file")
                {
                    initVersionMenu(Convert.ToInt32(lvwFiles.SelectedItems[0].SubItems[9].Text));
                }
            }
            this.Cursor = Cursors.Arrow;
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            if (lvwFiles.SelectedItems.Count > 0)
            {
                lvwFiles_ItemActivate(null, null);
            }
            else
            {
                MessageBox.Show("请先选择要打开的文件或文件夹？", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmiRename_Click(object sender, EventArgs e)
        {
            //文件重命名
            RenameFile();
        }

        /// <summary>
        /// 更改文件名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvwFiles_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            //string extensionName;
            //string tmpFileName;
            //tmpFileName = Path.GetFileNameWithoutExtension(e.Label);
            //extensionName = Path.GetExtension(e.Label);
            string oldPath = @rootPathLocal + (string.IsNullOrEmpty(@curPathNode.Path) ? @"\" : @curPathNode.Path) + lvwFiles.SelectedItems[0].SubItems[0].Text.Trim();
            string newName = e.Label;
            newName =!string.IsNullOrEmpty( newName) ? newName.Trim():null;
            ListViewItem selectedItem = lvwFiles.SelectedItems[0];  //选中项
            int documentID, projectID;
            //如果名称为空
            if (string.IsNullOrEmpty(e.Label))
            {
                e.CancelEdit = true;//显示时，恢复原来的标签
                return;
            }

            //标签没有改动
            if (string.IsNullOrEmpty( newName))
            {
                e.CancelEdit = true;//显示时，恢复原来的标签
                return;
            }
            //标签改动了，但是最终还是和原来一样
            else if (newName == selectedItem.Text.Trim())
            {
                return;
            }

            //文件名不合法
            else if (!IsValidFileName(newName))
            {
                MessageBox.Show("文件名不能包含下列任何字符:\r\n" + "\t\\/:*?\"<>|", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.CancelEdit = true;  //显示时，恢复原来的标签
            }
            else
            {
                //如果是文件
                if (selectedItem.SubItems[4].Text == "file")
                {
                    //如果当前路径下有同名的文件
                    if (File.Exists(Path.Combine(curFilePath, newName)))
                    {
                        MessageBox.Show("当前路径下有同名的文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //显示时，恢复原来的标签
                        e.CancelEdit = true;
                    }
                    else
                    {
                        documentID = Convert.ToInt32(selectedItem.Tag);
                        FrmProjectDocumentDAO.RenameToDbAndXml(newName, documentID, "file", "");
                        if (File.Exists(oldPath))
                        {
                            FileInfo f = new FileInfo(oldPath);
                            f.MoveTo(Path.Combine(f.Directory.FullName, newName));
                        }
                        selectedItem.Text = newName;
                    }
                }
                //如果是文件夹
                else if (selectedItem.SubItems[4].Text == "folder")
                {
                    //如果当前路径下有同名的文件夹
                    if (Directory.Exists(Path.Combine(curFilePath, newName)))
                    {
                        MessageBox.Show("当前路径下有同名的文件夹！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //显示时，恢复原来的标签
                        e.CancelEdit = true;
                    }
                    else
                    {
                        //更新文件夹名
                        projectID = Convert.ToInt32(selectedItem.Tag);
                        string newPath = (string.IsNullOrEmpty(@curPathNode.Path) ? @"\" : @curPathNode.Path) + newName + @"\";
                        FrmProjectDocumentDAO.RenameToDbAndXml(newName, projectID, "folder", newPath);
                        if (Directory.Exists(oldPath))
                        {
                            DirectoryInfo f = new DirectoryInfo(oldPath);
                            f.MoveTo(Path.Combine(f.Parent.FullName, newName));
                        }

                        selectedItem.Text = newName;
                        lvwFiles.SelectedItems[0].SubItems[3].Tag = newPath;
                    }
                }
            }
        }

        //激活某项事件(默认激活动作是“双击”)
        private void lvwFiles_ItemActivate(object sender, EventArgs e)
        {
            if (lvwFiles.SelectedItems.Count > 0)
            {
                //更新地址栏
                if (lvwFiles.SelectedItems[0].SubItems[3].Tag != null)
                {
                    tscboAddress.Text = lvwFiles.SelectedItems[0].SubItems[3].Tag.ToString();
                }
                OpenVirtual(tscboAddress.Text, 0);//0：代表不考虑版本，直接打开最高版本
            }
        }


        //TreeView有个默认获取焦点的过程,默认选择最顶端的节点，即索引等于0,也就是“最近访问”节点。此时会调用
        //该函数，导致右边文件列表视图为“最近访问”的文件列表视图。
        private void tvwDirectory_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //第一次初始化tvwDirectory
            if (isInitializeTvwDirectory)
            {
                //curFilePath = @"最近访问";
                //tscboAddress.Text = curFilePath;

                ////保存用户的历史路径的第一个路径
                //firstPathNode.iProjectID = 1;
                //firstPathNode.Path = "";
                //curPathNode = firstPathNode;
                //curSelectedNode =null;// e.Node;

                //ShowFilesList(1, true,"");

                //isInitializeTvwDirectory = false;
            }
            else
            {
                //curSelectedNode = e.Node;
                // ShowFilesList(Convert.ToInt32(e.Node.Tag), true, "");
            }

        }

        private void tvwDirectory_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            //在被选中节点展开前，加载被选中节点的子节点
            LoadChildNodes(e.Node);
        }

        private void tvwDirectory_AfterExpand(object sender, TreeViewEventArgs e)
        {
            //在被选中节点展开后，展开该节点
            e.Node.Expand();
        }

        //双向链表节点类(用来存储用户的历史访问路径)
        public class DoublyLinkedListNode
        {
            //保存的路径
            public int iProjectID { set; get; }
            public string Path { set; get; }
            public DoublyLinkedListNode PreNode { set; get; }
            public DoublyLinkedListNode NextNode { set; get; }
            public int isQueryStatus { set; get; }//0：非查询；1：查询；2：高级查询
            public string queryString { set; get; }

        }



        ////初始化管理器界面的显示（初始化左窗体的驱动器树形视图和右窗体的文件列表视图）
        private void InitDisplay(int projectID)
        {
            //    tvwDirectory.Nodes.Clear();

            //    TreeNode recentFilesNode = tvwDirectory.Nodes.Add("最近访问");
            //    recentFilesNode.Tag = "最近访问";
            //    //获取Recent路径
            //    var recentFolder = Environment.GetFolderPath(Environment.SpecialFolder.Recent);
            //    if (!ilRight.Images.ContainsKey("recent"))////
            //    {
            //        Icon fileIcon = IconHelper.GetIcon(recentFolder);
            //        //因为类型（除了exe）相同的文件，图标相同，所以可以按拓展名存取图标
            //        ilRight.Images.Add("recent", fileIcon);
            //    }

            //    recentFilesNode.ImageKey = "recent";
            //    recentFilesNode.SelectedImageKey = "recent";


            //    DriveInfo[] driveInfos = DriveInfo.GetDrives();

            //    foreach (DriveInfo info in driveInfos)
            //    {
            //        TreeNode driveNode = null;

            //        switch (info.DriveType)
            //        {

            //            //固定磁盘
            //            case DriveType.Fixed:

            //                //显示的名称
            //                string sVolumeLable = !string.IsNullOrEmpty(info.VolumeLabel) ? info.VolumeLabel : "本地磁盘";
            //                driveNode = tvwDirectory.Nodes.Add(sVolumeLable + "(" + info.Name.Split('\\')[0] + ")");

            //                //真正的路径
            //                driveNode.Tag = info.Name;
            //                if (!ilRight.Images.ContainsKey("fixed"))////
            //                {
            //                    Icon fileIcon = IconHelper.GetIcon(info.Name);
            //                    //因为类型（除了exe）相同的文件，图标相同，所以可以按拓展名存取图标
            //                    ilRight.Images.Add("fixed", fileIcon);
            //                }
            //                driveNode.ImageKey = "fixed";
            //                driveNode.SelectedImageKey = "fixed";
            //                break;

            //            //光驱
            //            case DriveType.CDRom:

            //                //显示的名称
            //                driveNode = tvwDirectory.Nodes.Add("光驱(" + info.Name.Split('\\')[0] + ")");

            //                //真正的路径
            //                driveNode.Tag = info.Name;
            //                if (!ilRight.Images.ContainsKey("cdRom"))////
            //                {
            //                    Icon fileIcon = IconHelper.GetIcon(info.Name);
            //                    //因为类型（除了exe）相同的文件，图标相同，所以可以按拓展名存取图标
            //                    ilRight.Images.Add("cdRom", fileIcon);
            //                }
            //                driveNode.ImageKey = "cdRom";
            //                driveNode.SelectedImageKey = "cdRom";

            //                break;

            //            //可移动磁盘
            //            case DriveType.Removable:

            //                //显示的名称
            //                driveNode = tvwDirectory.Nodes.Add("可移动磁盘(" + info.Name.Split('\\')[0] + ")");
            //                //真正的路径
            //                driveNode.Tag = info.Name;
            //                if (!ilRight.Images.ContainsKey("removable"))////
            //                {
            //                    Icon fileIcon = IconHelper.GetIcon(info.Name);
            //                    //因为类型（除了exe）相同的文件，图标相同，所以可以按拓展名存取图标
            //                    ilRight.Images.Add("removable", fileIcon);
            //                }
            //                driveNode.ImageKey = "removable";
            //                driveNode.SelectedImageKey = "removable";
            //                break;
            //        }
            //    }

            //    //加载每个磁盘下的子目录
            //    foreach (TreeNode node in tvwDirectory.Nodes)
            //    {
            //        LoadChildNodes(node);
            //    }


            //    //其中，右窗体的文件列表视图的显示其实在初始化tvwDirectory时已经默认调用了它的
            //    //tvwDirectory_AfterSelect函数，不必在这里写多余的代码
            Icon fileIcon = IconHelper.GetIcon(Application.StartupPath);
            ilOther.Images.Add("folder", fileIcon);//用于查询下拉树显示文件夹图标
            ShowFilesList(projectID, true, "");
        }



        //加载子节点（加载当前目录下的子目录）
        private void LoadChildNodes(TreeNode node)
        {
            try
            {
                //清除空节点，然后才加载子节点
                node.Nodes.Clear();

                if (node.Tag.ToString() == "最近访问")
                {
                    return;
                }
                else
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(node.Tag.ToString());
                    //if (curFilePath == "")//国；；l
                    //{
                    //    return;
                    //}
                    DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();
                    foreach (DirectoryInfo info in directoryInfos)
                    {
                        //显示的名称
                        TreeNode childNode = node.Nodes.Add(info.Name);

                        //真正的路径
                        childNode.Tag = info.FullName;
                        childNode.ImageKey = "folder";
                        childNode.SelectedImageKey = "folder";

                        //加载空节点，以实现“+”号
                        childNode.Nodes.Add("");
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region  在listView中显示文件和文件夹

        /// <summary>
        /// 在右窗体中显示指定路径下的所有文件/文件夹
        /// </summary>
        /// <param name="iProjectID">项目ID</param>
        /// <param name="isRecord">是否记录</param>
        /// <param name="sPath">路径</param>
        public void ShowFilesList(int iProjectID, bool isRecord, string sPath)
        {
            //查询状态
            isQueryStatus = false;

            //后退按钮可用
            tsbtnBack.Enabled = true;

            //需要保存记录，则需要创建新的路径节点
            if (isRecord)
            {
                //保存用户的历史访问路径
                DoublyLinkedListNode newNode = new DoublyLinkedListNode();
                newNode.iProjectID = iProjectID;
                newNode.Path = sPath;
                newNode.isQueryStatus = 0;
                curPathNode.NextNode = newNode;
                newNode.PreNode = curPathNode;
                curPathNode = newNode;
            }
            //开始数据更新
            lvwFiles.BeginUpdate();

            //清空lvwFiles
            lvwFiles.Items.Clear();

            try
            {
                DataTable dt = FrmProjectDocumentDAO.GetProjectDir(iProjectID);
                //列出所有文件夹
                string destPathLocal;
                foreach (DataRow dr in dt.Rows)
                {
                    //右侧对应图象列表控件
                    if (!ilRight.Images.ContainsKey("folder"))////
                    {
                        Icon fileIcon = IconHelper.GetIcon(Application.StartupPath);
                        ilRight.Images.Add("folder", fileIcon);
                    }

                    //右侧对应图象列表控件
                    if (!ilRight.Images.ContainsKey("folder_p"))////
                    {
                        ilRight.Images.Add("folder_p", Image.FromFile(Application.StartupPath + @"\img\folder_p.png"));
                    }

                    ListViewItem item = null;
                    if (Convert.ToInt32(dr["folderType"]) == 1)//1:文件夹  3：项目（含项目信息）
                    {
                        item = lvwFiles.Items.Add(dr["name"].ToString(), "folder");//名称
                    }

                    if (Convert.ToInt32(dr["folderType"]) == 3)//1:文件夹  3：项目（含项目信息）
                    {
                        item = lvwFiles.Items.Add(dr["name"].ToString(), "folder_p");//名称
                    }

                    item.Tag = dr["ChildProject"].ToString();
                    item.SubItems.Add("");//修改日期
                    item.SubItems.Add("文件夹");//类型
                    item.SubItems.Add("");//大小
                    item.SubItems[3].Tag = dr["path"].ToString();
                    item.SubItems.Add("folder");//是否文件夹
                    item.SubItems.Add("");//锁定用户
                    item.SubItems.Add("");//锁定域
                    item.SubItems.Add("");//锁定路径
                    item.SubItems.Add("");//添加到库
                    item.SubItems.Add("");//最高版版
                    item.SubItems.Add("");//打开过

                    //建立本地文件夹
                    destPathLocal = rootPathLocal + dr["path"].ToString();
                    if (!Directory.Exists(destPathLocal))
                    {
                        Directory.CreateDirectory(destPathLocal);
                    }
                }
                DataTable dt1 = FrmProjectDocumentDAO.GetDocuments(iProjectID);
                //列出所有文件
                string extension;
                foreach (DataRow dr in dt1.Rows)
                {
                    //如果是隐藏文件,判断权限
                    if (tsbLookHide.Enabled == false)
                    {
                        continue;
                    }

                    ListViewItem item = lvwFiles.Items.Add(dr["FileName"].ToString());//名称
                    if (!string.IsNullOrEmpty(Path.GetExtension(dr["FileName"].ToString())))
                    {
                        extension = Path.GetExtension(dr["FileName"].ToString()).Substring(1);
                    }
                    else
                    {
                        extension = "";
                    }

                    //为exe文件或无拓展名
                    if (extension == "exe" || extension == "" || extension == "lnk")
                    {
                        item.ImageKey = Path.GetFileNameWithoutExtension(dr["FileName"].ToString());

                    }
                    else  //其他文件
                    {
                        item.ImageKey = Path.GetExtension(dr["FileName"].ToString()).Substring(1);
                    }

                    //如果是隐藏文件，改变背景颜色
                    if (Convert.ToBoolean(dr["hidden"]) == true)
                    {
                        item.BackColor = Color.LightGray;
                    }

                    item.Tag = dr["DocumentID"];//DocumentID
                    item.SubItems.Add(dr["fileDate"].ToString());//修改日期1
                    item.SubItems.Add(!string.IsNullOrEmpty(extension) ? extension + "文件" : "未知类型文件");//类型2
                    item.SubItems.Add((FrmProjectDocumentBLL.ShowFileSize(Convert.ToInt64(dr["fileSize"] is DBNull ? 0 : dr["fileSize"])).Split('(')[0]));//文件大小3
                    item.SubItems.Add("file");//是否文件夹4
                    item.SubItems.Add(dr["userID"].ToString());//锁定用户5
                    item.SubItems.Add(dr["lockDomain"].ToString());//锁定域6
                    item.SubItems.Add(dr["lockPath"].ToString());//锁定路径7
                    item.SubItems.Add(dr["defValStored"].ToString());//添加到库8
                    item.SubItems.Add(dr["latestRevisionNo"].ToString());//最高版本9
                    item.SubItems.Add(dr["lockOpened"].ToString());//打开过10

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //更新状态栏
            tsslblFilesNum.Text = lvwFiles.Items.Count + " 个项目";
            //结束数据更新
            lvwFiles.EndUpdate();
            RefreshBackAdvanceButtonEnable();

        }


        //******************************显示查找到的文件和文件夹****************************************
        /// <summary>
        /// 在右窗体中显示找到的所有文件/文件夹
        /// </summary>
        /// <param name="queryString">查询字符串</param>
        /// <param name="sPath">路径</param>
        //public void ShowQueryFilesList(int iProjectID, bool isRecord, string sPath)
        public void ShowQueryFilesList(string queryString, string sPath, bool isRecord, int projectID)
        {
            //查询状态
            isQueryStatus = true;

            //后退按钮可用
            tsbtnBack.Enabled = true;

            //需要保存记录，则需要创建新的路径节点
            if (isRecord)
            {
                //保存用户的历史访问路径
                DoublyLinkedListNode newNode = new DoublyLinkedListNode();
                newNode.iProjectID = projectID;//curPathNode.iProjectID;//190211
                newNode.Path = sPath;
                if (advancedQuery == false)
                {
                    newNode.isQueryStatus = 1;
                }
                else
                {
                    newNode.isQueryStatus = 2;
                }
                newNode.queryString = queryString.Trim();
                curPathNode.NextNode = newNode;
                newNode.PreNode = curPathNode;
                curPathNode = newNode;
            }

            //开始数据更新
            lvwFiles.BeginUpdate();

            //清空lvwFiles
            lvwFiles.Items.Clear();

            try
            {
                DataTable dt = FrmProjectDocumentDAO.QueryCurrentProjects(queryString);
                //列出所有文件夹
                string destPathLocal;
                foreach (DataRow dr in dt.Rows)
                {
                    //右侧对应图象列表控件
                    if (!ilRight.Images.ContainsKey("folder"))
                    {
                        Icon fileIcon = IconHelper.GetIcon(Application.StartupPath);
                        ilRight.Images.Add("folder", fileIcon);
                    }

                    //右侧对应图象列表控件
                    if (!ilRight.Images.ContainsKey("folder_p"))
                    {
                        ilRight.Images.Add("folder_p", Image.FromFile(Application.StartupPath + @"\img\folder_p.png"));
                    }

                    ListViewItem item = null;
                    if (Convert.ToInt32(dr["folderType"]) == 1)//1:文件夹  3：项目（含项目信息）
                    {
                        item = lvwFiles.Items.Add(dr["name"].ToString(), "folder");//名称
                    }

                    if (Convert.ToInt32(dr["folderType"]) == 3)//1:文件夹  3：项目（含项目信息）
                    {
                        item = lvwFiles.Items.Add(dr["name"].ToString(), "folder_p");//名称
                    }

                    item.Tag = dr["ChildProjectID"].ToString();//190211
                    item.SubItems.Add("");//修改日期
                    item.SubItems.Add("文件夹");//类型
                    item.SubItems.Add("");//大小
                    item.SubItems[3].Tag = dr["path"].ToString();
                    item.SubItems.Add("folder");//是否文件夹
                    item.SubItems.Add("");//锁定用户
                    item.SubItems.Add("");//锁定域
                    item.SubItems.Add("");//锁定路径
                    item.SubItems.Add("");//添加到库
                    item.SubItems.Add("");//最高版版
                    item.SubItems.Add("");//打开过

                    //建立本地文件夹
                    destPathLocal = rootPathLocal + dr["path"].ToString();
                    if (!Directory.Exists(destPathLocal))
                    {
                        Directory.CreateDirectory(destPathLocal);
                    }
                }
                DataTable dt1 = FrmProjectDocumentDAO.QueryCurrentDocuments(queryString);
                //列出所有文件
                string extension;
                foreach (DataRow dr in dt1.Rows)
                {
                    //如果是隐藏文件,判断权限
                    if (tsbLookHide.Enabled == false)
                    {
                        continue;
                    }

                    ListViewItem item = lvwFiles.Items.Add(dr["FileName"].ToString());//名称

                    if (!string.IsNullOrEmpty(Path.GetExtension(dr["FileName"].ToString())))
                    {
                        extension = Path.GetExtension(dr["FileName"].ToString()).Substring(1);
                    }
                    else
                    {
                        extension = "";
                    }
                    //为exe文件或无拓展名
                    if (extension == "exe" || extension == "" || extension == "lnk")
                    {
                        item.ImageKey = Path.GetFileNameWithoutExtension(dr["FileName"].ToString());

                    }
                    else  //其他文件
                    {
                        item.ImageKey = Path.GetExtension(dr["FileName"].ToString()).Substring(1);
                    }

                    //如果是隐藏文件，改变背景颜色
                    if (Convert.ToBoolean(dr["hidden"]) == true)
                    {
                        item.BackColor = Color.LightGray;
                    }

                    item.Tag = dr["DocumentID"];//DocumentID
                    item.SubItems.Add(dr["fileDate"].ToString());//修改日期1
                    item.SubItems.Add(!string.IsNullOrEmpty(extension) ? extension + "文件" : "未知类型文件");//类型2
                    item.SubItems.Add((FrmProjectDocumentBLL.ShowFileSize(Convert.ToInt64(dr["fileSize"] is DBNull ? 0 : dr["fileSize"])).Split('(')[0]));//文件大小3
                    item.SubItems.Add("file");//是否文件夹4
                    item.SubItems.Add(dr["userID"].ToString());//锁定用户5
                    item.SubItems.Add(dr["lockDomain"].ToString());//锁定域6
                    item.SubItems.Add(dr["lockPath"].ToString());//锁定路径7
                    item.SubItems.Add(dr["defValStored"].ToString());//添加到库8
                    item.SubItems.Add(dr["latestRevisionNo"].ToString());//最高版本9
                    item.SubItems.Add(dr["lockOpened"].ToString());//打开过10
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //更新状态栏
            tsslblFilesNum.Text = lvwFiles.Items.Count + " 个项目";
            //结束数据更新
            lvwFiles.EndUpdate();
            RefreshBackAdvanceButtonEnable();
        }

        #endregion  在listView中显示文件和文件夹


        //检查文件名是否合法,文件名中不能包含字符\/:*?"<>|
        private bool IsValidFileName(string fileName)
        {
            bool isValid = true;

            //非法字符
            string errChar = "\\/:*?\"<>|";

            for (int i = 0; i < errChar.Length; i++)
            {
                if (fileName.Contains(errChar[i].ToString()))
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

        //新建文件夹
        private string CreateFolderLocal()
        {
            try
            {
                int num = 1;
                string path = @rootPathLocal + (string.IsNullOrEmpty(@curPathNode.Path) ? @"\" : @curPathNode.Path);
                path = Path.Combine(path, "新建文件夹");
                string newFolderPath = path;

                while (Directory.Exists(newFolderPath))
                {
                    newFolderPath = path + "(" + num + ")";
                    num++;
                }
                Directory.CreateDirectory(newFolderPath);
                string newFolderName = "新建文件夹" + (num == 1 ? "" : "(" + (num - 1) + ")");
                string nPath = (string.IsNullOrEmpty(@curPathNode.Path) ? @"\" : @curPathNode.Path) + newFolderName + @"\";
                //向相关数据库加入数据
                FrmProjectDocumentDAO.CreateFolderToSever(newFolderName, nPath, curPathNode.iProjectID);
                return newFolderName;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //打开文件/文件夹
        private void Open()
        {
            if (lvwFiles.SelectedItems.Count > 0)
            {
                string path = lvwFiles.SelectedItems[0].Tag.ToString();

                try
                {
                    //如果选中的是文件夹
                    if (Directory.Exists(path))
                    {
                        //打开文件夹
                        //ShowFilesList(path, true);
                    }
                    //如果选中的是文件
                    else
                    {
                        //打开文件
                        Process.Start(path);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //打开虚拟文件/文件夹
        private void OpenVirtual(string sPath, int assignVersion)
        {
            if (lvwFiles.SelectedItems.Count > 0)
            {
                int iProject = Convert.ToInt32(lvwFiles.SelectedItems[0].Tag);
                try
                {
                    //如果选中的是文件夹
                    if (lvwFiles.SelectedItems[0].SubItems[4].Text == "folder")
                    {
                        ShowFilesList(iProject, true, sPath); //打开文件夹

                        ////在新窗口中打开
                        //FrmProjectDocument f = new FrmProjectDocument(iProject);
                        //f.Show();
                    }
                    else//如果选中的是文件
                    {
                        string fileFullPath = @rootPathLocal + @curPathNode.Path + lvwFiles.SelectedItems[0].Text;
                        //string fileFullPath = @lvwFiles.SelectedItems[0].SubItems[7].Text + @"\" + lvwFiles.SelectedItems[0].Text;//190211
                        if (!File.Exists(fileFullPath) || lvwFiles.SelectedItems[0].SubItems[6].Text != "pc-songxi")//change
                        {
                            FrmProjectDocumentBLL.CacheToLocal(lvwFiles, assignVersion);//将文件缓存到本地
                        }
                        //同一台电脑如一个文件已被一个用户检出，另一个用户使用同一台电脑不允许打开
                        if (Convert.ToInt32(lvwFiles.SelectedItems[0].SubItems[5].Text) != 90 &&
                            lvwFiles.SelectedItems[0].SubItems[6].Text == "pc-songxi")//change
                        {
                            MessageBox.Show("当前电脑已经有用户进行了【检入】操作，其他用户无权打开！如需查看请使用其它电脑！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        //用于设定文件只读属性 
                        FileInfo f = new FileInfo(fileFullPath);

                        //将检出人文件打开动作记入文档表（检入时将升级）
                        if (Convert.ToInt32(lvwFiles.SelectedItems[0].SubItems[5].Text) == 90 &&
                            lvwFiles.SelectedItems[0].SubItems[6].Text == "pc-songxi")//change
                        {
                            int documentID = Convert.ToInt32(lvwFiles.SelectedItems[0].Tag);
                            FrmProjectDocumentDAO.UpdateFileOpenFlag(documentID);
                            //设置文件只读属性（只有检出人在在特定电脑上打才可写，否则都只读）
                            //文件可写
                            f.Attributes = FileAttributes.Archive;
                        }
                        else
                        {
                            //文件只读
                            f.Attributes = FileAttributes.ReadOnly;
                        }

                        Process.Start(fileFullPath); //打开文件
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //复制文件
        private void CopyFiles()
        {
            //获得待复制文件的源路径
            SetCopyFilesSourcePaths();
        }

        //粘贴文件
        private void PasteFiles()
        {
            //没有待粘贴的文件
            if (copyFilesSourcePaths[0] == null)
            {
                return;
            }

            //当前路径无效
            if (!Directory.Exists(curFilePath))
            {
                return;
            }

            if (curFilePath == "最近访问")
            {
                MessageBox.Show("不能在当前路径下进行粘贴操作！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; copyFilesSourcePaths[i] != null; i++)
            {
                //如果是文件
                if (File.Exists(copyFilesSourcePaths[i]))
                {
                    //执行文件的“移动到”或“复制到”
                    MoveToOrCopyToFileBySourcePath(copyFilesSourcePaths[i]);
                }
                //如果是文件夹
                else if (Directory.Exists(copyFilesSourcePaths[i]))
                {
                    //执行文件夹的“移动到”或“复制到”
                    MoveToOrCopyToDirectoryBySourcePath(copyFilesSourcePaths[i]);
                }
            }

            //在右边窗体显示文件列表
            //ShowFilesList(curFilePath, false);

            //刷新左边的目录树
            LoadChildNodes(curSelectedNode);

            //置空
            copyFilesSourcePaths = new string[200];
        }

        //剪切文件
        private void CutFiles()
        {
            //获得待复制文件的源路径
            SetCopyFilesSourcePaths();

            //准备移动
            isMove = true;
        }

        //删除文件
        private void DeleteFiles()
        {
            if (lvwFiles.SelectedItems.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("确定要删除吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                else
                {
                    try
                    {
                        foreach (ListViewItem item in lvwFiles.SelectedItems)
                        {
                            string path = item.Tag.ToString();

                            //如果是文件
                            if (File.Exists(path))
                            {
                                File.Delete(path);
                            }
                            //如果是文件夹
                            else if (Directory.Exists(path))
                            {
                                Directory.Delete(path, true);
                            }

                            lvwFiles.Items.Remove(item);
                        }

                        //刷新左边的目录树
                        LoadChildNodes(curSelectedNode);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //获得待复制文件的源路径
        private void SetCopyFilesSourcePaths()
        {
            if (lvwFiles.SelectedItems.Count > 0)
            {
                int i = 0;

                foreach (ListViewItem item in lvwFiles.SelectedItems)
                {
                    copyFilesSourcePaths[i++] = item.Tag.ToString();
                }
                isMove = false;
            }
        }

        //执行文件的“移动到”或“复制到”
        private void MoveToOrCopyToFileBySourcePath(string sourcePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                //获取目的路径
                string destPath = Path.Combine(curFilePath, fileInfo.Name);

                //如果目的路径和源路径相同，则不执行任何操作
                if (destPath == sourcePath)
                {
                    return;
                }

                //移动文件到目的路径（当前是在执行“剪切+粘贴”操作）
                if (isMove)
                {
                    fileInfo.MoveTo(destPath);
                }
                //粘贴文件到目的路径（当前是在执行“复制+粘贴”操作）
                else
                {
                    fileInfo.CopyTo(destPath);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //通过递归，复制并粘贴文件夹（包含文件夹下的所有文件）
        //没有DirectoryInfo.CopyTo(string path)方法，需要自己实现
        private void CopyAndPasteDirectory(DirectoryInfo sourceDirInfo, DirectoryInfo destDirInfo)
        {
            //判断目标文件夹是否是源文件夹的子目录，是则给出错误提示，不进行任何操作
            for (DirectoryInfo dirInfo = destDirInfo.Parent; dirInfo != null; dirInfo = dirInfo.Parent)
            {
                if (dirInfo.FullName == sourceDirInfo.FullName)
                {
                    MessageBox.Show("无法复制！目标文件夹是源文件夹的子目录！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            //创建目标文件夹
            if (!Directory.Exists(destDirInfo.FullName))
            {
                Directory.CreateDirectory(destDirInfo.FullName);
            }

            //复制文件并将文件粘贴到目标文件夹下
            foreach (FileInfo fileInfo in sourceDirInfo.GetFiles())
            {
                fileInfo.CopyTo(Path.Combine(destDirInfo.FullName, fileInfo.Name));
            }

            //递归复制并将子文件夹粘贴到目标文件夹下
            foreach (DirectoryInfo sourceSubDirInfo in sourceDirInfo.GetDirectories())
            {
                DirectoryInfo destSubDirInfo = destDirInfo.CreateSubdirectory(sourceSubDirInfo.Name);
                CopyAndPasteDirectory(sourceSubDirInfo, destSubDirInfo);
            }

        }

        //执行文件夹的“移动到”或“复制到”
        private void MoveToOrCopyToDirectoryBySourcePath(string sourcePath)
        {
            try
            {
                DirectoryInfo sourceDirectoryInfo = new DirectoryInfo(sourcePath);

                //获取目的路径
                string destPath = Path.Combine(curFilePath, sourceDirectoryInfo.Name);

                //如果目的路径和源路径相同，则不执行任何操作
                if (destPath == sourcePath)
                {
                    return;
                }

                //移动文件夹到目的路径（当前是在执行“剪切+粘贴”操作）
                if (isMove)
                {
                    //若使用sourceDirectoryInfo.MoveTo(destPath)，则不支持跨磁盘移动文件夹

                    //通过递归，复制并粘贴文件夹（包含文件夹下的所有文件）
                    CopyAndPasteDirectory(sourceDirectoryInfo, new DirectoryInfo(destPath));

                    //删除源文件夹
                    Directory.Delete(sourcePath, true);

                }
                //粘贴文件夹到目的路径（当前是在执行“复制+粘贴”操作）
                else
                {
                    //通过递归，复制并粘贴文件夹（包含文件夹下的所有文件）
                    CopyAndPasteDirectory(sourceDirectoryInfo, new DirectoryInfo(destPath));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //重命名文件
        private void RenameFile()
        {
            if (lvwFiles.SelectedItems.Count > 0)
            {
                //模拟进行编辑标签，实质是为了通过代码触发lvwFiles_AfterLabelEdit事件
                lvwFiles.SelectedItems[0].BeginEdit();
            }
            else
            {
                MessageBox.Show("请选择要重命名的文件或文件夹！", "提示", MessageBoxButtons.OK);
            }
        }

        //初始化相关“查看”选项
        private void InitViewChecks()
        {
            //默认右边窗体显示的是详细信息视图
            tsmiDetailedInfo.Checked = true;
            tsmiDetailedInfo1.Checked = true;
        }

        //重置相关“查看”选项
        private void ResetViewChecks()
        {
            tsmiBigIcon.Checked = false;
            tsmiSmallIcon.Checked = false;
            tsmiList.Checked = false;
            tsmiDetailedInfo.Checked = false;
            tsmiBigIcon1.Checked = false;
            tsmiSmallIcon1.Checked = false;
            tsmiList1.Checked = false;
            tsmiDetailedInfo1.Checked = false;
        }

        //使用多线程搜索文件/文件夹
        private void SearchWithMultiThread(string path, string fileName)
        {
            //清空lvwFiles
            lvwFiles.Items.Clear();

            //更新状态栏
            tsslblFilesNum.Text = 0 + " 个项目";

            this.fileName = fileName;

            ThreadPool.SetMaxThreads(1000, 1000);

            //开启一个线程来执行搜索操作
            ThreadPool.QueueUserWorkItem(new WaitCallback(Search), path);

        }



        //多线程搜索文件/文件夹
        public void Search(Object obj)
        {
            string path = obj.ToString();
            DirectorySecurity directorySecurity = new DirectorySecurity(path, AccessControlSections.Access);

            //目录可以访问
            if (!directorySecurity.AreAccessRulesProtected)
            {
                //待搜索路径
                DirectoryInfo directoryInfo = new DirectoryInfo(path);

                //待搜索路径下的文件
                FileInfo[] fileInfos = directoryInfo.GetFiles();

                //搜索文件
                if (fileInfos.Length > 0)
                {
                    foreach (FileInfo fileInfo in fileInfos)
                    {
                        try
                        {
                            if (fileInfo.Name.Split('.')[0].Contains(fileName))
                            {
                                AddSearchResultItemIntoList(fileInfo.FullName, true);
                                //更新状态栏
                                tsslblFilesNum.Text = lvwFiles.Items.Count + " 个项目";
                            }
                        }
                        catch (Exception e)
                        {
                            continue;
                        }
                    }
                }

                //待搜索路径下的子文件夹
                DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();

                //搜索文件夹
                if (directoryInfos.Length > 0)
                {
                    foreach (DirectoryInfo dirInfo in directoryInfos)
                    {
                        try
                        {
                            if (dirInfo.Name.Contains(fileName))
                            {
                                AddSearchResultItemIntoList(dirInfo.FullName, false);

                                //更新状态栏
                                tsslblFilesNum.Text = lvwFiles.Items.Count + " 个项目";
                            }
                            else
                            {
                                //多线程策略一：从待搜索文件夹开始，递归过程中每遇到一个文件夹便为其开一个线程进行递归搜索，线程总数多，但是
                                //使用的是线程池，它会进行自动管理，使得线程可以被反复利用，一个线程的搜索任务执行完成之后，又可以继续被利用去
                                //执行另一个在任务队列中的搜索任务。
                                //优点：可以适应普遍情况，搜索速度一般情况下很快！
                                ThreadPool.QueueUserWorkItem(new WaitCallback(Search), dirInfo.FullName);

                                //多线程策略二：为待搜索文件夹下每个文件夹开一个线程进行递归搜索，此后不再开线程，线程总数等于待搜索文件夹的子文件夹数。
                                //缺点:当待搜索文件夹的子文件夹数越少时，效果越差，速度越慢。
                                //ThreadPool.QueueUserWorkItem(new WaitCallback(SearchWithOneThread), dirInfo.FullName);
                            }
                        }
                        catch (Exception e)
                        {

                        }
                    }
                }
            }
        }

        //使用单个线程搜索单个子文件夹
        public void SearchWithOneThread(object obj)
        {
            string path = obj.ToString();
            DirectorySecurity directorySecurity = new DirectorySecurity(path, AccessControlSections.Access);

            //目录可以访问
            if (!directorySecurity.AreAccessRulesProtected)
            {
                //子文件夹
                DirectoryInfo directoryInfo = new DirectoryInfo(path);

                //子文件夹下的文件
                FileInfo[] fileInfos = directoryInfo.GetFiles();

                //子文件夹下的文件夹
                DirectoryInfo[] directoryInfos = directoryInfo.GetDirectories();

                //搜索文件
                if (fileInfos.Length > 0)
                {
                    foreach (FileInfo fileInfo in fileInfos)
                    {
                        try
                        {
                            if (fileInfo.Name.Split('.')[0].Contains(fileName))
                            {
                                AddSearchResultItemIntoList(fileInfo.FullName, true);

                                //更新状态栏
                                tsslblFilesNum.Text = lvwFiles.Items.Count + " 个项目";
                            }
                        }
                        catch (Exception e)
                        {
                            continue;
                        }
                    }
                }

                //搜索文件夹
                if (directoryInfos.Length > 0)
                {
                    foreach (DirectoryInfo dirInfo in directoryInfos)
                    {
                        try
                        {
                            if (dirInfo.Name.Contains(fileName))
                            {
                                AddSearchResultItemIntoList(dirInfo.FullName, false);

                                //更新状态栏
                                tsslblFilesNum.Text = lvwFiles.Items.Count + " 个项目";
                            }
                            else
                            {
                                SearchWithOneThread(dirInfo.FullName);
                            }
                        }
                        catch (Exception e)
                        {
                            continue;
                        }
                    }
                }
            }
        }

        //将搜索结果显示在文件列表上
        private void AddSearchResultItemIntoList(string fullPath, bool isFile)
        {
            //是文件
            if (isFile)
            {
                FileInfo fileInfo = new FileInfo(fullPath);

                ListViewItem item = lvwFiles.Items.Add(fileInfo.Name);

                //为exe文件或无拓展名
                if (fileInfo.Extension == ".exe" || fileInfo.Extension == "")
                {
                    //通过当前系统获得文件相应图标
                    // Icon fileIcon = GetSystemIcon.GetIconByFileName(fileInfo.FullName);
                    Icon fileIcon = IconHelper.GetIcon(fileInfo.FullName);


                    //因为不同的exe文件一般图标都不相同，所以不能按拓展名存取图标，应按文件名存取图标
                    ilRight.Images.Add(fileInfo.Name, fileIcon);

                    item.ImageKey = fileInfo.Name;
                }
                //其他文件
                else
                {
                    if (!ilRight.Images.ContainsKey(fileInfo.Extension))
                    {
                        //Icon fileIcon = GetSystemIcon.GetIconByFileName(fileInfo.FullName);
                        Icon fileIcon = IconHelper.GetIcon(fileInfo.FullName);

                        //因为类型（除了exe）相同的文件，图标相同，所以可以按拓展名存取图标
                        ilRight.Images.Add(fileInfo.Extension, fileIcon);
                    }

                    item.ImageKey = fileInfo.Extension;
                }

                item.Tag = fileInfo.FullName;

                item.SubItems.Add(fileInfo.LastWriteTimeUtc.ToString());
                item.SubItems.Add(fileInfo.Extension + "文件");
                item.SubItems.Add(FrmProjectDocumentBLL.ShowFileSize(fileInfo.Length).Split('(')[0]);
            }
            //是文件夹
            else
            {
                DirectoryInfo dirInfo = new DirectoryInfo(fullPath);

                //ListViewItem item = lvwFiles.Items.Add(dirInfo.Name, IconsIndexes.Folder);

                if (!ilRight.Images.ContainsKey("folder"))////
                {
                    //Icon fileIcon = GetSystemIcon.GetIconByFileName(fileInfo.FullName);
                    Icon fileIcon = IconHelper.GetIcon(dirInfo.FullName);

                    //因为类型（除了exe）相同的文件，图标相同，所以可以按拓展名存取图标
                    ilRight.Images.Add("folder", fileIcon);
                }

                ListViewItem item = lvwFiles.Items.Add(dirInfo.Name, "folder");

                item.Tag = dirInfo.FullName;
                item.SubItems.Add(dirInfo.LastWriteTimeUtc.ToString());
                item.SubItems.Add("文件夹");
                item.SubItems.Add("");
            }
        }


        /// <summary>
        /// 拖拽进入控件区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvwFiles_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        /// <summary>
        /// 拖拽进入窗口区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProjectDocument_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        /// <summary>
        /// 将文件拖拽到窗口中放下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProjectDocument_DragDrop(object sender, DragEventArgs e)
        {
            lvwFiles_DragDrop(sender, e);
        }

        /// <summary>
        /// 将文件拖拽到控件中放下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvwFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] sCopyFilesSourcePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            string sDestPath = @rootPathLocal + @curPathNode.Path;
            FrmProjectDocumentBLL.CopyToLocal(sCopyFilesSourcePaths, sDestPath, true, false, ilRight);
            //刷新文件列表
            tsmiRefresh_Click(null, null);
            //将新复制的文件/文件夹选中
            lvwFiles.Focus();
            foreach (string newItemName in sCopyFilesSourcePaths)
            {
                int index = FrmProjectDocumentBLL.FindRowIndex(lvwFiles, Path.GetFileName(newItemName), 0);
                if (index != -1)
                {
                    lvwFiles.Items[index].Selected = true;
                    lvwFiles.Items[index].EnsureVisible(); //确保可见
                }
            }
        }

        StringCollection sCopyFilesSourcePathsTmp { get; set; }
        /// <summary>
        /// 将在资源管理器复制的文件粘贴到本地缓存
        /// </summary>
        private void PasteToCache()
        {
            try
            {
                string[] sCopyFilesSourcePaths;
                if (Clipboard.ContainsFileDropList())
                {
                    sCopyFilesSourcePathsTmp = Clipboard.GetFileDropList();
                    sCopyFilesSourcePaths = new string[sCopyFilesSourcePathsTmp.Count];
                    sCopyFilesSourcePathsTmp.CopyTo(sCopyFilesSourcePaths, 0);

                    string sDestPath = @rootPathLocal + @curPathNode.Path;
                    FrmProjectDocumentBLL.CopyToLocal(sCopyFilesSourcePaths, sDestPath, true, false, ilRight);
                    //刷新文件列表
                    tsmiRefresh_Click(null, null);
                    //将新复制的文件/文件夹选中
                    lvwFiles.Focus();
                    foreach (string newItemName in sCopyFilesSourcePaths)
                    {
                        int index = FrmProjectDocumentBLL.FindRowIndex(lvwFiles, Path.GetFileName(newItemName), 0);
                        if (index != -1)
                        {
                            lvwFiles.Items[index].Selected = true;
                            lvwFiles.Items[index].EnsureVisible(); //确保可见
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 添加到库
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAddToFtp_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmProjectDocumentBLL.AddToFtp(lvwFiles);//添加到库
            //刷新文件列表
            //ShowFilesList(curPathNode.iProjectID, false, curPathNode.Path);
            //刷新文件列表
            tsmiRefresh_Click(null, null);
            tsslblFilesNum.Text = "已成功添加到库";
            this.Cursor = Cursors.Arrow;

        }

        /// <summary>
        /// 检入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCheckIn_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmProjectDocumentBLL.CheckIn(lvwFiles);
            //刷新文件列表
            tsmiRefresh_Click(null, null);
            tsslblFilesNum.Text = "已成功检入";
            this.Cursor = Cursors.Arrow;
        }

        /// <summary>
        /// 检出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCheckOut_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            FrmProjectDocumentBLL.CheckOut(lvwFiles);
            //刷新文件列表
            tsmiRefresh_Click(null, null);
            tsslblFilesNum.Text = "已成功检出";
            this.Cursor = Cursors.Arrow;
        }

        /// <summary>
        /// 打开文件菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFile_DropDownOpening(object sender, EventArgs e)
        {
            cmsMain_Opening(null, null);
            tsmiOpen1.Enabled = tsmiOpen.Enabled;
            tsmiNewFolder1.Enabled = tsmiNewFolder1.Enabled;
            tsmiProperties.Enabled = tsmiProperties1.Enabled;
            tsmiSetHide1.Enabled = tsmiSetHide.Enabled;
            tsmiCancelHide1.Enabled = tsmiCancelHide.Enabled;
            tsmiVersion1.Enabled = tsmiVersion.Enabled;

        }

        /// <summary>
        /// 打开编辑菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiEdit_DropDownOpening(object sender, EventArgs e)
        {
            cmsMain_Opening(null, null);
            tsmiRename1.Enabled = tsmiRename.Enabled;
            tsmiDelete.Enabled = tsmiDelete1.Enabled;
            tsmiQuotation1.Enabled = tsmiQuotation.Enabled;
            tsmiCreateQuotation1.Enabled = tsmiCreateQuotation.Enabled;
            tsmiEditQuotation1.Enabled = tsmiEditQuotation.Enabled;
            tsmiCancelQuotation1.Enabled = tsmiCancelQuotation.Enabled;
            tsmiAddToFtp1.Enabled = tsmiAddToFtp.Enabled;
            tsmiCheckIn1.Enabled = tsmiCheckIn.Enabled;
            tsmiCheckOut1.Enabled = tsmiCheckOut.Enabled;
            tsmiPasteToCache1.Enabled = tsmiPasteToCache.Enabled;
        }

        /// <summary>
        /// 生成报价单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCreateQuotation_Click(object sender, EventArgs e)
        {
            FrmProjectDocumentDAO.CreateQuotation(lvwFiles);
            //刷新文件列表
            tsmiRefresh_Click(null, null);
        }

        /// <summary>
        /// 取消报价单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCancelQuotation_Click(object sender, EventArgs e)
        {
            FrmProjectDocumentDAO.CancelQuotation(lvwFiles);
            //刷新文件列表
            tsmiRefresh_Click(null, null);
        }

        /// <summary>
        /// 打开指定版本文件
        /// </summary>
        /// <param name="assignVersion"></param>
        /// <returns></returns>
        public void openAssignVersionFile(int assignVersion)
        {
            if (lvwFiles.SelectedItems.Count > 0)
            {
                //更新地址栏
                if (lvwFiles.SelectedItems[0].SubItems[3].Tag != null)
                {
                    tscboAddress.Text = lvwFiles.SelectedItems[0].SubItems[3].Tag.ToString();
                }
                OpenVirtual(tscboAddress.Text, assignVersion);
            }
            else
            {
                MessageBox.Show("请先选择要打开的文件或文件夹？", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// 初始化版本菜单
        /// </summary>
        /// <param name="lastVersion"></param>
        public void initVersionMenu(int lastVersion)
        {
            tsmiVersion.DropDownItems.Clear();
            tsmiVersion1.DropDownItems.Clear();
            for (int i = 1; i <= lastVersion; i++)
            {
                tsmiVersion.DropDownItems.Add("版本" + i.ToString(), null, VersionMenu);
                tsmiVersion1.DropDownItems.Add("版本" + i.ToString(), null, VersionMenu);
            }
        }

        /// <summary>
        /// 版本菜单单击事件方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void VersionMenu(object sender, EventArgs e)
        {
            string menuText = ((ToolStripMenuItem)sender).Text;
            openAssignVersionFile(Convert.ToInt32(menuText.Substring(menuText.Length - 1)));
        }

        /// <summary>
        /// 将文件设置为隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSetHide_Click(object sender, EventArgs e)
        {
            FrmProjectDocumentBLL.HideF(lvwFiles);
            //刷新文件列表
            tsmiRefresh_Click(null, null);
        }

        /// <summary>
        /// 取消文件的隐藏属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiCancelHide_Click(object sender, EventArgs e)
        {
            FrmProjectDocumentBLL.CancelHideF(lvwFiles);
            //刷新文件列表
            tsmiRefresh_Click(null, null);
        }

        /// <summary>
        /// 单击查询按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnQuery_Click(object sender, EventArgs e)
        {
            advancedQuery = false;
            this.Cursor = Cursors.WaitCursor;
            ShowQueryFilesList(tsTxtQuery.Text.Trim(), "名称包含'" + tsTxtQuery.Text.Trim() + "'的文件和文件夹", true, curPathNode.iProjectID);
            tscboAddress.Text = curPathNode.Path;
            this.Cursor = Cursors.Arrow;
        }

        /// <summary>
        /// 查询文本框获得焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsTxtQuery_Enter(object sender, EventArgs e)
        {
            tsTxtQuery.SelectAll();
        }

        /// <summary>
        /// 单击查询文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsTxtQuery_Click(object sender, EventArgs e)
        {
            tsTxtQuery.SelectAll();
        }

        /// <summary>
        /// 在查询文本框中按回车键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsTxtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tsbtnQuery_Click(null, null);
            }
        }

        /// <summary>
        /// 添加备注信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddRemarks_Click(object sender, EventArgs e)
        {
            if (lvwFiles.SelectedItems.Count > 0)
            {
                FrmAddRemarks f = new FrmAddRemarks(lvwFiles);
                f.ShowDialog();

                if (lvwFiles.SelectedItems.Count > 0)
                {
                    FrmAddRemarksBLL.GetRemarksInfo(dataSet1, lvwFiles.SelectedItems[0]);
                }
            }
            else
            {
                MessageBox.Show("请先选择要添加备注的文件或文件夹？", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            lvwFiles.Focus();
        }

        /// <summary>
        /// 选择项改变
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvwFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwFiles.SelectedItems.Count > 0)
            {
                FrmAddRemarksBLL.GetRemarksInfo(dataSet1, lvwFiles.SelectedItems[0]);
                bsRemarksInfo.MoveLast();
            }
        }

        private void btnSaveRemarks_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(gvRemarks.GetFocusedDataRow()["Remarks"].ToString()))
            {
                MessageBox.Show("【备注信息】不能为空，如不需要备注信息请进行【删除】操作！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Validate();
            bsRemarksInfo.EndEdit();
            FrmProjectDocumentDAO.SaveRemarksInfo(dataSet1);

        }

        private void btnDeleteRemarks_Click(object sender, EventArgs e)
        {
            if (gvRemarks.GetFocusedDataRow() != null)//当前是否有数据
            {
                if (MessageBox.Show("确实要删除吗?", "确认", MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //删除相关数据
                    if (FrmProjectDocumentDAO.DeleteRemarksInfoData(Convert.ToInt32(gvRemarks.GetRowCellValue
                        (gvRemarks.GetSelectedRows()[0], "RemarksID")))) //删除相关数据
                    {
                        gvRemarks.DeleteSelectedRows();
                    }
                }
            }
        }

        /// <summary>
        /// 快捷键设定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmProjectDocument_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.S && e.Control)
            if (lvwFiles.Focused == true)
            {
                //重命名(F2键)
                if (e.KeyCode == Keys.F2)
                {
                    e.Handled = true;       //将Handled设置为true，指示已经处理过KeyDown事件   
                    tsmiRename_Click(null, null);
                }

                //删除（Delete键）
                if (e.KeyCode == Keys.Delete)
                {
                    e.Handled = true;
                    tsmiDelete_Click(null, null);
                }

                //新建文件夹（F3键）
                if (e.KeyCode == Keys.F3)
                {
                    e.Handled = true;
                    tsmiNewFolder_Click(null, null);
                }

                //添加到库（F4）
                if (e.KeyCode == Keys.F4)
                {
                    e.Handled = true;
                    cmsMain_Opening(null, null);
                    if (tsmiAddToFtp.Enabled == true)
                    {
                        tsmiAddToFtp_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("无权限或不需要进行【添加到库】操作！", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //检入（F5）
                if (e.KeyCode == Keys.F5)
                {
                    e.Handled = true;
                    cmsMain_Opening(null, null);
                    if (tsmiCheckIn.Enabled == true)
                    {
                        tsmiCheckIn_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("无权限或不需要进行【检入】操作！", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //检出（F6）
                if (e.KeyCode == Keys.F6)
                {
                    e.Handled = true;
                    cmsMain_Opening(null, null);
                    if (tsmiCheckOut.Enabled == true)
                    {
                        tsmiCheckOut_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("无权限或不需要进行【检出】操作！", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //新建报价单（Ctrl+Q）
                if (e.KeyCode == Keys.Q && e.Modifiers == Keys.Control)
                {
                    e.Handled = true;
                    cmsMain_Opening(null, null);
                    if (tsmiCreateQuotation.Enabled == true)
                    {
                        tsmiCreateQuotation_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("无权限或不需要进行【检出】操作！", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //取消报价单（Ctrl+Alt+Q）
                if (e.KeyCode == Keys.Q && (int)e.Modifiers == (int)Keys.Control + (int)Keys.Alt)
                {
                    e.Handled = true;
                    cmsMain_Opening(null, null);
                    if (tsmiCancelQuotation.Enabled == true)
                    {
                        tsmiCancelQuotation_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("无权限或不需要进行【取消报价单】操作！", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                //隐藏（Ctrl+H）
                if (e.KeyCode == Keys.H && e.Modifiers == Keys.Control)
                {
                    e.Handled = true;
                    tsmiSetHide_Click(null, null);
                }

                //取消隐藏（Ctrl+Alt+H）
                if (e.KeyCode == Keys.H && (int)e.Modifiers == (int)Keys.Control + (int)Keys.Alt)
                {
                    e.Handled = true;
                    tsmiCancelHide_Click(null, null);
                }
            }

            //高级搜索（Ctrl+F）
            if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                tsbtnAdvancedQuery_Click(null, null);
            }

            //粘贴到缓存（Ctrl+V）
            if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control)
            {
                e.Handled = true;
                cmsMain_Opening(null, null);
                if (tsmiPasteToCache.Enabled == true)
                {
                    tsmiPasteToCache_Click(null, null);
                }
                else
                {
                    MessageBox.Show("剪贴板中没有可以粘贴到缓存的文件！", "消息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        /// <summary>
        /// 高级搜索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnAdvancedQuery_Click(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.RowStyles[0].Height < 100)
            {
                tableLayoutPanel1.RowStyles[0].Height = tableLayoutPanel1.RowStyles[0].Height + 138;

            }
            else
            {
                tableLayoutPanel1.RowStyles[0].Height = tableLayoutPanel1.RowStyles[0].Height - 138;
            }
            initTllQueryLocation();
        }

        /// <summary>
        /// 初始化高级搜索下拉树列表
        /// </summary>
        private void initTllQueryLocation()
        {
            //Icon fileIcon = IconHelper.GetIcon(Application.StartupPath);
            //ilOther.Images.Add("folder", fileIcon);
            tllQueryLocation.Properties.TreeList.SelectImageList = ilOther;
            tllQueryLocation.Properties.TreeList.StateImageList = ilOther;

            tllQueryLocation.Properties.TreeList.DataSource = FrmProjectDocumentDAO.GetCompleteProjectTree();
            tllQueryLocation.Properties.TreeList.ParentFieldName = "ProjectID";
            tllQueryLocation.Properties.TreeList.KeyFieldName = "ChildProject";
            tllQueryLocation.Properties.TreeList.RootValue = 1;
            tllQueryLocation.Properties.TreeList.Columns[0].FieldName = "Name";
            tllQueryLocation.Properties.DisplayMember = "Path";
            tllQueryLocation.Properties.ValueMember = "ChildProject";
        }

        /// <summary>
        /// 打开下接列表时关闭所有节点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tllQueryLocation_Properties_Popup(object sender, EventArgs e)
        {
        }

        private void tllQueryLocation_Properties_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// 搜索指定条件文件或文件夹
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            advancedQuery = true;
            this.Cursor = Cursors.WaitCursor;
            ShowQueryFilesList(txtQuery.Text.Trim(), "名称包含'" + txtQuery.Text.Trim() + "'的文件和文件夹", true, Convert.ToInt32(string.IsNullOrEmpty(tllQueryLocation.EditValue.ToString()) ? "1" : tllQueryLocation.EditValue));
            tscboAddress.Text = curPathNode.Path;
            this.Cursor = Cursors.Arrow;

        }

        /// <summary>
        /// 定位到文档根路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnRootPath_Click(object sender, EventArgs e)
        {
            ShowFilesList(1, true, "");
        }

        private void txtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnQuery_Click(null, null);
            }
        }

        /// <summary>
        /// 粘贴到缓存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiPasteToCache_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            PasteToCache();
            //刷新文件列表
            tsmiRefresh_Click(null, null);
            tsslblFilesNum.Text = "已成功将复制的文件加工本地缓存";
            this.Cursor = Cursors.Arrow;
        }
    }
}
