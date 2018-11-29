namespace PSAP.VIEW.PURVIEW
{
    partial class FrmPrReqQuery
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
            this.pnltop = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxReqState = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labApplicant = new DevExpress.XtraEditors.LabelControl();
            this.lookUpApplicant = new DevExpress.XtraEditors.LookUpEdit();
            this.labReqState = new DevExpress.XtraEditors.LabelControl();
            this.lookUpPurCategory = new DevExpress.XtraEditors.LookUpEdit();
            this.labPurCategory = new DevExpress.XtraEditors.LabelControl();
            this.lookUpReqDep = new DevExpress.XtraEditors.LookUpEdit();
            this.labReqDep = new DevExpress.XtraEditors.LabelControl();
            this.btnQuery = new DevExpress.XtraEditors.SimpleButton();
            this.dateReqDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.lab = new DevExpress.XtraEditors.LabelControl();
            this.labReqDate = new DevExpress.XtraEditors.LabelControl();
            this.dateReqDateBegin = new DevExpress.XtraEditors.DateEdit();
            this.labCommon = new DevExpress.XtraEditors.LabelControl();
            this.textCommon = new DevExpress.XtraEditors.TextEdit();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
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
            this.dataTablePrReqList = new System.Data.DataTable();
            this.dataColumnAutoId = new System.Data.DataColumn();
            this.dataColumnPrReqNo = new System.Data.DataColumn();
            this.dataColCodeFileName = new System.Data.DataColumn();
            this.dataColQty = new System.Data.DataColumn();
            this.dataColRequirementDate = new System.Data.DataColumn();
            this.dataColPrReqListRemark = new System.Data.DataColumn();
            this.dataColCodeName = new System.Data.DataColumn();
            this.bindingSource_PrReqHead = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).BeginInit();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxReqState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpApplicant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPurCategory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PrReq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqHead)).BeginInit();
            this.SuspendLayout();
            // 
            // pnltop
            // 
            this.pnltop.Controls.Add(this.textCommon);
            this.pnltop.Controls.Add(this.labCommon);
            this.pnltop.Controls.Add(this.comboBoxReqState);
            this.pnltop.Controls.Add(this.labApplicant);
            this.pnltop.Controls.Add(this.lookUpApplicant);
            this.pnltop.Controls.Add(this.labReqState);
            this.pnltop.Controls.Add(this.lookUpPurCategory);
            this.pnltop.Controls.Add(this.labPurCategory);
            this.pnltop.Controls.Add(this.lookUpReqDep);
            this.pnltop.Controls.Add(this.labReqDep);
            this.pnltop.Controls.Add(this.btnQuery);
            this.pnltop.Controls.Add(this.dateReqDateEnd);
            this.pnltop.Controls.Add(this.lab);
            this.pnltop.Controls.Add(this.labReqDate);
            this.pnltop.Controls.Add(this.dateReqDateBegin);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 0);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(794, 78);
            this.pnltop.TabIndex = 1;
            // 
            // comboBoxReqState
            // 
            this.comboBoxReqState.EnterMoveNextControl = true;
            this.comboBoxReqState.Location = new System.Drawing.Point(86, 44);
            this.comboBoxReqState.Name = "comboBoxReqState";
            this.comboBoxReqState.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxReqState.Properties.Items.AddRange(new object[] {
            "全部",
            "待审核",
            "审核",
            "关闭"});
            this.comboBoxReqState.Size = new System.Drawing.Size(100, 20);
            this.comboBoxReqState.TabIndex = 4;
            // 
            // labApplicant
            // 
            this.labApplicant.Location = new System.Drawing.Point(202, 47);
            this.labApplicant.Name = "labApplicant";
            this.labApplicant.Size = new System.Drawing.Size(48, 14);
            this.labApplicant.TabIndex = 11;
            this.labApplicant.Text = "申请人：";
            // 
            // lookUpApplicant
            // 
            this.lookUpApplicant.EnterMoveNextControl = true;
            this.lookUpApplicant.Location = new System.Drawing.Point(250, 44);
            this.lookUpApplicant.Name = "lookUpApplicant";
            this.lookUpApplicant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpApplicant.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AutoId", "AutoId", 80, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LoginId", "用户名", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmpName", "员工名", 80, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpApplicant.Properties.DisplayMember = "EmpName";
            this.lookUpApplicant.Properties.NullText = "";
            this.lookUpApplicant.Properties.ValueMember = "EmpName";
            this.lookUpApplicant.Size = new System.Drawing.Size(100, 20);
            this.lookUpApplicant.TabIndex = 5;
            // 
            // labReqState
            // 
            this.labReqState.Location = new System.Drawing.Point(20, 47);
            this.labReqState.Name = "labReqState";
            this.labReqState.Size = new System.Drawing.Size(60, 14);
            this.labReqState.TabIndex = 9;
            this.labReqState.Text = "单据状态：";
            // 
            // lookUpPurCategory
            // 
            this.lookUpPurCategory.EnterMoveNextControl = true;
            this.lookUpPurCategory.Location = new System.Drawing.Point(555, 14);
            this.lookUpPurCategory.Name = "lookUpPurCategory";
            this.lookUpPurCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPurCategory.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurCategory", "编号", 81, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PurCategoryText", "名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpPurCategory.Properties.DisplayMember = "PurCategoryText";
            this.lookUpPurCategory.Properties.NullText = "";
            this.lookUpPurCategory.Properties.ValueMember = "PurCategory";
            this.lookUpPurCategory.Size = new System.Drawing.Size(100, 20);
            this.lookUpPurCategory.TabIndex = 3;
            // 
            // labPurCategory
            // 
            this.labPurCategory.Location = new System.Drawing.Point(489, 17);
            this.labPurCategory.Name = "labPurCategory";
            this.labPurCategory.Size = new System.Drawing.Size(60, 14);
            this.labPurCategory.TabIndex = 7;
            this.labPurCategory.Text = "采购类型：";
            // 
            // lookUpReqDep
            // 
            this.lookUpReqDep.EnterMoveNextControl = true;
            this.lookUpReqDep.Location = new System.Drawing.Point(374, 14);
            this.lookUpReqDep.Name = "lookUpReqDep";
            this.lookUpReqDep.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpReqDep.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentNo", "部门编号", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "部门名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpReqDep.Properties.DisplayMember = "DepartmentName";
            this.lookUpReqDep.Properties.NullText = "";
            this.lookUpReqDep.Properties.ValueMember = "DepartmentNo";
            this.lookUpReqDep.Size = new System.Drawing.Size(100, 20);
            this.lookUpReqDep.TabIndex = 2;
            // 
            // labReqDep
            // 
            this.labReqDep.Location = new System.Drawing.Point(308, 17);
            this.labReqDep.Name = "labReqDep";
            this.labReqDep.Size = new System.Drawing.Size(60, 14);
            this.labReqDep.TabIndex = 5;
            this.labReqDep.Text = "申请部门：";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(598, 43);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 7;
            this.btnQuery.Text = "查询";
            // 
            // dateReqDateEnd
            // 
            this.dateReqDateEnd.EditValue = null;
            this.dateReqDateEnd.EnterMoveNextControl = true;
            this.dateReqDateEnd.Location = new System.Drawing.Point(202, 14);
            this.dateReqDateEnd.Name = "dateReqDateEnd";
            this.dateReqDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReqDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReqDateEnd.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateReqDateEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateReqDateEnd.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateReqDateEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateReqDateEnd.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateReqDateEnd.Size = new System.Drawing.Size(100, 20);
            this.dateReqDateEnd.TabIndex = 1;
            // 
            // lab
            // 
            this.lab.Location = new System.Drawing.Point(192, 17);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(4, 14);
            this.lab.TabIndex = 2;
            this.lab.Text = "-";
            // 
            // labReqDate
            // 
            this.labReqDate.Location = new System.Drawing.Point(20, 17);
            this.labReqDate.Name = "labReqDate";
            this.labReqDate.Size = new System.Drawing.Size(60, 14);
            this.labReqDate.TabIndex = 1;
            this.labReqDate.Text = "请购日期：";
            // 
            // dateReqDateBegin
            // 
            this.dateReqDateBegin.EditValue = null;
            this.dateReqDateBegin.EnterMoveNextControl = true;
            this.dateReqDateBegin.Location = new System.Drawing.Point(86, 14);
            this.dateReqDateBegin.Name = "dateReqDateBegin";
            this.dateReqDateBegin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReqDateBegin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateReqDateBegin.Properties.DisplayFormat.FormatString = "yyyy-MM-dd";
            this.dateReqDateBegin.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateReqDateBegin.Properties.EditFormat.FormatString = "yyyy-MM-dd";
            this.dateReqDateBegin.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateReqDateBegin.Properties.Mask.EditMask = "yyyy-MM-dd";
            this.dateReqDateBegin.Size = new System.Drawing.Size(100, 20);
            this.dateReqDateBegin.TabIndex = 0;
            // 
            // labCommon
            // 
            this.labCommon.Location = new System.Drawing.Point(366, 47);
            this.labCommon.Name = "labCommon";
            this.labCommon.Size = new System.Drawing.Size(60, 14);
            this.labCommon.TabIndex = 12;
            this.labCommon.Text = "通用查询：";
            // 
            // textCommon
            // 
            this.textCommon.Location = new System.Drawing.Point(432, 44);
            this.textCommon.Name = "textCommon";
            this.textCommon.Size = new System.Drawing.Size(150, 20);
            this.textCommon.TabIndex = 6;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBottom.Location = new System.Drawing.Point(0, 78);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(794, 217);
            this.pnlBottom.TabIndex = 2;
            // 
            // dataSet_PrReq
            // 
            this.dataSet_PrReq.DataSetName = "NewDataSet";
            this.dataSet_PrReq.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTablePrReqHead,
            this.dataTablePrReqList});
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
            this.dataColPrReqRemark});
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
            // dataTablePrReqList
            // 
            this.dataTablePrReqList.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumnAutoId,
            this.dataColumnPrReqNo,
            this.dataColCodeFileName,
            this.dataColQty,
            this.dataColRequirementDate,
            this.dataColPrReqListRemark,
            this.dataColCodeName});
            this.dataTablePrReqList.TableName = "PrReqList";
            // 
            // dataColumnAutoId
            // 
            this.dataColumnAutoId.ColumnName = "AutoId";
            // 
            // dataColumnPrReqNo
            // 
            this.dataColumnPrReqNo.Caption = "请购单号";
            this.dataColumnPrReqNo.ColumnName = "PrReqNo";
            // 
            // dataColCodeFileName
            // 
            this.dataColCodeFileName.Caption = "文件名称";
            this.dataColCodeFileName.ColumnName = "CodeFileName";
            // 
            // dataColQty
            // 
            this.dataColQty.Caption = "数量";
            this.dataColQty.ColumnName = "Qty";
            this.dataColQty.DataType = typeof(double);
            // 
            // dataColRequirementDate
            // 
            this.dataColRequirementDate.Caption = "需求日期";
            this.dataColRequirementDate.ColumnName = "RequirementDate";
            this.dataColRequirementDate.DataType = typeof(System.DateTime);
            // 
            // dataColPrReqListRemark
            // 
            this.dataColPrReqListRemark.Caption = "备注";
            this.dataColPrReqListRemark.ColumnName = "PrReqListRemark";
            // 
            // dataColCodeName
            // 
            this.dataColCodeName.Caption = "零件名称";
            this.dataColCodeName.ColumnName = "CodeName";
            // 
            // bindingSource_PrReqHead
            // 
            this.bindingSource_PrReqHead.DataMember = "PrReqHead";
            this.bindingSource_PrReqHead.DataSource = this.dataSet_PrReq;
            // 
            // FrmPrReqQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 295);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnltop);
            this.Name = "FrmPrReqQuery";
            this.Text = "采购请购单查询";
            ((System.ComponentModel.ISupportInitialize)(this.pnltop)).EndInit();
            this.pnltop.ResumeLayout(false);
            this.pnltop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxReqState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpApplicant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPurCategory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpReqDep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateReqDateBegin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textCommon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_PrReq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrReqList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_PrReqHead)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnltop;
        private DevExpress.XtraEditors.TextEdit textCommon;
        private DevExpress.XtraEditors.LabelControl labCommon;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxReqState;
        private DevExpress.XtraEditors.LabelControl labApplicant;
        private DevExpress.XtraEditors.LookUpEdit lookUpApplicant;
        private DevExpress.XtraEditors.LabelControl labReqState;
        private DevExpress.XtraEditors.LookUpEdit lookUpPurCategory;
        private DevExpress.XtraEditors.LabelControl labPurCategory;
        private DevExpress.XtraEditors.LookUpEdit lookUpReqDep;
        private DevExpress.XtraEditors.LabelControl labReqDep;
        private DevExpress.XtraEditors.SimpleButton btnQuery;
        private DevExpress.XtraEditors.DateEdit dateReqDateEnd;
        private DevExpress.XtraEditors.LabelControl lab;
        private DevExpress.XtraEditors.LabelControl labReqDate;
        private DevExpress.XtraEditors.DateEdit dateReqDateBegin;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
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
        private System.Data.DataTable dataTablePrReqList;
        private System.Data.DataColumn dataColumnAutoId;
        private System.Data.DataColumn dataColumnPrReqNo;
        private System.Data.DataColumn dataColCodeFileName;
        private System.Data.DataColumn dataColQty;
        private System.Data.DataColumn dataColRequirementDate;
        private System.Data.DataColumn dataColPrReqListRemark;
        private System.Data.DataColumn dataColCodeName;
        private System.Windows.Forms.BindingSource bindingSource_PrReqHead;
    }
}