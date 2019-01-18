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

        /// <summary>
        /// 小闪，滚木，雪球，滚筒，剑雨，火球，毒药，大闪，火箭
        /// </summary>
        /// <param name="codeFileNameStr"></param>
        /// <param name="repertoryNoStr"></param>
        /// <param name="projectNameStr"></param>
        /// <param name="shelfNoStr"></param>
        /// <returns></returns>
        public string QueryWarehouseNowInfo_SQL(string codeFileNameStr, string repertoryNoStr, string projectNameStr, string shelfNoStr)
        {
            string sqlStr = " 1=1";
            if (codeFileNameStr != "")
            {
                sqlStr += string.Format(" and CodeFileName='{0}'", codeFileNameStr);
            }
            if (repertoryNoStr != "")
            {
                sqlStr += string.Format(" and RepertoryNo='{0}'", repertoryNoStr);
            }
            if (projectNameStr != "")
            {
                sqlStr += string.Format(" and ProjectName='{0}'", projectNameStr);
            }
            if (shelfNoStr != "")
            {
                sqlStr += string.Format(" and ShelfNo='{0}'", shelfNoStr);
            }
            sqlStr = string.Format("select * from V_INV_WarehouseNowInfo where {0} order by AutoId", sqlStr);
            return sqlStr;
        }

    }
}
