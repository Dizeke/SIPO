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
        enum Panel
        {
            RawAdd,
            RawUpdate,
            FinishAdd,
            FinishUpdate
        };

        FormPanelRawAdd formPanelRawAdd;

        FormPanelFinishAdd formPanelFinishAdd;

        

        bool hasOpenPanel = false;
        int openPanel = 0;
        public FormInventory()
        {
            InitializeComponent();
        }

        private void FormInventory_Load(object sender, EventArgs e)
        {

        }

        private void FormInventory_SizeChanged(object sender, EventArgs e)
        {
            if (hasOpenPanel)
            {
                if (openPanel == (int)Panel.RawAdd)
                {
                    formPanelRawAdd.AutoScrollMinSize = new Size(770, 450);
                    formPanelRawAdd.MaximumSize = panelHolder.Size;
                    formPanelRawAdd.Size = panelHolder.Size;
                }

                else if (openPanel == (int)Panel.FinishAdd)
                {
                    formPanelFinishAdd.AutoScrollMinSize = new Size(770, 450);
                    formPanelFinishAdd.MaximumSize = panelHolder.Size;
                    formPanelFinishAdd.Size = panelHolder.Size;
                }
            }
        }

        private void btnRawMaterialAdd_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();

            formPanelRawAdd = new FormPanelRawAdd();
            formPanelRawAdd.TopLevel = false;
            formPanelRawAdd.FormBorderStyle = FormBorderStyle.None;

            formPanelRawAdd.MaximumSize = panelHolder.Size;
            formPanelRawAdd.Dock = DockStyle.Fill;

            hasOpenPanel = true;
            openPanel = (int)Panel.RawAdd;

            panelHolder.Controls.Add(formPanelRawAdd);
            formPanelRawAdd.Show();
        }

        private void btnFinishedProductAdd_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();

            formPanelFinishAdd = new FormPanelFinishAdd();
            formPanelFinishAdd.TopLevel = false;
            formPanelFinishAdd.FormBorderStyle = FormBorderStyle.None;

            formPanelFinishAdd.MaximumSize = panelHolder.Size;
            formPanelFinishAdd.Dock = DockStyle.Fill;

            hasOpenPanel = true;
            openPanel = (int)Panel.FinishAdd;

            panelHolder.Controls.Add(formPanelFinishAdd);
            formPanelFinishAdd.Show();
        }
    }
}
