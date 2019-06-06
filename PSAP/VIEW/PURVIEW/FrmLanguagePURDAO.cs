using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmLanguagePURDAO : Form
    {
        public FrmLanguagePURDAO()
        {
            InitializeComponent();
            PSAP.BLL.BSBLL.BSBLL.language(this);
        }
    }
}
