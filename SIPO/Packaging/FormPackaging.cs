using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIPO.Packaging
{
    public partial class FormPackaging : MetroFramework.Forms.MetroForm
    {
        public FormPackaging()
        {
            InitializeComponent();
        }

        private void btnDispatchPackages_Click(object sender, EventArgs e)
        {
            FormPackageDispatchSelect formPackageDispatchSelect = new FormPackageDispatchSelect();
            formPackageDispatchSelect.ShowDialog();
        }

        private void btnPackaging_Click(object sender, EventArgs e)
        {
            FormPackagesReport formPackagesReport = new FormPackagesReport();
            formPackagesReport.ShowDialog();
        }
    }
}
