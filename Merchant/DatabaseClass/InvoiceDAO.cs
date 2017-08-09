using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Merchant.DatabaseClass
{
    class InvoiceDAO
    {
        //DatabaseConnection databaseConnection = new DatabaseConnection();
        private string connectionString = "Data Source=DESKTOP-R7K1GUE;Initial Catalog=BevarageDatabase;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataSet;
        int id = 1;
        public InvoiceDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void add7upProduct(s7upDTO invoice7upDTO)
        {

            // databaseConnection.databaseOpenConnection();
            sqlConnection.Open();

            String update = "update sUp set sUp2L=" + invoice7upDTO.S2L + ",sUp1L=" + invoice7upDTO.S1L + ",sUp500ml=" + invoice7upDTO.S500ML + ",sUp250pet=" + invoice7upDTO.S250MLPET + ",sUp250mlGlass=" + invoice7upDTO.S250MLGRB + ",sUp200mlGlass=" + invoice7upDTO.S200MLGRB + ",sUp250mlCan=" + invoice7upDTO.S200MLGRB + " where sUpID=" + id + " ";


            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void addPepsiProduct(PepsiDTO invoicePepsiDTO)
        {

            //databaseConnection.databaseOpenConnection();
            sqlConnection.Open();


            String update = "update Pepsi set Psi2L=" + invoicePepsiDTO.P2L + ",Psi1L=" + invoicePepsiDTO.P1L + ",Psi500ml=" + invoicePepsiDTO.P500ML + ",Psi500mlDiet=" + invoicePepsiDTO.P500ML + ",Psi250mlpet=" + invoicePepsiDTO.P250MLPET + ",Psi400ml=" + invoicePepsiDTO.P400ML + ",Psi250mlGlass=" + invoicePepsiDTO.P250MLGRB + ",Psi200mlGlass=" + invoicePepsiDTO.P200MLGRB + ",Psi250mlCan=" + invoicePepsiDTO.P250MLCAN + " where PsiID = " + id + "";


            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void addMirindaProduct(MirindaDTO invoiceMirindaDTO)
        {

            // databaseConnection.databaseOpenConnection();
            sqlConnection.Open();

            String update = " update Mirinda set Mda1L=" + invoiceMirindaDTO.M1L + ",Mda500ml=" + invoiceMirindaDTO.M500ML + ",Mda250mlPet=" + invoiceMirindaDTO.M250MLPET + ",Mda200mlGlass=" + invoiceMirindaDTO.M200MLGRB + ",Mda250mlCan=" + invoiceMirindaDTO.M250MLCAN + " where MdaID=" + id + " ";

            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void addDewProduct(DewDTO invoiceDewDTO)
        {

            //databaseConnection.databaseOpenConnection();
            sqlConnection.Open();

            String update = " update Dew set Dew500ml=" + invoiceDewDTO.D500ML + ",Dew400ml=" + invoiceDewDTO.D400ML + ",Dew250mlPet=" + invoiceDewDTO.D250MLPET + ",Dew200mlGlass=" + invoiceDewDTO.D200MLGRB + ",Dew250mlCan=" + invoiceDewDTO.D250MLCAN + " where DewID=" + id + " ";


            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void addAquafinaProduct(AquafinaDTO invoiceAquafinaDTO)
        {

            //databaseConnection.databaseOpenConnection();
            sqlConnection.Open();

            String update = "update Aquafina set AF1500ml=" + invoiceAquafinaDTO.A1500ML + ",AF500ml=" + invoiceAquafinaDTO.A500ML + " where AquafinaID=" + id + "  ";

            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void addSliceaProduct(SliceDTO invoiceSliceDTO)
        {

            //databaseConnection.databaseOpenConnection();
            sqlConnection.Open();
            String update = "update Slice set Slice250mlGlass=" + invoiceSliceDTO.SL250MLGRB + " where SliceID=" + id + "";



            sqlCommand = new SqlCommand(update, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void addChalan(CtransactionDTO chalan)
        {

            //databaseConnection.databaseOpenConnection();
            sqlConnection.Open();
            String query = "insert into ChalanTransaction values  ('" + chalan.DATE + "'," +
                                                    "'" + chalan.CHALANCOST + "'," +
                                                    "'" + chalan.LABORCOST + "'," +
                                                    "'" + chalan.TOTALCASE + "'," +
                                                    "'" + chalan.CHALANID + "')";


            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void addInvoice(InvoiceTransactionDTO invoiceTransaction)
        {

            //databaseConnection.databaseOpenConnection();
            sqlConnection.Open();
            String query = "insert into InvoiceTransaction values  ('" + invoiceTransaction.INVOICEID + "'," +
                                                    "'" + invoiceTransaction.DATE + "'," +
                                                    "'" +invoiceTransaction.SELLINGCASH+ "'," +
                                                    "'" + invoiceTransaction.PROFIT + "'," +
                                                      "'" + invoiceTransaction.OTHEREXPENSE + "'," +
                                                    "'" + invoiceTransaction.SHORTAGE + "')";


            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}
