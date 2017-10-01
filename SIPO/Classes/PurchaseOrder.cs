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
        private string po_payment;
        private string po_status;
        private int po_discount;
        private int po_discount_approved;
        private int po_client_id;

        public int id { get { return this.po_id; } set { this.po_id = value; } }
        public string datetime { get { return this.po_datetime; } set { this.po_datetime = value; } }
        public string payment { get { return this.po_payment; } set { this.po_payment = value; } }
        public string status { get { return this.po_status; } set { this.po_status = value; } }
        public int discount { get { return this.po_discount; } set { this.po_discount = value; } }
        public int discount_approved { get { return this.po_discount_approved; } set { this.po_discount_approved = value; } }
        public int client_id { get { return this.po_client_id; } set { this.po_client_id = value; } }

        private double po_total;
        private double po_discounted_total;

        public double total { get { return this.po_total; } set { this.po_total = value; } }
        public double discounted_total { get { return this.po_discounted_total; } set { this.discounted_total = value; } }
    }
}
