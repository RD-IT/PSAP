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
    public partial class FrmLanguageText : Form
    {
        public FrmLanguageText()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }
    }
}
