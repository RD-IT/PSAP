using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.BSENTITY
{
    class MenuButton
    {
        private string menuNo;
        private string buttonName;

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

        public string ButtonName
        {
            get
            {
                return buttonName;
            }

            set
            {
                buttonName = value;
            }
        }
    }
}
