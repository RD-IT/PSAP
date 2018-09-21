using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace PSAP.DAO.BSDAO
{
    class GetUserInfoList
    {
        public static DataTable getUserInfoList(string strUserID ,string strLoginID, string strUserName,string strDepartmentName)
        {
            //string sqlString = "select a.*,b.DepartmentName,c.RoleNo,d.RoleName " +
            string sqlString = "select a.autoID,a.loginID,a.empName,b.DepartmentName,d.RoleName,c.RoleNo " +
            "from BS_UserInfo a left join BS_Department b on a.DepartmentNo=b.DepartmentNo " +
            "left join BS_RoleUser c on a.AutoID=c.UserNo " +  //autoID是UserInfo表的关键字
            "left join BS_Role d on c.RoleNo=d.RoleNo " +
            "where convert(varchar(10),a.AutoID) like '%" + strUserID.Trim() + "%' "+
            "and a.LoginID like '%" + strLoginID.Trim() + "%' "+
            "and b.DepartmentName like '%" + strDepartmentName.Trim() + "%' " +
            "and a.EmpName like '%" + strUserName.Trim()+"%'";
            DataTable dtblTmp =new DataTable();
            dtblTmp = BaseSQL.GetTableBySql(sqlString);
            return dtblTmp;
        }
    }
}
