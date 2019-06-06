using PSAP.DAO.BSDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmSelectStnModule : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();

        public FrmSelectStnModule()
        {
            InitializeComponent();
        }
    }
}
