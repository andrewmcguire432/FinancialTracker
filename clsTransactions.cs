using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTrackingApp
{
    class clsTransactions
    {
        #region Properties
        private int _id;

        public int pID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _transactionType;

        public string pTransactionType
        {
            get { return _transactionType; }
            set { _transactionType = value; }
        }

        private double _transactionAmount;

        public double pTransactionAmount
        {
            get { return _transactionAmount; }
            set { _transactionAmount = value; }
        }

        private DateTime _transactionDate;

        public DateTime pTransactionDate
        {
            get { return _transactionDate; }
            set { _transactionDate = value; }
        }

        private string _transactionDescription;

        public string pTransactionDescription
        {
            get { return _transactionDescription; }
            set { _transactionDescription = value; }
        }

        private double _accountBalance;

        public double pAccountBalance
        {
            get { return _accountBalance; }
            set { _accountBalance = value; }
        }
        #endregion

        #region Constructors
        public clsTransactions()
        {

        }

        public clsTransactions(int id, string type, double amount, DateTime date, string desc, double balance)
        {
            pID = id;
            pTransactionType = type;
            pTransactionAmount = amount;
            pTransactionDate = date;
            pTransactionDescription = desc;
            pAccountBalance = balance;
        }
        #endregion

        #region Functions
        public DataSet GetTransactionsAsDataSet()
        {
            DataSet transactions = new DataSet();
            var con = clsDBConnect.GetDBConnection();
            con.Open();
            SqlCommand sqlComm = new SqlCommand("dbo.GetAll", con);
            sqlComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlComm;
            adapter.Fill(transactions);
            con.Close();
            return transactions;
        }

        public void InsertTransaction(double amount, string type, string description, DateTime date)
        {
            var con = clsDBConnect.GetDBConnection();
            con.Open();
            SqlCommand sqlComm = new SqlCommand("dbo.InsertNewTransaction", con);
            sqlComm.CommandType = CommandType.StoredProcedure;
            sqlComm.Parameters.AddWithValue("@Type", type);
            sqlComm.Parameters.AddWithValue("@Amount", amount);
            sqlComm.Parameters.AddWithValue("@Description", description);
            sqlComm.Parameters.AddWithValue("@Date", date);
            sqlComm.ExecuteNonQuery();
            con.Close();
        }

        public double GetCurrentBalance()
        {
            DataSet transactions = new DataSet();
            var con = clsDBConnect.GetDBConnection();
            con.Open();
            SqlCommand sqlComm = new SqlCommand("dbo.GetCurrentBalance", con);
            sqlComm.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sqlComm;
            adapter.Fill(transactions);
            return Convert.ToDouble(transactions.Tables[0].Rows[0]["totalBalance"]);

        }

        #endregion



    }
}
