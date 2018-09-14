using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Data;
using Services.Util;
namespace Services.Data
{
  public class DBKupci
    {
      public static void KupciInsert(Kupci kupac)
      {
          connection.db.KupciInsert(kupac.Ime, kupac.Prezime, kupac.DatumRegistracije, kupac.Email, kupac.KorisnickoIme, kupac.LozinkaHash, kupac.LozinkaSalt);
          
      }

      public static int SelectIDByKorisnickoIme(string korisnickoIme)
      {
          return connection.db.KupciSelectByKorisnickoIme(korisnickoIme).First().KupacID;
      }

      public static Kupci SelectByKorisnickoIme(string korisnickoIme, string lozinka)
      {
          Kupci kupac = connection.db.KupciSelectByKorisnickoIme(korisnickoIme).FirstOrDefault();

          if (kupac != null)
          {

              if (UiHelper.GenerateHash(lozinka, kupac.LozinkaSalt) == kupac.LozinkaHash)
                  return kupac;

          }

          else
          {
              throw new Exception("Lonikna nije ispravna");
          }

          return null;
      }
      public static SelectKupacByNarudzbaID_Result SelectKupacByNarudzbaID(int ID)
      {
          return connection.db.SelectKupacByNarudzbaID(ID).First();
      }

      public static KUPACVRIJEDNOSTBYID_Result SELECTVRIJEDNOST(int id)
      {
          return connection.db.KUPACVRIJEDNOSTBYID(id).First();
      }
    }
}
