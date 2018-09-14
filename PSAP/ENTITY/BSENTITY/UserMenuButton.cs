using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.BSENTITY
{
    class UserMenuButton
    {
        private int userNo;
        private int menuButtonId;

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

        public int MenuButtonId
        {
            get
            {
                return menuButtonId;
            }

            set
            {
                menuButtonId = value;
            }
        }
    }
}
