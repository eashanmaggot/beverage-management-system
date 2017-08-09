using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Merchant.DatabaseClass
{
    class PriceListDAO
    {
        //DatabaseConnection databaseConnection = new DatabaseConnection();
        private string connectionString = "Data Source=DESKTOP-R7K1GUE;Initial Catalog=BevarageDatabase;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;
        int id = 1;
        public PriceListDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void add7upProductPrice(s7upDTO invoice7upDTO)
        {

            // databaseConnection.databaseOpenConnection();
            sqlConnection.Open();

            String update = "update sUpPrice set sUp2Lp=" + invoice7upDTO.S2L + ",sUp1Lp=" + invoice7upDTO.S1L + ",sUp500mlp=" + invoice7upDTO.S500ML + ",sUp250mlpetp=" + invoice7upDTO.S250MLPET + ",sUp250mlglassp=" + invoice7upDTO.S250MLGRB + ",sUp200mlglassp=" + invoice7upDTO.S200MLGRB + ",sUp250mlcanp=" + invoice7upDTO.S200MLGRB + " where sUpPriceID=" + id + " ";


            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void addPepsiProductPrice(PepsiDTO invoicePepsiDTO)
        {

            //databaseConnection.databaseOpenConnection();
            sqlConnection.Open();


            String update = "update PepsiPrice set Psi2Lp=" + invoicePepsiDTO.P2L + ",Psi1Lp=" + invoicePepsiDTO.P1L + ",Psi500mlp=" + invoicePepsiDTO.P500ML + ",Psi500mlDietp=" + invoicePepsiDTO.P500ML + ",Psi250mlpetp=" + invoicePepsiDTO.P250MLPET + ",Psi400mlp=" + invoicePepsiDTO.P400ML + ",Psi250mlglassp=" + invoicePepsiDTO.P250MLGRB + ",Psi200mlglassp=" + invoicePepsiDTO.P200MLGRB + ",Psi250mlcanp=" + invoicePepsiDTO.P250MLCAN + " where PsiPriceID = " + id + "";


            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void addMirindaProductPrice(MirindaDTO invoiceMirindaDTO)
        {

            // databaseConnection.databaseOpenConnection();
            sqlConnection.Open();

            String update = " update MirindaPrice set Mda1Lp=" + invoiceMirindaDTO.M1L + ",Mda500mlp=" + invoiceMirindaDTO.M500ML + ",Mda250mlpetp=" + invoiceMirindaDTO.M250MLPET + ",Mda200mlglassp=" + invoiceMirindaDTO.M200MLGRB + ",Mda250mlcanp=" + invoiceMirindaDTO.M250MLCAN + " where MdaPriceID=" + id + " ";

            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void addDewProductPrice(DewDTO invoiceDewDTO)
        {

            //databaseConnection.databaseOpenConnection();
            sqlConnection.Open();

            String update = " update DewPrice set Dew500mlp=" + invoiceDewDTO.D500ML + ",Dew400mlp=" + invoiceDewDTO.D400ML + ",Dew250mlpetp=" + invoiceDewDTO.D250MLPET + ",Dew200mlglassp=" + invoiceDewDTO.D200MLGRB + ",Dew250mlcanp=" + invoiceDewDTO.D250MLCAN + " where DewPriceID=" + id + " ";


            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void addAquafinaProductPrice(AquafinaDTO invoiceAquafinaDTO)
        {

            //databaseConnection.databaseOpenConnection();
            sqlConnection.Open();

            String update = "update AquafinaPrice set Aqa1500mlp=" + invoiceAquafinaDTO.A1500ML + ",Aqa500mlp=" + invoiceAquafinaDTO.A500ML + " where AqaPriceID=" + id + "  ";

            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void addSliceProductPrice(SliceDTO invoiceSliceDTO)
        {

            //databaseConnection.databaseOpenConnection();
            sqlConnection.Open();
            String update = "update SlicePrice set Slice250mlglassp=" + invoiceSliceDTO.SL250MLGRB + " where SlicePriceID=" + id + "";



            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
