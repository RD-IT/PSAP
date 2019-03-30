using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmLanguageBSDAO : Form
    {
        public FrmLanguageBSDAO()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        private void tsmiSdmrlxsjcw_Click(object sender, EventArgs e)
        {

        }
    }
}
