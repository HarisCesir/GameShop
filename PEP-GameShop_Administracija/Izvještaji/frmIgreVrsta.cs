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
using Services;
using Services.Data;
namespace PEP_GameShop_Administracija.Izvještaji
{
    public partial class frmIgreVrsta : Form
    {
        public frmIgreVrsta()
        {
            InitializeComponent();
        }

        private void frmIgreVrsta_Load(object sender, EventArgs e)
        {
            inputVrsta.DataSource = DBProizvodi.GetVrstaAll();
            inputVrsta.DisplayMember = "Naziv";
            inputVrsta.ValueMember = "VrstaID";
           
            
        }

        private void buttonPrikazi_Click(object sender, EventArgs e)
        {
            int vrstaID = Convert.ToInt32(inputVrsta.SelectedValue);
            ReportDataSource rds = new ReportDataSource("DataSet1", bindingSource1);
            reportViewer1.LocalReport.DataSources.Add(rds);
            _PEP_GameShopDataSet2 ds = new _PEP_GameShopDataSet2();
            _PEP_GameShopDataSet2TableAdapters.IgreSelectByVrstaTableAdapter adapter = new _PEP_GameShopDataSet2TableAdapters.IgreSelectByVrstaTableAdapter();
            adapter.Fill(ds.IgreSelectByVrsta, vrstaID);
            bindingSource1.DataSource = ds.IgreSelectByVrsta;
            this.reportViewer1.RefreshReport();
        }
    }
}
