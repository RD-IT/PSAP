using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class QuerySqlParameter
    {
        private int querySqlId;
        private int parametersText;
        private int parametersName;
        private int parametersCatg;

        public int QuerySqlId
        {
            get
            {
                return querySqlId;
            }

            set
            {
                querySqlId = value;
            }
        }

        public int ParametersText
        {
            get
            {
                return parametersText;
            }

            set
            {
                parametersText = value;
            }
        }

        public int ParametersName
        {
            get
            {
                return parametersName;
            }

            set
            {
                parametersName = value;
            }
        }

        public int ParametersCatg
        {
            get
            {
                return parametersCatg;
            }

            set
            {
                parametersCatg = value;
            }
        }
    }
}
