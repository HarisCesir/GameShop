using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Data
{
  public  class DBNarudzbe
    {
      public static int GetZadnjaNarudza()
      {
          if (connection.db.Narudzbe.Count() > 0)
          {

              return connection.db.Narudzbe.Max(r => r.NarudzbaID);
          }
          return 0;
      }

      public static void InsertNarudzba(Narudzbe narudzba, string korisnickoIme)
      {
          narudzba.KupacID = connection.db.KupciSelectByKorisnickoIme(korisnickoIme).First().KupacID;

          connection.db.Narudzbe.Add(narudzba);
          connection.db.SaveChanges();

      }

      public static List<SELECTNARUDZBABYKUPAC_Result> SelectAllNarudzbe(int KupacID)
      {
          return connection.db.SELECTNARUDZBABYKUPAC(KupacID).ToList();
      }
      public static List<SelectAktivneNarudb_Result> SelectAktivne()
      {
          List<SelectAktivneNarudb_Result> Narudzbe=connection.db.SelectAktivneNarudb().ToList();

          SelectAktivneNarudb_Result narudzba = new SelectAktivneNarudb_Result();
          narudzba.BrojNarudzbe = " ";
          narudzba.NarudzbaID = 0;

          Narudzbe.Insert(0, narudzba);

          return Narudzbe;


      }
      public static List<SelectNarudzbaByID_Result> NarudzbaByID(int ID)
      {
        return  connection.db.SelectNarudzbaByID(ID).ToList();
      }
      public static void Update(int ID, bool status)
      {
          connection.db.UpdateNarudba(ID, status);
      }
    }
}
