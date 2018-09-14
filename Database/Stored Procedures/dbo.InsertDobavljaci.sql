SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[InsertDobavljaci]
(

@Naziv nvarchar(150),
@Adresa nvarchar(100),
@KontaktOsoba nvarchar(100),
@Telefon nvarchar(25),
@Email nvarchar(50),
@ZiroRacun nvarchar(255),
@Status bit
)

AS

INSERT INTO Dobavljaci(Naziv,KontaktOsoba,Adresa,Telefon,Email,ZiroRacun,Status)
VALUES(@Naziv,@KontaktOsoba,@Adresa,@Telefon,@Email,@ZiroRacun,@Status)


GO
