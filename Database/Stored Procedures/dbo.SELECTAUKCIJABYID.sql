SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SELECTAUKCIJABYID]
(
@AukcijaID int
)
AS

SELECT * FROM Aukcija WHERE AukcijaID=@AukcijaID

GO
