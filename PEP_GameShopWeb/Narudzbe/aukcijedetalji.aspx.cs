using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services;
using Services.Data;
namespace PEP_GameShopWeb.Narudzbe
{
    public partial class aukcijedetalji : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Request.QueryString["id"]);

            Services.Data.Aukcije aukc = DBAukcija.SelectByID(ID);

            LabelNaslov.Text = aukc.Igre.Naziv;
            
            LabelPočetak.Text = aukc.DatumOD.ToShortDateString();
            LabelKraj.Text = aukc.DatumDO.ToShortDateString();

            int id = DBKupci.SelectIDByKorisnickoIme(User.Identity.Name);

            List<Services.Data.AukcijeBYKupac_Result1> ponude = DBAukcija.AukcijeByKorisnik(id);

            decimal po = 0;
            foreach(AukcijeBYKupac_Result1 auk in ponude)
            {
                if(auk.AukcijeID==ID)
                {
                    if(auk.Ponuda>po)
                    {
                        po = auk.Ponuda;
                    }
                }
            }

            LabelTrenutna.Text = po.ToString();



            Image1.ImageUrl = "imageHandler.ashx?id=" + ID;
        }
    }
}