using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.PSAPCommon
{
    public class DataTypeConvert
    {
        public static string GetString(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                return "";
            }
            else
                return obj.ToString();
        }

        public static int GetInt(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)) || (Object.Equals(obj, "")))
            {
                return 0;
            }
            else
                return Convert.ToInt32(obj);
        }

        public static bool GetBoolean(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)) || (Object.Equals(obj, "")))
            {
                return false;
            }
            else
                return Convert.ToBoolean(obj);
        }

        public static double GetDouble(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)) || (Object.Equals(obj, "")))
            {
                return 0;
            }
            else
                return Convert.ToDouble(obj);
        }

        public static decimal GetDecimal(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value) || (Object.Equals(obj, ""))))
            {
                return 0;
            }
            else
                return Convert.ToDecimal(obj);
        }

        public static DateTime GetDateTime(object obj)
        {
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                return DAO.BSDAO.BaseSQL.GetServerDateTime();
            }
            else
                return Convert.ToDateTime(obj);
        }

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

        public static int BoolToBit(bool b)
        {
            if (b == true)
                return 1;
            else
                return 0;
        }
        
    }
}
