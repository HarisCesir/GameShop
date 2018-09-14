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
    public partial class zahtjevi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindZahtjevi();
            }

        }

        protected void ButtonDodaj_Click(object sender, EventArgs e)
        {
            if (TextBoxZahtjev.Text == "")
            {
                zahtjevError.Text = "Unesite vaš zahtjev";
            }
            else
            {

                Services.Data.Zahtjevi zahtjev = new Services.Data.Zahtjevi();
                zahtjev.Naslov = TextBoxZahtjev.Text;
                zahtjev.Datum = DateTime.Now;
                int KupacID = DBKupci.SelectIDByKorisnickoIme(User.Identity.Name);
                zahtjev.KupacID = KupacID;
                DBZahtjevi.InsertZahtjev(zahtjev);
                BindZahtjevi();
                zahtjevError.Text = "";
            }
        }

        protected void zahtjeviGrid_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            

            zahtjeviGrid.CurrentPageIndex = e.NewPageIndex;
            BindZahtjevi();
        }

        private void BindZahtjevi()
        {
            zahtjeviGrid.DataSource = DBZahtjevi.SelectALL();
            zahtjeviGrid.DataBind();
        }
    }
}