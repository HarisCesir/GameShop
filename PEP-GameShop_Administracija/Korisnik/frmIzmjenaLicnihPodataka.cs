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
using System.Net.Mail;
namespace PEP_GameShop_Administracija.Korisnik
{
    public partial class frmIzmjenaLicnihPodataka : Form
    {
        private Services.Data.Korisnici korisnik;
        public frmIzmjenaLicnihPodataka(Services.Data.Korisnici k)
        {

            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            if (k != null)
            {
                korisnik = k;
                ucitajPodatke();
            }
        }

        private void ucitajPodatke()
        {
            textBoxIme.Text = korisnik.Ime;
            textBoxPrezime.Text = korisnik.Prezime;
            textBoxEmail.Text = korisnik.Email;
            maskedTextBoxTelefon.Text = korisnik.Telefon;
        }

        private void frmIzmjenaLicnihPodataka_Load(object sender, EventArgs e)
        {

        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            if (korisnik != null)
            {
                if (this.ValidateChildren())
                {
                    korisnik.Ime = textBoxIme.Text;
                    korisnik.Prezime = textBoxPrezime.Text;
                    korisnik.Email = textBoxEmail.Text;
                    korisnik.Telefon = maskedTextBoxTelefon.Text;

                    if (korisnik.KorisnikID > 0)
                    {
                        Services.Data.DBKorisnici.KorisnikUpdate(korisnik);
                        this.Close();
                        MessageBox.Show(global.GetString("update_succ"), "Modifikovanje korisnika", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
        }

        private void textBoxIme_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxIme.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxIme, global.GetString("ime_error"));

            }
            else
            {
                errorProvider1.SetError(textBoxIme, "");
            }
        }

        private void textBoxPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxPrezime.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxPrezime, global.GetString("prezime_error"));
            }
            else
            {
                errorProvider1.SetError(textBoxPrezime, "");
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmail.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxEmail, global.GetString("email_req"));
                return;
            }
            else
            {


                try
                {
                    MailAddress email = new MailAddress(textBoxEmail.Text);
                    errorProvider1.SetError(textBoxEmail, "");
                }
                catch (Exception)
                {

                    e.Cancel = true;
                    errorProvider1.SetError(textBoxEmail, global.GetString("email_error"));

                }
            }
        }
    }
}
