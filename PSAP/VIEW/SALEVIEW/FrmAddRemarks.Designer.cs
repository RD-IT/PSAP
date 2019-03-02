namespace PSAP.VIEW.BSVIEW
{
    partial class FrmAddRemarks
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
            this.txtRemarks = new DevExpress.XtraEditors.MemoEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.cms = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiBznr = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTs = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).BeginInit();
            this.cms.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(0, 1);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Properties.MaxLength = 500;
            this.txtRemarks.Size = new System.Drawing.Size(638, 144);
            this.txtRemarks.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(275, 167);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(383, 167);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cms
            // 
            this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBznr,
            this.tsmiTs});
            this.cms.Name = "cms1";
            this.cms.Size = new System.Drawing.Size(185, 70);
            // 
            // tsmiBznr
            // 
            this.tsmiBznr.Name = "tsmiBznr";
            this.tsmiBznr.Size = new System.Drawing.Size(184, 22);
            this.tsmiBznr.Text = "备注内容不能为空！";
            // 
            // tsmiTs
            // 
            this.tsmiTs.Name = "tsmiTs";
            this.tsmiTs.Size = new System.Drawing.Size(184, 22);
            this.tsmiTs.Text = "提示";
            // 
            // FrmAddRemarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 202);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtRemarks);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.Name = "FrmAddRemarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加备注信息";
            ((System.ComponentModel.ISupportInitialize)(this.txtRemarks.Properties)).EndInit();
            this.cms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.MemoEdit txtRemarks;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.ContextMenuStrip cms;
        private System.Windows.Forms.ToolStripMenuItem tsmiBznr;
        private System.Windows.Forms.ToolStripMenuItem tsmiTs;
    }
}