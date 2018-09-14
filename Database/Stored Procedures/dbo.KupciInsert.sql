SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[KupciInsert]

@Ime nvarchar(50),
@Prezime nvarchar(50),
@Datum datetime,
@Email nvarchar(100),
@KorisnickoIme nvarchar(100),
@LozinkaHash nvarchar(50),
@LozinkaSalt nvarchar(50)

AS
   INSERT INTO Kupci(Ime,Prezime,DatumRegistracije,Email,KorisnickoIme,LozinkaHash,LozinkaSalt)
   VALUES(@Ime,@Prezime,@Datum,@Email,@KorisnickoIme,@LozinkaHash,@LozinkaSalt)

GO
