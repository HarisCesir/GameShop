CREATE TABLE [dbo].[Uloge]
(
[UlogaID] [int] NOT NULL IDENTITY(1, 1),
[Naziv] [nvarchar] (100) COLLATE Latin1_General_CI_AI NOT NULL,
[Opis] [nvarchar] (500) COLLATE Latin1_General_CI_AI NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Uloge] ADD CONSTRAINT [PK_Uloge] PRIMARY KEY CLUSTERED  ([UlogaID]) ON [PRIMARY]
GO
