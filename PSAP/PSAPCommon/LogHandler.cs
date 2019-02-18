using PSAP.DAO.BSDAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.PSAPCommon
{
    public class LogHandler
    {
        /// <summary>
        /// 事务记录日志
        /// </summary>
        /// <param name="logStr">日志内容</param>
        public static void RecordLog(SqlCommand cmd, string logStr)
        {
            //cmd.CommandText = "insert into LogTable...";
        }

        /// <summary>
        /// 非事务直接记录日志
        /// </summary>
        /// <param name="logStr">日志内容</param>
        public static void RecordLog(string logStr)
        {
            //string sqlStr = "insert into LogTable...";
            //BaseSQL.ExecuteSql(sqlStr);
        }

        /// <summary>
        /// 记录绑定的DataTable里面变化的数据的日志
        /// </summary>
        /// <param name="tableCaption">数据表的中文标题</param>
        /// <param name="dataTable_NoHandle">未处理的DataTable</param>
        /// <param name="primaryKeyColumn">主键列名</param>
        public static string RecordLog_DataTable(SqlCommand cmd, string tableCaption, DataTable dataTable_NoHandle, string primaryKeyColumn)
        {
            string partLogStr = "";
            string typeStr = "";
            string pkCaption = "";
            string pkValue = "";
            for (int i = 0; i < dataTable_NoHandle.Rows.Count; i++)
            {
                DataRow dr = dataTable_NoHandle.Rows[i];
                if (dr.RowState == DataRowState.Added)
                {
                    for (int j = 0; j < dataTable_NoHandle.Columns.Count; j++)
                    {
                        if (dataTable_NoHandle.Columns[j].ColumnName == primaryKeyColumn)
                        {
                            pkCaption = dataTable_NoHandle.Columns[j].Caption;
                            pkValue = DataTypeConvert.GetString(dr[j]);
                            continue;
                        }
                        string tmpValue = DataTypeConvert.GetString(dr[j]);
                        if (tmpValue != "")
                            partLogStr += string.Format("{0}的值为[{1}]，", dataTable_NoHandle.Columns[j].Caption, tmpValue);
                    }
                    typeStr = "新增";
                }
                else if (dr.RowState == DataRowState.Modified)
                {
                    for (int j = 0; j < dataTable_NoHandle.Columns.Count; j++)
                    {
                        if (dataTable_NoHandle.Columns[j].ColumnName == primaryKeyColumn)
                        {
                            pkCaption = dataTable_NoHandle.Columns[j].Caption;
                            pkValue = DataTypeConvert.GetString(dr[j]);
                            continue;
                        }

                        string oldValue = DataTypeConvert.GetString(dr[j, DataRowVersion.Original]);
                        string newValue = DataTypeConvert.GetString(dr[j, DataRowVersion.Current]);
                        if (oldValue != newValue)
                            partLogStr += string.Format("{0}的值由[{1}]变为[{2}]，", dataTable_NoHandle.Columns[j].Caption, oldValue, newValue);
                    }
                    typeStr = "修改";
                }
                else if (dr.RowState == DataRowState.Deleted)
                {
                    for (int j = 0; j < dataTable_NoHandle.Columns.Count; j++)
                    {
                        if (dataTable_NoHandle.Columns[j].ColumnName == primaryKeyColumn)
                        {
                            pkCaption = dataTable_NoHandle.Columns[j].Caption;
                            pkValue = DataTypeConvert.GetString(dr[j, DataRowVersion.Original]);
                            continue;
                        }

                        string tmpValue = DataTypeConvert.GetString(dr[j, DataRowVersion.Original]);
                        if (tmpValue != "")
                            partLogStr += string.Format("{0}的原值为[{1}]，", dataTable_NoHandle.Columns[j].Caption, tmpValue);
                    }
                    typeStr = "删除";
                }
            }

            string logStr = string.Format("对[{0}]表进行[{1}]操作：主键[{2}]的值为[{3}]，{4}", tableCaption, typeStr, pkCaption, pkValue, partLogStr);
            //MessageHandler.ShowMessageBox(logStr);
            RecordLog(cmd, logStr);
            return logStr;
        }

        /// <summary>
        /// 记录绑定的DataRow里面变化的数据的日志
        /// </summary>
        /// <param name="tableCaption">数据表的中文标题</param>
        /// <param name="Row_NoHandle">未处理的DataRow</param>
        /// <param name="primaryKeyColumn">主键列名</param>
        public static string RecordLog_DataRow(SqlCommand cmd, string tableCaption, DataRow Row_NoHandle, string primaryKeyColumn)
        {
            if (Row_NoHandle.RowState == DataRowState.Unchanged)
                return "";

            string partLogStr = "";
            string typeStr = "";
            string pkCaption = "";
            string pkValue = "";
            if (Row_NoHandle.RowState == DataRowState.Added)
            {
                for (int j = 0; j < Row_NoHandle.Table.Columns.Count; j++)
                {
                    if (Row_NoHandle.Table.Columns[j].ColumnName == primaryKeyColumn)
                    {
                        pkCaption = Row_NoHandle.Table.Columns[j].Caption;
                        pkValue = DataTypeConvert.GetString(Row_NoHandle[j]);
                        continue;
                    }
                    string tmpValue = DataTypeConvert.GetString(Row_NoHandle[j]);
                    if (tmpValue != "")
                        partLogStr += string.Format("{0}的值为[{1}]，", Row_NoHandle.Table.Columns[j].Caption, tmpValue);
                }
                typeStr = "新增";
            }
            else if (Row_NoHandle.RowState == DataRowState.Modified)
            {
                for (int j = 0; j < Row_NoHandle.Table.Columns.Count; j++)
                {
                    if (Row_NoHandle.Table.Columns[j].ColumnName == primaryKeyColumn)
                    {
                        pkCaption = Row_NoHandle.Table.Columns[j].Caption;
                        pkValue = DataTypeConvert.GetString(Row_NoHandle[j]);
                        continue;
                    }

                    string oldValue = DataTypeConvert.GetString(Row_NoHandle[j, DataRowVersion.Original]);
                    string newValue = DataTypeConvert.GetString(Row_NoHandle[j, DataRowVersion.Current]);
                    if (oldValue != newValue)
                        partLogStr += string.Format("{0}的值由[{1}]变为[{2}]，", Row_NoHandle.Table.Columns[j].Caption, oldValue, newValue);
                }
                typeStr = "修改";
            }
            else if (Row_NoHandle.RowState == DataRowState.Deleted)
            {
                for (int j = 0; j < Row_NoHandle.Table.Columns.Count; j++)
                {
                    if (Row_NoHandle.Table.Columns[j].ColumnName == primaryKeyColumn)
                    {
                        pkCaption = Row_NoHandle.Table.Columns[j].Caption;
                        pkValue = DataTypeConvert.GetString(Row_NoHandle[j, DataRowVersion.Original]);
                        continue;
                    }

                    string tmpValue = DataTypeConvert.GetString(Row_NoHandle[j, DataRowVersion.Original]);
                    if (tmpValue != "")
                        partLogStr += string.Format("{0}的原值为[{1}]，", Row_NoHandle.Table.Columns[j].Caption, tmpValue);
                }
                typeStr = "删除";
            }
            string logStr = string.Format("对[{0}]表进行[{1}]操作：主键[{2}]的值为[{3}]，{4}", tableCaption, typeStr, pkCaption, pkValue, partLogStr);
            //MessageHandler.ShowMessageBox(logStr);
            RecordLog(cmd, logStr);
            return logStr;
        }

        /// <summary>
        /// 记录删除DataRow数据的日志
        /// </summary>
        /// <param name="tableCaption">数据表的中文标题</param>
        /// <param name="Row_NoHandle">未处理的DataRow</param>
        /// <param name="primaryKeyColumn">主键列名</param>
        public static string RecordLog_DeleteRow(SqlCommand cmd, string tableCaption, DataRow Row_NoHandle, string primaryKeyColumn)
        {
            string partLogStr = "";
            string typeStr = "删除";
            string pkCaption = "";
            string pkValue = "";
            for (int j = 0; j < Row_NoHandle.Table.Columns.Count; j++)
            {
                if (Row_NoHandle.Table.Columns[j].ColumnName == primaryKeyColumn)
                {
                    pkCaption = Row_NoHandle.Table.Columns[j].Caption;
                    pkValue = DataTypeConvert.GetString(Row_NoHandle[j, DataRowVersion.Original]);
                    continue;
                }

                string tmpValue = DataTypeConvert.GetString(Row_NoHandle[j, DataRowVersion.Original]);
                if (tmpValue != "")
                    partLogStr += string.Format("{0}的原值为[{1}]，", Row_NoHandle.Table.Columns[j].Caption, tmpValue);
            }
            string logStr = string.Format("对[{0}]表进行[{1}]操作：主键[{2}]的值为[{3}]，{4}", tableCaption, typeStr, pkCaption, pkValue, partLogStr);
            RecordLog(cmd, logStr);
            return logStr;
        }

        /// <summary>
        /// 记录操作DataRow数据的日志
        /// </summary>
        /// <param name="tableCaption">数据表的中文标题</param>
        /// <param name="Row_NoHandle">未处理的DataRow</param>
        /// <param name="primaryKeyColumn">主键列名</param>
        /// <param name="OpType">操作类型：审批，取消审批，关闭等</param>
        /// <param name="OpUser">操作人员</param>
        /// <param name="OpTime">操作时间</param>
        public static string RecordLog_OperateRow(SqlCommand cmd, string tableCaption, DataRow Row_NoHandle, string primaryKeyColumn, string OpType, string OpUser, string OpTime)
        {
            string pkCaption = Row_NoHandle.Table.Columns[primaryKeyColumn].Caption;
            string pkValue = DataTypeConvert.GetString(Row_NoHandle[primaryKeyColumn]);
            string logStr = string.Format("对[{0}]表进行[{1}]操作：主键[{2}]的值为[{3}]，操作员为[{4}]，操作时间为[{5}]", tableCaption, OpType, pkCaption, pkValue, OpUser, OpTime);
            RecordLog(cmd, logStr);
            return logStr;
        }

    }
}
