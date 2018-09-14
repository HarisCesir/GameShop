using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services;
using Services.Data;
namespace PEP_GameShopWeb.Aukcija
{
    public partial class aukcijedetalji : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Request.QueryString["id"]);

            Services.Data.Aukcije aukc = DBAukcija.SelectByID(ID);

            List<Services.Data.AukcijaPonuda> ponude = DBAukcija.SelectPonude(ID);

            if(ponude==null)
            {
                LabelTrenutna.Text = aukc.Igre.Cijena.ToString();
            }
            else
            {
                decimal najveca = aukc.Igre.Cijena;
                foreach(AukcijaPonuda a in ponude)
                {
                    if(a.Ponuda>najveca)
                    {
                        najveca = a.Ponuda;
                    }
                }

                LabelTrenutna.Text = najveca.ToString();
            }


            LabelNaslov.Text = aukc.Igre.Naziv;
            
            LabelPočetak.Text = aukc.DatumOD.ToShortDateString();
            LabelKraj.Text = aukc.DatumDO.ToShortDateString();
            LabelPocetna.Text = aukc.Igre.Cijena.ToString();


            

            Image1.ImageUrl = "ImageHandler.ashx?id=" + ID;

        }

        protected void ButtonDodaj_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Request.QueryString["id"]);

            int KupacID=DBKupci.SelectIDByKorisnickoIme(User.Identity.Name);
            if ((TextBoxDodaj.Text == "")||(Convert.ToDecimal(TextBoxDodaj.Text)<Convert.ToDecimal(LabelTrenutna.Text)))
            {
                error.Visible = true;
            }
            else
            {
                error.Visible = false;
                DBAukcija.UpdateAukcija(KupacID, Convert.ToDecimal(TextBoxDodaj.Text), ID);
                LabelTrenutna.Text = TextBoxDodaj.Text;
                TextBoxDodaj.Text = "";
            }
        }
    }
}