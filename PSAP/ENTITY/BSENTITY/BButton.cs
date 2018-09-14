using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSAP.ENTITY.BSENTITY
{
    class BButton
    {
        private string buttonName;
        private string buttonText;

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

        public string ButtonText
        {
            get
            {
                return buttonText;
            }

            set
            {
                buttonText = value;
            }
        }
    }
}
