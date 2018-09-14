using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services;
using Services.Data;
namespace PEP_GameShopWeb.Recenzije
{
    public partial class recenzijedetalji : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Request.QueryString["id"]);

            Services.Data.Recenzije recenzija = DBRecenzije.SelectByID(ID);

            int KorisnikID = recenzija.KorisnikID;

            autor.Text = DBKorisnici.KorisniciSelectByID(KorisnikID).Ime + " " + DBKorisnici.KorisniciSelectByID(KorisnikID).Prezime;
            datum.Text = recenzija.Datum.ToString();
            naslov.Text = recenzija.Igre.Naziv;
            sadrzaj.Text = recenzija.Sadrzaj;





        }
    }
}