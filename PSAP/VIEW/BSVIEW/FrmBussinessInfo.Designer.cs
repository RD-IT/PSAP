namespace PSAP.VIEW.BSVIEW
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBussinessInfo));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.gdBussinessBaseInfo = new DevExpress.XtraGrid.GridControl();
            this.dataSet1 = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataTable2 = new System.Data.DataTable();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.dataColumn11 = new System.Data.DataColumn();
            this.dataColumn12 = new System.Data.DataColumn();
            this.dataColumn13 = new System.Data.DataColumn();
            this.dataColumn14 = new System.Data.DataColumn();
            this.dataColumn15 = new System.Data.DataColumn();
            this.dataColumn21 = new System.Data.DataColumn();
            this.dataTable3 = new System.Data.DataTable();
            this.dataColumn16 = new System.Data.DataColumn();
            this.dataColumn17 = new System.Data.DataColumn();
            this.dataColumn18 = new System.Data.DataColumn();
            this.dataColumn19 = new System.Data.DataColumn();
            this.dataColumn20 = new System.Data.DataColumn();
            this.gdvBussinessBaseInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsBussinessCategory = new System.Windows.Forms.BindingSource(this.components);
            this.dsPSAP = new PSAP.dsPSAP();
            this.colBussinessIsUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabBussinessInfo = new System.Windows.Forms.TabControl();
            this.tpBussinessDetailInfo = new System.Windows.Forms.TabPage();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.bsDetail = new System.Windows.Forms.BindingSource(this.components);
            this.txtWebSite = new DevExpress.XtraEditors.TextEdit();
            this.txtE_mail = new DevExpress.XtraEditors.TextEdit();
            this.txtFaxNo = new DevExpress.XtraEditors.TextEdit();
            this.txtPhoneNo = new DevExpress.XtraEditors.TextEdit();
            this.txtZipCode = new DevExpress.XtraEditors.TextEdit();
            this.txtCompanyAddress = new DevExpress.XtraEditors.TextEdit();
            this.TxtCompanyLR = new DevExpress.XtraEditors.TextEdit();
            this.lueCountryCode = new DevExpress.XtraEditors.LookUpEdit();
            this.tpBussinessFinancialInfo = new System.Windows.Forms.TabPage();
            this.pnlEdit1 = new System.Windows.Forms.Panel();
            this.txtBankAccout = new DevExpress.XtraEditors.TextEdit();
            this.bsFina = new System.Windows.Forms.BindingSource(this.components);
            this.txtBankAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtBussinessLicense = new DevExpress.XtraEditors.TextEdit();
            this.bsCountry = new System.Windows.Forms.BindingSource(this.components);
            this.bS_BussinessCategoryTableAdapter = new PSAP.dsPSAPTableAdapters.BS_BussinessCategoryTableAdapter();
            this.bS_CountryCodeManagementTableAdapter = new PSAP.dsPSAPTableAdapters.BS_CountryCodeManagementTableAdapter();
            this.bsBase = new System.Windows.Forms.BindingSource(this.components);
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
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tsControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdBussinessBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBussinessBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBussinessCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            this.tabBussinessInfo.SuspendLayout();
            this.tpBussinessDetailInfo.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebSite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtE_mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaxNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZipCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompanyLR.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCountryCode.Properties)).BeginInit();
            this.tpBussinessFinancialInfo.SuspendLayout();
            this.pnlEdit1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankAccout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBussinessLicense.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).BeginInit();
            this.SuspendLayout();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 257);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 12);
            label1.TabIndex = 28;
            label1.Text = "联系人";
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
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.gdBussinessBaseInfo);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tabBussinessInfo);
            this.splitContainer2.Size = new System.Drawing.Size(1006, 628);
            this.splitContainer2.SplitterDistance = 531;
            this.splitContainer2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tsControl);
            this.panel1.Location = new System.Drawing.Point(4, 3);
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
            this.tsbClose});
            this.tsControl.Location = new System.Drawing.Point(0, 0);
            this.tsControl.Name = "tsControl";
            this.tsControl.Size = new System.Drawing.Size(219, 25);
            this.tsControl.TabIndex = 4;
            this.tsControl.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(36, 22);
            this.tsbAdd.Text = "新增";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(36, 22);
            this.tsbEdit.Text = "编辑";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(36, 22);
            this.tsbDelete.Text = "删除";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(36, 22);
            this.tsbSave.Text = "保存";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbCancel
            // 
            this.tsbCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCancel.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancel.Image")));
            this.tsbCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancel.Name = "tsbCancel";
            this.tsbCancel.Size = new System.Drawing.Size(36, 22);
            this.tsbCancel.Text = "取消";
            this.tsbCancel.Click += new System.EventHandler(this.tsbCancel_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(36, 22);
            this.tsbClose.Text = "退出";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // gdBussinessBaseInfo
            // 
            this.gdBussinessBaseInfo.DataMember = "BussinessBaseInfo";
            this.gdBussinessBaseInfo.DataSource = this.dataSet1;
            this.gdBussinessBaseInfo.Location = new System.Drawing.Point(0, 34);
            this.gdBussinessBaseInfo.MainView = this.gdvBussinessBaseInfo;
            this.gdBussinessBaseInfo.Name = "gdBussinessBaseInfo";
            this.gdBussinessBaseInfo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemGridLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gdBussinessBaseInfo.Size = new System.Drawing.Size(511, 578);
            this.gdBussinessBaseInfo.TabIndex = 24;
            this.gdBussinessBaseInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvBussinessBaseInfo});
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1,
            this.dataTable2,
            this.dataTable3});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5});
            this.dataTable1.TableName = "BussinessBaseInfo";
            // 
            // dataColumn1
            // 
            this.dataColumn1.Caption = "自动编号";
            this.dataColumn1.ColumnName = "AutoId";
            this.dataColumn1.DataType = typeof(int);
            // 
            // dataColumn2
            // 
            this.dataColumn2.Caption = "往来方编号";
            this.dataColumn2.ColumnName = "BussinessBaseNo";
            // 
            // dataColumn3
            // 
            this.dataColumn3.Caption = "往来方名称";
            this.dataColumn3.ColumnName = "BussinessBaseText";
            // 
            // dataColumn4
            // 
            this.dataColumn4.Caption = "往来方分类";
            this.dataColumn4.ColumnName = "BussinessCategory";
            // 
            // dataColumn5
            // 
            this.dataColumn5.Caption = "是否使用";
            this.dataColumn5.ColumnName = "BussinessIsUse";
            this.dataColumn5.DataType = typeof(bool);
            // 
            // dataTable2
            // 
            this.dataTable2.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn21});
            this.dataTable2.TableName = "BussinessDetailInfo";
            // 
            // dataColumn6
            // 
            this.dataColumn6.Caption = "自动编号";
            this.dataColumn6.ColumnName = "AutoId";
            this.dataColumn6.DataType = typeof(int);
            // 
            // dataColumn7
            // 
            this.dataColumn7.Caption = "往来方编号";
            this.dataColumn7.ColumnName = "BussinessBaseNo";
            // 
            // dataColumn8
            // 
            this.dataColumn8.Caption = "法人";
            this.dataColumn8.ColumnName = "CompanyLR";
            // 
            // dataColumn9
            // 
            this.dataColumn9.Caption = "公司地址";
            this.dataColumn9.ColumnName = "CompanyAddress";
            // 
            // dataColumn10
            // 
            this.dataColumn10.Caption = "邮政编码";
            this.dataColumn10.ColumnName = "ZipCode";
            // 
            // dataColumn11
            // 
            this.dataColumn11.Caption = "电话";
            this.dataColumn11.ColumnName = "PhoneNo";
            // 
            // dataColumn12
            // 
            this.dataColumn12.Caption = "传真";
            this.dataColumn12.ColumnName = "FaxNo";
            // 
            // dataColumn13
            // 
            this.dataColumn13.Caption = "邮箱";
            this.dataColumn13.ColumnName = "E_mail";
            // 
            // dataColumn14
            // 
            this.dataColumn14.Caption = "网站";
            this.dataColumn14.ColumnName = "WebSite";
            // 
            // dataColumn15
            // 
            this.dataColumn15.Caption = "国家";
            this.dataColumn15.ColumnName = "CountryCode";
            // 
            // dataColumn21
            // 
            this.dataColumn21.Caption = "联系人";
            this.dataColumn21.ColumnName = "Contact";
            // 
            // dataTable3
            // 
            this.dataTable3.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18,
            this.dataColumn19,
            this.dataColumn20});
            this.dataTable3.TableName = "BussinessFinancialInfo";
            // 
            // dataColumn16
            // 
            this.dataColumn16.Caption = "自动编号";
            this.dataColumn16.ColumnName = "AutoId";
            this.dataColumn16.DataType = typeof(int);
            // 
            // dataColumn17
            // 
            this.dataColumn17.Caption = "往来方编号";
            this.dataColumn17.ColumnName = "BussinessBaseNo";
            // 
            // dataColumn18
            // 
            this.dataColumn18.Caption = "营业执照号";
            this.dataColumn18.ColumnName = "BussinessLicense";
            // 
            // dataColumn19
            // 
            this.dataColumn19.Caption = "银行账号";
            this.dataColumn19.ColumnName = "BankAccout";
            // 
            // dataColumn20
            // 
            this.dataColumn20.Caption = "开户行";
            this.dataColumn20.ColumnName = "BankAddress";
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
            this.gdvBussinessBaseInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gdvBussinessBaseInfo_CustomDrawRowIndicator);
            this.gdvBussinessBaseInfo.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gdvBussinessBaseInfo_SelectionChanged);
            this.gdvBussinessBaseInfo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gdvBussinessBaseInfo_FocusedRowChanged);
            this.gdvBussinessBaseInfo.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gdvBussinessBaseInfo_CellValueChanged);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colBussinessBaseNo
            // 
            this.colBussinessBaseNo.FieldName = "BussinessBaseNo";
            this.colBussinessBaseNo.Name = "colBussinessBaseNo";
            this.colBussinessBaseNo.Visible = true;
            this.colBussinessBaseNo.VisibleIndex = 0;
            // 
            // colBussinessBaseText
            // 
            this.colBussinessBaseText.FieldName = "BussinessBaseText";
            this.colBussinessBaseText.Name = "colBussinessBaseText";
            this.colBussinessBaseText.Visible = true;
            this.colBussinessBaseText.VisibleIndex = 1;
            // 
            // colBussinessCategory
            // 
            this.colBussinessCategory.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colBussinessCategory.FieldName = "BussinessCategory";
            this.colBussinessCategory.Name = "colBussinessCategory";
            this.colBussinessCategory.Visible = true;
            this.colBussinessCategory.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "自动编号", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BussinessCategory", "往来方编号", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BussinessCategoryText", "往来方名称")});
            this.repositoryItemLookUpEdit2.DataSource = this.bsBussinessCategory;
            this.repositoryItemLookUpEdit2.DisplayMember = "BussinessCategoryText";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.NullText = "";
            this.repositoryItemLookUpEdit2.ValueMember = "BussinessCategory";
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
            this.colBussinessIsUse.FieldName = "BussinessIsUse";
            this.colBussinessIsUse.Name = "colBussinessIsUse";
            this.colBussinessIsUse.Visible = true;
            this.colBussinessIsUse.VisibleIndex = 3;
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
            // repositoryItemGridLookUpEdit1
            // 
            this.repositoryItemGridLookUpEdit1.AutoHeight = false;
            this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
            this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
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
            this.pnlEdit.Controls.Add(this.textEdit1);
            this.pnlEdit.Controls.Add(label1);
            this.pnlEdit.Controls.Add(this.txtWebSite);
            this.pnlEdit.Controls.Add(this.txtE_mail);
            this.pnlEdit.Controls.Add(this.txtFaxNo);
            this.pnlEdit.Controls.Add(this.txtPhoneNo);
            this.pnlEdit.Controls.Add(this.txtZipCode);
            this.pnlEdit.Controls.Add(this.txtCompanyAddress);
            this.pnlEdit.Controls.Add(this.TxtCompanyLR);
            this.pnlEdit.Controls.Add(this.lueCountryCode);
            this.pnlEdit.Controls.Add(companyLRLabel);
            this.pnlEdit.Controls.Add(companyAddressLabel);
            this.pnlEdit.Controls.Add(zipCodeLabel);
            this.pnlEdit.Controls.Add(phoneNoLabel);
            this.pnlEdit.Controls.Add(faxNoLabel);
            this.pnlEdit.Controls.Add(e_mailLabel);
            this.pnlEdit.Controls.Add(webSiteLabel);
            this.pnlEdit.Controls.Add(countryCodeLabel);
            this.pnlEdit.Enabled = false;
            this.pnlEdit.Location = new System.Drawing.Point(6, 6);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(392, 297);
            this.pnlEdit.TabIndex = 4;
            this.pnlEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEdit_Paint);
            // 
            // textEdit1
            // 
            this.textEdit1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDetail, "Contact", true));
            this.textEdit1.EnterMoveNextControl = true;
            this.textEdit1.Location = new System.Drawing.Point(96, 253);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(150, 20);
            this.textEdit1.TabIndex = 29;
            // 
            // bsDetail
            // 
            this.bsDetail.DataMember = "BussinessDetailInfo";
            this.bsDetail.DataSource = this.dataSet1;
            // 
            // txtWebSite
            // 
            this.txtWebSite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDetail, "WebSite", true));
            this.txtWebSite.EnterMoveNextControl = true;
            this.txtWebSite.Location = new System.Drawing.Point(96, 197);
            this.txtWebSite.Name = "txtWebSite";
            this.txtWebSite.Size = new System.Drawing.Size(150, 20);
            this.txtWebSite.TabIndex = 27;
            // 
            // txtE_mail
            // 
            this.txtE_mail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDetail, "E_mail", true));
            this.txtE_mail.EnterMoveNextControl = true;
            this.txtE_mail.Location = new System.Drawing.Point(96, 170);
            this.txtE_mail.Name = "txtE_mail";
            this.txtE_mail.Size = new System.Drawing.Size(150, 20);
            this.txtE_mail.TabIndex = 26;
            // 
            // txtFaxNo
            // 
            this.txtFaxNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDetail, "FaxNo", true));
            this.txtFaxNo.EnterMoveNextControl = true;
            this.txtFaxNo.Location = new System.Drawing.Point(96, 143);
            this.txtFaxNo.Name = "txtFaxNo";
            this.txtFaxNo.Size = new System.Drawing.Size(150, 20);
            this.txtFaxNo.TabIndex = 25;
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDetail, "PhoneNo", true));
            this.txtPhoneNo.EnterMoveNextControl = true;
            this.txtPhoneNo.Location = new System.Drawing.Point(96, 115);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(150, 20);
            this.txtPhoneNo.TabIndex = 24;
            // 
            // txtZipCode
            // 
            this.txtZipCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDetail, "ZipCode", true));
            this.txtZipCode.EnterMoveNextControl = true;
            this.txtZipCode.Location = new System.Drawing.Point(96, 89);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(150, 20);
            this.txtZipCode.TabIndex = 23;
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDetail, "CompanyAddress", true));
            this.txtCompanyAddress.EnterMoveNextControl = true;
            this.txtCompanyAddress.Location = new System.Drawing.Point(96, 62);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(150, 20);
            this.txtCompanyAddress.TabIndex = 22;
            // 
            // TxtCompanyLR
            // 
            this.TxtCompanyLR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDetail, "CompanyLR", true));
            this.TxtCompanyLR.EnterMoveNextControl = true;
            this.TxtCompanyLR.Location = new System.Drawing.Point(96, 36);
            this.TxtCompanyLR.Name = "TxtCompanyLR";
            this.TxtCompanyLR.Size = new System.Drawing.Size(150, 20);
            this.TxtCompanyLR.TabIndex = 21;
            // 
            // lueCountryCode
            // 
            this.lueCountryCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDetail, "CountryCode", true));
            this.lueCountryCode.EnterMoveNextControl = true;
            this.lueCountryCode.Location = new System.Drawing.Point(96, 225);
            this.lueCountryCode.Name = "lueCountryCode";
            this.lueCountryCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueCountryCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "Name1", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryCode", "Name2", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryName", "国家")});
            this.lueCountryCode.Properties.DisplayMember = "CountryName";
            this.lueCountryCode.Properties.NullText = "";
            this.lueCountryCode.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.lueCountryCode.Properties.ValueMember = "CountryCode";
            this.lueCountryCode.Size = new System.Drawing.Size(150, 20);
            this.lueCountryCode.TabIndex = 20;
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
            this.pnlEdit1.Controls.Add(this.txtBankAccout);
            this.pnlEdit1.Controls.Add(this.txtBankAddress);
            this.pnlEdit1.Controls.Add(this.txtBussinessLicense);
            this.pnlEdit1.Controls.Add(bankAccoutLabel);
            this.pnlEdit1.Controls.Add(bussinessLicenseLabel);
            this.pnlEdit1.Controls.Add(bankAddressLabel);
            this.pnlEdit1.Enabled = false;
            this.pnlEdit1.Location = new System.Drawing.Point(6, 6);
            this.pnlEdit1.Name = "pnlEdit1";
            this.pnlEdit1.Size = new System.Drawing.Size(408, 187);
            this.pnlEdit1.TabIndex = 5;
            // 
            // txtBankAccout
            // 
            this.txtBankAccout.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFina, "BankAccout", true));
            this.txtBankAccout.EnterMoveNextControl = true;
            this.txtBankAccout.Location = new System.Drawing.Point(106, 64);
            this.txtBankAccout.Name = "txtBankAccout";
            this.txtBankAccout.Size = new System.Drawing.Size(150, 20);
            this.txtBankAccout.TabIndex = 23;
            // 
            // bsFina
            // 
            this.bsFina.DataMember = "BussinessFinancialInfo";
            this.bsFina.DataSource = this.dataSet1;
            // 
            // txtBankAddress
            // 
            this.txtBankAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFina, "BankAddress", true));
            this.txtBankAddress.EnterMoveNextControl = true;
            this.txtBankAddress.Location = new System.Drawing.Point(106, 94);
            this.txtBankAddress.Name = "txtBankAddress";
            this.txtBankAddress.Size = new System.Drawing.Size(150, 20);
            this.txtBankAddress.TabIndex = 24;
            // 
            // txtBussinessLicense
            // 
            this.txtBussinessLicense.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFina, "BussinessLicense", true));
            this.txtBussinessLicense.EnterMoveNextControl = true;
            this.txtBussinessLicense.Location = new System.Drawing.Point(106, 37);
            this.txtBussinessLicense.Name = "txtBussinessLicense";
            this.txtBussinessLicense.Size = new System.Drawing.Size(150, 20);
            this.txtBussinessLicense.TabIndex = 22;
            // 
            // bsCountry
            // 
            this.bsCountry.DataMember = "BS_CountryCodeManagement";
            this.bsCountry.DataSource = this.dsPSAP;
            // 
            // bS_BussinessCategoryTableAdapter
            // 
            this.bS_BussinessCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // bS_CountryCodeManagementTableAdapter
            // 
            this.bS_CountryCodeManagementTableAdapter.ClearBeforeFill = true;
            // 
            // bsBase
            // 
            this.bsBase.DataMember = "BussinessBaseInfo";
            this.bsBase.DataSource = this.dataSet1;
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
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdBussinessBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBussinessBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBussinessCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            this.tabBussinessInfo.ResumeLayout(false);
            this.tpBussinessDetailInfo.ResumeLayout(false);
            this.tpBussinessDetailInfo.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWebSite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtE_mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFaxNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhoneNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZipCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCompanyAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompanyLR.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueCountryCode.Properties)).EndInit();
            this.tpBussinessFinancialInfo.ResumeLayout(false);
            this.tpBussinessFinancialInfo.PerformLayout();
            this.pnlEdit1.ResumeLayout(false);
            this.pnlEdit1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankAccout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBankAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBussinessLicense.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tabBussinessInfo;
        private System.Windows.Forms.TabPage tpBussinessDetailInfo;
        private System.Windows.Forms.TabPage tpBussinessFinancialInfo;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Panel pnlEdit1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private DevExpress.XtraGrid.GridControl gdBussinessBaseInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvBussinessBaseInfo;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.BindingSource bsBussinessCategory;
        private dsPSAP dsPSAP;
        private dsPSAPTableAdapters.BS_BussinessCategoryTableAdapter bS_BussinessCategoryTableAdapter;
        private System.Windows.Forms.BindingSource bsCountry;
        private dsPSAPTableAdapters.BS_CountryCodeManagementTableAdapter bS_CountryCodeManagementTableAdapter;
        private System.Data.DataTable dataTable1;
        private DevExpress.XtraEditors.LookUpEdit lueCountryCode;
        private DevExpress.XtraEditors.TextEdit txtWebSite;
        private DevExpress.XtraEditors.TextEdit txtE_mail;
        private DevExpress.XtraEditors.TextEdit txtFaxNo;
        private DevExpress.XtraEditors.TextEdit txtPhoneNo;
        private DevExpress.XtraEditors.TextEdit txtZipCode;
        private DevExpress.XtraEditors.TextEdit txtCompanyAddress;
        private DevExpress.XtraEditors.TextEdit TxtCompanyLR;
        private DevExpress.XtraEditors.TextEdit txtBankAccout;
        private DevExpress.XtraEditors.TextEdit txtBankAddress;
        private DevExpress.XtraEditors.TextEdit txtBussinessLicense;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataTable dataTable2;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Data.DataColumn dataColumn10;
        private System.Data.DataColumn dataColumn11;
        private System.Data.DataColumn dataColumn12;
        private System.Data.DataColumn dataColumn13;
        private System.Data.DataColumn dataColumn14;
        private System.Data.DataColumn dataColumn15;
        private System.Data.DataTable dataTable3;
        private System.Data.DataColumn dataColumn16;
        private System.Data.DataColumn dataColumn17;
        private System.Data.DataColumn dataColumn18;
        private System.Data.DataColumn dataColumn19;
        private System.Data.DataColumn dataColumn20;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessIsUse;
        private System.Windows.Forms.BindingSource bsBase;
        private System.Windows.Forms.BindingSource bsDetail;
        private System.Windows.Forms.BindingSource bsFina;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private System.Data.DataColumn dataColumn21;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}