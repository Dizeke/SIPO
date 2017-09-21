using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    class PurchaseOrderBatch
    {
        private int pob_id;
        private string pob_datetime;
        private string pob_company;
        private int pob_po_id;
        private int pob_pack_id;

        private List<PurchaseOrderProduct> pob_purchaseOrderProducts;

        public int id { get { return this.pob_id; } set { this.pob_id = value; } }
        public string datetime { get { return this.pob_datetime; } set { this.pob_datetime = value; } }
        public string company_name { get { return this.pob_company; } set { this.pob_company = value; } }
        public int po_id { get { return this.pob_po_id; } set { this.pob_po_id = value; } }
        public int pack_id { get { return this.pob_pack_id; } set { this.pob_pack_id = value; } }

        public List<PurchaseOrderProduct> purchaseOrderProducts { get { return this.pob_purchaseOrderProducts; } set { this.pob_purchaseOrderProducts = value; } }
    }
}
