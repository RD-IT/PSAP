using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class BussinessFinancialInfo
    {
        private string bussinessBaseNo;
        private string bussinessLicense;
        private string bankAccout;
        private string bankAddress;

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

        public string BussinessLicense
        {
            get
            {
                return bussinessLicense;
            }

            set
            {
                bussinessLicense = value;
            }
        }

        public string BankAccout
        {
            get
            {
                return bankAccout;
            }

            set
            {
                bankAccout = value;
            }
        }

        public string BankAddress
        {
            get
            {
                return bankAddress;
            }

            set
            {
                bankAddress = value;
            }
        }
    }
}
