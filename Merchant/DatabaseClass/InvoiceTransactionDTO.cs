using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant.DatabaseClass
{
    class InvoiceTransactionDTO
    {
        private int sellingCash, profit, otherExpense,shortage,id;
        private String date;

        public InvoiceTransactionDTO(String date, int sellingCash, int profit, int otherExpense, int shortage,int id)
        {
            this.date = date;
            this.sellingCash = sellingCash;
            this.profit = profit;
            this.otherExpense = otherExpense;
            this.shortage = shortage;
            this.id = id;

        }

        public String DATE
        {
            get { return date; }
            set { date = value; }
        }

        public int SELLINGCASH
        {
            get { return sellingCash; }
            set { sellingCash= value; }
        }
        public int PROFIT
        {
            get { return profit; }
            set { profit = value; }
        }

        public int OTHEREXPENSE
        {
            get { return otherExpense; }
            set { otherExpense= value; }
        }

        public int SHORTAGE
        {
            get
            {
                return shortage;
            }

            set
            {
                shortage = value;
            }
        }
        public int INVOICEID
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
