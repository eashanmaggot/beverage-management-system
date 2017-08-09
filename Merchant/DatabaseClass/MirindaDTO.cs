using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant.DatabaseClass
{
    class MirindaDTO
    {
        private int m1L, m500ml, m250mlpet, m200mlGRB, m250mlCan;
        public MirindaDTO(int m1L, int m500ml, int m250mlpet, int m200mlGRB, int m250mlCan)
        {

            this.m500ml = m500ml;
            this.m250mlpet = m250mlpet;
            this.m200mlGRB = m200mlGRB;
            this.m250mlCan = m250mlCan;
            this.m1L = m1L;

        }

        public int M500ML
        {
            get { return m500ml; }
            set { m500ml = value; }
        }

        public int M1L
        {
            get { return m1L; }
            set { m1L = value; }
        }
        public int M250MLPET
        {
            get { return m250mlpet; }
            set { m250mlpet = value; }
        }

        public int M200MLGRB
        {
            get { return m200mlGRB; }
            set { m200mlGRB = value; }
        }

        public int M250MLCAN
        {
            get { return m250mlCan; }
            set { m250mlCan = value; }
        }
    }
}
