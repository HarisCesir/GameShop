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
namespace PEP_GameShop_Administracija.Korisnik
{
    public partial class frmPretraga : Form
    {
        private Korisnici korisnik { get; set; }

        public frmPretraga()
        {
            InitializeComponent();
        }

        private void textBoxImeIprezim_TextChanged(object sender, EventArgs e)
        {
            Bind();
        }

        private void frmPretraga_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void Bind()
        {
            dataGridViewKorisnici.DataSource = DBKorisnici.SearchByName(textBoxImeIprezim.Text);
            dataGridViewKorisnici.Columns[0].Visible = false;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Potrda deaktivacije", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridViewKorisnici.SelectedRows.Count > 0)
                {
                    int korisnikId = Convert.ToInt32(dataGridViewKorisnici.SelectedRows[0].Cells[0].Value.ToString());

                    DBKorisnici.KorisniciUpdateStatus(korisnikId, false);

                    MessageBox.Show(global.GetString("success_korisnikdeaktiviran"), "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Bind();
                }
            }
        }

        private void obrisiButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni?", "Potrda brisanja", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridViewKorisnici.SelectedRows.Count > 0)
                {
                    int korisnikId = Convert.ToInt32(dataGridViewKorisnici.SelectedRows[0].Cells[0].Value.ToString());
                    DBKorisnici.DeleteUlogeKorisnika(korisnikId);
                    DBKorisnici.DeleteKorisnici(korisnikId);

                    MessageBox.Show(global.GetString("success_deletekorisnik"), "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Bind();
                }
            }
        }

        private void izmjenaButton_Click(object sender, EventArgs e)
        {

        }

        private void izmjenaLičnihPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                frmIzmjenaLicnihPodataka izmjena = new frmIzmjenaLicnihPodataka(korisnik);
               
                izmjena.ShowDialog();
                Bind();
            }
        }

        private void dataGridViewKorisnici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void izmjenaStatusnihPodatakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                frmPristup pristupForm = new frmPristup(korisnik);
                pristupForm.ShowDialog();
               
            }
        }

        private void dataGridViewKorisnici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewKorisnici_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int korisnikId = Convert.ToInt32(dataGridViewKorisnici.SelectedRows[0].Cells[0].Value.ToString());
                korisnik = DBKorisnici.KorisniciSelectByID(korisnikId);
            }
        }

        private void IzmjeneButton_Click(object sender, EventArgs e)
        {

        }
    }
}
