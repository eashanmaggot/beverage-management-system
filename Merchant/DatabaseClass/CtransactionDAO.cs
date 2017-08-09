using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Merchant.DatabaseClass
{
    class CtransactionDAO
    {
        private string connectionString = "Data Source=DESKTOP-R7K1GUE;Initial Catalog=BevarageDatabase;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;

        public CtransactionDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void updateTraction(CtransactionDTO cTransaction)
        {
            sqlConnection.Open();
            String update;
            update = " update ChalanTransaction set Date ='" + cTransaction.DATE + "', ChalanCost= " + cTransaction.CHALANCOST + " ,LaborCost=" + cTransaction.LABORCOST + " ,TotalCaseNo = " + cTransaction.TOTALCASE + " where ChalanID =" + cTransaction.CHALANID + " ";
            System.Diagnostics.Debug.WriteLine(update);
            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public void deleteTransaction(CtransactionDTO cTransaction)
        {
            sqlConnection.Open();
            String update;
            update = " delete from ChalanTransaction  where ChalanID =" + cTransaction.CHALANID + " ";
            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }
    
    }
}
