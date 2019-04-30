using PSAP.DAO.BSDAO;
using PSAP.DAO.PBDAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.PBVIEW
{
    public partial class FrmProductionScheduleQuery : DockContent
    {
        FrmCommonDAO commonDAO = new FrmCommonDAO();
        FrmProductionScheduleDAO psDAO = new FrmProductionScheduleDAO();

        public FrmProductionScheduleQuery()
        {
            InitializeComponent();
        }
    }
}
