using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    class PurchaseOrderPayment
    {
        private int _pop_id;
        private string _pop_datetime;
        private double _pop_amount;
        private int _po_id;

        public int pop_id { get { return this._pop_id; } set { this._pop_id = value; } }
        public string pop_datetime { get { return this._pop_datetime; } set { this._pop_datetime = value; } }
        public double pop_amount { get { return this._pop_amount; } set { this._pop_amount = value; } }
        public int po_id { get { return this._po_id; } set { this._po_id = value; } }
    }
}
