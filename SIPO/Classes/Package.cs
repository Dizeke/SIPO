using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    public class Package
    {
        private int batchId;
        private string company;
        private string pOID;
        private string eta;
        private int packageId;

        public int BatchId { get => batchId; set => batchId = value; }
        public string Company { get => company; set => company = value; }
        public string POID { get => pOID; set => pOID = value; }
        public string Eta { get => eta; set => eta = value; }
        public int PackageId { get => packageId; set => packageId = value; }
    }
}
