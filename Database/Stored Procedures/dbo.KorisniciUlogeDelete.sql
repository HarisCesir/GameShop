SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[KorisniciUlogeDelete]
(

@KorisnikID int
)
AS

DELETE FROM KorisniciUloge
WHERE KorisnikID=@KorisnikID


GO
