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
            this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrReqNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqDep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProjectNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReqState = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApplicant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApplicantIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApplicantTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModifierTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApprover = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApproverTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrReqRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosedIp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClosedTime = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PrReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Location = new System.Drawing.Point(12, 12);
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
            this.simpleButton1.Location = new System.Drawing.Point(501, 24);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(159, 46);
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
            this.gridControl1.Location = new System.Drawing.Point(279, 76);
            this.gridControl1.MainView = this.winExplorerView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(504, 274);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView1});
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
            // winExplorerView1
            // 
            this.winExplorerView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colPrReqNo,
            this.colReqDate,
            this.colReqDep,
            this.colProjectNo,
            this.colStnNo,
            this.colPurCategory,
            this.colReqState,
            this.colApplicant,
            this.colApplicantIp,
            this.colApplicantTime,
            this.colModifier,
            this.colModifierIp,
            this.colModifierTime,
            this.colApprover,
            this.colApproverIp,
            this.colApproverTime,
            this.colPrReqRemark,
            this.colSelect,
            this.colClosed,
            this.colClosedIp,
            this.colClosedTime});
            this.winExplorerView1.ColumnSet.MediumImageIndexColumn = this.colReqState;
            this.winExplorerView1.ColumnSet.TextColumn = this.colPrReqNo;
            this.winExplorerView1.GridControl = this.gridControl1;
            this.winExplorerView1.MediumImages = this.imageList1;
            this.winExplorerView1.Name = "winExplorerView1";
            this.winExplorerView1.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Slide;
            this.winExplorerView1.OptionsImageLoad.AsyncLoad = true;
            this.winExplorerView1.OptionsImageLoad.CacheThumbnails = false;
            this.winExplorerView1.OptionsImageLoad.LoadThumbnailImagesFromDataSource = false;
            this.winExplorerView1.OptionsSelection.AllowMarqueeSelection = true;
            this.winExplorerView1.OptionsSelection.ItemSelectionMode = DevExpress.XtraGrid.Views.WinExplorer.IconItemSelectionMode.Click;
            this.winExplorerView1.OptionsSelection.MultiSelect = true;
            this.winExplorerView1.OptionsView.ShowExpandCollapseButtons = true;
            this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Medium;
            this.winExplorerView1.OptionsViewStyles.Content.ItemWidth = 502;
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.ImageSize = new System.Drawing.Size(220, 129);
            this.winExplorerView1.OptionsViewStyles.Large.ImageSize = new System.Drawing.Size(96, 56);
            this.winExplorerView1.OptionsViewStyles.Medium.ImageSize = new System.Drawing.Size(32, 32);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            this.colAutoId.Visible = true;
            this.colAutoId.VisibleIndex = 0;
            // 
            // colPrReqNo
            // 
            this.colPrReqNo.FieldName = "PrReqNo";
            this.colPrReqNo.Name = "colPrReqNo";
            this.colPrReqNo.Visible = true;
            this.colPrReqNo.VisibleIndex = 1;
            // 
            // colReqDate
            // 
            this.colReqDate.FieldName = "ReqDate";
            this.colReqDate.Name = "colReqDate";
            this.colReqDate.Visible = true;
            this.colReqDate.VisibleIndex = 2;
            // 
            // colReqDep
            // 
            this.colReqDep.FieldName = "ReqDep";
            this.colReqDep.Name = "colReqDep";
            this.colReqDep.Visible = true;
            this.colReqDep.VisibleIndex = 3;
            // 
            // colProjectNo
            // 
            this.colProjectNo.FieldName = "ProjectNo";
            this.colProjectNo.Name = "colProjectNo";
            this.colProjectNo.Visible = true;
            this.colProjectNo.VisibleIndex = 4;
            // 
            // colStnNo
            // 
            this.colStnNo.FieldName = "StnNo";
            this.colStnNo.Name = "colStnNo";
            this.colStnNo.Visible = true;
            this.colStnNo.VisibleIndex = 5;
            // 
            // colPurCategory
            // 
            this.colPurCategory.FieldName = "PurCategory";
            this.colPurCategory.Name = "colPurCategory";
            this.colPurCategory.Visible = true;
            this.colPurCategory.VisibleIndex = 6;
            // 
            // colReqState
            // 
            this.colReqState.FieldName = "ReqState";
            this.colReqState.Name = "colReqState";
            this.colReqState.Visible = true;
            this.colReqState.VisibleIndex = 7;
            // 
            // colApplicant
            // 
            this.colApplicant.FieldName = "Applicant";
            this.colApplicant.Name = "colApplicant";
            this.colApplicant.Visible = true;
            this.colApplicant.VisibleIndex = 8;
            // 
            // colApplicantIp
            // 
            this.colApplicantIp.FieldName = "ApplicantIp";
            this.colApplicantIp.Name = "colApplicantIp";
            this.colApplicantIp.Visible = true;
            this.colApplicantIp.VisibleIndex = 9;
            // 
            // colApplicantTime
            // 
            this.colApplicantTime.FieldName = "ApplicantTime";
            this.colApplicantTime.Name = "colApplicantTime";
            this.colApplicantTime.Visible = true;
            this.colApplicantTime.VisibleIndex = 10;
            // 
            // colModifier
            // 
            this.colModifier.FieldName = "Modifier";
            this.colModifier.Name = "colModifier";
            this.colModifier.Visible = true;
            this.colModifier.VisibleIndex = 11;
            // 
            // colModifierIp
            // 
            this.colModifierIp.FieldName = "ModifierIp";
            this.colModifierIp.Name = "colModifierIp";
            this.colModifierIp.Visible = true;
            this.colModifierIp.VisibleIndex = 12;
            // 
            // colModifierTime
            // 
            this.colModifierTime.FieldName = "ModifierTime";
            this.colModifierTime.Name = "colModifierTime";
            this.colModifierTime.Visible = true;
            this.colModifierTime.VisibleIndex = 13;
            // 
            // colApprover
            // 
            this.colApprover.FieldName = "Approver";
            this.colApprover.Name = "colApprover";
            this.colApprover.Visible = true;
            this.colApprover.VisibleIndex = 14;
            // 
            // colApproverIp
            // 
            this.colApproverIp.FieldName = "ApproverIp";
            this.colApproverIp.Name = "colApproverIp";
            this.colApproverIp.Visible = true;
            this.colApproverIp.VisibleIndex = 15;
            // 
            // colApproverTime
            // 
            this.colApproverTime.FieldName = "ApproverTime";
            this.colApproverTime.Name = "colApproverTime";
            this.colApproverTime.Visible = true;
            this.colApproverTime.VisibleIndex = 16;
            // 
            // colPrReqRemark
            // 
            this.colPrReqRemark.FieldName = "PrReqRemark";
            this.colPrReqRemark.Name = "colPrReqRemark";
            this.colPrReqRemark.Visible = true;
            this.colPrReqRemark.VisibleIndex = 17;
            // 
            // colSelect
            // 
            this.colSelect.FieldName = "Select";
            this.colSelect.Name = "colSelect";
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 18;
            // 
            // colClosed
            // 
            this.colClosed.FieldName = "Closed";
            this.colClosed.Name = "colClosed";
            this.colClosed.Visible = true;
            this.colClosed.VisibleIndex = 19;
            // 
            // colClosedIp
            // 
            this.colClosedIp.FieldName = "ClosedIp";
            this.colClosedIp.Name = "colClosedIp";
            this.colClosedIp.Visible = true;
            this.colClosedIp.VisibleIndex = 20;
            // 
            // colClosedTime
            // 
            this.colClosedTime.FieldName = "ClosedTime";
            this.colClosedTime.Name = "colClosedTime";
            this.colClosedTime.Visible = true;
            this.colClosedTime.VisibleIndex = 21;
            // 
            // FrmTest_WF2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(789, 414);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.searchLookUpEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.treeList1);
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
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView1;
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
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqNo;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDate;
        private DevExpress.XtraGrid.Columns.GridColumn colReqDep;
        private DevExpress.XtraGrid.Columns.GridColumn colProjectNo;
        private DevExpress.XtraGrid.Columns.GridColumn colStnNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPurCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colReqState;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicant;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicantIp;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicantTime;
        private DevExpress.XtraGrid.Columns.GridColumn colModifier;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierIp;
        private DevExpress.XtraGrid.Columns.GridColumn colModifierTime;
        private DevExpress.XtraGrid.Columns.GridColumn colApprover;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverIp;
        private DevExpress.XtraGrid.Columns.GridColumn colApproverTime;
        private DevExpress.XtraGrid.Columns.GridColumn colPrReqRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraGrid.Columns.GridColumn colClosed;
        private DevExpress.XtraGrid.Columns.GridColumn colClosedIp;
        private DevExpress.XtraGrid.Columns.GridColumn colClosedTime;
    }
}