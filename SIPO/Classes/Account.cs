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
        private string acc_vpass;

        private string acc_fname;
        private string acc_mname;
        private string acc_lname;

        private string acc_email;
        private string acc_contact;

        private string acc_position;
        private string acc_type;

        public int id { get { return this.acc_id; } set { this.acc_id = value; } }
        public string user { get { return this.acc_user; } set { this.acc_user = value; } }
        public string pass { get { return this.acc_pass; } set { this.acc_pass = value; } }
        public string vpass { get { return this.acc_vpass; } set { this.acc_vpass = value; } }
        public string fname { get { return this.acc_fname; } set { this.acc_fname = value; } }
        public string mname { get { return this.acc_mname; } set { this.acc_mname = value; } }
        public string lname { get { return this.acc_lname; } set { this.acc_lname = value; } }
        public string email { get { return this.acc_email; } set { this.acc_email = value; } }
        public string contact { get { return this.acc_contact; } set { this.acc_contact = value; } }
        public string position { get { return this.acc_position; } set { this.acc_position = value; } }
        public string type { get { return this.acc_type; } set { this.acc_type = value; } }
    }
}
