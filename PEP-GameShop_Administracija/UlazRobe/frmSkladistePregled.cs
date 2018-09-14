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
    public partial class frmSkladistePregled : Form
    {
        public frmSkladistePregled()
        {
            InitializeComponent();
        }

        private void frmSkladistePregled_Load(object sender, EventArgs e)
        {
            
            BindSkladista();
        }

        private void BindSkladista()
        {
            comboBoxSkladište.DataSource = DBSkladista.SelectAllSkladista().ToList();
            comboBoxSkladište.ValueMember = "SkladisteID";
            comboBoxSkladište.DisplayMember = "Naziv";
        }

        private void comboBoxSkladište_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSkladište.SelectedIndex != 0)
            {
                int skladisteID = Convert.ToInt32(comboBoxSkladište.SelectedValue);

                dataGridViewPregledSkladišta.DataSource = Services.Data.DBProizvodi.IgreSelectBySkladiste(skladisteID);
                dataGridViewPregledSkladišta.Columns[0].Visible = false;
                dataGridViewPregledSkladišta.ClearSelection();


            }
        }
    }
}
