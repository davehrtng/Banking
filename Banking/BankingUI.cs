using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking
{
    public partial class BankingUI : Form
    {
        public BankingUI()
        {
            InitializeComponent();
            // add dropdown items to combo boxes
            cbAccount.Items.Add(new AccountDropDownItem("Checking", "Checking", AccountType.checking));
            cbAccount.Items.Add(new AccountDropDownItem("Savings", "Savings", AccountType.savings));
            cbTransaction.Items.Add(new DropDownItem("Deposit", "Deposit"));
            cbTransaction.Items.Add(new DropDownItem("Withdrawal", "Withdrawal"));
            cbTransaction.Items.Add(new DropDownItem("Transfer", "Transfer"));
        }

        private void lbHistory_Update(AccountManager objAcctMan, AccountType acctType)
        {
            IList<Transaction> history = new List<Transaction>();
            history = objAcctMan.GetTransactions(acctType); 
            lbHistory.Items.Clear();
            foreach (Transaction trans in history)
            {
                lbHistory.Items.Add(trans.toCSV());
            }
            lblBalanceAmount.Text = Convert.ToString(objAcctMan.Balance(acctType));
        }

        private void clear_transaction()
        {
            cbTransaction.SelectedItem = null;
            tbAmount.Text = "";
            tbOrderOf.Text = "Pay to the order of";
            chCheck.Checked = false;
            chCheck.Visible = false;
            tbOrderOf.Visible = false; 
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void cbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            AccountDropDownItem item = (AccountDropDownItem)cbAccount.SelectedItem;
            AccountManager objAcctManager = new AccountManager();
            IList<Transaction> history = new List<Transaction>();
            lbHistory_Update(objAcctManager, item.AccountType);
        }

        private void cbTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccount.SelectedItem != null && cbTransaction.SelectedItem != null)
            {
                DropDownItem item = (DropDownItem)cbTransaction.SelectedItem;
                String selectedAccount = ((AccountDropDownItem)cbAccount.SelectedItem).ToString();
                lblFromAccount.Text = "From:\t";
                lblToAccount.Text = "To:\t";
                String otherAccount = "-";
                chCheck.Visible = false;
                tbOrderOf.Visible = false;
                tbOrderOf.Text = "Pay to the order of"; 
                if (item.Value.Equals("Deposit"))
                {
                    lblFromAccount.Text += otherAccount;
                    lblToAccount.Text += selectedAccount;
                    chCheck.Visible = true; 
                }
                else if (item.Value.Equals("Withdrawal"))
                {
                    lblFromAccount.Text += selectedAccount;
                    lblToAccount.Text += otherAccount;
                }
                else if (item.Value.Equals("Transfer"))
                {
                    lblFromAccount.Text += selectedAccount;
                    if (selectedAccount.Equals("Checking")) { otherAccount = "Savings"; }
                    else { otherAccount = "Checking"; }
                    lblToAccount.Text += otherAccount;
                }
                else
                {
                    lblFromAccount.Text = "From:\t";
                    lblToAccount.Text = "To:\t"; 
                }
            }
            else
            {
                lblFromAccount.Text = "From:\t";
                lblToAccount.Text = "To:\t"; 
            }
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            String transaction = ((DropDownItem)cbTransaction.SelectedItem).Value; 
            if (transaction != null)
            {
                AccountManager objAcctManager = new AccountManager();
                AccountType selectedAccountType = ((AccountDropDownItem)cbAccount.SelectedItem).AccountType;
                objAcctManager.GetTransactions(selectedAccountType); 
                decimal amount;
                try
                {
                    amount = Convert.ToDecimal(tbAmount.Text);
                    if (transaction == "Deposit")
                    {
                        if (chCheck.Checked)
                        {
                            objAcctManager.SignCheck(selectedAccountType, amount, tbOrderOf.Text); 
                        }
                        else
                        {
                            objAcctManager.Deposit(selectedAccountType, amount);
                        }
                    }
                    else if (transaction == "Withdrawal")
                    {
                        if (!objAcctManager.Withdraw(selectedAccountType, amount))
                        {
                            MessageBox.Show("Insufficient funds in " + selectedAccountType + " account to make withdrawal");
                        }
                    }
                    else if (transaction == "Transfer")
                    {
                        if (!objAcctManager.Transfer(selectedAccountType, selectedAccountType.otherAccount(), amount))
                        {
                            MessageBox.Show("Insufficient funds in " + selectedAccountType + " account to make withdrawal");
                        }
                    }
                    clear_transaction(); 
                }
                catch
                {
                    MessageBox.Show("Invalid AmountType");
                }
                lbHistory_Update(objAcctManager, selectedAccountType); 
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear_transaction(); 
        }

        private void chCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chCheck.Checked) { tbOrderOf.Visible = true; }
            else { tbOrderOf.Visible = false; } 
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void mnuFilePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Repository.Path = dialog.SelectedPath;
                MessageBox.Show("Make sure you have a files named \"Savings.txt\" and \"Checking.txt\" in the selected folder."); 
            }
        }

        
    }

    /*
     * Helper classes for the UI  
     */
    public class DropDownItem
    {
        protected String name;
        protected String value;
        public DropDownItem() { }
        public DropDownItem(String nm, String val)
        {
            name = nm;
            value = val;
        }
        public String Value
        {
            get { return value; }
        }
        public override String ToString() { return value; }
    }
    public class AccountDropDownItem : DropDownItem
    {
        private AccountType acctType;
        public AccountType AccountType { get { return acctType; } }
        public AccountDropDownItem(String nm, String val, AccountType type)
        {
            name = nm; value = val; acctType = type;
        }
    }
    // TODO: might not need TransactionDropDownItem class. delete it? 
    public class TransactionDropDownItem : DropDownItem
    {
        private TransactionType transType;
        public TransactionDropDownItem(String nm, String val, TransactionType type)
        {
            name = nm; value = val; transType = type; 
        }
        public TransactionType TransactionType { get { return transType; } } 
    }
}
