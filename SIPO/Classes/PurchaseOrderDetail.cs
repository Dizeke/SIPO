using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    class PurchaseOrderDetail
    {
        private int _po_id;
        private int _client_id;
        private string _client_company;
        private string _po_datetime;
        private double _total;
        private double _po_discount;
        private double _paid;
        private double _balance;

        public int po_id { get { return this._po_id; } set { this._po_id = value; } }
        public int client_id { get { return this._client_id; } set { this._client_id = value; } }
        public string client_company { get { return this._client_company; } set { this._client_company = value; } }
        public string po_datetime { get { return this._po_datetime; } set { this._po_datetime = value; } }
        public double total { get { return this._total; } set { this._total = value; } }
        public double po_discount { get { return this._po_discount; } set { this._po_discount = value; } }
        public double paid { get { return this._paid; } set { this._paid = value; } }
        public double balance { get { return this._balance; } set { this._balance = value; } }

    }
}
