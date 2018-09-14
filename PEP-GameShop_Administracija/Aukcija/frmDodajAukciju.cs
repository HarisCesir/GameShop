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
using System.IO;
namespace PEP_GameShop_Administracija.Aukcija
{
    public partial class frmDodajAukciju : Form
    {
        private Services.Data.Aukcije aukcija { get; set; }
        public frmDodajAukciju()
        {
            
            InitializeComponent();
            this.AutoValidate = AutoValidate.Disable;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.ValidateChildren(ValidationConstraints.Enabled))
                {
                    aukcija = new Aukcije();

                    aukcija.DatumOD = DateTime.Now.Date;


                    aukcija.KorisnikID = global.prijavljenKorisnik.KorisnikID;
                    aukcija.DatumDO = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
                    aukcija.IgraID = Convert.ToInt32(comboBoxIgre.SelectedValue);

                    DBAukcija.InsertAukcija(aukcija);

                    MessageBox.Show("Uspješno dodana aukcija");
                    clean();

                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);            }


        }

        private void clean()
        {
            
            dateTimePicker1.Value = DateTime.Now;
        }

       

       

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value <= DateTime.Now)
            {
                e.Cancel = true;
                errorProvider1.SetError(dateTimePicker1, global.GetString("date_error"));
            }
            else
            {
                errorProvider1.SetError(dateTimePicker1, "");
            }
        }

        private void frmDodajAukciju_Load(object sender, EventArgs e)
        {
            comboBoxIgre.DataSource = DBProizvodi.GetIgreAll();
            comboBoxIgre.DisplayMember = "Naziv";
            comboBoxIgre.ValueMember = "IgraID";
        }
    }
}
