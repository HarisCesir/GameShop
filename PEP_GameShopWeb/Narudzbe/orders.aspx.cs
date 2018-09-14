using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services.Data;
using System.Web.Security;
using Microsoft.AspNet.Membership;

namespace PEP_GameShopWeb.Narudzbe
{
    public partial class orders : System.Web.UI.Page
    {
        public Services.Data.Narudzbe narudzba
        {
            get { return (Services.Data.Narudzbe)Session["narudzba"]; }
            set { Session["narudzba"] = value; }
        }
        private decimal iznosRacuna
        {
            get { return (decimal)Session["Racun"]; }
            set { Session["Racun"] = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                bindgrid();
            }
        }

        private void bindgrid()
        {
            if (narudzba != null)
            {

                narudzbeGrid.DataSource = narudzba.NarudzbeStavke;



                narudzbeGrid.DataBind();
                racun.Text = Math.Round(iznosRacuna, 2).ToString();
                narudzba.Racun = Convert.ToDecimal(racun.Text);

                Button1.Enabled = true;

            }
            else
            {
                Button1.Enabled = false;
            }
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            DBNarudzbe.InsertNarudzba(narudzba, User.Identity.Name);

           

            narudzba = null;
            iznosRacuna = 0;
            racun.Text = "0";
            narudzbeGrid.DataBind();

            HyperLink cartLink = (HyperLink)this.Master.FindControl("korpalink");
            cartLink.Text = "Moja Korpa";

            Button1.Enabled = false;


            
              
            
        }

        protected void narudzbeGrid_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "obrisi")
            {

                int id = Convert.ToInt32(narudzbeGrid.DataKeys[e.Item.ItemIndex]);

                foreach (NarudzbeStavke item in narudzba.NarudzbeStavke)
                {
                    if (item.IgraID==id)
                    {
                        narudzba.NarudzbeStavke.Remove(item);
                        iznosRacuna = iznosRacuna - item.Igre.Cijena * item.Kolicina;
                        narudzbeGrid.DataSource = null;
                        narudzbeGrid.DataSource = narudzba.NarudzbeStavke;
                        narudzbeGrid.DataBind();

                        racun.Text = narudzba.Racun.ToString();


                        if (narudzba.NarudzbeStavke.Count == 0)
                        {
                            narudzba = null;
                            iznosRacuna = 0;
                            racun.Text = "0";
                            narudzbeGrid.DataBind();

                            HyperLink cartLink = (HyperLink)this.Master.FindControl("korpalink");
                            cartLink.Text = "Moja Korpa";

                            Button1.Enabled = false;
                        }


                        Response.Redirect(Request.RawUrl);

                        
                        return;
                    }
                }
                

            }

        }

       
        

       
    }
}