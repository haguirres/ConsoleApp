CREATE TABLE [dbo].[Inscription] (
    [CURP]            VARCHAR (30) NOT NULL,
    [SchoolId]        VARCHAR (50) NOT NULL,
    [InscriptionDate] DATE         NOT NULL,
    CONSTRAINT [PK_Inscription] PRIMARY KEY CLUSTERED ([CURP] ASC, [SchoolId] ASC),
    CONSTRAINT [FK_INSCRIPTION_SCHOOL] FOREIGN KEY ([SchoolId]) REFERENCES [dbo].[School] ([SchoolId]),
    CONSTRAINT [FK_INSCRIPTION_STUDENT] FOREIGN KEY ([CURP]) REFERENCES [dbo].[Student] ([CURP])
);

