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
    public partial class LoadingView : Form
    {
        public LoadingView()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rectangleShape2.Width += 5;
            if(rectangleShape2.Width >= 477)
            {
                timer1.Stop();
                StartFORM AdminLoggingForm = new StartFORM();
                AdminLoggingForm.Show();
                this.Hide();
            }
        }

        private void LoadingView_Load(object sender, EventArgs e)
        {
            
        }
    }
}
