SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[IgreSelectByVrstaNaziv]
    @VrstaID int,
	@Naziv nvarchar(500),
	@Offset int,
	@MaxRows int,
	@TotalRows int OUTPUT
AS
	SET FMTONLY OFF

    CREATE TABLE #TempProizvodi
	(
	 RedniBroj int identity (0,1),
	 ProizvodID int
	)

	INSERT INTO #TempProizvodi
	SELECT IgraID
	FROM Igre
	WHERE (VrstaID=@VrstaID OR @VrstaID=0 ) AND (LOwer(Naziv) like Lower(@Naziv)+'%' OR @Naziv='') AND Status=1
	ORDER BY Naziv

	SELECT @TotalRows =@@ROWCOUNT

	SELECT T1.IgraID,T1.Naziv,T1.Šifra,T1.Cijena
	FROM Igre AS T1 INNER JOIN #TempProizvodi AS T2
	ON T1.IgraID=T2.ProizvodID
	WHERE T2.RedniBroj BETWEEN @Offset AND (@Offset+@MaxRows-1)

	DROP TABLE #TempProizvodi

GO
