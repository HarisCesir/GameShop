CREATE TABLE [dbo].[KorisniciUloge]
(
[KorisnikUlogaID] [int] NOT NULL IDENTITY(1, 1),
[KorisnikID] [int] NOT NULL,
[UlogaID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KorisniciUloge] ADD CONSTRAINT [PK_KorisniciUloge] PRIMARY KEY CLUSTERED  ([KorisnikUlogaID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KorisniciUloge] ADD CONSTRAINT [FK_KorisniciUloge_Korisnici] FOREIGN KEY ([KorisnikID]) REFERENCES [dbo].[Korisnici] ([KorisnikID])
GO
ALTER TABLE [dbo].[KorisniciUloge] ADD CONSTRAINT [FK_KorisniciUloge_Uloge] FOREIGN KEY ([UlogaID]) REFERENCES [dbo].[Uloge] ([UlogaID])
GO
