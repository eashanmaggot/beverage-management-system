using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merchant.Windows_Form
{
    public partial class Stock : Form
    {
        DatabaseClass.BeverageDAO beverageInfo = new DatabaseClass.BeverageDAO();
        public Stock()
        {
            InitializeComponent();
            sUpInfo.DataSource = beverageInfo.sUP1().Tables[0];
            Dew.DataSource = beverageInfo.Dew1().Tables[0];
            Pepsi.DataSource = beverageInfo.Pepsi1().Tables[0];
            Mirinda.DataSource = beverageInfo.Mirinda1().Tables[0];
            Aquafina.DataSource = beverageInfo.Aquafina1().Tables[0];
            Slice.DataSource = beverageInfo.Slice1().Tables[0];

        }

        private void Stock_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
