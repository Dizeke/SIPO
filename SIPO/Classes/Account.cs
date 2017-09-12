using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    class Account
    {
        public static Account loggedAccount;

        private int acc_id;
        private string acc_user;
        private string acc_pass;
        private string acc_type;

        public int id { get { return this.acc_id; } set { this.acc_id = value; } }
        public string user { get { return this.acc_user; } set { this.acc_user = value; } }
        public string pass { get { return this.acc_pass; } set { this.acc_pass = value; } }
        public string type { get { return this.acc_type; } set { this.acc_type = value; } }
    }
}
