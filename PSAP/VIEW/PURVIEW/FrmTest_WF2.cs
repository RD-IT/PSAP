using DevExpress.Utils.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.WinExplorer;
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
            try
            {
                searchLookUpEdit1.Properties.DataSource = null;
                new FrmPrReqDAO().QueryPrReqHead(dataSet_PrReq.Tables[0], "", "", "", "", 0, "", "", false);

                string currentPath = Application.StartupPath;
                gridControl1.DataSource = FileSystemHelper.GetFileSystemEntries(currentPath, GetItemSizeType(ViewStyle), GetItemSize(ViewStyle));

                BarButtonItem btnItem = new BarButtonItem();
                btnItem.Name = "Function";
                btnItem.Caption = "标题";
                btnItem.Enabled = false;
                btnItem.ItemClick += this.barButtonItem1_ItemClick;
                barToolBar.AddItem(btnItem);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private IconSizeType GetItemSizeType(WinExplorerViewStyle viewStyle)
        {
            switch (viewStyle)
            {
                case WinExplorerViewStyle.Large:
                case WinExplorerViewStyle.ExtraLarge:
                    return IconSizeType.ExtraLarge;
                case WinExplorerViewStyle.List:
                case WinExplorerViewStyle.Small:
                    return IconSizeType.Small;
                case WinExplorerViewStyle.Tiles:
                case WinExplorerViewStyle.Medium:
                case WinExplorerViewStyle.Content:
                    return IconSizeType.Large;
                default: return IconSizeType.ExtraLarge;
            }
        }

        private Size GetItemSize(WinExplorerViewStyle viewStyle)
        {
            switch (viewStyle)
            {
                case WinExplorerViewStyle.ExtraLarge:
                    return new Size(256, 256);
                case WinExplorerViewStyle.Large:
                    return new Size(96, 96);
                case WinExplorerViewStyle.Content:
                    return new Size(32, 32);
                case WinExplorerViewStyle.Small:
                    return new Size(16, 16);
                case WinExplorerViewStyle.Tiles:
                case WinExplorerViewStyle.Default:
                case WinExplorerViewStyle.List:
                case WinExplorerViewStyle.Medium:
                default: return new Size(96, 96);
            }
        }

        public WinExplorerViewStyle ViewStyle { get { return winExplorerView.OptionsView.Style; } }

        void OnWinExplorerViewItemDoubleClick(object sender, WinExplorerViewItemDoubleClickEventArgs e)
        {
            try
            {
                if (e.MouseInfo.Button != MouseButtons.Left)
                    return;
                winExplorerView.ClearSelection();
                string s = ((DevExpress.Utils.Helpers.FileSystemEntry)e.ItemInfo.Row.RowKey).Path;
                gridControl1.DataSource = FileSystemHelper.GetFileSystemEntries(s, GetItemSizeType(ViewStyle), GetItemSize(ViewStyle));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            winExplorerView.RefreshData();
            gridControl1.RefreshDataSource();
            gridControl1.Refresh();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageHandler.ShowMessageBox("123");
        }
    }
}
