CREATE TABLE [dbo].[Ulaz]
(
[UlazID] [int] NOT NULL IDENTITY(1, 1),
[BrojFakture] [nvarchar] (20) COLLATE Latin1_General_CI_AI NOT NULL,
[Datum] [date] NOT NULL,
[Račun] [decimal] (18, 2) NOT NULL,
[PDV] [numeric] (18, 2) NOT NULL,
[SkladisteID] [int] NOT NULL,
[KorisnikID] [int] NOT NULL,
[DobavljacID] [int] NOT NULL,
[Napomena] [nvarchar] (500) COLLATE Latin1_General_CI_AI NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ulaz] ADD CONSTRAINT [PK_Ulaz] PRIMARY KEY CLUSTERED  ([UlazID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ulaz] ADD CONSTRAINT [FK_Ulaz_Dobavljaci] FOREIGN KEY ([DobavljacID]) REFERENCES [dbo].[Dobavljaci] ([DobavljacID])
GO
ALTER TABLE [dbo].[Ulaz] ADD CONSTRAINT [FK_Ulaz_Korisnici] FOREIGN KEY ([KorisnikID]) REFERENCES [dbo].[Korisnici] ([KorisnikID])
GO
ALTER TABLE [dbo].[Ulaz] ADD CONSTRAINT [FK_Ulaz_Skladista] FOREIGN KEY ([SkladisteID]) REFERENCES [dbo].[Skladista] ([SkladisteID])
GO
