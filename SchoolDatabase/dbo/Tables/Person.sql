CREATE TABLE [dbo].[Person] (
    [PersonId]        INT          IDENTITY (1, 1) NOT NULL,
    [PersonAge]       INT          NOT NULL,
    [AddressId]       INT          NOT NULL,
    [CURP]            VARCHAR (18) NOT NULL,
    [Phone]           VARCHAR (12) NULL,
    [Email]           VARCHAR (50) NULL,
    [RolId]           INT          NOT NULL,
    [PersonFirstName] VARCHAR (50) NOT NULL,
    [PersonLastName]  VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([PersonId] ASC),
    CONSTRAINT [FK_PERSON_ADDRESS] FOREIGN KEY ([AddressId]) REFERENCES [dbo].[Address] ([AddressId]),
    CONSTRAINT [FK_PERSON_ROL] FOREIGN KEY ([RolId]) REFERENCES [dbo].[Roles] ([RolId])
);



GO
CREATE NONCLUSTERED INDEX [IX_FK_PERSON_ROL]
    ON [dbo].[Person]([RolId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_PERSON_ADDRESS]
    ON [dbo].[Person]([AddressId] ASC);

