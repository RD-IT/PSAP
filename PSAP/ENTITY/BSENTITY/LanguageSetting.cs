using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class LanguageSetting
    {
        private string formName;
        private string controlsCategory;
        private string controlsName;
        private string chinese;
        private string english;

        public string FormName
        {
            get
            {
                return formName;
            }

            set
            {
                formName = value;
            }
        }

        public string ControlsCategory
        {
            get
            {
                return controlsCategory;
            }

            set
            {
                controlsCategory = value;
            }
        }

        public string ControlsName
        {
            get
            {
                return controlsName;
            }

            set
            {
                controlsName = value;
            }
        }

        public string Chinese
        {
            get
            {
                return chinese;
            }

            set
            {
                chinese = value;
            }
        }

        public string English
        {
            get
            {
                return english;
            }

            set
            {
                english = value;
            }
        }
    }
}
