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
    public partial class frmZahtjeviGlasovi : Form
    {
        public frmZahtjeviGlasovi()
        {
            InitializeComponent();
        }

        private void frmZahtjeviGlasovi_Load(object sender, EventArgs e)
        {

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (inputGlasovi.Text != "")
            {
                ReportDataSource rds = new ReportDataSource("DataSet1", bindingSource1);
                reportViewer1.LocalReport.DataSources.Add(rds);
                _PEP_GameShopDataSet4 ds = new _PEP_GameShopDataSet4();
                _PEP_GameShopDataSet4TableAdapters.ZahtjeviPoGlasovimaTableAdapter adapter = new _PEP_GameShopDataSet4TableAdapters.ZahtjeviPoGlasovimaTableAdapter();
                adapter.Fill(ds.ZahtjeviPoGlasovima, Convert.ToInt32(inputGlasovi.Text));
                bindingSource1.DataSource = ds.ZahtjeviPoGlasovima;
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
