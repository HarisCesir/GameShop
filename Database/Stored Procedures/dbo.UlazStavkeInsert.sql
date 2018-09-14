SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[UlazStavkeInsert]

@UlazID int,
@IgradID int,
@Kolicina int,
@Cijena DECIMAL(18,2)
AS
    INSERT INTO UlazStavke(UlazID,IgraID,Kolicina,Cijena)
	VALUES(@UlazID,@IgradID,@Kolicina,@Cijena)

GO
