SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[UpdateNarudba]
(
@ID int,
@Status bit
)
AS

UPDATE Narudzbe
SET
Status=@Status
WHERE NarudzbaID=@ID

GO
