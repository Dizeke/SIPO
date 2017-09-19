using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    class FinishedProduct
    {
        private int _id;
        private string _name;
        private string _desc;
        private List<string> _raw;
        private List<int> _qty;
        private List<int> _rawId;
        private int _finQty;
        private double _price;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Desc { get => _desc; set => _desc = value; }
        public double Price { get => _price; set => _price = value; }
        public int FinQty { get => _finQty; set => _finQty = value; }
        public List<string> Raw { get => _raw; set => _raw = value; }
        public List<int> Qty { get => _qty; set => _qty = value; }
        public List<int> RawId { get => _rawId; set => _rawId = value; }
    }
}
