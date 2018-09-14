using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.BSENTITY
{
    class RoleMenu
    {
        private string roleNo;
        private string menuNo;

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

        public string MenuNo
        {
            get
            {
                return menuNo;
            }

            set
            {
                menuNo = value;
            }
        }
    }
}
