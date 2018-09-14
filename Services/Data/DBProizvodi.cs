using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Data;
namespace Services.Data
{
  public  class DBProizvodi
    {
      public static int totalRows = 0;
      public static List<Vrsta> GetVrstaAll()
      {
          List<Vrsta> VrsteLista = connection.db.GetVrstaALL().ToList();

          Vrsta empty = new Vrsta();
          empty.VrstaID = 0;
          empty.Naziv = "";
          VrsteLista.Insert(0, empty);
          return VrsteLista;

      }

      public static List<Izdavaci> GetIzdavaciAll()
      {
          List<Izdavaci> Izdavaci=connection.db.GETIzdavaci().ToList();

          Izdavaci empty = new Izdavaci();
          empty.IzdavacID = 0;
          empty.Ime = "";
          Izdavaci.Insert(0, empty);
          return Izdavaci;

      }

      public static List<Igre> GetIgreAll()
      {
          return connection.db.SelectIgreAll().ToList();
      }
      public static List<Igre> GetIgrePoCijeni(decimal VecaOD, decimal ManjaOD)
      {
          List<Igre> IgreAll = connection.db.SelectIgreAll().ToList();
          List<Igre> Rezultati = new List<Igre>();

          foreach (Igre i in IgreAll)
          {
              if (i.Cijena > VecaOD && i.Cijena < ManjaOD)
              {
                  Rezultati.Add(i);
              }
          }

          return Rezultati;
      }


      public static void ProizvodiInsert(Igre proizvod)
      {
          connection.db.InsertIgre(proizvod.Naziv, proizvod.DatumIzdavanja, proizvod.IzdavacID, proizvod.Cijena, proizvod.Slika, proizvod.Trailer, proizvod.Opis, proizvod.VrstaID, proizvod.SlikaThumb, proizvod.Šifra);
      }

      public static object SearchIgre(string ime, string sifra)
      {
          return connection.db.SelectIgreNameSifra(ime,sifra).ToList();
      }
      public static Igre IgraIDBySifra(string sifra)
      {
          return connection.db.IgreSelectBySifra(sifra).FirstOrDefault();
      }
      public static Igre IgreSelectByID(int IgraID)
      {
          return connection.db.IgreSelectByID(IgraID).First();
      }

      public static List<IgreSelectByVrstaNaziv_Result> SelectByVrstaNaziv(int vrstaId, string naziv, int offset, int maxRows)
      {
          System.Data.Objects.ObjectParameter total = new System.Data.Objects.ObjectParameter("TotalRows", 0);
          List<IgreSelectByVrstaNaziv_Result> proizvodi = connection.db.IgreSelectByVrstaNaziv(vrstaId, naziv, offset, maxRows, total).ToList();

          
          totalRows = Convert.ToInt32(total.Value);

          return proizvodi;
      }
      public static object IgreSelectBySkladiste(int skladisteID)
      {
          return connection.db.IgreSelectBySkladiste(skladisteID).ToList();
      }
      public static List<SelectIgreByNarudzbaID_Result> SelectByNarudzbaID(int ID)
      {
          return connection.db.SelectIgreByNarudzbaID(ID).ToList();
      }
      public static List<IgreSifraIzvjestaj_Result> IgreSelectBySifra(string sifra)
      {
          return connection.db.IgreSifraIzvjestaj(sifra).ToList();
      }
    }
}
