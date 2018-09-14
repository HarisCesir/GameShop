SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[IzlazRobeInsert]
(

@BrojRacuna nvarchar(50),
@Datum date,
@KupacID int,
@Zakljucen bit,
@IznosBezPDv decimal,
@IznosSaPDv decimal,
@NarudzbaID int,
@SkladisteID int

)
AS

Insert into Izlazi(BrojRacuna,Datum,KupacID,Zakljucen,IznosBezPDV,IznosSaPDV,NarudzbaID,SkladisteID) VALUES(@BrojRacuna,@Datum,@KupacID,@Zakljucen,@IznosBezPDv,@IznosSaPDv,@NarudzbaID,@SkladisteID)

GO
