using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class ThemeDetail
    {
        private int themeId;
        private string controlName;
        private string controlProperty;
        private string controlValue;
        private string controlType;

        public int ThemeId
        {
            get
            {
                return themeId;
            }

            set
            {
                themeId = value;
            }
        }

        public string ControlName
        {
            get
            {
                return controlName;
            }

            set
            {
                controlName = value;
            }
        }

        public string ControlProperty
        {
            get
            {
                return controlProperty;
            }

            set
            {
                controlProperty = value;
            }
        }

        public string ControlValue
        {
            get
            {
                return controlValue;
            }

            set
            {
                controlValue = value;
            }
        }

        public string ControlType
        {
            get
            {
                return controlType;
            }

            set
            {
                controlType = value;
            }
        }
    }
}
