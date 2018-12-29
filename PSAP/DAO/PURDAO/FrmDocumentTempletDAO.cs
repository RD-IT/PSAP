﻿using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.DAO.PURDAO
{
    class FrmDocumentTempletDAO
    {
        /// <summary>
        /// 查询单据模板表
        /// </summary>
        /// <returns></returns>
        public DataTable QueryDocTemplet()
        {
            string sqlStr = "select AutoId, ParentId, ModuleName, TableName, DocFileName, DocPath from BS_DocumentTemplet";
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询某个单据模板
        /// </summary>
        public DataTable QueryDocTemplet(string tableNameStr)
        {
            string sqlStr = string.Format("select ModuleName, TableName, DocFileName, DocPath, DocVersion from BS_DocumentTemplet where TableName = '{0}'", tableNameStr);
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 更新某个单据模板
        /// </summary>
        public bool UpdateDocTemplet_File(string tableNameStr)
        {
            string sqlStr = string.Format("select * from BS_DocumentTemplet where TableName = '{0}'", tableNameStr);
            DataTable docTempletTable = BaseSQL.GetTableBySql(sqlStr);
            if (docTempletTable.Rows.Count != 1)
            {
                MessageHandler.ShowMessageBox("未查询到当前表的模板记录，操作错误。");
                return false;
            }
            string docPathStr = DataTypeConvert.GetString(docTempletTable.Rows[0]["DocPath"]) + DataTypeConvert.GetString(docTempletTable.Rows[0]["DocFileName"]);
            string oldDocVerStr = DataTypeConvert.GetString(docTempletTable.Rows[0]["DocVersion"]);

            if (!File.Exists(docPathStr))
                return false;

            long streamLength = 0;
            Byte[] buffer = FileHandler.FileToByteArray(docPathStr, ref streamLength);

            SqlParameter p1 = new SqlParameter("@size", SqlDbType.Int);
            p1.Value = streamLength;
            SqlParameter p2 = new SqlParameter("@filebyte", SqlDbType.Image);
            p2.Value = buffer;
            SqlParameter p3 = new SqlParameter("@docversion", SqlDbType.VarChar, 10);
            p3.Value = oldDocVerStr;
            SqlParameter p4 = new SqlParameter("@tablename", SqlDbType.VarChar, 50);
            p4.Value = tableNameStr;
            SqlParameter[] paraList = { p1, p2, p3, p4 };
            BaseSQL.GetSingle("Update BS_DocumentTemplet Set Size = @size, FileByte = @filebyte, DocVersion = @docversion where TableName = @tablename", paraList);

            return true;
        }

        /// <summary>
        /// 查询单据模板文件
        /// </summary>
        public Byte[] QueryDocTemplet_FileByte(string tableNameStr)
        {
            string sqlStr = string.Format("select TableName, FileByte from BS_DocumentTemplet where TableName = '{0}'", tableNameStr);
            DataTable docTable = BaseSQL.GetTableBySql(sqlStr);
            if (docTable.Rows.Count == 0)
                throw new Exception("查询模板文件异常。");
            return (byte[])docTable.Rows[0]["FileByte"];
        }
    }
}