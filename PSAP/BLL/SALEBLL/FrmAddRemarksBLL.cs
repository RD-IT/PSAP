using PSAP.DAO.BSDAO;
using PSAP.DAO.SALEDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAP.BLL.SALEBLL
{
    class FrmAddRemarksBLL
    {
        public static void SaveRemarks(ListView lv, string remarks)
        {
            int newRemarksID;
            IDataParameter[] parameters = new System.Data.IDataParameter[4];//实例化参数对象
            parameters[0] = new SqlParameter("@Remarks", remarks);//参数对象赋值 
            parameters[1] = new SqlParameter("@Founder", "songxi");//需改成变量change
            parameters[2] = new SqlParameter("@newRemarksID", SqlDbType.Int);
            parameters[3] = new SqlParameter("@returnMessage", string.Empty);
            parameters[2].Direction = ParameterDirection.Output;
            parameters[3].Direction = ParameterDirection.Output;
            BaseSQL.RunProcedure("GetNewRemarksID", parameters);
            newRemarksID = Convert.ToInt32(parameters[2].Value);//

            FrmAddRemarksDAO.sqlLlist.Clear();
            foreach (ListViewItem lvi in lv.SelectedItems)
            {
                //项目或文档ID
                int itemID = Convert.ToInt32(lvi.Tag);
                try
                {
                    //如果是文件夹
                    if (lvi.SubItems[4].Text == "folder")
                    {
                        //获得项目列表
                        DataTable dt = FrmProjectDocumentDAO.GetAllLevelProjects(itemID);
                        //项目下的所有项目
                        foreach (DataRow dr in dt.Rows)
                        {
                            //调用保存【项目备注】方法
                            FrmAddRemarksDAO.SaveProjectsRemarks_AddSql(Convert.ToInt32(dr["projectID"]), newRemarksID);
                        }

                        //获得文件列表
                        dt = FrmProjectDocumentDAO.GetAllLevelDocuments(itemID);
                        //项目下的所有文件
                        foreach (DataRow dr in dt.Rows)
                        {
                            //调用保存【文档备注】方法
                            FrmAddRemarksDAO.SaveDocumentsRemarks_AddSql(Convert.ToInt32(dr["documentID"]), newRemarksID);
                        }
                    }
                    else//如果是文件
                    {
                        DataRow dr;
                        dr = FrmProjectDocumentDAO.GetDocumentInfo(itemID);
                        //调用保存【文档备注】方法     
                        FrmAddRemarksDAO.SaveDocumentsRemarks_AddSql(Convert.ToInt32(dr["documentID"]), newRemarksID);
                    }
                    BaseSQL.ExecuteSqlTran(FrmAddRemarksDAO.sqlLlist);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// 获得当前所选项备注信息
        /// </summary>
        /// <param name="lvi">当前所选的第一项</param>
        public static void GetRemarksInfo(DataSet ds, ListViewItem lvi)
        {
            try
            {
                if (lvi.SubItems[4].Text == "folder")
                {
                   FrmAddRemarksDAO.GetProjectsRemarks(ds,Convert.ToInt32(lvi.Tag));
                }
                else
                {
                    FrmAddRemarksDAO.GetDocumentsRemarks(ds,Convert.ToInt32(lvi.Tag));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
