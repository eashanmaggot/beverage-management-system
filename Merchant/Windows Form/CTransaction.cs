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
using System.Data;
namespace Merchant.Windows_Form
{
    public partial class CTransaction : Form
    {
        private string connectionString = "Data Source=DESKTOP-R7K1GUE;Initial Catalog=BevarageDatabase;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        int index;
        int id, chalanCost, laborCost, totalCaseno;
        String date;
        private DataSet dataSet;
        DatabaseClass.CtransactionDAO cTRansactionDAO = new DatabaseClass.CtransactionDAO();

        public CTransaction()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection(connectionString);
            updatePanel.Hide();
            deletePanel.Hide();
        }
        private void CTransaction_Load(object sender, EventArgs e)
        {
            showTable();
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

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            // index = listView1.SelectedIndices[0];

            dateTextbox.Text = listView1.SelectedItems[0].SubItems[0].Text;
            chalanCostTextbox.Text = listView1.SelectedItems[0].SubItems[1].Text;
            laborCostTextbox.Text = listView1.SelectedItems[0].SubItems[2].Text;
            totalCaseTextbox.Text = listView1.SelectedItems[0].SubItems[3].Text;
            chalanIDTextbox.Text = listView1.SelectedItems[0].SubItems[4].Text;
            //showTable();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(chalanIDTextbox.Text);
            date = Convert.ToString(dateTextbox.Text);
            System.Diagnostics.Debug.WriteLine(date);
            chalanCost = Convert.ToInt32(chalanCostTextbox.Text);
            laborCost = Convert.ToInt32(laborCostTextbox.Text);
            totalCaseno = Convert.ToInt32(totalCaseTextbox.Text);
            cTRansactionDAO.updateTraction(new DatabaseClass.CtransactionDTO(totalCaseno, chalanCost, laborCost, date, id));
            listView1.Items.Clear();
            showTable();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sure ??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                id = Convert.ToInt32(chalanIDTextbox.Text);
                cTRansactionDAO.deleteTransaction(new DatabaseClass.CtransactionDTO(0, 0, 0, "", id));
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                ///showTable();

            }
        }

        public void showTable()
        {
            sqlConnection.Open();
            string query = "select *  from ChalanTransaction ";
            //sqlCommand.Parameters.AddWithValue("@WKS", WKS);
            sqlCommand = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();
            while (sqlReader.Read())
            {
                ListViewItem item = new ListViewItem(sqlReader["Date"].ToString());

                item.SubItems.Add(sqlReader["ChalanCost"].ToString());
                item.SubItems.Add(sqlReader["LaborCost"].ToString());
                item.SubItems.Add(sqlReader["TotalCaseNo"].ToString());
                item.SubItems.Add(sqlReader["ChalanID"].ToString());
                listView1.Items.Add(item);
                //ListViewItem list
            }

            sqlConnection.Close();
        }

    }
}
