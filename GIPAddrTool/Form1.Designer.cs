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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.getGIPAddrBtn = new System.Windows.Forms.Button();
            this.GIPAddrTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.proxyBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuInSettingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.getGIPAddrBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GIPAddrTxt, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 34);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // getGIPAddrBtn
            // 
            this.getGIPAddrBtn.Location = new System.Drawing.Point(2, 2);
            this.getGIPAddrBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getGIPAddrBtn.Name = "getGIPAddrBtn";
            this.getGIPAddrBtn.Size = new System.Drawing.Size(88, 22);
            this.getGIPAddrBtn.TabIndex = 0;
            this.getGIPAddrBtn.Text = "IPアドレス調査";
            this.getGIPAddrBtn.UseVisualStyleBackColor = true;
            this.getGIPAddrBtn.Click += new System.EventHandler(this.getGIPAddrBtn_Click);
            // 
            // GIPAddrTxt
            // 
            this.GIPAddrTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GIPAddrTxt.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GIPAddrTxt.Location = new System.Drawing.Point(96, 2);
            this.GIPAddrTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GIPAddrTxt.Name = "GIPAddrTxt";
            this.GIPAddrTxt.Size = new System.Drawing.Size(315, 23);
            this.GIPAddrTxt.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.proxyBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 58);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 53);
            this.panel1.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(9, 22);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 12);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "IPアドレス確認君";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // proxyBtn
            // 
            this.proxyBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.proxyBtn.Location = new System.Drawing.Point(170, 25);
            this.proxyBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.proxyBtn.Name = "proxyBtn";
            this.proxyBtn.Size = new System.Drawing.Size(80, 22);
            this.proxyBtn.TabIndex = 3;
            this.proxyBtn.Text = "プロキシ設定";
            this.proxyBtn.UseVisualStyleBackColor = true;
            this.proxyBtn.Click += new System.EventHandler(this.proxyBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuInSettingItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(53, 20);
            this.FileMenuItem.Text = "ファイル";
            // 
            // FileMenuInSettingItem
            // 
            this.FileMenuInSettingItem.Name = "FileMenuInSettingItem";
            this.FileMenuInSettingItem.Size = new System.Drawing.Size(98, 22);
            this.FileMenuInSettingItem.Text = "設定";
            this.FileMenuInSettingItem.Click += new System.EventHandler(this.FileMenuInSettingItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 111);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "GlobalIPアドレスツール";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button getGIPAddrBtn;
        private System.Windows.Forms.TextBox GIPAddrTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button proxyBtn;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileMenuInSettingItem;
    }
}

