using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Services.Data;
using Services.Util;
namespace PEP_GameShopWeb
{
    public partial class _Default : Page
    {
        private List<IgreSelectByVrstaNaziv_Result> igre;
       
        int IgraID = 0;
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
                BindVrste();
            }
            BindGrid();

        }



        private void BindVrste()
        {
            VrstaList.DataSource = DBProizvodi.GetVrstaAll();
            VrstaList.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            BindGrid();
        }

        private void BindGrid()
        {
            int vrstaID = 0;

            if (VrstaList.SelectedIndex != 0)
            {
                vrstaID = Convert.ToInt32(VrstaList.SelectedValue);
            }

            int offset = proizvodiGrid.CurrentPageIndex * proizvodiGrid.PageSize;
            igre = DBProizvodi.SelectByVrstaNaziv(vrstaID, TextBox1.Text, offset, proizvodiGrid.PageSize);
            proizvodiGrid.DataSource = igre;

            proizvodiGrid.VirtualItemCount = DBProizvodi.totalRows;
            proizvodiGrid.DataBind();
        }

        protected void proizvodiGrid_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemIndex != -1)
            {
                Image image = (Image)e.Item.FindControl("ThumbImage");
                image.ImageUrl = "ImageHandler.ashx?IgraID=" + igre[e.Item.ItemIndex].IgraID;

                int id = igre[e.Item.ItemIndex].IgraID;
                Igre igr = DBProizvodi.IgreSelectByID(id);
                if (igr.Aukcija == true)
                {
                    Image Image = (Image)e.Item.FindControl("AukcijaSlika");
                    Image.ImageUrl = "slika.jpg";

                    CheckBox c = (CheckBox)e.Item.FindControl("aukcijac");
                    c.Checked = true;
                   
                }

                


            }
        }

        protected void proizvodiGrid_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            if (e.CommandName == "dodajUKorpu")
            {
                int igraID = Convert.ToInt32(proizvodiGrid.DataKeys[e.Item.ItemIndex]);
                IgraID = igraID;
                
                
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
            




        

        protected void proizvodiGrid_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            proizvodiGrid.CurrentPageIndex = e.NewPageIndex;
            BindGrid();
        }

       

       


        }

        

        

       
    }
