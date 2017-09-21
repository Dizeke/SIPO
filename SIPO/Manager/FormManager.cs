﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SIPO.Classes;

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

        private void btnAccountUpdate_Click(object sender, EventArgs e)
        {
            FormPanelAccountSelect formPanelAccountSelect = new FormPanelAccountSelect();
            formPanelAccountSelect.ShowDialog();

            if (AccountUpdateHolder.hasSelected)
            {
                panelHolder.Controls.Clear();

                FormPanelAccountUpdate formPanelAccountUpdate = new FormPanelAccountUpdate();
                formPanelAccountUpdate.TopLevel = false;
                formPanelAccountUpdate.FormBorderStyle = FormBorderStyle.None;

                formPanelAccountUpdate.MaximumSize = panelHolder.Size;
                formPanelAccountUpdate.Dock = DockStyle.Fill;

                hasOpenPanel = true;
                openPanel = (int)Panel.AccountUpdate;

                panelHolder.Controls.Add(formPanelAccountUpdate);
                formPanelAccountUpdate.Show();
            }
        }

        private void btnClientUpdate_Click(object sender, EventArgs e)
        {
            FormPanelClientSelect formPanelClientSelect = new FormPanelClientSelect();
            formPanelClientSelect.ShowDialog();

            if (ClientUpdateHolder.hasSelected)
            {
                panelHolder.Controls.Clear();

                FormPanelClientUpdate formPanelClientUpdate = new FormPanelClientUpdate();
                formPanelClientUpdate.TopLevel = false;
                formPanelClientUpdate.FormBorderStyle = FormBorderStyle.None;

                formPanelClientUpdate.MaximumSize = panelHolder.Size;
                formPanelClientUpdate.Dock = DockStyle.Fill;

                hasOpenPanel = true;
                openPanel = (int)Panel.ClientUpdate;

                panelHolder.Controls.Add(formPanelClientUpdate);
                formPanelClientUpdate.Show();
            }
        }

    }
}
