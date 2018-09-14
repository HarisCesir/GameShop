using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Util;
using Services.Data;
using System.Data;
namespace Services.Data
{
  public class DBKorisnici
    {

      public static Korisnici SelectByKorisnickoIme(string korisnickoime, string lozinka)
      {
          Korisnici ko = connection.db.Korisnici_Select_By_KorisnickoIme(korisnickoime).FirstOrDefault();
          if (ko != null)
          {
              if (UiHelper.GenerateHash(lozinka, ko.LozinkaSalt) == ko.LozinkaHash.Trim())
              {
                  ko.uloge = connection.db.Korisnici_Uloge_SelectByKorisnik(ko.KorisnikID).ToList();
                  return ko;
              }
            
          }
          return null;
      }

      public static List<Uloge> GetUlogeAll()
      {
          return connection.db.UlogeALL().ToList();
      }

      public static void InsertKorisnik(Korisnici korisnik, List<Uloge> uloge)
      {
          try
          {
              int KorisnikID = Convert.ToInt32(connection.db.KorisniciInsert(korisnik.Ime, korisnik.Prezime, korisnik.Email,
                    korisnik.Telefon, korisnik.KorisnickoIme, korisnik.LozinkaHash, korisnik.LozinkaSalt).First());

              foreach (Uloge u in uloge)
              {
                  connection.db.KorisniciIUlogeInsert(KorisnikID, u.UlogaID);
              }
          }
          catch (EntityException e)
          {

              Util.ExceptionHandler.HandleException(e);
              return;
          }
      }

      public static object SearchByName(string name)
      {
          return connection.db.KorisniciSelectByNameSearch(name).ToList();
      }
      

      public static void DeleteKorisnici(int korisnikID)
      {
          connection.db.DeleteKOrisnici(korisnikID);
      }
      public static void DeleteUlogeKorisnika(int korisnikID)
      {
          connection.db.KorisniciUlogeDelete(korisnikID);
      }

      public static void KorisniciUpdateStatus(int korisnikID, bool status)
      {

          connection.db.KorisniciUpdateStatus(korisnikID, status);
      }

      public static Korisnici KorisniciSelectByID(int korisnikID)
      {
          return connection.db.KorisniciSelektById(korisnikID).FirstOrDefault();
      }

      public static void KorisnikUpdate(Korisnici korisnik)
      {
          connection.db.update_korisnik(korisnik.KorisnikID, korisnik.Ime, korisnik.Prezime, korisnik.Telefon, korisnik.Email);
      }

      public static List<Uloge> KorisniciSelectUloge(int korisnikID)
      {
          return connection.db.Korisnici_Uloge_SelectByKorisnik(korisnikID).ToList();
      }

      public static void KorisniciChangePassword(Korisnici korisnik)
      {
          connection.db.KorisniciChangePassword(korisnik.KorisnikID, korisnik.LozinkaSalt, korisnik.LozinkaHash);
      }

      public static void UpdateStatus(int korisnikID, bool status)
      {
          connection.db.KorisniciUpdateStatus(korisnikID, status);
      }

      public static void UpdateUloge(int korisnikID, List<Uloge> uloge)
      {
          connection.db.KorisniciUlogeDelete(korisnikID);

          foreach (Uloge item in uloge)
          {
              connection.db.KorisniciIUlogeInsert(korisnikID, item.UlogaID);
          }
      }
   
    }

}
