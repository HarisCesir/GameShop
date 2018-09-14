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
namespace PEP_GameShop_Administracija.Korisnik
{
    public partial class frmPristup : Form
    {
        private Korisnici  korisnik { get; set; }
        public frmPristup( Korisnici k)
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
            textBoxKorisnickoIme.Text = korisnik.KorisnickoIme;
            korisnik.uloge = DBKorisnici.KorisniciSelectUloge(korisnik.KorisnikID);
            checkBoxStatus.Checked = korisnik.Status;
            ((ListBox)checkedListBoxUloge).DataSource = DBKorisnici.GetUlogeAll();
            ((ListBox)checkedListBoxUloge).DisplayMember = "Naziv";

            checkedListBoxUloge.ClearSelected();

            for (int i = 0; i < checkedListBoxUloge.Items.Count; i++)
            {
                if (korisnik.uloge.Contains(checkedListBoxUloge.Items[i]))
                    checkedListBoxUloge.SetItemCheckState(i, CheckState.Checked);
            }
        }

        private void frmPristup_Load(object sender, EventArgs e)
        {

        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
            if (textBoxLozinka.Text != " ")
            {
                korisnik.LozinkaSalt = Services.Util.UiHelper.GenerateSalt();
                korisnik.LozinkaHash = Services.Util.UiHelper.GenerateHash(textBoxLozinka.Text, korisnik.LozinkaSalt);
                DBKorisnici.KorisniciChangePassword(korisnik);
            }
            if (korisnik.KorisnikID == global.prijavljenKorisnik.KorisnikID)
               global.GetString("status_err");
            else
                if (korisnik.Status != checkBoxStatus.Checked)
            {
                korisnik.Status = checkBoxStatus.Checked;
                DBKorisnici.UpdateStatus(korisnik.KorisnikID, korisnik.Status);
            }

            DBKorisnici.UpdateUloge(korisnik.KorisnikID,checkedListBoxUloge.CheckedItems.Cast<Uloge>().ToList());

            MessageBox.Show(global.GetString("update_succ"), "Promjene", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();




        }
    }
}
