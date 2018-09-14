SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[DobavljaciSelectByNaziv]

@Naziv nvarchar(100)
AS
    SELECT *
	FROM Dobavljaci
	WHERE (LOWER(Naziv) LIKE LOWER(@Naziv)+'%' OR @Naziv='') AND Status=1
	ORDER BY Naziv

GO
