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
    public partial class FrmUlazRobe : Form
    {
        private Dobavljaci dobavljac;
        private List<UlazStavke> stavke = new List<UlazStavke>();
        private decimal iznosRacuna = 0;
        private decimal pdv = 0;

        public FrmUlazRobe()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void buttonPretraga_Click(object sender, EventArgs e)
        {
            FrmDobavljacPretraga frm = new FrmDobavljacPretraga();
            frm.ShowDialog();

            if (frm.dobavljac != null)
            {
                dobavljac = frm.dobavljac;
                textBoxNaziv.Text = dobavljac.Naziv;
                textBoxKontaktOsoba.Text = dobavljac.KontaktOsoba;
                textBoxTelefon.Text = dobavljac.Telefon;
            }
        }

        private void FrmUlazRobe_Load(object sender, EventArgs e)
        {
            BindSkladista();
        }

        private void BindSkladista()
        {
            comboBoxSkladiste.DataSource = DBSkladista.SelectAllSkladista();
            comboBoxSkladiste.ValueMember = "SkladisteID";
            comboBoxSkladiste.DisplayMember = "Naziv";
        }

        private void buttonzakljuci_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateChildren(ValidationConstraints.Enabled))
                {
                    Ulaz ulaz = new Ulaz();
                    ulaz.DobavljacID = dobavljac.DobavljacID;


                    ulaz.KorisnikID = global.prijavljenKorisnik.KorisnikID;
                    if (comboBoxSkladiste.SelectedIndex != 0)
                        ulaz.SkladisteID = Convert.ToInt32(comboBoxSkladiste.SelectedValue);
                    ulaz.BrojFakture = textBoxBrojFakture.Text;
                    ulaz.Datum = dateTimePickerDatum.Value;
                    ulaz.Napomena = textBoxNapomena.Text;
                    ulaz.Račun = iznosRacuna + pdv;
                    ulaz.PDV = pdv;


                    DBUlazRobe.Insert(ulaz, stavke);
                    MessageBox.Show(global.GetString("ulaz_succ"), "Nabavka robe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            DodajStavku();
            IgreGridBind();
        }

        private void IgreGridBind()
        {
            dataGridViewIgre.AutoGenerateColumns = false;
            dataGridViewIgre.DataSource = null;
            dataGridViewIgre.DataSource = stavke;
            dataGridViewIgre.ClearSelection();
        }

        private void DodajStavku()
        {  try{
           UlazStavke s = new UlazStavke();
         
                Igre igra=DBProizvodi.IgraIDBySifra(textBoxSifraProizvoda.Text);
                s.IgraID=igra.IgraID;
                
                
                s.Igre=DBProizvodi.IgreSelectByID(s.IgraID);
                s.Kolicina = Convert.ToInt32(textBoxKolicina.Text);

                s.Cijena = Convert.ToDecimal(textBoxCijena.Text);
                stavke.Add(s);
                
                iznosRacuna += s.Kolicina*s.Cijena;
                
                pdv = (decimal)0.17 * iznosRacuna;
                
                textBoxRacun.Text = Math.Round(iznosRacuna + pdv, 2).ToString();
              textBoxPDV.Text = Math.Round(pdv, 2).ToString();
                textBoxSifraProizvoda.Text="";
            textBoxKolicina.Text="";
            textBoxCijena.Text="";
            textBoxSifraProizvoda.Focus();

            
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDodajSkladista_Click(object sender, EventArgs e)
        {
            frmDodajSkladista frm = new frmDodajSkladista();
            frm.ShowDialog();
            BindSkladista();
        }

        private void comboBoxSkladiste_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxSkladiste.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBoxSkladiste, global.GetString("skladiste_req"));

            }
            else
            {
                errorProvider1.SetError(comboBoxSkladiste, "");
            }
        }

        private void textBoxBrojFakture_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxBrojFakture.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxBrojFakture, global.GetString("faktura_req"));
            }
            else
            {
                errorProvider1.SetError(textBoxBrojFakture, "");
            }
        }

        private void dataGridViewIgre_Validating(object sender, CancelEventArgs e)
        {

            if (dataGridViewIgre.Rows.Count == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(dataGridViewIgre, global.GetString("igre_req"));
            }
            else
            {
                errorProvider1.SetError(dataGridViewIgre, "");
            }
        }

        private void textBoxNaziv_Validating(object sender, CancelEventArgs e)
        {
            if(textBoxNaziv.Text.Trim()=="")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxNaziv, global.GetString("dobavljac_ob"));
            }
            else
            {
                errorProvider1.SetError(textBoxNaziv, "");
            }
        }
    }
}
