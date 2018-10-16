﻿using PSAP.DAO.BSDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP
{
    class BSCommon
    {
        /// <summary>
        /// 根据用户ID和窗口名称获得相应的窗口控件权限
        /// </summary>
        /// <param name="strUserNo"></param>
        /// <param name="strFormName"></param>
        /// <returns></returns>
        public static DataTable GetFormButtonRightData(string strUserNo, string strFormName,string strButtonName)
        {
            string sql =
                "select a.UserNo,b.*,c.FormName " +
                "from BS_UserMenuButton a " +
                "left join BS_MenuButton b on a.MenuButtonId = b.AutoId " +
                "left join BS_Menu c on b.MenuName = c.MenuName " +
                "where b.ButtonName <> 'menuItemFlag' and convert(varchar(20),a.UserNo) like '" + strUserNo + "' " +
                "and c.FormName like '" + strFormName + "' " +
                "and b.buttonName like '"+strButtonName+"'";
            DataTable dt = BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 获得部门列表
        /// </summary>
        /// <returns></returns>
        public static DataTable getDepartmentList()
        {
            string sqlString = "select distinct a.DepartmentName " +
            "from BS_Department a " +
            "union " +
            "select '' from BS_Department b ";
            DataTable dtblTmp = new DataTable();
            dtblTmp = BaseSQL.GetTableBySql(sqlString);
            return dtblTmp;
        }

        /// <summary>
        /// 获得角色列表
        /// </summary>
        /// <returns></returns>
        public static DataTable getRoleList()
        {
            string sqlString = "select distinct a.RoleNo,a.RoleName " +
            "from BS_Role a " +
            "union " +
            "select '','' from BS_Role b ";
            DataTable dtblTmp = new DataTable();
            dtblTmp = BaseSQL.GetTableBySql(sqlString);
            return dtblTmp;
        }
    }
}
