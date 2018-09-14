using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.BSENTITY
{
    class Role
    {
        private string roleNo;
        private string roleName;

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
    }
}
