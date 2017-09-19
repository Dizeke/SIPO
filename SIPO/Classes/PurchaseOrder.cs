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
        private string po_datetime;
        private int po_client_id;

        public int id { get { return this.po_id; } set { this.po_id = value; } }
        public string datetime { get { return this.po_datetime; } set { this.po_datetime = value; } }
        public int client_id { get { return this.po_client_id; } set { this.po_client_id = value; } }
    }
}
