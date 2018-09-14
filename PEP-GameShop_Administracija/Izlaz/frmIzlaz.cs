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
namespace PEP_GameShop_Administracija.Izlaz
{
    public partial class frmIzlaz : Form
    {
        private Izlazi Izlaz=new Izlazi();
        private List<IzlazStavke> Stavke =new List<IzlazStavke>();
        public frmIzlaz()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void frmIzlaz_Load(object sender, EventArgs e)
        {
            comboBoxNarudžba.DataSource = DBNarudzbe.SelectAktivne().ToList();
            comboBoxNarudžba.ValueMember = "NarudzbaID";
            comboBoxNarudžba.DisplayMember = "BrojNarudzbe";
            dateTimePickerDatum.Visible = false;
        }

        private void comboBoxNarudžba_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID;
            SelectKupacByNarudzbaID_Result Kupac = new SelectKupacByNarudzbaID_Result();
            if (comboBoxNarudžba.SelectedIndex != 0)
            {
                ID = Convert.ToInt32(comboBoxNarudžba.SelectedValue);
                Kupac = DBKupci.SelectKupacByNarudzbaID(ID);

                textBoxIme.Text = Kupac.Ime;
                textBoxPrezime.Text = Kupac.Prezime;
                dateTimePickerDatum.Visible = true;
                dateTimePickerDatum.Value = Kupac.Datum;
                dataGridViewIgre.DataSource = DBProizvodi.SelectByNarudzbaID(ID);
                
                

                racun(ID);

            }
            else
            {
                textBoxIme.Text = "";
                textBoxPrezime.Text = "";
                dateTimePickerDatum.Visible = false;
            }
        }

        private void racun(int ID)
        {
           
            

            List<SelectIgreByNarudzbaID_Result> Igre = DBProizvodi.SelectByNarudzbaID(ID);
            decimal racun = 0;
            
            foreach (SelectIgreByNarudzbaID_Result ig in Igre)
            {
                
                racun = racun + ig.Cijena;
               
                 
            }

            decimal pdv = (decimal)0.17 * racun;

            textBoxIznos.Text = Math.Round(racun, 2).ToString();
            textBoxPDv.Text = Math.Round(pdv, 2).ToString();

            decimal ukupno = pdv + racun;

            textBoxUkupno.Text = Math.Round(ukupno, 2).ToString();
            
            
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
                  Izlaz = new Izlazi();
                  Stavke = new List<IzlazStavke>();
                  


            if (this.ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    Izlaz.Datum = DateTime.Now;
                    Izlaz.BrojRacuna = textBoxBrojracuna.Text;
                    int ID = Convert.ToInt32(comboBoxNarudžba.SelectedValue);
                    Izlaz.KupacID = DBKupci.SelectKupacByNarudzbaID(ID).KupacID;
                    Izlaz.Zakljucen = true;
                    Izlaz.NarudzbaID = ID;
                    Izlaz.IznosBezPDV = Convert.ToDecimal(textBoxIznos.Text);
                    Izlaz.IznosSaPDV = Convert.ToDecimal(textBoxUkupno.Text);
                    Izlaz.NarudzbaID = ID;

                    List<SelectIgreByNarudzbaID_Result> Igre = DBProizvodi.SelectByNarudzbaID(ID);

                    foreach (SelectIgreByNarudzbaID_Result ig in Igre)
                    {
                        IzlazStavke stavka = new IzlazStavke();
                        stavka.ProizvodID = ig.IgraID;
                        stavka.Kolicina = ig.Kolicina;
                        stavka.Cijena = ig.Cijena;
                        Stavke.Add(stavka);
                        

                    }


                    DBIzlazi.Insert(Izlaz, Stavke);
                    MessageBox.Show(global.GetString("izlaz_succ"), "Izlaz", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

                    
        }

        private void comboBoxNarudžba_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxNarudžba.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBoxNarudžba, global.GetString("narudzba_req"));
            }
            else
            {
                errorProvider1.SetError(comboBoxNarudžba, "");
            }
        }

        private void textBoxBrojracuna_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxBrojracuna.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxBrojracuna, global.GetString("brojracuna_req"));
            }
            else
            {
                errorProvider1.SetError(textBoxBrojracuna, "");
            }
        }
    }
}
