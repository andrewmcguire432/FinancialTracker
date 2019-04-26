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
    public partial class FormAddTransaction : Form
    {
        public FormAddTransaction()
        {
            InitializeComponent();
        }

        private void FormAddTransaction_Load(object sender, EventArgs e)
        {
            cbType.Items.Add("Deposit");
            cbType.Items.Add("Withdraw");
            cbType.SelectedIndex = 0;
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            clsTransactions insert = new clsTransactions();

            double amount;

            if (double.TryParse(txtAmount.Text, out amount))
            {
                string type = cbType.Text;
                string description = txtDescription.Text;
                DateTime date = dateTimePicker1.Value;
                insert.InsertTransaction(amount, type, description, date);
                MessageBox.Show("Insert Successful");
                cbType.Text = "";
                txtDescription.Clear();
                txtAmount.Clear();
            }
            else
            {
                MessageBox.Show("Enter valid deposit amount");
            }

        }
    }
}
