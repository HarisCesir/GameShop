SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[IgreSelectBySkladiste]
(
@SkladisteID int
)
AS
   SELECT T5.IgraID,T5.SlikaThumb,T5.Naziv,T5.Šifra,T5.Cijena,
   SUM(DISTINCT T3.Kolicina)-ISNULL(SUM(DISTINCT T4.Kolicina),0) AS
   Kolicina 
   FROM Ulaz AS T1 LEFT JOIN Izlazi AS T2
   ON T1.SkladisteID=T2.SkladisteID inner join UlazStavke AS T3
   ON T1.UlazID=T3.UlazID LEFT JOIN IzlazStavke AS T4
   ON T2.IzlazID =T4.IzlazID AND T4.ProizvodID=T3.IgraID
   INNER JOIN Igre AS T5
   ON T3.IgraID=T5.IgraID
   WHERE T1.SkladisteID=@SkladisteID
   GROUP BY T5.IgraID,T5.SlikaThumb,T5.Naziv,T5.Šifra,T5.Cijena
   ORDER BY T5.Šifra
GO
