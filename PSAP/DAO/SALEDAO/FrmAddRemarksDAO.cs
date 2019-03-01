using PSAP.DAO.BSDAO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAP.DAO.SALEDAO
{
    class FrmAddRemarksDAO
    {
        public static ArrayList sqlLlist = new ArrayList();//存储SQL语句

        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();
        public FrmAddRemarksDAO()
        {
            PSAP.BLL.BSBLL.BSBLL.language(f);
        }

        /// <summary>
        /// 增加保存【项目备注】SQL语句
        /// </summary>
        /// <param name="projectID"></param>
        public static void SaveProjectsRemarks_AddSql(int projectID, int newRemarksID)
        {
            string sql = "insert into SA_ProjectsRemarks(projectID,remarksID) " +
                "values(" + projectID + "," + newRemarksID + ")";
            sqlLlist.Add(sql);
        }

        /// <summary>
        /// 增加保存【文档备注】SQL语句
        /// </summary>
        /// <param name="documentID"></param>
        public static void SaveDocumentsRemarks_AddSql(int documentID, int newRemarksID)
        {
            string sql = "insert into SA_DocumentsRemarks(documentID,remarksID) " +
                "values(" + documentID + "," + newRemarksID + ")";
            sqlLlist.Add(sql);
        }

        /// <summary>
        /// 获得文档备注信息
        /// </summary>
        /// <param name="documentID"></param>
        /// <returns></returns>
        public static void GetDocumentsRemarks(DataSet ds, int documentID)
        {
            try
            {
                ds.Tables["remarksInfo"].Clear();
                string sql = "select  a.*,b.Remarks,b.Founder,b.CreateDate " +
                              "from SA_DocumentsRemarks a left join SA_RemarksInfo b on a.RemarksID = b.RemarksID " +
                              "where a.DocumentID =" + documentID;

                BaseSQL.Query(sql, ds.Tables["remarksInfo"]);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(ex.Message, f.tsmiTs.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        /// <summary>
        /// 获得项目备注信息
        /// </summary>
        /// <param name="projectID"></param>
        /// <returns></returns>
        public static void GetProjectsRemarks(DataSet ds, int projectID)
        {
            try
            {
                ds.Tables["remarksInfo"].Clear();
                string sql = "select a.*,b.Remarks,b.Founder,b.CreateDate " +
                              "from SA_ProjectsRemarks a left join SA_RemarksInfo b on a.RemarksID = b.RemarksID " +
                              "where a.ProjectID =" + projectID;

                BaseSQL.Query(sql, ds.Tables["remarksInfo"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,f.tsmiTs.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
