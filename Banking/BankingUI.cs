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
        }

        private void lblBalance_Click(object sender, EventArgs e)
        {

        }

        private void cbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAccount.SelectedValue.ToString().Equals("Checking"))
            {
                MessageBox.Show("you picked checking"); 
            }
            else if (cbAccount.SelectedValue.ToString().Equals("Savings"))
            {
                MessageBox.Show("you picked savings"); 
            }
        }
    }
}
