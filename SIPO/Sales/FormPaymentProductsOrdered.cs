using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using SIPO.Classes;

namespace SIPO.Sales
{
    public partial class FormPaymentProductsOrdered : MetroFramework.Forms.MetroForm
    {
        public FormPaymentProductsOrdered()
        {
            InitializeComponent();
            loadProductsOrdered();
        }

        private void loadProductsOrdered()
        {
            MySqlConnection con = new MySqlConnection(ConString.getConString());
        }

        private void displayProductsOrdered()
        {
        }

        public partial class ProdOrdered
        {
            private int _prodf_id;
        }
    }
}
