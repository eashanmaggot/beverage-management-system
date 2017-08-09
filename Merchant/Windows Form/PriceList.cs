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
    public partial class PriceList : Form
    {
        DatabaseClass.BeverageDAO beverageDAO = new DatabaseClass.BeverageDAO();
        DatabaseClass.PriceListDAO priceListDAO = new DatabaseClass.PriceListDAO();

        int s2L, s1L, s500ml, s500mldiet, s400ml, s250mlpet, s250mlGRB, s200mlGRB, s250mlCan; // 7up product Type 
        int p2L, p1L, p500ml, p500mldiet, p400ml, p250mlpet, p250mlGRB, p200mlGRB, p250mlCan; // Pepsi product Type 
        int m1L, m500ml, m250mlpet, m200mlGRB, m250mlCan; // Mirinda product Type 

       

        private void priceListDoneButton_Click(object sender, EventArgs e)
        {
            get7upProductQuantity();
            getPepsiProductQuantity();
            getMirindaProductQuantity();
            getDewProductQuatinty();
            getSliceProductQuantity();
            getAquafinaProductQuantity();


            priceListDAO.add7upProductPrice(new DatabaseClass.s7upDTO(s2L, s1L, s500ml, s500mldiet, s400ml, s250mlpet, s250mlGRB, s200mlGRB, s250mlCan));
            priceListDAO.addPepsiProductPrice(new DatabaseClass.PepsiDTO(p2L, p1L, p500ml, p500mldiet, p400ml, p250mlpet, p250mlGRB, p200mlGRB, p250mlCan));
            priceListDAO.addMirindaProductPrice(new DatabaseClass.MirindaDTO(m1L, m500ml, m250mlpet, m200mlGRB, m250mlCan));
            priceListDAO.addDewProductPrice(new DatabaseClass.DewDTO(d500ml, d400ml, d250mlpet, d200mlGRB, d250mlCan));
            priceListDAO.addAquafinaProductPrice(new DatabaseClass.AquafinaDTO(a1500ml, a500ml));
            priceListDAO.addSliceProductPrice(new DatabaseClass.SliceDTO(sl250mlGRB));

            MessageBox.Show(" Successfully Done ");
            this.Hide();
        }

        int d500ml, d400ml, d250mlpet, d200mlGRB, d250mlCan; // Dew product Type 
        int sl250mlGRB; // Slice product Type
        int a1500ml, a500ml;// Aqquafina product Type 
        public PriceList()
        {
            InitializeComponent();
            priceListPanel.Hide();
        }
        private void pricelistCx_CheckedChanged(object sender, EventArgs e)
        {
            if (pricelistCx.Checked)
            {
                priceListPanel.Show();
            }
        }
        private void PriceList_Load(object sender, EventArgs e)
        {
            setAquafinaProductPrice();
            setSliceProductPrice();
            setDewProductPrice();
            setMirindaProductPrice();
            sett7upProductPrice();
            setPepsiProductPrice();
        }
        public void sett7upProductPrice()
        {

            s2LTextbox.Text = Convert.ToString(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp2Lp"]);
            s1LTextbox.Text = Convert.ToString(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp1Lp"]);
            s500mlTextbox.Text = Convert.ToString(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp500mlp"]);
            s500mldietTextbox.Text = Convert.ToString(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp500mldietp"]);
            s400mlTextbox.Text = Convert.ToString(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp400mlp"]);
            s250mlpetTextbox.Text = Convert.ToString(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp250mlpetp"]);
            s250mlGRBTextbox.Text = Convert.ToString(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp250mlglassp"]);
            s200mlGRBTextbox.Text = Convert.ToString(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp200mlglassp"]);
            s250mlCanTextbox.Text = Convert.ToString(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp250mlcanp"]);

        }

        public void setPepsiProductPrice()
        {
            p2LTextbox.Text = Convert.ToString(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi2Lp"]);
            p1LTextbox.Text = Convert.ToString(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi1Lp"]);
            p500mlTextbox.Text = Convert.ToString(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi500mlp"]);
            p500mldietTextbox.Text = Convert.ToString(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi500mldietp"]);
            p400mlTextbox.Text = Convert.ToString(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi400mlp"]);
            p250mlpetTextbox.Text = Convert.ToString(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi250mlpetp"]);
            p250mlGRBTextbox.Text = Convert.ToString(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi250mlglassp"]);
            p200mlGRBTextbox.Text = Convert.ToString(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi200mlglassp"]);
            p250mlCanTextbox.Text = Convert.ToString(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi250mlcanp"]);

        }
        public void setMirindaProductPrice()
        {
            m1LTextbox.Text = Convert.ToString(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda1Lp"]);
            m500mlTextbox.Text = Convert.ToString(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda500mlp"]);
            m250mlpetTextbox.Text = Convert.ToString(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda250mlpetp"]);
            m200mlGRBTextbox.Text = Convert.ToString(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda200mlglassp"]);
            m250mlCanTextbox.Text = Convert.ToString(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda250mlcanp"]);
        }

        public void setDewProductPrice()
        {
            d500mlTextbox.Text = Convert.ToString(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew500mlp"]);
            d400mlTexbox.Text = Convert.ToString(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew400mlp"]);
            d250mlpetTexbox.Text = Convert.ToString(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew250mlpetp"]);
            d200mlGRBTextbox.Text = Convert.ToString(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew200mlglassp"]);
            d250mlCanTexbox.Text = Convert.ToString(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew250mlcanp"]);

        }
        public void setAquafinaProductPrice()
        {
            a1500mlTextbox.Text = Convert.ToString(beverageDAO.AquafinaPrice().Tables[0].Rows[0]["Aqa1500mlp"]);
            a500mlTextbox.Text = Convert.ToString(beverageDAO.AquafinaPrice().Tables[0].Rows[0]["Aqa500mlp"]);
        }
        public void setSliceProductPrice()
        {
            sl250mlGRBTextbox.Text = Convert.ToString(beverageDAO.SlicePrice().Tables[0].Rows[0]["Slice250mlglassp"]);
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
