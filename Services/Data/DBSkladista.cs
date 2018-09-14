using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
   public class DBSkladista
    {
       public static List<Skladista> SelectAllSkladista()
       {
           List<Skladista> skladistelista = connection.db.GetAllSkladista().ToList();
           Skladista empty = new Skladista();
           empty.Adresa = "";
           empty.Naziv = "";
           empty.SkladisteID = 0;
           skladistelista.Insert(0, empty);


           return skladistelista;
       }
       public static void InsertSkladista(Skladista skladiste)
       {
           connection.db.InsertSkladista(skladiste.Naziv, skladiste.Adresa);
       }
    }
}
