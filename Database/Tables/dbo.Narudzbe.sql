CREATE TABLE [dbo].[Narudzbe]
(
[NarudzbaID] [int] NOT NULL IDENTITY(1, 1),
[BrojNarudzbe] [nvarchar] (20) COLLATE Latin1_General_CI_AI NOT NULL,
[KupacID] [int] NOT NULL,
[Datum] [datetime] NOT NULL,
[Status] [bit] NOT NULL,
[Otkazano] [bit] NOT NULL,
[Racun] [money] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Narudzbe] ADD CONSTRAINT [PK__Narudzbe__FBEC13578E3C05FD] PRIMARY KEY CLUSTERED  ([NarudzbaID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Narudzbe] ADD CONSTRAINT [FK_Narudzbe_Kupci] FOREIGN KEY ([KupacID]) REFERENCES [dbo].[Kupci] ([KupacID])
GO
