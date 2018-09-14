CREATE TABLE [dbo].[Ocjene]
(
[OcjenaID] [int] NOT NULL IDENTITY(1, 1),
[ProizvodID] [int] NOT NULL,
[KupacID] [int] NOT NULL,
[Datum] [datetime] NOT NULL,
[Ocjena] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ocjene] ADD CONSTRAINT [PK__Ocjene__E6FC7B497BE2EE84] PRIMARY KEY CLUSTERED  ([OcjenaID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Ocjene] ADD CONSTRAINT [FK_Ocjene_Kupci] FOREIGN KEY ([KupacID]) REFERENCES [dbo].[Kupci] ([KupacID])
GO
ALTER TABLE [dbo].[Ocjene] ADD CONSTRAINT [FK_Ocjene_Igre] FOREIGN KEY ([ProizvodID]) REFERENCES [dbo].[Igre] ([IgraID])
GO
