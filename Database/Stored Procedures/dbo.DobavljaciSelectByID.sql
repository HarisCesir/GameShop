SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[DobavljaciSelectByID]
@DobavljacID int
AS
    SELECT *
	FROM Dobavljaci
	WHERE DobavljacID=@DobavljacID

GO
