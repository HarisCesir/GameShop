SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[KorisniciChangePassword]

@KorisnikID int,
@LozinkaSalt nvarchar(50),
@LozinkaHash nvarchar(50)
AS
    UPDATE Korisnici
	set
	LozinkaSalt=@LozinkaSalt,
	LozinkaHash=@LozinkaHash
	where KorisnikID=@KorisnikID

GO
