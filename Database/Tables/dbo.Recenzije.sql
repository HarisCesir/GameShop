CREATE TABLE [dbo].[Recenzije]
(
[RecenzijaID] [int] NOT NULL IDENTITY(1, 1),
[Naslov] [nvarchar] (100) COLLATE Latin1_General_CI_AI NOT NULL,
[Datum] [datetime] NOT NULL,
[Sadrzaj] [nvarchar] (1000) COLLATE Latin1_General_CI_AI NOT NULL,
[KorisnikID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Recenzije] ADD CONSTRAINT [PK_Recenzije] PRIMARY KEY CLUSTERED  ([RecenzijaID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Recenzije] ADD CONSTRAINT [FK_Recenzije_Korisnici] FOREIGN KEY ([KorisnikID]) REFERENCES [dbo].[Korisnici] ([KorisnikID])
GO
