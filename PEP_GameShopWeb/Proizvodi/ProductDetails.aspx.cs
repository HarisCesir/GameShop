using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services.Data;
using Services;
using Services.Util;
namespace PEP_GameShopWeb.Proizvodi
{   
    public partial class ProductDetails : System.Web.UI.Page
    {
        private List<Igre> preporukaListaProizvoda;
        int PID = 0;
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
            
           
             int ID = Convert.ToInt32(Request.QueryString["id"]);
             Igre igra = DBProizvodi.IgreSelectByID(ID);
              
              lblNaziv.Text = igra.Naziv.ToString();
              lblDatumIzdavanja.Text = igra.DatumIzdavanja.ToString();
              lblIzdavac.Text = igra.Izdavaci.Ime.ToString();
              lblOpis.Text = igra.Opis.ToString();
              lblCijena.Text = Math.Round(igra.Cijena, 2).ToString() + "KM";
              lblVrsta.Text = igra.Vrsta.Naziv;


              Image image = (Image)Slika;
              image.ImageUrl = "ImageHandlerr.ashx?IgraID=" + ID;

              
              video.Src = igra.Trailer;
              
              

              PID = ID;
              BinditemBasedPreporuke();

              if (preporukaListaProizvoda.Count() < 1)
              {
                  ItemBasedPreporukaGrid.Visible = false;
                  prepo.Visible = false;
              }
              else
              {
                  ItemBasedPreporukaGrid.Visible = true;
                  prepo.Visible = true;
              }

        }

        protected void dodajOcjenu_Click(object sender, EventArgs e)
        {



            if (User.Identity.Name != "")
            {
                int KupacID = DBKupci.SelectIDByKorisnickoIme(User.Identity.Name);
                int ocjena = Convert.ToInt32(Ocjena.SelectedValue);

                int ID = Convert.ToInt32(Request.QueryString["id"]);


                Ocjene oc = new Ocjene();

                oc.Ocjena = ocjena;
                oc.KupacID = KupacID;
                oc.ProizvodID = ID;
                oc.Datum = DateTime.UtcNow;

                DBOcjene.InsertOcjene(oc);

                Labelerror.Text = "Uspješno ste ocjenili proizvod!";

            }
            else
            {
                Labelerror.Text = "Da bi ste ocjenili proizvod morate biti logirani!";
            }


        }

        protected void ItemBasedPreporukaGrid_ItemCommand(object source, DataGridCommandEventArgs e)
        {
             if (e.CommandName == "dodajUKorpu")
            {
                int igraID = Convert.ToInt32(ItemBasedPreporukaGrid.DataKeys[e.Item.ItemIndex]);
                
                if (narudzba == null)
                {
                    narudzba = new Services.Data.Narudzbe();
                    var max = DBNarudzbe.GetZadnjaNarudza();

                    narudzba.NarudzbaID = max + 1;
                    int broj = Convert.ToInt32(max + 1);
                    narudzba.BrojNarudzbe = broj + "" + DateTime.Now.Year;
                    iznosRacuna = 0;
                    narudzba.Datum = DateTime.Now;
                    narudzba.Otkazano = false;
                    narudzba.Status = true;

                   
                }

                foreach (NarudzbeStavke s in narudzba.NarudzbeStavke)
                {
                    if (s.IgraID == igraID)
                    {
                        s.Kolicina = s.Kolicina + 1;
                        iznosRacuna = iznosRacuna + s.Igre.Cijena;

                        return;
                    }
                }

                NarudzbeStavke stavka = new NarudzbeStavke();
                stavka.IgraID = igraID;
                
                stavka.Igre = Services.Data.DBProizvodi.IgreSelectByID(igraID);

                stavka.Kolicina = 1;

                narudzba.NarudzbeStavke.Add(stavka);

                iznosRacuna = iznosRacuna + stavka.Igre.Cijena;
                HyperLink korpalink = (HyperLink)this.Master.FindControl("korpalink");
                korpalink.Text = string.Format("Moja Korpa({0})", narudzba.NarudzbeStavke.Count);



            }


        
        }

        protected void ItemBasedPreporukaGrid_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            ItemBasedPreporukaGrid.CurrentPageIndex = e.NewPageIndex;
            BinditemBasedPreporuke();
        }

        private void BinditemBasedPreporuke()
        {
            preporukaListaProizvoda = Services.Util.ItemBasedPreporuka.GetSlicneProizvode(PID);
            ItemBasedPreporukaGrid.DataSource = preporukaListaProizvoda;
            ItemBasedPreporukaGrid.DataBind();
        }

        protected void ItemBasedPreporukaGrid_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemIndex != -1)
            {
                Image image = (Image)e.Item.FindControl("thumbImage");
                image.ImageUrl = "ImageHandlerr.ashx?IgraID=" + preporukaListaProizvoda[e.Item.ItemIndex].IgraID;
            }
        }

        protected void btnDodajUKorpu_Click(object sender, EventArgs e)
        {
            int igraID = Convert.ToInt32(Request.QueryString["id"]);

            if (narudzba == null)
            {
                narudzba = new Services.Data.Narudzbe();
                var max = DBNarudzbe.GetZadnjaNarudza();

                narudzba.NarudzbaID = max + 1;
                int broj = Convert.ToInt32(max + 1);
                narudzba.BrojNarudzbe = broj + "" + DateTime.Now.Year;
                iznosRacuna = 0;
                narudzba.Datum = DateTime.Now;
                narudzba.Otkazano = false;
                narudzba.Status = true;


            }

            foreach (NarudzbeStavke s in narudzba.NarudzbeStavke)
            {
                if (s.IgraID == igraID)
                {
                    s.Kolicina = s.Kolicina + 1;
                    iznosRacuna = iznosRacuna + s.Igre.Cijena;

                    return;
                }
            }

            NarudzbeStavke stavka = new NarudzbeStavke();
            stavka.IgraID = igraID;

            stavka.Igre = Services.Data.DBProizvodi.IgreSelectByID(igraID);

            stavka.Kolicina = 1;

            narudzba.NarudzbeStavke.Add(stavka);

            iznosRacuna = iznosRacuna + stavka.Igre.Cijena;
            HyperLink korpalink = (HyperLink)this.Master.FindControl("korpalink");
            korpalink.Text = string.Format("Moja Korpa({0})", narudzba.NarudzbeStavke.Count);


        }

        
        }
    }
