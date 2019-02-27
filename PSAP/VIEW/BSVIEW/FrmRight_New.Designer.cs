namespace PSAP.VIEW.BSVIEW
{
    partial class FrmRight_New
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
            this.TabControlUserPower = new DevExpress.XtraTab.XtraTabControl();
            this.PageUserMenuButton = new DevExpress.XtraTab.XtraTabPage();
            this.PageMenuManagement = new DevExpress.XtraTab.XtraTabPage();
            this.PageRole = new DevExpress.XtraTab.XtraTabPage();
            this.pnlUser = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.TabControlUserPower)).BeginInit();
            this.TabControlUserPower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlUser)).BeginInit();
            this.pnlUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlUserPower
            // 
            this.TabControlUserPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlUserPower.Location = new System.Drawing.Point(2, 2);
            this.TabControlUserPower.Name = "TabControlUserPower";
            this.TabControlUserPower.SelectedTabPage = this.PageUserMenuButton;
            this.TabControlUserPower.Size = new System.Drawing.Size(1050, 562);
            this.TabControlUserPower.TabIndex = 0;
            this.TabControlUserPower.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.PageUserMenuButton,
            this.PageMenuManagement,
            this.PageRole});
            this.TabControlUserPower.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.TabControlUserPower_SelectedPageChanged);
            // 
            // PageUserMenuButton
            // 
            this.PageUserMenuButton.Name = "PageUserMenuButton";
            this.PageUserMenuButton.Size = new System.Drawing.Size(1044, 533);
            this.PageUserMenuButton.Text = "用户权限管理";
            // 
            // PageMenuManagement
            // 
            this.PageMenuManagement.Name = "PageMenuManagement";
            this.PageMenuManagement.Size = new System.Drawing.Size(1044, 533);
            this.PageMenuManagement.Text = "主菜单管理";
            // 
            // PageRole
            // 
            this.PageRole.Name = "PageRole";
            this.PageRole.Size = new System.Drawing.Size(1044, 533);
            this.PageRole.Text = "角色权限管理";
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.TabControlUserPower);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(1054, 566);
            this.pnlUser.TabIndex = 1;
            // 
            // FrmRight_New
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1054, 566);
            this.Controls.Add(this.pnlUser);
            this.Name = "FrmRight_New";
            this.TabText = "用户权限";
            this.Text = "用户权限";
            this.Load += new System.EventHandler(this.FrmRight_New_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabControlUserPower)).EndInit();
            this.TabControlUserPower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlUser)).EndInit();
            this.pnlUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl TabControlUserPower;
        private DevExpress.XtraTab.XtraTabPage PageUserMenuButton;
        private DevExpress.XtraTab.XtraTabPage PageMenuManagement;
        private DevExpress.XtraTab.XtraTabPage PageRole;
        private DevExpress.XtraEditors.PanelControl pnlUser;
    }
}