SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[Korisnici_Select_By_KorisnickoIme]
(
@korisnickoIme nvarchar(50)
)
AS
SELECT *
FROM Korisnici
WHERE KorisnickoIme=@korisnickoIme 
GO
