using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
   public class DBAukcija
    {
       public static void InsertAukcija(Aukcije aukcija)
       {
           connection.db.InsertAukcije(aukcija.DatumOD, aukcija.DatumDO, aukcija.KorisnikID, aukcija.IgraID);

           connection.db.UpdateIgre(aukcija.IgraID);
       }
       public static object SelectAukcije()
       {
           List<SelectAukcije1_Result> Aukcije = connection.db.SelectAukcije1().ToList();
           List<SelectAukcije1_Result> AktivneAukcije = new List<SelectAukcije1_Result>();
           foreach (SelectAukcije1_Result se in Aukcije)
           {
               if (se.DatumDO > DateTime.Now)
               {
                   AktivneAukcije.Add(se);
               }
           }

           return AktivneAukcije;
       }
       public static object AukcijeAll()
       {
           List<SELECTALLAUKCIJE_Result> Aukcije = connection.db.SELECTALLAUKCIJE().ToList();

           SELECTALLAUKCIJE_Result empty = new SELECTALLAUKCIJE_Result();
           empty.AukcijeID = 0;
           empty.Naziv = "";

           Aukcije.Insert(0, empty);

           return Aukcije;
       }
       public static List<SelectAukcije1_Result> AukcijePoDatumu(DateTime DatumOD, DateTime DatumDO)
       {
           List<SelectAukcije1_Result> Aukcije = connection.db.SelectAukcije1().ToList();
           List<SelectAukcije1_Result> pretraga = new List<SelectAukcije1_Result>();

           foreach (SelectAukcije1_Result au in Aukcije)
           {
               if (au.DatumOD <= DatumOD && au.DatumDO > DatumDO)
               {
                   pretraga.Add(au);
               }
           }

           return pretraga;
       }
       public static Aukcije SelectByID(int ID)
       {
           return connection.db.AukcSelectByID(ID).First();
       }
       public static void UpdateAukcija(int KupacID, decimal ponuda,int aukcijaID)
       {
           connection.db.UpdateAukcija(aukcijaID, ponuda, KupacID, DateTime.Now);
       }
       public static List<AukcijeBYKupac_Result1> AukcijeByKorisnik(int ID)
       {
           

           
           List<AukcijeBYKupac_Result1> sve = connection.db.AukcijeBYKupac(ID).ToList();

           

           sve = sve.GroupBy(x => x.IgraID).Select(x => x.First()).ToList();

           return sve;

       }
       public static List<AukcijaPonuda> SelectPonude(int id)
       {
           return connection.db.SelectAukcijaPonude(id).ToList();

           
       }

       public static List<AukcijaPonudeInfo_Result> PonudeInfo(int id)
       {
           return connection.db.AukcijaPonudeInfo(id).ToList();
       }
      
    }
}
