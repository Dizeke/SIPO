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
        List<PurchaseOrderProduct> po_prods;

        int po_id;

        public FormPaymentProductsOrdered(int _po_id)
        {
            InitializeComponent();
            this.po_id = _po_id;

            loadProductsOrdered();
        }

        private void loadProductsOrdered()
        {
            po_prods = new List<PurchaseOrderProduct>();

            string query = String.Format("");
            MySqlConnection con = new MySqlConnection(ConString.getConString());
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();

            reader = com.ExecuteReader();
            while (reader.Read())
            {

            }

            con.Close();
            displayProductsOrdered();
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
