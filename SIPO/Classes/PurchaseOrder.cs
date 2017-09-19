using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    class PurchaseOrder
    {
        private int po_id;
        private DateTime po_datetime;
        private int client_id;

        public int id { get { return this.po_id; } set { this.po_id = value; } }
        public DateTime datetime { get { return this.po_datetime; } set { this.po_datetime = value; } }
        public int clientID { get { return this.client_id; } set { this.client_id = value; } }
    }
}
