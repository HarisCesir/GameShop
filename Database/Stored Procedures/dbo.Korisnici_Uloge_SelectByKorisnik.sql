SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Korisnici_Uloge_SelectByKorisnik]
(
@KorisnikID INT
)
AS
SELECT T2.*
FROM KorisniciUloge AS T1 inner join Uloge AS T2
on T1.UlogaID=T2.UlogaID
WHERE T1.KorisnikID=@KorisnikID

GO
