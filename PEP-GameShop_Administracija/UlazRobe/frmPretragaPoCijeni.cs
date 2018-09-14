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
namespace PEP_GameShop_Administracija.UlazRobe
{
    public partial class frmPretragaPoCijeni : Form
    {
        public frmPretragaPoCijeni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal vecaOD;
            decimal manjaOD;
            if ((cijenaVeca.Text == "")&&(CijenaManja.Text==""))
            {
                vecaOD = 0;
                manjaOD = decimal.MaxValue;
            }
            else
            {
                if (cijenaVeca.Text == "")
                {
                    vecaOD = 0;
                }
                else
                {
                    vecaOD = Convert.ToDecimal(cijenaVeca.Text);
                }
       
                    if(CijenaManja.Text=="")
                    {
                        manjaOD=decimal.MaxValue;
                    }
                    else
                    {
                        manjaOD = Convert.ToDecimal(CijenaManja.Text);
                    }

            }


            dataGridViewCijena.AutoGenerateColumns = false;
            dataGridViewCijena.DataSource = DBProizvodi.GetIgrePoCijeni(vecaOD,manjaOD);
            
        }

        private void frmPretragaPoCijeni_Load(object sender, EventArgs e)
        {

        }
    }
}
