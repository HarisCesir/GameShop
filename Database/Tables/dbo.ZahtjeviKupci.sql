CREATE TABLE [dbo].[ZahtjeviKupci]
(
[ZahtjeviKupciID] [int] NOT NULL IDENTITY(1, 1),
[KupacID] [int] NOT NULL,
[ZahtjevID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ZahtjeviKupci] ADD CONSTRAINT [PK_ZahtjeviKupci] PRIMARY KEY CLUSTERED  ([ZahtjeviKupciID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ZahtjeviKupci] ADD CONSTRAINT [FK_ZahtjeviKupci_Kupci] FOREIGN KEY ([KupacID]) REFERENCES [dbo].[Kupci] ([KupacID])
GO
ALTER TABLE [dbo].[ZahtjeviKupci] ADD CONSTRAINT [FK_ZahtjeviKupci_Zahtjevi] FOREIGN KEY ([ZahtjevID]) REFERENCES [dbo].[Zahtjevi] ([ZahtjeviID])
GO
