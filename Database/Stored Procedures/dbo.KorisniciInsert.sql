SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[KorisniciInsert]
(
 @Ime nvarchar(100),
 @Prezime nvarchar(100),
 @Email nvarchar(100),
 @Telefon nvarchar(50),
 @KorisnickoIme nvarchar(100),
 @LozinkaHash nvarchar(100),
 @LozinkaSalt nvarchar(100)
)
AS
INSERT INTO Korisnici(Ime,Prezime,Email,Telefon,KorisnickoIme,LozinkaHash,LozinkaSalt)
VALUES(@Ime,@Prezime,@Email,@Telefon,@KorisnickoIme,@LozinkaHash,@LozinkaSalt)

SELECT @@IDENTITY


GO
