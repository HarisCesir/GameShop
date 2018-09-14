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
    public partial class aukcija : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridAukcije.DataSource = DBAukcija.SelectAukcije();
            GridAukcije.DataBind();
        }

        protected void GridAukcije_PageIndexChanged(object source, DataGridPageChangedEventArgs e)
        {
            GridAukcije.CurrentPageIndex = e.NewPageIndex;
            GridAukcije.DataBind();
        }

      

        
    }
}