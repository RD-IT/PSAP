using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class DataHeaderSetting
    {
        private int querySql;
        private int dataSetting;
        private string headerName;
        private string headerText;
        private string parentHeaderName;

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

        public int DataSetting
        {
            get
            {
                return dataSetting;
            }

            set
            {
                dataSetting = value;
            }
        }

        public string HeaderName
        {
            get
            {
                return headerName;
            }

            set
            {
                headerName = value;
            }
        }

        public string HeaderText
        {
            get
            {
                return headerText;
            }

            set
            {
                headerText = value;
            }
        }

        public string ParentHeaderName
        {
            get
            {
                return parentHeaderName;
            }

            set
            {
                parentHeaderName = value;
            }
        }
    }
}
