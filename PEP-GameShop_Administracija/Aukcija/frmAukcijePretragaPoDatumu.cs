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
namespace PEP_GameShop_Administracija.Aukcija
{
    public partial class frmAukcijePretragaPoDatumu : Form
    {
        public frmAukcijePretragaPoDatumu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridViewAukcijeDatum.AutoGenerateColumns = false;
            gridViewAukcijeDatum.DataSource = DBAukcija.AukcijePoDatumu(datumOD.Value, datumDO.Value);
            
        }

        private void frmAukcijePretragaPoDatumu_Load(object sender, EventArgs e)
        {

        }
    }
}
