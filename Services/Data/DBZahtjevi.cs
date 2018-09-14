using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
   public class DBZahtjevi
    {
       public static void InsertZahtjev(Zahtjevi zahtjev)
       {
           
           connection.db.ZAHTJEVIINSERT(zahtjev.Naslov,zahtjev.KupacID,zahtjev.Datum);
       }
       public static List<SELECTALLZAHTJEVI_Result> SelectALL()
       {
         List<SELECTALLZAHTJEVI_Result> zahtjevi = connection.db.SELECTALLZAHTJEVI().ToList();
         List<SELECTALLZAHTJEVI_Result> Aktivni = new List<SELECTALLZAHTJEVI_Result>();

           foreach(SELECTALLZAHTJEVI_Result z in zahtjevi)
           {
               if (connection.db.SELECTZAHTJEVIBROJGLASOVA(z.ZahtjeviID).Count() < 20)
               {
                   Aktivni.Add(z);
               }
           }

           return Aktivni;
         
       }
       public static Zahtjevi SelectByID(int ZahtjevID)
       {
           return connection.db.SELECTZAHTJEVBYID(ZahtjevID).FirstOrDefault();
       }
       public static int SelectZahtjevi(int ZahtjevID)
       {
           return connection.db.SELECTZAHTJEVIBROJGLASOVA(ZahtjevID).Count();

           
       }
       public static int ZahtjeviKupciProvjera(int ZahtjevID, int KupacID)
       {
           return connection.db.ZAHTJEVIKUPCIPROVJERA(KupacID, ZahtjevID).Count();
       }

       public static void ZahtjeviKupciInsert(int ZahtjevID, int KupacID)
       {
           connection.db.ZAHTJEVIKUPCIINSERT(KupacID, ZahtjevID);
       }

       public static List<ZAHTJEVINFO_Result> SelectSviZahtjevi()
       {
           return connection.db.ZAHTJEVINFO().ToList();
       }

       public static List<ZahtjeviPretragaNaziv_Result> ZahtjeviPretraga(string Naziv, bool glasovi)
       {
           List<ZahtjeviPretragaNaziv_Result> PoNazivu = connection.db.ZahtjeviPretragaNaziv(Naziv).ToList();

           

           
           List<ZahtjeviPretragaNaziv_Result> RezultatVise = new List<ZahtjeviPretragaNaziv_Result>();

           foreach (ZahtjeviPretragaNaziv_Result z in PoNazivu)
           {
               if (z.Glasovi >= 20)
               {
                   RezultatVise.Add(z);
                  
               }
           }

           if (glasovi == true)
           {
               return RezultatVise;
           }
           else
           {
               return PoNazivu;
           }

       }
    }
}
