SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[IgreSelectBySifra]
(

@Sifra nvarchar(50)

)

AS

SELECT *
FROM Igre
WHERE Šifra=@Sifra


GO
