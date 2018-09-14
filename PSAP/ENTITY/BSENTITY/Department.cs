using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.BSENTITY
{
    class Department
    {
        private string departmentNo;
        private string departmentName;
        private string parentDepartmentNo;
        private DateTime createDate;
        private string founder;

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

        public string ParentDepartmentNo
        {
            get
            {
                return parentDepartmentNo;
            }

            set
            {
                parentDepartmentNo = value;
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
    }
}
