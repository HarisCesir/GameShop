using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
  public class DBOcjene
    {
      public static void InsertOcjene(Ocjene ocjena)
      {
          connection.db.InsertOcjene(ocjena.KupacID, ocjena.ProizvodID, ocjena.Datum, ocjena.Ocjena);

          //int ocjenaID = Convert.ToInt32(connection.db.InsertOcjene(ocjena.KupacID,ocjena.ProizvodID,ocjena.Datum,ocjena.Ocjena).FirstOrDefault());

      }

    }
}
