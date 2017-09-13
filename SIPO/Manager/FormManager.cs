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

        FormPanelClientAdd formPanelClientAdd;

        bool hasOpenPanel = false;
        int openPanel = 0;

        public FormManager()
        {
            InitializeComponent();
        }

        private void FormManager_SizeChanged(object sender, EventArgs e)
        {
            if (hasOpenPanel)
            {
                if (openPanel == (int)Panel.AccountAdd)
                {
                    formPanelAccountAdd.AutoScrollMinSize = new Size(770, 450);
                    formPanelAccountAdd.MaximumSize = panelHolder.Size;
                    formPanelAccountAdd.Size = panelHolder.Size;
                }

                else if (openPanel == (int)Panel.ClientAdd)
                {
                    formPanelClientAdd.AutoScrollMinSize = new Size(770, 450);
                    formPanelClientAdd.MaximumSize = panelHolder.Size;
                    formPanelClientAdd.Size = panelHolder.Size;
                }
            }
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();

            formPanelAccountAdd = new FormPanelAccountAdd();
            formPanelAccountAdd.TopLevel = false;
            formPanelAccountAdd.FormBorderStyle = FormBorderStyle.None;

            formPanelAccountAdd.MaximumSize = panelHolder.Size;
            formPanelAccountAdd.Dock = DockStyle.Fill;

            hasOpenPanel = true;
            openPanel = (int)Panel.AccountAdd;

            panelHolder.Controls.Add(formPanelAccountAdd);
            formPanelAccountAdd.Show();
        }

        private void btnClientAdd_Click(object sender, EventArgs e)
        {
            panelHolder.Controls.Clear();

            formPanelClientAdd = new FormPanelClientAdd();
            formPanelClientAdd.TopLevel = false;
            formPanelClientAdd.FormBorderStyle = FormBorderStyle.None;

            formPanelClientAdd.MaximumSize = panelHolder.Size;
            formPanelClientAdd.Dock = DockStyle.Fill;

            hasOpenPanel = true;
            openPanel = (int)Panel.ClientAdd;

            panelHolder.Controls.Add(formPanelClientAdd);
            formPanelClientAdd.Show();
        }
    }
}
