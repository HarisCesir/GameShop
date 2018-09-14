using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Services.Data;
namespace PEP_GameShopWeb
{
    /// <summary>
    /// Summary description for ImageHandler
    /// </summary>
    public class ImageHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            int IgraID = Convert.ToInt32(context.Request["IgraID"]);
            Igre igra = DBProizvodi.IgreSelectByID(IgraID);
            context.Response.ContentType = "image/Jpeg";
            context.Response.BinaryWrite(igra.SlikaThumb);
            
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