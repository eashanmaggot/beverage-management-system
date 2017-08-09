using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merchant.DatabaseClass
{
    class SliceDTO
    {
        private int sl250mlGRB;

        public SliceDTO(int sl250mlGRB)
        {
            this.sl250mlGRB = sl250mlGRB;
        }
        public int SL250MLGRB
        {

            get
            {
                return sl250mlGRB;
            }
            set
            {
                sl250mlGRB = value;
            }
        }
    }
}
