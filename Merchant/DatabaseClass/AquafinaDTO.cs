using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant.DatabaseClass
{
    class AquafinaDTO
    {
        private int a1500ml, a500ml;
        public AquafinaDTO(int a1500ml, int a500ml)
        {

            this.a1500ml = a1500ml;
            this.a500ml = a500ml;


        }
        public int A500ML
        {
            get { return a500ml; }
            set { a500ml = value; }
        }

        public int A1500ML
        {
            get { return a1500ml; }
            set { a1500ml = value; }
        }
    }
}
