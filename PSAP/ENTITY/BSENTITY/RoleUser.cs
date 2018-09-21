using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.BSENTITY
{
    class RoleUser
    {
        private string roleNo;
        private int userNo;

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

        public int UserNo
        {
            get
            {
                return userNo;
            }

            set
            {
                userNo = value;
            }
        }
    }
}
