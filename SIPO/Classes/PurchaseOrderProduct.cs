﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    class PurchaseOrderProduct
    {
        private int pop_id;
        private int pop_prodf_id;
        private int pop_prodf_quantity;
        private int pop_po_id;

        private FinishedProduct pop_finishedProduct;

        public int id { get { return this.pop_id; } set { this.pop_id = value; } }
        public int prodf_id { get { return this.pop_prodf_id; } set { this.pop_prodf_id = value; } }
        public int prodf_quantity { get { return this.pop_prodf_quantity; } set { this.pop_prodf_quantity = value; } }
        public int po_id { get { return this.pop_po_id; } set { this.pop_po_id = value; } }

        public FinishedProduct finishedProduct { get { return this.pop_finishedProduct; } set { this.pop_finishedProduct = value; } }
    }
}