using DevExpress.Skins;
using DevExpress.XtraGrid.Views.Base;
using PSAP.DAO.PURDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmTest_WF : DockContent
    {
        public FrmTest_WF()
        {
            InitializeComponent();
        }

        private void FrmTest_WF_Load(object sender, EventArgs e)
        {
            var al = new ArrayList();
            foreach (SkinContainer cnt in SkinManager.Default.Skins)
            {
                al.Add(cnt.SkinName);
            }
            al.Sort();
            foreach (string s in al)
            {
                listBoxControl2.Items.Add(s);
            }
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = listBoxControl2.SelectedItem.ToString();
        }

    }
}
