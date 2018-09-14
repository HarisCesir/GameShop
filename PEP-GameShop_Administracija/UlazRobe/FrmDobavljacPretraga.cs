using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services.Data;
namespace PEP_GameShop_Administracija.UlazRobe
{
    public partial class FrmDobavljacPretraga : Form
    {
        public Dobavljaci dobavljac;
        public FrmDobavljacPretraga()
        {
            InitializeComponent();
        }

        private void textBoxNaziv_TextChanged(object sender, EventArgs e)
        {
            Bind();
        }

        private void Bind()
        {
            dataGridViewDobavljaci.AutoGenerateColumns = false;
            dataGridViewDobavljaci.DataSource = DBDobavljaci.DobavljaciSelectByNaziv(textBoxNaziv.Text);
            dataGridViewDobavljaci.ClearSelection();
        }

        private void FrmDobavljacPretraga_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void dataGridViewDobavljaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int dobavljacID =Convert.ToInt32(dataGridViewDobavljaci.SelectedRows[0].Cells[0].Value);
                dobavljac = DBDobavljaci.DobavljaciSelectByID(dobavljacID);
                this.Close();
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            frmDodajDobavljaca dodaj = new frmDodajDobavljaca();
            dodaj.ShowDialog();
            Bind();
        }
    }
}
