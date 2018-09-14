CREATE TABLE [dbo].[Aukcije]
(
[AukcijeID] [int] NOT NULL IDENTITY(1, 1),
[Naslov] [nvarchar] (500) COLLATE Latin1_General_CI_AI NOT NULL,
[Slika] [varbinary] (max) NOT NULL,
[Opis] [nvarchar] (500) COLLATE Latin1_General_CI_AI NOT NULL,
[DatumOD] [date] NOT NULL,
[DatumDO] [date] NOT NULL,
[Cijena] [money] NOT NULL,
[KorisnikID] [int] NOT NULL,
[KupacID] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Aukcije] ADD CONSTRAINT [PK_Aukcije] PRIMARY KEY CLUSTERED  ([AukcijeID]) ON [PRIMARY]
GO
