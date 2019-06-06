using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace PSAP.DAO.BSDAO
{
    class FrmMainDAO
    {
        /// <summary>
        /// 获取一级菜单数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTopMenuData()
        {
            string sql = "select * from BS_Menu where ParentMenuName is null order by MenuOrder"; //一级菜单，其父菜单id为null
            DataTable dt = PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 获取子菜单数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetChildMenuData(string mname)
        {
            string sql = "select * from BS_Menu where ParentMenuName ='" + mname + "' order by MenuOrder";
            DataTable dt = PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);
            return dt;
        }


        /// <summary>
        /// 获取子菜单权限数据（角色）
        /// </summary>
        /// <returns></returns>
        public static DataTable GetChildMenuRoleRightData(string mname,string strRoleNo)
        {
            string sql = "select * from BS_Menu " +
                "where ParentMenuName ='" + mname + "'" +
                "and MenuName in (select MenuName from BS_RoleMenu where convert(varchar(20),RoleNo)='" + strRoleNo.Trim() + "')";
            DataTable dt = PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);
            return dt;
        }

        public DataTable QueryRoleMenu(string roleNoStr)
        {
            string sqlStr = string.Format("Select MenuName from BS_RoleMenu where RoleNo='{0}'", roleNoStr);
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 获取子菜单权限数据（个人）
        /// </summary>
        /// <returns></returns>
        public static DataTable GetChildMenuPersonalRightData(string mname, string strPersonalNo)
        {
            //根据父菜单项加载子菜单
            string sql = "select * from BS_Menu " +
                "where ParentMenuName ='" + mname + "'" +
                "and MenuName in (select b.MenuName from BS_UserMenuButton a inner join BS_MenuButton b "+
                "on a.MenuButtonId=b.AutoId where b.buttonName like 'menuItemFlag' "+
                    "and convert(varchar(20),a.UserNo)='" + strPersonalNo.Trim() + "')";
            DataTable dt = PSAP.DAO.BSDAO.BaseSQL.GetTableBySql(sql);
            return dt;
        }

        public DataTable QueryPersonalMenu(string personalNoStr)
        {
            string sqlStr = string.Format("select b.MenuName from BS_UserMenuButton a inner join BS_MenuButton b on a.MenuButtonId=b.AutoId where b.buttonName like 'menuItemFlag' and a.UserNo = '{0}'", personalNoStr);
            return BaseSQL.GetTableBySql(sqlStr);
        }
    }
}
