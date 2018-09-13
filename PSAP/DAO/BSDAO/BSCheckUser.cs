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
            string sqlString = "select a.*,b.departmentName " +
           "from BS_UserInfo a left join BS_Department b on a.departmentNo=b.departmentNo  " +
           "where a.loginID='" + txtUserID + "' and a.loginPwd='" + txtPassword + "'";
            DataSet ds = new DataSet();
            ds = BaseSQL.Query(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
            {
                user=new UserInfo();
                //foreach (DataRow dsR in ds.Tables[0].Rows)
                //{
                //    foreach (DataColumn dsC in ds.Tables[0].Columns)
                //    {
                user.DepartmentNo = ds.Tables[0].Rows[0]["DepartmentNo"].ToString();
                user.EmpName = ds.Tables[0].Rows[0]["EmpName"].ToString();
                user.LoginID = ds.Tables[0].Rows[0]["LoginID"].ToString();
                user.DepartmentName = ds.Tables[0].Rows[0]["DepartmentNo"].ToString();

                //    }
                //}

                //PSAPCommon.LoginInfo = ds.Tables[0].Rows[0];
                return user;
            }
            else
            {
                return user;
            }
        }
    }
}
