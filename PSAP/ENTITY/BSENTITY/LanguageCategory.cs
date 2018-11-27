using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class LanguageCategory
    {
        private string languageName;
        private string languageText;

        public string LanguageName
        {
            get
            {
                return languageName;
            }

            set
            {
                languageName = value;
            }
        }

        public string LanguageText
        {
            get
            {
                return languageText;
            }

            set
            {
                languageText = value;
            }
        }
    }
}
