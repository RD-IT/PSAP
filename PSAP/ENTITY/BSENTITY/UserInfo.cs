using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.BSENTITY
{
    class UserInfo
    {
        private int autoId;
        private string empName;
        private string departmentNo;
        private string departmentName;
        private string loginID;
        private string loginPwd;
        private string founder;
        private DateTime createDate;
        private string bfree1;
        private string bfree2;
        private string bfree3;
        private string bfree4;
        private string bfree5;
        private string roleNo;
        private string roleName;
        private string lanuage;

        public string EmpName
        {
            get
            {
                return empName;
            }

            set
            {
                empName = value;
            }
        }

        public string DepartmentNo
        {
            get
            {
                return departmentNo;
            }

            set
            {
                departmentNo = value;
            }
        }

        public string LoginID
        {
            get
            {
                return loginID;
            }

            set
            {
                loginID = value;
            }
        }

        public string LoginPwd
        {
            get
            {
                return loginPwd;
            }

            set
            {
                loginPwd = value;
            }
        }

        public string Founder
        {
            get
            {
                return founder;
            }

            set
            {
                founder = value;
            }
        }

        public DateTime CreateDate
        {
            get
            {
                return createDate;
            }

            set
            {
                createDate = value;
            }
        }

        public string Bfree1
        {
            get
            {
                return bfree1;
            }

            set
            {
                bfree1 = value;
            }
        }

        public string Bfree2
        {
            get
            {
                return bfree2;
            }

            set
            {
                bfree2 = value;
            }
        }

        public string Bfree3
        {
            get
            {
                return bfree3;
            }

            set
            {
                bfree3 = value;
            }
        }

        public string Bfree4
        {
            get
            {
                return bfree4;
            }

            set
            {
                bfree4 = value;
            }
        }

        public string Bfree5
        {
            get
            {
                return bfree5;
            }

            set
            {
                bfree5 = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return departmentName;
            }

            set
            {
                departmentName = value;
            }
        }

        public string RoleNo
        {
            get
            {
                return roleNo;
            }

            set
            {
                roleNo = value;
            }
        }

        public string RoleName
        {
            get
            {
                return roleName;
            }

            set
            {
                roleName = value;
            }
        }

        public int AutoId
        {
            get
            {
                return autoId;
            }

            set
            {
                autoId = value;
            }
        }

        public string Lanuage
        {
            get
            {
                return lanuage;
            }

            set
            {
                lanuage = value;
            }
        }
    }
}
