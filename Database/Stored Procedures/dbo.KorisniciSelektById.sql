SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[KorisniciSelektById]
@KorisnikId int
AS
    
	SELECT *
	FROM Korisnici
	WHERE KorisnikID=@KorisnikId

GO
