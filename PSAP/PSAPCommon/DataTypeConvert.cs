using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.PSAPCommon
{
    public class DataTypeConvert
    {
        /// <summary>
        /// 将Object类型转换为String类型
        /// </summary>
        public static string GetString(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                return "";
            }
            else
                return obj.ToString();
        }

        /// <summary>
        /// 将Object类型转换为Int类型
        /// </summary>
        public static int GetInt(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)) || (Object.Equals(obj, "")))
            {
                return 0;
            }
            else
                return Convert.ToInt32(obj);
        }

        /// <summary>
        /// 将Object类型转换为Boolean类型
        /// </summary>
        public static bool GetBoolean(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)) || (Object.Equals(obj, "")))
            {
                return false;
            }
            else
                return Convert.ToBoolean(obj);
        }

        /// <summary>
        /// 将Object类型转换为Double类型
        /// </summary>
        public static double GetDouble(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)) || (Object.Equals(obj, "")))
            {
                return 0;
            }
            else
                return Convert.ToDouble(obj);
        }

        /// <summary>
        /// 将Object类型转换为Decimal类型
        /// </summary>
        public static decimal GetDecimal(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value) || (Object.Equals(obj, ""))))
            {
                return 0;
            }
            else
                return Convert.ToDecimal(obj);
        }

        /// <summary>
        /// 将Object类型转换为DateTime类型，为空时默认返回服务器的时间
        /// </summary>
        public static DateTime GetDateTime(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                return DAO.BSDAO.BaseSQL.GetServerDateTime();
            }
            else
                return Convert.ToDateTime(obj);
        }

        /// <summary>
        /// 将Object类型转换为Bit类型
        /// </summary>
        public static int GetBit(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                return 0;
            }
            else if (GetBoolean(obj))
                return 1;
            else
                return 0;
        }

        /// <summary>
        /// 将Bool类型转换为Bit类型
        /// </summary>
        public static int BoolToBit(bool b)
        {
            if (b == true)
                return 1;
            else
                return 0;
        }
        
    }
}
