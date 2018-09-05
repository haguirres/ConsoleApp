CREATE TABLE [dbo].[Student] (
    [CURP]       VARCHAR (30) NOT NULL,
    [PersonName] VARCHAR (50) NOT NULL,
    [Age]        INT          NULL,
    [AddressId]  INT          NOT NULL,
    [PersonId]   INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([CURP] ASC),
    CONSTRAINT [FK_STUDENT_ADDRESS] FOREIGN KEY ([AddressId]) REFERENCES [dbo].[Address] ([AddressId]),
    CONSTRAINT [FK_STUDENT_PERSON] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([Id]),
    UNIQUE NONCLUSTERED ([PersonId] ASC)
);

