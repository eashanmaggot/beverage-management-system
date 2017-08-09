using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
namespace Merchant.DatabaseClass
{
    class AdminDAO
    {
        private string connectionString = "Data Source=DESKTOP-R7K1GUE;Initial Catalog=BevarageDatabase;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;


        public AdminDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public DataSet getAdminInfo()
        {
            sqlConnection.Open();
            string query = "select * from Admin";

            sqlCommand = new SqlCommand(query, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
    }
}
