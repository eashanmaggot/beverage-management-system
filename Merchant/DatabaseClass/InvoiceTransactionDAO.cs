using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Merchant.DatabaseClass

{
    class InvoiceTransactionDAO
    {
        private string connectionString = "Data Source=DESKTOP-R7K1GUE;Initial Catalog=BevarageDatabase;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;

        public InvoiceTransactionDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void updateTraction(InvoiceTransactionDTO invoiceTransaction)
        {
            sqlConnection.Open();
            String update;
            update = " update InvoiceTransaction set Date ='" + invoiceTransaction.DATE + "', SellingCash= " + invoiceTransaction.SELLINGCASH+ " ,Profit=" +invoiceTransaction.PROFIT+ " ,OtherExpense = " + invoiceTransaction.OTHEREXPENSE + " where InvoiceID ="+invoiceTransaction.INVOICEID+" ";
            System.Diagnostics.Debug.WriteLine(update);
            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public void deleteTransaction(InvoiceTransactionDTO invoiceTransaction)
        {
            sqlConnection.Open();
            String update;
            update = " delete from InvoiceTransaction  where InvoiceID =" + invoiceTransaction.INVOICEID + " ";
            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

        }

    }
}

