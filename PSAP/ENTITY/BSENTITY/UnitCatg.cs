using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.BSENTITY
{
    class UnitCatg
    {
        private string unitNo;
        private string unitName;
        private string unitDescription;

        public string UnitNo
        {
            get
            {
                return unitNo;
            }

            set
            {
                unitNo = value;
            }
        }

        public string UnitName
        {
            get
            {
                return unitName;
            }

            set
            {
                unitName = value;
            }
        }

        public string UnitDescription
        {
            get
            {
                return unitDescription;
            }

            set
            {
                unitDescription = value;
            }
        }
    }
}
