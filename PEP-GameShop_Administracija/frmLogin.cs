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
namespace PEP_GameShop_Administracija
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPotvrdi_Click(object sender, EventArgs e)
        {
            Services.Data.Korisnici korisnik = DBKorisnici.SelectByKorisnickoIme(textBoxKorisnikoIme.Text, textBoxLozinka.Text);

            if (korisnik != null && korisnik.Status==true)
            {
                MessageBox.Show(global.GetString("loginSuccess"), "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                global.prijavljenKorisnik = korisnik;
                this.DialogResult = DialogResult.OK;

                

            }
            else
            {
                MessageBox.Show(global.GetString("loginError"), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
