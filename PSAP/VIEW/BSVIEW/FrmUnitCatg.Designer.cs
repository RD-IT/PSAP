namespace PSAP.VIEW.BSVIEW
{
    partial class FrmUnitCatg
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
            System.Windows.Forms.Label unitNoLabel;
            System.Windows.Forms.Label unitNameLabel;
            System.Windows.Forms.Label unitDescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUnitCatg));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bS_DepartmentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bS_UnitCatgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPSAP = new PSAP.dsPSAP();
            this.bdnCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bdnMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bdnMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bdnPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bdnMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bdnMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsControl = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbCancel = new System.Windows.Forms.ToolStripButton();
            this.tsbQuery = new System.Windows.Forms.ToolStripButton();
            this.tsbDGViewExportToCSV = new System.Windows.Forms.ToolStripButton();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.bS_UnitCatgTableAdapter = new PSAP.dsPSAPTableAdapters.BS_UnitCatgTableAdapter();
            this.tableAdapterManager = new PSAP.dsPSAPTableAdapters.TableAdapterManager();
            this.unitNoTextBox = new System.Windows.Forms.TextBox();
            this.unitNameTextBox = new System.Windows.Forms.TextBox();
            this.unitDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.bS_UnitCatgDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            unitNoLabel = new System.Windows.Forms.Label();
            unitNameLabel = new System.Windows.Forms.Label();
            unitDescriptionLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingNavigator)).BeginInit();
            this.bS_DepartmentBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_UnitCatgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).BeginInit();
            this.tsControl.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_UnitCatgDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // unitNoLabel
            // 
            unitNoLabel.AutoSize = true;
            unitNoLabel.Location = new System.Drawing.Point(3, 15);
            unitNoLabel.Name = "unitNoLabel";
            unitNoLabel.Size = new System.Drawing.Size(53, 12);
            unitNoLabel.TabIndex = 6;
            unitNoLabel.Text = "单位编号";
            // 
            // unitNameLabel
            // 
            unitNameLabel.AutoSize = true;
            unitNameLabel.Location = new System.Drawing.Point(3, 42);
            unitNameLabel.Name = "unitNameLabel";
            unitNameLabel.Size = new System.Drawing.Size(53, 12);
            unitNameLabel.TabIndex = 8;
            unitNameLabel.Text = "单位名称";
            // 
            // unitDescriptionLabel
            // 
            unitDescriptionLabel.AutoSize = true;
            unitDescriptionLabel.Location = new System.Drawing.Point(3, 69);
            unitDescriptionLabel.Name = "unitDescriptionLabel";
            unitDescriptionLabel.Size = new System.Drawing.Size(53, 12);
            unitDescriptionLabel.TabIndex = 10;
            unitDescriptionLabel.Text = "单位描述";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bS_DepartmentBindingNavigator);
            this.panel1.Controls.Add(this.tsControl);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 58);
            this.panel1.TabIndex = 4;
            // 
            // bS_DepartmentBindingNavigator
            // 
            this.bS_DepartmentBindingNavigator.AddNewItem = null;
            this.bS_DepartmentBindingNavigator.BindingSource = this.bS_UnitCatgBindingSource;
            this.bS_DepartmentBindingNavigator.CountItem = this.bdnCountItem;
            this.bS_DepartmentBindingNavigator.DeleteItem = null;
            this.bS_DepartmentBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.bS_DepartmentBindingNavigator.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bS_DepartmentBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bS_DepartmentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bdnMoveFirstItem,
            this.bdnMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bdnPositionItem,
            this.bdnCountItem,
            this.bindingNavigatorSeparator1,
            this.bdnMoveNextItem,
            this.bdnMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bS_DepartmentBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.bS_DepartmentBindingNavigator.MoveFirstItem = this.bdnMoveFirstItem;
            this.bS_DepartmentBindingNavigator.MoveLastItem = this.bdnMoveLastItem;
            this.bS_DepartmentBindingNavigator.MoveNextItem = this.bdnMoveNextItem;
            this.bS_DepartmentBindingNavigator.MovePreviousItem = this.bdnMovePreviousItem;
            this.bS_DepartmentBindingNavigator.Name = "bS_DepartmentBindingNavigator";
            this.bS_DepartmentBindingNavigator.PositionItem = this.bdnPositionItem;
            this.bS_DepartmentBindingNavigator.Size = new System.Drawing.Size(197, 25);
            this.bS_DepartmentBindingNavigator.TabIndex = 3;
            this.bS_DepartmentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bS_UnitCatgBindingSource
            // 
            this.bS_UnitCatgBindingSource.DataMember = "BS_UnitCatg";
            this.bS_UnitCatgBindingSource.DataSource = this.dsPSAP;
            // 
            // dsPSAP
            // 
            this.dsPSAP.DataSetName = "dsPSAP";
            this.dsPSAP.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdnCountItem
            // 
            this.bdnCountItem.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bdnCountItem.Name = "bdnCountItem";
            this.bdnCountItem.Size = new System.Drawing.Size(32, 22);
            this.bdnCountItem.Text = "/ {0}";
            this.bdnCountItem.ToolTipText = "总项数";
            // 
            // bdnMoveFirstItem
            // 
            this.bdnMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bdnMoveFirstItem.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.bdnMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bdnMoveFirstItem.Image")));
            this.bdnMoveFirstItem.Name = "bdnMoveFirstItem";
            this.bdnMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bdnMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bdnMoveFirstItem.Text = "移到第一条记录";
            // 
            // bdnMovePreviousItem
            // 
            this.bdnMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bdnMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bdnMovePreviousItem.Image")));
            this.bdnMovePreviousItem.Name = "bdnMovePreviousItem";
            this.bdnMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bdnMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bdnMovePreviousItem.Text = "移到上一条记录";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bdnPositionItem
            // 
            this.bdnPositionItem.AccessibleName = "位置";
            this.bdnPositionItem.AutoSize = false;
            this.bdnPositionItem.Name = "bdnPositionItem";
            this.bdnPositionItem.Size = new System.Drawing.Size(50, 25);
            this.bdnPositionItem.Text = "0";
            this.bdnPositionItem.ToolTipText = "当前位置";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bdnMoveNextItem
            // 
            this.bdnMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bdnMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bdnMoveNextItem.Image")));
            this.bdnMoveNextItem.Name = "bdnMoveNextItem";
            this.bdnMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bdnMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bdnMoveNextItem.Text = "移到下一条记录";
            // 
            // bdnMoveLastItem
            // 
            this.bdnMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bdnMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bdnMoveLastItem.Image")));
            this.bdnMoveLastItem.Name = "bdnMoveLastItem";
            this.bdnMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bdnMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bdnMoveLastItem.Text = "移到最后一条记录";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.tsbQuery.Click += new System.EventHandler(this.tsbQuery_Click);
            // 
            // tsbDGViewExportToCSV
            // 
            this.tsbDGViewExportToCSV.Image = ((System.Drawing.Image)(resources.GetObject("tsbDGViewExportToCSV.Image")));
            this.tsbDGViewExportToCSV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDGViewExportToCSV.Name = "tsbDGViewExportToCSV";
            this.tsbDGViewExportToCSV.Size = new System.Drawing.Size(76, 22);
            this.tsbDGViewExportToCSV.Text = "导出数据";
            this.tsbDGViewExportToCSV.Click += new System.EventHandler(this.tsbDGViewExportToCSV_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(52, 22);
            this.tsbClose.Text = "退出";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // bS_UnitCatgTableAdapter
            // 
            this.bS_UnitCatgTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BS_DepartmentTableAdapter = null;
            this.tableAdapterManager.BS_MenuTableAdapter = null;
            this.tableAdapterManager.BS_RoleTableAdapter = null;
            this.tableAdapterManager.BS_UnitCatgTableAdapter = this.bS_UnitCatgTableAdapter;
            this.tableAdapterManager.BS_UserInfoTableAdapter = null;
            this.tableAdapterManager.BS_UserRightTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PSAP.dsPSAPTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // unitNoTextBox
            // 
            this.unitNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_UnitCatgBindingSource, "UnitNo", true));
            this.unitNoTextBox.Location = new System.Drawing.Point(66, 12);
            this.unitNoTextBox.Name = "unitNoTextBox";
            this.unitNoTextBox.Size = new System.Drawing.Size(200, 21);
            this.unitNoTextBox.TabIndex = 7;
            this.unitNoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitNoTextBox_KeyPress);
            // 
            // unitNameTextBox
            // 
            this.unitNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_UnitCatgBindingSource, "UnitName", true));
            this.unitNameTextBox.Location = new System.Drawing.Point(66, 39);
            this.unitNameTextBox.Name = "unitNameTextBox";
            this.unitNameTextBox.Size = new System.Drawing.Size(200, 21);
            this.unitNameTextBox.TabIndex = 9;
            this.unitNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitNameTextBox_KeyPress);
            // 
            // unitDescriptionTextBox
            // 
            this.unitDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bS_UnitCatgBindingSource, "UnitDescription", true));
            this.unitDescriptionTextBox.Location = new System.Drawing.Point(66, 66);
            this.unitDescriptionTextBox.Name = "unitDescriptionTextBox";
            this.unitDescriptionTextBox.Size = new System.Drawing.Size(200, 21);
            this.unitDescriptionTextBox.TabIndex = 11;
            this.unitDescriptionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.unitDescriptionTextBox_KeyPress);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(unitNoLabel);
            this.pnlEdit.Controls.Add(this.unitDescriptionTextBox);
            this.pnlEdit.Controls.Add(unitDescriptionLabel);
            this.pnlEdit.Controls.Add(this.unitNameTextBox);
            this.pnlEdit.Controls.Add(this.unitNoTextBox);
            this.pnlEdit.Controls.Add(unitNameLabel);
            this.pnlEdit.Enabled = false;
            this.pnlEdit.Location = new System.Drawing.Point(0, 65);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(628, 104);
            this.pnlEdit.TabIndex = 12;
            // 
            // bS_UnitCatgDataGridView
            // 
            this.bS_UnitCatgDataGridView.AutoGenerateColumns = false;
            this.bS_UnitCatgDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bS_UnitCatgDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bS_UnitCatgDataGridView.DataSource = this.bS_UnitCatgBindingSource;
            this.bS_UnitCatgDataGridView.Location = new System.Drawing.Point(1, 175);
            this.bS_UnitCatgDataGridView.Name = "bS_UnitCatgDataGridView";
            this.bS_UnitCatgDataGridView.RowTemplate.Height = 23;
            this.bS_UnitCatgDataGridView.Size = new System.Drawing.Size(636, 295);
            this.bS_UnitCatgDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "UnitNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "单位编号";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitName";
            this.dataGridViewTextBoxColumn3.HeaderText = "单位名称";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "UnitDescription";
            this.dataGridViewTextBoxColumn4.HeaderText = "单位描述";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FrmUnitCatg
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(842, 482);
            this.Controls.Add(this.bS_UnitCatgDataGridView);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "FrmUnitCatg";
            this.TabText = "计量单位";
            this.Text = "计量单位";
            this.Load += new System.EventHandler(this.FrmUnitCatg_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_DepartmentBindingNavigator)).EndInit();
            this.bS_DepartmentBindingNavigator.ResumeLayout(false);
            this.bS_DepartmentBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_UnitCatgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPSAP)).EndInit();
            this.tsControl.ResumeLayout(false);
            this.tsControl.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bS_UnitCatgDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingNavigator bS_DepartmentBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bdnCountItem;
        private System.Windows.Forms.ToolStripButton bdnMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bdnMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bdnPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bdnMoveNextItem;
        private System.Windows.Forms.ToolStripButton bdnMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStrip tsControl;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbCancel;
        private System.Windows.Forms.ToolStripButton tsbQuery;
        private System.Windows.Forms.ToolStripButton tsbDGViewExportToCSV;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private dsPSAP dsPSAP;
        private System.Windows.Forms.BindingSource bS_UnitCatgBindingSource;
        private dsPSAPTableAdapters.BS_UnitCatgTableAdapter bS_UnitCatgTableAdapter;
        private dsPSAPTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox unitNoTextBox;
        private System.Windows.Forms.TextBox unitNameTextBox;
        private System.Windows.Forms.TextBox unitDescriptionTextBox;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.DataGridView bS_UnitCatgDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}