SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[AukcijeBYKupac]
(

@ID int

)
AS

SELECT * From Aukcije WHERE KupacID=@ID


GO