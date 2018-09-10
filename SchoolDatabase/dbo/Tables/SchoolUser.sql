CREATE TABLE [dbo].[SchoolUser] (
    [SchoolUserId] INT          NOT NULL IDENTITY,
    [RolId]    INT          NOT NULL,
    [UserName] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (15) NOT NULL,
    [IsActive] BIT NOT NULL DEFAULT 1, 
    PRIMARY KEY CLUSTERED ([SchoolUserId] ASC),
    CONSTRAINT [FK_PERSON_ROLES] FOREIGN KEY ([RolId]) REFERENCES [dbo].[Roles] ([RolId])
);

