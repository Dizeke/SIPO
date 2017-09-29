using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIPO.Classes;

namespace SIPO.Packaging
{
    public partial class FormPackagePrint : Form
    {
        List<PackageDetails> _list;
        Package _pack;
        public FormPackagePrint( Package pack, List<PackageDetails> list )
        {
            InitializeComponent();
            _list = list;
            _pack = pack;

        }

        private void FormPackagePrint_Load(object sender, EventArgs e)
        {
            rptPackage1.SetDataSource(_list);
            rptPackage1.SetParameterValue("pName", _pack.Company);
            rptPackage1.SetParameterValue("pInvoice", _pack.POID);
            crystalReportViewer1.ReportSource = rptPackage1;

        }
    }
}
