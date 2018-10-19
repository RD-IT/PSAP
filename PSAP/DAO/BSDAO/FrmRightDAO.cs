using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace PSAP.DAO.BSDAO
{
    class FrmRightDAO
    {
        public static ArrayList strSqlLlist = new ArrayList();//存储生成的SQL语句
        /// <summary>
        /// 新建button临时表
        /// </summary>
        /// <param name="strSql"></param>
        public static void CreateButtonsTempTable()
        {
            string strSql = @"if object_id(N'tmpButton', N'U') is not null drop table tmpButton";
            strSqlLlist.Add(strSql);
            strSql = @"create table tmpButton(formName varchar(100) null,btnText varchar(100) null,btnName varchar(100) null)";
            strSqlLlist.Add(strSql);

        }

        /// <summary>
        /// 向sql语句组中增加接的sql语句
        /// </summary>
        /// <param name="strFormName"></param>
        /// <param name="strButtonName"></param>
        /// <param name="strButtonText"></param>
        public static void AddSqlStatement(string strFormName, string strButtonName, string strButtonText)
        {
            string strSql = @"insert into tmpButton(formName,btnText,btnName) values('" + strFormName + "','" + strButtonText + "','" + strButtonName + "')";
            strSqlLlist.Add(strSql);
        }

        /// <summary>
        /// 以事务方式执行拼接好的sql语句组
        /// </summary>
        public static void RunSqlStatement()
        {
            BaseSQL.ExecuteSqlTran(strSqlLlist);
            IDataParameter[] parameters = new System.Data.IDataParameter[1];//实例化参数对象
            parameters[0] = new SqlParameter("@returnMessage", string.Empty);//参数对象赋值 
            BaseSQL.RunProcedure("FrmRight_RefreshButtonInfo", parameters);//执行存储过程，刷新button相关表
        }

        /// <summary>
        /// 获得MenuButtonId
        /// </summary>
        /// <param name="strMenuName"></param>
        /// <param name="strButtonName"></param>
        /// <returns></returns>
        public static int GetMenuButtonId(string strMenuName, string strButtonName)
        {
            string strSql = @"select autoId from BS_MenuButton " +
                            "where menuName like '" + strMenuName + "' and buttonName like '" + strButtonName + "'";
            DataTable dt = new DataTable();
            dt = BaseSQL.GetTableBySql(strSql);
            return (int)dt.Rows[0]["AutoId"];

        }

        /// <summary>
        /// 将设定的个人权限保存到数据库中（向sql语句组中增加sql语句）
        /// </summary>
        /// <param name="strUserNo"></param>
        /// <param name="intMenuButtonId"></param>
        public static void AddSqlStatement_SaveUserMenuButton(int intUserNo, int intMenuButtonId)
        {
            string strSql = @"insert into BS_UserMenuButton(userNo,menuButtonId) values(" + intUserNo + "," + intMenuButtonId + ") ";
            strSqlLlist.Add(strSql);
        }

        /// <summary>
        /// 以事务方式执行拼接好的sql语句组
        /// </summary>
        public static void RunSqlStatement_SaveUserMenuButton(int intUserNo)
        {
            string strSql = @"delete from BS_UserMenuButton where userNo= " + intUserNo + " ";
            strSqlLlist.Insert(0, strSql);
            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }


        /// <summary>
        /// 根据用户ID获得每个菜单项对应的按钮权限
        /// </summary>
        /// <param name="intUserNo"></param>
        /// <param name="strMenuName"></param>
        /// <returns></returns>
        public static DataTable GetButtonPersonalRightData(string strUserNo, string strMenuName)
        {
            string sql =
                "select a.UserNo,b.* " +
                "from BS_UserMenuButton a left " +
                "join BS_MenuButton b on a.MenuButtonId = b.AutoId " +
                "where b.ButtonName <> 'menuItemFlag' and convert(varchar(20),a.UserNo) like '" + strUserNo + "' and b.MenuName like '" + strMenuName + "'";
            DataTable dt = BSDAO.BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 将设定的角色权限保存到数据库中（向sql语句组中增加sql语句）
        /// </summary>
        /// <param name="strUserNo"></param>
        /// <param name="intMenuButtonId"></param>
        public static void AddSqlStatement_SaveRoleMenuButton(string strRoleNo, string strMenuName)
        {
            string strSql = @"insert into BS_RoleMenu(RoleNo,MenuName) values('" + strRoleNo + "','" + strMenuName + "') ";
            strSqlLlist.Add(strSql);
        }

        /// <summary>
        /// 保存角色权限（执行事务）
        /// </summary>
        public static void RunSqlStatement_SaveRoleMenuButton(string strRoleNo)
        {
            string strSql = @"delete from BS_RoleMenu where RoleNo= '" + strRoleNo + "' ";
            strSqlLlist.Insert(0, strSql);
            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }

        /// <summary>
        /// 保存为用户设定的角色
        /// </summary>
        public static void SaveRoleUser(string strRoleNo, int intUserNo)
        {
            strSqlLlist.Clear();
            string strSql = @"delete from BS_RoleUser where UserNo= " + intUserNo + " ";
            strSqlLlist.Insert(0, strSql);
            strSql = @"insert into BS_RoleUser(RoleNo,UserNo) values('" + strRoleNo + "'," + intUserNo + ") ";
            strSqlLlist.Add(strSql);

            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }

        /// <summary>
        ///给予角色权限对应窗口所有“按钮”的权限 
        /// </summary>
        public static void GiveRoleAllButtonRight()
        {
            string strSql = @"insert into BS_UserMenuButton(UserNo,MenuButtonId) " +
                            "select a.UserNo,c.AutoId MenuButtonId " +
                            "from BS_RoleUser a " +
                            "left join BS_RoleMenu b on a.RoleNo=b.RoleNo " +
                            "left join BS_MenuButton c on b.MenuName=c.MenuName " +
                            "where convert(varchar(30),a.UserNo)+CONVERT(varchar(30),c.AutoId) not in " +
                            "		(select convert(varchar(30),a.UserNo)+CONVERT(varchar(30),c.AutoId) " +
                            "		from BS_UserMenuButton) ";

            BaseSQL.ExecuteSql(strSql);
        }
        /// <summary>
        /// 删除与【菜单】相关数据
        /// </summary>
        public static void DeleteMenuCorrelationData(string strMenuName)
        {
            strSqlLlist.Clear();
            string strSql = @"delete from BS_UserMenuButton  " +
                            "where MenuButtonId in " +
                            "(select a1.AutoId from BS_MenuButton a1 where a1.MenuName like '" + strMenuName + "')";
            strSqlLlist.Add(strSql);

            strSql = @"delete from BS_MenuButton where MenuName like '" + strMenuName + "'";
            strSqlLlist.Add(strSql);

            strSql = @"delete from BS_RoleMenu where MenuName like '" + strMenuName + "'";
            strSqlLlist.Add(strSql);
            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }

        /// <summary>
        /// 删除与【角色】相关数据
        /// </summary>
        /// <param name="strRoleNo"></param>
        public static void DeleteRoleCorrelationData(string strRoleNo)
        {
            strSqlLlist.Clear();
            string strSql = @"delete from BS_RoleMenu where RoleNo like '" + strRoleNo + "'";
            strSqlLlist.Add(strSql);

            strSql = @"delete from BS_RoleUser where RoleNo like '" + strRoleNo + "'";
            strSqlLlist.Add(strSql);
            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }

        /// <summary>
        /// 刷新BS_MenuButton表
        /// </summary>
        /// <param name="strMenuName"></param>
        public static void RefreshMenuButton(string strMenuName)
        {
            string sql = @"insert into BS_MenuButton(MenuName, ButtonName) " +
                        "select distinct '" + strMenuName + "','menuItemFlag' " +
                        "from BS_MenuButton " +
                        "where '" + strMenuName + "'+'menuItemFlag' not in(select menuName + buttonName from BS_MenuButton)";
            BaseSQL.ExecuteSql(sql);
        }
    }
}
