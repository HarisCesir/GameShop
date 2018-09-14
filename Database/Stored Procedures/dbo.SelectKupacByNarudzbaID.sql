SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SelectKupacByNarudzbaID]
(

@NarudbaID int
)
AS

SELECT T1.Ime,T1.Prezime,T2.Datum,T1.KupacID FROM Kupci AS T1 inner join Narudzbe AS T2 ON T1.KupacID=T2.KupacID WHERE T2.NarudzbaID=@NarudbaID
GO
