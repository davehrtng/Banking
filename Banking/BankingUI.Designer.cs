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
            this.cbAccount = new System.Windows.Forms.ComboBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.gbAccount = new System.Windows.Forms.GroupBox();
            this.gbTransaction = new System.Windows.Forms.GroupBox();
            this.cbTransaction = new System.Windows.Forms.ComboBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblToAccount = new System.Windows.Forms.Label();
            this.lblFromAccount = new System.Windows.Forms.Label();
            this.btnAddTransaction = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.gbAccount.SuspendLayout();
            this.gbTransaction.SuspendLayout();
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
            // cbAccount
            // 
            this.cbAccount.FormattingEnabled = true;
            this.cbAccount.Items.AddRange(new object[] {
            "Checking",
            "Savings"});
            this.cbAccount.Location = new System.Drawing.Point(59, 34);
            this.cbAccount.Name = "cbAccount";
            this.cbAccount.Size = new System.Drawing.Size(121, 21);
            this.cbAccount.TabIndex = 1;
            this.cbAccount.Text = "Pick an account";
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
            this.lblDate.Location = new System.Drawing.Point(30, 26);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(81, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Today\'s date is ";
            // 
            // gbAccount
            // 
            this.gbAccount.Controls.Add(this.lblBalanceAmount);
            this.gbAccount.Controls.Add(this.lblAccount);
            this.gbAccount.Controls.Add(this.lblBalance);
            this.gbAccount.Controls.Add(this.cbAccount);
            this.gbAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAccount.Location = new System.Drawing.Point(33, 51);
            this.gbAccount.Name = "gbAccount";
            this.gbAccount.Size = new System.Drawing.Size(200, 100);
            this.gbAccount.TabIndex = 5;
            this.gbAccount.TabStop = false;
            this.gbAccount.Text = "Choose an account";
            // 
            // gbTransaction
            // 
            this.gbTransaction.Controls.Add(this.btnClear);
            this.gbTransaction.Controls.Add(this.btnAddTransaction);
            this.gbTransaction.Controls.Add(this.lblFromAccount);
            this.gbTransaction.Controls.Add(this.lblToAccount);
            this.gbTransaction.Controls.Add(this.lblAmount);
            this.gbTransaction.Controls.Add(this.tbAmount);
            this.gbTransaction.Controls.Add(this.cbTransaction);
            this.gbTransaction.Location = new System.Drawing.Point(33, 169);
            this.gbTransaction.Name = "gbTransaction";
            this.gbTransaction.Size = new System.Drawing.Size(200, 200);
            this.gbTransaction.TabIndex = 6;
            this.gbTransaction.TabStop = false;
            this.gbTransaction.Text = "Make a transaction";
            // 
            // cbTransaction
            // 
            this.cbTransaction.FormattingEnabled = true;
            this.cbTransaction.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw",
            "Transfer"});
            this.cbTransaction.Location = new System.Drawing.Point(9, 40);
            this.cbTransaction.Name = "cbTransaction";
            this.cbTransaction.Size = new System.Drawing.Size(121, 21);
            this.cbTransaction.TabIndex = 0;
            this.cbTransaction.Text = "Pick a transaction";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(58, 78);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(72, 20);
            this.tbAmount.TabIndex = 1;
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
            // lblToAccount
            // 
            this.lblToAccount.AutoSize = true;
            this.lblToAccount.Location = new System.Drawing.Point(6, 126);
            this.lblToAccount.Name = "lblToAccount";
            this.lblToAccount.Size = new System.Drawing.Size(23, 13);
            this.lblToAccount.TabIndex = 3;
            this.lblToAccount.Text = "To:";
            // 
            // lblFromAccount
            // 
            this.lblFromAccount.AutoSize = true;
            this.lblFromAccount.Location = new System.Drawing.Point(6, 139);
            this.lblFromAccount.Name = "lblFromAccount";
            this.lblFromAccount.Size = new System.Drawing.Size(33, 13);
            this.lblFromAccount.TabIndex = 4;
            this.lblFromAccount.Text = "From:";
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Location = new System.Drawing.Point(9, 171);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Size = new System.Drawing.Size(75, 23);
            this.btnAddTransaction.TabIndex = 5;
            this.btnAddTransaction.Text = "Confirm";
            this.btnAddTransaction.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(91, 171);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.Location = new System.Drawing.Point(265, 34);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(616, 329);
            this.lbHistory.TabIndex = 7;
            // 
            // BankingUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 397);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.gbTransaction);
            this.Controls.Add(this.gbAccount);
            this.Name = "BankingUI";
            this.Text = "Banking";
            this.gbAccount.ResumeLayout(false);
            this.gbAccount.PerformLayout();
            this.gbTransaction.ResumeLayout(false);
            this.gbTransaction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.ComboBox cbAccount;
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
    }
}

