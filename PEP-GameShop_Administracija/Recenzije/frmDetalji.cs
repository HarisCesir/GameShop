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
namespace PEP_GameShop_Administracija.Recenzije
{
    public partial class frmDetalji : Form
    {
        private Services.Data.Recenzije recenzija;
        public frmDetalji(Services.Data.Recenzije recenzije)
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
            if (recenzije != null)
            {
                recenzija = recenzije;
                ucitaj();
            }
        }

        private void ucitaj()
        {
            textBoxNaslov.Text = recenzija.Igre.Naziv;
            textBoxSadrzaj.Text = recenzija.Sadrzaj;
            textBoxDatum.Text = recenzija.Datum.ToString();
            textBoxAutor.Text = recenzija.Korisnici.Ime + "" + recenzija.Korisnici.Prezime;
        }

        private void frmDetalji_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonIzmjeni_Click(object sender, EventArgs e)
        {
            textBoxSadrzaj.ReadOnly = false;
           
            buttonSacuvaj.Enabled = true;

        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                DBRecenzije.Update(textBoxSadrzaj.Text, recenzija.RecenzijaID);
                MessageBox.Show("Uspješno sačuvano");
                textBoxSadrzaj.ReadOnly = true;

                buttonSacuvaj.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxSadrzaj_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxSadrzaj.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxSadrzaj, global.GetString("sadrzaj_req"));
            }
            else
            {
                errorProvider1.SetError(textBoxSadrzaj, "");
            }
        }
    }
}
