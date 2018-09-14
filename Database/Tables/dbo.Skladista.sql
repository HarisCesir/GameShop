CREATE TABLE [dbo].[Skladista]
(
[SkladisteID] [int] NOT NULL IDENTITY(1, 1),
[Naziv] [nvarchar] (150) COLLATE Latin1_General_CI_AI NOT NULL,
[Adresa] [nvarchar] (100) COLLATE Latin1_General_CI_AI NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Skladista] ADD CONSTRAINT [PK_Skladista] PRIMARY KEY CLUSTERED  ([SkladisteID]) ON [PRIMARY]
GO
