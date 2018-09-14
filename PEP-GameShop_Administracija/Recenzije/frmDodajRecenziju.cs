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
using System.IO;
namespace PEP_GameShop_Administracija.Recenzije
{
    public partial class frmDodajRecenziju : Form
    {
        private Services.Data.Recenzije recenzija { get; set; }
        public frmDodajRecenziju()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.ValidateChildren(ValidationConstraints.Enabled))
            {
            recenzija = new Services.Data.Recenzije();
            
            recenzija.Sadrzaj = textBoxTekst.Text;
            recenzija.Datum = DateTime.Now;

            int KorisnikID = global.prijavljenKorisnik.KorisnikID;

            recenzija.KorisnikID = KorisnikID;
            recenzija.IgraID = Convert.ToInt32(comboBoxIgre.SelectedValue);

            Services.Data.DBRecenzije.InsertRecenzije(recenzija);

            MessageBox.Show(global.GetString("recenzija_success"), "Uspješno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clean();
            }

        }

        private void clean()
        {
            
            textBoxTekst.Text = "";
        }

        

        private void textBoxTekst_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxTekst.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxTekst, global.GetString("sadrzaj_req"));
            }
            else
            {
                errorProvider1.SetError(textBoxTekst,"");
            }
            }

        private void frmDodajRecenziju_Load(object sender, EventArgs e)
        {
            bindIGre();
        }

        private void bindIGre()
        {
            comboBoxIgre.DataSource = DBProizvodi.GetIgreAll();
            comboBoxIgre.ValueMember = "IgraID";
            comboBoxIgre.DisplayMember = "Naziv";
        }
        }
    }

