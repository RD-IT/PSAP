namespace PSAP.VIEW.BSVIEW
{
    partial class FrmChangePassword
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
            this.panel1 = new DevExpress.XtraEditors.PanelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtPasswordNewV = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPasswordNew = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserID = new DevExpress.XtraEditors.TextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.btnConfirm = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordNewV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPasswordNewV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPasswordNew);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Location = new System.Drawing.Point(43, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 200);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(4, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "验证新密码";
            // 
            // txtPasswordNewV
            // 
            this.txtPasswordNewV.Location = new System.Drawing.Point(72, 125);
            this.txtPasswordNewV.Name = "txtPasswordNewV";
            this.txtPasswordNewV.Properties.PasswordChar = '*';
            this.txtPasswordNewV.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordNewV.TabIndex = 3;
            this.txtPasswordNewV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasswordNewV_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(29, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "新密码";
            // 
            // txtPasswordNew
            // 
            this.txtPasswordNew.Location = new System.Drawing.Point(72, 92);
            this.txtPasswordNew.Name = "txtPasswordNew";
            this.txtPasswordNew.Properties.PasswordChar = '*';
            this.txtPasswordNew.Size = new System.Drawing.Size(100, 20);
            this.txtPasswordNew.TabIndex = 2;
            this.txtPasswordNew.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPasswordNew_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户ID";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(28, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "原密码";
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(72, 26);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(100, 20);
            this.txtUserID.TabIndex = 0;
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(110, 170);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(72, 59);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(4, 170);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 278);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改密码";
            ((System.ComponentModel.ISupportInitialize)(this.panel1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordNewV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPasswordNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel1;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtUserID;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.SimpleButton btnConfirm;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.TextEdit txtPasswordNewV;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.TextEdit txtPasswordNew;
    }
}