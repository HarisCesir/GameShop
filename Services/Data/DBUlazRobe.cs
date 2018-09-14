using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
  public class DBUlazRobe
    {
      public static void Insert(Ulaz ulaz, List<UlazStavke> ulazStavke)
      {
          int ulazId = Convert.ToInt32(connection.db.UlazRobeInsert(ulaz.BrojFakture, ulaz.Datum, ulaz.Račun, ulaz.PDV,
                                          ulaz.Napomena, ulaz.SkladisteID, ulaz.KorisnikID, ulaz.DobavljacID));
          foreach (UlazStavke s in ulazStavke)
          {
              connection.db.UlazStavkeInsert(ulazId, s.IgraID, s.Kolicina, s.Cijena);
          }
      }
    }
}
