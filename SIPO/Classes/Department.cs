using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIPO.Classes
{
    class Department
    {
        public static String Sales = "Sales";
        public static String Inventory = "Inventory";
        public static String Packaging = "Packaging";
        public static String Manager = "Manager";

        public static List<String> Departments = new List<String>(new String[] { Sales, Inventory, Packaging, Manager });
    }
}
