SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[GETIzdavaci]

AS

SELECT *
FROM Izdavaci
ORDER BY IzdavacID

GO