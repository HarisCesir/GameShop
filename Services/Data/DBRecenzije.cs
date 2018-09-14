using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
   public class DBRecenzije
    {
       public static void InsertRecenzije(Recenzije recenzija)
       {
           connection.db.INSERTRECENZIJA(recenzija.IgraID, recenzija.Datum, recenzija.Sadrzaj, recenzija.KorisnikID);
           
       }
       public static object SelectAll()
       {
           return connection.db.SELECTRECENZIJE().ToList();
       }
       public static Recenzije SelectByID(int recenzijaID)
       {

           return connection.db.SELECTRECENZIJABYID(recenzijaID).First();
       }
       public static object Search(string naslov)
       {

           return connection.db.SearchRecenzije(naslov).ToList();
       }
       public static void Update(string Sadrzaj,int recenzijaID)
       {
           connection.db.UpdateRecenzije(recenzijaID,Sadrzaj);
       }
    }
}
