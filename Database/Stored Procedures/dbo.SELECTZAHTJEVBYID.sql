SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SELECTZAHTJEVBYID]
(

@ZahtjevID int
)
AS

SELECT * FROM Zahtjevi WHERE ZahtjeviID=@ZahtjevID

GO
