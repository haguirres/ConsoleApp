CREATE TABLE [dbo].[Teacher] (
    [PersonId]  INT          NOT NULL,
    [TeacherId] INT          IDENTITY (1, 1) NOT NULL,
    [RFC]       VARCHAR (13) NOT NULL,
    [IsActive]  BIT          NOT NULL,
    CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED ([TeacherId] ASC),
    CONSTRAINT [FK_TEACHER_PERSON] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId])
);




GO
CREATE NONCLUSTERED INDEX [IX_FK_TEACHER_PERSON]
    ON [dbo].[Teacher]([PersonId] ASC);

