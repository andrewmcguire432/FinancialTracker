using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTrackingApp
{
    class clsDBConnect
    {
        private static string connectionString =
            "Data Source=(LocalDb)\\LocalDB;Initial Catalog=FinancialTrackerDB;Integrated Security=True";
        
        public static SqlConnection GetDBConnection()
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            return cnn;
        }

        public static void CloseConnection(SqlConnection cnn)
        {
            cnn.Close();
        }
    }
}
