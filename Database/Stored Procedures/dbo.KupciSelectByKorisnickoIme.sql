SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[KupciSelectByKorisnickoIme]
@KorisnickoIme nvarchar(100)
AS
    SELECT *
	FROM Kupci
	WHERE KorisnickoIme=@KorisnickoIme

GO
