using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSAP.ENTITY.BSENTITY
{
    class BomMateriel
    {
        private string materielNo;
        private string levelMaterielNo;
        private int qty;
        private DateTime getTime;

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

        public string LevelMaterielNo
        {
            get
            {
                return levelMaterielNo;
            }

            set
            {
                levelMaterielNo = value;
            }
        }

        public int Qty
        {
            get
            {
                return qty;
            }

            set
            {
                qty = value;
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
