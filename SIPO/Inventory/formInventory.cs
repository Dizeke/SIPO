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
            formPanelRawAdd.ShowDialog();
            

        }

        private void btnFinishedProductAdd_Click(object sender, EventArgs e)
        {
            formPanelFinishAdd = new FormPanelFinishAdd();
            formPanelFinishAdd.ShowDialog();

        }

        private void btnRawMaterialUpdate_Click(object sender, EventArgs e)
        {
            formPanelRawSelect = new FormPanelRawSelect();
            formPanelRawSelect.ShowDialog();
            

        }

        private void btnFinishedProductUpdate_Click(object sender, EventArgs e)
        {
            formPanelFinishSelect = new FormPanelFinishSelect();
            formPanelFinishSelect.ShowDialog();
            


        }

        private void btnMoveToPackaging_Click(object sender, EventArgs e)
        {
            FormFulfillSelect formFulfillSelect = new FormFulfillSelect();
            formFulfillSelect.ShowDialog();
        }

        private void btnRawMaterials_Click(object sender, EventArgs e)
        {
            
            FormRawReports formRawReports = new FormRawReports();
            formRawReports.ShowDialog();
        }

        private void btnFinishedProducts_Click(object sender, EventArgs e)
        {
            FormFinishedReports formFinishedReports = new FormFinishedReports();
            formFinishedReports.ShowDialog();
        }
    }
}
