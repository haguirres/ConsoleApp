CREATE TABLE [dbo].[Student] (
    [PersonId]  INT          NOT NULL,
    [StudentId] INT          IDENTITY (1, 1) NOT NULL,
    [Account]   VARCHAR (15) NULL,
    [IsActive]  BIT          NOT NULL,
    CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED ([StudentId] ASC),
    CONSTRAINT [FK_STUDENT_PERSON] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId])
);




GO
CREATE NONCLUSTERED INDEX [IX_FK_STUDENT_PERSON]
    ON [dbo].[Student]([PersonId] ASC);

