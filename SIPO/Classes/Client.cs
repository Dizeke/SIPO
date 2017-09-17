using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    class Client
    {
        private int client_id;
        private string client_company;
        private string client_tin;
        private string client_address;
        private string client_contact;
        private string client_contact_number;

        public int id { get { return this.client_id; } set { client_id = value; } }
        public string company { get { return this.client_company; } set { this.client_company = value; } }
        public string tin { get { return this.client_tin; } set { this.client_tin = value; } }
        public string address { get { return this.client_address; } set { this.client_address = value; } }
        public string contact { get { return this.client_contact; } set { this.client_contact = value; } }
        public string contact_number { get { return this.client_contact_number; } set { this.client_contact_number = value; } }
    }
}
