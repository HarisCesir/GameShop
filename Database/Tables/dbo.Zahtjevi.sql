CREATE TABLE [dbo].[Zahtjevi]
(
[ZahtjeviID] [int] NOT NULL IDENTITY(1, 1),
[Naslov] [nvarchar] (500) COLLATE Latin1_General_CI_AI NOT NULL,
[Datum] [datetime] NOT NULL,
[KupacID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Zahtjevi] ADD CONSTRAINT [PK_Zahtjevi] PRIMARY KEY CLUSTERED  ([ZahtjeviID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Zahtjevi] ADD CONSTRAINT [FK_Zahtjevi_Kupci] FOREIGN KEY ([KupacID]) REFERENCES [dbo].[Kupci] ([KupacID])
GO
