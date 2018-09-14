CREATE TABLE [dbo].[Korisnici]
(
[KorisnikID] [int] NOT NULL IDENTITY(1, 1),
[Ime] [nvarchar] (100) COLLATE Latin1_General_CI_AI NOT NULL,
[Prezime] [nvarchar] (100) COLLATE Latin1_General_CI_AI NOT NULL,
[Email] [nvarchar] (100) COLLATE Latin1_General_CI_AI NOT NULL,
[Telefon] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[KorisnickoIme] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[LozinkaHash] [nchar] (100) COLLATE Latin1_General_CI_AI NOT NULL,
[LozinkaSalt] [nvarchar] (100) COLLATE Latin1_General_CI_AI NOT NULL,
[Status] [bit] NOT NULL CONSTRAINT [DF__Korisnici__Statu__5165187F] DEFAULT ((1))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Korisnici] ADD CONSTRAINT [PK_Korisnici] PRIMARY KEY CLUSTERED  ([KorisnikID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Korisnici] ADD CONSTRAINT [CS_Email] UNIQUE NONCLUSTERED  ([Email]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Korisnici] ADD CONSTRAINT [mail] UNIQUE NONCLUSTERED  ([Email]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Korisnici] ADD CONSTRAINT [CS_KorisnickoIme] UNIQUE NONCLUSTERED  ([KorisnickoIme]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Korisnici] ADD CONSTRAINT [korisnickoIme] UNIQUE NONCLUSTERED  ([KorisnickoIme]) ON [PRIMARY]
GO
