using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class CountryCodeManagement
    {
        private string countryCode;
        private string countryName;

        public string CountryCode
        {
            get
            {
                return countryCode;
            }

            set
            {
                countryCode = value;
            }
        }

        public string CountryName
        {
            get
            {
                return countryName;
            }

            set
            {
                countryName = value;
            }
        }
    }
}
