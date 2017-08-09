using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant
{
    public partial class StartFORM : Form
    {
        String name = "salehin";
        String pass = "iconcept";
        public StartFORM()
        {
            InitializeComponent();
            welcomePanel.Show();
            optionPanel.Hide();

           

            //name = admin.getAdminInfo().Tables[0].Rows[0]["name"].ToString();
            //  pass = admin.getAdminInfo().Tables[0].Rows[0]["pass"].ToString();
            System.Diagnostics.Debug.WriteLine(name);
            System.Diagnostics.Debug.WriteLine(pass);

        }

        private void stockButton_Click(object sender, EventArgs e)
        {
            Windows_Form.Stock stock = new Windows_Form.Stock();
            stock.Show();
        }

        private void dailyInvoiceButton_Click(object sender, EventArgs e)
        {
            Windows_Form.DailyInvoice dailyinvoice = new Windows_Form.DailyInvoice();
            dailyinvoice.Show();
        }

        private void dailyTransactionButton_Click(object sender, EventArgs e)
        {
            Windows_Form.DailyTransaction dailyTransaction = new Windows_Form.DailyTransaction();
            dailyTransaction.Show();
                
        }

        private void companyInvoiceButton_Click(object sender, EventArgs e)
        {
            Windows_Form.CompanyInvoice companyInvoice = new Windows_Form.CompanyInvoice();
            companyInvoice.Show();
        }

        private void companyInvoiceTransactionButtton_Click(object sender, EventArgs e)
        {
            Windows_Form.CTransaction cTransaction = new Windows_Form.CTransaction();
            cTransaction.Show();
        }

        private void priceListButton_Click(object sender, EventArgs e)
        {
            Windows_Form.PriceList priceList = new Windows_Form.PriceList();
            priceList.Show();
        }

        private void editStockButton_Click(object sender, EventArgs e)
        {
            Windows_Form.EditStock editStock = new Windows_Form.EditStock();
            editStock.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(userName.Text.Equals(name));
            //System.Diagnostics.Debug.WriteLine(passwordTextbox.Text.Equals(pass));
            // String str = userName.Text.ToString();
            // System.Diagnostics.Debug.WriteLine(str.Equals(name));


            if (userNameTextbox.Text.ToString().Equals(name) && passwordTextbox.Text.ToString().Equals(pass))
            {
                welcomePanel.Hide();
                optionPanel.Show();
                // welcomePanel.Hide();
                //forgetPanel.Hide();


            }
            else
            {
                MessageBox.Show("Incorrect password or name ");
            }
        }

        private void userNameLeave(object sender, EventArgs e)
        {
            if (userNameTextbox.Text == "")
            {
                userNameTextbox.Text = "type here";
                userNameTextbox.ForeColor = Color.Silver;

            }
        }

        private void userNameEnter(object sender, EventArgs e)
        {
            if (userNameTextbox.Text == "type here")
            {
                userNameTextbox.Text = "";
                userNameTextbox.ForeColor = Color.Black;

            }
        }

        private void StartFORM_Load(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
