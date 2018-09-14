SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SelectIgreByNarudzbaID]
(
@NarudbaID int
)
AS

SELECT T1.IgraID, T1.Naziv,T1.Cijena,T2.Kolicina FROM Igre AS T1 inner join NarudzbeStavke AS T2 ON T1.IgraID=T2.IgraID
WHERE T2.NarudzbaID=@NarudbaID


GO
