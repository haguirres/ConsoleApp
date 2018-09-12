CREATE TABLE [dbo].[SchoolUser] (
    [SchoolUserId] INT          IDENTITY (1, 1) NOT NULL,
    [RolId]        INT          NOT NULL,
    [UserName]     VARCHAR (50) NOT NULL,
    [Password]     VARCHAR (15) NOT NULL,
    [IsActive]     BIT          DEFAULT ('true') NOT NULL,
    CONSTRAINT [PK_SchoolUser] PRIMARY KEY CLUSTERED ([SchoolUserId] ASC),
    CONSTRAINT [FK_PERSON_ROLES] FOREIGN KEY ([RolId]) REFERENCES [dbo].[Roles] ([RolId])
);






GO
CREATE NONCLUSTERED INDEX [IX_FK_PERSON_ROLES]
    ON [dbo].[SchoolUser]([RolId] ASC);

