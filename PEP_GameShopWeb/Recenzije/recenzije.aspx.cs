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
    
    public partial class recenzije : System.Web.UI.Page
    {
        //private List<SELECTRECENZIJE_Result> recenzija;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindRecenzije();
            }
        }

        private void BindRecenzije()
        {
            GridRecenzije.DataSource = Services.Data.DBRecenzije.SelectAll();
            GridRecenzije.DataBind();
        }

       

        protected void GridRecenzije_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            GridRecenzije.CurrentPageIndex = e.NewPageIndex;
            BindRecenzije();
        }

        
    }
}