using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace PEP_GameShop_Administracija
{
   public class global
    {
        public static Services.Data.Korisnici prijavljenKorisnik { get; set; }

        public static string GetString(string key)
        {
            ResourceManager rm = new ResourceManager("PEP_GameShop_Administracija.poruke", Assembly.GetExecutingAssembly());
            return rm.GetString(key);

            
        }
    }
}
