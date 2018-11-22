using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class BomMaterieState
    {
        private int materieStateId;
        private string materieStateText;

        public int MaterieStateId
        {
            get
            {
                return materieStateId;
            }

            set
            {
                materieStateId = value;
            }
        }

        public string MaterieStateText
        {
            get
            {
                return materieStateText;
            }

            set
            {
                materieStateText = value;
            }
        }
    }
}
