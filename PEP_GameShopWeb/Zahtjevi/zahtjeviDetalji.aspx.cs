using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services;
using Services.Data;
namespace PEP_GameShopWeb.Zahtjevi
{
    public partial class zahtjeviDetalji : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(Request.QueryString["id"]);

            Services.Data.Zahtjevi zahtjev = DBZahtjevi.SelectByID(ID);

            naziv.Text = zahtjev.Naslov;
            datum.Text = zahtjev.Datum.ToString();




            autor.Text = zahtjev.Kupci.Ime;
            glasovi.Text = DBZahtjevi.SelectZahtjevi(ID).ToString();

            pglasova.Text = (20 - DBZahtjevi.SelectZahtjevi(ID)).ToString();

            

            
        }

        protected void glasaj_Click(object sender, EventArgs e)
        {
            int KupacID = DBKupci.SelectIDByKorisnickoIme(User.Identity.Name);
            int ZahtjevID = Convert.ToInt32(Request.QueryString["id"]);

            if (DBZahtjevi.ZahtjeviKupciProvjera(ZahtjevID, KupacID) >= 1)
            {
                LabelError.Text = "Već ste glasali za ovaj zahtjev!";
            }
            else
            {
                DBZahtjevi.ZahtjeviKupciInsert(ZahtjevID, KupacID);
                LabelError.Text = "Uspješno ste glasali";
                glasovi.Text = DBZahtjevi.SelectZahtjevi(ZahtjevID).ToString();
                pglasova.Text = (20 - DBZahtjevi.SelectZahtjevi(ZahtjevID)).ToString();
                
            }

        }

       
    }
}