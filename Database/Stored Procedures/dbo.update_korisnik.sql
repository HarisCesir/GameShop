SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[update_korisnik]
(
@KorisnikID int,
@KorisnikIme nvarchar(100),
@KorisnikPrezime nvarchar(100),
@KorisnikTelefon nvarchar(50),
@KorisnikEmail nvarchar(100)
)
AS
UPDATE Korisnici
SET
Ime=@KorisnikIme,
Prezime=@KorisnikPrezime,
Telefon=@KorisnikTelefon,
Email=@KorisnikEmail
WHERE KorisnikID=@KorisnikID

GO
