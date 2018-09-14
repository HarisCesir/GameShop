SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[IzlazSelectByDatum]

@DatumOd DATETIME,
@DatumDo DATETIME

AS
  SELECT T3.Šifra,T3.Naziv,T3.Cijena, SUM(T2.Kolicina) AS Kolicina, SUM(T2.Kolicina*T2.Cijena) AS Iznos
  FROM Izlazi AS T1 inner join IzlazStavke AS T2
  ON T1.IzlazID=T2.IzlazID inner join Igre AS T3
  ON T3.IgraID=T2.ProizvodID
  WHERE T1.Datum between @DatumOd AND @DatumDo
  GROUP BY T3.Šifra,T3.Naziv,T3.Cijena
  ORDER BY Iznos DESC

GO
