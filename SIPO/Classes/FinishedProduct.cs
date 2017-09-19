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
        private int _qty;
        private string _raw;
        private int _finQty;
        private double _price;
        private double _newprice;


        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Desc { get => _desc; set => _desc = value; }
        public string Raw { get { return this._raw; } set { this._raw = value; } }
        public double Price { get => _price; set => _price = value; }
        public int FinQty { get => _finQty; set => _finQty = value; }
        public int Qty { get => _qty; set => _qty = value; }
        public double Newprice { get => _newprice; set => _newprice = value; }
    }
}
