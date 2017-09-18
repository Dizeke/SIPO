using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    class RawMaterials
    {
        private int _id;
        private string _name;
        private string _desc;
        private int _size;
        private int _qty;
        private string _received;
        private double _price;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Desc { get => _desc; set => _desc = value; }
        public int Size { get => _size; set => _size = value; }
        public int Qty { get => _qty; set => _qty = value; }
        public string Received { get => _received; set => _received = value; }
        public double Price { get => _price; set => _price = value; }
    }
}
