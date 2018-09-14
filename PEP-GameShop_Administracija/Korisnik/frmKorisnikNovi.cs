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
using Services;
using Services.Util;
using System.Net.Mail;
namespace PEP_GameShop_Administracija.Korisnik
{
    public partial class frmKorisnikNovi : Form
    {
        private Korisnici korisniciIzmjene { get; set; }
        public frmKorisnikNovi(Korisnici k)
        {

            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;

            if (k != null)
            {
                korisniciIzmjene = k;
                ucitajPodatke();
            }
        }

        private void ucitajPodatke()
        {

            this.Width = this.Width - pristupPanel.Width;

            buttonSacuvaj.Location = new Point(buttonSacuvaj.Location.X - pristupPanel.Width,buttonSacuvaj.Location.Y);
           
           
            this.Text = "Izmjene korisnika";
            pristupPanel.Visible = false;
            textBoxIme.Text = korisniciIzmjene.Ime;
            textBoxPrezime.Text = korisniciIzmjene.Prezime;
            textBoxEmail.Text = korisniciIzmjene.Email;
            maskedTextBoxTelefon.Text = korisniciIzmjene.Telefon;
            
        }

        private void frmKorisnikNovi_Load(object sender, EventArgs e)
        {
            ((ListBox)checkedListBoxUloge).DataSource= DBKorisnici.GetUlogeAll();
            ((ListBox)checkedListBoxUloge).DisplayMember = "Naziv";
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren(ValidationConstraints.Enabled))
            {
            Services.Data.Korisnici korisnik = new Korisnici();
            if (korisniciIzmjene != null)
                korisnik.KorisnikID = korisniciIzmjene.KorisnikID;

            korisnik.Ime = textBoxIme.Text;
            korisnik.Prezime = textBoxPrezime.Text;
            korisnik.Email = textBoxEmail.Text;
            korisnik.Telefon = maskedTextBoxTelefon.Text;

            if (korisnik.KorisnikID > 0)
            {
                DBKorisnici.KorisnikUpdate(korisnik);
                MessageBox.Show(global.GetString("update_succ"), "Izmjene korisničkih podataka",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            korisnik.KorisnickoIme = textBoxKorisnickoIme.Text;
            korisnik.LozinkaSalt = UiHelper.GenerateSalt();
            korisnik.LozinkaHash = UiHelper.GenerateHash(textBoxLozinka.Text, korisnik.LozinkaSalt);

            List<Uloge> uloge = checkedListBoxUloge.CheckedItems.Cast<Uloge>().ToList();
            try
            {
                DBKorisnici.InsertKorisnik(korisnik, uloge);

                clear();

                MessageBox.Show(global.GetString("korisnikSuccessAdd"), "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(global.GetString(ex.Message));
            }

         
        }
    }

        private void clear()
        {
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxEmail.Text = "";
            maskedTextBoxTelefon.Text = "";
            textBoxKorisnickoIme.Text = "";
            textBoxLozinka.Text = "";
            checkedListBoxUloge.ClearSelected();
            foreach(int item in checkedListBoxUloge.CheckedIndices)
            {
                checkedListBoxUloge.SetItemCheckState(item, CheckState.Unchecked);
            }
            
        }

        private void textBoxIme_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxIme.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxIme,global.GetString("ime_error"));
                
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

       

        private void textBoxKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxKorisnickoIme.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxKorisnickoIme, global.GetString("korisnickoime_error"));
            }
            else
            {
                errorProvider1.SetError(textBoxKorisnickoIme, "");
            }

        }

        private void textBoxLozinka_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLozinka_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxLozinka.TextLength < 5)
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxLozinka, global.GetString("lozinka_req"));
            }
            else
            {
                errorProvider1.SetError(textBoxLozinka, "");
            }
        }

        private void checkedListBoxUloge_Validating(object sender, CancelEventArgs e)
        {
            if (checkedListBoxUloge.CheckedItems.Count == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(checkedListBoxUloge, global.GetString("uloge_req"));
            }
            else
            {
                errorProvider1.SetError(checkedListBoxUloge, "");
            }
        }
    }
}
