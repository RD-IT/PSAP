using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.DAO.BSDAO
{
    class FrmUserInfoDAO
    {
        public static ArrayList strSqlLlist = new ArrayList();//存储生成的SQL语句

        /// <summary>
        /// 删除与【用户信息】相关数据
        /// </summary>
        /// <param name="strRoleNo"></param>
        public static void DeleteUserInfoCorrelationData(int strUserNo)
        {
            strSqlLlist.Clear();
            string strSql = @"delete from BS_UserMenuButton where UserNo= " + strUserNo ;
            strSqlLlist.Add(strSql);

            strSql = @"delete from BS_RoleUser where UserNo= " + strUserNo ;
            strSqlLlist.Add(strSql);
            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }
    }
}
