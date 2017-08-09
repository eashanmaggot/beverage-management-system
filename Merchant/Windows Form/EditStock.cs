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
    public partial class EditStock : Form
    {
        DatabaseClass.BeverageDAO beverageDAO = new DatabaseClass.BeverageDAO();
        DatabaseClass.InvoiceDAO invoiceDAO = new DatabaseClass.InvoiceDAO();

        int s2L, s1L, s500ml, s500mldiet, s400ml, s250mlpet, s250mlGRB, s200mlGRB, s250mlCan; // 7up product Type 

        private void editStockDoneButton_Click(object sender, EventArgs e)
        {

            get7upProductQuantity();
            getPepsiProductQuantity();
            getMirindaProductQuantity();
            getDewProductQuatinty();
            getSliceProductQuantity();
            getAquafinaProductQuantity();


            invoiceDAO.add7upProduct(new DatabaseClass.s7upDTO(s2L, s1L, s500ml, s500mldiet, s400ml, s250mlpet, s250mlGRB, s200mlGRB, s250mlCan));
            invoiceDAO.addPepsiProduct(new DatabaseClass.PepsiDTO(p2L, p1L, p500ml, p500mldiet, p400ml, p250mlpet, p250mlGRB, p200mlGRB, p250mlCan));
            invoiceDAO.addMirindaProduct(new DatabaseClass.MirindaDTO(m1L, m500ml, m250mlpet, m200mlGRB, m250mlCan));
            invoiceDAO.addDewProduct(new DatabaseClass.DewDTO(d500ml, d400ml, d250mlpet, d200mlGRB, d250mlCan));
            invoiceDAO.addAquafinaProduct(new DatabaseClass.AquafinaDTO(a1500ml, a500ml));
            invoiceDAO.addSliceaProduct(new DatabaseClass.SliceDTO(sl250mlGRB));

            MessageBox.Show(" Successfully Done ");
            this.Hide();
        }

        int p2L, p1L, p500ml, p500mldiet, p400ml, p250mlpet, p250mlGRB, p200mlGRB, p250mlCan; // Pepsi product Type 
        int m1L, m500ml, m250mlpet, m200mlGRB, m250mlCan; // Mirinda product Type 

        private void editStockCx_CheckedChanged(object sender, EventArgs e)
        {
            if (editStockCx.Checked)
            {
                priceListPanel.Show();
            }
        }

        private void EditStock_Load(object sender, EventArgs e)
        {
            setAquafinaProductPrice();
            setSliceProductPrice();
            setDewProductPrice();
            setMirindaProductPrice();
            sett7upProductPrice();
            setPepsiProductPrice();
        }

        int d500ml, d400ml, d250mlpet, d200mlGRB, d250mlCan; // Dew product Type 
        int sl250mlGRB; // Slice product Type
        int a1500ml, a500ml;// Aqquafina product Type 

        public EditStock()
        {
            InitializeComponent();
            priceListPanel.Hide();
        }



        public void sett7upProductPrice()
        {

            s2LTextbox.Text = Convert.ToString(beverageDAO.sUP().Tables[0].Rows[0]["sUp2L"]);
            s1LTextbox.Text = Convert.ToString(beverageDAO.sUP().Tables[0].Rows[0]["sUp1L"]);
            s500mlTextbox.Text = Convert.ToString(beverageDAO.sUP().Tables[0].Rows[0]["sUp500ml"]);
            s500mldietTextbox.Text = Convert.ToString(beverageDAO.sUP().Tables[0].Rows[0]["sUp500mldiet"]);
            s400mlTextbox.Text = Convert.ToString(beverageDAO.sUP().Tables[0].Rows[0]["sUp400ml"]);
            s250mlpetTextbox.Text = Convert.ToString(beverageDAO.sUP().Tables[0].Rows[0]["sUp250pet"]);
            s250mlGRBTextbox.Text = Convert.ToString(beverageDAO.sUP().Tables[0].Rows[0]["sUp250mlGlass"]);
            s200mlGRBTextbox.Text = Convert.ToString(beverageDAO.sUP().Tables[0].Rows[0]["sUp200mlGlass"]);
            s250mlCanTextbox.Text = Convert.ToString(beverageDAO.sUP().Tables[0].Rows[0]["sUp250mlCan"]);

        }

        public void setPepsiProductPrice()
        {
            p2LTextbox.Text = Convert.ToString(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi2L"]);
            p1LTextbox.Text = Convert.ToString(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi1L"]);
            p500mlTextbox.Text = Convert.ToString(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi500ml"]);
            p500mldietTextbox.Text = Convert.ToString(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi500mlDiet"]);
            p400mlTextbox.Text = Convert.ToString(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi400ml"]);
            p250mlpetTextbox.Text = Convert.ToString(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi250mlPet"]);
            p250mlGRBTextbox.Text = Convert.ToString(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi250mlGlass"]);
            p200mlGRBTextbox.Text = Convert.ToString(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi200mlGlass"]);
            p250mlCanTextbox.Text = Convert.ToString(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi250mlCan"]);

        }
        public void setMirindaProductPrice()
        {
            m1LTextbox.Text = Convert.ToString(beverageDAO.Mirinda().Tables[0].Rows[0]["Mda1L"]);
            m500mlTextbox.Text = Convert.ToString(beverageDAO.Mirinda().Tables[0].Rows[0]["Mda500ml"]);
            m250mlpetTextbox.Text = Convert.ToString(beverageDAO.Mirinda().Tables[0].Rows[0]["Mda250mlPet"]);
            m200mlGRBTextbox.Text = Convert.ToString(beverageDAO.Mirinda().Tables[0].Rows[0]["Mda200mlGlass"]);
            m250mlCanTextbox.Text = Convert.ToString(beverageDAO.Mirinda().Tables[0].Rows[0]["Mda250mlCan"]);
        }

        public void setDewProductPrice()
        {
            d500mlTextbox.Text = Convert.ToString(beverageDAO.Dew().Tables[0].Rows[0]["Dew500ml"]);
            d400mlTexbox.Text = Convert.ToString(beverageDAO.Dew().Tables[0].Rows[0]["Dew400ml"]);
            d250mlpetTexbox.Text = Convert.ToString(beverageDAO.Dew().Tables[0].Rows[0]["Dew250mlPet"]);
            d200mlGRBTextbox.Text = Convert.ToString(beverageDAO.Dew().Tables[0].Rows[0]["Dew200mlGlass"]);
            d250mlCanTexbox.Text = Convert.ToString(beverageDAO.Dew().Tables[0].Rows[0]["Dew250mlCan"]);

        }
        public void setAquafinaProductPrice()
        {
            a1500mlTextbox.Text = Convert.ToString(beverageDAO.Aquafina().Tables[0].Rows[0]["AF1500ml"]);
            a500mlTextbox.Text = Convert.ToString(beverageDAO.Aquafina().Tables[0].Rows[0]["AF500ml"]);
        }
        public void setSliceProductPrice()
        {
            sl250mlGRBTextbox.Text = Convert.ToString(beverageDAO.Slice().Tables[0].Rows[0]["Slice250mlGlass"]);
        }



        // get data from Textboxes 

        public void get7upProductQuantity()
        {
            s2L = Convert.ToInt32(s2LTextbox.Text);
            s1L = Convert.ToInt32(s1LTextbox.Text);
            s500ml = Convert.ToInt32(s500mlTextbox.Text);
            s500mldiet = Convert.ToInt32(s500mldietTextbox.Text);
            s400ml = Convert.ToInt32(s400mlTextbox.Text);
            s250mlpet = Convert.ToInt32(s250mlpetTextbox.Text);
            s250mlGRB = Convert.ToInt32(s250mlGRBTextbox.Text);
            s200mlGRB = Convert.ToInt32(s200mlGRBTextbox.Text);
            s250mlCan = Convert.ToInt32(s250mlCanTextbox.Text);
        }
        public void getPepsiProductQuantity()
        {
            p2L = Convert.ToInt32(p2LTextbox.Text);
            p1L = Convert.ToInt32(p1LTextbox.Text);
            p500ml = Convert.ToInt32(p500mlTextbox.Text);
            p500mldiet = Convert.ToInt32(p500mldietTextbox.Text);
            p400ml = Convert.ToInt32(p400mlTextbox.Text);
            p250mlpet = Convert.ToInt32(p250mlpetTextbox.Text);
            p250mlGRB = Convert.ToInt32(p250mlGRBTextbox.Text);
            p200mlGRB = Convert.ToInt32(p200mlGRBTextbox.Text);
            p250mlCan = Convert.ToInt32(p250mlCanTextbox.Text);
        }

        public void getMirindaProductQuantity()
        {
            m1L = Convert.ToInt32(m1LTextbox.Text);
            m500ml = Convert.ToInt32(m500mlTextbox.Text);
            m250mlpet = Convert.ToInt32(m250mlpetTextbox.Text);
            m200mlGRB = Convert.ToInt32(m200mlGRBTextbox.Text);
            m250mlCan = Convert.ToInt32(m250mlCanTextbox.Text);

        }

        public void getDewProductQuatinty()
        {
            d500ml = Convert.ToInt32(d500mlTextbox.Text);
            d400ml = Convert.ToInt32(d400mlTexbox.Text);
            d250mlpet = Convert.ToInt32(d250mlpetTexbox.Text);
            d200mlGRB = Convert.ToInt32(d200mlGRBTextbox.Text);
            d250mlCan = Convert.ToInt32(d250mlCanTexbox.Text);

        }

        public void getAquafinaProductQuantity()
        {
            a1500ml = Convert.ToInt32(a1500mlTextbox.Text);
            a500ml = Convert.ToInt32(a500mlTextbox.Text);
        }

        public void getSliceProductQuantity()
        {
            sl250mlGRB = Convert.ToInt32(sl250mlGRBTextbox.Text);
        }
    }
}
