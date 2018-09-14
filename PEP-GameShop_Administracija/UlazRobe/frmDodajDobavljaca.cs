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
using System.Net.Mail;
namespace PEP_GameShop_Administracija.UlazRobe
{
    public partial class frmDodajDobavljaca : Form
    {
        public frmDodajDobavljaca()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try 
	{	        
		if(this.ValidateChildren(ValidationConstraints.Enabled))
            {
            Dobavljaci dobavljac = new Dobavljaci();

            dobavljac.Naziv = textBoxNaziv.Text;
            dobavljac.Adresa = textBoxAdresa.Text;
            dobavljac.Email = textBoxEmail.Text;
            dobavljac.Status = true;
            dobavljac.Telefon = maskedTextBoxTelefon.Text;
            dobavljac.ZiroRacun = textBoxZiroracun.Text;
            dobavljac.KontaktOsoba = textBoxKontaktOsoba.Text;

            Services.Data.DBDobavljaci.InsertDobavljaci(dobavljac);
            MessageBox.Show(global.GetString("dobavljac_succ"), "Uspjesno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clean();
            }
	}
	catch (Exception ex)
	{
		
      MessageBox.Show(ex.Message,"Greška",MessageBoxButtons.OK,MessageBoxIcon.Error);
	}

        }

        private void clean()
        {
            textBoxNaziv.Text = "";
            textBoxKontaktOsoba.Text = "";
            textBoxEmail.Text = "";
            textBoxAdresa.Text = "";
            maskedTextBoxTelefon.Text = "";
            textBoxZiroracun.Text = "";
        }

        private void textBoxNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxNaziv.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNaziv, global.GetString("nazivd_req"));
            }
            else
            {
                errorProvider1.SetError(textBoxNaziv, "");
            }
        }

        private void textBoxKontaktOsoba_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxKontaktOsoba.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxKontaktOsoba, global.GetString("kontakt_req"));


            }
            else
            {
                errorProvider1.SetError(textBoxKontaktOsoba, "");
            }
        }

        private void textBoxAdresa_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxAdresa.Text.Trim() == "")
            {

                e.Cancel = true;
                errorProvider1.SetError(textBoxAdresa, global.GetString("adresad_req"));

            }
            else
            {
                errorProvider1.SetError(textBoxAdresa, "");
            }
        }

        private void maskedTextBoxTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (maskedTextBoxTelefon.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(maskedTextBoxTelefon, global.GetString("telefond_req"));
            }
            else
            {
                errorProvider1.SetError(maskedTextBoxTelefon, "");
            }
        }

        private void textBoxEmail_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxEmail.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxEmail, global.GetString("emaild_req"));


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

        private void textBoxZiroracun_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxZiroracun.Text.Trim() == "")
            {

                e.Cancel = true;
                errorProvider1.SetError(textBoxZiroracun, global.GetString("ziro_req"));
            }
            else
            {
                errorProvider1.SetError(textBoxZiroracun, "");
            }
        }
    }
}
