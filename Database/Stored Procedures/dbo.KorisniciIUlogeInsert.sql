SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[KorisniciIUlogeInsert]
(
	@KorisnikID INT,
	@UlogaID INT
 
)
AS
INSERT INTO KorisniciUloge(KorisnikID,UlogaID)
VALUES(@KorisnikID,@UlogaID)


GO
