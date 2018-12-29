namespace PSAP.VIEW.BSVIEW
{
    partial class FrmTest_WF2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest_WF2));
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.searchLookUpEdit1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataSet_PrReq = new System.Data.DataSet();
            this.dataTablePrReqHead = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColPrReqNo = new System.Data.DataColumn();
            this.dataColReqDate = new System.Data.DataColumn();
            this.dataColReqDep = new System.Data.DataColumn();
            this.dataColProjectNo = new System.Data.DataColumn();
            this.dataColStnNo = new System.Data.DataColumn();
            this.dataColPurCategory = new System.Data.DataColumn();
            this.dataColReqState = new System.Data.DataColumn();
            this.dataColApplicant = new System.Data.DataColumn();
            this.dataColApplicantIp = new System.Data.DataColumn();
            this.dataColApplicantTime = new System.Data.DataColumn();
            this.dataColModifier = new System.Data.DataColumn();
            this.dataColModifierIp = new System.Data.DataColumn();
            this.dataColModifierTime = new System.Data.DataColumn();
            this.dataColApprover = new System.Data.DataColumn();
            this.dataColApproverIp = new System.Data.DataColumn();
            this.dataColApproverTime = new System.Data.DataColumn();
            this.dataColPrReqRemark = new System.Data.DataColumn();
            this.dataColSelect = new System.Data.DataColumn();
            this.dataColClosed = new System.Data.DataColumn();
            this.dataColClosedIp = new System.Data.DataColumn();
            this.dataColClosedTime = new System.Data.DataColumn();
            this.winExplorerView = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.columnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnPath = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnCheck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.barManagerToolBar = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barToolBar = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.修改 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PrReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerToolBar)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Location = new System.Drawing.Point(12, 36);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsClipboard.AllowCopy = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.OptionsClipboard.CopyNodeHierarchy = DevExpress.Utils.DefaultBoolean.True;
            this.treeList1.SelectImageList = this.imageList1;
            this.treeList1.Size = new System.Drawing.Size(261, 378);
            this.treeList1.TabIndex = 0;
            this.treeList1.CustomDrawNodeImages += new DevExpress.XtraTreeList.CustomDrawNodeImagesEventHandler(this.treeList1_CustomDrawNodeImages);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Empty;
            this.imageList1.Images.SetKeyName(0, "amazon.ico");
            this.imageList1.Images.SetKeyName(1, "HotPepper.ico");
            this.imageList1.Images.SetKeyName(2, "amazon.ico");
            this.imageList1.Images.SetKeyName(3, "HotPepper.ico");
            this.imageList1.Images.SetKeyName(4, "amazon.ico");
            this.imageList1.Images.SetKeyName(5, "HotPepper.ico");
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(309, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(163, 53);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // searchLookUpEdit1
            // 
            this.searchLookUpEdit1.Location = new System.Drawing.Point(531, 144);
            this.searchLookUpEdit1.Name = "searchLookUpEdit1";
            this.searchLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEdit1.Properties.View = this.searchLookUpEdit1View;
            this.searchLookUpEdit1.Size = new System.Drawing.Size(100, 20);
            this.searchLookUpEdit1.TabIndex = 2;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "PrReqHead";
            this.gridControl1.DataSource = this.dataSet_PrReq;
            this.gridControl1.Location = new System.Drawing.Point(279, 116);
            this.gridControl1.MainView = this.winExplorerView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(504, 274);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView});
            // 
            // dataSet_PrReq
            // 
            this.dataSet_PrReq.DataSetName = "NewDataSet";
            this.dataSet_PrReq.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTablePrReqHead});
            // 
            // dataTablePrReqHead
            // 
            this.dataTablePrReqHead.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColPrReqNo,
            this.dataColReqDate,
            this.dataColReqDep,
            this.dataColProjectNo,
            this.dataColStnNo,
            this.dataColPurCategory,
            this.dataColReqState,
            this.dataColApplicant,
            this.dataColApplicantIp,
            this.dataColApplicantTime,
            this.dataColModifier,
            this.dataColModifierIp,
            this.dataColModifierTime,
            this.dataColApprover,
            this.dataColApproverIp,
            this.dataColApproverTime,
            this.dataColPrReqRemark,
            this.dataColSelect,
            this.dataColClosed,
            this.dataColClosedIp,
            this.dataColClosedTime});
            this.dataTablePrReqHead.TableName = "PrReqHead";
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColPrReqNo
            // 
            this.dataColPrReqNo.Caption = "请购单号";
            this.dataColPrReqNo.ColumnName = "PrReqNo";
            // 
            // dataColReqDate
            // 
            this.dataColReqDate.Caption = "请购日期";
            this.dataColReqDate.ColumnName = "ReqDate";
            this.dataColReqDate.DataType = typeof(System.DateTime);
            // 
            // dataColReqDep
            // 
            this.dataColReqDep.Caption = "申请部门";
            this.dataColReqDep.ColumnName = "ReqDep";
            // 
            // dataColProjectNo
            // 
            this.dataColProjectNo.Caption = "项目号";
            this.dataColProjectNo.ColumnName = "ProjectNo";
            // 
            // dataColStnNo
            // 
            this.dataColStnNo.Caption = "站号";
            this.dataColStnNo.ColumnName = "StnNo";
            // 
            // dataColPurCategory
            // 
            this.dataColPurCategory.Caption = "采购类型";
            this.dataColPurCategory.ColumnName = "PurCategory";
            // 
            // dataColReqState
            // 
            this.dataColReqState.Caption = "状态";
            this.dataColReqState.ColumnName = "ReqState";
            this.dataColReqState.DataType = typeof(short);
            // 
            // dataColApplicant
            // 
            this.dataColApplicant.Caption = "申请人";
            this.dataColApplicant.ColumnName = "Applicant";
            // 
            // dataColApplicantIp
            // 
            this.dataColApplicantIp.Caption = "申请人IP";
            this.dataColApplicantIp.ColumnName = "ApplicantIp";
            // 
            // dataColApplicantTime
            // 
            this.dataColApplicantTime.Caption = "申请时间";
            this.dataColApplicantTime.ColumnName = "ApplicantTime";
            this.dataColApplicantTime.DataType = typeof(System.DateTime);
            // 
            // dataColModifier
            // 
            this.dataColModifier.Caption = "修改人";
            this.dataColModifier.ColumnName = "Modifier";
            // 
            // dataColModifierIp
            // 
            this.dataColModifierIp.Caption = "修改人IP";
            this.dataColModifierIp.ColumnName = "ModifierIp";
            // 
            // dataColModifierTime
            // 
            this.dataColModifierTime.Caption = "修改时间";
            this.dataColModifierTime.ColumnName = "ModifierTime";
            this.dataColModifierTime.DataType = typeof(System.DateTime);
            // 
            // dataColApprover
            // 
            this.dataColApprover.Caption = "审批人";
            this.dataColApprover.ColumnName = "Approver";
            // 
            // dataColApproverIp
            // 
            this.dataColApproverIp.Caption = "审批人IP";
            this.dataColApproverIp.ColumnName = "ApproverIp";
            // 
            // dataColApproverTime
            // 
            this.dataColApproverTime.Caption = "审批时间";
            this.dataColApproverTime.ColumnName = "ApproverTime";
            this.dataColApproverTime.DataType = typeof(System.DateTime);
            // 
            // dataColPrReqRemark
            // 
            this.dataColPrReqRemark.Caption = "备注";
            this.dataColPrReqRemark.ColumnName = "PrReqRemark";
            // 
            // dataColSelect
            // 
            this.dataColSelect.Caption = "";
            this.dataColSelect.ColumnName = "Select";
            this.dataColSelect.DataType = typeof(bool);
            // 
            // dataColClosed
            // 
            this.dataColClosed.Caption = "关闭人";
            this.dataColClosed.ColumnName = "Closed";
            // 
            // dataColClosedIp
            // 
            this.dataColClosedIp.Caption = "关闭人IP";
            this.dataColClosedIp.ColumnName = "ClosedIp";
            // 
            // dataColClosedTime
            // 
            this.dataColClosedTime.Caption = "关闭时间";
            this.dataColClosedTime.ColumnName = "ClosedTime";
            this.dataColClosedTime.DataType = typeof(System.DateTime);
            // 
            // winExplorerView
            // 
            this.winExplorerView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.winExplorerView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnName,
            this.columnPath,
            this.columnCheck,
            this.columnGroup,
            this.columnImage});
            this.winExplorerView.ColumnSet.CheckBoxColumn = this.columnCheck;
            this.winExplorerView.ColumnSet.DescriptionColumn = this.columnPath;
            this.winExplorerView.ColumnSet.ExtraLargeImageColumn = this.columnImage;
            this.winExplorerView.ColumnSet.GroupColumn = this.columnGroup;
            this.winExplorerView.ColumnSet.LargeImageColumn = this.columnImage;
            this.winExplorerView.ColumnSet.MediumImageColumn = this.columnImage;
            this.winExplorerView.ColumnSet.SmallImageColumn = this.columnImage;
            this.winExplorerView.ColumnSet.TextColumn = this.columnName;
            this.winExplorerView.GridControl = this.gridControl1;
            this.winExplorerView.GroupCount = 1;
            this.winExplorerView.Name = "winExplorerView";
            this.winExplorerView.OptionsBehavior.Editable = false;
            this.winExplorerView.OptionsSelection.AllowMarqueeSelection = true;
            this.winExplorerView.OptionsSelection.ItemSelectionMode = DevExpress.XtraGrid.Views.WinExplorer.IconItemSelectionMode.Click;
            this.winExplorerView.OptionsSelection.MultiSelect = true;
            this.winExplorerView.OptionsView.ImageLayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
            this.winExplorerView.OptionsView.ShowCheckBoxes = true;
            this.winExplorerView.OptionsView.ShowViewCaption = true;
            this.winExplorerView.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Small;
            this.winExplorerView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.columnGroup, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.winExplorerView.ItemDoubleClick += new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewItemDoubleClickEventHandler(this.OnWinExplorerViewItemDoubleClick);
            // 
            // columnName
            // 
            this.columnName.Caption = "columnName";
            this.columnName.FieldName = "Name";
            this.columnName.Name = "columnName";
            this.columnName.Visible = true;
            this.columnName.VisibleIndex = 0;
            // 
            // columnPath
            // 
            this.columnPath.Caption = "columnPath";
            this.columnPath.FieldName = "Path";
            this.columnPath.Name = "columnPath";
            this.columnPath.Visible = true;
            this.columnPath.VisibleIndex = 0;
            // 
            // columnCheck
            // 
            this.columnCheck.Caption = "columnCheck";
            this.columnCheck.FieldName = "IsCheck";
            this.columnCheck.Name = "columnCheck";
            this.columnCheck.Visible = true;
            this.columnCheck.VisibleIndex = 0;
            // 
            // columnGroup
            // 
            this.columnGroup.Caption = "columnGroup";
            this.columnGroup.FieldName = "Group";
            this.columnGroup.Name = "columnGroup";
            this.columnGroup.Visible = true;
            this.columnGroup.VisibleIndex = 0;
            // 
            // columnImage
            // 
            this.columnImage.Caption = "columnImage";
            this.columnImage.FieldName = "Image";
            this.columnImage.Name = "columnImage";
            this.columnImage.Visible = true;
            this.columnImage.VisibleIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(499, 23);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(163, 53);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // barManagerToolBar
            // 
            this.barManagerToolBar.AllowCustomization = false;
            this.barManagerToolBar.AllowMoveBarOnToolbar = false;
            this.barManagerToolBar.AllowQuickCustomization = false;
            this.barManagerToolBar.AllowShowToolbarsPopup = false;
            this.barManagerToolBar.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barToolBar});
            this.barManagerToolBar.DockControls.Add(this.barDockControlTop);
            this.barManagerToolBar.DockControls.Add(this.barDockControlBottom);
            this.barManagerToolBar.DockControls.Add(this.barDockControlLeft);
            this.barManagerToolBar.DockControls.Add(this.barDockControlRight);
            this.barManagerToolBar.Form = this;
            this.barManagerToolBar.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.修改,
            this.barButtonItem2});
            this.barManagerToolBar.MainMenu = this.barToolBar;
            this.barManagerToolBar.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(789, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 414);
            this.barDockControlBottom.Size = new System.Drawing.Size(789, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 390);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(789, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 390);
            // 
            // barToolBar
            // 
            this.barToolBar.BarName = "Main menu";
            this.barToolBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barToolBar.DockCol = 0;
            this.barToolBar.DockRow = 0;
            this.barToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barToolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.修改)});
            this.barToolBar.OptionsBar.AllowQuickCustomization = false;
            this.barToolBar.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.barToolBar.OptionsBar.DisableClose = true;
            this.barToolBar.OptionsBar.DisableCustomization = true;
            this.barToolBar.OptionsBar.UseWholeRow = true;
            this.barToolBar.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "新增";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // 修改
            // 
            this.修改.Caption = "修改";
            this.修改.Enabled = false;
            this.修改.Id = 1;
            this.修改.Name = "修改";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // FrmTest_WF2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(789, 414);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.searchLookUpEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.treeList1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmTest_WF2";
            this.TabText = "FrmTest_WF2";
            this.Text = "FrmTest_WF2";
            this.Load += new System.EventHandler(this.FrmTest_WF2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PrReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerToolBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView;
        private System.Data.DataSet dataSet_PrReq;
        private System.Data.DataTable dataTablePrReqHead;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColPrReqNo;
        private System.Data.DataColumn dataColReqDate;
        private System.Data.DataColumn dataColReqDep;
        private System.Data.DataColumn dataColProjectNo;
        private System.Data.DataColumn dataColStnNo;
        private System.Data.DataColumn dataColPurCategory;
        private System.Data.DataColumn dataColReqState;
        private System.Data.DataColumn dataColApplicant;
        private System.Data.DataColumn dataColApplicantIp;
        private System.Data.DataColumn dataColApplicantTime;
        private System.Data.DataColumn dataColModifier;
        private System.Data.DataColumn dataColModifierIp;
        private System.Data.DataColumn dataColModifierTime;
        private System.Data.DataColumn dataColApprover;
        private System.Data.DataColumn dataColApproverIp;
        private System.Data.DataColumn dataColApproverTime;
        private System.Data.DataColumn dataColPrReqRemark;
        private System.Data.DataColumn dataColSelect;
        private System.Data.DataColumn dataColClosed;
        private System.Data.DataColumn dataColClosedIp;
        private System.Data.DataColumn dataColClosedTime;        
        private DevExpress.XtraGrid.Columns.GridColumn columnName;
        private DevExpress.XtraGrid.Columns.GridColumn columnPath;
        private DevExpress.XtraGrid.Columns.GridColumn columnCheck;
        private DevExpress.XtraGrid.Columns.GridColumn columnGroup;
        private DevExpress.XtraGrid.Columns.GridColumn columnImage;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraBars.BarManager barManagerToolBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem 修改;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        public DevExpress.XtraBars.Bar barToolBar;
    }
}