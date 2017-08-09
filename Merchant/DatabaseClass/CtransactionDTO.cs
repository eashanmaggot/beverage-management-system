using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant.DatabaseClass
{
    class CtransactionDTO
    {
        private int totalCase, chalanCost, laborCost, chalanID;
        private String date;

        public CtransactionDTO(int totalCase, int chalanCost, int laborCost, String date, int chalanID)
        {

            this.totalCase = totalCase;
            this.chalanCost = chalanCost;
            this.laborCost = laborCost;
            this.date = date;
            this.chalanID = chalanID;


        }

        public String DATE
        {
            get { return date; }
            set { date = value; }
        }

        public int TOTALCASE
        {
            get { return totalCase; }
            set { totalCase = value; }
        }
        public int LABORCOST
        {
            get { return laborCost; }
            set { laborCost = value; }
        }

        public int CHALANCOST
        {
            get { return chalanCost; }
            set { chalanCost = value; }
        }

        public int CHALANID
        {
            get
            {
                return chalanID;
            }

            set
            {
                chalanID = value;
            }
        }
    }
}
