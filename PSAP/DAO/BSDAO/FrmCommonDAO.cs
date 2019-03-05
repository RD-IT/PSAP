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
        static PSAP.VIEW.BSVIEW.FrmLanguageText f = new VIEW.BSVIEW.FrmLanguageText();
        public FrmCommonDAO()
        {
            PSAP.BLL.BSBLL.BSBLL.language(f);
        }

        /// <summary>
        /// 查询部门信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryDepartment(bool addAllItem)
        {
            //string sqlStr = "select 0 as AutoId, '' as DepartmentNo, '全部' as DepartmentName union select AutoId, DepartmentNo, DepartmentName from BS_Department";
            string sqlStr = "select AutoId, DepartmentNo, DepartmentName from BS_Department where DepartmentNo not in (select IsNull(ParentDepartmentNo,'') from BS_Department) order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '' as DepartmentNo, '" + f.tsmiQb + "' as DepartmentName union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询部门信息全部表（增加一个全部选项）
        /// </summary>
        public DataTable QueryDepartment_AllNode(bool addAllItem)
        {
            string sqlStr = "select AutoId, DepartmentNo, DepartmentName from BS_Department order by AutoId";
            if (addAllItem)
            {
                //sqlStr = "select 0 as AutoId, '' as DepartmentNo, '全部' as DepartmentName union " + sqlStr;
                sqlStr = "select 0 as AutoId, '' as DepartmentNo, '" + f.tsmiQb + "' as DepartmentName union " + sqlStr;

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
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as LoginId, '" + f.tsmiQb + "' as EmpName union " + sqlStr;
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
                sqlStr = "select 0 as AutoId, '' as PurCategory, '" + f.tsmiQb + "' as PurCategoryText union " + sqlStr;
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
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as CodeFileName, '" + f.tsmiQb + "' as CodeName union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询单位信息表
        /// </summary>
        public DataTable QueryUnitCatg(bool addAllItem)
        {
            string sqlStr = "select AutoId, UnitNo, UnitName from BS_UnitCatg order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as UnitNo, '" + f.tsmiQb + "' as UnitName union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询材料信息表
        /// </summary>
        public DataTable QueryMaterialSelectLib(bool addAllItem)
        {
            string sqlStr = "select AutoId, LibName, MaterialCategory, MaterialName from SW_MaterialSelectLib order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as LibName, '" + f.tsmiQb + "' as MaterialCategory, '" + f.tsmiQb + "' as MaterialName union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询品牌信息表
        /// </summary>
        public DataTable QueryBrandCatg(bool addAllItem)
        {
            string sqlStr = "select AutoId, BrandNo, BrandName from SW_BrandCatg order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as BrandNo, '" + f.tsmiQb + "' as BrandName union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询零件分类表
        /// </summary>
        public DataTable QueryPartNoCatg(bool addAllItem)
        {
            string sqlStr = "select AutoId, CatgName, CatgDescription from SW_PartNoCatg order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as CatgName, '" + f.tsmiQb + "' as CatgDescription union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询表面处理表
        /// </summary>
        public DataTable QueryFinishCatg(bool addAllItem)
        {
            string sqlStr = "select AutoId, FinishCatg, FinishOrder from SW_FinishCatg order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as FinishCatg, 0 as FinishOrder union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询加工等级表
        /// </summary>
        public DataTable QueryLevelCatg(bool addAllItem)
        {
            string sqlStr = "select AutoId, LevelCatg, CatgOrder from SW_LevelCatg order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as LevelCatg, 0 as CatgOrder union " + sqlStr;
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
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as ProjectNo, '" + f.tsmiQb + "' as ProjectName, '" + f.tsmiQb + "' as Remark union " + sqlStr;
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
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as TypeNo, '" + f.tsmiQb + "' as TypeNoText, 0 as ApprovalCat, '' as ApprovalText union " + sqlStr;
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
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as BussinessBaseNo, '" + f.tsmiQb + "' as BussinessBaseText, '" + f.tsmiQb + "' as BussinessCategoryText union " + sqlStr;
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
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as PayTypeNo, '" + f.tsmiQb + "' as PayTypeNoText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 查询收款类型信息（增加一个全部选项）
        /// </summary>
        public DataTable QueryCollectionType(bool addAllItem)
        {
            string sqlStr = "select AutoId, CollectionTypeNo, CollectionTypeNoText from BS_CollectionType Order by AutoId";
            if (addAllItem)
            {
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as CollectionTypeNo, '" + f.tsmiQb + "' as CollectionTypeNoText union " + sqlStr;
            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 统计要查询的SQL的数据的行数的SQL
        /// </summary>
        /// <param name="sqlStr">要查询的SQL</param>
        public string QuerySqlTranTotalCountSql(string sqlStr)
        {
            string orderbyStr = sqlStr.Substring(sqlStr.IndexOf("order by"));
            return string.Format("select Count(*) from ({0}) as tmpTable", sqlStr.Replace(orderbyStr, ""));
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
                //sqlStr = "select 0 as AutoId, '全部' as RepertoryNo, '全部' as RepertoryName, 1 as RepertoryType, '正常' as RepertoryTypeText union " + sqlStr;
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as RepertoryNo, '" + f.tsmiQb + "' as RepertoryName, 1 as RepertoryType, '"+f.tsmiZc.Text+"' as RepertoryTypeText union " + sqlStr;

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
                //sqlStr = "select 0 as AutoId, '全部' as ShelfNo, '全部' as ShelfLocation union " + sqlStr;
                sqlStr = "select 0 as AutoId, '" + f.tsmiQb + "' as ShelfNo, '" + f.tsmiQb + "' as ShelfLocation union " + sqlStr;

            }
            return BaseSQL.GetTableBySql(sqlStr);
        }

        /// <summary>
        /// 检查模块权限
        /// </summary>
        /// <param name="moduleNoStr">模块编号</param>
        /// <param name="moduleNameStr">模块名称</param>
        public static bool CheckModuleAuthority(string moduleNoStr, string moduleNameStr)
        {
            if (moduleNoStr == "")
                return false;

            string resultStr = new SocketHandler().SendServerAndReturnResult("Module|" + moduleNoStr);
            string[] msgStringArray = resultStr.Split('|');
            if (msgStringArray.Length > 0)
            {
                switch (msgStringArray[0])
                {
                    case "Module":
                        if (msgStringArray[1] == "1")
                            return true;
                        break;
                }
            }
            return false;
        }
    }
}
