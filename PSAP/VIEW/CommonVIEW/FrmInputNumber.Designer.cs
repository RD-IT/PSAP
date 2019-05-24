namespace PSAP.VIEW.BSVIEW
{
    partial class FrmInputNumber
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
            this.spinNumber = new DevExpress.XtraEditors.SpinEdit();
            this.labNumber = new DevExpress.XtraEditors.LabelControl();
            this.pnlBottom = new DevExpress.XtraEditors.PanelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnConfirm = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.spinNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).BeginInit();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spinNumber
            // 
            this.spinNumber.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinNumber.EnterMoveNextControl = true;
            this.spinNumber.Location = new System.Drawing.Point(132, 67);
            this.spinNumber.Name = "spinNumber";
            this.spinNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinNumber.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNumber.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinNumber.Size = new System.Drawing.Size(150, 20);
            this.spinNumber.TabIndex = 0;
            // 
            // labNumber
            // 
            this.labNumber.Location = new System.Drawing.Point(65, 70);
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(48, 14);
            this.labNumber.TabIndex = 5;
            this.labNumber.Text = "增加数量";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.BtnConfirm);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 165);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(344, 36);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(255, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "取消";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnConfirm.Location = new System.Drawing.Point(174, 7);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(75, 23);
            this.BtnConfirm.TabIndex = 1;
            this.BtnConfirm.Text = "确定";
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.spinNumber);
            this.panelControl1.Controls.Add(this.labNumber);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(344, 165);
            this.panelControl1.TabIndex = 0;
            // 
            // FrmInputNumber
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.pnlBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInputNumber";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabText = "输入数量";
            this.Text = "输入数量";
            ((System.ComponentModel.ISupportInitialize)(this.spinNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBottom)).EndInit();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit spinNumber;
        private DevExpress.XtraEditors.LabelControl labNumber;
        private DevExpress.XtraEditors.PanelControl pnlBottom;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton BtnConfirm;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}