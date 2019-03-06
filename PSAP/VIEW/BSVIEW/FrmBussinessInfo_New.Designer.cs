namespace PSAP.VIEW.BSVIEW
{
    partial class FrmBussinessInfo_New
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
            this.dSBussiness = new System.Data.DataSet();
            this.TableBussinessBaseInfo = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColBussinessBaseNo = new System.Data.DataColumn();
            this.dataColBussinessBaseText = new System.Data.DataColumn();
            this.dataColBussinessCategory = new System.Data.DataColumn();
            this.dataColBussinessCategoryText = new System.Data.DataColumn();
            this.dataColBussinessIsUse = new System.Data.DataColumn();
            this.TableBussinessDetailInfo = new System.Data.DataTable();
            this.dataCoAutoId = new System.Data.DataColumn();
            this.dataCoBussinessBaseNo = new System.Data.DataColumn();
            this.dataCoCompanyLR = new System.Data.DataColumn();
            this.dataCoCompanyAddress = new System.Data.DataColumn();
            this.dataCoZipCode = new System.Data.DataColumn();
            this.dataCoPhoneNo = new System.Data.DataColumn();
            this.dataCoFaxNo = new System.Data.DataColumn();
            this.dataCoE_mail = new System.Data.DataColumn();
            this.dataCoWebSite = new System.Data.DataColumn();
            this.dataCoCountryCode = new System.Data.DataColumn();
            this.dataCoContact = new System.Data.DataColumn();
            this.TableBussinessFinancialInfo = new System.Data.DataTable();
            this.dataCAutoId = new System.Data.DataColumn();
            this.dataCBussinessBaseNo = new System.Data.DataColumn();
            this.dataCBussinessLicense = new System.Data.DataColumn();
            this.dataCBankAccout = new System.Data.DataColumn();
            this.dataCBankAddress = new System.Data.DataColumn();
            this.bSBaseInfo = new System.Windows.Forms.BindingSource(this.components);
            this.bSDetailInfo = new System.Windows.Forms.BindingSource(this.components);
            this.bSFinancialInfo = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.pnlRight = new DevExpress.XtraEditors.PanelControl();
            this.TabControlOtherInfo = new DevExpress.XtraTab.XtraTabControl();
            this.PageDetailInfo = new DevExpress.XtraTab.XtraTabPage();
            this.pnlDetailInfo = new DevExpress.XtraEditors.PanelControl();
            this.textContact = new DevExpress.XtraEditors.TextEdit();
            this.labContact = new DevExpress.XtraEditors.LabelControl();
            this.labCountryCode = new DevExpress.XtraEditors.LabelControl();
            this.lookUpCountryCode = new DevExpress.XtraEditors.LookUpEdit();
            this.textWebSite = new DevExpress.XtraEditors.TextEdit();
            this.labWebSite = new DevExpress.XtraEditors.LabelControl();
            this.textE_mail = new DevExpress.XtraEditors.TextEdit();
            this.labE_mail = new DevExpress.XtraEditors.LabelControl();
            this.textFaxNo = new DevExpress.XtraEditors.TextEdit();
            this.labFaxNo = new DevExpress.XtraEditors.LabelControl();
            this.textPhoneNo = new DevExpress.XtraEditors.TextEdit();
            this.labPhoneNo = new DevExpress.XtraEditors.LabelControl();
            this.textZipCode = new DevExpress.XtraEditors.TextEdit();
            this.labZipCode = new DevExpress.XtraEditors.LabelControl();
            this.textCompanyAddress = new DevExpress.XtraEditors.TextEdit();
            this.labCompanyAddress = new DevExpress.XtraEditors.LabelControl();
            this.textCompanyLR = new DevExpress.XtraEditors.TextEdit();
            this.labCompanyLR = new DevExpress.XtraEditors.LabelControl();
            this.PageFinancialInfo = new DevExpress.XtraTab.XtraTabPage();
            this.pnlFinancialInfo = new DevExpress.XtraEditors.PanelControl();
            this.textBussinessLicense = new DevExpress.XtraEditors.TextEdit();
            this.labBussinessLicense = new DevExpress.XtraEditors.LabelControl();
            this.textBankAddress = new DevExpress.XtraEditors.TextEdit();
            this.labBankAddress = new DevExpress.XtraEditors.LabelControl();
            this.textBankAccout = new DevExpress.XtraEditors.TextEdit();
            this.labBankAccout = new DevExpress.XtraEditors.LabelControl();
            this.pnlLeft = new DevExpress.XtraEditors.PanelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlBaseInfo = new DevExpress.XtraGrid.GridControl();
            this.gridViewBaseInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessBaseText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessCategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessCategoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBussinessIsUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.checkBussinessIsUse = new DevExpress.XtraEditors.CheckEdit();
            this.labBussinessCategory = new DevExpress.XtraEditors.LabelControl();
            this.lookUpBussinessCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.textBussinessBaseText = new DevExpress.XtraEditors.TextEdit();
            this.textBussinessBaseNo = new DevExpress.XtraEditors.TextEdit();
            this.labBussinessBaseText = new DevExpress.XtraEditors.LabelControl();
            this.labBussinessBaseNo = new DevExpress.XtraEditors.LabelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.splitterMiddle = new DevExpress.XtraEditors.SplitterControl();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiWlfbh = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWlfmc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWlffl = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSzwlfjbxxmrzcw = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSzwlfxxxxmrzcw = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dSBussiness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBussinessBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBussinessDetailInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBussinessFinancialInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDetailInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSFinancialInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).BeginInit();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlOtherInfo)).BeginInit();
            this.TabControlOtherInfo.SuspendLayout();
            this.PageDetailInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetailInfo)).BeginInit();
            this.pnlDetailInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textContact.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCountryCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWebSite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_mail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFaxNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhoneNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textZipCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCompanyAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCompanyLR.Properties)).BeginInit();
            this.PageFinancialInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFinancialInfo)).BeginInit();
            this.pnlFinancialInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBussinessLicense.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankAccout.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).BeginInit();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBaseInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBussinessIsUse.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBussinessCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBussinessBaseText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBussinessBaseNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSBussiness
            // 
            this.dSBussiness.DataSetName = "NewDataSet";
            this.dSBussiness.Tables.AddRange(new System.Data.DataTable[] {
            this.TableBussinessBaseInfo,
            this.TableBussinessDetailInfo,
            this.TableBussinessFinancialInfo});
            // 
            // TableBussinessBaseInfo
            // 
            this.TableBussinessBaseInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColBussinessBaseNo,
            this.dataColBussinessBaseText,
            this.dataColBussinessCategory,
            this.dataColBussinessCategoryText,
            this.dataColBussinessIsUse});
            this.TableBussinessBaseInfo.TableName = "BussinessBaseInfo";
            this.TableBussinessBaseInfo.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableBussinessBaseInfo_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColBussinessBaseNo
            // 
            this.dataColBussinessBaseNo.Caption = "往来方编号";
            this.dataColBussinessBaseNo.ColumnName = "BussinessBaseNo";
            // 
            // dataColBussinessBaseText
            // 
            this.dataColBussinessBaseText.Caption = "往来方名称";
            this.dataColBussinessBaseText.ColumnName = "BussinessBaseText";
            // 
            // dataColBussinessCategory
            // 
            this.dataColBussinessCategory.Caption = "往来方分类";
            this.dataColBussinessCategory.ColumnName = "BussinessCategory";
            // 
            // dataColBussinessCategoryText
            // 
            this.dataColBussinessCategoryText.Caption = "往来方分类";
            this.dataColBussinessCategoryText.ColumnName = "BussinessCategoryText";
            // 
            // dataColBussinessIsUse
            // 
            this.dataColBussinessIsUse.Caption = "是否使用";
            this.dataColBussinessIsUse.ColumnName = "BussinessIsUse";
            this.dataColBussinessIsUse.DataType = typeof(bool);
            // 
            // TableBussinessDetailInfo
            // 
            this.TableBussinessDetailInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataCoAutoId,
            this.dataCoBussinessBaseNo,
            this.dataCoCompanyLR,
            this.dataCoCompanyAddress,
            this.dataCoZipCode,
            this.dataCoPhoneNo,
            this.dataCoFaxNo,
            this.dataCoE_mail,
            this.dataCoWebSite,
            this.dataCoCountryCode,
            this.dataCoContact});
            this.TableBussinessDetailInfo.TableName = "BussinessDetailInfo";
            this.TableBussinessDetailInfo.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableBussinessDetailInfo_TableNewRow);
            // 
            // dataCoAutoId
            // 
            this.dataCoAutoId.ColumnName = "AutoId";
            this.dataCoAutoId.DataType = typeof(int);
            // 
            // dataCoBussinessBaseNo
            // 
            this.dataCoBussinessBaseNo.ColumnName = "BussinessBaseNo";
            // 
            // dataCoCompanyLR
            // 
            this.dataCoCompanyLR.ColumnName = "CompanyLR";
            // 
            // dataCoCompanyAddress
            // 
            this.dataCoCompanyAddress.ColumnName = "CompanyAddress";
            // 
            // dataCoZipCode
            // 
            this.dataCoZipCode.ColumnName = "ZipCode";
            // 
            // dataCoPhoneNo
            // 
            this.dataCoPhoneNo.ColumnName = "PhoneNo";
            // 
            // dataCoFaxNo
            // 
            this.dataCoFaxNo.ColumnName = "FaxNo";
            // 
            // dataCoE_mail
            // 
            this.dataCoE_mail.ColumnName = "E_mail";
            // 
            // dataCoWebSite
            // 
            this.dataCoWebSite.ColumnName = "WebSite";
            // 
            // dataCoCountryCode
            // 
            this.dataCoCountryCode.ColumnName = "CountryCode";
            // 
            // dataCoContact
            // 
            this.dataCoContact.ColumnName = "Contact";
            // 
            // TableBussinessFinancialInfo
            // 
            this.TableBussinessFinancialInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataCAutoId,
            this.dataCBussinessBaseNo,
            this.dataCBussinessLicense,
            this.dataCBankAccout,
            this.dataCBankAddress});
            this.TableBussinessFinancialInfo.TableName = "BussinessFinancialInfo";
            // 
            // dataCAutoId
            // 
            this.dataCAutoId.ColumnName = "AutoId";
            this.dataCAutoId.DataType = typeof(int);
            // 
            // dataCBussinessBaseNo
            // 
            this.dataCBussinessBaseNo.ColumnName = "BussinessBaseNo";
            // 
            // dataCBussinessLicense
            // 
            this.dataCBussinessLicense.ColumnName = "BussinessLicense";
            // 
            // dataCBankAccout
            // 
            this.dataCBankAccout.ColumnName = "BankAccout";
            // 
            // dataCBankAddress
            // 
            this.dataCBankAddress.ColumnName = "BankAddress";
            // 
            // bSBaseInfo
            // 
            this.bSBaseInfo.DataMember = "BussinessBaseInfo";
            this.bSBaseInfo.DataSource = this.dSBussiness;
            // 
            // bSDetailInfo
            // 
            this.bSDetailInfo.DataMember = "BussinessDetailInfo";
            this.bSDetailInfo.DataSource = this.dSBussiness;
            // 
            // bSFinancialInfo
            // 
            this.bSFinancialInfo.DataMember = "BussinessFinancialInfo";
            this.bSFinancialInfo.DataSource = this.dSBussiness;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(1228, 40);
            this.pnlToolBar.TabIndex = 3;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.TabControlOtherInfo);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(826, 2);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(400, 493);
            this.pnlRight.TabIndex = 4;
            // 
            // TabControlOtherInfo
            // 
            this.TabControlOtherInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlOtherInfo.Location = new System.Drawing.Point(2, 2);
            this.TabControlOtherInfo.Name = "TabControlOtherInfo";
            this.TabControlOtherInfo.SelectedTabPage = this.PageDetailInfo;
            this.TabControlOtherInfo.Size = new System.Drawing.Size(396, 489);
            this.TabControlOtherInfo.TabIndex = 0;
            this.TabControlOtherInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageDetailInfo,
            this.PageFinancialInfo});
            // 
            // PageDetailInfo
            // 
            this.PageDetailInfo.Controls.Add(this.pnlDetailInfo);
            this.PageDetailInfo.Name = "PageDetailInfo";
            this.PageDetailInfo.Size = new System.Drawing.Size(390, 460);
            this.PageDetailInfo.Text = "详细信息";
            // 
            // pnlDetailInfo
            // 
            this.pnlDetailInfo.Controls.Add(this.textContact);
            this.pnlDetailInfo.Controls.Add(this.labContact);
            this.pnlDetailInfo.Controls.Add(this.labCountryCode);
            this.pnlDetailInfo.Controls.Add(this.lookUpCountryCode);
            this.pnlDetailInfo.Controls.Add(this.textWebSite);
            this.pnlDetailInfo.Controls.Add(this.labWebSite);
            this.pnlDetailInfo.Controls.Add(this.textE_mail);
            this.pnlDetailInfo.Controls.Add(this.labE_mail);
            this.pnlDetailInfo.Controls.Add(this.textFaxNo);
            this.pnlDetailInfo.Controls.Add(this.labFaxNo);
            this.pnlDetailInfo.Controls.Add(this.textPhoneNo);
            this.pnlDetailInfo.Controls.Add(this.labPhoneNo);
            this.pnlDetailInfo.Controls.Add(this.textZipCode);
            this.pnlDetailInfo.Controls.Add(this.labZipCode);
            this.pnlDetailInfo.Controls.Add(this.textCompanyAddress);
            this.pnlDetailInfo.Controls.Add(this.labCompanyAddress);
            this.pnlDetailInfo.Controls.Add(this.textCompanyLR);
            this.pnlDetailInfo.Controls.Add(this.labCompanyLR);
            this.pnlDetailInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetailInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlDetailInfo.Name = "pnlDetailInfo";
            this.pnlDetailInfo.Size = new System.Drawing.Size(390, 460);
            this.pnlDetailInfo.TabIndex = 0;
            // 
            // textContact
            // 
            this.textContact.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSDetailInfo, "Contact", true));
            this.textContact.EnterMoveNextControl = true;
            this.textContact.Location = new System.Drawing.Point(112, 27);
            this.textContact.Name = "textContact";
            this.textContact.Size = new System.Drawing.Size(200, 20);
            this.textContact.TabIndex = 4;
            // 
            // labContact
            // 
            this.labContact.Location = new System.Drawing.Point(36, 30);
            this.labContact.Name = "labContact";
            this.labContact.Size = new System.Drawing.Size(36, 14);
            this.labContact.TabIndex = 46;
            this.labContact.Text = "联系人";
            // 
            // labCountryCode
            // 
            this.labCountryCode.Location = new System.Drawing.Point(36, 350);
            this.labCountryCode.Name = "labCountryCode";
            this.labCountryCode.Size = new System.Drawing.Size(24, 14);
            this.labCountryCode.TabIndex = 44;
            this.labCountryCode.Text = "国家";
            // 
            // lookUpCountryCode
            // 
            this.lookUpCountryCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSDetailInfo, "CountryCode", true));
            this.lookUpCountryCode.Location = new System.Drawing.Point(112, 347);
            this.lookUpCountryCode.Name = "lookUpCountryCode";
            this.lookUpCountryCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpCountryCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryCode", "国家编码", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryName", "国家名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpCountryCode.Properties.DisplayMember = "CountryName";
            this.lookUpCountryCode.Properties.NullText = "";
            this.lookUpCountryCode.Properties.ValueMember = "CountryCode";
            this.lookUpCountryCode.Size = new System.Drawing.Size(200, 20);
            this.lookUpCountryCode.TabIndex = 12;
            this.lookUpCountryCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lookUpCountryCode_KeyDown);
            // 
            // textWebSite
            // 
            this.textWebSite.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSDetailInfo, "WebSite", true));
            this.textWebSite.EnterMoveNextControl = true;
            this.textWebSite.Location = new System.Drawing.Point(112, 307);
            this.textWebSite.Name = "textWebSite";
            this.textWebSite.Size = new System.Drawing.Size(200, 20);
            this.textWebSite.TabIndex = 11;
            // 
            // labWebSite
            // 
            this.labWebSite.Location = new System.Drawing.Point(36, 310);
            this.labWebSite.Name = "labWebSite";
            this.labWebSite.Size = new System.Drawing.Size(24, 14);
            this.labWebSite.TabIndex = 42;
            this.labWebSite.Text = "网站";
            // 
            // textE_mail
            // 
            this.textE_mail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSDetailInfo, "E_mail", true));
            this.textE_mail.EnterMoveNextControl = true;
            this.textE_mail.Location = new System.Drawing.Point(112, 267);
            this.textE_mail.Name = "textE_mail";
            this.textE_mail.Size = new System.Drawing.Size(200, 20);
            this.textE_mail.TabIndex = 10;
            // 
            // labE_mail
            // 
            this.labE_mail.Location = new System.Drawing.Point(36, 270);
            this.labE_mail.Name = "labE_mail";
            this.labE_mail.Size = new System.Drawing.Size(24, 14);
            this.labE_mail.TabIndex = 40;
            this.labE_mail.Text = "邮箱";
            // 
            // textFaxNo
            // 
            this.textFaxNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSDetailInfo, "FaxNo", true));
            this.textFaxNo.EnterMoveNextControl = true;
            this.textFaxNo.Location = new System.Drawing.Point(112, 227);
            this.textFaxNo.Name = "textFaxNo";
            this.textFaxNo.Size = new System.Drawing.Size(200, 20);
            this.textFaxNo.TabIndex = 9;
            // 
            // labFaxNo
            // 
            this.labFaxNo.Location = new System.Drawing.Point(36, 230);
            this.labFaxNo.Name = "labFaxNo";
            this.labFaxNo.Size = new System.Drawing.Size(24, 14);
            this.labFaxNo.TabIndex = 38;
            this.labFaxNo.Text = "传真";
            // 
            // textPhoneNo
            // 
            this.textPhoneNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSDetailInfo, "PhoneNo", true));
            this.textPhoneNo.EnterMoveNextControl = true;
            this.textPhoneNo.Location = new System.Drawing.Point(112, 187);
            this.textPhoneNo.Name = "textPhoneNo";
            this.textPhoneNo.Size = new System.Drawing.Size(200, 20);
            this.textPhoneNo.TabIndex = 8;
            // 
            // labPhoneNo
            // 
            this.labPhoneNo.Location = new System.Drawing.Point(36, 190);
            this.labPhoneNo.Name = "labPhoneNo";
            this.labPhoneNo.Size = new System.Drawing.Size(24, 14);
            this.labPhoneNo.TabIndex = 36;
            this.labPhoneNo.Text = "电话";
            // 
            // textZipCode
            // 
            this.textZipCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSDetailInfo, "ZipCode", true));
            this.textZipCode.EnterMoveNextControl = true;
            this.textZipCode.Location = new System.Drawing.Point(112, 147);
            this.textZipCode.Name = "textZipCode";
            this.textZipCode.Size = new System.Drawing.Size(200, 20);
            this.textZipCode.TabIndex = 7;
            // 
            // labZipCode
            // 
            this.labZipCode.Location = new System.Drawing.Point(36, 150);
            this.labZipCode.Name = "labZipCode";
            this.labZipCode.Size = new System.Drawing.Size(48, 14);
            this.labZipCode.TabIndex = 34;
            this.labZipCode.Text = "邮政编码";
            // 
            // textCompanyAddress
            // 
            this.textCompanyAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSDetailInfo, "CompanyAddress", true));
            this.textCompanyAddress.EnterMoveNextControl = true;
            this.textCompanyAddress.Location = new System.Drawing.Point(112, 107);
            this.textCompanyAddress.Name = "textCompanyAddress";
            this.textCompanyAddress.Size = new System.Drawing.Size(200, 20);
            this.textCompanyAddress.TabIndex = 6;
            // 
            // labCompanyAddress
            // 
            this.labCompanyAddress.Location = new System.Drawing.Point(36, 110);
            this.labCompanyAddress.Name = "labCompanyAddress";
            this.labCompanyAddress.Size = new System.Drawing.Size(48, 14);
            this.labCompanyAddress.TabIndex = 32;
            this.labCompanyAddress.Text = "公司地址";
            // 
            // textCompanyLR
            // 
            this.textCompanyLR.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSDetailInfo, "CompanyLR", true));
            this.textCompanyLR.EnterMoveNextControl = true;
            this.textCompanyLR.Location = new System.Drawing.Point(112, 67);
            this.textCompanyLR.Name = "textCompanyLR";
            this.textCompanyLR.Size = new System.Drawing.Size(200, 20);
            this.textCompanyLR.TabIndex = 5;
            // 
            // labCompanyLR
            // 
            this.labCompanyLR.Location = new System.Drawing.Point(36, 70);
            this.labCompanyLR.Name = "labCompanyLR";
            this.labCompanyLR.Size = new System.Drawing.Size(24, 14);
            this.labCompanyLR.TabIndex = 30;
            this.labCompanyLR.Text = "法人";
            // 
            // PageFinancialInfo
            // 
            this.PageFinancialInfo.Controls.Add(this.pnlFinancialInfo);
            this.PageFinancialInfo.Name = "PageFinancialInfo";
            this.PageFinancialInfo.Size = new System.Drawing.Size(390, 460);
            this.PageFinancialInfo.Text = "金融信息";
            // 
            // pnlFinancialInfo
            // 
            this.pnlFinancialInfo.Controls.Add(this.textBussinessLicense);
            this.pnlFinancialInfo.Controls.Add(this.labBussinessLicense);
            this.pnlFinancialInfo.Controls.Add(this.textBankAddress);
            this.pnlFinancialInfo.Controls.Add(this.labBankAddress);
            this.pnlFinancialInfo.Controls.Add(this.textBankAccout);
            this.pnlFinancialInfo.Controls.Add(this.labBankAccout);
            this.pnlFinancialInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFinancialInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlFinancialInfo.Name = "pnlFinancialInfo";
            this.pnlFinancialInfo.Size = new System.Drawing.Size(390, 460);
            this.pnlFinancialInfo.TabIndex = 1;
            // 
            // textBussinessLicense
            // 
            this.textBussinessLicense.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSFinancialInfo, "BussinessLicense", true));
            this.textBussinessLicense.EnterMoveNextControl = true;
            this.textBussinessLicense.Location = new System.Drawing.Point(112, 27);
            this.textBussinessLicense.Name = "textBussinessLicense";
            this.textBussinessLicense.Size = new System.Drawing.Size(200, 20);
            this.textBussinessLicense.TabIndex = 13;
            // 
            // labBussinessLicense
            // 
            this.labBussinessLicense.Location = new System.Drawing.Point(36, 30);
            this.labBussinessLicense.Name = "labBussinessLicense";
            this.labBussinessLicense.Size = new System.Drawing.Size(48, 14);
            this.labBussinessLicense.TabIndex = 52;
            this.labBussinessLicense.Text = "营业执照";
            // 
            // textBankAddress
            // 
            this.textBankAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSFinancialInfo, "BankAddress", true));
            this.textBankAddress.EnterMoveNextControl = true;
            this.textBankAddress.Location = new System.Drawing.Point(112, 107);
            this.textBankAddress.Name = "textBankAddress";
            this.textBankAddress.Size = new System.Drawing.Size(200, 20);
            this.textBankAddress.TabIndex = 15;
            // 
            // labBankAddress
            // 
            this.labBankAddress.Location = new System.Drawing.Point(36, 110);
            this.labBankAddress.Name = "labBankAddress";
            this.labBankAddress.Size = new System.Drawing.Size(36, 14);
            this.labBankAddress.TabIndex = 50;
            this.labBankAddress.Text = "开户行";
            // 
            // textBankAccout
            // 
            this.textBankAccout.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSFinancialInfo, "BankAccout", true));
            this.textBankAccout.EnterMoveNextControl = true;
            this.textBankAccout.Location = new System.Drawing.Point(112, 67);
            this.textBankAccout.Name = "textBankAccout";
            this.textBankAccout.Size = new System.Drawing.Size(200, 20);
            this.textBankAccout.TabIndex = 14;
            // 
            // labBankAccout
            // 
            this.labBankAccout.Location = new System.Drawing.Point(36, 70);
            this.labBankAccout.Name = "labBankAccout";
            this.labBankAccout.Size = new System.Drawing.Size(48, 14);
            this.labBankAccout.TabIndex = 48;
            this.labBankAccout.Text = "银行账号";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.pnlGrid);
            this.pnlLeft.Controls.Add(this.pnlEdit);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeft.Location = new System.Drawing.Point(2, 2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(819, 493);
            this.pnlLeft.TabIndex = 15;
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlBaseInfo);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(2, 99);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(815, 392);
            this.pnlGrid.TabIndex = 8;
            // 
            // gridCrlBaseInfo
            // 
            this.gridCrlBaseInfo.DataSource = this.bSBaseInfo;
            this.gridCrlBaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlBaseInfo.Location = new System.Drawing.Point(2, 2);
            this.gridCrlBaseInfo.MainView = this.gridViewBaseInfo;
            this.gridCrlBaseInfo.Name = "gridCrlBaseInfo";
            this.gridCrlBaseInfo.Size = new System.Drawing.Size(811, 388);
            this.gridCrlBaseInfo.TabIndex = 100;
            this.gridCrlBaseInfo.TabStop = false;
            this.gridCrlBaseInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewBaseInfo});
            // 
            // gridViewBaseInfo
            // 
            this.gridViewBaseInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colBussinessBaseNo,
            this.colBussinessBaseText,
            this.colBussinessCategory,
            this.colBussinessCategoryText,
            this.colBussinessIsUse});
            this.gridViewBaseInfo.GridControl = this.gridCrlBaseInfo;
            this.gridViewBaseInfo.IndicatorWidth = 40;
            this.gridViewBaseInfo.Name = "gridViewBaseInfo";
            this.gridViewBaseInfo.OptionsBehavior.Editable = false;
            this.gridViewBaseInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewBaseInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewBaseInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewBaseInfo.OptionsView.ShowFooter = true;
            this.gridViewBaseInfo.OptionsView.ShowGroupPanel = false;
            this.gridViewBaseInfo.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.gridViewBaseInfo_CustomDrawRowIndicator);
            this.gridViewBaseInfo.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewBaseInfo_FocusedRowChanged);
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colBussinessBaseNo
            // 
            this.colBussinessBaseNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessBaseNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessBaseNo.FieldName = "BussinessBaseNo";
            this.colBussinessBaseNo.Name = "colBussinessBaseNo";
            this.colBussinessBaseNo.Visible = true;
            this.colBussinessBaseNo.VisibleIndex = 0;
            this.colBussinessBaseNo.Width = 120;
            // 
            // colBussinessBaseText
            // 
            this.colBussinessBaseText.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessBaseText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessBaseText.FieldName = "BussinessBaseText";
            this.colBussinessBaseText.Name = "colBussinessBaseText";
            this.colBussinessBaseText.Visible = true;
            this.colBussinessBaseText.VisibleIndex = 1;
            this.colBussinessBaseText.Width = 120;
            // 
            // colBussinessCategory
            // 
            this.colBussinessCategory.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessCategory.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessCategory.FieldName = "BussinessCategory";
            this.colBussinessCategory.Name = "colBussinessCategory";
            // 
            // colBussinessCategoryText
            // 
            this.colBussinessCategoryText.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessCategoryText.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessCategoryText.FieldName = "BussinessCategoryText";
            this.colBussinessCategoryText.Name = "colBussinessCategoryText";
            this.colBussinessCategoryText.Visible = true;
            this.colBussinessCategoryText.VisibleIndex = 2;
            this.colBussinessCategoryText.Width = 120;
            // 
            // colBussinessIsUse
            // 
            this.colBussinessIsUse.AppearanceHeader.Options.UseTextOptions = true;
            this.colBussinessIsUse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBussinessIsUse.FieldName = "BussinessIsUse";
            this.colBussinessIsUse.Name = "colBussinessIsUse";
            this.colBussinessIsUse.Visible = true;
            this.colBussinessIsUse.VisibleIndex = 3;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.labelControl1);
            this.pnlEdit.Controls.Add(this.checkBussinessIsUse);
            this.pnlEdit.Controls.Add(this.labBussinessCategory);
            this.pnlEdit.Controls.Add(this.lookUpBussinessCategory);
            this.pnlEdit.Controls.Add(this.textBussinessBaseText);
            this.pnlEdit.Controls.Add(this.textBussinessBaseNo);
            this.pnlEdit.Controls.Add(this.labBussinessBaseText);
            this.pnlEdit.Controls.Add(this.labBussinessBaseNo);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(2, 2);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(815, 97);
            this.pnlEdit.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(300, 58);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "是否使用";
            // 
            // checkBussinessIsUse
            // 
            this.checkBussinessIsUse.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBaseInfo, "BussinessIsUse", true));
            this.checkBussinessIsUse.Location = new System.Drawing.Point(389, 56);
            this.checkBussinessIsUse.Name = "checkBussinessIsUse";
            this.checkBussinessIsUse.Properties.Caption = "";
            this.checkBussinessIsUse.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.checkBussinessIsUse.Size = new System.Drawing.Size(22, 19);
            this.checkBussinessIsUse.TabIndex = 3;
            this.checkBussinessIsUse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.checkBussinessIsUse_KeyDown);
            // 
            // labBussinessCategory
            // 
            this.labBussinessCategory.Location = new System.Drawing.Point(36, 58);
            this.labBussinessCategory.Name = "labBussinessCategory";
            this.labBussinessCategory.Size = new System.Drawing.Size(60, 14);
            this.labBussinessCategory.TabIndex = 17;
            this.labBussinessCategory.Text = "往来方分类";
            // 
            // lookUpBussinessCategory
            // 
            this.lookUpBussinessCategory.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBaseInfo, "BussinessCategory", true));
            this.lookUpBussinessCategory.EnterMoveNextControl = true;
            this.lookUpBussinessCategory.Location = new System.Drawing.Point(112, 55);
            this.lookUpBussinessCategory.Name = "lookUpBussinessCategory";
            this.lookUpBussinessCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpBussinessCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BussinessCategory", "类别编号", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BussinessCategoryText", "类别名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpBussinessCategory.Properties.DisplayMember = "BussinessCategoryText";
            this.lookUpBussinessCategory.Properties.NullText = "";
            this.lookUpBussinessCategory.Properties.ValueMember = "BussinessCategory";
            this.lookUpBussinessCategory.Size = new System.Drawing.Size(150, 20);
            this.lookUpBussinessCategory.TabIndex = 2;
            // 
            // textBussinessBaseText
            // 
            this.textBussinessBaseText.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBaseInfo, "BussinessBaseText", true));
            this.textBussinessBaseText.EnterMoveNextControl = true;
            this.textBussinessBaseText.Location = new System.Drawing.Point(380, 21);
            this.textBussinessBaseText.Name = "textBussinessBaseText";
            this.textBussinessBaseText.Size = new System.Drawing.Size(150, 20);
            this.textBussinessBaseText.TabIndex = 1;
            // 
            // textBussinessBaseNo
            // 
            this.textBussinessBaseNo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSBaseInfo, "BussinessBaseNo", true));
            this.textBussinessBaseNo.EnterMoveNextControl = true;
            this.textBussinessBaseNo.Location = new System.Drawing.Point(112, 21);
            this.textBussinessBaseNo.Name = "textBussinessBaseNo";
            this.textBussinessBaseNo.Size = new System.Drawing.Size(150, 20);
            this.textBussinessBaseNo.TabIndex = 0;
            // 
            // labBussinessBaseText
            // 
            this.labBussinessBaseText.Location = new System.Drawing.Point(300, 24);
            this.labBussinessBaseText.Name = "labBussinessBaseText";
            this.labBussinessBaseText.Size = new System.Drawing.Size(60, 14);
            this.labBussinessBaseText.TabIndex = 14;
            this.labBussinessBaseText.Text = "往来方名称";
            // 
            // labBussinessBaseNo
            // 
            this.labBussinessBaseNo.Location = new System.Drawing.Point(36, 24);
            this.labBussinessBaseNo.Name = "labBussinessBaseNo";
            this.labBussinessBaseNo.Size = new System.Drawing.Size(60, 14);
            this.labBussinessBaseNo.TabIndex = 12;
            this.labBussinessBaseNo.Text = "往来方编号";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlLeft);
            this.pnlBottom.Controls.Add(this.splitterMiddle);
            this.pnlBottom.Controls.Add(this.pnlRight);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 40);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1228, 497);
            this.pnlBottom.TabIndex = 16;
            // 
            // splitterMiddle
            // 
            this.splitterMiddle.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.splitterMiddle.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitterMiddle.Location = new System.Drawing.Point(821, 2);
            this.splitterMiddle.Name = "splitterMiddle";
            this.splitterMiddle.Size = new System.Drawing.Size(5, 493);
            this.splitterMiddle.TabIndex = 15;
            this.splitterMiddle.TabStop = false;
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWlfbh,
            this.tsmiWlfmc,
            this.tsmiWlffl,
            this.tsmiSzwlfjbxxmrzcw,
            this.tsmiSzwlfxxxxmrzcw});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(269, 136);
            // 
            // tsmiWlfbh
            // 
            this.tsmiWlfbh.Name = "tsmiWlfbh";
            this.tsmiWlfbh.Size = new System.Drawing.Size(268, 22);
            this.tsmiWlfbh.Text = "往来方编号不能为空，请重新操作。";
            // 
            // tsmiWlfmc
            // 
            this.tsmiWlfmc.Name = "tsmiWlfmc";
            this.tsmiWlfmc.Size = new System.Drawing.Size(268, 22);
            this.tsmiWlfmc.Text = "往来方名称不能为空，请重新操作。";
            // 
            // tsmiWlffl
            // 
            this.tsmiWlffl.Name = "tsmiWlffl";
            this.tsmiWlffl.Size = new System.Drawing.Size(268, 22);
            this.tsmiWlffl.Text = "往来方分类不能为空，请重新操作。";
            // 
            // tsmiSzwlfjbxxmrzcw
            // 
            this.tsmiSzwlfjbxxmrzcw.Name = "tsmiSzwlfjbxxmrzcw";
            this.tsmiSzwlfjbxxmrzcw.Size = new System.Drawing.Size(268, 22);
            this.tsmiSzwlfjbxxmrzcw.Text = "设置往来方基本信息默认值错误。";
            // 
            // tsmiSzwlfxxxxmrzcw
            // 
            this.tsmiSzwlfxxxxmrzcw.Name = "tsmiSzwlfxxxxmrzcw";
            this.tsmiSzwlfxxxxmrzcw.Size = new System.Drawing.Size(268, 22);
            this.tsmiSzwlfxxxxmrzcw.Text = "设置往来方详细信息默认值错误。";
            // 
            // FrmBussinessInfo_New
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1228, 537);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmBussinessInfo_New";
            this.TabText = "往来方信息登记";
            this.Text = "往来方信息登记";
            this.Load += new System.EventHandler(this.FrmBussinessInfo_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSBussiness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBussinessBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBussinessDetailInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBussinessFinancialInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDetailInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSFinancialInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlRight)).EndInit();
            this.pnlRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlOtherInfo)).EndInit();
            this.TabControlOtherInfo.ResumeLayout(false);
            this.PageDetailInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlDetailInfo)).EndInit();
            this.pnlDetailInfo.ResumeLayout(false);
            this.pnlDetailInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textContact.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpCountryCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textWebSite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textE_mail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textFaxNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPhoneNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textZipCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCompanyAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCompanyLR.Properties)).EndInit();
            this.PageFinancialInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFinancialInfo)).EndInit();
            this.pnlFinancialInfo.ResumeLayout(false);
            this.pnlFinancialInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBussinessLicense.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBankAccout.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLeft)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewBaseInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkBussinessIsUse.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpBussinessCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBussinessBaseText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBussinessBaseNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSBussiness;
        private System.Data.DataTable TableBussinessBaseInfo;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColBussinessBaseNo;
        private System.Data.DataColumn dataColBussinessBaseText;
        private System.Data.DataColumn dataColBussinessCategory;
        private System.Data.DataColumn dataColBussinessCategoryText;
        private System.Data.DataColumn dataColBussinessIsUse;
        private System.Data.DataTable TableBussinessDetailInfo;
        private System.Data.DataColumn dataCoAutoId;
        private System.Data.DataColumn dataCoBussinessBaseNo;
        private System.Data.DataColumn dataCoCompanyLR;
        private System.Data.DataColumn dataCoCompanyAddress;
        private System.Data.DataColumn dataCoZipCode;
        private System.Data.DataColumn dataCoPhoneNo;
        private System.Data.DataColumn dataCoFaxNo;
        private System.Data.DataColumn dataCoE_mail;
        private System.Data.DataColumn dataCoWebSite;
        private System.Data.DataColumn dataCoCountryCode;
        private System.Data.DataTable TableBussinessFinancialInfo;
        private System.Data.DataColumn dataCAutoId;
        private System.Data.DataColumn dataCBussinessBaseNo;
        private System.Data.DataColumn dataCBussinessLicense;
        private System.Data.DataColumn dataCBankAccout;
        private System.Data.DataColumn dataCBankAddress;
        private System.Windows.Forms.BindingSource bSBaseInfo;
        private System.Windows.Forms.BindingSource bSDetailInfo;
        private System.Windows.Forms.BindingSource bSFinancialInfo;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlRight;
        private DevExpress.XtraEditors.PanelControl pnlLeft;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.LabelControl labBussinessCategory;
        private DevExpress.XtraEditors.LookUpEdit lookUpBussinessCategory;
        private DevExpress.XtraEditors.TextEdit textBussinessBaseText;
        private DevExpress.XtraEditors.TextEdit textBussinessBaseNo;
        private DevExpress.XtraEditors.LabelControl labBussinessBaseText;
        private DevExpress.XtraEditors.LabelControl labBussinessBaseNo;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlBaseInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewBaseInfo;
        private DevExpress.XtraEditors.CheckEdit checkBussinessIsUse;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseNo;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessBaseText;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessCategory;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessCategoryText;
        private DevExpress.XtraGrid.Columns.GridColumn colBussinessIsUse;
        private DevExpress.XtraTab.XtraTabControl TabControlOtherInfo;
        private DevExpress.XtraTab.XtraTabPage PageDetailInfo;
        private DevExpress.XtraTab.XtraTabPage PageFinancialInfo;
        private DevExpress.XtraEditors.PanelControl pnlDetailInfo;
        private DevExpress.XtraEditors.PanelControl pnlFinancialInfo;
        private System.Data.DataColumn dataCoContact;
        private DevExpress.XtraEditors.TextEdit textContact;
        private DevExpress.XtraEditors.LabelControl labContact;
        private DevExpress.XtraEditors.LabelControl labCountryCode;
        private DevExpress.XtraEditors.LookUpEdit lookUpCountryCode;
        private DevExpress.XtraEditors.TextEdit textWebSite;
        private DevExpress.XtraEditors.LabelControl labWebSite;
        private DevExpress.XtraEditors.TextEdit textE_mail;
        private DevExpress.XtraEditors.LabelControl labE_mail;
        private DevExpress.XtraEditors.TextEdit textFaxNo;
        private DevExpress.XtraEditors.LabelControl labFaxNo;
        private DevExpress.XtraEditors.TextEdit textPhoneNo;
        private DevExpress.XtraEditors.LabelControl labPhoneNo;
        private DevExpress.XtraEditors.TextEdit textZipCode;
        private DevExpress.XtraEditors.LabelControl labZipCode;
        private DevExpress.XtraEditors.TextEdit textCompanyAddress;
        private DevExpress.XtraEditors.LabelControl labCompanyAddress;
        private DevExpress.XtraEditors.TextEdit textCompanyLR;
        private DevExpress.XtraEditors.LabelControl labCompanyLR;
        private DevExpress.XtraEditors.TextEdit textBussinessLicense;
        private DevExpress.XtraEditors.LabelControl labBussinessLicense;
        private DevExpress.XtraEditors.TextEdit textBankAddress;
        private DevExpress.XtraEditors.LabelControl labBankAddress;
        private DevExpress.XtraEditors.TextEdit textBankAccout;
        private DevExpress.XtraEditors.LabelControl labBankAccout;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SplitterControl splitterMiddle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiWlfbh;
        private System.Windows.Forms.ToolStripMenuItem tsmiWlfmc;
        private System.Windows.Forms.ToolStripMenuItem tsmiWlffl;
        private System.Windows.Forms.ToolStripMenuItem tsmiSzwlfjbxxmrzcw;
        private System.Windows.Forms.ToolStripMenuItem tsmiSzwlfxxxxmrzcw;
    }
}