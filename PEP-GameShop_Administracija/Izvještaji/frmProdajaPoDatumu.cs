using Microsoft.Reporting.WinForms;
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
    public partial class frmProdajaPoDatumu : Form
    {
        public frmProdajaPoDatumu()
        {
            InitializeComponent();
        }

        private void frmProdajaPoDatumu_Load(object sender, EventArgs e)
        {

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("DataSet1", bindingSource1);
            reportViewer1.LocalReport.DataSources.Add(rds);
            _PEP_GameShopDataSet3 ds = new _PEP_GameShopDataSet3();
            _PEP_GameShopDataSet3TableAdapters.IzlazSelectByDatumTableAdapter adapter = new _PEP_GameShopDataSet3TableAdapters.IzlazSelectByDatumTableAdapter();
            adapter.Fill(ds.IzlazSelectByDatum, dateTimePickerDatumOD.Value, dateTimePickerDatumDO.Value);
            bindingSource1.DataSource = ds.IzlazSelectByDatum;
            this.reportViewer1.RefreshReport();
        }
    }
}
