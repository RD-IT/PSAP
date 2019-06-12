namespace PSAP.VIEW.BSVIEW
{
    partial class FrmUserInfo_New
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
            this.dSUserInfo = new System.Data.DataSet();
            this.TableUserInfo = new System.Data.DataTable();
            this.dataColAutoId = new System.Data.DataColumn();
            this.dataColEmpName = new System.Data.DataColumn();
            this.dataColDepartmentNo = new System.Data.DataColumn();
            this.dataColLoginId = new System.Data.DataColumn();
            this.dataColLoginPwd = new System.Data.DataColumn();
            this.dataColFounder = new System.Data.DataColumn();
            this.dataColCreateDate = new System.Data.DataColumn();
            this.dataColBfree1 = new System.Data.DataColumn();
            this.dataColBfree2 = new System.Data.DataColumn();
            this.dataColBfree3 = new System.Data.DataColumn();
            this.dataColBfree4 = new System.Data.DataColumn();
            this.dataColBfree5 = new System.Data.DataColumn();
            this.dataColDepartmentName = new System.Data.DataColumn();
            this.bSUserInfo = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolBar = new DevExpress.XtraEditors.PanelControl();
            this.pnlEdit = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpDept = new DevExpress.XtraEditors.LookUpEdit();
            this.textLoginPwd = new DevExpress.XtraEditors.TextEdit();
            this.textEmpName = new DevExpress.XtraEditors.TextEdit();
            this.textLoginId = new DevExpress.XtraEditors.TextEdit();
            this.labLoginPwd = new DevExpress.XtraEditors.LabelControl();
            this.labEmpName = new DevExpress.XtraEditors.LabelControl();
            this.labLoginId = new DevExpress.XtraEditors.LabelControl();
            this.pnlGrid = new DevExpress.XtraEditors.PanelControl();
            this.gridCrlUserInfo = new DevExpress.XtraGrid.GridControl();
            this.gridViewUserInfo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAutoId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmpName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginPwd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFounder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBfree1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBfree2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBfree3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBfree4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBfree5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDlmbnwk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiYgxmbnwk = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dSUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDept.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLoginPwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEmpName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLoginId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).BeginInit();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserInfo)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSUserInfo
            // 
            this.dSUserInfo.DataSetName = "NewDataSet";
            this.dSUserInfo.Tables.AddRange(new System.Data.DataTable[] {
            this.TableUserInfo});
            // 
            // TableUserInfo
            // 
            this.TableUserInfo.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColAutoId,
            this.dataColEmpName,
            this.dataColDepartmentNo,
            this.dataColLoginId,
            this.dataColLoginPwd,
            this.dataColFounder,
            this.dataColCreateDate,
            this.dataColBfree1,
            this.dataColBfree2,
            this.dataColBfree3,
            this.dataColBfree4,
            this.dataColBfree5,
            this.dataColDepartmentName});
            this.TableUserInfo.TableName = "UserInfo";
            this.TableUserInfo.TableNewRow += new System.Data.DataTableNewRowEventHandler(this.TableUserInfo_TableNewRow);
            // 
            // dataColAutoId
            // 
            this.dataColAutoId.ColumnName = "AutoId";
            this.dataColAutoId.DataType = typeof(int);
            // 
            // dataColEmpName
            // 
            this.dataColEmpName.Caption = "员工姓名";
            this.dataColEmpName.ColumnName = "EmpName";
            // 
            // dataColDepartmentNo
            // 
            this.dataColDepartmentNo.Caption = "部门编号";
            this.dataColDepartmentNo.ColumnName = "DepartmentNo";
            // 
            // dataColLoginId
            // 
            this.dataColLoginId.Caption = "登陆名";
            this.dataColLoginId.ColumnName = "LoginId";
            // 
            // dataColLoginPwd
            // 
            this.dataColLoginPwd.Caption = "密码";
            this.dataColLoginPwd.ColumnName = "LoginPwd";
            // 
            // dataColFounder
            // 
            this.dataColFounder.Caption = "创建人";
            this.dataColFounder.ColumnName = "Founder";
            // 
            // dataColCreateDate
            // 
            this.dataColCreateDate.Caption = "创建时间";
            this.dataColCreateDate.ColumnName = "CreateDate";
            this.dataColCreateDate.DataType = typeof(System.DateTime);
            // 
            // dataColBfree1
            // 
            this.dataColBfree1.ColumnName = "Bfree1";
            // 
            // dataColBfree2
            // 
            this.dataColBfree2.ColumnName = "Bfree2";
            // 
            // dataColBfree3
            // 
            this.dataColBfree3.ColumnName = "Bfree3";
            // 
            // dataColBfree4
            // 
            this.dataColBfree4.ColumnName = "Bfree4";
            // 
            // dataColBfree5
            // 
            this.dataColBfree5.ColumnName = "Bfree5";
            // 
            // dataColDepartmentName
            // 
            this.dataColDepartmentName.Caption = "部门名称";
            this.dataColDepartmentName.ColumnName = "DepartmentName";
            // 
            // bSUserInfo
            // 
            this.bSUserInfo.DataMember = "UserInfo";
            this.bSUserInfo.DataSource = this.dSUserInfo;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolBar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(950, 40);
            this.pnlToolBar.TabIndex = 2;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.labelControl1);
            this.pnlEdit.Controls.Add(this.lookUpDept);
            this.pnlEdit.Controls.Add(this.textLoginPwd);
            this.pnlEdit.Controls.Add(this.textEmpName);
            this.pnlEdit.Controls.Add(this.textLoginId);
            this.pnlEdit.Controls.Add(this.labLoginPwd);
            this.pnlEdit.Controls.Add(this.labEmpName);
            this.pnlEdit.Controls.Add(this.labLoginId);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEdit.Location = new System.Drawing.Point(0, 40);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(950, 97);
            this.pnlEdit.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(567, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "所属部门";
            // 
            // lookUpDept
            // 
            this.lookUpDept.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSUserInfo, "DepartmentNo", true));
            this.lookUpDept.EnterMoveNextControl = true;
            this.lookUpDept.Location = new System.Drawing.Point(654, 21);
            this.lookUpDept.Name = "lookUpDept";
            this.lookUpDept.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpDept.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentNo", "部门编号", 95, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepartmentName", "部门名称", 111, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpDept.Properties.DisplayMember = "DepartmentName";
            this.lookUpDept.Properties.NullText = "";
            this.lookUpDept.Properties.ValueMember = "DepartmentNo";
            this.lookUpDept.Size = new System.Drawing.Size(150, 20);
            this.lookUpDept.TabIndex = 2;
            // 
            // textLoginPwd
            // 
            this.textLoginPwd.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSUserInfo, "LoginPwd", true));
            this.textLoginPwd.EnterMoveNextControl = true;
            this.textLoginPwd.Location = new System.Drawing.Point(112, 55);
            this.textLoginPwd.Name = "textLoginPwd";
            this.textLoginPwd.Properties.PasswordChar = '*';
            this.textLoginPwd.Size = new System.Drawing.Size(150, 20);
            this.textLoginPwd.TabIndex = 3;
            // 
            // textEmpName
            // 
            this.textEmpName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSUserInfo, "EmpName", true));
            this.textEmpName.EnterMoveNextControl = true;
            this.textEmpName.Location = new System.Drawing.Point(380, 21);
            this.textEmpName.Name = "textEmpName";
            this.textEmpName.Size = new System.Drawing.Size(150, 20);
            this.textEmpName.TabIndex = 1;
            // 
            // textLoginId
            // 
            this.textLoginId.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bSUserInfo, "LoginId", true));
            this.textLoginId.EnterMoveNextControl = true;
            this.textLoginId.Location = new System.Drawing.Point(112, 21);
            this.textLoginId.Name = "textLoginId";
            this.textLoginId.Size = new System.Drawing.Size(150, 20);
            this.textLoginId.TabIndex = 0;
            // 
            // labLoginPwd
            // 
            this.labLoginPwd.Location = new System.Drawing.Point(36, 58);
            this.labLoginPwd.Name = "labLoginPwd";
            this.labLoginPwd.Size = new System.Drawing.Size(24, 14);
            this.labLoginPwd.TabIndex = 15;
            this.labLoginPwd.Text = "密码";
            // 
            // labEmpName
            // 
            this.labEmpName.Location = new System.Drawing.Point(300, 24);
            this.labEmpName.Name = "labEmpName";
            this.labEmpName.Size = new System.Drawing.Size(48, 14);
            this.labEmpName.TabIndex = 14;
            this.labEmpName.Text = "员工姓名";
            // 
            // labLoginId
            // 
            this.labLoginId.Location = new System.Drawing.Point(36, 24);
            this.labLoginId.Name = "labLoginId";
            this.labLoginId.Size = new System.Drawing.Size(36, 14);
            this.labLoginId.TabIndex = 12;
            this.labLoginId.Text = "登陆名";
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.gridCrlUserInfo);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 137);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(950, 467);
            this.pnlGrid.TabIndex = 7;
            // 
            // gridCrlUserInfo
            // 
            this.gridCrlUserInfo.DataSource = this.bSUserInfo;
            this.gridCrlUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCrlUserInfo.Location = new System.Drawing.Point(2, 2);
            this.gridCrlUserInfo.MainView = this.gridViewUserInfo;
            this.gridCrlUserInfo.Name = "gridCrlUserInfo";
            this.gridCrlUserInfo.Size = new System.Drawing.Size(946, 463);
            this.gridCrlUserInfo.TabIndex = 0;
            this.gridCrlUserInfo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUserInfo});
            // 
            // gridViewUserInfo
            // 
            this.gridViewUserInfo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAutoId,
            this.colEmpName,
            this.colDepartmentNo,
            this.colDepartmentName,
            this.colLoginId,
            this.colLoginPwd,
            this.colFounder,
            this.colCreateDate,
            this.colBfree1,
            this.colBfree2,
            this.colBfree3,
            this.colBfree4,
            this.colBfree5});
            this.gridViewUserInfo.GridControl = this.gridCrlUserInfo;
            this.gridViewUserInfo.IndicatorWidth = 40;
            this.gridViewUserInfo.Name = "gridViewUserInfo";
            this.gridViewUserInfo.OptionsBehavior.Editable = false;
            this.gridViewUserInfo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewUserInfo.OptionsView.ColumnAutoWidth = false;
            this.gridViewUserInfo.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewUserInfo.OptionsView.ShowFooter = true;
            this.gridViewUserInfo.OptionsView.ShowGroupPanel = false;
            // 
            // colAutoId
            // 
            this.colAutoId.FieldName = "AutoId";
            this.colAutoId.Name = "colAutoId";
            // 
            // colEmpName
            // 
            this.colEmpName.AppearanceHeader.Options.UseTextOptions = true;
            this.colEmpName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colEmpName.FieldName = "EmpName";
            this.colEmpName.Name = "colEmpName";
            this.colEmpName.Visible = true;
            this.colEmpName.VisibleIndex = 1;
            this.colEmpName.Width = 100;
            // 
            // colDepartmentNo
            // 
            this.colDepartmentNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepartmentNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepartmentNo.FieldName = "DepartmentNo";
            this.colDepartmentNo.Name = "colDepartmentNo";
            this.colDepartmentNo.Visible = true;
            this.colDepartmentNo.VisibleIndex = 2;
            this.colDepartmentNo.Width = 100;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.colDepartmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDepartmentName.FieldName = "DepartmentName";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.Visible = true;
            this.colDepartmentName.VisibleIndex = 3;
            this.colDepartmentName.Width = 120;
            // 
            // colLoginId
            // 
            this.colLoginId.AppearanceHeader.Options.UseTextOptions = true;
            this.colLoginId.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colLoginId.FieldName = "LoginId";
            this.colLoginId.Name = "colLoginId";
            this.colLoginId.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "LoginId", "共计{0}条")});
            this.colLoginId.Visible = true;
            this.colLoginId.VisibleIndex = 0;
            this.colLoginId.Width = 100;
            // 
            // colLoginPwd
            // 
            this.colLoginPwd.FieldName = "LoginPwd";
            this.colLoginPwd.Name = "colLoginPwd";
            // 
            // colFounder
            // 
            this.colFounder.AppearanceHeader.Options.UseTextOptions = true;
            this.colFounder.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFounder.FieldName = "Founder";
            this.colFounder.Name = "colFounder";
            this.colFounder.Visible = true;
            this.colFounder.VisibleIndex = 4;
            this.colFounder.Width = 100;
            // 
            // colCreateDate
            // 
            this.colCreateDate.AppearanceHeader.Options.UseTextOptions = true;
            this.colCreateDate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCreateDate.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colCreateDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colCreateDate.FieldName = "CreateDate";
            this.colCreateDate.Name = "colCreateDate";
            this.colCreateDate.Visible = true;
            this.colCreateDate.VisibleIndex = 5;
            this.colCreateDate.Width = 150;
            // 
            // colBfree1
            // 
            this.colBfree1.FieldName = "Bfree1";
            this.colBfree1.Name = "colBfree1";
            // 
            // colBfree2
            // 
            this.colBfree2.FieldName = "Bfree2";
            this.colBfree2.Name = "colBfree2";
            // 
            // colBfree3
            // 
            this.colBfree3.FieldName = "Bfree3";
            this.colBfree3.Name = "colBfree3";
            // 
            // colBfree4
            // 
            this.colBfree4.FieldName = "Bfree4";
            this.colBfree4.Name = "colBfree4";
            // 
            // colBfree5
            // 
            this.colBfree5.FieldName = "Bfree5";
            this.colBfree5.Name = "colBfree5";
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDlmbnwk,
            this.tsmiYgxmbnwk});
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(257, 70);
            // 
            // tsmiDlmbnwk
            // 
            this.tsmiDlmbnwk.Name = "tsmiDlmbnwk";
            this.tsmiDlmbnwk.Size = new System.Drawing.Size(256, 22);
            this.tsmiDlmbnwk.Text = "登陆名不能为空，请重新操作。";
            // 
            // tsmiYgxmbnwk
            // 
            this.tsmiYgxmbnwk.Name = "tsmiYgxmbnwk";
            this.tsmiYgxmbnwk.Size = new System.Drawing.Size(256, 22);
            this.tsmiYgxmbnwk.Text = "员工姓名不能为空，请重新操作。";
            // 
            // FrmUserInfo_New
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(950, 604);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlToolBar);
            this.Name = "FrmUserInfo_New";
            this.TabText = "用户信息";
            this.Text = "用户信息";
            this.Load += new System.EventHandler(this.FrmUserInfo_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlToolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlEdit)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpDept.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLoginPwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEmpName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textLoginId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGrid)).EndInit();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCrlUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUserInfo)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Data.DataSet dSUserInfo;
        private System.Data.DataTable TableUserInfo;
        private System.Data.DataColumn dataColAutoId;
        private System.Data.DataColumn dataColEmpName;
        private System.Data.DataColumn dataColDepartmentNo;
        private System.Data.DataColumn dataColLoginId;
        private System.Data.DataColumn dataColLoginPwd;
        private System.Data.DataColumn dataColFounder;
        private System.Data.DataColumn dataColCreateDate;
        private System.Data.DataColumn dataColBfree1;
        private System.Data.DataColumn dataColBfree2;
        private System.Data.DataColumn dataColBfree3;
        private System.Data.DataColumn dataColBfree4;
        private System.Data.DataColumn dataColBfree5;
        private System.Windows.Forms.BindingSource bSUserInfo;
        private DevExpress.XtraEditors.PanelControl pnlToolBar;
        private DevExpress.XtraEditors.PanelControl pnlEdit;
        private DevExpress.XtraEditors.TextEdit textLoginPwd;
        private DevExpress.XtraEditors.TextEdit textEmpName;
        private DevExpress.XtraEditors.TextEdit textLoginId;
        private DevExpress.XtraEditors.LabelControl labLoginPwd;
        private DevExpress.XtraEditors.LabelControl labEmpName;
        private DevExpress.XtraEditors.LabelControl labLoginId;
        private DevExpress.XtraEditors.PanelControl pnlGrid;
        private DevExpress.XtraGrid.GridControl gridCrlUserInfo;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUserInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colAutoId;
        private DevExpress.XtraGrid.Columns.GridColumn colEmpName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentNo;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginId;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginPwd;
        private DevExpress.XtraGrid.Columns.GridColumn colFounder;
        private DevExpress.XtraGrid.Columns.GridColumn colCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBfree1;
        private DevExpress.XtraGrid.Columns.GridColumn colBfree2;
        private DevExpress.XtraGrid.Columns.GridColumn colBfree3;
        private DevExpress.XtraGrid.Columns.GridColumn colBfree4;
        private DevExpress.XtraGrid.Columns.GridColumn colBfree5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpDept;
        private System.Data.DataColumn dataColDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiDlmbnwk;
        private System.Windows.Forms.ToolStripMenuItem tsmiYgxmbnwk;
    }
}