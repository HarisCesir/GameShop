SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SearchRecenzije]
(

@Naslov nvarchar(100)
)
AS

SELECT RecenzijaID,Naslov,Datum,Sadrzaj FROM Recenzije WHERE LOWER(Naslov) like @Naslov+'%'

GO
