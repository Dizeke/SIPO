using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPO.Manager
{
    public partial class FormManager : MetroFramework.Forms.MetroForm
    {
        enum Panel
        {
            AccountAdd,
            AccountUpdate,
            ClientAdd,
            ClientUpdate
        };

        FormPanelAccountAdd formPanelAccountAdd;

        bool hasOpenPanel = false;
        int openPanel = 0;

        public FormManager()
        {
            InitializeComponent();
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();
            
            formPanelAccountAdd = new FormPanelAccountAdd();
            formPanelAccountAdd.TopLevel = false;
            formPanelAccountAdd.FormBorderStyle = FormBorderStyle.None;
            formPanelAccountAdd.Dock = DockStyle.Fill;

            hasOpenPanel = true;
            openPanel = (int)Panel.AccountAdd;

            panelHolder.Controls.Add(formPanelAccountAdd);
            formPanelAccountAdd.Show();

            MessageBox.Show("Panel Size: " + panelHolder.Width + ", " + panelHolder.Height);
            MessageBox.Show("Form Size: " + formPanelAccountAdd.Width + ", " + formPanelAccountAdd.Height);
        }

        private void FormManager_SizeChanged(object sender, EventArgs e)
        {
            if (hasOpenPanel)
            {
                if (openPanel == (int)Panel.AccountAdd)
                {
                    formPanelAccountAdd.AutoScrollMinSize = new Size(770, 450);
                    formPanelAccountAdd.Size = panelHolder.Size;
                }
            }
        }
    }
}
