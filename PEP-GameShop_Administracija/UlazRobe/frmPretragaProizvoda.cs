using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEP_GameShop_Administracija.UlazRobe
{
    public partial class frmPretragaProizvoda : Form
    {
        public frmPretragaProizvoda()
        {
            InitializeComponent();
        }

        private void frmPretragaProizvoda_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            dataGridViewPretraga.AutoGenerateColumns = false;
            dataGridViewPretraga.DataSource = Services.Data.DBProizvodi.SearchIgre(textBoxNaziv.Text, textBoxSifra.Text);
            //dataGridViewPretraga.Columns[0].Visible = false;
            dataGridViewPretraga.ClearSelection();
        }

        private void textBoxSifra_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void textBoxNaziv_TextChanged(object sender, EventArgs e)
        {
            BindGrid();
        }
    }
}
