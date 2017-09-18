using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SIPO.Packaging;

namespace SIPO.Inventory
{
    public partial class FormInventory : MetroFramework.Forms.MetroForm
    {
      

        FormPanelRawAdd formPanelRawAdd;

        FormPanelFinishAdd formPanelFinishAdd;

        FormPanelRawSelect formPanelRawSelect;

        FormPanelFinishSelect formPanelFinishSelect;

      
        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {

        }


        private void btnRawMaterialAdd_Click(object sender, EventArgs e)
        {
            formPanelRawAdd = new FormPanelRawAdd();
            this.Hide();
            formPanelRawAdd.ShowDialog();
            this.Show();
           
        }

        private void btnFinishedProductAdd_Click(object sender, EventArgs e)
        {
            formPanelFinishAdd = new FormPanelFinishAdd();
            this.Hide();
            formPanelFinishAdd.ShowDialog();
            this.Show();
           
        }

        private void btnRawMaterialUpdate_Click(object sender, EventArgs e)
        {
            formPanelRawSelect = new FormPanelRawSelect();
            this.Hide();
            formPanelRawSelect.ShowDialog();
            this.Show();

        }

        private void btnFinishedProductUpdate_Click(object sender, EventArgs e)
        {
            formPanelFinishSelect = new FormPanelFinishSelect();
            this.Hide();
            formPanelFinishSelect.ShowDialog();
            this.Show();


        }
    }
}
