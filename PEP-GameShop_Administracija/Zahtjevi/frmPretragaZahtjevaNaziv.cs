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
namespace PEP_GameShop_Administracija.Zahtjevi
{
    public partial class frmPretragaZahtjevaNaziv : Form
    {
        public frmPretragaZahtjevaNaziv()
        {
            InitializeComponent();
        }

        private void frmPretragaZahtjevaNaziv_Load(object sender, EventArgs e)
        {
            dataGridViewzahtjevi.AutoGenerateColumns = false;
            dataGridViewzahtjevi.DataSource = DBZahtjevi.SelectSviZahtjevi();
            
        }

        private void buttonTrazi_Click(object sender, EventArgs e)
        {
            bool cekirano;
            if (checkBoxglasovi.Checked)
                cekirano = true;
            else
                cekirano = false;

            dataGridViewzahtjevi.DataSource = DBZahtjevi.ZahtjeviPretraga(textBoxNaziv.Text, cekirano);
            
        }

       
    }
}
