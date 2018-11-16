using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAP.DAO.BSDAO
{
    class FrmDataQueryDesignDAO
    {
        public static ArrayList strSqlLlist = new ArrayList();//存储生成的SQL语句

        /// <summary>
        /// 获取根部门数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetTopQuerySqlData()
        {
            string sql = "select * from BS_QuerySql where ParentId is null order by ItemOrder "; //根部门，其父部门id为null
            DataTable dt = BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 获取子部门数据
        /// </summary>
        /// <returns></returns>
        public static DataTable GetChildQuerySqlData(string strParentId)
        {
            string sql = "select * from BS_QuerySql where convert(varchar(10),ParentId) ='" + strParentId + "' order by ItemOrder ";
            DataTable dt = BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 获取存储过程参数列表
        /// </summary>
        /// <param name="strProcedureName">存储过程名</param>
        /// <returns></returns>
        public static void CreateProcedureParaList(string strQuerySqlId, string strProcedureName)
        {
            strSqlLlist.Clear();
            string strSql =
            "delete from BS_QuerySqlParameter " +
            "where convert(varchar(10), querySqlId)='" + strQuerySqlId + "' " +
            "and parametersName + parametersCatg not in ( " +
                "select a.name + b.name " +
                "from syscolumns a " +
                "left join systypes b on a.xtype = b.xusertype " +
                "where id = (select id from sysobjects where upper(name) = '" + strProcedureName.ToUpper().Trim() + "')" +
                "and a.isoutparam = 0) ";
            strSqlLlist.Add(strSql);

            strSql =
              "insert into BS_QuerySqlParameter(QuerySqlId,ParametersText,ParametersName,ParametersCatg) " +
              "select '" + strQuerySqlId + "',a.name as paraText,a.name as paraName,b.name paraCatg " +
              "from syscolumns a " +
              "left  join systypes b on a.xtype = b.xusertype " +
              "where a.id = (select id from sysobjects where upper(name) = '" + strProcedureName.ToUpper().Trim() + "') " +
              "and '" + strQuerySqlId + "'+a.name+b.name not in ( " +
              "select convert(varchar(10), querySqlId)+parametersName+parametersCatg from BS_QuerySqlParameter) " +
              "and  a.isoutparam=0 ";
            strSqlLlist.Add(strSql);

            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }

        /// <summary>
        /// 执行存储过程
        /// </summary>
        /// <param name="strQuerySqlId">查询ID</param>
        /// <param name="strControlTmp">控件列表变量</param>
        /// <returns></returns>
        public static DataSet ExecUserProcedure(string strQuerySqlId, string[,] strControlTmp)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            dt = GetUserQueryInfo(strQuerySqlId);
            if (!string.IsNullOrEmpty(dt.Rows[0].ItemArray[6].ToString().Trim()))
            {
                int intRowCount = dt.Rows.Count;
                IDataParameter[] parameters = new System.Data.IDataParameter[intRowCount];//实例化参数对象
                for (int i = 0; i < intRowCount; i++)
                {
                    //string reval = string.Empty;
                    string strParaName = dt.Rows[i].ItemArray[6].ToString();
                    switch (strControlTmp[i, 2].ToLower())
                    {
                        case "int":
                            //reval = "Int32";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Int);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToInt32(strControlTmp[i, 1]);
                            break;
                        case "text":
                            //reval = "String";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Text);//参数对象赋值 
                            parameters[i].Value = Convert.ToString(strControlTmp[i, 1]);
                            break;
                        case "bigint":
                            //reval = "Int64";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.BigInt);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToInt64(strControlTmp[i, 1]);
                            break;
                        case "binary":
                            //reval = "System.Byte[]";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Binary);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToByte(strControlTmp[i, 1]);
                            break;
                        case "bit":
                            //reval = "Boolean";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Bit);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToBoolean(strControlTmp[i, 1]);
                            break;
                        case "char":
                            //reval = "String";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Char);//参数对象赋值 
                            parameters[i].Value = Convert.ToString(strControlTmp[i, 1]);
                            break;
                        case "datetime":
                            //reval = "System.DateTime";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.DateTime);//参数对象赋值 
                            parameters[i].Value = Convert.ToDateTime(strControlTmp[i, 1]);
                            break;
                        case "decimal":
                            //reval = "System.Decimal";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Decimal);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToDecimal(strControlTmp[i, 1]);
                            break;
                        case "float":
                            //reval = "System.Double";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Float);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToDouble(strControlTmp[i, 1]);
                            break;
                        case "image":
                            //reval = "System.Byte[]";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Image);//参数对象赋值 
                            parameters[i].Value = Convert.ToByte(strControlTmp[i, 1]);
                            break;
                        case "money":
                            //reval = "System.Decimal";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Money);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToDecimal(strControlTmp[i, 1]);
                            break;
                        case "nchar":
                            //reval = "String";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.NChar);//参数对象赋值 
                            parameters[i].Value = Convert.ToString(strControlTmp[i, 1]);
                            break;
                        case "ntext":
                            //reval = "String";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.NText);//参数对象赋值 
                            parameters[i].Value = Convert.ToString(strControlTmp[i, 1]);
                            break;
                        case "numeric":
                            //reval = "System.Decimal";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Decimal);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToDecimal(strControlTmp[i, 1]);
                            break;
                        case "nvarchar":
                            //reval = "String";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.NVarChar);//参数对象赋值 
                            parameters[i].Value = Convert.ToString(strControlTmp[i, 1]);
                            break;
                        case "real":
                            //reval = "System.Single";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Real);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToSingle(strControlTmp[i, 1]);
                            break;
                        case "smalldatetime":
                            //reval = "System.DateTime";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.SmallDateTime);//参数对象赋值 
                            parameters[i].Value = Convert.ToDateTime(strControlTmp[i, 1]);
                            break;
                        case "smallint":
                            //reval = "Int16";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.SmallInt);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToInt16(strControlTmp[i, 1]);
                            break;
                        case "smallmoney":
                            //reval = "System.Decimal";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.SmallMoney);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToDecimal(strControlTmp[i, 1]);
                            break;
                        case "timestamp":
                            //reval = "System.DateTime";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Timestamp);//参数对象赋值 
                            parameters[i].Value = Convert.ToDateTime(strControlTmp[i, 1]);
                            break;
                        case "tinyint":
                            //reval = "System.Byte";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.TinyInt);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToByte(strControlTmp[i, 1]);
                            break;
                        case "varbinary":
                            //reval = "System.Byte[]";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.VarBinary);//参数对象赋值 
                            parameters[i].Value = string.IsNullOrEmpty(strControlTmp[i, 1]) ? null : (object)Convert.ToByte(strControlTmp[i, 1]);
                            break;
                        case "varchar":
                            //reval = "String";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.VarChar);//参数对象赋值 
                            parameters[i].Value = Convert.ToString(strControlTmp[i, 1]);
                            break;
                        case "Variant":
                            //reval = "Object";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.Variant);//参数对象赋值 
                            parameters[i].Value = (object)(strControlTmp[i, 1]);
                            break;
                        default:
                            //reval = "String";
                            parameters[i] = new SqlParameter(strParaName, SqlDbType.VarChar);//参数对象赋值 
                            parameters[i].Value = Convert.ToString(strControlTmp[i, 1]);
                            break;
                    }
                }
                ds = BaseSQL.RunProcedure(Convert.ToString(dt.Rows[0].ItemArray[3]).Trim(), parameters, "dd");//执行存储过程
                return ds;
            }
            return null;
        }

        /// <summary>
        /// 获得查询信息列表
        /// </summary>
        /// <param name="strQuerySqlId">查询ID</param>
        /// <returns></returns>
        public static DataTable GetUserQueryInfo(string strQuerySqlId)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string strSql =
            "select a.AutoId,a.ParentId,a.QueryText,a.QuerySql,a.Reamrks,b.ParametersText,b.ParametersName,b.ParametersCatg " +
            "from BS_QuerySql a left join BS_QuerySqlParameter b on a.AutoId=b.QuerySqlId " +
            "where a.AutoId ='" + strQuerySqlId + "'and a.ParentId is not null ";
            dt = BaseSQL.GetTableBySql(strSql);
            return dt;
        }

        /// <summary>
        /// 获得查询结果Tab信息列表
        /// </summary>
        /// <param name="strQuerySqlId">查询ID</param>
        /// <returns></returns>
        public static DataTable GetUserQueryTabsInfo(string strQuerySqlId)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string strSql =
            "select a.AutoId,a.ParentId,a.QueryText,a.QuerySql,a.Reamrks,b.TabText,b.TabRemark,b.AutoId " +
            "from BS_QuerySql a left join BS_DataSetting b on a.AutoId=b.QuerySql " +
            "where a.AutoId ='" + strQuerySqlId + "'and a.ParentId is not null ";
            dt = BaseSQL.GetTableBySql(strSql);
            return dt;
        }

        /// <summary>
        /// 更新Tab文本
        /// </summary>
        /// <param name="iQuerySqlId">查询ID</param>
        /// <param name="iTabIndex">Tab索引</param>
        /// <param name="strTabText">Tab文本</param>
        public static void UpdateTabText(int iQuerySqlId, int iTabIndex, string strTabText)
        {
            string strSql =
            "update BS_DataSetting set TabText='" + strTabText + "' " +
            "where QuerySQl=" + iQuerySqlId + " and TabIndex= " + iTabIndex;
            BaseSQL.ExecuteSql(strSql);
        }

        /// <summary>
        /// 更新Tab说明
        /// </summary>
        /// <param name="iQuerySqlId"></param>
        /// <param name="iTabIndex"></param>
        /// <param name="strTabRemarks"></param>
        public static void UpdateTabRemarks(int iQuerySqlId, int iTabIndex, string strTabRemarks)
        {
            string strSql =
            "update BS_DataSetting set TabRemark= '" + strTabRemarks + "' " +
            "where QuerySQl=" + iQuerySqlId + " and TabIndex= " + iTabIndex;
            BaseSQL.ExecuteSql(strSql);
        }

        /// <summary>
        /// 初始化Tab信息
        /// </summary>
        /// <param name="iQuerySqlId"></param>
        /// <param name="iTabIndex"></param>
        /// <param name="strTabText"></param>
        /// <param name="strTabRemarks"></param>
        public static void InitTabInfo(int iQuerySqlId, int iTabIndex, string strTabText, string strTabRemarks)
        {
            string strSql =
            "insert into BS_DataSetting(QuerySql,TabIndex,TabText,TabRemark) " +
            "select " + iQuerySqlId + "," + iTabIndex + ",'" + strTabText + "','" + strTabRemarks + "' " +
            "where '" + iQuerySqlId.ToString() + iTabIndex.ToString() + "' not in (" +
            "select convert(varchar(10),QuerySql)+convert(varchar(10),TabIndex) from BS_DataSetting)";
            BaseSQL.ExecuteSql(strSql);
        }

        //ooooooooooooooooooo

        /// <summary>
        /// 获取DataSetting表的ID
        /// </summary>
        /// <param name="iQuerySqlId"></param>
        /// <param name="iTabIndex"></param>
        /// <returns></returns>
        public static int GetDataSettingId(int iQuerySqlId, int iTabIndex)
        {
            string strSql =
                "select AutoId from BS_DataSetting where querySql=" + iQuerySqlId + " and tabIndex=" + iTabIndex;
            DataTable dt = new DataTable();
            dt = BaseSQL.GetTableBySql(strSql);
            return Convert.ToInt16(dt.Rows[0].ItemArray[0]);
        }

        /// <summary>
        /// 1.新建TmpColumns临时表
        /// </summary>
        public static void CreateColumnsTempTable()
        {
            strSqlLlist.Clear();
            string strSql = @"if object_id(N'tmpColumns', N'U') is not null drop table tmpColumns";
            strSqlLlist.Add(strSql);
            strSql = @"create table tmpColumns(HeaderName varchar(100) null,HeaderText varchar(100) null)";
            strSqlLlist.Add(strSql);

        }

        /// <summary>
        /// 2.向临时表中加入表的字段名信息
        /// </summary>
        /// <param name="strHeaderName"></param>
        /// <param name="strHeaderText"></param>
        public static void insertHeaderInfo(string strHeaderName, string strHeaderText)
        {
            string strSql = @"insert into tmpColumns(HeaderName,HeaderText) values('" + strHeaderName + "','" + strHeaderText + "')";
            strSqlLlist.Add(strSql);
        }

        /// <summary>
        /// 3.执行事务
        /// </summary>
        public static void ExecSqlTran()
        {
            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }

        /// <summary>
        /// 4.初始化DataHeaderSetting表
        /// </summary>
        /// <param name="iQuerySqlId"></param>
        /// <param name="iTabIndex"></param>
        public static void InitHeaderSetting(int iQuerySqlId, int iTabIndex)
        {
            strSqlLlist.Clear();
            string strSql =
            "delete from BS_DataHeaderSetting " +
            "where DataSetting not in (select AutoId from BS_DataSetting) ";
            strSqlLlist.Add(strSql);

            int iTmp = GetDataSettingId(iQuerySqlId, iTabIndex);
            //strSql =
            //"delete from BS_DataHeaderSetting  " +
            //"where dataSetting= " + iTmp + " " +
            //"and HeaderName not in (select HeaderName from tmpColumns)";
            //strSqlLlist.Add(strSql);

            strSql = "insert into BS_DataHeaderSetting(QuerySql,DataSetting,HeaderName,HeaderText) " +
                       "select " + iQuerySqlId + "," + iTmp + ",HeaderName,HeaderText from tmpColumns where '" + iQuerySqlId.ToString() + iTmp.ToString() + "'+HeaderName not in (select convert(varchar(10),querySql)+convert(varchar(10),dataSetting)+headerName from BS_DataHeaderSetting) ";
            strSqlLlist.Add(strSql);

            strSql = @"drop table tmpColumns ";//删除建立的临时表
            strSqlLlist.Add(strSql);
            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }

        /// <summary>
        /// 删除查询表相关数据
        /// </summary>
        /// <param name="iQuerySqlId"></param>
        public static void DeleteQueryCorrelationData(int iQuerySqlId)
        {
            strSqlLlist.Clear();
            string strSql =
            "delete from BS_DataHeaderSetting where QuerySql=" + iQuerySqlId;
            strSqlLlist.Add(strSql);

            strSql =
            "delete from BS_DataSetting where QuerySql=" + iQuerySqlId;
            strSqlLlist.Add(strSql);

            strSql =
            "delete from BS_QuerySqlParameter where QuerySqlId=" + iQuerySqlId;
            strSqlLlist.Add(strSql);

            BaseSQL.ExecuteSqlTran(strSqlLlist);
        }

        /// <summary>
        ///  获取表顶层标题数据
        /// </summary>
        /// <param name="iQuerySqlId"></param>
        /// <param name="iTabIndex"></param>
        /// <returns></returns>
        public static DataTable GetTopTableHeaderData(int iQuerySqlId, int iTabIndex)
        {
            int iTmp = GetDataSettingId(iQuerySqlId, iTabIndex);
            string sql = "select * from BS_DataHeaderSetting where ParentHeaderName is null " +
                "and QuerySql=" + iQuerySqlId + " and DataSetting=" + iTmp;

            DataTable dt = BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 获取表子标题数据
        /// </summary>
        /// <param name="strParentHeaderName"></param>
        /// <param name="iQuerySqlId"></param>
        /// <param name="iTabIndex"></param>
        /// <returns></returns>
        public static DataTable GetChildTableHeaderData(string strParentHeaderName, int iQuerySqlId, int iTabIndex)
        {
            int iTmp = GetDataSettingId(iQuerySqlId, iTabIndex);
            string sql = "select * from BS_DataHeaderSetting " +
                "where ParentHeaderName='" + strParentHeaderName + "'" +
                "and QuerySql=" + iQuerySqlId + " and DataSetting=" + iTmp;

            DataTable dt = BaseSQL.GetTableBySql(sql);
            return dt;
        }

        /// <summary>
        /// 将删除节点操作同步到数据库
        /// </summary>
        /// <param name="iQuerySqlId"></param>
        /// <param name="iDataSetting"></param>
        /// <param name="strHeaderName"></param>
        public static void saveDeleteNode(int iQuerySqlId, int iDataSetting, string strHeaderName)
        {
            string sql = "delete from BS_DataHeaderSetting " +
                "where QuerySql=" + iQuerySqlId + " and DataSetting=" + iDataSetting + " and HeaderName='" + strHeaderName + "'";
            BaseSQL.ExecuteSql(sql);
        }

        /// <summary>
        /// 将新建的根节点数据保存到数据库中
        /// </summary>
        /// <param name="iQuerySqlId"></param>
        /// <param name="iDataSetting"></param>
        /// <param name="strHeaderName"></param>
        /// <param name="strHeaderText"></param>
        public static void saveCreateRootNode(int iQuerySqlId, int iDataSetting, string strHeaderName, string strHeaderText)
        {
            string sql = "insert into BS_DataHeaderSetting(QuerySql,DataSetting,HeaderName,HeaderText) " +
                "values(" + iQuerySqlId + "," + iDataSetting + ",'" + strHeaderName + "','" + strHeaderText + "')";
            BaseSQL.ExecuteSql(sql);
        }
        /// <summary>
        /// 将新建的子节点数据保存到数据库中（与插入节点通用）
        /// </summary>
        /// <param name="iQuerySqlId"></param>
        /// <param name="iDataSetting"></param>
        /// <param name="strHeaderName"></param>
        /// <param name="strHeaderText"></param>
        /// <param name="strParentHeaderName"></param>
        public static void saveCreateChildNode(int iQuerySqlId, int iDataSetting, string strHeaderName, string strHeaderText,string strParentHeaderName)
        {
            string sql = "insert into BS_DataHeaderSetting(QuerySql,DataSetting,HeaderName,HeaderText,ParentHeaderName) " +
                "values(" + iQuerySqlId + "," + iDataSetting + ",'" + strHeaderName + "','" + strHeaderText + "','"+strParentHeaderName+"')";
            BaseSQL.ExecuteSql(sql);
        }

        public static void saveLabelEdit(int iQuerySqlId, int iDataSetting, string strHeaderName,string strHeaderText)
        {
            string sql = "update BS_DataHeaderSetting set HeaderText='" + strHeaderText+"' " +
                "where QuerySql=" + iQuerySqlId + " and DataSetting=" + iDataSetting + " and HeaderName='" + strHeaderName + "'";
            BaseSQL.ExecuteSql(sql);
        }

    }
}
