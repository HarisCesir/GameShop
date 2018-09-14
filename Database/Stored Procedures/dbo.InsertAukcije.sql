SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[InsertAukcije]
(

@Naslov nvarchar(500),
@Slika varbinary(MAX),
@Opis nvarchar(500),
@DatumOD date,
@DatumDO date,
@Cijena money,
@KorisnikID int,
@KupacID int

)

AS

INSERT INTO Aukcije(Naslov,Slika,Opis,DatumOD,DatumDO,Cijena,KorisnikID,KupacID) VALUES(@Naslov,@Slika, @Opis,@DatumOD,@DatumDO,@Cijena,@KorisnikID,@KupacID)

GO
