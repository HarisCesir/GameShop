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
    public partial class frmDodajSkladista : Form
    {
        public frmDodajSkladista()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {

                    Skladista sklad = new Skladista();
                    sklad.Naziv = textBoxNaziv.Text;
                    sklad.Adresa = textBoxAdresa.Text;
                    DBSkladista.InsertSkladista(sklad);
                    MessageBox.Show(global.GetString("sklad_succ"), "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clean();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void clean()
        {
            textBoxNaziv.Text = "";
            textBoxAdresa.Text = "";
        }

        private void textBoxNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNaziv.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNaziv, global.GetString("naziv_req"));

            }
            else
            {
                errorProvider1.SetError(textBoxNaziv, "");
            }
        }

        private void textBoxAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxAdresa.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxAdresa, global.GetString("adresa_req"));

            }
            else
            {
                errorProvider1.SetError(textBoxAdresa, "");
            }
        }
    }
}
