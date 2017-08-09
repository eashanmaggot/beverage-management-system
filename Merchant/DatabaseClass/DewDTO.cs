using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant.DatabaseClass
{
    class DewDTO
    {
        private int d500ml, d400ml, d250mlpet, d200mlGRB, d250mlCan;

        public DewDTO(int d500ml, int d400ml, int d250mlpet, int d200mlGRB, int d250mlCan)
        {

            this.d500ml = d500ml;
            this.d400ml = d400ml;
            this.d250mlpet = d250mlpet;
            this.d200mlGRB = d200mlGRB;
            this.d250mlCan = d250mlCan;

        }

        public int D500ML
        {
            get { return d500ml; }
            set { d500ml = value; }
        }

        public int D400ML
        {
            get { return d400ml; }
            set { d400ml = value; }
        }
        public int D250MLPET
        {
            get { return d250mlpet; }
            set { d250mlpet = value; }
        }

        public int D200MLGRB
        {
            get { return d200mlGRB; }
            set { d200mlGRB = value; }
        }

        public int D250MLCAN
        {
            get { return d250mlCan; }
            set { d250mlCan = value; }
        }
    }
}
