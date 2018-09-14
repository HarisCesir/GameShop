using Microsoft.Reporting.WinForms;
using PEP_GameShop_Administracija._PEP_GameShopDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEP_GameShop_Administracija.Izvještaji
{
    public partial class frmProizvodiIzvjestaj : Form
    {
        public frmProizvodiIzvjestaj()
        {
            InitializeComponent();
        }

        private void frmProizvodiIzvjestaj_Load(object sender, EventArgs e)
        {
            ReportDataSource rds=new ReportDataSource("DataSet1",bindingSource1);
            reportViewer1.LocalReport.DataSources.Add(rds);
            _PEP_GameShopDataSet ds = new _PEP_GameShopDataSet();
            ProizvodiTableAdapter adapter = new ProizvodiTableAdapter();
            adapter.Fill(ds.Proizvodi);
            bindingSource1.DataSource = ds.Proizvodi;
            this.reportViewer1.RefreshReport();
        }
    }
}
