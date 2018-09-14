using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Services;
using Services.Data;
namespace PEP_GameShopWeb.Narudzbe
{
    /// <summary>
    /// Summary description for imageHandler
    /// </summary>
    public class imageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int AukcijaID = Convert.ToInt32(context.Request["id"]);

            Services.Data.Aukcije aukc = Services.Data.DBAukcija.SelectByID(AukcijaID);
            context.Response.ContentType = "image/Jpeg";
            context.Response.BinaryWrite(aukc.Igre.Slika);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}