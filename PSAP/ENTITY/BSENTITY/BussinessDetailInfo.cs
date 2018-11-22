using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class BussinessDetailInfo
    {
        private string bussinessBaseNo;
        private string companyLR;
        private string companyAddress;
        private string zipCode;
        private string phoneNo;
        private string faxNo;
        private string e_mail;
        private string webSite;
        private string countryCode;

        public string BussinessBaseNo
        {
            get
            {
                return bussinessBaseNo;
            }

            set
            {
                bussinessBaseNo = value;
            }
        }

        public string CompanyLR
        {
            get
            {
                return companyLR;
            }

            set
            {
                companyLR = value;
            }
        }

        public string CompanyAddress
        {
            get
            {
                return companyAddress;
            }

            set
            {
                companyAddress = value;
            }
        }

        public string ZipCode
        {
            get
            {
                return zipCode;
            }

            set
            {
                zipCode = value;
            }
        }

        public string PhoneNo
        {
            get
            {
                return phoneNo;
            }

            set
            {
                phoneNo = value;
            }
        }

        public string FaxNo
        {
            get
            {
                return faxNo;
            }

            set
            {
                faxNo = value;
            }
        }

        public string E_mail
        {
            get
            {
                return e_mail;
            }

            set
            {
                e_mail = value;
            }
        }

        public string WebSite
        {
            get
            {
                return webSite;
            }

            set
            {
                webSite = value;
            }
        }

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
    }
}
