using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmLanguageINVDAO : Form
    {
        public FrmLanguageINVDAO()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }
    }
}
