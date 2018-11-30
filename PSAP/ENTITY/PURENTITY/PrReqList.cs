using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.PURENTITY
{
    class PrReqList
    {
        private string prReqNo;
        private string codeFileName;
        private double qty;
        private DateTime requirementDate;
        private string prReqListRemark;

        public string PrReqNo
        {
            get { return prReqNo; }
            set { prReqNo = value; }
        }
        public string CodeFileName
        {
            get { return codeFileName; }
            set { codeFileName = value; }
        }
        public double Qty
        {
            get { return qty; }
            set { qty = value; }
        }
        public DateTime RequirementDate
        {
            get { return requirementDate; }
            set { requirementDate = value; }
        }
        public string PrReqListRemark
        {
            get { return prReqListRemark; }
            set { prReqListRemark = value; }
        }
    }
}
