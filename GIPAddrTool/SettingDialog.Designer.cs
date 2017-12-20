namespace GIPAddrTool
{
    partial class SettingDialog
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.proxyIPAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.portNumber = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.settingSaveBtn = new System.Windows.Forms.Button();
            this.settingCancelBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 67);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.proxyIPAddress);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.portNumber);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(406, 22);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 6, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "プロキシサーバIP";
            // 
            // proxyIPAddress
            // 
            this.proxyIPAddress.Location = new System.Drawing.Point(89, 2);
            this.proxyIPAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.proxyIPAddress.Name = "proxyIPAddress";
            this.proxyIPAddress.Size = new System.Drawing.Size(155, 19);
            this.proxyIPAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 6, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ポート番号";
            // 
            // portNumber
            // 
            this.portNumber.Location = new System.Drawing.Point(309, 2);
            this.portNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.portNumber.Name = "portNumber";
            this.portNumber.Size = new System.Drawing.Size(67, 19);
            this.portNumber.TabIndex = 1;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.settingSaveBtn);
            this.flowLayoutPanel3.Controls.Add(this.settingCancelBtn);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(254, 36);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(154, 29);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // settingSaveBtn
            // 
            this.settingSaveBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.settingSaveBtn.Location = new System.Drawing.Point(2, 2);
            this.settingSaveBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingSaveBtn.Name = "settingSaveBtn";
            this.settingSaveBtn.Size = new System.Drawing.Size(56, 22);
            this.settingSaveBtn.TabIndex = 0;
            this.settingSaveBtn.Text = "OK";
            this.settingSaveBtn.UseVisualStyleBackColor = true;
            this.settingSaveBtn.Click += new System.EventHandler(this.settingSaveBtn_Click);
            // 
            // settingCancelBtn
            // 
            this.settingCancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.settingCancelBtn.Location = new System.Drawing.Point(62, 2);
            this.settingCancelBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.settingCancelBtn.Name = "settingCancelBtn";
            this.settingCancelBtn.Size = new System.Drawing.Size(67, 22);
            this.settingCancelBtn.TabIndex = 1;
            this.settingCancelBtn.Text = "キャンセル";
            this.settingCancelBtn.UseVisualStyleBackColor = true;
            // 
            // SettingDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 77);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingDialog";
            this.Text = "設定";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button settingSaveBtn;
        private System.Windows.Forms.Button settingCancelBtn;
        private System.Windows.Forms.TextBox proxyIPAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portNumber;
    }
}