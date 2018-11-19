namespace PSAP.VIEW.BSVIEW
{
    partial class FrmDataQuery
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tvtbQueryList_User = new PsapUserControlLibrary.TreeViewToolBoxEx();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlQueryCondition = new System.Windows.Forms.Panel();
            this.tableLayoutpnlQueryCondition = new System.Windows.Forms.TableLayoutPanel();
            this.btnExportData = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlQueryCondition.SuspendLayout();
            this.tableLayoutpnlQueryCondition.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 154F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tvtbQueryList_User, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl2, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(842, 482);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tvtbQueryList_User
            // 
            this.tvtbQueryList_User.BoundColoseImageName = null;
            this.tvtbQueryList_User.BoundOpenImageName = null;
            this.tvtbQueryList_User.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.tvtbQueryList_User.FullRowSelect = true;
            this.tvtbQueryList_User.HideSelection = false;
            this.tvtbQueryList_User.HotTracking = true;
            this.tvtbQueryList_User.ItemHeight = 20;
            this.tvtbQueryList_User.LabelEdit = true;
            this.tvtbQueryList_User.Location = new System.Drawing.Point(3, 3);
            this.tvtbQueryList_User.Name = "tvtbQueryList_User";
            this.tvtbQueryList_User.ShowLines = false;
            this.tvtbQueryList_User.ShowPlusMinus = false;
            this.tvtbQueryList_User.ShowRootLines = false;
            this.tvtbQueryList_User.Size = new System.Drawing.Size(148, 475);
            this.tvtbQueryList_User.TabIndex = 2;
            this.tvtbQueryList_User.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvtbQueryList_User_AfterSelect);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pnlQueryCondition);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(157, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 476);
            this.panel3.TabIndex = 0;
            // 
            // pnlQueryCondition
            // 
            this.pnlQueryCondition.AutoSize = true;
            this.pnlQueryCondition.Controls.Add(this.tableLayoutpnlQueryCondition);
            this.pnlQueryCondition.Location = new System.Drawing.Point(3, 0);
            this.pnlQueryCondition.Name = "pnlQueryCondition";
            this.pnlQueryCondition.Size = new System.Drawing.Size(228, 42);
            this.pnlQueryCondition.TabIndex = 5;
            // 
            // tableLayoutpnlQueryCondition
            // 
            this.tableLayoutpnlQueryCondition.ColumnCount = 2;
            this.tableLayoutpnlQueryCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutpnlQueryCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutpnlQueryCondition.Controls.Add(this.btnExportData, 0, 0);
            this.tableLayoutpnlQueryCondition.Controls.Add(this.btnQuery, 0, 0);
            this.tableLayoutpnlQueryCondition.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutpnlQueryCondition.Location = new System.Drawing.Point(0, 14);
            this.tableLayoutpnlQueryCondition.Name = "tableLayoutpnlQueryCondition";
            this.tableLayoutpnlQueryCondition.RowCount = 1;
            this.tableLayoutpnlQueryCondition.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutpnlQueryCondition.Size = new System.Drawing.Size(228, 28);
            this.tableLayoutpnlQueryCondition.TabIndex = 4;
            this.tableLayoutpnlQueryCondition.Visible = false;
            // 
            // btnExportData
            // 
            this.btnExportData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportData.Enabled = false;
            this.btnExportData.Location = new System.Drawing.Point(137, 3);
            this.btnExportData.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.btnExportData.Name = "btnExportData";
            this.btnExportData.Size = new System.Drawing.Size(75, 23);
            this.btnExportData.TabIndex = 1;
            this.btnExportData.Text = "导出数据";
            this.btnExportData.UseVisualStyleBackColor = true;
            this.btnExportData.Click += new System.EventHandler(this.btnExportData_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuery.Location = new System.Drawing.Point(23, 3);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 3, 16, 3);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(397, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(442, 476);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(434, 450);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "查询结果";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FrmDataQuery
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(842, 482);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "FrmDataQuery";
            this.TabText = "数据查询";
            this.Text = "数据查询";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnlQueryCondition.ResumeLayout(false);
            this.tableLayoutpnlQueryCondition.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private PsapUserControlLibrary.TreeViewToolBoxEx tvtbQueryList_User;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlQueryCondition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutpnlQueryCondition;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnExportData;
    }
}