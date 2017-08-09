using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant.DatabaseClass
{
    class PepsiDTO
    {
        private int p2L, p1L, p500ml, p500mldiet, p400ml, p250mlpet, p250mlGRB, p200mlGRB, p250mlCan; // Pepsi product Type 
        public PepsiDTO(int p2L, int p1L, int p500ml, int p500mldiet, int p400ml, int p250mlpet, int p250mlGRB, int p200mlGRB, int p250mlCan)
        {
            this.p2L = p2L;
            this.p1L = p1L;
            this.p500ml = p500ml;
            this.p500mldiet = p500mldiet;
            this.p400ml = p400ml;
            this.p250mlpet = p250mlpet;
            this.p250mlGRB = p250mlGRB;
            this.p200mlGRB = p200mlGRB;
            this.p250mlCan = p250mlCan;

        }

        public int P2L
        {
            get
            {
                return p2L;
            }
            set
            {
                p2L = value;
            }
        }

        public int P1L
        {
            get { return p1L; }
            set { p1L = value; }
        }

        public int P500ML
        {
            get { return p500ml; }
            set { p500ml = value; }
        }

        public int P500MLDIET
        {
            get { return p500mldiet; }
            set { p500mldiet = value; }
        }
        public int P400ML
        {
            get { return p400ml; }
            set { p400ml = value; }
        }
        public int P250MLPET
        {
            get { return p250mlpet; }
            set { p250mlpet = value; }
        }
        public int P250MLGRB
        {
            get { return p250mlGRB; }
            set { p250mlGRB = value; }
        }
        public int P200MLGRB
        {
            get { return p200mlGRB; }
            set { p200mlGRB = value; }
        }

        public int P250MLCAN
        {
            get { return p250mlCan; }
            set { p250mlCan = value; }
        }
    }
}
