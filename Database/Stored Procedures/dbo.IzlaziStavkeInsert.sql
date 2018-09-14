SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[IzlaziStavkeInsert]
(

@IzlazID int,
@ProizvodID int,
@Kolicina int,
@Cijena decimal,
@Popust decimal
)
AS

Insert into IzlazStavke(IzlazID,ProizvodID,Kolicina,Cijena,Popust) 
VALUES(@IzlazID,@ProizvodID,@Kolicina,@Cijena,@Popust)

GO
