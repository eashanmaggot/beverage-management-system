using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Merchant.DatabaseClass
{
    class BeverageDAO
    {
        private string connectionString = "Data Source=DESKTOP-R7K1GUE;Initial Catalog=BevarageDatabase;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;

        private DataSet dataSet;

        public BeverageDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }


       
           

        public DataSet sUP1()
        {
            sqlConnection.Open();
            string query = "select sUp2L as '7up 2L', sUp1L as '7up 1L', sUp500ml as '7up 500ml', sUp250pet as '7up 250mlpet', sUp200mlGlass as '7up 200mlGRB', sUp250mlGlass as '7up 250mlGRB', sUp250mlCan as '7up 250mlCan', sUp400ml as '7up 400ml' , sUp500mldiet as '7up 500mldiet' from sUp";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet sUP()
        {
            sqlConnection.Open();
            string query = "select sUp2L , sUp1L , sUp500ml , sUp250pet , sUp200mlGlass, sUp250mlGlass, sUp250mlCan, sUp400ml  , sUp500mldiet  from sUp";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet sUPPrice()
        {
            sqlConnection.Open();
            string query = "select sUp2Lp, sUp1Lp, sUp500mlp, sUp250mlpetp, sUp200mlglassp, sUp250mlglassp, sUp250mlcanp, sUp400mlp , sUp500mldietp from sUpPrice";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet CsUPPrice()
        {
            sqlConnection.Open();
            string query = "select CsUp2Lp, CsUp1Lp, CsUp500mlp, CsUp250mlpetp, CsUp200mlglassp, CsUp250mlglassp, CsUp250mlcanp, CsUp400ml , CsUp500mldietp from CsUpPrice";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet Pepsi1()
        {
            sqlConnection.Open();
            string query = "select Psi2L as 'Pepsi 2L', Psi1L as 'Pepsi 1L', Psi500ml as 'Pepsi 500ml', Psi500mldiet as 'Pepsi 500mldiet', Psi400ml as 'Pepsi 400ml', Psi250mlPet as 'Pepsi 250mlpet', Psi250mlGlass as 'Pepsi 250mlGRB', Psi200mlGlass as 'Pepsi 200mlGRB', Psi250mlCan as 'Pepsi 250mlCan' from Pepsi ";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet Pepsi()
        {
            sqlConnection.Open();
            string query = "select Psi2L , Psi1L , Psi500ml, Psi500mldiet , Psi400ml , Psi250mlPet , Psi250mlGlass, Psi200mlGlass, Psi250mlCan  from Pepsi ";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet PepsiPrice()
        {
            sqlConnection.Open();
            string query = "select Psi2Lp, Psi1Lp, Psi500mlp, Psi500mldietp, Psi400mlp, Psi250mlpetp, Psi250mlglassp, Psi200mlglassp, Psi250mlcanp from PepsiPrice ";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet CPepsiPrice()
        {
            sqlConnection.Open();
            string query = "select CPepsi2Lp,  CPepsi1Lp,  CPepsi500mlp,  CPepsi500mldietp,  CPepsi400mlp,  CPepsi250mlpetp,  CPepsi250mlglassp,  CPepsi200mlglassp,  CPepsi250mlcanp from  CPepsiPrice ";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }

        public DataSet Mirinda1()
        {
            sqlConnection.Open();
            string query = "select Mda1L as 'Mirinda 1L', Mda500ml as 'Mirinda 500ml', Mda250mlPet as 'Mirinda 250mlpet', Mda200mlGlass as 'Mirinda 200mlGRB', Mda250mlCan as 'Mirinda 250mlCan' from Mirinda  ";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet Mirinda()
        {
            sqlConnection.Open();
            string query = "select Mda1L, Mda500ml , Mda250mlPet, Mda200mlGlass , Mda250mlCan  from Mirinda  ";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet MirindaPrice()
        {
            sqlConnection.Open();
            string query = "select Mda1Lp, Mda500mlp, Mda250mlpetp, Mda200mlglassp, Mda250mlcanp from MirindaPrice ";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet CMirindaPrice()
        {
            sqlConnection.Open();
            string query = "select CMirinda1Lp, CMirinda500mlp, CMirinda250mlpetp, CMirinda200mlglassp,CMirinda250mlcanp from CMirindaPrice ";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet Dew1()
        {
            sqlConnection.Open();
            string query = "select Dew400ml as 'Dew 400ml', Dew500ml as 'Dew 500ml', Dew250mlPet as 'Dew 250mlpet', Dew200mlGlass as 'Dew 200mlGRB', Dew250mlCan as 'Dew 250mlCan' from Dew";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet Dew()
        {
            sqlConnection.Open();
            string query = "select Dew400ml, Dew500ml, Dew250mlPet , Dew200mlGlass , Dew250mlCan  from Dew";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet DewPrice()
        {
            sqlConnection.Open();
            string query = "select Dew400mlp, Dew500mlp, Dew250mlpetp, Dew200mlglassp, Dew250mlcanp from DewPrice";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet CDewPrice()
        {
            sqlConnection.Open();
            string query = "select CDew400mlp, CDew500mlp, CDew250mlpetp, CDew200mlglassp, CDew250mlcanp from CDewPrice";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet Aquafina1()
        {
            sqlConnection.Open();
            string query = "select AF1500ml as 'Aquafina 1500ml', AF500ml as 'Aquafina 500ml' from Aquafina";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet Aquafina()
        {
            sqlConnection.Open();
            string query = "select AF1500ml , AF500ml from Aquafina";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet AquafinaPrice()
        {
            sqlConnection.Open();
            string query = "select Aqa1500mlp, Aqa500mlp from AquafinaPrice";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet CAquafinaPrice()
        {
            sqlConnection.Open();
            string query = "select CAqa1500mlp, CAqa500mlp from CAqaPrice";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet Slice1()
        {
            sqlConnection.Open();
            string query = "select Slice250mlGlass as 'Slice 250mlGRB' from Slice";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet Slice()
        {
            sqlConnection.Open();
            string query = "select Slice250mlGlass  from Slice";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet SlicePrice()
        {
            sqlConnection.Open();
            string query = "select Slice250mlglassp from SlicePrice";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }
        public DataSet CSlicePrice()
        {
            sqlConnection.Open();
            string query = "select CSlice250mlglassp from CSlicePrice";

            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlAdapter = new SqlDataAdapter(sqlCommand);

            dataSet = new DataSet();
            sqlAdapter.Fill(dataSet);

            sqlConnection.Close();
            return dataSet;
        }



    }
}
