using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
  public class DBDobavljaci
    {
      public static List<Dobavljaci> DobavljaciSelectByNaziv(string naziv)
      {
          return connection.db.DobavljaciSelectByNaziv(naziv).ToList();
      }
      public static Dobavljaci DobavljaciSelectByID(int dobavljacID)
      {
          return connection.db.DobavljaciSelectByID(dobavljacID).First();
      }
      public static void InsertDobavljaci(Dobavljaci dobavljac)
      {
          connection.db.InsertDobavljaci(dobavljac.Naziv, dobavljac.Adresa, dobavljac.KontaktOsoba, dobavljac.Telefon, dobavljac.Email, dobavljac.ZiroRacun, dobavljac.Status);


      }
    }
}
