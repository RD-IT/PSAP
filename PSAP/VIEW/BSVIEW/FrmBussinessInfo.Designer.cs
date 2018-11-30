﻿namespace PSAP.VIEW.BSVIEW
{
    partial class FrmBussinessInfo
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
            System.Windows.Forms.Label bussinessBaseNoLabel;
            System.Windows.Forms.Label companyLRLabel;
            System.Windows.Forms.Label companyAddressLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.Windows.Forms.Label phoneNoLabel;
            System.Windows.Forms.Label faxNoLabel;
            System.Windows.Forms.Label e_mailLabel;
            System.Windows.Forms.Label webSiteLabel;
            System.Windows.Forms.Label countryCodeLabel;
            System.Windows.Forms.Label bussinessLicenseLabel;
            System.Windows.Forms.Label bankAccoutLabel;
            System.Windows.Forms.Label bankAddressLabel;
            System.Windows.Forms.Label bussinessBaseNoLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBussinessInfo));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.gdBussinessBaseInfo = new DevExpress.XtraGrid.GridControl();
            this.gdvBussinessBaseInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsBussinessCategory = new System.Windows.Forms.BindingSource(this.components);
            this.dsPSAP = new PSAP.dsPSAP();
            this.colBussinessIsUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbDGViewExportToCSV = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUse = new System.Windows.Forms.CheckBox();
            this.cboBussinessCategory = new System.Windows.Forms.ComboBox();
            this.btnStretch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBussinessBaseNo = new System.Windows.Forms.TextBox();
            this.txtBussinessBaseText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bussinessBaseNoTextBox1 = new System.Windows.Forms.TextBox();
            this.bussinessBaseNoTextBox = new System.Windows.Forms.TextBox();
            this.tabBussinessInfo = new System.Windows.Forms.TabControl();
            this.tpBussinessDetailInfo = new System.Windows.Forms.TabPage();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.cboCountryCode = new System.Windows.Forms.ComboBox();
            this.companyLRTextBox = new System.Windows.Forms.TextBox();
            this.companyAddressTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.faxNoTextBox = new System.Windows.Forms.TextBox();
            this.e_mailTextBox = new System.Windows.Forms.TextBox();
            this.webSiteTextBox = new System.Windows.Forms.TextBox();
            this.tpBussinessFinancialInfo = new System.Windows.Forms.TabPage();
            this.pnlEdit1 = new System.Windows.Forms.Panel();
            this.bussinessLicenseTextBox = new System.Windows.Forms.TextBox();
            this.bankAccoutTextBox = new System.Windows.Forms.TextBox();
            this.bankAddressTextBox = new System.Windows.Forms.TextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.bS_BussinessCategoryTableAdapter = new PSAP.dsPSAPTableAdapters.BS_BussinessCategoryTableAdapter();
            this.bsCountry = new System.Windows.Forms.BindingSource(this.components);
            this.bS_CountryCodeManagementTableAdapter = new PSAP.dsPSAPTableAdapters.BS_CountryCodeManagementTableAdapter();
            bussinessBaseNoLabel = new System.Windows.Forms.Label();
            companyLRLabel = new System.Windows.Forms.Label();
            companyAddressLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            phoneNoLabel = new System.Windows.Forms.Label();
            faxNoLabel = new System.Windows.Forms.Label();
            e_mailLabel = new System.Windows.Forms.Label();
            webSiteLabel = new System.Windows.Forms.Label();
            countryCodeLabel = new System.Windows.Forms.Label();
            bussinessLicenseLabel = new System.Windows.Forms.Label();
            bankAccoutLabel = new System.Windows.Forms.Label();
            bankAddressLabel = new System.Windows.Forms.Label();
            bussinessBaseNoLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdBussinessBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBussinessBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBussinessCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).BeginInit();
            this.panel1.SuspendLayout();
            this.tsControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabBussinessInfo.SuspendLayout();
            this.tpBussinessDetailInfo.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.tpBussinessFinancialInfo.SuspendLayout();
            this.pnlEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // bussinessBaseNoLabel
            // 
            bussinessBaseNoLabel.AutoSize = true;
            bussinessBaseNoLabel.Location = new System.Drawing.Point(136, 261);
            bussinessBaseNoLabel.Name = "bussinessBaseNoLabel";
            bussinessBaseNoLabel.Size = new System.Drawing.Size(65, 12);
            bussinessBaseNoLabel.TabIndex = 2;
            bussinessBaseNoLabel.Text = "往来方编号";
            bussinessBaseNoLabel.Visible = false;
            // 
            // companyLRLabel
            // 
            companyLRLabel.AutoSize = true;
            companyLRLabel.Location = new System.Drawing.Point(3, 39);
            companyLRLabel.Name = "companyLRLabel";
            companyLRLabel.Size = new System.Drawing.Size(29, 12);
            companyLRLabel.TabIndex = 4;
            companyLRLabel.Text = "法人";
            // 
            // companyAddressLabel
            // 
            companyAddressLabel.AutoSize = true;
            companyAddressLabel.Location = new System.Drawing.Point(3, 66);
            companyAddressLabel.Name = "companyAddressLabel";
            companyAddressLabel.Size = new System.Drawing.Size(53, 12);
            companyAddressLabel.TabIndex = 6;
            companyAddressLabel.Text = "公司地址";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(3, 93);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(53, 12);
            zipCodeLabel.TabIndex = 8;
            zipCodeLabel.Text = "邮政编码";
            // 
            // phoneNoLabel
            // 
            phoneNoLabel.AutoSize = true;
            phoneNoLabel.Location = new System.Drawing.Point(3, 120);
            phoneNoLabel.Name = "phoneNoLabel";
            phoneNoLabel.Size = new System.Drawing.Size(29, 12);
            phoneNoLabel.TabIndex = 10;
            phoneNoLabel.Text = "电话";
            // 
            // faxNoLabel
            // 
            faxNoLabel.AutoSize = true;
            faxNoLabel.Location = new System.Drawing.Point(3, 147);
            faxNoLabel.Name = "faxNoLabel";
            faxNoLabel.Size = new System.Drawing.Size(29, 12);
            faxNoLabel.TabIndex = 12;
            faxNoLabel.Text = "传真";
            // 
            // e_mailLabel
            // 
            e_mailLabel.AutoSize = true;
            e_mailLabel.Location = new System.Drawing.Point(3, 174);
            e_mailLabel.Name = "e_mailLabel";
            e_mailLabel.Size = new System.Drawing.Size(29, 12);
            e_mailLabel.TabIndex = 14;
            e_mailLabel.Text = "邮箱";
            // 
            // webSiteLabel
            // 
            webSiteLabel.AutoSize = true;
            webSiteLabel.Location = new System.Drawing.Point(3, 201);
            webSiteLabel.Name = "webSiteLabel";
            webSiteLabel.Size = new System.Drawing.Size(29, 12);
            webSiteLabel.TabIndex = 16;
            webSiteLabel.Text = "网站";
            // 
            // countryCodeLabel
            // 
            countryCodeLabel.AutoSize = true;
            countryCodeLabel.Location = new System.Drawing.Point(3, 228);
            countryCodeLabel.Name = "countryCodeLabel";
            countryCodeLabel.Size = new System.Drawing.Size(29, 12);
            countryCodeLabel.TabIndex = 18;
            countryCodeLabel.Text = "国家";
            // 
            // bussinessLicenseLabel
            // 
            bussinessLicenseLabel.AutoSize = true;
            bussinessLicenseLabel.Location = new System.Drawing.Point(3, 40);
            bussinessLicenseLabel.Name = "bussinessLicenseLabel";
            bussinessLicenseLabel.Size = new System.Drawing.Size(77, 12);
            bussinessLicenseLabel.TabIndex = 4;
            bussinessLicenseLabel.Text = "营业执照号码";
            // 
            // bankAccoutLabel
            // 
            bankAccoutLabel.AutoSize = true;
            bankAccoutLabel.Location = new System.Drawing.Point(3, 67);
            bankAccoutLabel.Name = "bankAccoutLabel";
            bankAccoutLabel.Size = new System.Drawing.Size(53, 12);
            bankAccoutLabel.TabIndex = 6;
            bankAccoutLabel.Text = "银行账号";
            // 
            // bankAddressLabel
            // 
            bankAddressLabel.AutoSize = true;
            bankAddressLabel.Location = new System.Drawing.Point(3, 94);
            bankAddressLabel.Name = "bankAddressLabel";
            bankAddressLabel.Size = new System.Drawing.Size(41, 12);
            bankAddressLabel.TabIndex = 8;
            bankAddressLabel.Text = "开户行";
            // 
            // bussinessBaseNoLabel1
            // 
            bussinessBaseNoLabel1.AutoSize = true;
            bussinessBaseNoLabel1.Location = new System.Drawing.Point(322, 261);
            bussinessBaseNoLabel1.Name = "bussinessBaseNoLabel1";
            bussinessBaseNoLabel1.Size = new System.Drawing.Size(65, 12);
            bussinessBaseNoLabel1.TabIndex = 21;
            bussinessBaseNoLabel1.Text = "往来方编号";
            bussinessBaseNoLabel1.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.gdBussinessBaseInfo);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(bussinessBaseNoLabel);
            this.splitContainer2.Panel1.Controls.Add(this.bussinessBaseNoTextBox1);
            this.splitContainer2.Panel1.Controls.Add(this.bussinessBaseNoTextBox);
            this.splitContainer2.Panel1.Controls.Add(bussinessBaseNoLabel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabBussinessInfo);
            this.splitContainer2.Size = new System.Drawing.Size(1006, 628);
            this.splitContainer2.SplitterDistance = 531;
            this.splitContainer2.TabIndex = 2;
            // 
            // gdBussinessBaseInfo
            // 
            this.gdBussinessBaseInfo.Location = new System.Drawing.Point(0, 145);
            this.gdBussinessBaseInfo.MainView = this.gdvBussinessBaseInfo;
            this.gdBussinessBaseInfo.Name = "gdBussinessBaseInfo";
            this.gdBussinessBaseInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gdBussinessBaseInfo.Size = new System.Drawing.Size(511, 467);
            this.gdBussinessBaseInfo.TabIndex = 24;
            this.gdBussinessBaseInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvBussinessBaseInfo});
            // 
            // gdvBussinessBaseInfo
            // 
            this.gdvBussinessBaseInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colBussinessBaseNo,
            this.colBussinessBaseText,
            this.colBussinessCategory,
            this.colBussinessIsUse});
            this.gdvBussinessBaseInfo.GridControl = this.gdBussinessBaseInfo;
            this.gdvBussinessBaseInfo.Name = "gdvBussinessBaseInfo";
            this.gdvBussinessBaseInfo.OptionsView.ShowDetailButtons = false;
            this.gdvBussinessBaseInfo.OptionsView.ShowGroupPanel = false;
            this.gdvBussinessBaseInfo.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gdvBussinessBaseInfo_SelectionChanged);
            this.gdvBussinessBaseInfo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvBussinessBaseInfo_FocusedRowChanged);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colBussinessBaseNo
            // 
            this.colBussinessBaseNo.Caption = "往来方编号";
            this.colBussinessBaseNo.FieldName = "BussinessBaseNo";
            this.colBussinessBaseNo.Name = "colBussinessBaseNo";
            this.colBussinessBaseNo.Visible = true;
            this.colBussinessBaseNo.VisibleIndex = 0;
            // 
            // colBussinessBaseText
            // 
            this.colBussinessBaseText.Caption = "往来方名称";
            this.colBussinessBaseText.FieldName = "BussinessBaseText";
            this.colBussinessBaseText.Name = "colBussinessBaseText";
            this.colBussinessBaseText.Visible = true;
            this.colBussinessBaseText.VisibleIndex = 1;
            // 
            // colBussinessCategory
            // 
            this.colBussinessCategory.Caption = "往来方分类";
            this.colBussinessCategory.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colBussinessCategory.FieldName = "BussinessCategory";
            this.colBussinessCategory.Name = "colBussinessCategory";
            this.colBussinessCategory.Visible = true;
            this.colBussinessCategory.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "Auto Id", 65, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BussinessCategory", "", 113, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BussinessCategoryText", "往来方分类", 143, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.bsBussinessCategory;
            this.repositoryItemLookUpEdit1.DisplayMember = "BussinessCategoryText";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "BussinessCategory";
            // 
            // bsBussinessCategory
            // 
            this.bsBussinessCategory.DataMember = "BS_BussinessCategory";
            this.bsBussinessCategory.DataSource = this.dsPSAP;
            // 
            // dsPSAP
            // 
            this.dsPSAP.DataSetName = "dsPSAP";
            this.dsPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colBussinessIsUse
            // 
            this.colBussinessIsUse.Caption = "是否使用";
            this.colBussinessIsUse.FieldName = "BussinessIsUse";
            this.colBussinessIsUse.Name = "colBussinessIsUse";
            this.colBussinessIsUse.Visible = true;
            this.colBussinessIsUse.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tsControl);
            this.panel1.Location = new System.Drawing.Point(4, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 25);
            this.panel1.TabIndex = 23;
            // 
            // tsControl
            // 
            this.tsControl.Dock = System.Windows.Forms.DockStyle.None;
            this.tsControl.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbSave,
            this.tsbCancel,
            this.tsbQuery,
            this.tsbDGViewExportToCSV,
            this.tsbClose});
            this.tsControl.Location = new System.Drawing.Point(0, 0);
            this.tsControl.Name = "tsControl";
            this.tsControl.Size = new System.Drawing.Size(443, 25);
            this.tsControl.TabIndex = 4;
            this.tsControl.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(52, 22);
            this.tsbAdd.Text = "新增";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(52, 22);
            this.tsbEdit.Text = "编辑";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(52, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(52, 22);
            this.tsbCancel.Text = "取消";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbQuery
            // 
            this.tsbQuery.Image = ((System.Drawing.Image)(resources.GetObject("tsbQuery.Image")));
            this.tsbQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbQuery.Name = "tsbQuery";
            this.tsbQuery.Size = new System.Drawing.Size(52, 22);
            this.tsbQuery.Text = "查询";
            // 
            // tsbDGViewExportToCSV
            // 
            this.tsbDGViewExportToCSV.Image = ((System.Drawing.Image)(resources.GetObject("tsbDGViewExportToCSV.Image")));
            this.tsbDGViewExportToCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDGViewExportToCSV.Name = "tsbDGViewExportToCSV";
            this.tsbDGViewExportToCSV.Size = new System.Drawing.Size(76, 22);
            this.tsbDGViewExportToCSV.Text = "导出数据";
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(52, 22);
            this.tsbClose.Text = "退出";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUse);
            this.groupBox1.Controls.Add(this.cboBussinessCategory);
            this.groupBox1.Controls.Add(this.btnStretch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBussinessBaseNo);
            this.groupBox1.Controls.Add(this.txtBussinessBaseText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 92);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "商业往来方信息筛选";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chkUse
            // 
            this.chkUse.AutoSize = true;
            this.chkUse.Location = new System.Drawing.Point(187, 60);
            this.chkUse.Name = "chkUse";
            this.chkUse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkUse.Size = new System.Drawing.Size(48, 16);
            this.chkUse.TabIndex = 20;
            this.chkUse.Text = "使用";
            this.chkUse.UseVisualStyleBackColor = true;
            // 
            // cboBussinessCategory
            // 
            this.cboBussinessCategory.DisplayMember = "BussinessCategory";
            this.cboBussinessCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBussinessCategory.FormattingEnabled = true;
            this.cboBussinessCategory.Location = new System.Drawing.Point(77, 56);
            this.cboBussinessCategory.Name = "cboBussinessCategory";
            this.cboBussinessCategory.Size = new System.Drawing.Size(73, 20);
            this.cboBussinessCategory.TabIndex = 19;
            this.cboBussinessCategory.ValueMember = "BussinessCategory";
            // 
            // btnStretch
            // 
            this.btnStretch.Location = new System.Drawing.Point(276, 56);
            this.btnStretch.Name = "btnStretch";
            this.btnStretch.Size = new System.Drawing.Size(85, 23);
            this.btnStretch.TabIndex = 11;
            this.btnStretch.Text = "筛选";
            this.btnStretch.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "往来方分类";
            // 
            // txtBussinessBaseNo
            // 
            this.txtBussinessBaseNo.Location = new System.Drawing.Point(76, 27);
            this.txtBussinessBaseNo.Name = "txtBussinessBaseNo";
            this.txtBussinessBaseNo.Size = new System.Drawing.Size(73, 21);
            this.txtBussinessBaseNo.TabIndex = 12;
            // 
            // txtBussinessBaseText
            // 
            this.txtBussinessBaseText.Location = new System.Drawing.Point(241, 27);
            this.txtBussinessBaseText.Name = "txtBussinessBaseText";
            this.txtBussinessBaseText.Size = new System.Drawing.Size(73, 21);
            this.txtBussinessBaseText.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "往来方名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "往来方编号";
            // 
            // bussinessBaseNoTextBox1
            // 
            this.bussinessBaseNoTextBox1.Location = new System.Drawing.Point(378, 258);
            this.bussinessBaseNoTextBox1.Name = "bussinessBaseNoTextBox1";
            this.bussinessBaseNoTextBox1.Size = new System.Drawing.Size(100, 21);
            this.bussinessBaseNoTextBox1.TabIndex = 20;
            // 
            // bussinessBaseNoTextBox
            // 
            this.bussinessBaseNoTextBox.Location = new System.Drawing.Point(207, 258);
            this.bussinessBaseNoTextBox.Name = "bussinessBaseNoTextBox";
            this.bussinessBaseNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.bussinessBaseNoTextBox.TabIndex = 3;
            this.bussinessBaseNoTextBox.TextChanged += new System.EventHandler(this.bussinessBaseNoTextBox_TextChanged);
            this.bussinessBaseNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bussinessBaseNoTextBox_KeyPress);
            // 
            // tabBussinessInfo
            // 
            this.tabBussinessInfo.Controls.Add(this.tpBussinessDetailInfo);
            this.tabBussinessInfo.Controls.Add(this.tpBussinessFinancialInfo);
            this.tabBussinessInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBussinessInfo.Location = new System.Drawing.Point(0, 0);
            this.tabBussinessInfo.Name = "tabBussinessInfo";
            this.tabBussinessInfo.SelectedIndex = 0;
            this.tabBussinessInfo.Size = new System.Drawing.Size(471, 628);
            this.tabBussinessInfo.TabIndex = 2;
            // 
            // tpBussinessDetailInfo
            // 
            this.tpBussinessDetailInfo.AutoScroll = true;
            this.tpBussinessDetailInfo.Controls.Add(this.pnlEdit);
            this.tpBussinessDetailInfo.Location = new System.Drawing.Point(4, 22);
            this.tpBussinessDetailInfo.Name = "tpBussinessDetailInfo";
            this.tpBussinessDetailInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBussinessDetailInfo.Size = new System.Drawing.Size(463, 602);
            this.tpBussinessDetailInfo.TabIndex = 0;
            this.tpBussinessDetailInfo.Text = "往来方详细信息";
            this.tpBussinessDetailInfo.UseVisualStyleBackColor = true;
            // 
            // pnlEdit
            // 
            this.pnlEdit.AutoSize = true;
            this.pnlEdit.Controls.Add(this.cboCountryCode);
            this.pnlEdit.Controls.Add(companyLRLabel);
            this.pnlEdit.Controls.Add(this.companyLRTextBox);
            this.pnlEdit.Controls.Add(companyAddressLabel);
            this.pnlEdit.Controls.Add(this.companyAddressTextBox);
            this.pnlEdit.Controls.Add(zipCodeLabel);
            this.pnlEdit.Controls.Add(this.zipCodeTextBox);
            this.pnlEdit.Controls.Add(phoneNoLabel);
            this.pnlEdit.Controls.Add(this.phoneNoTextBox);
            this.pnlEdit.Controls.Add(faxNoLabel);
            this.pnlEdit.Controls.Add(this.faxNoTextBox);
            this.pnlEdit.Controls.Add(e_mailLabel);
            this.pnlEdit.Controls.Add(this.e_mailTextBox);
            this.pnlEdit.Controls.Add(webSiteLabel);
            this.pnlEdit.Controls.Add(this.webSiteTextBox);
            this.pnlEdit.Controls.Add(countryCodeLabel);
            this.pnlEdit.Enabled = false;
            this.pnlEdit.Location = new System.Drawing.Point(6, 6);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(392, 297);
            this.pnlEdit.TabIndex = 4;
            // 
            // cboCountryCode
            // 
            this.cboCountryCode.DataSource = this.bsCountry;
            this.cboCountryCode.DisplayMember = "CountryName";
            this.cboCountryCode.FormattingEnabled = true;
            this.cboCountryCode.Location = new System.Drawing.Point(122, 225);
            this.cboCountryCode.Name = "cboCountryCode";
            this.cboCountryCode.Size = new System.Drawing.Size(100, 20);
            this.cboCountryCode.TabIndex = 19;
            this.cboCountryCode.ValueMember = "CountryCode";
            this.cboCountryCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboCountryCode_KeyPress);
            // 
            // companyLRTextBox
            // 
            this.companyLRTextBox.Location = new System.Drawing.Point(122, 36);
            this.companyLRTextBox.Name = "companyLRTextBox";
            this.companyLRTextBox.Size = new System.Drawing.Size(100, 21);
            this.companyLRTextBox.TabIndex = 5;
            this.companyLRTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.companyLRTextBox_KeyPress);
            // 
            // companyAddressTextBox
            // 
            this.companyAddressTextBox.Location = new System.Drawing.Point(122, 63);
            this.companyAddressTextBox.Name = "companyAddressTextBox";
            this.companyAddressTextBox.Size = new System.Drawing.Size(100, 21);
            this.companyAddressTextBox.TabIndex = 7;
            this.companyAddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.companyAddressTextBox_KeyPress);
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(122, 90);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(100, 21);
            this.zipCodeTextBox.TabIndex = 9;
            this.zipCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zipCodeTextBox_KeyPress);
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.Location = new System.Drawing.Point(122, 117);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.phoneNoTextBox.TabIndex = 11;
            this.phoneNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNoTextBox_KeyPress);
            // 
            // faxNoTextBox
            // 
            this.faxNoTextBox.Location = new System.Drawing.Point(122, 144);
            this.faxNoTextBox.Name = "faxNoTextBox";
            this.faxNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.faxNoTextBox.TabIndex = 13;
            this.faxNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.faxNoTextBox_KeyPress);
            // 
            // e_mailTextBox
            // 
            this.e_mailTextBox.Location = new System.Drawing.Point(122, 171);
            this.e_mailTextBox.Name = "e_mailTextBox";
            this.e_mailTextBox.Size = new System.Drawing.Size(100, 21);
            this.e_mailTextBox.TabIndex = 15;
            this.e_mailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.e_mailTextBox_KeyPress);
            // 
            // webSiteTextBox
            // 
            this.webSiteTextBox.Location = new System.Drawing.Point(122, 198);
            this.webSiteTextBox.Name = "webSiteTextBox";
            this.webSiteTextBox.Size = new System.Drawing.Size(100, 21);
            this.webSiteTextBox.TabIndex = 17;
            this.webSiteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.webSiteTextBox_KeyPress);
            // 
            // tpBussinessFinancialInfo
            // 
            this.tpBussinessFinancialInfo.Controls.Add(this.pnlEdit1);
            this.tpBussinessFinancialInfo.Location = new System.Drawing.Point(4, 22);
            this.tpBussinessFinancialInfo.Name = "tpBussinessFinancialInfo";
            this.tpBussinessFinancialInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpBussinessFinancialInfo.Size = new System.Drawing.Size(463, 602);
            this.tpBussinessFinancialInfo.TabIndex = 1;
            this.tpBussinessFinancialInfo.Text = "往来方金融信息";
            this.tpBussinessFinancialInfo.UseVisualStyleBackColor = true;
            // 
            // pnlEdit1
            // 
            this.pnlEdit1.AutoSize = true;
            this.pnlEdit1.Controls.Add(bankAccoutLabel);
            this.pnlEdit1.Controls.Add(this.bussinessLicenseTextBox);
            this.pnlEdit1.Controls.Add(this.bankAccoutTextBox);
            this.pnlEdit1.Controls.Add(this.bankAddressTextBox);
            this.pnlEdit1.Controls.Add(bussinessLicenseLabel);
            this.pnlEdit1.Controls.Add(bankAddressLabel);
            this.pnlEdit1.Enabled = false;
            this.pnlEdit1.Location = new System.Drawing.Point(6, 6);
            this.pnlEdit1.Name = "pnlEdit1";
            this.pnlEdit1.Size = new System.Drawing.Size(408, 187);
            this.pnlEdit1.TabIndex = 5;
            // 
            // bussinessLicenseTextBox
            // 
            this.bussinessLicenseTextBox.Location = new System.Drawing.Point(122, 37);
            this.bussinessLicenseTextBox.Name = "bussinessLicenseTextBox";
            this.bussinessLicenseTextBox.Size = new System.Drawing.Size(100, 21);
            this.bussinessLicenseTextBox.TabIndex = 5;
            this.bussinessLicenseTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bussinessLicenseTextBox_KeyPress);
            // 
            // bankAccoutTextBox
            // 
            this.bankAccoutTextBox.Location = new System.Drawing.Point(122, 64);
            this.bankAccoutTextBox.Name = "bankAccoutTextBox";
            this.bankAccoutTextBox.Size = new System.Drawing.Size(100, 21);
            this.bankAccoutTextBox.TabIndex = 7;
            this.bankAccoutTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bankAccoutTextBox_KeyPress);
            // 
            // bankAddressTextBox
            // 
            this.bankAddressTextBox.Location = new System.Drawing.Point(122, 91);
            this.bankAddressTextBox.Name = "bankAddressTextBox";
            this.bankAddressTextBox.Size = new System.Drawing.Size(100, 21);
            this.bankAddressTextBox.TabIndex = 9;
            this.bankAddressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bankAddressTextBox_KeyPress);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // bS_BussinessCategoryTableAdapter
            // 
            this.bS_BussinessCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // bsCountry
            // 
            this.bsCountry.DataMember = "BS_CountryCodeManagement";
            this.bsCountry.DataSource = this.dsPSAP;
            // 
            // bS_CountryCodeManagementTableAdapter
            // 
            this.bS_CountryCodeManagementTableAdapter.ClearBeforeFill = true;
            // 
            // FrmBussinessInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 628);
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "FrmBussinessInfo";
            this.TabText = "商业往来信息";
            this.Text = "商业往来信息";
            this.Load += new System.EventHandler(this.FrmBussinessInfo_Load);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdBussinessBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBussinessBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBussinessCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabBussinessInfo.ResumeLayout(false);
            this.tpBussinessDetailInfo.ResumeLayout(false);
            this.tpBussinessDetailInfo.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.tpBussinessFinancialInfo.ResumeLayout(false);
            this.tpBussinessFinancialInfo.PerformLayout();
            this.pnlEdit1.ResumeLayout(false);
            this.pnlEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ComboBox cboBussinessCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBussinessBaseText;
        private System.Windows.Forms.TextBox txtBussinessBaseNo;
        private System.Windows.Forms.Button btnStretch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkUse;
        private System.Windows.Forms.TabControl tabBussinessInfo;
        private System.Windows.Forms.TabPage tpBussinessDetailInfo;
        private System.Windows.Forms.TabPage tpBussinessFinancialInfo;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.TextBox bussinessBaseNoTextBox;
        private System.Windows.Forms.TextBox companyLRTextBox;
        private System.Windows.Forms.TextBox companyAddressTextBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.TextBox faxNoTextBox;
        private System.Windows.Forms.TextBox e_mailTextBox;
        private System.Windows.Forms.TextBox webSiteTextBox;
        private System.Windows.Forms.Panel pnlEdit1;
        private System.Windows.Forms.TextBox bussinessLicenseTextBox;
        private System.Windows.Forms.TextBox bankAccoutTextBox;
        private System.Windows.Forms.TextBox bankAddressTextBox;
        private System.Windows.Forms.ComboBox cboCountryCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbDGViewExportToCSV;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private DevExpress.XtraGrid.GridControl gdBussinessBaseInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvBussinessBaseInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessIsUse;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.TextBox bussinessBaseNoTextBox1;
        private System.Windows.Forms.BindingSource bsBussinessCategory;
        private dsPSAP dsPSAP;
        private dsPSAPTableAdapters.BS_BussinessCategoryTableAdapter bS_BussinessCategoryTableAdapter;
        private System.Windows.Forms.BindingSource bsCountry;
        private dsPSAPTableAdapters.BS_CountryCodeManagementTableAdapter bS_CountryCodeManagementTableAdapter;
    }
}