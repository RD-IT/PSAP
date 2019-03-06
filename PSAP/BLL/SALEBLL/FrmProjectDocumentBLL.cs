using PSAP.DAO.BSDAO;
using PSAP.DAO.SALEDAO;
using PSAP.PSAPCommon;
using PSAP.VIEW.BSVIEW;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAP.BLL.SALEBLL
{

    class FrmProjectDocumentBLL
    {
        /// <summary>
        /// 用于多语言文本引用
        /// </summary>
        static PSAP.VIEW.BSVIEW.FrmLanguageBSDAO f = new PSAP.VIEW.BSVIEW.FrmLanguageBSDAO();

        static FrmProjectDocumentBLL()
        {
            PSAP.BLL.BSBLL.BSBLL.language(f);
        }

        //以一定格式显示文件的大小
        //Math.Round(num,2,MidpointRounding.AwayFromZero)，中国式的四舍五入，num保留2位小数
        public static string ShowFileSize(long fileSize)
        {
            string fileSizeStr = "";

            if (fileSize < 1024)
            {
                fileSizeStr = fileSize + " " + f.tsmiZj.Text;
            }
            else if (fileSize >= 1024 && fileSize < 1024 * 1024)
            {
                fileSizeStr = Math.Round(fileSize * 1.0 / 1024, 2, MidpointRounding.AwayFromZero) + " KB(" + fileSize + f.tsmiZj.Text + ")";
            }
            else if (fileSize >= 1024 * 1024 && fileSize < 1024 * 1024 * 1024)
            {
                fileSizeStr = Math.Round(fileSize * 1.0 / (1024 * 1024), 2, MidpointRounding.AwayFromZero) + " MB(" + fileSize + f.tsmiZj.Text + ")";
            }
            else if (fileSize >= 1024 * 1024 * 1024)
            {
                fileSizeStr = Math.Round(fileSize * 1.0 / (1024 * 1024 * 1024), 2, MidpointRounding.AwayFromZero) + " GB(" + fileSize + f.tsmiZj.Text + ")";
            }

            return fileSizeStr;
        }

        /// <summary>
        /// 获得16进制流水号
        /// </summary>
        /// <param name="iLength">流水号长度</param>
        /// <param name="iValue">当前流水号（10进制）</param>
        /// <returns></returns>
        public static string GetSerialNumber16(int iLength, int iValue)
        {
            return Convert.ToString(Convert.ToInt64(iValue), 16).PadLeft(iLength, '0');
        }

        /// <summary>
        /// 初始化FTP文件夹
        /// </summary>
        public static void intiFtpDir()
        {
            try
            {
                if (!FrmProjectDocument.ftp.DirectoryExist(FrmProjectDocument.FtpRootDir))
                {
                    FrmProjectDocument.ftp.MakeDir(FrmProjectDocument.FtpRootDir);
                    FrmProjectDocument.ftp.GotoDirectory(FrmProjectDocument.FtpRootDir, false);
                    FrmProjectDocument.ftp.MakeDir("img");
                    for (int i = 0; i <= 15; i++)
                    {
                        FrmProjectDocument.ftp.MakeDir(GetSerialNumber16(1, i));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //将本地文件复制到本地文件夹//////////////////////////////////////////////
        /// <summary>
        /// 将本地文件复制到本地文件夹
        /// </summary>
        /// <param name="sCopyFilesSourcePaths"></param>
        /// <param name="isDownLoad"></param>
        /// <param name="isOverwrite"></param>
        public static void CopyToLocal(string[] sCopyFilesSourcePaths, string destPathA, bool isDownLoad, Boolean isOverwrite, ImageList ilRight)
        {
            DialogResult dialogResult;
            string destPath;
            if (sCopyFilesSourcePaths.Count() > 0)
            {
                if (isDownLoad == false)//上传
                {
                }

                else//下载//////////////
                {
                    //dialogResult = MessageBox.Show("确定要将选定文件添加到系统缓存？",  f.tsmiTs.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    dialogResult = MessageBox.Show(f.tsmiQdyjxdwjtjdxthc.Text, f.tsmiTs.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                    else//确定下载文件
                    {
                        try
                        {
                            foreach (string path in sCopyFilesSourcePaths)
                            {
                                destPath = "";
                                destPath = Path.Combine(destPathA, Path.GetFileName(path));
                                //如果是文件
                                if (File.Exists(path))
                                {
                                    //将文件下载到目标文件夹
                                    CopyToFileBySourcePath(path, destPath, isDownLoad, isOverwrite, ilRight);
                                }
                                //如果是文件夹
                                else if (Directory.Exists(path))
                                {
                                    //将文件夹下载到目标文件夹
                                    CopyToDirectoryBySourcePath(path, destPath, isDownLoad, isOverwrite, FrmProjectDocument.curPathNode.iProjectID, ilRight);
                                }
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }


        /*
                    //为exe文件或无拓展名
                    if (dr["Extension"].ToString() == ".exe" || dr["Extension"].ToString() == "")
                    {
                        //通过当前系统获得文件相应图标
                        //Icon fileIcon = IconHelper.GetIcon(fileInfo.FullName);

                        //因为不同的exe文件一般图标都不相同，所以不能按拓展名存取图标，应按文件名存取图标
                        //ilRight.Images.Add(fileInfo.Name, fileIcon);

                        //item.ImageKey = dr["Extension"].ToString();得新建表存exe文件的图标文件名及图标文件
                    }
                    else  //其他文件
                    {
                        if (!ilRight.Images.ContainsKey(fileInfo.Extension))
                        {
                            Icon fileIcon = IconHelper.GetIcon(fileInfo.FullName);

                            //因为类型（除了exe）相同的文件，图标相同，所以可以按拓展名存取图标
                            ilRight.Images.Add(fileInfo.Extension, fileIcon);
                        }
                        item.ImageKey = fileInfo.Extension;
    }
    */




        //执行文件的“复制到”
        public static void CopyToFileBySourcePath(string sourcePath, string sDestPath, bool isDownload, Boolean isOverwrite, ImageList ilRight)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //  MessageBox.Show(Path.GetExtension(destPath) + "【】" + Path.GetFileNameWithoutExtension(destPath) + "【】" + Path.GetDirectoryName(destPath));

                //如果目的路径和源路径相同，则不执行任何操作
                if (sDestPath == sourcePath)
                {
                    return;
                }
                DialogResult dialogResult;
                //if (FrmProjectDocument111.onlyAddNewFile)//只传输服务器或本机没有的文件(下载新增/上传新增时)//此判断无意义
                //{
                //    if (!File.Exists(sDestPath))//不存在文件
                //    {
                //        //将新出现的文件图标上传到FTP
                //        if (!FrmProjectDocumentDAO.ExistsFileExtension(fileInfo.Name))
                //        {
                //            createNewIcoFileToFtp(ilRight, fileInfo);
                //        }

                //        //将复制的文档数据同步到数据库////
                //        FrmProjectDocumentDAO.CreateDocmentToLocal(fileInfo.Name, FrmProjectDocument.curPathNode.iProjectID, sDestPath);

                //        fileInfo.CopyTo(sDestPath, isOverwrite);
                //        //记录操作过程
                //        string tmp;
                //        tmp = "新增";
                //        DocumentManagementRecord(fileInfo.FullName, sDestPath, isDownload ? "下载" : "上传", tmp);
                //    }
                //}
                //else//此组判断无意义，直接执行此部分
                //{
                //if (!File.Exists(sDestPath) || isOverwrite)//不存在文件或设定覆盖
                if (!File.Exists(sDestPath))//不存在文件或设定覆盖
                {
                    //将新出现的文件图标上传到FTP
                    if (!FrmProjectDocumentDAO.ExistsFileExtension(fileInfo.Name))
                    {
                        createNewIcoFileToFtp(ilRight, fileInfo);
                    }

                    //将复制的文档数据同步到数据库////
                    FrmProjectDocumentDAO.CreateDocmentToLocal(fileInfo.Name, FrmProjectDocument.curPathNode.iProjectID, sDestPath, fileInfo.Length, fileInfo.LastWriteTime);

                    fileInfo.CopyTo(sDestPath, isOverwrite);

                    //记录操作过程
                    string tmp;
                    if (!File.Exists(sDestPath))
                    {
                        tmp = "新增";
                    }
                    else
                    {
                        tmp = "覆盖";
                    }
                    DocumentManagementRecord(fileInfo.FullName, sDestPath, isDownload ? "下载" : "上传", tmp);
                }
                else
                {
                    dialogResult = MessageBox.Show("文件【" + fileInfo.Name + "】已存在，要覆盖原文件吗？", "文件存在确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.OK)
                    {
                        //将复制的文档数据同步到数据库////
                        //覆盖时暂不记录信息，应是更新部分信息
                        //FrmProjectDocumentDAO.CreateDocmentToSever(fileInfo.Name, FrmProjectDocument.curPathNode.iProjectID);
                        fileInfo.CopyTo(sDestPath, true);
                        //记录操作过程
                        string tmp;
                        tmp = "覆盖";
                        DocumentManagementRecord(fileInfo.FullName, sDestPath, isDownload ? "下载" : "上传", tmp);
                    }
                }
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //将新出现的文件图标上传到FTP
        public static void createNewIcoFileToFtp(ImageList ilRight, FileInfo fileInfo)
        {
            string icoFileName;
            try
            {
                Icon fileIcon;
                //FtpOperations ftp = new FtpOperations(@"192.168.0.2", @"\RongDa Project Documents\img", "ftpAdministrator", "a");//建立FTP连接
                FtpOperations ftp = new FtpOperations(@"192.168.0.2", @"\" + FrmProjectDocument.FtpRootDir + @"\img", "ftpAdministrator", "a");//建立FTP连接
                fileIcon = IconHelper.GetIcon(fileInfo.FullName);
                string fileExtension = (Path.GetExtension(fileInfo.Name));
                if (fileExtension == ".exe" || fileExtension == "" || fileExtension == ".lnk")
                {
                    icoFileName = Path.GetFileNameWithoutExtension(fileInfo.Name);
                    if (!ilRight.Images.ContainsKey(icoFileName))
                    {
                        ilRight.Images.Add(icoFileName, fileIcon);
                    }
                }
                else
                {
                    icoFileName = Path.GetExtension(fileInfo.Name).Substring(1);
                    if (!ilRight.Images.ContainsKey(icoFileName))
                    {
                        ilRight.Images.Add(icoFileName, fileIcon);
                    }
                }
                Stream stream = File.Create(Application.StartupPath + @"\img\" + icoFileName + ".ico");
                fileIcon.Save(stream);
                stream.Close();
                ftp.Upload(Application.StartupPath + @"\img\" + icoFileName + ".ico");
                //将刚刚建立的临时文件删除
                File.Delete(Application.StartupPath + @"\img\" + icoFileName + ".ico");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //执行文件夹的“复制到”
        public static void CopyToDirectoryBySourcePath(string sourcePath, string destPath, bool isDownLoad, Boolean isOverwrite, int destProjectID, ImageList ilRight)
        {
            string nPath;
            try
            {
                DirectoryInfo sourceDirectoryInfo = new DirectoryInfo(sourcePath);

                //如果目的路径和源路径相同，则不执行任何操作
                if (destPath == sourcePath)
                {
                    return;
                }
                //通过递归，复制并粘贴文件夹（包含文件夹下的所有文件）
                ht.Clear();
                nPath = (string.IsNullOrEmpty(@FrmProjectDocument.curPathNode.Path) ? @"\" : @FrmProjectDocument.curPathNode.Path);
                CopyAndPasteDirectory(sourceDirectoryInfo, new DirectoryInfo(destPath), isOverwrite, isDownLoad, destProjectID, nPath, ilRight);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static Hashtable ht = new Hashtable();
        private static Hashtable htPath = new Hashtable();
        //通过递归，复制并粘贴文件夹（包含文件夹下的所有文件）
        public static void CopyAndPasteDirectory(DirectoryInfo sourceDirInfo, DirectoryInfo destDirInfo, Boolean isOverwrite, Boolean isDownload, int destProjectID, string nPath, ImageList ilRight)
        {
            try
            {
                int fileDestProjectID;
                //判断目标文件夹是否是源文件夹的子目录，是则给出错误提示，不进行任何操作
                for (DirectoryInfo dirInfo = destDirInfo.Parent; dirInfo != null; dirInfo = dirInfo.Parent)
                {
                    if (dirInfo.FullName == sourceDirInfo.FullName)
                    {
                        //MessageBox.Show("无法复制，目标文件夹是源文件夹的子目。", f.tsmiCw.Text , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        MessageBox.Show(f.tsmiWffzmbwjjsy.Text, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                //创建目标文件夹
                if (!Directory.Exists(destDirInfo.FullName))
                {
                    if (!ht.Contains(destDirInfo.Parent.FullName))
                    {
                        ht.Add(destDirInfo.Parent.FullName, destProjectID);
                    }

                    //路径//////////
                    if (!htPath.Contains(destDirInfo.Parent.FullName))
                    {
                        htPath.Add(destDirInfo.Parent.FullName, nPath);
                    }

                    if (!htPath.Contains(destDirInfo.FullName))
                    {
                        if (destDirInfo.Parent != null)
                        {
                            htPath.Add(destDirInfo.FullName, htPath[destDirInfo.Parent.FullName] + destDirInfo.Name + @"\");
                        }
                    }
                    //路径//////////////

                    //将复制的文件夹数据同步到数据库
                    destProjectID = Convert.ToInt32(ht[destDirInfo.Parent.FullName]);
                    destProjectID = FrmProjectDocumentDAO.CreateFolderToSever(destDirInfo.Name, htPath[destDirInfo.FullName].ToString(), destProjectID);///

                    if (!ht.Contains(destDirInfo.FullName))
                    {
                        ht.Add(destDirInfo.FullName, destProjectID);
                    }

                    //新建文件夹
                    Directory.CreateDirectory(destDirInfo.FullName);
                }
                else
                {
                    string projectPath = destDirInfo.FullName.Substring(FrmProjectDocument.diskLocal.Length + FrmProjectDocument.rootDir.Length) + @"\";
                    if (FrmProjectDocumentDAO.GetExistsProjectID(projectPath) != -1)
                    {
                        destProjectID = FrmProjectDocumentDAO.GetExistsProjectID(projectPath);
                        if (!ht.Contains(destDirInfo.Parent.FullName))
                        {
                            ht.Add(destDirInfo.Parent.FullName, destProjectID);
                        }

                        //路径//////////
                        if (!htPath.Contains(destDirInfo.Parent.FullName))
                        {
                            htPath.Add(destDirInfo.Parent.FullName, nPath);
                        }

                        if (!htPath.Contains(destDirInfo.FullName))
                        {
                            if (destDirInfo.Parent != null)
                            {
                                htPath.Add(destDirInfo.FullName, htPath[destDirInfo.Parent.FullName] + destDirInfo.Name + @"\");
                            }
                        }
                        if (!ht.Contains(destDirInfo.FullName))
                        {
                            ht.Add(destDirInfo.FullName, destProjectID);
                        }

                    }
                }
                DialogResult dialogResult;
                //复制文件并将文件粘贴到目标文件夹下
                foreach (FileInfo fileInfo in sourceDirInfo.GetFiles())
                {
                    if (!File.Exists(Path.Combine(destDirInfo.FullName, fileInfo.Name)))//文件不存在
                    {
                        //将新出现的文件图标上传到FTP
                        if (!FrmProjectDocumentDAO.ExistsFileExtension(fileInfo.Name))
                        {
                            createNewIcoFileToFtp(ilRight, fileInfo);
                        }

                        //将复制的文档数据同步到数据库
                        fileDestProjectID = Convert.ToInt32(ht[destDirInfo.FullName]);
                        FrmProjectDocumentDAO.CreateDocmentToLocal(fileInfo.Name, fileDestProjectID, FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + @htPath[destDirInfo.FullName].ToString(), fileInfo.Length, fileInfo.LastWriteTime);//190211
                                                                                                                                                                                                                                                    //复制文件
                        fileInfo.CopyTo(Path.Combine(destDirInfo.FullName, fileInfo.Name), isOverwrite);
                        //记录操作过程
                        string tmp;
                        if (!File.Exists(Path.Combine(destDirInfo.FullName, fileInfo.Name)))
                        {
                            tmp = "新增";
                        }
                        else
                        {
                            tmp = "覆盖";
                        }
                        DocumentManagementRecord(fileInfo.FullName, Path.Combine(destDirInfo.FullName, fileInfo.Name), isDownload ? "下载" : "上传", tmp);

                    }
                    else
                    {
                        dialogResult = MessageBox.Show("文件【" + fileInfo.Name + "】已存在，要覆盖原文件吗？", "文件存在确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            //将新出现的文件图标上传到FTP
                            if (!FrmProjectDocumentDAO.ExistsFileExtension(fileInfo.Name))
                            {
                                createNewIcoFileToFtp(ilRight, fileInfo);
                            }

                            //将复制的文档数据同步到数据库(文件存在时不加入数据，最多只更新数据)
                            fileDestProjectID = Convert.ToInt32(ht[destDirInfo.FullName]);//111222mm
                                                                                          //复制文件
                            fileInfo.CopyTo(Path.Combine(destDirInfo.FullName, fileInfo.Name), true);

                            //记录操作过程
                            string tmp;
                            tmp = "覆盖";
                            DocumentManagementRecord(fileInfo.FullName, Path.Combine(destDirInfo.FullName, fileInfo.Name), isDownload ? "下载" : "上传", tmp);
                        }
                    }
                }

                //递归复制并将子文件夹粘贴到目标文件夹下
                foreach (DirectoryInfo sourceSubDirInfo in sourceDirInfo.GetDirectories())
                {
                    DirectoryInfo destSubDirInfo = destDirInfo.CreateSubdirectory(sourceSubDirInfo.Name);

                    //路径////////
                    if (!htPath.Contains(destSubDirInfo.FullName))
                    {
                        {
                            htPath.Add(destSubDirInfo.FullName, htPath[destSubDirInfo.Parent.FullName] + destSubDirInfo.Name + @"\");
                        }
                    }
                    //路径///////

                    //将复制的文件夹数据同步到数据库
                    string projectPath = destSubDirInfo.FullName.Substring(FrmProjectDocument.diskLocal.Length + FrmProjectDocument.rootDir.Length) + @"\";
                    if (FrmProjectDocumentDAO.GetExistsProjectID(projectPath) == -1)//只有数据库中没有记录时才添加
                    {
                        {
                            destProjectID = Convert.ToInt32(ht[destDirInfo.FullName]);
                            destProjectID = FrmProjectDocumentDAO.CreateFolderToSever(destSubDirInfo.Name, htPath[destSubDirInfo.FullName].ToString(), destProjectID);///
                        }
                    }

                    if (!ht.Contains(destSubDirInfo.FullName))
                    {
                        ht.Add(destSubDirInfo.FullName, destProjectID);
                    }
                    CopyAndPasteDirectory(sourceSubDirInfo, destSubDirInfo, isOverwrite, isDownload, destProjectID, Convert.ToString(htPath[destSubDirInfo.FullName]), ilRight);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// 文档管理记录（所有调用暂时保留）
        /// </summary>
        /// <param name="sSourcePath"></param>
        /// <param name="sDestPath"></param>
        /// <param name="sProjectFileProcessCatg"></param>
        /// <param name="sProjectFileCreateCatg"></param>
        public static void DocumentManagementRecord(string sSourcePath, string sDestPath, string sProjectFileProcessCatg, string sProjectFileCreateCatg)
        {
            //MessageBox.Show("me将" + sSourcePath + "【" + sProjectFileProcessCatg + "】到" + sDestPath + "【" + sProjectFileCreateCatg);
        }

        /// <summary>
        /// 删除选择项
        /// </summary>
        /// <param name="lv"></param>
        public static void DeleteSelItem(ListView lv)
        {
            string localPath;
            foreach (ListViewItem lvi in lv.SelectedItems)
            {
                int iProject = Convert.ToInt32(lvi.Tag);
                try
                {
                    //如果是文件夹
                    if (lvi.SubItems[4].Text == "folder")
                    {
                        FrmProjectDocumentDAO.sqlLlist.Clear();
                        FrmProjectDocumentDAO.AddSqlDeleteSelDir(Convert.ToInt32(lvi.Tag));//增加删除SQL语句
                        //循环删除根项目
                        DeleteChildItem(Convert.ToInt32(lvi.Tag));
                        BaseSQL.ExecuteSqlTran(FrmProjectDocumentDAO.sqlLlist);//执行一个选定根文件夹的删除标记操作
                        //所选文件夹本地路径
                        localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(Convert.ToInt32(lvi.Tag));
                        //删除本地文件夹
                        //Directory.Delete(localPath, true);
                        DirectoryInfo dir = new DirectoryInfo(localPath);
                        DeleteFileByDirectory(dir);

                    }
                    else//如果是文件
                    {
                        FrmProjectDocumentDAO.DeleteSelFile(Convert.ToInt32(lvi.Tag));//删除选定文件
                        //所选文件本地路径
                        localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(Convert.ToInt32(FrmProjectDocument.curPathNode.iProjectID));
                        //删除本地文件
                        FileInfo f = new FileInfo(localPath + lvi.Text);
                        //去掉文件的只读属性
                        f.Attributes = FileAttributes.Archive;
                        File.Delete(localPath + lvi.Text);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>     
        ///  用来遍历删除目录下的文件以及该文件夹     
        /// </summary>     
        public static void DeleteFileByDirectory(DirectoryInfo info)
        {
            try
            {
                foreach (DirectoryInfo newInfo in info.GetDirectories())
                {
                    DeleteFileByDirectory(newInfo);
                }
                foreach (FileInfo newInfo in info.GetFiles())
                {
                    newInfo.Attributes = newInfo.Attributes & ~(FileAttributes.Archive | FileAttributes.ReadOnly | FileAttributes.Hidden);
                    newInfo.Delete();
                }
                info.Attributes = info.Attributes & ~(FileAttributes.Archive | FileAttributes.ReadOnly | FileAttributes.Hidden);
                info.Delete();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //遍历子项
        private static void DeleteChildItem(int iProjectID)
        {
            try
            {
                DataTable dt = FrmProjectDocumentDAO.GetDocuments(iProjectID);
                //列出所有文件
                foreach (DataRow dr in dt.Rows)
                {
                    FrmProjectDocumentDAO.AddSqlDeleteSelFile(Convert.ToInt32(dr["DocumentID"]));
                }

                DataTable dt1 = FrmProjectDocumentDAO.GetProjectDir(iProjectID);//获取项目文件夹列表
                foreach (DataRow dr1 in dt1.Rows)
                {
                    if (dr1 != null)
                    {
                        FrmProjectDocumentDAO.AddSqlDeleteSelDir(Convert.ToInt32(dr1["childProject"]));//增加删除SQL语句
                        DeleteChildItem(Convert.ToInt32(dr1["childProject"]));//递归
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 删除虚拟文件或文件夹
        /// </summary>
        /// <param name="lv"></param>
        public static void DeleteVirtual(ListView lv)
        {
            if (lv.SelectedItems.Count > 0)
            {
                DialogResult dialogResult;
                //dialogResult = MessageBox.Show("确定要删除选定项吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                dialogResult = MessageBox.Show(f.tsmiQdyscxdxm.Text, f.tsmiTs.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                DeleteSelItem(lv); //删除选择项
            }
            else
            {
                //MessageBox.Show("请先选择要删除的文件或文件夹？", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(f.tsmiQxxzyscdwjhwjj.Text, f.tsmiTs.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #region **********************添加到库***********************************************
        /// <summary>
        /// 文件或文件夹添加到库
        /// </summary>
        /// <param name="lv"></param>
        public static void AddToFtp(ListView lv)
        {
            if (lv.SelectedItems.Count > 0)
            {
                DialogResult dialogResult;
                //dialogResult = MessageBox.Show("确定要检入选定项吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                dialogResult = MessageBox.Show(f.tsmiQdyjrxdxm.Text, f.tsmiTs.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                AddToFtpSelItem(lv); //将所选项添加入库
            }
            else
            {
                //MessageBox.Show("请先选择要检入的文件或文件夹？", "提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
                MessageBox.Show(f.tsmiQxzyjrdwjhwjj.Text, f.tsmiTs.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 检入选择项
        /// </summary>
        /// <param name="lv"></param>
        public static void AddToFtpSelItem(ListView lv)
        {
            //文件下载到本地进的路径
            //string localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(Convert.ToInt32(FrmProjectDocument.curPathNode.iProjectID));
            string localPath;
            foreach (ListViewItem lvi in lv.SelectedItems)
            {
                //int iProject = Convert.ToInt32(lvi.Tag);
                try
                {
                    //如果是文件夹
                    if (lvi.SubItems[4].Text == "folder")
                    {
                        //遍历子文件夹中的项目
                        //AddToFtpChildItem(Convert.ToInt32(lvi.Tag));

                        //文件下载到本地的路径
                        localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(Convert.ToInt32(lvi.Tag));
                        DataTable dt = FrmProjectDocumentDAO.GetAddToFtp(Convert.ToInt32(lvi.Tag), 90, "pc-songxi");//change

                        //列出所有文件
                        foreach (DataRow dr in dt.Rows)
                        {
                            //调用文件添加入库方法
                            AddToFtpFile(localPath, Convert.ToInt32(dr["DocumentID"]), dr["fileName"].ToString());
                        }
                    }
                    else//如果是文件
                    {
                        localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(Convert.ToInt32(FrmProjectDocument.curPathNode.iProjectID));

                        DataRow dr;
                        dr = FrmProjectDocumentDAO.GetDocumentInfo(Convert.ToInt32(lvi.Tag));
                        //调用文件添加入库方法     //change  【90】
                        if (Convert.ToBoolean(dr["deleted"]) == false
                            && Convert.ToInt32(dr["userID"]) == 90
                            && dr["lockDomain"].ToString() == "pc-songxi"
                            && Convert.ToInt32(dr["defValStored"]) == 0)
                        {
                            AddToFtpFile(localPath, Convert.ToInt32(lvi.Tag), lvi.Text);
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // 1111
        ////遍历检入子文件夹下的文件
        //private static void AddToFtpChildItem(int iProjectID)
        //{
        //    //文件下载到本地的路径
        //    string localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(iProjectID);
        //    DataTable dt = FrmProjectDocumentDAO.GetDocuments(iProjectID);
        //    //列出所有文件
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        //调用文件添加入库方法
        //        AddToFtpFile(localPath, Convert.ToInt32(dr["DocumentID"]), dr["fileName"].ToString());
        //    }

        //    DataTable dt1 = FrmProjectDocumentDAO.GetProjectDir(iProjectID);//获取项目文件夹列表
        //    //遍历所有文件夹
        //    foreach (DataRow dr1 in dt1.Rows)
        //    {
        //        if (dr1 != null)
        //        {
        //            CheckInChildItem(Convert.ToInt32(dr1["childProject"]));//递归
        //        }
        //    }
        //}

        //文件添加入库方法
        private static void AddToFtpFile(string localPath, int documentID, string fileName)
        {
            try
            {
                DialogResult dialogResult;
                string documentDir;
                documentDir = GetSerialNumber16(8, documentID);
                string localFilePath;
                localFilePath = localPath + fileName;

                if (!File.Exists(localFilePath))
                {
                    //MessageBox.Show("本地文件【" + fileName + "】不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(f.tsmiBdwj.Text + "【" + fileName + "】" + f.tsmiBcz.Text, f.tsmiTs.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                FileInfo fileInfo = new FileInfo(localFilePath);
                string xt = FrmProjectDocument.rootDir + @"\" + documentDir.Substring(documentDir.Length - 1, 1);
                FrmProjectDocument.ftp.GotoDirectory(FrmProjectDocument.rootDir + @"\" + documentDir.Substring(documentDir.Length - 1, 1), true);
                if (!FrmProjectDocument.ftp.DirectoryExist(documentDir))//文档号文件夹不存在
                {
                    FrmProjectDocument.ftp.MakeDir(documentDir);
                }

                FrmProjectDocument.ftp.GotoDirectory(xt + @"\" + documentDir, true);
                string ftpFileName;
                ftpFileName = GetSerialNumber16(8, 1) + Path.GetExtension(fileName); //入库时版本总为1

                if (FrmProjectDocument.ftp.FileExist(ftpFileName))//文件存在
                {//此部分正常是用不上的
                 //dialogResult = MessageBox.Show("文件已存在，不需再次添加入库。", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    dialogResult = MessageBox.Show(f.tsmiWjyczbxzctjrk.Text, f.tsmiTs.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        return;
                    }
                }
                else
                {
                    FrmProjectDocument.ftp.Upload(localFilePath);
                    FrmProjectDocument.ftp.ReName(fileName, ftpFileName);
                    //更新【添加到库】状态标记
                    FrmProjectDocumentDAO.UpdateAddToFtpFlag(documentID, fileInfo.Length, fileInfo.LastWriteTime);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion **********************添加到库***********************************************


        #region **********************检入***********************************************
        /// <summary>
        /// 检入文件或文件夹
        /// </summary>
        /// <param name="lv"></param>
        public static void CheckIn(ListView lv)
        {
            if (lv.SelectedItems.Count > 0)
            {
                //DialogResult dialogResult;
                //dialogResult = MessageBox.Show("确定要检入选定项吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                DialogResult dialogResult;
                dialogResult = MessageBox.Show(f.tsmiQdyjrxdxm.Text, f.tsmiTs.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                CheckInSelItem(lv); //检入选择项
            }
            else
            {
                //MessageBox.Show("请先选择要检入的文件或文件夹。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(f.tsmiQxxzyjrdwjhwjj.Text, f.tsmiTs.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 检入选择项
        /// </summary>
        /// <param name="lv"></param>
        public static void CheckInSelItem(ListView lv)
        {
            //文件下载到本地进的路径
            //string localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(Convert.ToInt32(FrmProjectDocument.curPathNode.iProjectID));
            string localPath;

            foreach (ListViewItem lvi in lv.SelectedItems)
            {
                //int iProject = Convert.ToInt32(lvi.Tag);
                try
                {
                    //如果是文件夹
                    if (lvi.SubItems[4].Text == "folder")
                    {
                        ////遍历子文件夹中的项目
                        //CheckInChildItem(Convert.ToInt32(lvi.Tag));

                        //文件下载到本地的路径
                        localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(Convert.ToInt32(lvi.Tag));
                        DataTable dt = FrmProjectDocumentDAO.GetCheckIn(Convert.ToInt32(lvi.Tag), 90, "pc-songxi");//change
                        //列出所有文件
                        foreach (DataRow dr in dt.Rows)
                        {
                            //调用检入文件方法
                            CheckInFile(localPath, Convert.ToInt32(dr["DocumentID"]), dr["fileName"].ToString(), Convert.ToInt32(dr["latestRevisionNo"]), Convert.ToBoolean(dr["lockOpened"]));
                        }

                    }
                    else//如果是文件
                    {
                        localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(Convert.ToInt32(FrmProjectDocument.curPathNode.iProjectID));
                        DataRow dr;
                        dr = FrmProjectDocumentDAO.GetDocumentInfo(Convert.ToInt32(lvi.Tag));
                        //调用检入文件方法     //change
                        if (Convert.ToBoolean(dr["deleted"]) == false
                            && Convert.ToInt32(dr["userID"]) == 90
                            && dr["lockDomain"].ToString() == "pc-songxi"
                            && Convert.ToInt32(dr["defValStored"]) == 1)
                        {
                            CheckInFile(localPath, Convert.ToInt32(lvi.Tag), dr["fileName"].ToString(), Convert.ToInt32(dr["latestRevisionNo"]), Convert.ToBoolean(Convert.ToBoolean(dr["lockOpened"])));
                            //MessageBox.Show(dr["filename"].ToString());
                        }

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        ////遍历检入子文件夹下的文件
        //private static void CheckInChildItem(int iProjectID)
        //{
        //    //文件下载到本地的路径
        //    string localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(iProjectID);
        //    DataTable dt = FrmProjectDocumentDAO.GetDocuments(iProjectID);
        //    //列出所有文件
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        //调用检入文件方法
        //        CheckInFile(localPath, Convert.ToInt32(dr["DocumentID"]), dr["fileName"].ToString());
        //    }

        //    DataTable dt1 = FrmProjectDocumentDAO.GetProjectDir(iProjectID);//获取项目文件夹列表
        //    //遍历所有文件夹
        //    foreach (DataRow dr1 in dt1.Rows)
        //    {
        //        if (dr1 != null)
        //        {
        //            CheckInChildItem(Convert.ToInt32(dr1["childProject"]));//递归
        //        }
        //    }
        //}

        private static void CheckInFile(string localPath, int documentID, string fileName, int latestRevisionNo, bool lockOpened)
        {
            try
            {
                //DialogResult dialogResult;
                string documentDir;
                documentDir = GetSerialNumber16(8, documentID);
                string localFilePath;
                localFilePath = localPath + fileName;

                if (!File.Exists(localFilePath))
                {
                    //MessageBox.Show("本地文件【" + fileName + "】不存在！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(f.tsmiBdwj.Text + "【" + fileName + "】" + f.tsmiBcz.Text, f.tsmiTs.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string xt = FrmProjectDocument.rootDir + @"\" + documentDir.Substring(documentDir.Length - 1, 1);
                FrmProjectDocument.ftp.GotoDirectory(FrmProjectDocument.rootDir + @"\" + documentDir.Substring(documentDir.Length - 1, 1), true);
                if (!FrmProjectDocument.ftp.DirectoryExist(documentDir))//文档号文件夹不存在
                {
                    FrmProjectDocument.ftp.MakeDir(documentDir);
                }

                FrmProjectDocument.ftp.GotoDirectory(xt + @"\" + documentDir, true);
                string ftpFileName;
                ftpFileName = GetSerialNumber16(8, latestRevisionNo + 1) + Path.GetExtension(fileName);
                if (lockOpened == true)
                {
                    FrmProjectDocument.ftp.Upload(localFilePath);
                    FrmProjectDocument.ftp.ReName(fileName, ftpFileName);
                    FileInfo fileInfo = new FileInfo(localFilePath);
                    FrmProjectDocumentDAO.UpdateCheckInRevisionNo(documentID, fileInfo.Length, fileInfo.LastWriteTime, latestRevisionNo + 1);
                }
                //更新【检入】状态标记
                FrmProjectDocumentDAO.UpdateCheckInFlag(documentID);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion **********************检入***********************************************


        #region **********************检出***********************************************
        /// <summary>
        /// 检出文件或文件夹
        /// </summary>
        /// <param name="lv"></param>
        public static void CheckOut(ListView lv)
        {
            if (lv.SelectedItems.Count > 0)
            {
                DialogResult dialogResult;
                //dialogResult = MessageBox.Show("确定要检出选定项吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                dialogResult = MessageBox.Show(f.tsmiQdyjcxdxm.Text, f.tsmiTs.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                CheckOutSelItem(lv); //检出选择项
            }
            else
            {
                //MessageBox.Show("请先选择要检出的文件或文件夹。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(f.tsmiQxxzyjcdwjhwjj.Text , f.tsmiTs.Text , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 检出选择项
        /// </summary>
        /// <param name="lv"></param>
        public static void CheckOutSelItem(ListView lv)
        {
            //文件下载到本地的路径
            //string localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(Convert.ToInt32(FrmProjectDocument.curPathNode.iProjectID));
            string localPath;
            foreach (ListViewItem lvi in lv.SelectedItems)
            {
                //int iProject = Convert.ToInt32(lvi.Tag);
                try
                {
                    //如果是文件夹
                    if (lvi.SubItems[4].Text == "folder")
                    {
                        ////调用检出子文件夹下文件方法
                        //CheckOutChildItem(Convert.ToInt32(lvi.Tag));

                        //文件下载到本地进的路径
                        localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(Convert.ToInt32(lvi.Tag));
                        DataTable dt = FrmProjectDocumentDAO.GetCheckOut(Convert.ToInt32(lvi.Tag));
                        //列出所有文件
                        foreach (DataRow dr in dt.Rows)
                        {
                            //调用检出文件方法
                            CheckOutFile(localPath, Convert.ToInt32(dr["DocumentID"]), dr["fileName"].ToString(), Convert.ToInt32(dr["latestRevisionNo"]));
                        }
                    }
                    else//如果是文件
                    {
                        localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(Convert.ToInt32(FrmProjectDocument.curPathNode.iProjectID));

                        DataRow dr;
                        dr = FrmProjectDocumentDAO.GetDocumentInfo(Convert.ToInt32(lvi.Tag));
                        //调用检入文件方法     //change  【1】需在数据库中设定好
                        if (Convert.ToBoolean(dr["deleted"]) == false
                            && Convert.ToInt32(dr["userID"]) == 1)
                        {
                            //调用检出文件方法
                            CheckOutFile(localPath, Convert.ToInt32(lvi.Tag), dr["fileName"].ToString(), Convert.ToInt32(dr["latestRevisionNo"]));
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        /// <summary>
        /// 检出文件
        /// </summary>
        /// <param name="localPath"></param>
        /// <param name="documentID"></param>
        /// <param name="fileName"></param>
        private static void CheckOutFile(string localPath, int documentID, string fileName, int latestRevisionNo)
        {
            try
            {
                string documentDir;
                documentDir = GetSerialNumber16(8, documentID);
                string localFilePath;
                localFilePath = localPath + fileName;

                string xt = FrmProjectDocument.rootDir + @"\" + documentDir.Substring(documentDir.Length - 1, 1);
                FrmProjectDocument.ftp.GotoDirectory(FrmProjectDocument.rootDir + @"\" + documentDir.Substring(documentDir.Length - 1, 1), true);
                if (FrmProjectDocument.ftp.DirectoryExist(documentDir))//远程文档号文件夹存在
                {

                    FrmProjectDocument.ftp.GotoDirectory(xt + @"\" + documentDir, true);
                }
                else
                {
                    //MessageBox.Show("远程文件夹不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(f.tsmiYcwjjbcz.Text ,f.tsmiTs.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string ftpFileName;
                ftpFileName = GetSerialNumber16(8, latestRevisionNo) + Path.GetExtension(fileName); //第二个参数为版本号

                if (FrmProjectDocument.ftp.FileExist(ftpFileName))//远程文件存在
                {
                    if (!Directory.Exists(localPath))
                    {
                        Directory.CreateDirectory(localPath);
                    }

                    if (File.Exists(localFilePath))
                    {
                        FileInfo f1 = new FileInfo(localFilePath);
                        f1.Attributes = FileAttributes.Archive;
                        File.Delete(localFilePath);
                    }
                    FrmProjectDocument.ftp.Download(localPath, ftpFileName);
                    FileInfo f = new FileInfo(localPath + ftpFileName);
                    f.MoveTo(Path.Combine(f.Directory.FullName, fileName));//改名
                    //更新【检出】状态标记   //change
                    FrmProjectDocumentDAO.UpdateCheckOutFlag(documentID, localPath, 90, "pc-songxi");

                }
                else
                {
                    //MessageBox.Show("远程文件【" + fileName + "】不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(f.tsmiYcwj.Text +"【" + fileName + "】"+f.tsmiBcz.Text , f.tsmiTs.Text , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion *********************检出***********************************************


        #region **********************缓存文件***********************************************
        /// <summary>
        /// 将要打开的且本地没有的文件缓存到本地
        /// </summary>
        /// <param name="lv"></param>
        public static void CacheToLocal(ListView lv, int assignVersion)
        {
            //文件下载到本地的路径
            string localPath = FrmProjectDocument.diskLocal + FrmProjectDocument.rootDir + FrmProjectDocumentDAO.GetProjectLocalPath(Convert.ToInt32(FrmProjectDocument.curPathNode.iProjectID));
            foreach (ListViewItem lvi in lv.SelectedItems)
            {
                try
                {
                    if (assignVersion == 0)
                    {
                        //调用缓存文件方法（未指定版本，直接打开最高版本）
                        CacheFile(localPath, Convert.ToInt32(lvi.Tag), lvi.Text, Convert.ToInt32(lvi.SubItems[9].Text));
                    }
                    else
                    {
                        //调用缓存文件方法（打开指定的版本）
                        CacheFile(localPath, Convert.ToInt32(lvi.Tag), lvi.Text, assignVersion);
                    }

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 缓存文件
        /// </summary>
        /// <param name="localPath"></param>
        /// <param name="documentID"></param>
        /// <param name="fileName"></param>
        /// <param name="assignVersion"></param>
        private static void CacheFile(string localPath, int documentID, string fileName, int assignVersion)
        {
            try
            {
                string documentDir;
                documentDir = GetSerialNumber16(8, documentID);
                string localFilePath;
                localFilePath = localPath + fileName;

                string xt = FrmProjectDocument.rootDir + @"\" + documentDir.Substring(documentDir.Length - 1, 1);
                FrmProjectDocument.ftp.GotoDirectory(FrmProjectDocument.rootDir + @"\" + documentDir.Substring(documentDir.Length - 1, 1), true);
                if (FrmProjectDocument.ftp.DirectoryExist(documentDir))//远程文档号文件夹存在
                {

                    FrmProjectDocument.ftp.GotoDirectory(xt + @"\" + documentDir, true);
                }
                else
                {
                    //MessageBox.Show("远程文件夹不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(f.tsmiYcwjjbcz.Text , f.tsmiTs.Text , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string ftpFileName;
                ftpFileName = GetSerialNumber16(8, assignVersion) + Path.GetExtension(fileName); //第二个参数为版本号

                if (FrmProjectDocument.ftp.FileExist(ftpFileName))//远程文件存在
                {
                    if (!Directory.Exists(localPath))
                    {
                        Directory.CreateDirectory(localPath);
                    }
                    if (File.Exists(localFilePath))
                    {
                        FileInfo f1 = new FileInfo(localFilePath);
                        f1.Attributes = FileAttributes.Archive;
                        File.Delete(localFilePath);
                    }
                    FrmProjectDocument.ftp.Download(localPath, ftpFileName);
                    FileInfo f = new FileInfo(localPath + ftpFileName);
                    f.MoveTo(Path.Combine(f.Directory.FullName, fileName));//改名
                }
                else
                {
                    //MessageBox.Show("远程文件【" + fileName + "】不存在。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show(f.tsmiYcwj.Text+"【" + fileName + "】"+f.tsmiBcz.Text , f.tsmiTs.Text , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion *********************缓存文件***********************************************




        /// <summary>
        /// 根据text获得ListView的Index
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="text"></param>
        /// <param name="columnIndex"></param>
        /// <returns></returns>
        public static int FindRowIndex(ListView lv, string text, int columnIndex)
        {
            foreach (ListViewItem li in lv.Items)
            {
                if (li.SubItems[columnIndex].Text == text)
                {
                    return li.Index;
                }
            }
            return -1;
        }

        #region **********************菜单Enable属性设定（文件状态）********************************
        private static bool checkInFlag = false, checkOutFlag = false, addToFtpFlag = false,
            quotationCreateFlag = false, quotationEditFlag = false, quotationCancelFlag = false, versionFlag = false;
        /// <summary>
        /// 菜单Enable属性设定（文件状态）
        /// </summary>
        /// <param name="lv"></param>
        public static void MenuEnableForFiles(ContextMenuStrip cms, ListView lv, ToolStrip ts)
        {
            if (lv.SelectedItems.Count > 0)
            {
                checkInFlag = false; checkOutFlag = false; addToFtpFlag = false;
                quotationCreateFlag = false; quotationEditFlag = false; quotationCancelFlag = false; versionFlag = false;
                int selCount;
                selCount = lv.SelectedItems.Count;
                //初始化上下文菜单
                cms.Items["tsmiOpen"].Enabled = true;
                cms.Items["tsmiVersion"].Enabled = true;
                cms.Items["tsmiRename"].Enabled = ts.Items["tsbRename"].Enabled;
                cms.Items["tsmiDelete1"].Enabled = ts.Items["tsbDelete"].Enabled;
                cms.Items["tsmiNewFolder1"].Enabled = ts.Items["tsbNewFolder"].Enabled;
                cms.Items["tsmiAddToFtp"].Enabled = ts.Items[0].Enabled;
                cms.Items["tsmiCheckIn"].Enabled = ts.Items[2].Enabled;
                cms.Items["tsmiCheckOut"].Enabled = ts.Items[1].Enabled;
                cms.Items["tsmiProperties1"].Enabled = true;
                cms.Items["tsmiQuotation"].Enabled = true;
                ((ToolStripMenuItem)cms.Items["tsmiProperties1"]).DropDownItems["tsmiSetHide"].Enabled = ts.Items["tsbSetHide"].Enabled;
                ((ToolStripMenuItem)cms.Items["tsmiProperties1"]).DropDownItems["tsmiCancelHide"].Enabled = ts.Items["tsbCancelHide"].Enabled;
                ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCreateQuotation"].Enabled = ts.Items["tsbCreateQuotation"].Enabled;
                ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiEditQuotation"].Enabled = ts.Items["tsbEditQuotation"].Enabled;
                ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCancelQuotation"].Enabled = ts.Items["tsbCancelQuotation"].Enabled;

                //多选时不能编辑报价单
                if (selCount > 1)
                {
                    ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCreateQuotation"].Enabled = false;
                    quotationCreateFlag = true;
                    ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiEditQuotation"].Enabled = false;
                    quotationEditFlag = true;
                    ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCancelQuotation"].Enabled = false;
                    quotationCancelFlag = true;
                }

                MenuEnableSelItem(cms, lv, ts); //

                //报价单菜单
                if (((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCreateQuotation"].Enabled == true
                    || ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiEditQuotation"].Enabled == true
                    || ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCancelQuotation"].Enabled == true)
                {
                    cms.Items["tsmiQuotation"].Enabled = true;
                }
                else
                {
                    cms.Items["tsmiQuotation"].Enabled = false;
                }
            }
            else
            {
                cms.Items["tsmiOpen"].Enabled = false;
                cms.Items["tsmiVersion"].Enabled = false;
                cms.Items["tsmiAddToFtp"].Enabled = false;
                cms.Items["tsmiCheckIn"].Enabled = false;
                cms.Items["tsmiCheckOut"].Enabled = false;
                cms.Items["tsmiRename"].Enabled = false;
                cms.Items["tsmiDelete1"].Enabled = false;
                cms.Items["tsmiProperties1"].Enabled = false;
                cms.Items["tsmiQuotation"].Enabled = false;
                ((ToolStripMenuItem)cms.Items["tsmiProperties1"]).DropDownItems["tsmiSetHide"].Enabled = false;
                ((ToolStripMenuItem)cms.Items["tsmiProperties1"]).DropDownItems["tsmiCancelHide"].Enabled = false;
                ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCreateQuotation"].Enabled = false;
                ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiEditQuotation"].Enabled = false;
                ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCancelQuotation"].Enabled = false;
            }

            //查询状态时，新建文件夹菜单enable=false
            if (FrmProjectDocument.isQueryStatus == true)
            {
                cms.Items["tsmiNewFolder1"].Enabled = false;
            }

            //粘贴到缓存"tsmiPasteToCache"
            if (Clipboard.ContainsFileDropList())
            {
                cms.Items["tsmiPasteToCache"].Enabled = true;
            }
            else
            {
                cms.Items["tsmiPasteToCache"].Enabled = false;
            }
        }

        /// <summary>
        /// 判断选择项
        /// </summary>
        /// <param name="lv"></param>
        public static void MenuEnableSelItem(ContextMenuStrip cms, ListView lv, ToolStrip ts)
        {
            foreach (ListViewItem lvi in lv.SelectedItems)
            {
                try
                {
                    //如果是文件夹
                    if (lvi.SubItems[4].Text == "folder")
                    {
                        MenuEnableChildItem(cms, Convert.ToInt32(lvi.Tag), ts);
                    }
                    else//如果是文件
                    {
                        //报价单(新建、编辑、取消)
                        if (quotationCreateFlag == false)
                        {
                            ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCreateQuotation"].Enabled = false;
                            quotationCreateFlag = true;
                        }
                        if (quotationEditFlag == false)
                        {
                            ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiEditQuotation"].Enabled = false;
                            quotationEditFlag = true;
                        }
                        if (quotationCancelFlag == false)
                        {
                            ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCancelQuotation"].Enabled = false;
                            quotationCancelFlag = true;
                        }

                        //打开版本
                        if (versionFlag == false)
                        {
                            if (Convert.ToInt32(lvi.SubItems[9].Text) != 0 &&
                                lvi.SubItems[6].Text != "pc-songxi" && lv.SelectedItems.Count == 1)//未保存到库的没有版本概念
                            {
                                cms.Items["tsmiVersion"].Enabled = true;
                                versionFlag = true;
                            }
                            else
                            {
                                cms.Items["tsmiVersion"].Enabled = false;
                                versionFlag = true;
                            }
                        }

                        //添加到库   //需将ID等改为从方法获取change
                        if (cms.Items["tsmiAddToFtp"].Enabled == true)
                        {
                            if (addToFtpFlag == false)
                            {
                                if (Convert.ToInt32(lvi.SubItems[5].Text) == 90 &&
                                    lvi.SubItems[6].Text == "pc-songxi" &&
                                    Convert.ToInt32(lvi.SubItems[8].Text) == 0)
                                {
                                    cms.Items["tsmiAddToFtp"].Enabled = true;
                                    addToFtpFlag = true;
                                }
                                else
                                {
                                    cms.Items["tsmiAddToFtp"].Enabled = false;
                                }
                            }
                        }
                        //检入
                        if (cms.Items["tsmiCheckIn"].Enabled == true)
                        {
                            if (checkInFlag == false)
                            {
                                if (Convert.ToInt32(lvi.SubItems[5].Text) == 90 &&
                                    lvi.SubItems[6].Text == "pc-songxi" &&
                                     Convert.ToInt32(lvi.SubItems[8].Text) == 1)
                                {
                                    cms.Items["tsmiCheckIn"].Enabled = true;
                                    checkInFlag = true;
                                }
                                else
                                {
                                    cms.Items["tsmiCheckIn"].Enabled = false;
                                }
                            }
                        }

                        //检出
                        if (cms.Items["tsmiCheckOut"].Enabled == true)
                        {
                            if (checkOutFlag == false)
                            {
                                if (Convert.ToInt32(lvi.SubItems[5].Text) == 1)
                                {
                                    cms.Items["tsmiCheckOut"].Enabled = true;
                                    checkOutFlag = true;
                                }
                                else
                                {
                                    cms.Items["tsmiCheckOut"].Enabled = false;
                                }
                            }
                        }

                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 检测当前项目下所有层级文件菜单Enable状态
        /// </summary>
        /// <param name="iProjectID"></param>
        private static void MenuEnableChildItem(ContextMenuStrip cms, int projectID, ToolStrip ts)
        {
            DataRow dr;
            dr = FrmProjectDocumentDAO.GetProjectInfo(projectID);
            //报价单(建立)
            if (ts.Items["tsbCreateQuotation"].Enabled == true)
            {
                if (quotationCreateFlag == false)
                {
                    if (Convert.ToInt32(dr["folderType"]) == 1)
                    {
                        ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCreateQuotation"].Enabled = true;
                        quotationCreateFlag = true;
                    }
                    else
                    {
                        ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCreateQuotation"].Enabled = false;
                    }
                }

            }

            //报价单(编辑)
            if (ts.Items["tsbEditQuotation"].Enabled == true)
            {
                if (quotationEditFlag == false)
                {
                    if (Convert.ToInt32(dr["folderType"]) == 3)
                    {
                        ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiEditQuotation"].Enabled = true;
                        quotationEditFlag = true;
                    }
                    else
                    {
                        ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiEditQuotation"].Enabled = false;
                    }
                }
            }

            //报价单(取消)
            if (ts.Items["tsbCancelQuotation"].Enabled == true)
            {
                if (quotationCancelFlag == false)
                {
                    if (Convert.ToInt32(dr["folderType"]) == 3)
                    {
                        ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCancelQuotation"].Enabled = true;
                        quotationCancelFlag = true;
                    }
                    else
                    {
                        ((ToolStripMenuItem)cms.Items["tsmiQuotation"]).DropDownItems["tsmiCancelQuotation"].Enabled = false;
                    }
                }
            }


            //打开版本
            cms.Items["tsmiVersion"].Enabled = false;

            //添加到库   //需将ID等改为从方法获取change
            if (ts.Items["tsbAddToFtp"].Enabled == true)
            {
                if (addToFtpFlag == false)
                {
                    if (FrmProjectDocumentDAO.GetAddToFtp(projectID, 90, "pc-songxi").Rows.Count > 0)
                    {
                        cms.Items["tsmiAddToFtp"].Enabled = true;
                        addToFtpFlag = true;
                    }
                    else
                    {
                        cms.Items["tsmiAddToFtp"].Enabled = false;
                    }

                }
            }
            //检入
            if (ts.Items["tsbCheckIn"].Enabled == true)
            {
                if (checkInFlag == false)
                {
                    if (FrmProjectDocumentDAO.GetCheckIn(projectID, 90, "pc-songxi").Rows.Count > 0)
                    {
                        cms.Items["tsmiCheckIn"].Enabled = true;
                        checkInFlag = true;
                    }
                    else
                    {
                        cms.Items["tsmiCheckIn"].Enabled = false;
                    }
                }
            }

            //检出
            if (ts.Items["tsbCheckOut"].Enabled == true)
            {
                if (checkOutFlag == false)
                {
                    if (FrmProjectDocumentDAO.GetCheckOut(projectID).Rows.Count > 0)
                    {
                        cms.Items["tsmiCheckOut"].Enabled = true;
                        checkOutFlag = true;
                    }
                    else
                    {
                        cms.Items["tsmiCheckOut"].Enabled = false;
                    }
                }
            }
        }

        ///// <summary>
        ///// 遍历检出子文件夹下的文件（暂不用了）
        ///// </summary>
        ///// <param name="iProjectID"></param>
        //private static void MenuEnableChildItem(ContextMenuStrip cms, int iProjectID)
        //{
        //    DataTable dt = FrmProjectDocumentDAO.GetDocuments(iProjectID);
        //    //列出所有文件
        //    foreach (DataRow dr in dt.Rows)//需将ID等改为从方法获取change
        //    {
        //        if (cms.Items["tsmiAddToFtp"].Enabled == true &&
        //            cms.Items["tsmiCheckIn"].Enabled == true &&
        //            cms.Items["tsmiCheckOut"].Enabled == true)
        //        {
        //            return;
        //        }
        //        //添加到库
        //        if (cms.Items["tsmiAddToFtp"].Enabled == false)
        //        {
        //            if (Convert.ToInt32(dr["userId"]) == 90 && dr["lockDomain"].ToString() == "pc-songxi" && Convert.ToInt32(dr["defValStored"]) == 0)
        //            {
        //                cms.Items["tsmiAddToFtp"].Enabled = true;
        //            }
        //        }
        //        //检入
        //        if (cms.Items["tsmiCheckIn"].Enabled == false)
        //        {
        //            if (Convert.ToInt32(dr["userId"]) == 90 && dr["lockDomain"].ToString() == "pc-songxi" && Convert.ToInt32(dr["defValStored"]) == 1)
        //            {
        //                cms.Items["tsmiCheckIn"].Enabled = true;
        //            }
        //        }

        //        //检出
        //        if (cms.Items["tsmiCheckOut"].Enabled == false)
        //        {
        //            if (Convert.ToInt32(dr["userId"]) == 1)
        //            {
        //                cms.Items["tsmiCheckOut"].Enabled = true;
        //            }
        //        }
        //    }

        //    DataTable dt1 = FrmProjectDocumentDAO.GetProjectDir(iProjectID);//获取项目文件夹列表
        //    //遍历所有文件夹
        //    foreach (DataRow dr1 in dt1.Rows)
        //    {
        //        if (dr1 != null)
        //        {
        //            MenuEnableChildItem(cms, Convert.ToInt32(dr1["childProject"]));//递归
        //        }
        //    }
        //}

        #endregion *********************菜单Enable属性设定（文件状态）*******************************

        /// <summary>
        /// 生成报价单号
        /// </summary>
        /// <returns></returns>
        public static string CreateQuotationNo()
        {
            ArrayList al = new ArrayList();
            al.Add("RDQ");
            al.Add("FY" + DateTime.Now.Year.ToString().Substring(2, 2));
            al.Add(BaseSQL.GetMaxID("SN", "SA_Quotation", "year", DateTime.Now.Year).ToString().PadLeft(4, '0'));

            string quotationNo = string.Empty;
            foreach (string str in al)
            {
                quotationNo = quotationNo + str + "-";
            }
            return quotationNo.Substring(0, quotationNo.Length - 1);
        }

        #region **********************隐藏文件***********************************************
        /// <summary>
        /// 隐藏文件
        /// </summary>
        /// <param name="lv"></param>
        public static void HideF(ListView lv)
        {
            if (lv.SelectedItems.Count > 0)
            {
                DialogResult dialogResult;
                //dialogResult = MessageBox.Show("确定要隐藏选定文件吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                dialogResult = MessageBox.Show(f.tsmiQdyycxdwjm.Text , f.tsmiTs.Text , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                HideSelItem(lv); //隐藏选择项
            }
            else
            {
                //MessageBox.Show("请先选择要隐藏的文件或文件夹。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(f.tsmiQxxzyycdwjhwjj.Text ,f.tsmiTs.Text , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 隐藏选择项
        /// </summary>
        /// <param name="lv"></param>
        public static void HideSelItem(ListView lv)
        {

            foreach (ListViewItem lvi in lv.SelectedItems)
            {
                try
                {
                    //如果是文件夹
                    if (lvi.SubItems[4].Text == "folder")
                    {
                        //遍历子文件夹中的项目
                        DataTable dt = FrmProjectDocumentDAO.GetHideFiles(Convert.ToInt32(lvi.Tag));
                        //列出所有文件
                        foreach (DataRow dr in dt.Rows)
                        {
                            //更新【隐藏】状态标记
                            FrmProjectDocumentDAO.UpdateHideFlag(Convert.ToInt32(dr["documentID"]));
                        }
                    }
                    else//如果是文件
                    {
                        DataRow dr;
                        dr = FrmProjectDocumentDAO.GetDocumentInfo(Convert.ToInt32(lvi.Tag));
                        //调用隐藏文件方法     //change
                        if (Convert.ToBoolean(dr["Hidden"]) == false)
                        {
                            //更新【隐藏】状态标记
                            FrmProjectDocumentDAO.UpdateHideFlag(Convert.ToInt32(dr["documentID"]));
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion **********************隐藏文件*********************************************


        #region **********************取消隐藏文件***********************************************
        /// <summary>
        /// 取消隐藏文件
        /// </summary>
        /// <param name="lv"></param>
        public static void CancelHideF(ListView lv)
        {
            if (lv.SelectedItems.Count > 0)
            {
                DialogResult dialogResult;
                //dialogResult = MessageBox.Show("确定要取消隐藏选定文件吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                dialogResult = MessageBox.Show(f.tsmiQdyycxdwjm.Text , f.tsmiTs.Text , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Cancel)
                {
                    return;
                }
                CancelHideSelItem(lv); //取消隐藏选择项
            }
            else
            {
                //MessageBox.Show("请先选择要取消隐藏的文件或文件夹？", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(f.tsmiQxxzyycdwjhwjj.Text , f.tsmiTs.Text , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 取消隐藏选择项
        /// </summary>
        /// <param name="lv"></param>
        public static void CancelHideSelItem(ListView lv)
        {

            foreach (ListViewItem lvi in lv.SelectedItems)
            {
                try
                {
                    //如果是文件夹
                    if (lvi.SubItems[4].Text == "folder")
                    {
                        //遍历子文件夹中的项目
                        DataTable dt = FrmProjectDocumentDAO.GetCancelHideFiles(Convert.ToInt32(lvi.Tag));
                        //列出所有文件
                        foreach (DataRow dr in dt.Rows)
                        {
                            //更新【隐藏】状态标记
                            FrmProjectDocumentDAO.UpdateCancelHideFlag(Convert.ToInt32(dr["documentID"]));
                        }
                    }
                    else//如果是文件
                    {
                        DataRow dr;
                        dr = FrmProjectDocumentDAO.GetDocumentInfo(Convert.ToInt32(lvi.Tag));
                        //调用隐藏文件方法     //change
                        if (Convert.ToBoolean(dr["Hidden"]) == true)
                        {
                            //更新【隐藏】状态标记
                            FrmProjectDocumentDAO.UpdateCancelHideFlag(Convert.ToInt32(dr["documentID"]));
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, f.tsmiCw.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion **********************取消隐藏文件*********************************************


    }
}
