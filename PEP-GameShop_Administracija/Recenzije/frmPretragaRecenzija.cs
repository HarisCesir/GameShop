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
    public partial class frmPretragaRecenzija : Form
    {
        Services.Data.Recenzije recenzija { get; set; }
        public frmPretragaRecenzija()
        {
            InitializeComponent();
        }

        private void dataGridViewRecenzije_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPretragaRecenzija_Load(object sender, EventArgs e)
        {
            Bind();
        }

        private void Bind()
        {
            dataGridViewRecenzije.DataSource = DBRecenzije.Search(textBoxNaslov.Text);
            dataGridViewRecenzije.Columns[0].Visible = false;
        }

        private void textBoxNaslov_TextChanged(object sender, EventArgs e)
        {
            Bind();
        }

        private void dataGridViewRecenzije_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int RecenzijaId = Convert.ToInt32(dataGridViewRecenzije.SelectedRows[0].Cells[0].Value.ToString());
            recenzija = DBRecenzije.SelectByID(RecenzijaId);
        }

        private void buttonDetalji_Click(object sender, EventArgs e)
        {
            if (recenzija != null)
            {
                frmDetalji frm = new frmDetalji(recenzija);
                frm.ShowDialog();
            }
            
                
            
        }

        private void buttonIzmjeni_Click(object sender, EventArgs e)
        {

        }
    }
}
