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
using System.Text.RegularExpressions;
namespace PEP_GameShop_Administracija.UlazRobe
{
    public partial class frmProizvodi : Form
    {
        private Igre Proizvodi { get; set; }
        public frmProizvodi()
        {
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void frmProizvodi_Load(object sender, EventArgs e)
        {
            BindVrsta();

            BindIzdavaci();

            BindIGre();

        }
        private void BindIzdavaci()
        {
            comboBoxIzdavaci.DataSource = DBProizvodi.GetIzdavaciAll();
            comboBoxIzdavaci.ValueMember = "IzdavacID";
            comboBoxIzdavaci.DisplayMember = "Ime";

        }
        private void BindVrsta()
        {
            comboBoxVrsta.DataSource = DBProizvodi.GetVrstaAll();
            comboBoxVrsta.ValueMember = "VrstaID";
            comboBoxVrsta.DisplayMember = "Naziv";
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Proizvodi = new Igre();
            openFileDialogSlika.ShowDialog();

            textBoxSlika.Text = openFileDialogSlika.FileName;

            Image image = Image.FromFile(textBoxSlika.Text);

            MemoryStream ms = new MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            Proizvodi.Slika = ms.ToArray();

            Image resizedImage = Services.Util.UiHelper.ResizeImage(image, new Size(200, 180));

           

            ms = new MemoryStream();

            resizedImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            Proizvodi.SlikaThumb = ms.ToArray();
            

            pictureBoxSlika.Image = resizedImage;

        }

        private void BindIGre()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = DBProizvodi.GetIgreAll();
        }

        private void buttonSacuvaj_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (this.ValidateChildren(ValidationConstraints.Enabled))
                {

                    if (Proizvodi == null)
                        Proizvodi = new Igre();

                    if (comboBoxVrsta.SelectedIndex > 0)
                    {
                        Proizvodi.VrstaID = Convert.ToInt32(comboBoxVrsta.SelectedValue);
                    }

                    Proizvodi.Šifra = textBoxSifra.Text.Trim();
                    Proizvodi.Naziv = textBoxNaziv.Text.Trim();
                    

                    decimal cijena = Convert.ToDecimal(textBoxCijena.Text);
                    Proizvodi.Cijena = Math.Round(cijena, 2);

                    Proizvodi.DatumIzdavanja = dateTimePickerDatum.Text;
                    Proizvodi.Opis = textBoxOpis.Text;
                    Proizvodi.Trailer = textBoxTrailer.Text;

                    if (comboBoxIzdavaci.SelectedIndex >= 0)
                    {
                        Proizvodi.IzdavacID = Convert.ToInt32(comboBoxIzdavaci.SelectedValue);
                    }


                    DBProizvodi.ProizvodiInsert(Proizvodi);

                    BindIGre();
                    clean();
                    MessageBox.Show(global.GetString("ulaz_succs"), "Proizvod", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
                
                
            }
           
        

        private void clean()
        {
            textBoxNaziv.Text = "";
            textBoxOpis.Text = "";
            textBoxCijena.Text = "";
            textBoxSifra.Text = "";
            textBoxSlika.Text = "";
            pictureBoxSlika.Image = null;
            textBoxTrailer.Text = "";
            comboBoxIzdavaci.SelectedIndex = 0;
            comboBoxVrsta.SelectedIndex = 0;
        }

        private void comboBoxVrsta_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxVrsta.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBoxVrsta, global.GetString("vrsta_req"));

            }
            else
            {
                errorProvider1.SetError(comboBoxVrsta, "");
            }
        }

        private void comboBoxIzdavaci_Validating(object sender, CancelEventArgs e)
        {
            if (comboBoxIzdavaci.SelectedIndex == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(comboBoxIzdavaci, global.GetString("izdavac_req"));

            }
            else
            {
                errorProvider1.SetError(comboBoxIzdavaci, "");

            }
        }

        private void textBoxSifra_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxSifra.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxSifra, global.GetString("sifra_req"));
            }
            else
            {
                errorProvider1.SetError(textBoxSifra, "");
            }
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

        private void textBoxCijena_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxCijena.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxCijena, global.GetString("cijena_req"));

            }
            else
            {
                errorProvider1.SetError(textBoxCijena, "");
            }
        }

        private void textBoxTrailer_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^(?:https?:\/\/)?(?:www\.)?(?:youtu\.be\/|youtube\.com\/(?:embed\/))((\w|-){11})(?:\S+)?$");
            Match match = regex.Match(textBoxTrailer.Text.Trim());

            if(match.Success)
            {
                errorProvider1.SetError(textBoxTrailer, "");
            }
            else
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxTrailer, global.GetString("trailer_req"));
            }
           
        }

        private void textBoxSlika_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxSlika.Text.Trim() == "")
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxSlika, global.GetString("slika_req"));


            }
            else
            {
                errorProvider1.SetError(textBoxSlika, "");

            }
        }
    }
}
