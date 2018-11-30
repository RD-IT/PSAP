using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.DAO.BSDAO
{
    class BSCommon
    {
        /// <summary>
        /// 根据用户ID和窗口名称获得相应的窗口控件权限
        /// </summary>
        /// <param name="strUserNo"></param>
        /// <param name="strFormName"></param>
        /// <returns></returns>
        public static DataTable GetFormButtonRightData(string strUserNo, string strFormName, string strButtonName)
        {
            string sql =
                "select a.UserNo,b.*,c.FormName " +
                "from BS_UserMenuButton a " +
                "left join BS_MenuButton b on a.MenuButtonId = b.AutoId " +
                "left join BS_Menu c on b.MenuName = c.MenuName " +
                "where b.ButtonName <> 'menuItemFlag' and convert(varchar(20),a.UserNo) like '" + strUserNo + "' " +
                "and c.FormName like '" + strFormName + "' " +
                "and b.buttonName like '" + strButtonName + "'";
            DataTable dt = BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 获得部门列表
        /// </summary>
        /// <returns></returns>
        public static DataTable getDepartmentList()
        {
            string sqlString = "select distinct a.DepartmentName,a.DepartmentNo " +
            "from BS_Department a " +
            "union " +
            "select '','' from BS_Department b ";
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

        /// <summary>
        /// 获得用户信息表
        /// </summary>
        /// <param name="strUserID"></param>
        /// <param name="strLoginID"></param>
        /// <param name="strUserName"></param>
        /// <param name="strDepartmentName"></param>
        /// <returns></returns>
        public static DataTable getUserInfoList(string strUserID, string strLoginID, string strUserName, string strDepartmentName)
        {
            string sqlString = "select a.autoID,a.loginID,a.empName,b.DepartmentName,d.RoleName,c.RoleNo " +
            "from BS_UserInfo a left join BS_Department b on a.DepartmentNo=b.DepartmentNo " +
            "left join BS_RoleUser c on a.AutoID=c.UserNo " +  //autoID是UserInfo表的关键字
            "left join BS_Role d on c.RoleNo=d.RoleNo " +
            "where convert(varchar(10),a.AutoID) like '%" + strUserID.Trim() + "%' " +
            "and a.LoginID like '%" + strLoginID.Trim() + "%' " +
            "and b.DepartmentName like '%" + strDepartmentName.Trim() + "%' " +
            "and a.EmpName like '%" + strUserName.Trim() + "%'";
            DataTable dtblTmp = new DataTable();
            dtblTmp = BaseSQL.GetTableBySql(sqlString);
            return dtblTmp;
        }

        public static DataTable getThemeInfo()
        {
            string n = PSAP.Properties.Settings.Default.ThemeId;
            string sqlString = "select a.ThemeId,b.ThemeDescribe,a.ControlName,a.ControlProperty,a.ControlValue,a.ControlType " +
            "from BS_ThemeDetail a left join BS_Theme b on a.ThemeId=b.AutoId " +
            "where convert(varchar(10),a.ThemeId) like '" + n + "' and a.ControlValue<>'-' ";
            DataTable dtblTmp = new DataTable();
            dtblTmp = BaseSQL.GetTableBySql(sqlString);
            return dtblTmp;
        }

        #region 多语言系统功能%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
        public static ArrayList strSqlLlist = new ArrayList();//存储生成的SQL语句

        /// <summary>
        /// 开始遍历系统控件文本
        /// </summary>
        public static void TraverseControlTextStart()
        {
            strSqlLlist.Clear();
        }

        /// <summary>
        /// 向sql语句组中增加接的sql语句(保存对界面控件文本的遍历结果)
        /// </summary>
        /// <param name="strFormName"></param>
        /// <param name="strButtonName"></param>
        /// <param name="strButtonText"></param>
        public static void TraverseControlTextAdd(string strFormName, string strControlsCategory, string strControlsName, string strCinese, string strControlsProperties)
        {
            string strSql = "insert into BS_LanguageSetting(FormName,ControlsCategory,ControlsName,Chinese,ControlsProperties) " +
                "select '" + strFormName + "','" + strControlsCategory + "','" + strControlsName + "','" + strCinese + "','" + strControlsProperties + "' " +
                "where '" + strFormName + strControlsName + strControlsProperties + "' not in (" +
                    "select FormName+ControlsName+ControlsProperties from BS_LanguageSetting)";
            strSqlLlist.Add(strSql);
            strSql = "update BS_LanguageSetting set Chinese='" + strCinese + "' " +
                "where FormName='" + strFormName + "' and ControlsName='" + strControlsName + "' and ControlsProperties='" + strControlsProperties + "'";
            strSqlLlist.Add(strSql);

        }

        /// <summary>
        /// 以事务方式执行拼接好的sql语句组(保存对界面控件文本的遍历结果)
        /// </summary>
        public static void TraverseControlTextSave()
        {
            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }

        /// <summary>
        /// 获得窗口语种设定数据
        /// </summary>
        /// <param name="strFormName"></param>
        /// <returns></returns>
        public static DataTable GetFormLanuageData(string strFormName)
        {
            string sql =
                "select AutoId,FormName,ControlsCategory,ControlsName,ControlsProperties," + SystemInfo.user.Lanuage + " as LanguageText " +
                "from BS_LanguageSetting " +
                "where FormName like '" + strFormName + "'";
            DataTable dt = BaseSQL.GetTableBySql(sql);
            return dt;

        }

        public static EnumerableRowCollection<DataRow> LocationControlsText(DataTable dt,string strControlsName,string strControlsProperties)
        {
            var TextValue = from dr1 in dt.AsEnumerable()
                            where dr1.Field<string>("ControlsName") == strControlsName
                                && dr1.Field<string>("ControlsProperties") == strControlsProperties
                            select dr1;
            return TextValue;
        }
        #endregion
    }
}
