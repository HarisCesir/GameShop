using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
   public class DBIzlazi
    {
       public static List<IzlazSelectByDatum_Result> SelectByDatum(DateTime DatumOD, DateTime DatumDO)
       {
           return connection.db.IzlazSelectByDatum(DatumOD, DatumDO).ToList();
       }
       public static void Insert(Izlazi izlaz, List<IzlazStavke> stavke)
       {
           
           int ID=Convert.ToInt32(connection.db.IzlazRobeInsert(izlaz.BrojRacuna,izlaz.Datum,izlaz.KupacID,izlaz.Zakljucen,izlaz.IznosBezPDV,izlaz.IznosSaPDV,izlaz.NarudzbaID,izlaz.SkladisteID));
           
           foreach (IzlazStavke iz in stavke)
           {
               connection.db.IzlaziStavkeInsert(ID, iz.ProizvodID, iz.Kolicina, iz.Cijena, iz.Popust);
           }
           connection.db.UpdateNarudba(izlaz.NarudzbaID, false);
       }
       public static List<Izlazi> SelectAllIzlazi()
       {
           List<Izlazi> Izlazi=connection.db.SelectIzlazi().ToList();
           Izlazi empty = new Izlazi();
           empty.BrojRacuna = "";
           Izlazi.Insert(0, empty);

           return Izlazi;
       }
    }
}
