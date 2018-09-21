using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.BSENTITY
{
    class Menu
    {
        private string menuName;
        private string menuText;
        private string parentMenuName;

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

        public string ParentMenuName
        {
            get
            {
                return parentMenuName;
            }

            set
            {
                parentMenuName = value;
            }
        }
    }
}
