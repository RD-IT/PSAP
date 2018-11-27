using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class BussinessBaseInfo
    {
        private string bussinessBaseNo;
        private string bussinessBaseText;
        private string bussinessCategory;
        private bool bussinessIsUse;

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

        public string BussinessBaseText
        {
            get
            {
                return bussinessBaseText;
            }

            set
            {
                bussinessBaseText = value;
            }
        }

        public string BussinessCategory
        {
            get
            {
                return bussinessCategory;
            }

            set
            {
                bussinessCategory = value;
            }
        }

        public bool BussinessIsUse
        {
            get
            {
                return bussinessIsUse;
            }

            set
            {
                bussinessIsUse = value;
            }
        }
    }
}
