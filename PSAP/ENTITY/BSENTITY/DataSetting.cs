using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class DataSetting
    {
        private int querySql;
        private int tabIndex;
        private int tabName;
        private string tabText;
        private string tabRemark;

        public int QuerySql
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

        public int TabIndex
        {
            get
            {
                return tabIndex;
            }

            set
            {
                tabIndex = value;
            }
        }

        public int TabName
        {
            get
            {
                return tabName;
            }

            set
            {
                tabName = value;
            }
        }

        public string TabText
        {
            get
            {
                return tabText;
            }

            set
            {
                tabText = value;
            }
        }

        public string TabRemark
        {
            get
            {
                return tabRemark;
            }

            set
            {
                tabRemark = value;
            }
        }
    }
}
