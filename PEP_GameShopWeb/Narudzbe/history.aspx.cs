using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services.Data;
using System.Data;
namespace PEP_GameShopWeb.Narudzbe
{
    public partial class history : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bindgrid();
                bindAukcije();
            }

        }

        private void bindAukcije()
        {
             int id = DBKupci.SelectIDByKorisnickoIme(User.Identity.Name);
             aukcije.DataSource = DBAukcija.AukcijeByKorisnik(id);
             aukcije.DataBind();
            
        }

        private void bindgrid()
        {
            int id = DBKupci.SelectIDByKorisnickoIme(User.Identity.Name);

            List<SELECTNARUDZBABYKUPAC_Result> Sve = DBNarudzbe.SelectAllNarudzbe(id);
            Sve=Sve.GroupBy(x=>x.NarudzbaID).Select(x=>x.First()).ToList();


            DropDownListHistory.DataSource = Sve;
           

            DropDownListHistory.DataValueField = "NarudzbaID";
            DropDownListHistory.DataTextField = "Datum";

            

            DropDownListHistory.DataBind();
            
        }

        protected void DropDownListHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
                int ID = Convert.ToInt32(DropDownListHistory.SelectedValue);
                
                
                historija.DataSource = DBProizvodi.SelectByNarudzbaID(ID);
                historija.DataBind();

                List<SelectIgreByNarudzbaID_Result> Igre = DBProizvodi.SelectByNarudzbaID(ID);
               
                decimal racun = 0;

                foreach (SelectIgreByNarudzbaID_Result ig in Igre)
                {

                    racun = racun + ig.Cijena;


                }
                Label3.Text = Math.Round(racun, 2).ToString();

        
        }

        protected void aukcije_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            aukcije.CurrentPageIndex = e.NewPageIndex;
            aukcije.DataBind();
        }

        
    }
}