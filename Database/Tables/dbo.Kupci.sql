CREATE TABLE [dbo].[Kupci]
(
[KupacID] [int] NOT NULL IDENTITY(1, 1),
[Ime] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[Prezime] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[DatumRegistracije] [datetime] NOT NULL,
[Email] [nvarchar] (100) COLLATE Latin1_General_CI_AI NOT NULL,
[KorisnickoIme] [nvarchar] (100) COLLATE Latin1_General_CI_AI NOT NULL,
[LozinkaHash] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[LozinkaSalt] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[Status] [bit] NOT NULL CONSTRAINT [DF__Kupci__Status__52593CB8] DEFAULT ((1))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Kupci] ADD CONSTRAINT [PK__Kupci__A9593C7B54135C21] PRIMARY KEY CLUSTERED  ([KupacID]) ON [PRIMARY]
GO
