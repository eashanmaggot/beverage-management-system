using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant.DatabaseClass
{
    class s7upDTO
    {
        private int s2L, s1L, s500ml, s500mldiet, s400ml, s250mlpet, s250mlGRB, s200mlGRB, s250mlCan;
        private string name;

        public s7upDTO(int s2L, int s1L, int s500ml, int s500mldiet, int s400ml, int s250mlpet, int s250mlGRB, int s200mlGRB, int s250mlCan)
        {
            this.s2L = s2L;
            this.s1L = s1L;
            this.s500ml = s500ml;
            this.s500mldiet = s500mldiet;
            this.s400ml = s400ml;
            this.s250mlpet = s250mlpet;
            this.s250mlGRB = s250mlGRB;
            this.s200mlGRB = s200mlGRB;
            this.s250mlCan = s250mlCan;

        }

        public int S2L
        {
            get
            {
                return s2L;
            }
            set
            {
                s2L = value;
            }
        }

        public int S1L
        {
            get { return s1L; }
            set { s1L = value; }
        }

        public int S500ML
        {
            get { return s500ml; }
            set { s500ml = value; }
        }

        public int S500MLDIET
        {
            get { return s500mldiet; }
            set { s500mldiet = value; }
        }
        public int S400ML
        {
            get { return s400ml; }
            set { s400ml = value; }
        }
        public int S250MLPET
        {
            get { return s250mlpet; }
            set { s250mlpet = value; }
        }
        public int S250MLGRB
        {
            get { return s250mlGRB; }
            set { s250mlGRB = value; }
        }
        public int S200MLGRB
        {
            get { return s200mlGRB; }
            set { s200mlGRB = value; }
        }

        public int S250MLCAN
        {
            get { return s250mlCan; }
            set { s250mlCan = value; }
        }
    }
}
