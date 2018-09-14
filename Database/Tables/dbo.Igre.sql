CREATE TABLE [dbo].[Igre]
(
[IgraID] [int] NOT NULL IDENTITY(1, 1),
[Naziv] [nvarchar] (500) COLLATE Latin1_General_CI_AI NOT NULL,
[DatumIzdavanja] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[IzdavacID] [int] NOT NULL,
[Cijena] [money] NOT NULL,
[Slika] [varbinary] (max) NULL,
[Trailer] [nvarchar] (500) COLLATE Latin1_General_CI_AI NOT NULL,
[Opis] [nvarchar] (500) COLLATE Latin1_General_CI_AI NOT NULL,
[VrstaID] [int] NOT NULL,
[SlikaThumb] [varbinary] (max) NULL,
[Status] [bit] NULL CONSTRAINT [DF_Igre_Status] DEFAULT ((1)),
[Šifra] [nvarchar] (50) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Igre] ADD CONSTRAINT [PK_Igre] PRIMARY KEY CLUSTERED  ([IgraID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Igre] ADD CONSTRAINT [FK_Igre_Izdavaci] FOREIGN KEY ([IzdavacID]) REFERENCES [dbo].[Izdavaci] ([IzdavacID])
GO
ALTER TABLE [dbo].[Igre] ADD CONSTRAINT [FK_Igre_Vrsta] FOREIGN KEY ([VrstaID]) REFERENCES [dbo].[Vrsta] ([VrstaID])
GO
