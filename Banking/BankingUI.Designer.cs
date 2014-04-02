using System;
namespace Banking
{
    partial class BankingUI
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
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.cbAccount = new System.Windows.Forms.ComboBox();
            this.gbTransaction = new System.Windows.Forms.GroupBox();
            this.tbOrderOf = new System.Windows.Forms.TextBox();
            this.chCheck = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.lblFromAccount = new System.Windows.Forms.Label();
            this.lblToAccount = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.cbTransaction = new System.Windows.Forms.ComboBox();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilePath = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAccount.SuspendLayout();
            this.gbTransaction.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(6, 37);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(47, 13);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Account";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(6, 72);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 2;
            this.lblBalance.Text = "Balance:";
            this.lblBalance.Click += new System.EventHandler(this.lblBalance_Click);
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Location = new System.Drawing.Point(61, 72);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(104, 13);
            this.lblBalanceAmount.TabIndex = 3;
            this.lblBalanceAmount.Text = "no account selected";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(30, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Today\'s date is ";
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.cbAccount);
            this.gbAccount.Controls.Add(this.lblBalanceAmount);
            this.gbAccount.Controls.Add(this.lblAccount);
            this.gbAccount.Controls.Add(this.lblBalance);
            this.gbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccount.Location = new System.Drawing.Point(33, 51);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(200, 100);
            this.gbAccount.TabIndex = 5;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Choose an account";
            // 
            // cbAccount
            // 
            this.cbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Location = new System.Drawing.Point(58, 34);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(121, 21);
            this.cbAccount.TabIndex = 4;
            this.cbAccount.SelectedIndexChanged += new System.EventHandler(this.cbAccount_SelectedIndexChanged);
            // 
            // gbTransaction
            // 
            this.gbTransaction.Controls.Add(this.tbOrderOf);
            this.gbTransaction.Controls.Add(this.chCheck);
            this.gbTransaction.Controls.Add(this.btnClear);
            this.gbTransaction.Controls.Add(this.btnAddTransaction);
            this.gbTransaction.Controls.Add(this.lblFromAccount);
            this.gbTransaction.Controls.Add(this.lblToAccount);
            this.gbTransaction.Controls.Add(this.lblAmount);
            this.gbTransaction.Controls.Add(this.tbAmount);
            this.gbTransaction.Controls.Add(this.cbTransaction);
            this.gbTransaction.Location = new System.Drawing.Point(33, 169);
            this.gbTransaction.Name = "gbTransaction";
            this.gbTransaction.Size = new System.Drawing.Size(200, 220);
            this.gbTransaction.TabIndex = 6;
            this.gbTransaction.TabStop = false;
            this.gbTransaction.Text = "Make a transaction";
            // 
            // tbOrderOf
            // 
            this.tbOrderOf.Location = new System.Drawing.Point(6, 160);
            this.tbOrderOf.Name = "tbOrderOf";
            this.tbOrderOf.Size = new System.Drawing.Size(160, 20);
            this.tbOrderOf.TabIndex = 8;
            this.tbOrderOf.Visible = false;
            // 
            // chCheck
            // 
            this.chCheck.AutoSize = true;
            this.chCheck.Location = new System.Drawing.Point(7, 137);
            this.chCheck.Name = "chCheck";
            this.chCheck.Size = new System.Drawing.Size(78, 17);
            this.chCheck.TabIndex = 7;
            this.chCheck.Text = "sign check";
            this.chCheck.UseVisualStyleBackColor = true;
            this.chCheck.Visible = false;
            this.chCheck.CheckedChanged += new System.EventHandler(this.chCheck_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(91, 191);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(10, 191);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnAddTransaction.TabIndex = 5;
            this.btnAddTransaction.Text = "Confirm";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // lblFromAccount
            // 
            this.lblFromAccount.AutoSize = true;
            this.lblFromAccount.Location = new System.Drawing.Point(6, 120);
            this.lblFromAccount.Name = "lblFromAccount";
            this.lblFromAccount.Size = new System.Drawing.Size(33, 13);
            this.lblFromAccount.TabIndex = 4;
            this.lblFromAccount.Text = "From:";
            // 
            // lblToAccount
            // 
            this.lblToAccount.AutoSize = true;
            this.lblToAccount.Location = new System.Drawing.Point(6, 107);
            this.lblToAccount.Name = "lblToAccount";
            this.lblToAccount.Size = new System.Drawing.Size(23, 13);
            this.lblToAccount.TabIndex = 3;
            this.lblToAccount.Text = "To:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 85);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount:";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(58, 78);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(72, 20);
            this.tbAmount.TabIndex = 1;
            // 
            // cbTransaction
            // 
            this.cbTransaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTransaction.FormattingEnabled = true;
            this.cbTransaction.Location = new System.Drawing.Point(9, 40);
            this.cbTransaction.Name = "cbTransaction";
            this.cbTransaction.Size = new System.Drawing.Size(121, 21);
            this.cbTransaction.TabIndex = 0;
            this.cbTransaction.SelectedIndexChanged += new System.EventHandler(this.cbTransaction_SelectedIndexChanged);
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(265, 34);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(616, 355);
            this.lbHistory.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFilePath,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            // 
            // mnuFilePath
            // 
            this.mnuFilePath.Name = "mnuFilePath";
            this.mnuFilePath.Size = new System.Drawing.Size(205, 22);
            this.mnuFilePath.Text = "Choose save file location";
            this.mnuFilePath.Click += new System.EventHandler(this.mnuFilePath_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(205, 22);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // BankingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 405);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.gbTransaction);
            this.Controls.Add(this.gbAccount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BankingUI";
            this.Text = "Banking";
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.gbTransaction.ResumeLayout(false);
            this.gbTransaction.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox gbAccount;
        private System.Windows.Forms.GroupBox gbTransaction;
        private System.Windows.Forms.ComboBox cbTransaction;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lblFromAccount;
        private System.Windows.Forms.Label lblToAccount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddTransaction;
        private System.Windows.Forms.ListBox lbHistory;
        private System.Windows.Forms.ComboBox cbAccount;
        private System.Windows.Forms.TextBox tbOrderOf;
        private System.Windows.Forms.CheckBox chCheck;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFilePath;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
    }
}

