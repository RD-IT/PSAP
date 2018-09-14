using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.BSENTITY
{
    class Menu
    {
        private string menuNo;
        private string menuName;
        private string menuText;
        private string parentMenuNo;

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

        public string MenuName
        {
            get
            {
                return menuName;
            }

            set
            {
                menuName = value;
            }
        }

        public string MenuText
        {
            get
            {
                return menuText;
            }

            set
            {
                menuText = value;
            }
        }

        public string ParentMenuNo
        {
            get
            {
                return parentMenuNo;
            }

            set
            {
                parentMenuNo = value;
            }
        }
    }
}
