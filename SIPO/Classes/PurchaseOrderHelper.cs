using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    class PurchaseOrderHelper
    {
        public static PurchaseOrder purchaseOrder;
        public static List<PurchaseOrderProduct> purchaseOrderProducts;
        public static List<PurchaseOrderBatch> purchaseOrderBatches;

        public static bool isComplete;
    }
}
