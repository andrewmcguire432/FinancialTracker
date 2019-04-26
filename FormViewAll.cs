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
    public partial class FormViewAll : Form
    {
        public FormViewAll()
        {
            InitializeComponent();
        }

        private void FormViewAll_Load(object sender, EventArgs e)
        {
            dgvDisplayTransactions.ReadOnly = true;
            clsTransactions clsT = new clsTransactions();
            var transactions = clsT.GetTransactionsAsDataSet();
            dgvDisplayTransactions.DataSource = transactions.Tables[0];
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.Format = "C";
            dgvDisplayTransactions.Columns[5].DefaultCellStyle = style;
            dgvDisplayTransactions.Columns[3].DefaultCellStyle = style;
        }
    }
}
