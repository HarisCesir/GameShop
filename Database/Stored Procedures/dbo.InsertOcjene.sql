SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[InsertOcjene]
(

@KupacID int,
@IgraID int,
@Datum datetime,
@Ocjena int

)
AS

INSERT INTO Ocjene(KupacID,ProizvodID,Datum,Ocjena) VALUES(@KupacID,@IgraID,@Datum,@Ocjena) SELECT @@IDENTITY

GO
