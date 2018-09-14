CREATE TABLE [dbo].[UlazStavke]
(
[UlazStavkeID] [int] NOT NULL IDENTITY(1, 1),
[UlazID] [int] NOT NULL,
[IgraID] [int] NOT NULL,
[Kolicina] [int] NOT NULL,
[Cijena] [decimal] (18, 2) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UlazStavke] ADD CONSTRAINT [PK_UlazStavke] PRIMARY KEY CLUSTERED  ([UlazStavkeID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UlazStavke] ADD CONSTRAINT [FK_UlazStavke_Igre] FOREIGN KEY ([IgraID]) REFERENCES [dbo].[Igre] ([IgraID])
GO
ALTER TABLE [dbo].[UlazStavke] ADD CONSTRAINT [FK_UlazStavke_Ulaz] FOREIGN KEY ([UlazID]) REFERENCES [dbo].[Ulaz] ([UlazID])
GO
