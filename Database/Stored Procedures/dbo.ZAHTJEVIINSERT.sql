SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[ZAHTJEVIINSERT]
(

@Naslov nvarchar(500),
@KupacID int,
@Datum datetime

)

AS

INSERT INTO Zahtjevi(Naslov,Datum,KupacID) VALUES(@Naslov,@Datum,@KupacID)

GO
