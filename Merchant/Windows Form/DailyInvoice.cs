using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace Merchant.Windows_Form
{
    public partial class DailyInvoice : Form
    {

        DatabaseClass.BeverageDAO beverageDAO = new DatabaseClass.BeverageDAO();
        DatabaseClass.InvoiceDAO invoiceDAO = new DatabaseClass.InvoiceDAO();

        // delivery varible
        int s2L, s1L, s500ml, s500mldiet, s400ml, s250mlpet, s250mlGRB, s200mlGRB, s250mlCan; // 7up product Type 
        int p2L, p1L, p500ml, p500mldiet, p400ml, p250mlpet, p250mlGRB, p200mlGRB, p250mlCan; // Pepsi product Type 
        int m1L, m500ml, m250mlpet, m200mlGRB, m250mlCan; // Mirinda product Type 
        int d500ml, d400ml, d250mlpet, d200mlGRB, d250mlCan; // Dew product Type 
        int sl250mlGRB; // Slice product Type
        int a1500ml, a500ml;// Aqquafina product Type 
       
  
        // return varible 
        int returns2L, returns1L, returns500ml, returns500mldiet, returns400ml, returns250mlpet, returns250mlGRB, returns200mlGRB, returns250mlCan; // 7up product Type 
        int returns2Lp, returns1Lp, returns500mlp, returns500mldietp, returns400mlp, returns250mlpetp, returns250mlGRBp, returns200mlGRBp, returns250mlCanp;  

        int returnp2Lp, returnp1Lp, returnp500mlp, returnp500mldietp, returnp400mlp, returnp250mlpetp, returnp250mlGRBp, returnp200mlGRBp, returnp250mlCanp; // Pepsi product Type 
        int returnp2L, returnp1L, returnp500ml, returnp500mldiet, returnp400ml, returnp250mlpet, returnp250mlGRB, returnp200mlGRB, returnp250mlCan;

        int returnm1L, returnm500ml, returnm250mlpet, returnm200mlGRB, returnm250mlCan; // Mirinda product Type 
        int returnm1Lp, returnm500mlp, returnm250mlpetp, returnm200mlGRBp, returnm250mlCanp;  

        int returnd500ml, returnd400ml, returnd250mlpet, returnd200mlGRB, returnd250mlCan; // Dew product Type 

        int returnd500mlp, returnd400mlp, returnd250mlpetp, returnd200mlGRBp, returnd250mlCanp;  

        int returnsl250mlGRB; // Slice product Type
        int returnsl250mlGRBp; 

        int returna1500ml, returna500ml;// Aqquafina product Type
        int returna1500mlp, returna500mlp;

        // sold out variable 
        int solds2L, solds1L, solds500ml, solds500mldiet, solds400ml, solds250mlpet, solds250mlGRB, solds200mlGRB, solds250mlCan; // 7up product Type 

        

        int solds2Lp, solds1Lp, solds500mlp, solds500mldietp, solds400mlp, solds250mlpetp, solds250mlGRBp, solds200mlGRBp, solds250mlCanp; // 7up product Type 

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        int soldp2L, soldp1L, soldp500ml, soldp500mldiet, soldp400ml, soldp250mlpet, soldp250mlGRB, soldp200mlGRB, soldp250mlCan; // Pepsi product Type 
        int soldp2Lp, soldp1Lp, soldp500mlp, soldp500mldietp, soldp400mlp, soldp250mlpetp, soldp250mlGRBp, soldp200mlGRBp, soldp250mlCanp; // Pepsi product Type 

        int soldm1L, soldm500ml, soldm250mlpet, soldm200mlGRB, soldm250mlCan; // Mirinda product Type 
        int soldm1Lp, soldm500mlp, soldm250mlpetp, soldm200mlGRBp, soldm250mlCanp; 

        int soldd500ml, soldd400ml, soldd250mlpet, soldd200mlGRB, soldd250mlCan; // Dew product Type 
        int soldd500mlp, soldd400mlp, soldd250mlpetp, soldd200mlGRBp, soldd250mlCanp;  

        int soldsl250mlGRB; // Slice product Type
        int soldsl250mlGRBp; 

        int solda1500ml, solda500ml;// Aqquafina product Type 
        int solda1500mlp, solda500mlp;

        // update Stock  after seelling item  

        int updates2L, updates1L, updates500ml, updates500mldiet, updates400ml, updates250mlpet, updates250mlGRB, updates200mlGRB, updates250mlCan; // 7up product Type 
        int updatep2L, updatep1L, updatep500ml, updatep500mldiet, updatep400ml, updatep250mlpet, updatep250mlGRB, updatep200mlGRB, updatep250mlCan; // Pepsi product Type 
        int updatem1L, updatem500ml, updatem250mlpet, updatem200mlGRB, updatem250mlCan; // Mirinda product Type 
        int updated500ml, updated400ml, updated250mlpet, updated200mlGRB, updated250mlCan; // Dew product Type 
        int updatesl250mlGRB; // Slice product Type
        int updatea1500ml, updatea500ml;// Aqquafina product Type 

        // sold out products price 

        double solds2LTk, solds1LTk, solds500mlTk, solds500mldietTk, solds400mlTk, solds250mlpetTk, solds250mlGRBTk, solds200mlGRBTk, solds250mlCanTk; // 7up product Type 
        double solds2LpTk, solds1LpTk, solds500mlpTk, solds500mldietpTk, solds400mlpTk, solds250mlpetpTk, solds250mlGRBpTk, solds200mlGRBpTk, solds250mlCanpTk; // 7up product Type 

        double soldp2LTk, soldp1LTk, soldp500mlTk, soldp500mldietTk, soldp400mlTk, soldp250mlpetTk, soldp250mlGRBTk, soldp200mlGRBTk, soldp250mlCanTk; // Pepsi product Type 
        double soldp2LpTk, soldp1LpTk, soldp500mlpTk, soldp500mldietpTk, soldp400mlpTk, soldp250mlpetpTk, soldp250mlGRBpTk, soldp200mlGRBpTk, soldp250mlCanpTk; // Pepsi product Type 

        double soldm1LTk, soldm500mlTk, soldm250mlpetTk, soldm200mlGRBTk, soldm250mlCanTk; // Mirinda product Type 
        double soldm1LpTk, soldm500mlpTk, soldm250mlpetpTk, soldm200mlGRBpTk, soldm250mlCanpTk;

        double soldd500mlTk, soldd400mlTk, soldd250mlpetTk, soldd200mlGRBTk, soldd250mlCanTk; // Dew product Type 
        double soldd500mlpTk, soldd400mlpTk, soldd250mlpetpTk, soldd200mlGRBpTk, soldd250mlCanpTk;

        double soldsl250mlGRBTk; // Slice product Type
        double soldsl250mlGRBpTk;

        double solda1500mlTk, solda500mlTk;// Aqquafina product Type 
        double  solda1500mlpTk, solda500mlpTk;
        double total7upCash, totalPepsiCash, totalMirindaCash, totalDewCash, totalAquafinaCash, totalSliceCash;
        String date;

        double stotal;
        double ctotal;
        double profit;
        int handCash;
        int otherExpense;
        int shortage;
        int sellingCash;
        int companytotal;
        int profitt;
        int tem;
        //int handcash1;
        int otherex;
        int shortaz;
        Random random = new Random();
        int invoiceID;
        public DailyInvoice()
        {
            InitializeComponent();
            dateLabel.Text = "Date : " + DateTime.Now.Date.ToShortDateString();
            date = DateTime.Now.Date.ToShortDateString();

        }

        private void DailyInvoice_Load(object sender, EventArgs e)
        {
           
        }
        // Delivery Check box 
        private void delivaryCx_CheckedChanged(object sender, EventArgs e)
        {
            if (delivaryCx.Checked)
            {
                if (int.TryParse(deliverys2LTx.Text,out tem) && int.TryParse(deliverys1LTx.Text, out tem) && int.TryParse(deliverys500mlTx.Text, out tem) && int.TryParse(deliverys500mldietTx.Text, out tem)&& int.TryParse(deliverys250mlpetTx.Text, out tem) && int.TryParse(deliverys250mlGRBTx.Text, out tem) && int.TryParse(deliverys200mlGRBTx.Text, out tem) && int.TryParse(deliverys250mlCanTx.Text, out tem) && int.TryParse(deliverys400mlTx.Text, out tem)  && int.TryParse(deliveryp2LTx.Text, out tem) && int.TryParse(deliveryp1LTx.Text, out tem) && int.TryParse(deliveryp500mlTx.Text, out tem) && int.TryParse(deliveryp500mldietTx.Text, out tem) && int.TryParse(deliveryp250mlpetTx.Text, out tem) && int.TryParse(deliveryp250mlGRBTx.Text, out tem) && int.TryParse(deliveryp200mlGRBTx.Text, out tem) && int.TryParse(deliveryp250mlCanTx.Text, out tem) && int.TryParse(deliveryp400mlTx.Text, out tem)  && int.TryParse(deliverym1LTx.Text, out tem) && int.TryParse(deliverym500mlTx.Text, out tem)  && int.TryParse(deliverym250mlpetTx.Text, out tem)  && int.TryParse(deliverym200mlGRBTx.Text, out tem) && int.TryParse(deliverym250mlCanTx.Text, out tem)  &&  int.TryParse(deliveryd400mlTx.Text, out tem) && int.TryParse(deliveryd500mlTx.Text, out tem) && int.TryParse(deliveryd250mlpetTx.Text, out tem) && int.TryParse(deliveryd200mlGRBTx.Text, out tem) && int.TryParse(deliveryd250mlCanTx.Text, out tem) && int.TryParse(deliveryd200mlGRBTx.Text, out tem) && int.TryParse(deliveryd250mlCanTx.Text, out tem) &&  int.TryParse(deliverya1500mlTx.Text, out tem) && int.TryParse(deliverya500mlTx.Text, out tem) && int.TryParse(deliverysl250mlGRBTx.Text, out tem))
                {
                    getDelivery7upProductQuantity();
                    getDeliveryPepsiProductQuantity();
                    getDeliveryMirindaProductQuantity();
                    getDeliveryDewProductQuantity();
                    getDeliverySliceProductQuantity();
                    getDeliveryAquafinaProductQuantity();
                }
                else
                {
                    MessageBox.Show("Please Correct The Input ");
                }
            }
            
        }
        // Return product Checkbox

        private void returnCx_CheckedChanged(object sender, EventArgs e)
        {
            if (returnCx.Checked)
            {
                if (int.TryParse(returns7up2LTx.Text, out tem) && int.TryParse(returns7up1LTx.Text, out tem) && int.TryParse(returns7up500mlTx.Text, out tem) && int.TryParse(returns7up500mldietTx.Text, out tem) && int.TryParse(returns7up250mlpetTx.Text, out tem) && int.TryParse(returns7up250mlGRBTx.Text, out tem) && int.TryParse(returns7up200mlGRBTx.Text, out tem) && int.TryParse(returns7up250mlCanTx.Text, out tem) && int.TryParse(returns7up400mlTx.Text, out tem) && int.TryParse(returnPepsi2LTx.Text, out tem) && int.TryParse(returnPepsi1LTx.Text, out tem) && int.TryParse(returnPepsi500mlTx.Text, out tem) && int.TryParse(returnPepsi500mldietTx.Text, out tem) && int.TryParse(returnPepsi250mlpetTx.Text, out tem) && int.TryParse(returnPepsi250mlGRBTx.Text, out tem) && int.TryParse(returnPepsi200mlGRBTx.Text, out tem) && int.TryParse(returnPepsi250mlCanTx.Text, out tem) && int.TryParse(returnPepsi400mlTx.Text, out tem) && int.TryParse(returnMirinda1LTx.Text, out tem) && int.TryParse(returnMirinda500mlTx.Text, out tem) && int.TryParse(returnMirinda250mlpetTx.Text, out tem) && int.TryParse(returnMirinda200mlGRBTx.Text, out tem) && int.TryParse(returnMirinda250mlCanTx.Text, out tem) && int.TryParse(returnDew400mlTx.Text, out tem) && int.TryParse(returnDew500mlTx.Text, out tem) && int.TryParse(returnDew250mlpetTx.Text, out tem) && int.TryParse(returnDew200mlGRBTx.Text, out tem) && int.TryParse(deliveryd250mlCanTx.Text, out tem) && int.TryParse(deliveryd200mlGRBTx.Text, out tem) && int.TryParse(returnDew250mlCanTx.Text, out tem) && int.TryParse(returnAqufina1500mlTx.Text, out tem) && int.TryParse(returnAqufina500mlTx.Text, out tem) && int.TryParse(returnSlice250mlGRBTx.Text, out tem)) { 

                getReturn7upProductQuantity();
                getReturnPepsiProductQuantity();
                getReturnMirindaProductQuantity();
                getReturnDewProductQuantity();
                getReturnSliceProductQuantity();
                getReturnAquafinaProductQuantity();

                }
                else
                {
                    MessageBox.Show("Please Correct The Input ");
                }
            }
           
        }

        private void soldOutCx_CheckedChanged(object sender, EventArgs e)
        {
            if (delivaryCx.Checked && returnCx.Checked)
            {
                if (soldOutCx.Checked)
                {
                    sold7upProductQuantity();
                    soldPepsiProductQuantity();
                    soldMirindaProductQuantity();
                    soldDewProductQuantity();
                    soldAquafinaProductQuantity();
                    soldSliceProductQuantity();


                    sold7upSetProductQuantity();
                    soldPepsiSetProductQuantity();
                    soldMirindaSetProductQuantity();
                    soldDewSetProductQuantity();
                    soldAquafinaSetProductQuantity();
                    soldSliceSetProductQuantity();
                }
            }
            else
            {
                MessageBox.Show(" Please check the all boxes ");
            }
        }

        private void totalSellingCashCheckBtn_Click(object sender, EventArgs e)
        {
            if (delivaryCx.Checked && returnCx.Checked && soldOutCx.Checked)
            {
                TotalSellingCashCustomerRate();

                stotal = total7upCash + totalPepsiCash + totalMirindaCash + totalDewCash + totalAquafinaCash + totalSliceCash;
                companytotal = Convert.ToInt32(stotal);
                totalSellingCashTx.Text = Convert.ToString(companytotal);

                
            }
            else
            {
                MessageBox.Show(" Please check the all boxes ");
            }
        }
        private void productProfitCheckBtn_Click(object sender, EventArgs e)
        {
            if (delivaryCx.Checked && returnCx.Checked && soldOutCx.Checked)
            {
                TotalSellingCashCustomerRate();
                //TotalSellingCashComapanyRate();

                stotal = total7upCash + totalPepsiCash + totalMirindaCash + totalDewCash + totalAquafinaCash + totalSliceCash;
                TotalSellingCashComapanyRate();
                ctotal = total7upCash + totalPepsiCash + totalMirindaCash + totalDewCash + totalAquafinaCash + totalSliceCash;

                profit = stotal - ctotal;
                productProfitTx.Text = Convert.ToString(profit);
            }
            else
            {
                MessageBox.Show(" Please check the all boxes ");
            }
        }
        private void shortageCheckBtn_Click(object sender, EventArgs e)
        {
            if (delivaryCx.Checked && returnCx.Checked && soldOutCx.Checked)
            {

                if (int.TryParse(otherExpenseTx.Text, out tem) && int.TryParse(handCashTx.Text,out tem)) {
                    TotalSellingCashCustomerRate();
                    stotal = total7upCash + totalPepsiCash + totalMirindaCash + totalDewCash + totalAquafinaCash + totalSliceCash;
                    companytotal = Convert.ToInt32(stotal);
                    handCash = Convert.ToInt32(handCashTx.Text);
                    otherExpense = Convert.ToInt32(otherExpenseTx.Text);
                    companytotal = Convert.ToInt32(stotal);
                    tem = companytotal - otherExpense;
                    if (tem > handCash)
                    {
                        shortage = tem - handCash;
                        shortageTx.Text = Convert.ToString(shortage);
                    }
                    else
                    {
                        shortage = 0;
                        shortageTx.Text = "0";
                    }
                }

                else
                {
                    MessageBox.Show(" Please Correct The Input ");
                }
                
            }
            else
            {
                MessageBox.Show(" Please check the all boxes ");
            }
        }
        private void dailyInvoiceButton_Click(object sender, EventArgs e)
        {
            if (delivaryCx.Checked && returnCx.Checked && soldOutCx.Checked) {
                updatesoldProductQuantity();
                invoiceID = random.Next(106, 999);
                sellingCash = Convert.ToInt32(stotal);
                profitt = Convert.ToInt32(profit);
                otherex = Convert.ToInt32(otherExpense);
                shortaz = Convert.ToInt32(shortage);

                invoiceDAO.add7upProduct(new DatabaseClass.s7upDTO(updates2L, updates1L, updates500ml, updates500mldiet, updates400ml, updates250mlpet, updates250mlGRB, updates200mlGRB, updates250mlCan));
                invoiceDAO.addPepsiProduct(new DatabaseClass.PepsiDTO(updatep2L, updatep1L, updatep500ml, updatep500mldiet, updatep400ml, updatep250mlpet, updatep250mlGRB, updatep200mlGRB, updatep250mlCan));
                invoiceDAO.addMirindaProduct(new DatabaseClass.MirindaDTO(updatem1L, updatem500ml, updatem250mlpet, updatem200mlGRB, updatem250mlCan));
                invoiceDAO.addDewProduct(new DatabaseClass.DewDTO(updated500ml, updated400ml, updated250mlpet, updated200mlGRB, updated250mlCan));
                invoiceDAO.addAquafinaProduct(new DatabaseClass.AquafinaDTO(updatea1500ml, updatea500ml));
                invoiceDAO.addSliceaProduct(new DatabaseClass.SliceDTO(updatesl250mlGRB));
                invoiceDAO.addInvoice(new DatabaseClass.InvoiceTransactionDTO(date, sellingCash, profitt, otherex, shortaz, invoiceID));
                // make pdf
                try
                {
                    DataTable dtbl = MakeDataTable();
                    ExportDataTableToPdf(dtbl, @"E:\Eashan.pdf", "Beverage Managment System");
                    System.Diagnostics.Process.Start(@"E:\Eashan.pdf");
                    this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message");
                }
               // MessageBox.Show(" Successfully Done ");
               // this.Hide();
            }
            else
            {
                MessageBox.Show(" Please check the all boxes ");
            }
        }

        public void TotalSellingCashCustomerRate()
        {
            //  7up selling cash  //
             solds2LTk = Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp2Lp"]) * solds2L;
             solds2LpTk = (Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp2Lp"]) / 6) * solds2Lp;


            solds1LTk = Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp1Lp"]) * solds1L;
            solds1LpTk = (Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp1Lp"]) / 12) * solds1Lp;

            solds500mlTk = Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp500mlp"])  * solds500ml;
            solds500mlpTk = (Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp500mlp"]) / 24) * solds500mlp;


            solds500mldietTk  = Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp500mldietp"]) * solds500mldiet;
            solds500mldietpTk = (Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp500mldietp"]) /24) * solds500mldietp;

            solds400mlTk = Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp400mlp"]) * solds400ml;
            solds400mlpTk = (Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp400mlp"])/24) * solds400mlp;

            solds250mlpetTk = Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp250mlpetp"]) * solds250mlpet;
            solds250mlpetpTk = ( Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp250mlpetp"])/24) * solds250mlpetp;

            solds250mlGRBTk = Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp250mlglassp"]) * solds250mlGRB;
            solds250mlGRBpTk = (Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp250mlglassp"])/24) * solds250mlGRBp;

            solds200mlGRBTk = Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp200mlglassp"]) * solds200mlGRB;
            solds200mlGRBpTk = (Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp200mlglassp"])/24) * solds200mlGRBp;

            solds250mlCanTk   = Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp250mlcanp"]) * solds250mlCan;
            solds250mlCanpTk = (Convert.ToInt32(beverageDAO.sUPPrice().Tables[0].Rows[0]["sUp250mlcanp"]) /24)* solds250mlCanp;
            //  7up selling cash //


            // Pepsi Selling Cash 
            soldp2LTk = Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi2Lp"]) * soldp2L;
            soldp2LpTk = (Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi2Lp"]) / 6) * soldp2Lp;


            soldp1LTk = Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi1Lp"]) * soldp1L;
            soldp1LpTk = (Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi1Lp"]) / 12) * soldp1Lp;

            soldp500mlTk = Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi500mlp"]) * soldp500ml;
            soldp500mlpTk = (Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi500mlp"]) / 24) * soldp500mlp;


            soldp500mldietTk = Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi500mldietp"]) * soldp500mldiet;
            soldp500mldietpTk = (Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi500mldietp"]) / 24) * soldp500mldietp;

            soldp400mlTk =    Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi400mlp"]) * soldp400ml;
            soldp400mlpTk =   (Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi400mlp"]) / 24) * soldp400mlp;

            soldp250mlpetTk =  Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi250mlpetp"]) * soldp250mlpet;
            soldp250mlpetpTk = (Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi250mlpetp"]) / 24) * soldp250mlpetp;

            soldp250mlGRBTk =  Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi250mlglassp"]) * soldp250mlGRB;
            soldp250mlGRBpTk = (Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi250mlglassp"]) / 24) * soldp250mlGRBp;

            soldp200mlGRBTk =  Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi200mlglassp"]) * soldp200mlGRB;
            soldp200mlGRBpTk = (Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi200mlglassp"]) / 24) * soldp200mlGRBp;

            soldp250mlCanTk =  Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi250mlcanp"]) * soldp250mlCan;
            soldp250mlCanpTk = (Convert.ToInt32(beverageDAO.PepsiPrice().Tables[0].Rows[0]["Psi250mlcanp"]) / 24) * soldp250mlCanp;
            //  Pepsi selling cash  //

           
            
            // Mirinda selling Cash 
            soldm1LTk = Convert.ToInt32(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda1Lp"]) * soldm1L;
            soldm1LpTk = (Convert.ToInt32(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda1Lp"])/12) * soldm1Lp;

            soldm500mlTk = Convert.ToInt32(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda500mlp"]) * soldm500ml;
            soldm500mlpTk = (Convert.ToInt32(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda500mlp"])/24) * soldm500mlp;

            soldm250mlpetTk = Convert.ToInt32(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda250mlpetp"]) * soldm250mlpet;
            soldm250mlpetpTk = (Convert.ToInt32(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda250mlpetp"]) /24) * soldm250mlpetp;

            soldm200mlGRBTk = Convert.ToInt32(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda200mlglassp"]) * soldm200mlGRB;
            soldm200mlGRBpTk = (Convert.ToInt32(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda200mlglassp"]) / 24) * soldm200mlGRBp;

            soldm250mlCanTk = Convert.ToInt32(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda250mlcanp"]) * soldm250mlCan;
            soldm250mlCanpTk = Convert.ToInt32(beverageDAO.MirindaPrice().Tables[0].Rows[0]["Mda250mlcanp"])/24 * soldm250mlCanp;
            // Mirinda selling Cash //


            // Dew selling Cash
            soldd400mlTk = Convert.ToInt32(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew400mlp"]) * soldd400ml;
            soldd400mlpTk = (Convert.ToInt32(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew400mlp"]) / 12) * soldd400mlp;

            soldd500mlTk = Convert.ToInt32(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew500mlp"]) * soldd500ml;
            soldd500mlpTk = (Convert.ToInt32(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew500mlp"]) / 24) * soldd500mlp;

            soldd250mlpetTk = Convert.ToInt32(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew250mlpetp"]) * soldd250mlpet;
            soldd250mlpetpTk = (Convert.ToInt32(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew250mlpetp"]) / 24) * soldd250mlpetp;

            soldd200mlGRBTk = Convert.ToInt32(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew200mlglassp"]) * soldd200mlGRB;
            soldd200mlGRBpTk = (Convert.ToInt32(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew200mlglassp"]) / 24) * soldd200mlGRBp;

            soldd250mlCanTk = Convert.ToInt32(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew250mlcanp"]) * soldd250mlCan;
            soldd250mlCanpTk = Convert.ToInt32(beverageDAO.DewPrice().Tables[0].Rows[0]["Dew250mlcanp"]) / 24 * soldd250mlCanp;
            // Dew selling Cash //

            // Aquafina selling Cash 
            solda1500mlTk = Convert.ToInt32(beverageDAO.AquafinaPrice().Tables[0].Rows[0]["Aqa1500mlp"]) * solda1500ml;
            solda1500mlpTk =( Convert.ToInt32(beverageDAO.AquafinaPrice().Tables[0].Rows[0]["Aqa1500mlp"]) /12)* solda1500mlp;


            solda500mlTk = Convert.ToInt32(beverageDAO.AquafinaPrice().Tables[0].Rows[0]["Aqa500mlp"]) * solda500ml;
            solda500mlpTk =  (Convert.ToInt32(beverageDAO.AquafinaPrice().Tables[0].Rows[0]["Aqa500mlp"])/24)  * solda500mlp;
            //Aquafina selling Cash 

            
            
            // Slice selling Cash
            soldsl250mlGRBTk =  Convert.ToInt32(beverageDAO.SlicePrice().Tables[0].Rows[0]["Slice250mlglassp"]) * soldsl250mlGRB;
            soldsl250mlGRBpTk = (Convert.ToInt32(beverageDAO.SlicePrice().Tables[0].Rows[0]["Slice250mlglassp"]) /24 ) * soldsl250mlGRBp;
            //Slice selling Cash 

            //total 7up selling cash 
            total7upCash = solds2LTk+ solds1LTk+ solds500mlTk+solds500mldietTk+solds400mlTk+solds250mlpetTk+solds250mlGRBTk+solds200mlGRBTk+solds250mlCanTk;
            total7upCash = total7upCash+solds2LpTk+solds1LpTk+solds500mlpTk+solds500mldietpTk+solds400mlpTk+solds250mlpetpTk+solds250mlGRBpTk+solds200mlGRBpTk+solds250mlCanpTk;

            // total Pepsi selling Cash
            totalPepsiCash = soldp2LTk+soldp1LTk+soldp500mlTk+soldp500mldietTk+soldp400mlTk+soldp250mlpetTk+soldp250mlGRBTk+soldp200mlGRBTk+soldp250mlCanTk;  
            totalPepsiCash = totalPepsiCash + soldp2LpTk+soldp1LpTk+soldp500mlpTk+soldp500mldietpTk+soldp400mlpTk+soldp250mlpetpTk+soldp250mlGRBpTk+soldp200mlGRBpTk+soldp250mlCanpTk;

            //total Mirinda selling Cash
            totalMirindaCash =  soldm1LTk+soldm500mlTk+soldm250mlpetTk+soldm200mlGRBTk+soldm250mlCanTk;  
            totalMirindaCash = totalMirindaCash + soldm1LpTk+soldm500mlpTk+soldm250mlpetpTk+soldm200mlGRBpTk+soldm250mlCanpTk;

            // total Dew  selling Cash
            totalDewCash =  soldd500mlTk+soldd400mlTk+soldd250mlpetTk+soldd200mlGRBTk+soldd250mlCanTk; 
            totalDewCash = totalDewCash + soldd500mlpTk+soldd400mlpTk+soldd250mlpetpTk+soldd200mlGRBpTk+soldd250mlCanpTk;

            // total Aquafina selling Cash         
            totalAquafinaCash =  solda1500mlTk+solda500mlTk;
            totalAquafinaCash = totalAquafinaCash + solda1500mlpTk+solda500mlpTk;

            // total Slice selling Cash
            totalSliceCash = soldsl250mlGRBTk; 
            totalSliceCash = totalSliceCash + soldsl250mlGRBpTk;


        }
        public void TotalSellingCashComapanyRate()
        {
          
                //  7up selling cash  //
                solds2LTk = Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp2Lp"]) * solds2L;
                solds2LpTk = (Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp2Lp"]) / 6) * solds2Lp;


                solds1LTk = Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp1Lp"]) * solds1L;
                solds1LpTk = (Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp1Lp"]) / 12) * solds1Lp;

                solds500mlTk = Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp500mlp"]) * solds500ml;
                solds500mlpTk = (Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp500mlp"]) / 24) * solds500mlp;


                solds500mldietTk = Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp500mldietp"]) * solds500mldiet;
                solds500mldietpTk = (Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp500mldietp"]) / 24) * solds500mldietp;

                solds400mlTk = Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp400ml"]) * solds400ml;
                solds400mlpTk = (Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp400ml"]) / 24) * solds400mlp;

                solds250mlpetTk = Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp250mlpetp"]) * solds250mlpet;
                solds250mlpetpTk = (Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp250mlpetp"]) / 24) * solds250mlpetp;

                solds250mlGRBTk = Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp250mlglassp"]) * solds250mlGRB;
                solds250mlGRBpTk = (Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp250mlglassp"]) / 24) * solds250mlGRBp;

                solds200mlGRBTk = Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp200mlglassp"]) * solds200mlGRB;
                solds200mlGRBpTk = (Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp200mlglassp"]) / 24) * solds200mlGRBp;

                solds250mlCanTk = Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp250mlcanp"]) * solds250mlCan;
                solds250mlCanpTk = (Convert.ToInt32(beverageDAO.CsUPPrice().Tables[0].Rows[0]["CsUp250mlcanp"]) / 24) * solds250mlCanp;
                //  7up selling cash //


                // Pepsi Selling Cash 
                soldp2LTk = Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi2Lp"]) * soldp2L;
                soldp2LpTk = (Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi2Lp"]) / 6) * soldp2Lp;


                soldp1LTk = Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi1Lp"]) * soldp1L;
                soldp1LpTk = (Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi1Lp"]) / 12) * soldp1Lp;

                soldp500mlTk = Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi500mlp"]) * soldp500ml;
                soldp500mlpTk = (Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi500mlp"]) / 24) * soldp500mlp;


                soldp500mldietTk = Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi500mldietp"]) * soldp500mldiet;
                soldp500mldietpTk = (Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi500mldietp"]) / 24) * soldp500mldietp;

                soldp400mlTk = Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi400mlp"]) * soldp400ml;
                soldp400mlpTk = (Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi400mlp"]) / 24) * soldp400mlp;

                soldp250mlpetTk = Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi250mlpetp"]) * soldp250mlpet;
                soldp250mlpetpTk = (Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi250mlpetp"]) / 24) * soldp250mlpetp;

                soldp250mlGRBTk = Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi250mlglassp"]) * soldp250mlGRB;
                soldp250mlGRBpTk = (Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi250mlglassp"]) / 24) * soldp250mlGRBp;

                soldp200mlGRBTk = Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi200mlglassp"]) * soldp200mlGRB;
                soldp200mlGRBpTk = (Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi200mlglassp"]) / 24) * soldp200mlGRBp;

                soldp250mlCanTk = Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi250mlcanp"]) * soldp250mlCan;
                soldp250mlCanpTk = (Convert.ToInt32(beverageDAO.CPepsiPrice().Tables[0].Rows[0]["CPepsi250mlcanp"]) / 24) * soldp250mlCanp;
                //  Pepsi selling cash  //



                // Mirinda selling Cash 
                soldm1LTk = Convert.ToInt32(beverageDAO.CMirindaPrice().Tables[0].Rows[0]["CMirinda1Lp"]) * soldm1L;
                soldm1LpTk = (Convert.ToInt32(beverageDAO.CMirindaPrice().Tables[0].Rows[0]["CMirinda1Lp"]) / 12) * soldm1Lp;

                soldm500mlTk = Convert.ToInt32(beverageDAO.CMirindaPrice().Tables[0].Rows[0]["CMirinda500mlp"]) * soldm500ml;
                soldm500mlpTk = (Convert.ToInt32(beverageDAO.CMirindaPrice().Tables[0].Rows[0]["CMirinda500mlp"]) / 24) * soldm500mlp;

                soldm250mlpetTk = Convert.ToInt32(beverageDAO.CMirindaPrice().Tables[0].Rows[0]["CMirinda250mlpetp"]) * soldm250mlpet;
                soldm250mlpetpTk = (Convert.ToInt32(beverageDAO.CMirindaPrice().Tables[0].Rows[0]["CMirinda250mlpetp"]) / 24) * soldm250mlpetp;

                soldm200mlGRBTk = Convert.ToInt32(beverageDAO.CMirindaPrice().Tables[0].Rows[0]["CMirinda200mlglassp"]) * soldm200mlGRB;
                soldm200mlGRBpTk = (Convert.ToInt32(beverageDAO.CMirindaPrice().Tables[0].Rows[0]["CMirinda200mlglassp"]) / 24) * soldm200mlGRBp;

                soldm250mlCanTk = Convert.ToInt32(beverageDAO.CMirindaPrice().Tables[0].Rows[0]["CMirinda250mlcanp"]) * soldm250mlCan;
                soldm250mlCanpTk = Convert.ToInt32(beverageDAO.CMirindaPrice().Tables[0].Rows[0]["CMirinda250mlcanp"]) / 24 * soldm250mlCanp;
                // Mirinda selling Cash //


                // Dew selling Cash
                soldd400mlTk = Convert.ToInt32(beverageDAO.CDewPrice().Tables[0].Rows[0]["CDew400mlp"]) * soldd400ml;
                soldd400mlpTk = (Convert.ToInt32(beverageDAO.CDewPrice().Tables[0].Rows[0]["CDew400mlp"]) / 12) * soldd400mlp;

                soldd500mlTk = Convert.ToInt32(beverageDAO.CDewPrice().Tables[0].Rows[0]["CDew500mlp"]) * soldd500ml;
                soldd500mlpTk = (Convert.ToInt32(beverageDAO.CDewPrice().Tables[0].Rows[0]["CDew500mlp"]) / 24) * soldd500mlp;

                soldd250mlpetTk = Convert.ToInt32(beverageDAO.CDewPrice().Tables[0].Rows[0]["CDew250mlpetp"]) * soldd250mlpet;
                soldd250mlpetpTk = (Convert.ToInt32(beverageDAO.CDewPrice().Tables[0].Rows[0]["CDew250mlpetp"]) / 24) * soldd250mlpetp;

                soldd200mlGRBTk = Convert.ToInt32(beverageDAO.CDewPrice().Tables[0].Rows[0]["CDew200mlglassp"]) * soldd200mlGRB;
                soldd200mlGRBpTk = (Convert.ToInt32(beverageDAO.CDewPrice().Tables[0].Rows[0]["CDew200mlglassp"]) / 24) * soldd200mlGRBp;

                soldd250mlCanTk = Convert.ToInt32(beverageDAO.CDewPrice().Tables[0].Rows[0]["CDew250mlcanp"]) * soldd250mlCan;
                soldd250mlCanpTk = Convert.ToInt32(beverageDAO.CDewPrice().Tables[0].Rows[0]["CDew250mlcanp"]) / 24 * soldd250mlCanp;
                // Dew selling Cash //

                // Aquafina selling Cash 
                solda1500mlTk = Convert.ToInt32(beverageDAO.CAquafinaPrice().Tables[0].Rows[0]["CAqa1500mlp"]) * solda1500ml;
                solda1500mlpTk = (Convert.ToInt32(beverageDAO.CAquafinaPrice().Tables[0].Rows[0]["CAqa1500mlp"]) / 12) * solda1500mlp;


                solda500mlTk = Convert.ToInt32(beverageDAO.CAquafinaPrice().Tables[0].Rows[0]["CAqa500mlp"]) * solda500ml;
                solda500mlpTk = (Convert.ToInt32(beverageDAO.CAquafinaPrice().Tables[0].Rows[0]["CAqa500mlp"]) / 24) * solda500mlp;
                //Aquafina selling Cash 



                // Slice selling Cash
                soldsl250mlGRBTk = Convert.ToInt32(beverageDAO.CSlicePrice().Tables[0].Rows[0]["CSlice250mlglassp"]) * soldsl250mlGRB;
                soldsl250mlGRBpTk = (Convert.ToInt32(beverageDAO.CSlicePrice().Tables[0].Rows[0]["CSlice250mlglassp"]) / 24) * soldsl250mlGRBp;
                //Slice selling Cash 

                //total 7up selling cash 
                total7upCash = solds2LTk + solds1LTk + solds500mlTk + solds500mldietTk + solds400mlTk + solds250mlpetTk + solds250mlGRBTk + solds200mlGRBTk + solds250mlCanTk;
                total7upCash = total7upCash + solds2LpTk + solds1LpTk + solds500mlpTk + solds500mldietpTk + solds400mlpTk + solds250mlpetpTk + solds250mlGRBpTk + solds200mlGRBpTk + solds250mlCanpTk;

                // total Pepsi selling Cash
                totalPepsiCash = soldp2LTk + soldp1LTk + soldp500mlTk + soldp500mldietTk + soldp400mlTk + soldp250mlpetTk + soldp250mlGRBTk + soldp200mlGRBTk + soldp250mlCanTk;
                totalPepsiCash = totalPepsiCash + soldp2LpTk + soldp1LpTk + soldp500mlpTk + soldp500mldietpTk + soldp400mlpTk + soldp250mlpetpTk + soldp250mlGRBpTk + soldp200mlGRBpTk + soldp250mlCanpTk;

                //total Mirinda selling Cash
                totalMirindaCash = soldm1LTk + soldm500mlTk + soldm250mlpetTk + soldm200mlGRBTk + soldm250mlCanTk;
                totalMirindaCash = totalMirindaCash + soldm1LpTk + soldm500mlpTk + soldm250mlpetpTk + soldm200mlGRBpTk + soldm250mlCanpTk;

                // total Dew  selling Cash
                totalDewCash = soldd500mlTk + soldd400mlTk + soldd250mlpetTk + soldd200mlGRBTk + soldd250mlCanTk;
                totalDewCash = totalDewCash + soldd500mlpTk + soldd400mlpTk + soldd250mlpetpTk + soldd200mlGRBpTk + soldd250mlCanpTk;

                // total Aquafina selling Cash         
                totalAquafinaCash = solda1500mlTk + solda500mlTk;
                totalAquafinaCash = totalAquafinaCash + solda1500mlpTk + solda500mlpTk;

                // total Slice selling Cash
                totalSliceCash = soldsl250mlGRBTk;
                totalSliceCash = totalSliceCash + soldsl250mlGRBpTk;


            
        }
        public void updatesoldProductQuantity()
        {
            //update 7up product 

            updates2L =   Convert.ToInt32(beverageDAO.sUP().Tables[0].Rows[0]["sUp2L"]) - solds2L;
            updates1L =   Convert.ToInt32(beverageDAO.sUP().Tables[0].Rows[0]["sUp1L"])  - solds1L;
            updates500ml =  Convert.ToInt32(beverageDAO.sUP().Tables[0].Rows[0]["sUp500ml"]) - solds500ml;
            updates500mldiet =   Convert.ToInt32(beverageDAO.sUP().Tables[0].Rows[0]["sUp500mldiet"]) - solds500mldiet;
            updates400ml =   Convert.ToInt32(beverageDAO.sUP().Tables[0].Rows[0]["sUp400ml"]) - solds400ml;
            updates250mlpet =   Convert.ToInt32(beverageDAO.sUP().Tables[0].Rows[0]["sUp250pet"]) - solds250mlpet;
            updates250mlGRB =  Convert.ToInt32(beverageDAO.sUP().Tables[0].Rows[0]["sUp250mlGlass"]) - solds250mlGRB;
            updates200mlGRB =   Convert.ToInt32(beverageDAO.sUP().Tables[0].Rows[0]["sUp200mlGlass"]) - solds200mlGRB;
            updates250mlCan =   Convert.ToInt32(beverageDAO.sUP().Tables[0].Rows[0]["sUp250mlCan"]) - solds250mlCan;
            //                                                            xxxxx            ////

            // update Pepsi Product 
            //look herer some confussion 
            updatep2L = Convert.ToInt32(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi2L"]) - soldp2L   ;
            updatep1L =  Convert.ToInt32(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi1L"])  -soldp1L  ;
            soldp500ml = Convert.ToInt32(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi500ml"]) - soldp500ml ;
            updatep500mldiet = Convert.ToInt32(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi500mlDiet"]) - soldp500mldiet  ;
            updatep400ml =  Convert.ToInt32(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi400ml"]) -soldp400ml ;
            updatep250mlpet =  Convert.ToInt32(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi250mlPet"])  - soldp250mlpet  ;
            updatep250mlGRB =  Convert.ToInt32(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi250mlGlass"]) -soldp250mlGRB ;
            updatep200mlGRB =  Convert.ToInt32(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi200mlGlass"]) - soldp200mlGRB ;
            updatep250mlCan =  Convert.ToInt32(beverageDAO.Pepsi().Tables[0].Rows[0]["Psi250mlCan"])   - soldp250mlCan ;

            //                                                          xxxxx               ////

            // update Mirinda Product 

            updatem1L =   Convert.ToInt32(beverageDAO.Mirinda().Tables[0].Rows[0]["Mda1L"]) - soldm1L;
            updatem500ml =   Convert.ToInt32(beverageDAO.Mirinda().Tables[0].Rows[0]["Mda500ml"]) - soldm500ml;
            updatem250mlpet =  Convert.ToInt32(beverageDAO.Mirinda().Tables[0].Rows[0]["Mda250mlPet"]) - soldm250mlpet;
            updatem200mlGRB =   Convert.ToInt32(beverageDAO.Mirinda().Tables[0].Rows[0]["Mda200mlGlass"])- soldm200mlGRB;
            updatem250mlCan =  Convert.ToInt32(beverageDAO.Mirinda().Tables[0].Rows[0]["Mda250mlCan"]) - soldm250mlCan;
            //                                                          xxxxx               ////


            // update Dew Product 

            updated500ml =  Convert.ToInt32(beverageDAO.Dew().Tables[0].Rows[0]["Dew500ml"]) - soldd500ml;
            updated400ml =   Convert.ToInt32(beverageDAO.Dew().Tables[0].Rows[0]["Dew400ml"]) - soldd400ml;
            updated250mlpet =  Convert.ToInt32(beverageDAO.Dew().Tables[0].Rows[0]["Dew250mlPet"]) - soldd250mlpet;
            updated200mlGRB =   Convert.ToInt32(beverageDAO.Dew().Tables[0].Rows[0]["Dew200mlGlass"]) - soldd200mlGRB;
            updated250mlCan =   Convert.ToInt32(beverageDAO.Dew().Tables[0].Rows[0]["Dew250mlCan"]) - soldd250mlCan;
            //                                                          xxxxx              ////

            // update Aquafina Product 

            updatea1500ml =   Convert.ToInt32(beverageDAO.Aquafina().Tables[0].Rows[0]["AF1500ml"]) -solda1500ml;
            updatea500ml =   Convert.ToInt32(beverageDAO.Aquafina().Tables[0].Rows[0]["AF500ml"]) - solda500ml;
            //                                                          xxxxx             ////

            // update Slice Product 

            updatesl250mlGRB = Convert.ToInt32(beverageDAO.Slice().Tables[0].Rows[0]["Slice250mlGlass"]) - soldsl250mlGRB;
        }

        // get DElivery Product Quantity
        public void getDelivery7upProductQuantity()
        {
            s2L = Convert.ToInt32(deliverys2LTx.Text);
            s1L = Convert.ToInt32(deliverys1LTx.Text);
            s500ml = Convert.ToInt32(deliverys500mlTx.Text);
            s500mldiet = Convert.ToInt32(deliverys500mldietTx.Text);
            s400ml = Convert.ToInt32(deliverys400mlTx.Text);
            s250mlpet = Convert.ToInt32(deliverys250mlpetTx.Text);
            s250mlGRB = Convert.ToInt32(deliverys250mlGRBTx.Text);
            s200mlGRB = Convert.ToInt32(deliverys200mlGRBTx.Text);
            s250mlCan = Convert.ToInt32(deliverys250mlCanTx.Text);
        }
        public void getDeliveryPepsiProductQuantity()
        {
            p2L = Convert.ToInt32(deliveryp2LTx.Text);
            p1L= Convert.ToInt32(deliveryp1LTx.Text);
            p500ml = Convert.ToInt32(deliveryp500mlTx.Text);
            p500mldiet = Convert.ToInt32(deliveryp500mldietTx.Text);
            p400ml = Convert.ToInt32(deliveryp400mlTx.Text);
            p250mlpet = Convert.ToInt32(deliveryp250mlpetTx.Text);
            p250mlGRB = Convert.ToInt32(deliveryp250mlGRBTx.Text);
            p200mlGRB = Convert.ToInt32(deliveryp200mlGRBTx.Text);
            p250mlCan = Convert.ToInt32(deliveryp250mlCanTx.Text);


        }
        public void getDeliveryMirindaProductQuantity()
        {
            m1L = Convert.ToInt32(deliverym1LTx.Text);
            m500ml = Convert.ToInt32(deliverym500mlTx.Text);
            m250mlpet = Convert.ToInt32(deliverym250mlpetTx.Text);
            m200mlGRB = Convert.ToInt32(deliverym200mlGRBTx.Text);
            m250mlCan = Convert.ToInt32(deliverym250mlCanTx.Text);

        }
        public void getDeliveryDewProductQuantity()
        {
            d400ml = Convert.ToInt32(deliveryd400mlTx.Text);
            d500ml = Convert.ToInt32(deliveryd500mlTx.Text);
            d250mlpet = Convert.ToInt32(deliveryd250mlpetTx.Text);
            d200mlGRB = Convert.ToInt32(deliveryd200mlGRBTx.Text);
            d250mlCan = Convert.ToInt32(deliveryd250mlCanTx.Text);
        }

        public void getDeliveryAquafinaProductQuantity()
        {
            a1500ml = Convert.ToInt32(deliverya1500mlTx.Text);
            a500ml = Convert.ToInt32(deliverya500mlTx.Text);
        }
        public void getDeliverySliceProductQuantity()
        {
            sl250mlGRB = Convert.ToInt32(deliverysl250mlGRBTx.Text);
        }

        //
        public void getReturn7upProductQuantity()
        {   // Case Quantity
            returns2L = Convert.ToInt32(returns7up2LTx.Text);
            returns1L = Convert.ToInt32(returns7up1LTx.Text);
            returns500ml = Convert.ToInt32(returns7up500mlTx.Text);
            returns500mldiet = Convert.ToInt32(returns7up500mldietTx.Text);
            returns400ml = Convert.ToInt32(returns7up400mlTx.Text);
            returns250mlpet = Convert.ToInt32(returns7up250mlpetTx.Text);
            returns250mlGRB = Convert.ToInt32(returns7up250mlGRBTx.Text);
            returns200mlGRB = Convert.ToInt32(returns7up200mlGRBTx.Text);
            returns250mlCan = Convert.ToInt32(returns7up250mlCanTx.Text);
             
            // Piece Quantity


            returns2Lp = Convert.ToInt32(returns7up2LpTx.Text);
            returns1Lp = Convert.ToInt32(returns7up1LpTx.Text);
            returns500mlp = Convert.ToInt32(returns7up500mlpTx.Text);
            returns500mldietp = Convert.ToInt32(returns7up500mldietpTx.Text);
            returns400mlp = Convert.ToInt32(returns7up400mlpTx.Text);
            returns250mlpetp = Convert.ToInt32(returns7up250mlpetpTx.Text);
            returns250mlGRBp = Convert.ToInt32(returns7up250mlGRBpTx.Text);
            returns200mlGRBp = Convert.ToInt32(returns7up200mlGRBpTx.Text);
            returns250mlCanp = Convert.ToInt32(returns7up250mlCanpTx.Text);
        }

        public void getReturnPepsiProductQuantity()
        {
            // Case Quantity
            returnp2L = Convert.ToInt32(returnPepsi2LTx.Text);
            returnp1L = Convert.ToInt32(returnPepsi1LTx.Text);
            returnp500ml = Convert.ToInt32(returnPepsi500mlTx.Text);
            returnp500mldiet = Convert.ToInt32(returnPepsi500mldietTx.Text);
            returnp400ml = Convert.ToInt32(returnPepsi400mlTx.Text);
            returnp250mlpet = Convert.ToInt32(returnPepsi250mlpetTx.Text);
            returnp250mlGRB = Convert.ToInt32(returnPepsi250mlGRBTx.Text);
            returnp200mlGRB = Convert.ToInt32(returnPepsi200mlGRBTx.Text);
            returnp250mlCan = Convert.ToInt32(returnPepsi250mlCanTx.Text);

            // Piece Quantity


            returnp2Lp = Convert.ToInt32(returnPepsi2LpTx.Text);
            returnp1Lp = Convert.ToInt32(returnPepsi1LpTx.Text);
            returnp500mlp = Convert.ToInt32(returnPepsi500mlpTx.Text);
            returnp500mldietp = Convert.ToInt32(returnPepsi500mldietpTx.Text);
            returnp400mlp = Convert.ToInt32(returnPepsi400mlpTx.Text);
            returnp250mlpetp = Convert.ToInt32(returnPepsi250mlpetpTx.Text);
            returnp250mlGRBp = Convert.ToInt32(returnPepsi250mlGRBpTx.Text);
            returnp200mlGRBp = Convert.ToInt32(returnPepsi200mlGRBpTx.Text);
            returnp250mlCanp = Convert.ToInt32(returnPepsi250mlCanpTx.Text);
        }

        public void getReturnMirindaProductQuantity()
        {
            //case Quantity

            returnm1L = Convert.ToInt32(returnMirinda1LTx.Text);
            returnm500ml = Convert.ToInt32(returnMirinda500mlTx.Text);
            returnm250mlpet = Convert.ToInt32(returnMirinda250mlpetTx.Text);
            returnm200mlGRB = Convert.ToInt32(returnMirinda200mlGRBTx.Text);
            returnm250mlCan = Convert.ToInt32(returnMirinda250mlCanTx.Text);
            // Piece Quantity
            returnm1Lp = Convert.ToInt32(returnMirinda1LpTx.Text);
            returnm500mlp = Convert.ToInt32(returnMirinda500mlpTx.Text);
            returnm250mlpetp = Convert.ToInt32(returnMirinda250mlpetpTx.Text);
            returnm200mlGRBp = Convert.ToInt32(returnMirinda200mlGRBpTx.Text);
            returnm250mlCanp = Convert.ToInt32(returnMirinda250mlCanpTx.Text);
        }



        public void getReturnDewProductQuantity()
        {
            //case Quantity

            returnd400ml = Convert.ToInt32(returnDew400mlTx.Text);
            returnd500ml = Convert.ToInt32(returnDew500mlTx.Text);
            returnd250mlpet = Convert.ToInt32(returnDew250mlpetTx.Text);
            returnd200mlGRB = Convert.ToInt32(returnDew200mlGRBTx.Text);
            returnd250mlCan = Convert.ToInt32(returnDew250mlCanTx.Text);
            // Piece Quantity
            returnd400mlp = Convert.ToInt32(returnDew400mlpTx.Text);
            returnd500mlp = Convert.ToInt32(returnDew500mlpTx.Text);
            returnd250mlpetp = Convert.ToInt32(returnDew250mlpetpTx.Text);
            returnd200mlGRBp = Convert.ToInt32(returnDew200mlGRBpTx.Text);
            returnd250mlCanp = Convert.ToInt32(returnDew250mlCanpTx.Text);
        }


        public void getReturnSliceProductQuantity()
        {
            // Case  Quantity
            returnsl250mlGRB = Convert.ToInt32(returnSlice250mlGRBTx.Text);
            // Piece Quantity
            returnsl250mlGRBp = Convert.ToInt32(returnSlice250mlGRBpTx.Text);
        }



        public void getReturnAquafinaProductQuantity()
        {
            // Case  Quantity
            returna1500ml = Convert.ToInt32(returnAqufina1500mlTx.Text);
            returna500ml = Convert.ToInt32(returnAqufina500mlTx.Text);
            // Piece Quantity
            returna1500mlp = Convert.ToInt32(returnAqufina1500mlpTx.Text);
            returna500mlp = Convert.ToInt32(returnAqufina500mlpTx.Text);

        }

        // Sold 7up Product Quantity 
        public void sold7upProductQuantity()
        {
            if(returns2Lp>0)
            {
                solds2L = (s2L-returns2L)-1;
                solds2Lp = 6 - returns2Lp;
            }          
            else
            {
                solds2L = (s2L - returns2L);
                solds2Lp =  returns2Lp;
            }

            if (returns1Lp > 0)
            {
                solds1L = (s1L-returns1L)-1 ;
                solds1L = 12 - returns1Lp;
            }
            else
            {
                solds1L = (s1L - returns1L) ;
                solds1L =  returns1Lp;
            }

            if (returns500ml > 0)
            {
                solds500ml = (s500ml - returns500ml) - 1;
                solds500mlp = 24 - returns500mlp;
            }
            else
            {
                solds500ml = (s500ml-returns500ml);
                solds500mlp = returns500mlp;
            }

            if (returns500mldietp > 0)
            {
                solds500mldiet = (s500mldiet - returns500mldiet) - 1;
                solds500mldietp = 24 - returns500mldietp;
            }
            else
            {
                solds500mldiet = (s500mldiet - returns500mldiet);
                solds500mldietp = returns500mldietp;
            }

            if (returns400mlp>0)
            {
                solds400ml = (s400ml - returns400ml )-1;
                solds400mlp = 24 - returns400mlp;
            }
            else
            {
                solds400ml = (s400ml - returns400ml);
                solds400mlp = returns400mlp;
            }


            if (returns250mlpetp>0)
            {
                solds250mlpet = (s250mlpet - returns250mlpet) - 1;
                solds250mlpetp = 24 - returns250mlpetp;
            }
            else
            {
                solds250mlpet = (s250mlpet - returns250mlpet);
                solds250mlpetp = returns250mlpetp;
            }

            if (returns250mlGRBp>0)
            {
                solds250mlGRB = (s250mlGRB - returns250mlGRB) - 1;
                solds250mlGRBp = (24- returns250mlGRBp);
            }
            else
            {
                solds250mlGRB = (s250mlGRB - returns250mlGRB);
                solds250mlGRBp = (returns250mlGRBp);
            }


            if (returns200mlGRBp > 0)
            {
                solds200mlGRB = (s200mlGRB - returns200mlGRB) - 1;
                solds200mlGRBp = (24 - returns200mlGRBp);
            }
            else
            {
                solds200mlGRB = (s200mlGRB - returns200mlGRB);
                solds200mlGRBp = (returns200mlGRBp);
            }

            if (returns250mlCanp>0)
            {
                solds250mlCan = (s250mlCan - returns250mlCan) - 1;
                solds250mlCanp = 24 - returns250mlCanp;
            }
            else
            {
                solds250mlCan = (s250mlCan - returns250mlCan);
                solds250mlCanp = returns250mlCanp;
            }
        }
        // Pepsi sold Quantity
        public void soldPepsiProductQuantity()
        {
            if (returnp2Lp > 0)
            {
                soldp2L = (p2L - returnp2L) - 1;
                soldp2Lp = 6 - returnp2Lp;
            }
            else
            {
                soldp2L = (p2L - returnp2L);
                soldp2Lp = returnp2Lp;
            }

            if (returnp1Lp > 0)
            {
                soldp1L = (p1L - returnp1L) - 1;
                soldp1L = 12 - returnp1Lp;
            }
            else
            {
                soldp1L = (p1L - returnp1L);
                soldp1L = returnp1Lp;
            }

            if (returnp500ml > 0)
            {
                soldp500ml = (p500ml - returnp500ml) - 1;
                soldp500mlp = 24 - returnp500mlp;
            }
            else
            {
                soldp500ml = (p500ml - returnp500ml);
                soldp500mlp = returnp500mlp;
            }

            if (returnp500mldietp > 0)
            {
                soldp500mldiet = (p500mldiet - returnp500mldiet) - 1;
                soldp500mldietp = 24 - returnp500mldietp;
            }
            else
            {
                soldp500mldiet = (p500mldiet - returnp500mldiet);
                soldp500mldietp = returnp500mldietp;
            }

            if (returnp400mlp > 0)
            {
                soldp400ml = (p400ml - returnp400ml) - 1;
                soldp400mlp = 24 - returnp400mlp;
            }
            else
            {
                soldp400ml = (p400ml - returnp400ml);
                soldp400mlp = returnp400mlp;
            }


            if (returnp250mlpetp > 0)
            {
                soldp250mlpet = (p250mlpet - returnp250mlpet) - 1;
                soldp250mlpetp = 24 - returnp250mlpetp;
            }
            else
            {
                soldp250mlpet = (p250mlpet - returnp250mlpet);
                soldp250mlpetp = returnp250mlpetp;
            }

            if (returnp250mlGRBp > 0)
            {
                soldp250mlGRB = (p250mlGRB - returnp250mlGRB) - 1;
                soldp250mlGRBp = (24 - returnp250mlGRBp);
            }
            else
            {
                soldp250mlGRB = (p250mlGRB - returnp250mlGRB);
                soldp250mlGRBp = (returnp250mlGRBp);
            }


            if (returnp200mlGRBp > 0)
            {
                soldp200mlGRB = (p200mlGRB - returnp200mlGRB) - 1;
                soldp200mlGRBp = (24 - returnp200mlGRBp);
            }
            else
            {
                soldp200mlGRB = (p200mlGRB - returnp200mlGRB);
                soldp200mlGRBp = (returnp200mlGRBp);
            }

            if (returnp250mlCanp > 0)
            {
                soldp250mlCan = (p250mlCan - returnp250mlCan) - 1;
                soldp250mlCanp = 24 - returnp250mlCanp;
            }
            else
            {
                soldp250mlCan = (p250mlCan - returnp250mlCan);
                soldp250mlCanp = returnp250mlCanp;
            }

        }

        // Sold Mirinda Product Quantity
        public void soldMirindaProductQuantity()
        {
            if (returnm1Lp > 0)
            {
                soldm1L = (m1L - returnm1L) - 1;
                soldm1L = 12 - returnm1Lp;
            }
            else
            {
                soldm1L = (m1L - returnm1L);
                soldm1L = returnm1Lp;
            }

            if (returnm500ml > 0)
            {
                soldm500ml = (m500ml - returnm500ml) - 1;
                soldm500mlp = 24 - returnm500mlp;
            }
            else
            {
                soldm500ml = (m500ml - returnm500ml);
                soldm500mlp = returnm500mlp;
            }
            if (returnm250mlpetp > 0)
            {
                soldm250mlpet = (m250mlpet - returnm250mlpet) - 1;
                soldm250mlpetp = 24 - returnm250mlpetp;
            }
            else
            {
                soldm250mlpet = (m250mlpet - returnm250mlpet);
                soldm250mlpetp = returnm250mlpetp;
            }
            if (returnm200mlGRBp > 0)
            {
                soldm200mlGRB = (m200mlGRB - returnm200mlGRB) - 1;
                soldm200mlGRBp = (24 - returnm200mlGRBp);
            }
            else
            {
                soldm200mlGRB = (m200mlGRB - returnm200mlGRB);
                soldm200mlGRBp = (returnm200mlGRBp);
            }

            if (returnm250mlCanp > 0)
            {
                soldm250mlCan = (m250mlCan - returnm250mlCan) - 1;
                soldm250mlCanp = 24 - returnm250mlCanp;
            }
            else
            {
                soldm250mlCan = (m250mlCan - returnm250mlCan);
                soldm250mlCanp = returnm250mlCanp;
            }

        }

        // Sold Dew Product Quantity 
        public void soldDewProductQuantity()
        {
            if (returnd400mlp > 0)
            {
                soldd400ml = (d400ml - returnd400ml) - 1;
                soldd400mlp = 24 - returnd400mlp;
            }
            else
            {
                soldd400ml = (d400ml - returnd400ml);
                soldd400mlp =  returnd400mlp;
            }

            if (returnd500ml > 0)
            {
                soldd500ml = (d500ml - returnd500ml) - 1;
                soldd500mlp = 24 - returnd500mlp;
            }
            else
            {
                soldd500ml = (d500ml - returnd500ml);
                soldd500mlp = returnd500mlp;
            }
            if (returnd250mlpetp > 0)
            {
                soldd250mlpet = (d250mlpet - returnd250mlpet) - 1;
                soldd250mlpetp = 24 - returnd250mlpetp;
            }
            else
            {
                soldd250mlpet = (d250mlpet - returnd250mlpet);
                soldd250mlpetp = returnd250mlpetp;
            }
            if (returnd200mlGRBp > 0)
            {
                soldd200mlGRB = (d200mlGRB - returnd200mlGRB) - 1;
                soldd200mlGRBp = (24 - returnd200mlGRBp);
            }
            else
            {
                soldd200mlGRB = (d200mlGRB - returnd200mlGRB);
                soldd200mlGRBp = (returnd200mlGRBp);
            }

            if (returnd250mlCanp > 0)
            {
                soldd250mlCan = (d250mlCan - returnd250mlCan) - 1;
                soldd250mlCanp = 24 - returnd250mlCanp;
            }
            else
            {
                soldm250mlCan = (m250mlCan - returnm250mlCan);
                soldm250mlCanp = returnm250mlCanp;
            }
        }

        // Sold Aquafina Product Quantity
        public void soldAquafinaProductQuantity()
        {
            if (returna1500mlp > 0)
            {
                solda1500ml = (a1500ml - returna1500ml) - 1;
                solda1500ml = 24 - returna1500mlp;
            }
            else
            {
                solda1500ml = (a1500ml - returna1500ml);
                solda1500ml = returna1500mlp;
            }

            if (returna500mlp > 0)
            {
                solda500ml = (a500ml - returna500ml) - 1;
                solda500ml = 24 - returna500mlp;
            }
            else
            {
                solda500ml = (a500ml - returna500ml);
                solda500ml = returna500mlp;
            }

        }


        public void soldSliceProductQuantity()
        {
            if (returnsl250mlGRBp>0)
            {
                soldsl250mlGRB = (sl250mlGRB - returnsl250mlGRB) - 1;
                soldsl250mlGRBp = 24 - returnsl250mlGRBp;
            }
            else
            {
                soldsl250mlGRB = (sl250mlGRB - returnsl250mlGRB);
                soldsl250mlGRBp = returnsl250mlGRBp;

            }
        }


        public void sold7upSetProductQuantity()
        {
            solds7up2LTx.Text = Convert.ToString(solds2L);
            solds7up2LpTx.Text = Convert.ToString(solds2Lp);

            solds7up1LTx.Text = Convert.ToString(solds1L);
            solds7up1LpTx.Text = Convert.ToString(solds1Lp);

            solds7up500mlTx.Text = Convert.ToString(solds500ml);
            solds7up500mlpTx.Text = Convert.ToString(solds500mlp);

            solds7up500mldietTx.Text = Convert.ToString(solds500mldiet);
            solds7up500mldietpTx.Text = Convert.ToString(solds500mldietp);

            solds7up400mlTx.Text = Convert.ToString(solds400ml);
            solds7up400mlpTx.Text = Convert.ToString(solds400mlp);

            solds7up250mlpetTx.Text = Convert.ToString(solds250mlpet);
            solds7up250mlpetpTx.Text = Convert.ToString(solds250mlpetp);

            solds7up250mlGRBTx.Text = Convert.ToString(solds250mlGRB);
            solds7up250mlGRBpTx.Text = Convert.ToString(solds250mlGRBp);

            solds7up200mlGRBTx.Text = Convert.ToString(solds200mlGRB);
            solds7up200mlGRBpTx.Text = Convert.ToString(solds200mlGRBp);

            solds7up250mlCanTx.Text = Convert.ToString(solds250mlCan);
            solds7up250mlCanpTx.Text = Convert.ToString(solds250mlCanp);

        }
        public void soldPepsiSetProductQuantity()
        {
            soldPepsi2LTx.Text = Convert.ToString(soldp2L);
            soldPepsi2LpTx.Text = Convert.ToString(soldp2Lp);

            soldPepsi1LTx.Text = Convert.ToString(soldp1L);
            soldPepsi1LpTx.Text = Convert.ToString(soldp1Lp);

            soldPepsi500mlTx.Text = Convert.ToString(soldp500ml);
            soldPepsi500mlpTx.Text = Convert.ToString(soldp500mlp);

            soldPepsi500mldietTx.Text = Convert.ToString(soldp500mldiet);
            soldPepsi500mldietpTx.Text = Convert.ToString(soldp500mldietp);

            soldPepsi400mlTx.Text = Convert.ToString(soldp400ml);
            soldPepsi400mlpTx.Text = Convert.ToString(soldp400mlp);

            soldPepsi250mlpetTx.Text = Convert.ToString(soldp250mlpet);
            soldPepsi250mlpetpTx.Text = Convert.ToString(soldp250mlpetp);

            soldPepsi250mlGRBTx.Text = Convert.ToString(soldp250mlGRB);
            soldPepsi250mlGRBpTx.Text = Convert.ToString(soldp250mlGRBp);

            soldPepsi200mlGRBTx.Text = Convert.ToString(soldp200mlGRB);
            soldPepsi200mlGRBpTx.Text = Convert.ToString(soldp200mlGRBp);

            soldPepsi250mlCanTx.Text = Convert.ToString(soldp250mlCan);
            soldPepsi250mlCanpTx.Text = Convert.ToString(soldp250mlCanp);
        }
        public void soldMirindaSetProductQuantity()
        {
            soldMirinda1LTx.Text = Convert.ToString(soldm1L);
            soldMirinda1LpTx.Text = Convert.ToString(soldm1Lp);

            soldMirinda500mlTx.Text = Convert.ToString(soldm500ml);
            soldMirinda500mlpTx.Text = Convert.ToString(soldm500mlp);

            soldMirinda250mlpetTx.Text = Convert.ToString(soldm250mlpet);
            soldMirinda250mlpetpTx.Text = Convert.ToString(soldm250mlpetp);

            soldMirinda200mlGRBTx.Text = Convert.ToString(soldm200mlGRB);
            soldMirinda200mlGRBpTx.Text = Convert.ToString(soldm200mlGRBp);

            soldMirinda250mlCanTx.Text = Convert.ToString(soldm250mlCan);
            soldMirinda250mlCanTx.Text = Convert.ToString(soldm250mlCanp);
        }
        public void soldDewSetProductQuantity()
        {
            soldDew400mlTx.Text = Convert.ToString(soldd400ml);
            soldDew400mlpTx.Text = Convert.ToString(soldd400mlp);

            soldDew500mlTx.Text = Convert.ToString(soldd500ml);
            soldDew500mlpTx.Text = Convert.ToString(soldd500mlp);

            soldDew250mlpetTx.Text = Convert.ToString(soldd250mlpet);
            soldDew250mlpetpTx.Text = Convert.ToString(soldd250mlpetp);

            soldDew200mlGRBTx.Text = Convert.ToString(soldd200mlGRB);
            soldDew200mlGRBpTx.Text = Convert.ToString(soldd200mlGRBp);

            soldDew250mlCanTx.Text = Convert.ToString(soldd250mlCan);
            soldDew250mlCanpTx.Text = Convert.ToString(soldd250mlCanp);

        }
        public void soldAquafinaSetProductQuantity()
        {
            soldAquafina1500mlTx.Text = Convert.ToString(solda1500ml);
            soldAquafina1500mlpTx.Text = Convert.ToString(solda1500mlp);

            soldAquafina500mlpTx.Text = Convert.ToString(solda500ml);
            soldAquafina500mlpTx.Text = Convert.ToString(solda500mlp);
        }
        public void soldSliceSetProductQuantity()
        {
            soldSlice250mlGRBTx.Text = Convert.ToString(soldsl250mlGRB);
            soldSlice250mlGRBpTx.Text = Convert.ToString(soldsl250mlGRBp);
        }


        // MAking PDF 

        DataTable MakeDataTable()
        {
            //Create friend table object
            DataTable friend = new DataTable();

            //Define columns
            friend.Columns.Add("Product Name");
            friend.Columns.Add("Delivery");
            friend.Columns.Add("Return");
            friend.Columns.Add("Sold");

            //Populate with friends :)
            friend.Rows.Add("7UP 2L",            deliverys2LTx.Text,returns7up2LTx.Text + " case" + returns7up2LpTx.Text + " pcs", solds7up2LTx.Text + " case" + solds7up2LpTx.Text + " pcs");
            friend.Rows.Add("7UP 1L",            deliverys1LTx.Text,returns7up1LTx.Text + " case" + returns7up1LpTx.Text + " pcs", solds7up1LTx.Text + " case" + solds7up1LpTx.Text + " pcs");
            friend.Rows.Add("7UP 500ml",         deliverys500mlTx.Text,returns7up500mlTx.Text + " case" + returns7up500mlpTx.Text + " pcs", solds7up500mlTx.Text + " case" + solds7up500mlpTx.Text + " pcs");
            friend.Rows.Add("7UP 500ml Diet",    deliverys500mldietTx.Text,returns7up500mldietTx.Text + " case" + returns7up500mldietpTx.Text + " pcs", solds7up500mldietTx.Text + " case" + solds7up500mldietpTx.Text + " pcs");
            friend.Rows.Add("7UP 400ml",         deliverys400mlTx.Text,returns7up400mlTx.Text + " case" + returns7up400mlpTx.Text + " pcs", solds7up400mlTx.Text + " case" + "Pieces");
            friend.Rows.Add("7UP 200ml Pet",     deliverys250mlpetTx.Text,returns7up250mlpetTx.Text + " case" + returns7up250mlpetpTx.Text + " pcs", solds7up250mlpetTx.Text + " case" + solds7up250mlpetpTx.Text + " pcs");
            friend.Rows.Add("7UP 250ml GRB",     deliverys250mlGRBTx.Text,returns7up250mlGRBTx.Text + " case" + returns7up250mlGRBpTx.Text + " pcs", solds7up250mlGRBTx.Text + " case" + solds7up250mlGRBpTx.Text + " pcs");
            friend.Rows.Add("7UP 200ml GRB",     deliverys200mlGRBTx.Text,returns7up200mlGRBTx.Text + " case" + returns7up200mlGRBpTx.Text + " pcs", solds7up200mlGRBTx.Text + " case" + solds7up200mlGRBpTx.Text + " pcs");
            friend.Rows.Add("7UP 250ml CAN",     deliverys250mlCanTx.Text,returns7up250mlCanTx.Text + " case" + returns7up250mlCanpTx.Text + " pcs", solds7up250mlCanTx.Text + " case" + solds7up250mlCanpTx.Text + " pcs");
            friend.Rows.Add("Pepsi 2L",          deliveryp2LTx.Text,returnPepsi2LTx.Text + " case" + returnPepsi2LpTx.Text + " pcs", soldPepsi2LTx.Text + " case" + soldPepsi2LpTx.Text + " pcs");
            friend.Rows.Add("Pepsi 1L",          deliveryp1LTx.Text,returnPepsi1LTx.Text + " case" + returnPepsi1LpTx.Text + " pcs", soldPepsi500mlTx.Text + " case" + soldPepsi500mlpTx.Text + " pcs");
            friend.Rows.Add("Pepsi 500ml",       deliveryp500mlTx.Text,returnPepsi500mlTx.Text + " case" + returnPepsi500mlpTx.Text + " pcs", soldPepsi500mldietTx.Text + " case" + soldPepsi500mldietpTx.Text + " pcs");
            friend.Rows.Add("Pepsi 500ml Diet",  deliveryp500mldietTx.Text, returnPepsi500mldietTx.Text + " case" + returnPepsi500mldietpTx.Text + " pcs", soldPepsi500mldietTx.Text + " case" + soldPepsi500mldietpTx.Text + " pcs");
            friend.Rows.Add("Pepsi 400ml",       deliveryp400mlTx.Text,returnPepsi400mlTx.Text + " case" + returnPepsi400mlpTx.Text + " pcs", soldPepsi400mlTx.Text + " case" + soldPepsi400mlpTx.Text + " pcs");
            friend.Rows.Add("Pepsi 200ml Pet",   deliveryp250mlpetTx.Text,returnPepsi250mlpetTx.Text + " case" + returnPepsi250mlpetpTx.Text + " pcs", soldPepsi250mlpetTx.Text + " case" + soldPepsi250mlpetpTx.Text + " pcs");
            friend.Rows.Add("Pepsi  250ml GRB",  deliveryp250mlGRBTx.Text,returnPepsi250mlGRBTx.Text + " case" + returnPepsi250mlGRBpTx.Text + " pcs", soldPepsi250mlGRBTx.Text + " case" + soldPepsi250mlGRBpTx.Text + " pcs");
            friend.Rows.Add("Pepsi 200ml GRB",   deliveryp200mlGRBTx.Text,returnPepsi200mlGRBTx.Text + " case" + returnPepsi200mlGRBpTx.Text + " pcs", soldPepsi200mlGRBTx.Text + " case" + soldPepsi200mlGRBpTx.Text + " pcs");
            friend.Rows.Add("Pepsi 250ml CAN",   deliveryp250mlCanTx.Text,returnPepsi250mlCanTx.Text + " case" + returnPepsi250mlCanpTx.Text + " pcs", soldPepsi250mlCanTx.Text + " case" + soldPepsi250mlCanpTx.Text + " pcs");
            friend.Rows.Add("Mirinda 1L",        deliverym1LTx.Text,returnMirinda1LTx.Text + " case" + returnMirinda1LpTx.Text + " pcs", soldMirinda1LTx.Text + " case" + soldMirinda1LTx.Text + " pcs");
            friend.Rows.Add("Mirinda 500ml",     deliverym500mlTx.Text,returnMirinda500mlTx.Text + " case" + returnMirinda500mlpTx.Text + " pcs", soldMirinda500mlTx.Text + " case" + soldMirinda500mlpTx.Text + "Pieces");
            friend.Rows.Add("Mirinda 250ml Pet", deliverym250mlpetTx.Text,returnMirinda250mlpetTx.Text + " case" + returnMirinda250mlpetpTx.Text + " pcs", soldMirinda250mlpetTx.Text + " case" + soldMirinda250mlpetpTx.Text + " pcs");
            friend.Rows.Add("Mirinda 200ml GRB", deliverym200mlGRBTx.Text,returnMirinda200mlGRBTx.Text + " case" + returnMirinda200mlGRBpTx.Text + " pcs", soldMirinda200mlGRBTx.Text + " case" + soldMirinda200mlGRBpTx.Text + " pcs");
            friend.Rows.Add("Mirinda 250ml CAN", deliverym250mlCanTx.Text,returnMirinda250mlCanTx.Text + " case" + returnMirinda250mlCanpTx.Text + " pcs", soldMirinda250mlCanTx.Text + " case" + soldMirinda250mlCanpTx.Text + " pcs");
            friend.Rows.Add("Dew 500ml",         deliveryd500mlTx.Text,returnDew500mlTx.Text + " case" + returnDew500mlpTx.Text + " pcs", soldDew500mlTx.Text + " case" + soldDew500mlpTx.Text + " pcs");
            friend.Rows.Add("Dew 400ml",         deliveryd400mlTx.Text,returnDew400mlTx.Text + " case" + returnDew400mlpTx.Text + " pcs", soldDew400mlTx.Text + " case" + soldDew400mlpTx.Text + " pcs");
            friend.Rows.Add("Dew 250ml Pet",     deliveryd250mlpetTx.Text,returnDew250mlpetTx.Text + " case" + returnDew250mlpetpTx.Text + " pcs", soldDew250mlpetTx.Text + " case" + soldDew250mlpetpTx.Text + " pcs");
            friend.Rows.Add("Dew 200ml GRB",     deliveryd200mlGRBTx.Text,returnDew200mlGRBTx.Text + " case" + returnDew200mlGRBpTx.Text + " pcs", soldDew200mlGRBTx.Text + " case" + soldDew200mlGRBpTx.Text + " pcs");
            friend.Rows.Add("Dew 250ml CAN",     deliveryd250mlCanTx.Text,returnDew250mlCanTx.Text + " case" + returnDew250mlCanpTx.Text + " pcs", soldDew250mlCanTx.Text + " case" + soldDew250mlCanpTx.Text + " pcs");
            friend.Rows.Add("Auafina 1500ML",    deliverya1500mlTx.Text,returnAqufina1500mlTx.Text + " case" + returnAqufina1500mlpTx.Text + " pcs", soldAquafina1500mlTx.Text + " case" + soldAquafina1500mlpTx.Text + " pcs");
            friend.Rows.Add("Auafina 500ML",     deliverya500mlTx.Text,returnAqufina500mlTx.Text + " case" + returnAqufina500mlpTx.Text + " pcs", soldAquafina500mlTx.Text + " case" + soldAquafina500mlpTx.Text + " pcs");
            friend.Rows.Add("Slice 250ml GRB",   deliverysl250mlGRBTx.Text, returnSlice250mlGRBTx.Text + " case" + returnSlice250mlGRBpTx.Text + " pcs", soldSlice250mlGRBTx.Text + " case" + soldSlice250mlGRBpTx.Text + " pcs");

            return friend;
        }

        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.Color.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 8, 2, iTextSharp.text.Color.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new Chunk("Company : Salehin Enterprise", fntAuthor));
            prgAuthor.Add(new Chunk("\nRun Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.Color.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 10, 1, iTextSharp.text.Color.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = iTextSharp.text.Color.GRAY;
                cell.AddElement(new Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }




















































   




    }
}
