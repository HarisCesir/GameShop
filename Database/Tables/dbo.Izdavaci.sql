CREATE TABLE [dbo].[Izdavaci]
(
[IzdavacID] [int] NOT NULL IDENTITY(1, 1),
[Ime] [nvarchar] (50) COLLATE Latin1_General_CI_AI NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Izdavaci] ADD CONSTRAINT [PK_Izdavaci] PRIMARY KEY CLUSTERED  ([IzdavacID]) ON [PRIMARY]
GO
