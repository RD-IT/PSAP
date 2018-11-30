namespace PSAP.VIEW.BSVIEW
{
    partial class GridBottom
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCtlBottom = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxPageNo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnEnd = new DevExpress.XtraEditors.SimpleButton();
            this.btnRight = new DevExpress.XtraEditors.SimpleButton();
            this.btnFirst = new DevExpress.XtraEditors.SimpleButton();
            this.btnLeft = new DevExpress.XtraEditors.SimpleButton();
            this.lMemo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtlBottom)).BeginInit();
            this.pnlCtlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPageNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCtlBottom
            // 
            this.pnlCtlBottom.Controls.Add(this.comboBoxPageNo);
            this.pnlCtlBottom.Controls.Add(this.btnEnd);
            this.pnlCtlBottom.Controls.Add(this.btnRight);
            this.pnlCtlBottom.Controls.Add(this.btnFirst);
            this.pnlCtlBottom.Controls.Add(this.btnLeft);
            this.pnlCtlBottom.Controls.Add(this.lMemo);
            this.pnlCtlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCtlBottom.Location = new System.Drawing.Point(0, 0);
            this.pnlCtlBottom.LookAndFeel.UseDefaultLookAndFeel = false;
            this.pnlCtlBottom.LookAndFeel.UseWindowsXPTheme = true;
            this.pnlCtlBottom.Name = "pnlCtlBottom";
            this.pnlCtlBottom.Size = new System.Drawing.Size(721, 46);
            this.pnlCtlBottom.TabIndex = 26;
            // 
            // comboBoxPageNo
            // 
            this.comboBoxPageNo.Location = new System.Drawing.Point(461, 13);
            this.comboBoxPageNo.Name = "comboBoxPageNo";
            this.comboBoxPageNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxPageNo.Properties.Items.AddRange(new object[] {
            "1"});
            this.comboBoxPageNo.Size = new System.Drawing.Size(58, 20);
            this.comboBoxPageNo.TabIndex = 6;
            this.comboBoxPageNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxPageNo_SelectedIndexChanged);
            // 
            // btnEnd
            // 
            this.btnEnd.Enabled = false;
            this.btnEnd.Location = new System.Drawing.Point(563, 12);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(26, 23);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.Text = ">|";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnRight
            // 
            this.btnRight.Enabled = false;
            this.btnRight.Location = new System.Drawing.Point(531, 12);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(26, 23);
            this.btnRight.TabIndex = 4;
            this.btnRight.Text = ">";
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Enabled = false;
            this.btnFirst.Location = new System.Drawing.Point(391, 12);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(26, 23);
            this.btnFirst.TabIndex = 3;
            this.btnFirst.Text = "|<";
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Enabled = false;
            this.btnLeft.Location = new System.Drawing.Point(423, 12);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(26, 23);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "<";
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // lMemo
            // 
            this.lMemo.AutoSize = true;
            this.lMemo.Location = new System.Drawing.Point(27, 17);
            this.lMemo.Name = "lMemo";
            this.lMemo.Size = new System.Drawing.Size(74, 14);
            this.lMemo.TabIndex = 0;
            this.lMemo.Text = "共计0条记录";
            // 
            // GridBottom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlCtlBottom);
            this.Name = "GridBottom";
            this.Size = new System.Drawing.Size(721, 46);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCtlBottom)).EndInit();
            this.pnlCtlBottom.ResumeLayout(false);
            this.pnlCtlBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxPageNo.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlCtlBottom;
        private System.Windows.Forms.Label lMemo;
        private DevExpress.XtraEditors.SimpleButton btnEnd;
        private DevExpress.XtraEditors.SimpleButton btnRight;
        private DevExpress.XtraEditors.SimpleButton btnFirst;
        private DevExpress.XtraEditors.SimpleButton btnLeft;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxPageNo;
    }
}
