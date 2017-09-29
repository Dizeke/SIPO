using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    public class PackageDetails
    {
        private int _id;
        private string _name;
        private string _qty;
        private int _gross;
        private int _net;
        private string _qtypercarton;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Qty { get => _qty; set => _qty = value; }
        public int Gross { get => _gross; set => _gross = value; }
        public int Net { get => _net; set => _net = value; }
        public string Qtypercarton { get => _qtypercarton; set => _qtypercarton = value; }
    }
}
