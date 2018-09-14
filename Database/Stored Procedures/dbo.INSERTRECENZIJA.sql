SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[INSERTRECENZIJA]
(

@Naslov nvarchar(100),
@Datum datetime,
@Sadrzaj nvarchar(1000),
@KorisnikID int


)
AS

INSERT INTO Recenzije(Naslov,Datum,Sadrzaj,KorisnikID) VALUES(@Naslov,@Datum,@Sadrzaj,@KorisnikID)

GO
