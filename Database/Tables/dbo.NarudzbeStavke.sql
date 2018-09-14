CREATE TABLE [dbo].[NarudzbeStavke]
(
[NarudzbaStavkaID] [int] NOT NULL IDENTITY(1, 1),
[NarudzbaID] [int] NOT NULL,
[IgraID] [int] NOT NULL,
[Kolicina] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NarudzbeStavke] ADD CONSTRAINT [PK__Narudzbe__7AC08D9826094F83] PRIMARY KEY CLUSTERED  ([NarudzbaStavkaID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NarudzbeStavke] ADD CONSTRAINT [FK_NarudzbeStavke_Igre] FOREIGN KEY ([IgraID]) REFERENCES [dbo].[Igre] ([IgraID])
GO
ALTER TABLE [dbo].[NarudzbeStavke] ADD CONSTRAINT [FK_NarudzbeStavke_Narudzbe] FOREIGN KEY ([NarudzbaID]) REFERENCES [dbo].[Narudzbe] ([NarudzbaID])
GO
