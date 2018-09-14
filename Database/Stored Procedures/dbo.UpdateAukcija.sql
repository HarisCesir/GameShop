SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[UpdateAukcija]
(
@AukcijaID int,
@Cijena money,
@KupacID int
)
AS

UPDATE Aukcije

SET KupacID=@KupacID,Cijena=@Cijena
WHERE AukcijeID=@AukcijaID

GO
