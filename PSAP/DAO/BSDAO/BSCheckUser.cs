using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using PSAP.ENTITY.BSENTITY;

namespace PSAP.DAO.BSDAO
{
    class BSCheckUser
    {
        public static UserInfo user;
        public static UserInfo CheckUser(string txtUserID, string txtPassword)
        {
            string sqlString = "select a.*,b.DepartmentName,c.RoleNo,d.RoleName " +
            "from BS_UserInfo a left join BS_Department b on a.DepartmentNo=b.DepartmentNo " +
            "left join BS_RoleUser c on a.AutoID=c.UserNo " +  //autoID是UserInfo表的关键字
            "left join BS_Role d on c.RoleNo=d.RoleNo " + 
            "where a.LoginID='" + txtUserID +"' and a.LoginPwd='" + txtPassword + "'";
            DataSet ds = new DataSet();
            ds = BaseSQL.Query(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
            {
                user=new UserInfo();
                user.DepartmentNo = ds.Tables[0].Rows[0]["DepartmentNo"].ToString();
                user.EmpName = ds.Tables[0].Rows[0]["EmpName"].ToString();
                user.LoginID = ds.Tables[0].Rows[0]["LoginID"].ToString();
                user.DepartmentName = ds.Tables[0].Rows[0]["DepartmentNo"].ToString();
                user.RoleNo= ds.Tables[0].Rows[0]["RoleNo"].ToString();
                user.RoleName = ds.Tables[0].Rows[0]["RoleName"].ToString();
                user.AutoId = (int)ds.Tables[0].Rows[0]["AutoId"];
                return user;
            }
            else
            {
                return user;
            }
        }
    }
}
