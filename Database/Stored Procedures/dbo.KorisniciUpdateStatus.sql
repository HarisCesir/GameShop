SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[KorisniciUpdateStatus]
	@KorisnikID INT,
	@Status BIT
AS
    UPDATE Korisnici 
	SET
		Status = @Status
	WHERE KorisnikID = @KorisnikID

GO
