using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.DAO.BSDAO
{
    class FrmPartsCodeDAO
    {
        /// <summary>
        /// 查询和当前零件编号相同的零件个数
        /// </summary>
        public int QueryPartsCode_CodeFileNameCount(string codeFileNameStr)
        {
            string sqlStr = string.Format("select Count(*) from SW_PartsCode where CodeFileName = '{0}'", codeFileNameStr);
            return DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr));
        }

        /// <summary>
        /// 保存导入的物料信息
        /// </summary>
        public void SaveImportPartsCode(DataTable partsCodeTable)
        {
            using (SqlConnection conn = new SqlConnection(BaseSQL.connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    try
                    {
                        SqlCommand cmd = new SqlCommand("", conn, trans);

                        cmd.CommandText = "select * from SW_PartsCode where 1=2";
                        SqlDataAdapter adapterList = new SqlDataAdapter(cmd);
                        DataTable tmpPCTable = new DataTable();
                        adapterList.Fill(tmpPCTable);
                        BaseSQL.UpdateDataTable(adapterList, partsCodeTable);

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}
