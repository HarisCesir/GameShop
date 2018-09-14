SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[InsertSkladista]
(

@Naziv nvarchar(150),
@Adresa nvarchar(100)
)

AS

INSERT INTO Skladista(Naziv,Adresa)
VALUES(@Naziv,@Adresa)


GO
