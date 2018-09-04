CREATE TABLE [dbo].[Teacher] (
    [CURP]       VARCHAR (30) NOT NULL,
    [PersonName] VARCHAR (50) NOT NULL,
    [Age]        INT          NULL,
    [AddressId]  INT          NOT NULL,
    [PersonId]   INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([CURP] ASC),
    CONSTRAINT [FK_TEACHER_ADDRESS] FOREIGN KEY ([AddressId]) REFERENCES [dbo].[Address] ([AddressId]),
    CONSTRAINT [FK_TEACHER_PERSON] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId]),
    UNIQUE NONCLUSTERED ([PersonId] ASC)
);

