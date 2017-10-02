using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    class PackageDispatched
    {
        private int _packd_id;
        private int _pack_id;
        private int _po_id;
        private int _pob_id;
        private int _client_id;

        private string _packd_datetime;
        private string _pack_datetime;
        private string _packd_status;
        private string _client_company;
        private string _po_payment;
        private string _po_status;
        private string _pob_datetime;

        public int packd_id { get { return this._packd_id; } set { this._packd_id = value; } }
        public int pack_id { get { return this._pack_id; } set { this._pack_id = value; } }
        public int po_id { get { return this._po_id; } set { this._po_id = value; } }
        public int pob_id { get { return this._pob_id; } set { this._pob_id = value; } }
        public int client_id { get { return this._client_id; } set { this._client_id = value; } }

        public string po_payment { get { return this._po_payment; } set { this._po_payment = value; } }
        public string po_status { get { return this._po_status; } set { this._po_status = value; } }
        public string packd_datetime { get { return this._packd_datetime; } set { this._packd_datetime = value; } }
        public string pack_datetime { get { return this._pack_datetime; } set { this._pack_datetime = value; } }
        public string packd_status { get { return this._packd_status; } set { this._packd_status = value; } }
        public string client_company { get { return this._client_company; } set { this._client_company = value; } }
        public string pob_datetime { get { return this._pob_datetime; } set { this._pob_datetime = value; } }
    }
}
