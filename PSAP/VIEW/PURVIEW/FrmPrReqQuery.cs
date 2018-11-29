using DevExpress.XtraGrid.Views.Base;
using PSAP.DAO.PURDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.PURVIEW
{
    public partial class FrmPrReqQuery : Form
    {
        FrmPrReqDAO prReqDAO = new FrmPrReqDAO();

        public FrmPrReqQuery()
        {
            InitializeComponent();
        }
    }
}
