CREATE TABLE [dbo].[Dobavljaci]
(
[DobavljacID] [int] NOT NULL IDENTITY(1, 1),
[Naziv] [nvarchar] (100) COLLATE Latin1_General_CI_AI NOT NULL,
[KontaktOsoba] [nvarchar] (100) COLLATE Latin1_General_CI_AI NOT NULL,
[Adresa] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[Telefon] [nvarchar] (25) COLLATE Latin1_General_CI_AI NOT NULL,
[Email] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL,
[ZiroRacun] [nvarchar] (255) COLLATE Latin1_General_CI_AI NOT NULL,
[Status] [bit] NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Dobavljaci] ADD CONSTRAINT [PK_Dobavljaci] PRIMARY KEY CLUSTERED  ([DobavljacID]) ON [PRIMARY]
GO
