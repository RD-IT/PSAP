using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using PSAP.DAO.PURDAO;
using PSAP.PSAPCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace PSAP.VIEW.BSVIEW
{
    public partial class FrmTest_WF2 : DockContent
    {
        public FrmTest_WF2()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            InitTreeList(treeList1);
            treeList1.CollapseAll();
        }

        private static DataTable dt = new DataTable();
        public static void InitTreeList(DevExpress.XtraTreeList.TreeList tl)
        {
            dt.Columns.Add("dirName", Type.GetType("System.String"));
            dt.Columns.Add("dirId", Type.GetType("System.String"));
            dt.Columns.Add("dirParentId", Type.GetType("System.String"));
            GetProjectPathStru(@"D:\Raultwf");//
            tl.Nodes.Clear();
            tl.OptionsView.ShowHorzLines = false;
            tl.OptionsView.ShowVertLines = false;
            tl.OptionsView.ShowColumns = false;
            tl.KeyFieldName = "dirId";
            tl.ParentFieldName = "dirParentId";
            tl.ImageIndexFieldName = "d";
            tl.DataSource = dt;
            //tl.SelectImageList = IconsIndexes.FolderOpen;
            //tl.StateImageList = IconsIndexes.FolderClose;
            tl.OptionsBehavior.Editable = false;
            tl.ExpandAll();
        }

        public static void GetProjectPathStru(string dir)
        {
            DirectoryInfo d = new DirectoryInfo(dir);
            foreach (DirectoryInfo fsinfo in d.GetDirectories())
            {
                DataRow dr = dt.NewRow();
                dr[0] = fsinfo.Name;
                dr[1] = fsinfo.FullName;
                dr[2] = fsinfo.Parent.FullName;
                dt.Rows.Add(dr);
                GetProjectPathStru(fsinfo.FullName);//递归调用
            }
        }

        private void treeList1_CustomDrawNodeImages(object sender, DevExpress.XtraTreeList.CustomDrawNodeImagesEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Expanded)
                {
                    e.SelectImageIndex = 1;
                    return;
                }
                else
                {
                    e.SelectImageIndex = 0;
                }                
            }
            else
            {
                e.SelectImageIndex = 0;
            }
        }

        private void FrmTest_WF2_Load(object sender, EventArgs e)
        {
            searchLookUpEdit1.Properties.DataSource = null;
            new FrmPrReqDAO().QueryPrReqHead(dataSet_PrReq.Tables[0], "", "", "", "", 0, "", "", false);
        }

    }
}
