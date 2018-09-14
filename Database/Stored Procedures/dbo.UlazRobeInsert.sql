SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[UlazRobeInsert]

    @BrojFakture NVARCHAR(20),
	@Datum DATETIME,
	@IznosRacuna DECIMAL (18,2),
	@PDV DECIMAL (18,2),
	@Napomena NVARCHAR(500),
	@SkladisteID INT,
	@KorisnikID INT,
	@DobavljacID INT

AS
  
  INSERT INTO Ulaz(BrojFakture,Datum,Račun,PDV,Napomena,SkladisteID,KorisnikID,DobavljacID)
  VALUES (@BrojFakture,@Datum,@IznosRacuna,@PDV,@Napomena,@SkladisteID,@KorisnikID,@DobavljacID)


GO
