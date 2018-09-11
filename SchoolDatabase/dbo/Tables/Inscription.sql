﻿CREATE TABLE [dbo].[Inscription] (
    [StudentId]       INT          NOT NULL,
    [SchoolId]        VARCHAR (50) NOT NULL,
    [InscriptionDate] DATETIME     NOT NULL,
    CONSTRAINT [PK_Inscription] PRIMARY KEY CLUSTERED ([StudentId] ASC, [SchoolId] ASC),
    CONSTRAINT [FK_INSCRIPTION_SCHOOL] FOREIGN KEY ([SchoolId]) REFERENCES [dbo].[School] ([SchoolId]),
    CONSTRAINT [FK_INSCRIPTION_STUDENT] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId])
);




GO
CREATE NONCLUSTERED INDEX [IX_FK_INSCRIPTION_SCHOOL]
    ON [dbo].[Inscription]([SchoolId] ASC);

