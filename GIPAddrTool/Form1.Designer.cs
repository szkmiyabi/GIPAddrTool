namespace GIPAddrTool
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.getGIPAddrBtn = new System.Windows.Forms.Button();
            this.GIPAddrTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.proxyBtn = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.getGIPAddrBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GIPAddrTxt, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(509, 42);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // getGIPAddrBtn
            // 
            this.getGIPAddrBtn.Location = new System.Drawing.Point(3, 3);
            this.getGIPAddrBtn.Name = "getGIPAddrBtn";
            this.getGIPAddrBtn.Size = new System.Drawing.Size(117, 27);
            this.getGIPAddrBtn.TabIndex = 0;
            this.getGIPAddrBtn.Text = "IPアドレス調査";
            this.getGIPAddrBtn.UseVisualStyleBackColor = true;
            this.getGIPAddrBtn.Click += new System.EventHandler(this.getGIPAddrBtn_Click);
            // 
            // GIPAddrTxt
            // 
            this.GIPAddrTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GIPAddrTxt.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GIPAddrTxt.Location = new System.Drawing.Point(128, 3);
            this.GIPAddrTxt.Name = "GIPAddrTxt";
            this.GIPAddrTxt.Size = new System.Drawing.Size(378, 27);
            this.GIPAddrTxt.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.proxyBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 58);
            this.panel1.TabIndex = 2;
            // 
            // proxyBtn
            // 
            this.proxyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.proxyBtn.Location = new System.Drawing.Point(207, 23);
            this.proxyBtn.Name = "proxyBtn";
            this.proxyBtn.Size = new System.Drawing.Size(107, 23);
            this.proxyBtn.TabIndex = 3;
            this.proxyBtn.Text = "プロキシ設定";
            this.proxyBtn.UseVisualStyleBackColor = true;
            this.proxyBtn.Click += new System.EventHandler(this.proxyBtn_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 27);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 15);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "IPアドレス確認君";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 100);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "GlobalIPアドレスツール";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button getGIPAddrBtn;
        private System.Windows.Forms.TextBox GIPAddrTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button proxyBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

