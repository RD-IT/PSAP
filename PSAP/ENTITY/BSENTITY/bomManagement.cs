using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class bomManagement
    {
        private int martsCodeId;
        private string materielNo;
        private int materieStateId;
        private DateTime getTime;

        public int MartsCodeId
        {
            get
            {
                return martsCodeId;
            }

            set
            {
                martsCodeId = value;
            }
        }

        public string MaterielNo
        {
            get
            {
                return materielNo;
            }

            set
            {
                materielNo = value;
            }
        }

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

        public DateTime GetTime
        {
            get
            {
                return getTime;
            }

            set
            {
                getTime = value;
            }
        }
    }
}
