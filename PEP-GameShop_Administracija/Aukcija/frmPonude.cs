using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEP_GameShop_Administracija.Aukcija
{
    public partial class frmPonude : Form
    {
        public frmPonude()
        {
            InitializeComponent();
        }

        private void frmPonude_Load(object sender, EventArgs e)
        {
            comboBoxIgre.DataSource = Services.Data.DBAukcija.AukcijeAll();
            comboBoxIgre.DisplayMember = "Naziv";
            comboBoxIgre.ValueMember = "AukcijeID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ponudeInfo.AutoGenerateColumns = false;
            int id = Convert.ToInt32(comboBoxIgre.SelectedValue);
            ponudeInfo.DataSource = Services.Data.DBAukcija.PonudeInfo(id);

            
        }
    }
}
