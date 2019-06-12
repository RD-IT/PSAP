namespace PSAP.VIEW.BSVIEW
{
    partial class FrmSystemSet
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
            this.xtraTabSystem = new DevExpress.XtraTab.XtraTabControl();
            this.PageDBManage = new DevExpress.XtraTab.XtraTabPage();
            this.progressBarBackup = new System.Windows.Forms.ProgressBar();
            this.textBackupPath = new DevExpress.XtraEditors.TextEdit();
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.labBackupPath = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabSystem)).BeginInit();
            this.xtraTabSystem.SuspendLayout();
            this.PageDBManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBackupPath.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabSystem
            // 
            this.xtraTabSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabSystem.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Left;
            this.xtraTabSystem.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.xtraTabSystem.Location = new System.Drawing.Point(0, 0);
            this.xtraTabSystem.Name = "xtraTabSystem";
            this.xtraTabSystem.SelectedTabPage = this.PageDBManage;
            this.xtraTabSystem.Size = new System.Drawing.Size(1123, 622);
            this.xtraTabSystem.TabIndex = 0;
            this.xtraTabSystem.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageDBManage});
            // 
            // PageDBManage
            // 
            this.PageDBManage.Controls.Add(this.progressBarBackup);
            this.PageDBManage.Controls.Add(this.textBackupPath);
            this.PageDBManage.Controls.Add(this.btnBackup);
            this.PageDBManage.Controls.Add(this.labBackupPath);
            this.PageDBManage.Name = "PageDBManage";
            this.PageDBManage.Size = new System.Drawing.Size(1067, 616);
            this.PageDBManage.Text = "数据库";
            // 
            // progressBarBackup
            // 
            this.progressBarBackup.Location = new System.Drawing.Point(54, 78);
            this.progressBarBackup.Name = "progressBarBackup";
            this.progressBarBackup.Size = new System.Drawing.Size(500, 23);
            this.progressBarBackup.TabIndex = 2;
            // 
            // textBackupPath
            // 
            this.textBackupPath.EditValue = "D:\\";
            this.textBackupPath.Location = new System.Drawing.Point(156, 34);
            this.textBackupPath.Name = "textBackupPath";
            this.textBackupPath.Size = new System.Drawing.Size(300, 20);
            this.textBackupPath.TabIndex = 0;
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(483, 33);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 1;
            this.btnBackup.Text = "备份";
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // labBackupPath
            // 
            this.labBackupPath.Location = new System.Drawing.Point(54, 37);
            this.labBackupPath.Name = "labBackupPath";
            this.labBackupPath.Size = new System.Drawing.Size(96, 14);
            this.labBackupPath.TabIndex = 0;
            this.labBackupPath.Text = "数据库备份路径：";
            // 
            // FrmSystemSet
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1123, 622);
            this.Controls.Add(this.xtraTabSystem);
            this.Name = "FrmSystemSet";
            this.TabText = "系统设定";
            this.Text = "系统设定";
            this.Load += new System.EventHandler(this.FrmSystemSet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabSystem)).EndInit();
            this.xtraTabSystem.ResumeLayout(false);
            this.PageDBManage.ResumeLayout(false);
            this.PageDBManage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBackupPath.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabSystem;
        private DevExpress.XtraTab.XtraTabPage PageDBManage;
        private DevExpress.XtraEditors.TextEdit textBackupPath;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private DevExpress.XtraEditors.LabelControl labBackupPath;
        private System.Windows.Forms.ProgressBar progressBarBackup;
    }
}