using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PSAP.DAO.BSDAO
{
    class FrmOrganizationStruDAO
    {
        /// <summary>
        /// 获取根部门数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTopDepartmentData()
        {
            string sql = "select * from BS_Department where ParentDepartmentNo is null "; //根部门，其父部门id为null
            DataTable dt = BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 获取子部门数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetChildDepartmentData(string strParentDepartmentNo)
        {
            string sql = "select * from BS_Department where ParentDepartmentNo ='" + strParentDepartmentNo + "'";
            DataTable dt = BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 更改部门编号时，同步更改以此编号为父部门编码的数据
        /// </summary>
        /// <param name="strDepartmentNo"></param>
        /// <param name="strNewDepartmentNo"></param>
        public static void UpdateDeptmentNoCorrelationData(string strDepartmentNo,string strNewDepartmentNo)
        {
            string sql = @"update BS_Department set ParentDepartmentNo = '" + strNewDepartmentNo + "' where ParentDepartmentNo like '" + strDepartmentNo + "'";
            BaseSQL.ExecuteSql(sql);

        }
    }
}
