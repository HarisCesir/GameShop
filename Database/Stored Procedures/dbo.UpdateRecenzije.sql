SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[UpdateRecenzije]
(
@RecenzijaID int,
@Naslov nvarchar(100),
@Sadrzaj nvarchar(1000)

)
AS

Update Recenzije

SET Naslov=@Naslov,Sadrzaj=@Sadrzaj

WHERE RecenzijaID=@RecenzijaID

GO
