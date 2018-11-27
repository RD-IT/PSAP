﻿using PSAP.ENTITY.BSENTITY;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace PSAP.DAO.BSDAO
{
    class FrmLoginDAO
    {
        /// <summary>
        /// 更改密码
        /// </summary>
        /// <param name="strPassworNew"></param>
        /// <param name="strLoginId"></param>
        public static void ChangePassword(string strPassworNew,string strLoginId)
        {
            string sql= @"update BS_UserInfo set LoginPwd = '"+strPassworNew+"' where LoginId like '"+strLoginId+"'";
            BaseSQL.ExecuteSql(sql);

        }

        
        public static UserInfo CheckUser(string txtUserID, string txtPassword)
        {
            string sqlString = "select a.*,b.DepartmentName,c.RoleNo,d.RoleName " +
            "from BS_UserInfo a left join BS_Department b on a.DepartmentNo=b.DepartmentNo " +
            "left join BS_RoleUser c on a.AutoID=c.UserNo " +  //autoID是UserInfo表的关键字
            "left join BS_Role d on c.RoleNo=d.RoleNo " +
            "where a.LoginID='" + txtUserID + "' and a.LoginPwd='" + txtPassword + "'";
            DataSet ds = new DataSet();
            ds = BaseSQL.Query(sqlString);
            if (ds.Tables[0].Rows.Count > 0)
            {
                SystemInfo.user = new UserInfo();
                SystemInfo.user.DepartmentNo = ds.Tables[0].Rows[0]["DepartmentNo"].ToString();
                SystemInfo.user.EmpName = ds.Tables[0].Rows[0]["EmpName"].ToString();
                SystemInfo.user.LoginID = ds.Tables[0].Rows[0]["LoginID"].ToString();
                SystemInfo.user.DepartmentName = ds.Tables[0].Rows[0]["DepartmentNo"].ToString();
                SystemInfo.user.RoleNo = ds.Tables[0].Rows[0]["RoleNo"].ToString();
                SystemInfo.user.RoleName = ds.Tables[0].Rows[0]["RoleName"].ToString();
                SystemInfo.user.AutoId = (int)ds.Tables[0].Rows[0]["AutoId"];
                return SystemInfo.user;
            }
            else
            {
                return SystemInfo.user;
            }
        }
    }
}
