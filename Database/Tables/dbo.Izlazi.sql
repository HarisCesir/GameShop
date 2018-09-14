CREATE TABLE [dbo].[Izlazi]
(
[IzlazID] [int] NOT NULL IDENTITY(1, 1),
[BrojRacuna] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[Datum] [datetime] NOT NULL,
[KupacID] [int] NOT NULL,
[Zakljucen] [bit] NOT NULL,
[IznosBezPDV] [decimal] (18, 0) NOT NULL,
[IznosSaPDV] [decimal] (18, 0) NOT NULL,
[NarudzbaID] [int] NOT NULL,
[SkladisteID] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Izlazi] ADD CONSTRAINT [PK__Izlazi__153899C010242464] PRIMARY KEY CLUSTERED  ([IzlazID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Izlazi] ADD CONSTRAINT [FK_Izlazi_Kupci] FOREIGN KEY ([KupacID]) REFERENCES [dbo].[Kupci] ([KupacID])
GO
ALTER TABLE [dbo].[Izlazi] ADD CONSTRAINT [FK_Izlazi_Narudzbe] FOREIGN KEY ([NarudzbaID]) REFERENCES [dbo].[Narudzbe] ([NarudzbaID])
GO
ALTER TABLE [dbo].[Izlazi] ADD CONSTRAINT [FK_Izlazi_Skladista] FOREIGN KEY ([SkladisteID]) REFERENCES [dbo].[Skladista] ([SkladisteID])
GO
