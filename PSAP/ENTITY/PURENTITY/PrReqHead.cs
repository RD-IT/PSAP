using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.PURENTITY
{
    class PrReqHead
    {
        private string prReqNo;
        private DateTime reqDate;
        private string reqDep;
        private string projectNo;
        private string stnNo;
        private string purCategory;
        private int reqState;
        private string applicant;
        private string applicantIp;
        private string approver;
        private string approverIp;
        private string modifier;
        private string modifierIp;
        private string prReqRemark;

        public string PrReqNo
        {
            get { return prReqNo; }
            set { prReqNo = value; }
        }
        public DateTime ReqDate
        {
            get { return reqDate; }
            set { reqDate = value; }
        }
        public string ReqDep
        {
            get { return reqDep; }
            set { reqDep = value; }
        }
        public string ProjectNo
        {
            get { return projectNo; }
            set { projectNo = value; }
        }
        public string StnNo
        {
            get { return stnNo; }
            set { stnNo = value; }
        }
        public string PurCategory
        {
            get { return purCategory; }
            set { purCategory = value; }
        }
        public int ReqState
        {
            get { return reqState; }
            set { reqState = value; }
        }
        public string Applicant
        {
            get { return applicant; }
            set { applicant = value; }
        }
        public string ApplicantIp
        {
            get { return applicantIp; }
            set { applicantIp = value; }
        }
        public string Approver
        {
            get { return approver; }
            set { approver = value; }
        }
        public string ApproverIp
        {
            get { return approverIp; }
            set { approverIp = value; }
        }
        public string Modifier
        {
            get { return modifier; }
            set { modifier = value; }
        }
        public string ModifierIp
        {
            get { return modifierIp; }
            set { modifierIp = value; }
        }
        public string PrReqRemark
        {
            get { return prReqRemark; }
            set { prReqRemark = value; }
        }
    }
}
