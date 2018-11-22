using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class QuerySql
    {
        private int parentId;
        private string queryText;
        private string querySql;
        private int itemOrder;
        private string reamrks;

        public int ParentId
        {
            get
            {
                return parentId;
            }

            set
            {
                parentId = value;
            }
        }

        public string QueryText
        {
            get
            {
                return queryText;
            }

            set
            {
                queryText = value;
            }
        }

        public string QuerySql_
        {
            get
            {
                return querySql;
            }

            set
            {
                querySql = value;
            }
        }

        public int ItemOrder
        {
            get
            {
                return itemOrder;
            }

            set
            {
                itemOrder = value;
            }
        }

        public string Reamrks
        {
            get
            {
                return reamrks;
            }

            set
            {
                reamrks = value;
            }
        }
    }
}
