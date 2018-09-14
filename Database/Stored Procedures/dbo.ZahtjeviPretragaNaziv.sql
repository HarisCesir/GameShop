SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ZahtjeviPretragaNaziv]
(

 @Naslov nvarchar(500)
)
AS

SELECT T1.Naslov,T3.Ime,T1.Datum,count(T2.KupacID) AS Glasovi FROM Zahtjevi AS T1 inner join ZahtjeviKupci AS T2 ON T1.ZahtjeviID=T2.ZahtjevID inner join Kupci AS T3 ON T1.KupacID=T3.KupacID
WHERE T1.Naslov like @Naslov+'%'
GROUP BY T1.Naslov,T1.Datum,T3.Ime

GO
