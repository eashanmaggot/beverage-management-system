using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Merchant.Windows_Form
{
    public partial class DailyTransaction : Form
    {
        private string connectionString = "Data Source=DESKTOP-R7K1GUE;Initial Catalog=BevarageDatabase;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        DatabaseClass.InvoiceTransactionDAO invoiceTransactionDAO = new DatabaseClass.InvoiceTransactionDAO();
        int id, sellingCash, profit, otherExpense, shortage;
        String date;
        public DailyTransaction()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            updatePanel.Hide();
            deletePanel.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                id = Convert.ToInt32(InvoiceIDTextbox.Text);
               invoiceTransactionDAO.deleteTransaction(new DatabaseClass.InvoiceTransactionDTO("",0, 0, 0, 0, id));
               listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                ///showTable();

            }
        }

        private void editCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (editCheckbox.Checked)
            {
                updatePanel.Show();
                deletePanel.Show();
            }
            else
            {
                updatePanel.Hide();
                deletePanel.Hide();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DailyTransaction_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            sqlConnection.Open();
            string query = "select *  from InvoiceTransaction ";
            //sqlCommand.Parameters.AddWithValue("@WKS", WKS);
            sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            while (sqlReader.Read())
            {
                ListViewItem item = new ListViewItem(sqlReader["InvoiceID"].ToString());

                item.SubItems.Add(sqlReader["Date"].ToString());
                item.SubItems.Add(sqlReader["SellingCash"].ToString());
                item.SubItems.Add(sqlReader["Profit"].ToString());
                item.SubItems.Add(sqlReader["OtherExpense"].ToString());
                item.SubItems.Add(sqlReader["Shortage"].ToString());
                listView1.Items.Add(item);
                //ListViewItem list
            }

            sqlConnection.Close();
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            InvoiceIDTextbox.Text = listView1.SelectedItems[0].SubItems[0].Text;
            dateTextbox.Text = listView1.SelectedItems[0].SubItems[1].Text;
            sellingCashTextbox.Text = listView1.SelectedItems[0].SubItems[2].Text;
            ProfitTextbox.Text = listView1.SelectedItems[0].SubItems[3].Text;
            otherExpenseTextbox.Text = listView1.SelectedItems[0].SubItems[4].Text;
            shortageTextBox.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(InvoiceIDTextbox.Text);
            date = Convert.ToString(dateTextbox.Text);
            System.Diagnostics.Debug.WriteLine(date);
            sellingCash = Convert.ToInt32(sellingCashTextbox.Text);
            profit = Convert.ToInt32(ProfitTextbox.Text);
            otherExpense = Convert.ToInt32(otherExpenseTextbox.Text);
            shortage = Convert.ToInt32(shortageTextBox.Text);
            invoiceTransactionDAO.updateTraction(new DatabaseClass.InvoiceTransactionDTO(date,sellingCash,profit,otherExpense,shortage,id));
            listView1.Items.Clear();
            showTable();
        }
    }
}
