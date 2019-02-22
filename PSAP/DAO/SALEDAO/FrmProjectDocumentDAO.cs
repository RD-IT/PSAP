using PSAP.BLL.SALEBLL;
using PSAP.DAO.BSDAO;
using PSAP.VIEW.BSVIEW;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAP.DAO.SALEDAO
{
    class FrmProjectDocumentDAO
    {
        public static ArrayList sqlLlist = new ArrayList();//存储SQL语句

        /// <summary>
        /// 获取项目子文件夹列表
        /// </summary>
        /// <param name="iProjectID"></param>
        /// <returns></returns>
        public static DataTable GetProjectDir(int iProjectID)
        {
            try
            {
                string sSql = "select a.ChildProject, a.ProjectID, b.Name, b.StatusID, b.StartTime, b.Deadline, " +
                    "b.TimeEstimate, b.Busy, b.MoveCount, b.Path, b.Deleted, b.FolderType " +
                    "from SA_ProjectTree a  left join SA_Projects b " +
                    "on a.ChildProject = b.ProjectID " +
                    "where a.ProjectID =" + iProjectID + " and b.Deleted = 0 and (b.FolderType = 1 or b.folderType=3) " +
                    "order by b.name";

                return BaseSQL.GetTableBySql(sSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        /// <summary>
        /// 获取指定项目对应本地路径
        /// </summary>
        /// <param name="iProjectID"></param>
        /// <returns></returns>
        public static string GetProjectLocalPath(int iProjectID)
        {
            try
            {
                string sSql = "select top 1 a.Path from SA_Projects a where a.ProjectID=" + iProjectID;
                DataTable dt;
                dt = BaseSQL.GetTableBySql(sSql);
                DataRow dr = dt.Rows[0];
                return dr["path"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }


        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <param name="iProjectID"></param>
        /// <returns></returns>
        public static DataTable GetDocuments(int iProjectID)
        {
            try
            {
                string sSql = "select b.lockOpened,a.ProjectID,a.DocumentID,a.Deleted,b.Filename,b.LockProject,b.UserID,b.LockDomain,b.LockPath,b.Busy," +
                    "b.Flushed,b.DefValStored,b.RevGenCounter,b.LatestRevisionNo,b.CurrentStatusID,b.WorkingVersionModified," +
                    "c.Extension,c.Flags,b.LockDate,b.UserDocRefsModified,b.Shared,b.LockViewID,b.Link,b.DocTypeID,b.ObjectTypeID,b.Flags,b.hidden," +
                    "d.fileSize,d.fileDate " +
                    "from SA_DocumentsInProjects a " +
                    "left join SA_Documents b on a.DocumentID = b.DocumentID " +
                    "left join SA_FileExtension c on b.ExtensionID = c.ExtensionID " +
                    "left join SA_Revisions d on b.documentID=d.documentID and b.LatestRevisionNo=d.RevNr " +
                    "where a.ProjectID =" + iProjectID + " and a.Deleted = 0 and b.Deleted = 0 " +
                    "order by a.ProjectID,b.Filename";
                //d影响速度

                return BaseSQL.GetTableBySql(sSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        /// <summary>
        /// 获取文件信息
        /// </summary>
        /// <param name="documentID"></param>
        /// <returns></returns>
        public static DataRow GetDocumentInfo(int documentID)
        {
            try
            {
                string sSql = "select distinct a.*,b.fileSize,b.fileDate from SA_Documents a left join SA_Revisions b " +
                    "on a.documentID=b.documentID and a.LatestRevisionNo=b.RevNr where a.documentID =" + documentID;
                //b影响速度

                DataTable dt;
                dt = BaseSQL.GetTableBySql(sSql);
                DataRow dr;
                return dr = dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        /// <summary>
        /// 获取项目信息
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns></returns>
        public static DataRow GetProjectInfo(int projectID)
        {
            try
            {
                string sSql = "select * from SA_Projects a where a.projectID =" + projectID;
                DataTable dt;
                dt = BaseSQL.GetTableBySql(sSql);
                DataRow dr;
                return dr = dt.Rows[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }


        /// <summary>
        /// 获取指定项目所有层次的文件列表(含指定项目)
        /// </summary>
        /// <param name="iProjectID"></param>
        /// <returns></returns>
        public static DataTable GetAllLevelDocuments(int iProjectID)
        {
            try
            {
                string sSql = "select b.ProjectID,c.ChildProjectID,c.ParentProjectID,c.Level,a.* " +
                "from SA_Documents a " +
                "inner join SA_DocumentsInProjects b on a.DocumentID = b.DocumentID " +
                "inner join SA_ProjectTreeRec c on b.projectID = c.childProjectID and c.ParentProjectID =" + iProjectID + " " +
                "where a.Deleted = 0 and b.Deleted = 0 ";

                return BaseSQL.GetTableBySql(sSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        /// <summary>
        /// 获取指定项目所有层次的项目列表(含指定项目)
        /// </summary>
        /// <param name="iProjectID"></param>
        /// <returns></returns>
        public static DataTable GetAllLevelProjects(int iProjectID)
        {
            try
            {
                string sSql = "select a.ChildProjectID,a.ParentProjectID,a.Level,b.* " +
                "from SA_ProjectTreeRec a " +
                "left join SA_Projects b on a.ChildProjectID=b.ProjectID " +
                "where b.Deleted = 0 " +
                "and a.ParentProjectID = " + iProjectID;

                return BaseSQL.GetTableBySql(sSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }


        /// <summary>
        /// 在服务器创建文件夹
        /// </summary>
        /// <param name="projectName"></param>
        /// <param name="projectPath"></param>
        /// <param name="parentProjectID"></param>
        public static int CreateFolderToSever(string projectName, string projectPath, int parentProjectID)
        {
            //string sql;
            try
            {
                IDataParameter[] parameters = new System.Data.IDataParameter[5];//实例化参数对象
                parameters[0] = new SqlParameter("@projectName", projectName);//参数对象赋值 
                parameters[1] = new SqlParameter("@projectPath", projectPath);
                parameters[2] = new SqlParameter("@parentProjectID", parentProjectID);
                parameters[3] = new SqlParameter("@newProjectId", SqlDbType.Int);
                parameters[4] = new SqlParameter("@returnMessage", string.Empty);
                parameters[3].Direction = ParameterDirection.Output;
                parameters[4].Direction = ParameterDirection.Output;
                BaseSQL.RunProcedure("CreateFolderToSever", parameters);
                return Convert.ToInt32(parameters[3].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }

        }

        /// <summary>
        /// 在本地创建文档 
        /// </summary>
        /// <param name="documentName"></param>
        /// <param name="inProjectID"></param>
        public static void CreateDocmentToLocal(string documentName, int inProjectID, string lockPath, Int64 fileSize, DateTime fileDate)
        {
            string sql;
            string fileExtension;
            int fileExtensionID;
            string icoFileName;
            fileExtension = (Path.GetExtension(documentName));
            if (fileExtension == ".exe" || fileExtension == "" || fileExtension == ".lnk")
            {
                icoFileName = Path.GetFileNameWithoutExtension(documentName);
            }
            else
            {
                icoFileName = Path.GetExtension(documentName).Substring(1);
            }

            try
            {
                //增加新的文件类型
                sql = "insert into SA_FileExtension (Extension, Flags) " +
                    "select '" + icoFileName + "', 0 where '" + icoFileName +
                        "' not in (select Extension from SA_FileExtension ) ";
                BaseSQL.ExecuteSql(sql);

                //获得指定文件类型对应ID
                sql = "select a.ExtensionID from SA_FileExtension a " +
                    "where a.extension like '" + icoFileName + "'";
                fileExtensionID = Convert.ToInt32(BaseSQL.GetTableBySql(sql).Rows[0][0]);

                lockPath = Path.GetDirectoryName(lockPath);
                //增加文档信息【需将用户iD等改为变量】change
                int newDocumentID = BaseSQL.GetMaxID("documentID", "SA_Documents");
                sqlLlist.Clear();
                sql = "insert into SA_Documents(filename,busy,extensionID,deleted,flags," +
                    "lockProject,userId,lockDomain,lockPath,lockDate,latestRevisionNo,objectTypeID,defValStored) " +
                    "values('" + documentName + "', 0," + fileExtensionID + " , 0,0," +
                    inProjectID + ",'90','pc-songxi','" + lockPath + "','" + DateTime.Now + "',0 ,1,0)";//'90':userID
                sqlLlist.Add(sql);

                //增加文档和项目关联关系信息
                sql = "insert into SA_DocumentsInProjects(projectID,documentID,Deleted) " +
                      "values(" + inProjectID + "," + newDocumentID + ",0)";
                sqlLlist.Add(sql);

                //增加文档版本信息
                sql = "insert into SA_Revisions(documentID,RevNr,date,UserID,fileSize,fileDate) " +
                      "values(" + newDocumentID + ",0,'" + DateTime.Now + "',90," + fileSize + ",'" + fileDate + "')";//change 90
                sqlLlist.Add(sql);

                BaseSQL.ExecuteSqlTran(sqlLlist);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        /// <summary>
        /// 判断指定文件类型是否存在,不存在时执行后续操作
        /// </summary>
        /// <param name="documentName"></param>
        /// <returns></returns>
        public static bool ExistsFileExtension(string documentName)
        {
            string sql;
            string fileExtension;
            fileExtension = Path.GetExtension(documentName).Substring(1);
            try
            {
                //增加新的文件类型
                sql = "select * from SA_FileExtension where Extension='" + fileExtension + "'";
                return BaseSQL.Exists(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

        }

        /// <summary>
        /// 将更改后的文件名（文件夹名）的更改同步到数据库
        /// </summary>
        /// <param name="newName"></param>
        /// <param name="documentOrProjectID"></param>
        /// <param name="folderOrFile"></param>
        public static void RenameToDbAndXml(string newName, int documentOrProjectID, string folderOrFile, string newPath)
        {
            try
            {
                if (folderOrFile == "folder")
                {
                    string sql = "update a set a.name='" + newName + "',a.path='" + newPath + "' " +
                        "from SA_Projects a where a.ProjectID=" + documentOrProjectID;
                    BaseSQL.ExecuteSql(sql);
                }
                else
                {
                    string sql = "update a set a.Filename='" + newName +
                        "' from SA_Documents a where a.documentID=" + documentOrProjectID;
                    BaseSQL.ExecuteSql(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// 更新【添加入库】状态标记及相应字段,并增加版本信息
        /// </summary>
        /// <param name="documentID"></param>
        public static void UpdateAddToFtpFlag(int documentID, Int64 fileSize, DateTime fileDate)
        {
            try
            {
                sqlLlist.Clear();
                string sql = "update a set a.defValStored=1,a.userID=1,a.lockDomain='',a.lockPath='',a.latestRevisionNo=1 " +
                    "from SA_Documents a where a.DocumentID=" + documentID;
                sqlLlist.Add(sql);

                //增加文档版本信息(添加到库时版本始终为1)
                sql = "insert into SA_Revisions(documentID,RevNr,date,UserID,fileSize,fileDate) " +
                      "values(" + documentID + ", 1 ,'" + DateTime.Now + "',90," + fileSize + ",'" + fileDate + "')";//change 90
                sqlLlist.Add(sql);
                BaseSQL.ExecuteSqlTran(sqlLlist);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 更新【检入】状态标记及相应字段
        /// </summary>
        /// <param name="documentID"></param>
        public static void UpdateCheckInFlag(int documentID)
        {
            try
            {
                string sql = "update a set a.userID=1,a.lockDomain='',a.lockPath='' " +
                    "from SA_Documents a where a.DocumentID=" + documentID;
                BaseSQL.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 更新【检入】文件版本字段
        /// </summary>
        /// <param name="documentID"></param>
        public static void UpdateCheckInRevisionNo(int documentID, Int64 fileSize, DateTime fileDate, int latestRevisionNo)
        {
            try
            {
                sqlLlist.Clear();
                string sql = "update a set a.latestRevisionNo=latestRevisionNo+1 " +
                    "from SA_Documents a where a.DocumentID=" + documentID;
                sqlLlist.Add(sql);

                //增加文档版本信息
                sql = "insert into SA_Revisions(documentID,RevNr,date,UserID,fileSize,fileDate) " +
                      "values(" + documentID + "," + latestRevisionNo + ",'" + DateTime.Now + "',90," + fileSize + ",'" + fileDate + "')";//change 90
                sqlLlist.Add(sql);
                BaseSQL.ExecuteSqlTran(sqlLlist);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// 更新【检出】状态标记
        /// </summary>
        /// <param name="documentID"></param>
        /// <param name="localPath"></param>
        /// <param name="userID"></param>
        /// <param name="lockDomain"></param>
        public static void UpdateCheckOutFlag(int documentID, string localPath, int userID, string lockDomain)
        {
            try
            {
                string sql = "update a set a.userID=" + userID + "," +
                    "a.lockDomain='" + lockDomain + "'," +
                    "a.lockPath='" + localPath + "' ," +
                    "a.lockOpened=0 " +
                    "from SA_Documents a where a.DocumentID=" + documentID;
                BaseSQL.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        /// <summary>
        /// 更新文件打开标记
        /// </summary>
        /// <param name="documentID"></param>
        public static void UpdateFileOpenFlag(int documentID)
        {
            try
            {
                string sql = "update a set a.lockOpened=1 " +
                    "from SA_Documents a where a.DocumentID=" + documentID;
                BaseSQL.ExecuteSql(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 获取指定项目节点数据
        /// </summary>
        /// <returns></returns>
        //public static DataTable GetAppointProjectNode()
        //{
        //    string sql = "select * from BS_Department where ParentDepartmentNo is null "; //根部门，其父部门id为null
        //    DataTable dt = BaseSQL.GetTableBySql(sql);
        //    return dt;
        //}

        /// <summary>
        /// 获取子项目节点数据
        /// </summary>
        /// <returns></returns>
        //public static DataTable GetAppointChildProjectNode(string strParentDepartmentNo)
        //{
        //    string sql = "select * from BS_Department where ParentDepartmentNo ='" + strParentDepartmentNo + "'";
        //    DataTable dt = BaseSQL.GetTableBySql(sql);
        //    return dt;
        //}

        /// <summary>
        /// 删除选择的文件（做删除标记）
        /// </summary>
        /// <param name="documentID"></param>
        public static void DeleteSelFile(int documentID)
        {
            sqlLlist.Clear();
            string sql = "update a set a.deleted=1 from SA_Documents a where a.documentID =" + documentID;
            sqlLlist.Add(sql);

            sql = "update a set a.deleted=1 from SA_DocumentsInProjects a where a.documentID =" + documentID;
            sqlLlist.Add(sql);
            BaseSQL.ExecuteSqlTran(sqlLlist);
        }

        /// <summary>
        /// 隐藏选择的文件（做隐藏标记）
        /// </summary>
        /// <param name="documentID"></param>
        public static void UpdateHideFlag(int documentID)
        {
            string sql = "update a set a.hidden=1 from SA_Documents a where a.documentID =" + documentID;
            BaseSQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 取消隐藏选择的文件（取消隐藏标记）
        /// </summary>
        /// <param name="documentID"></param>
        public static void UpdateCancelHideFlag(int documentID)
        {
            string sql = "update a set a.hidden=0 from SA_Documents a where a.documentID =" + documentID;
            BaseSQL.ExecuteSql(sql);
        }


        /// <summary>
        /// 增加删除文件夹Sql（做删除标记）
        /// </summary>
        /// <param name="documentID"></param>
        public static void AddSqlDeleteSelDir(int projectID)
        {
            string sql = "update a set a.deleted=1 from SA_projects a where a.projectID =" + projectID;
            sqlLlist.Add(sql);
        }

        /// <summary>
        /// 增加删除文件Sql（做删除标记）
        /// </summary>
        /// <param name="documentID"></param>
        public static void AddSqlDeleteSelFile(int documentID)
        {
            string sql = "update a set a.deleted=1 from SA_Documents a where a.documentID =" + documentID;
            sqlLlist.Add(sql);

            sql = "update a set a.deleted=1 from SA_DocumentsInProjects a where a.documentID =" + documentID;
            sqlLlist.Add(sql);

        }

        #region **********************菜单Enable属性检测（文件状态）及可操作明细获得********************************
        /// <summary>
        /// 获得添加到库的文件列表
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns>大于0时包含</returns>
        public static DataTable GetAddToFtp(int projectID, int userID, string lockDomain)
        {
            try
            {
                string sSql = "select b.ProjectID,c.ChildProjectID,c.ParentProjectID,c.Level,a.* " +
                "from SA_Documents a " +
                "inner join SA_DocumentsInProjects b on a.DocumentID = b.DocumentID " +
                "inner join SA_ProjectTreeRec c on b.projectID = c.childProjectID and c.ParentProjectID =" + projectID + " " +
                "where a.Deleted = 0 and b.Deleted = 0 " +
                "and  a.userID=" + userID + " and a.lockDomain like '" + lockDomain + "' and a.defValStored=0 ";
                return BaseSQL.GetTableBySql(sSql);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        /// <summary>
        /// 获得检入的文件
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns>大于0时包含</returns>
        public static DataTable GetCheckIn(int projectID, int userID, string lockDomain)
        {
            try
            {
                string sSql = "select b.ProjectID,c.ChildProjectID,c.ParentProjectID,c.Level,a.* " +
                "from SA_Documents a " +
                "inner join SA_DocumentsInProjects b on a.DocumentID = b.DocumentID " +
                "inner join SA_ProjectTreeRec c on b.projectID = c.childProjectID and c.ParentProjectID =" + projectID + " " +
                "where a.Deleted = 0 and b.Deleted = 0 " +
                "and  a.userID=" + userID + " " +
                "and a.lockDomain like '" + lockDomain + "'" +
                "and a.defValStored=1 ";
                //"and a.lockOpened=1 ";
                return BaseSQL.GetTableBySql(sSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        /// <summary>
        /// 获得检出的文件列表
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns>大于0时包含</returns>
        public static DataTable GetCheckOut(int projectID)
        {
            try
            {
                string sSql = "select b.ProjectID,c.ChildProjectID,c.ParentProjectID,c.Level,a.* " +
                "from SA_Documents a " +
                "inner join SA_DocumentsInProjects b on a.DocumentID = b.DocumentID " +
                "inner join SA_ProjectTreeRec c on b.projectID = c.childProjectID and c.ParentProjectID =" + projectID + " " +
                "where a.Deleted = 0 and b.Deleted = 0 " +
                "and  a.userID=1";
                return BaseSQL.GetTableBySql(sSql);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        /// <summary>
        /// 获得隐藏的文件列表(未应用于菜单Enable)
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns>大于0时包含</returns>
        public static DataTable GetHideFiles(int projectID)
        {
            try
            {
                string sSql = "select b.ProjectID,c.ChildProjectID,c.ParentProjectID,c.Level,a.* " +
                "from SA_Documents a " +
                "inner join SA_DocumentsInProjects b on a.DocumentID = b.DocumentID " +
                "inner join SA_ProjectTreeRec c on b.projectID = c.childProjectID and c.ParentProjectID =" + projectID + " " +
                "where a.Deleted = 0 and b.Deleted = 0 " +
                "and  a.hidden=0";
                return BaseSQL.GetTableBySql(sSql);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }


        /// <summary>
        /// 获得取消隐藏的文件列表(未应用于菜单Enable)
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns>大于0时包含</returns>
        public static DataTable GetCancelHideFiles(int projectID)
        {
            try
            {
                string sSql = "select b.ProjectID,c.ChildProjectID,c.ParentProjectID,c.Level,a.* " +
                "from SA_Documents a " +
                "inner join SA_DocumentsInProjects b on a.DocumentID = b.DocumentID " +
                "inner join SA_ProjectTreeRec c on b.projectID = c.childProjectID and c.ParentProjectID =" + projectID + " " +
                "where a.Deleted = 0 and b.Deleted = 0 " +
                "and  a.hidden=1";
                return BaseSQL.GetTableBySql(sSql);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        #endregion **********************菜单Enable属性检测（文件状态）及可操作明细获得********************************

        /// <summary>
        /// 生成报价单
        /// </summary>
        /// <param name="lv"></param>
        public static void CreateQuotation(ListView lv)
        {
            sqlLlist.Clear();
            int projectID = Convert.ToInt32(lv.SelectedItems[0].Tag);
            try
            {
                string sql = "insert into SA_quotation(quotationNo,SN,projectID,year) " +
                             "values('" + FrmProjectDocumentBLL.CreateQuotationNo() + "'," +
                             BaseSQL.GetMaxID("SN", "SA_quotation","year", DateTime.Now.Year) + "," +
                             projectID +","+DateTime.Now.Year+ ")";
                sqlLlist.Add(sql);

                sql = "update a set a.FolderType=3  from SA_Projects a where a.ProjectID=" + projectID;
                sqlLlist.Add(sql);

                BaseSQL.ExecuteSqlTran(sqlLlist);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 取消报价单
        /// </summary>
        /// <param name="lv"></param>
        public static void CancelQuotation(ListView lv)
        {
            sqlLlist.Clear();
            int projectID = Convert.ToInt32(lv.SelectedItems[0].Tag);
            try
            {
                string sql = "update a set a.deleted=1  from SA_Quotation a where a.ProjectID=" + projectID;
                sqlLlist.Add(sql);

                //FolderType=1:普通文件夹；3：关联报价单
                sql = "update a set a.FolderType=1  from SA_Projects a where a.ProjectID=" + projectID;
                sqlLlist.Add(sql);

                BaseSQL.ExecuteSqlTran(sqlLlist);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #region     ***************1.获得查询到的文件和文件夹列表(在全部范围内)*************************
        /// <summary>
        /// 获取项目子文件夹列表
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public static DataTable QueryAllProjects(string queryString)
        {
            try
            {
                string sSql = "select a.ChildProject, a.ProjectID, b.Name, b.StatusID, b.StartTime, b.Deadline, " +
                            "b.TimeEstimate, b.Busy, b.MoveCount, b.Path, b.Deleted, b.FolderType " +
                            "from SA_ProjectTree a  left join SA_Projects b on a.ChildProject = b.ProjectID " +
                            "where b.Deleted = 0 and (b.FolderType = 1 or b.folderType=3) " +
                                "and upper(b.name) like '%" + queryString.ToUpper() + "%' " +
                            "order by b.name";
                return BaseSQL.GetTableBySql(sSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        /// <summary>
        /// 获取文件列表
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public static DataTable QueryAllDocuments(string queryString)
        {
            try
            {
                string sSql = "select b.lockOpened,b.DocumentID,b.Deleted,b.Filename,b.LockProject,b.UserID,b.LockDomain,b.LockPath,b.Busy," +
                    "b.Flushed,b.DefValStored,b.RevGenCounter,b.LatestRevisionNo,b.CurrentStatusID,b.WorkingVersionModified," +
                    "c.Extension,c.Flags,b.LockDate,b.UserDocRefsModified,b.Shared,b.LockViewID,b.Link,b.DocTypeID,b.ObjectTypeID,b.Flags,b.hidden " +
                    "from SA_Documents b " +
                    "left join SA_FileExtension c on b.ExtensionID = c.ExtensionID " +
                    "where b.Deleted = 0 and upper(b.filename) like '%" + queryString.ToUpper() + "%' " +
                    "order by b.Filename";

                return BaseSQL.GetTableBySql(sSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        #endregion  ***************1.获得查询到的文件和文件夹列表(在全部范围内)*************************


        #region     ***************2.获得查询到的文件和文件夹列表(从当前文件夹开始)*************************

        /// <summary>
        /// 获取当前项目子文件夹列表
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public static DataTable QueryCurrentProjects(string queryString)
        {
            try
            {
                string sql = "select a.ChildProjectID, b.ProjectID, b.Name, b.StatusID, b.StartTime, b.Deadline, " +
                            "b.TimeEstimate, b.Busy, b.MoveCount, b.Path, b.Deleted, b.FolderType " +
                    "from SA_ProjectTreeRec a left join SA_Projects b on b.projectID = a.childProjectID and a.ParentProjectID!=a.childProjectID and a.ParentProjectID =" + FrmProjectDocument.curPathNode.iProjectID + " " +
                    "where b.Deleted = 0 and (b.FolderType = 1 or b.folderType=3) " +
                    "and upper(b.name) like '%" + queryString.ToUpper() + "%' " +
                    "order by b.name";

                return BaseSQL.GetTableBySql(sql);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        /// <summary>
        /// 获取当前项目文件列表
        /// </summary>
        /// <param name="queryString"></param>
        /// <returns></returns>
        public static DataTable QueryCurrentDocuments(string queryString)
        {
            try
            {
                string Sql = "select a.lockOpened,a.DocumentID,a.Deleted,a.Filename,a.LockProject,a.UserID,a.LockDomain,a.LockPath,a.Busy," +
                    "a.Flushed,a.DefValStored,a.RevGenCounter,a.LatestRevisionNo,a.CurrentStatusID,a.WorkingVersionModified," +
                    "d.Extension,d.Flags,a.LockDate,a.UserDocRefsModified,a.Shared,a.LockViewID,a.Link,a.DocTypeID,a.ObjectTypeID,a.Flags,a.hidden, " +
                    "e.fileSize,e.FileDate " +
                "from SA_Documents a " +
                "left join SA_FileExtension d on a.ExtensionID = d.ExtensionID " +
                "inner join SA_DocumentsInProjects b on a.DocumentID = b.DocumentID " +
                "inner join SA_ProjectTreeRec c on b.projectID = c.childProjectID and c.ParentProjectID =" + FrmProjectDocument.curPathNode.iProjectID + " " +
                "inner join SA_Revisions e on a.documentID=e.documentID and a.LatestRevisionNo=e.RevNr " +
                "where a.Deleted = 0 and b.Deleted = 0 " +
                "and upper(a.filename) like '%" + queryString.ToUpper() + "%' " +
                "order by a.Filename";
                return BaseSQL.GetTableBySql(Sql);
                //e影响速度
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        #endregion  ***************2.获得查询到的文件和文件夹列表(从当前文件夹开始)*************************


        /// <summary>
        /// 将备注信息数据保存到数据库
        /// </summary>
        /// <param name="dataSet1"></param>
        public static void SaveRemarksInfo(DataSet dataSet1)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);
                        cmd.CommandText = "select Top 0 * from SA_RemarksInfo ";
                        SqlDataAdapter adp = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adp.Fill(dt);
                        BaseSQL.UpdateDataTable(adp, dataSet1.Tables["RemarksInfo"]);

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        dataSet1.Tables["RemarksInfo"].RejectChanges();
                        throw ex;
                    }
                }
            }
        }

        /// <summary>
        /// 删除选定行数据
        /// </summary>
        /// <param name="strBussinessCategory"></param>
        public static bool DeleteRemarksInfoData(int remarksID)
        {
            try
            {
                sqlLlist.Clear();
                string sql = @"delete from SA_remarksInfo where remarksId =" + remarksID;
                sqlLlist.Add(sql);
                sql = @"delete from SA_ProjectsRemarks where remarksId =" + remarksID;
                sqlLlist.Add(sql);
                sql = @"delete from SA_DocumentsRemarks where remarksId =" + remarksID;
                sqlLlist.Add(sql);
                BaseSQL.ExecuteSqlTran(sqlLlist);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        /// <summary>
        /// 获得完整的项目树
        /// </summary>
        /// <returns></returns>
        public static DataTable GetCompleteProjectTree()
        {
            try
            {
                string sSql = "select a.ChildProject, a.ProjectID, b.Name, " +
                    "b.Path " +
                    "from SA_ProjectTree a  left join SA_Projects b " +
                    "on a.ChildProject = b.ProjectID " +
                    "where b.Deleted = 0 and (b.FolderType = 1 or b.folderType=3) " +
                    "order by b.name";
                return BaseSQL.GetTableBySql(sSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }

        /// <summary>
        /// 根据文件夹的path,获得已存在文件夹的projectID
        /// </summary>
        /// <param name="projectPath"></param>
        /// <returns></returns>
        public static int GetExistsProjectID(string projectPath)
        {
            try
            {
                string sql = "select a.ProjectID " +
                            "from SA_Projects a " +
                            "where a.Deleted = 0 and a.Path like '" + projectPath + "' ";
                DataTable dt = BaseSQL.GetTableBySql(sql);
                if (dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    return Convert.ToInt32(dr["projectID"]);
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return -1;
            }
        }


    }
}
