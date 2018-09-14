SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SelectIgreNameSifra]
(
@Naziv nvarchar(500),
@Sifra nvarchar(50)

)

AS

SELECT IgraID,Šifra,Naziv,Cijena,DatumIzdavanja,Status
FROM Igre
WHERE (Šifra = @Sifra OR @Sifra = '') AND 
	      (LOWER(Naziv) like LOWER(@Naziv) + '%' OR @Naziv = '') AND
	      Status = 1
	ORDER BY Šifra
GO
