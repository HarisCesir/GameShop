SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[InsertIgre]
(

@Naziv NVARCHAR(500),
@DatumIzdavanja nvarchar(50),
@IzdavacID int,
@Cijena money,
@Slika varbinary(max),
@Trailer nvarchar(500),
@Opis nvarchar(500),
@VrstaID int,
@SlikaThumb varbinary(max),
@Sifra nvarchar(50)

)
AS

INSERT INTO Igre(Naziv,DatumIzdavanja,IzdavacID,Cijena,Slika,Trailer,Opis,VrstaID,SlikaThumb,Šifra)
VALUES(@Naziv,@DatumIzdavanja,@IzdavacID,@Cijena,@Slika,@Trailer,@Opis,@VrstaID,@SlikaThumb,@Sifra)


GO
