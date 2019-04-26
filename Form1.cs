using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialTrackingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            FormViewAll frmViewAll = new FormViewAll();
            frmViewAll.ShowDialog();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            var frmAdd = new FormAddTransaction();
            frmAdd.ShowDialog();
        }

        private void btnViewBalance_Click(object sender, EventArgs e)
        {
            clsTransactions clsT = new clsTransactions();
            double balance = clsT.GetCurrentBalance();
            MessageBox.Show("Your current balance is: " + balance.ToString("c"));
        }
    }
}
