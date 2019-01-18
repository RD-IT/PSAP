using PSAP.DAO.BSDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.DAO.BSDAO
{
    public class FrmCommonDAO
    {
        /// <summary>
        /// 查询部门信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryDepartment(bool addAllItem)
        {
            //string sqlStr = "select 0 as AutoId, '' as DepartmentNo, '全部' as DepartmentName union select AutoId, DepartmentNo, DepartmentName from BS_Department";
            string sqlStr = "select AutoId, DepartmentNo, DepartmentName from BS_Department where DepartmentNo not in (select IsNull(ParentDepartmentNo,'') from BS_Department) order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '' as DepartmentNo, '全部' as DepartmentName union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询操作员信息
        /// </summary>
        public DataTable QueryUserInfo(bool addAllItem)
        {
            string sqlStr = "select AutoId, LoginId, EmpName from BS_UserInfo order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as LoginId, '全部' as EmpName union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询采购类型（增加一个全部选项）
        /// </summary>
        public DataTable QueryPurCategory(bool addAllItem)
        {
            string sqlStr = "select AutoId, PurCategory, PurCategoryText from PUR_PurCategory order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '' as PurCategory, '全部' as PurCategoryText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询物料信息表
        /// </summary>
        public DataTable QueryPartsCode(bool addAllItem)
        {
            string sqlStr = "select AutoId, CodeFileName, CodeName from SW_PartsCode order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as CodeFileName, '全部' as CodeName union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询项目号列表
        /// </summary>
        public DataTable QueryProjectList(bool addAllItem)
        {
            string sqlStr = "select AutoId, ProjectNo, ProjectName, Remark from BS_ProjectList order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as ProjectNo, '全部' as ProjectName, '全部' as Remark union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询站号详细表
        /// </summary>
        /// <param name="projectNoStr">项目号</param>
        public DataTable QueryStnList(string projectNoStr)
        {
            string sqlStr = string.Format("select StnNo, ProjectNo, Remark from BS_StnList {0} order by AutoId", projectNoStr == "" ? " where 1=2" : (string.Format(" where ProjectNo='{0}'", projectNoStr)));
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询审批类型信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryApprovalType(bool addAllItem)
        {
            string sqlStr = "select AutoId, TypeNo, TypeNoText, ApprovalCat, ApprovalText from V_PUR_ApprovalType Order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as TypeNo, '全部' as TypeNoText, 0 as ApprovalCat, '' as ApprovalText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询往来方信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryBussinessBaseInfo(bool addAllItem)
        {
            string sqlStr = "select Info.AutoId, Info.BussinessBaseNo, Info.BussinessBaseText, Cate.BussinessCategoryText from BS_BussinessBaseInfo as Info left join BS_BussinessCategory as Cate on Info.BussinessCategory=Cate.BussinessCategory where BussinessIsUse=1 Order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as BussinessBaseNo, '全部' as BussinessBaseText, '全部' as BussinessCategoryText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询付款类型信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryPayType(bool addAllItem)
        {
            string sqlStr = "select AutoId, PayTypeNo, PayTypeNoText from PUR_PayType Order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as PayTypeNo, '全部' as PayTypeNoText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 统计要查询的SQL的数据的行数的SQL
        /// </summary>
        /// <param name="sqlStr">要查询的SQL</param>
        public string QuerySqlTranTotalCountSql(string sqlStr)
        {
            return string.Format("select Count(*) from ({0}) as tmpTable", sqlStr.Replace("order by AutoId", ""));
        }

        /// <summary>
        /// 判断站号是否包含在项目号中
        /// </summary>
        /// <param name="projectNoStr">项目号</param>
        /// <param name="stnNoStr">站号</param>
        public bool StnNoIsContainProjectNo(string projectNoStr, string stnNoStr)
        {
            string sqlStr = string.Format("select Count(*) from BS_StnList where ProjectNo='{0}' and StnNo='{1}'", projectNoStr, stnNoStr);
            int count = DataTypeConvert.GetInt(BaseSQL.GetSingle(sqlStr));
            return count == 0 ? false : true;
        }

        /// <summary>
        /// 查询仓库信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryRepertoryInfo(bool addAllItem)
        {
            string sqlStr = "select AutoId, RepertoryNo, RepertoryName, RepertoryType, RepertoryTypeText from V_BS_RepertoryInfo Order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as RepertoryNo, '全部' as RepertoryName, 1 as RepertoryType, '正常' as RepertoryTypeText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询货架信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryShelfInfo(bool addAllItem)
        {
            string sqlStr = "select AutoId, ShelfNo, ShelfLocation from BS_ShelfInfo Order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '全部' as ShelfNo, '全部' as ShelfLocation union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }
    }
}
