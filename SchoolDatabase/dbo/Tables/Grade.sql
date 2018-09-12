CREATE TABLE [dbo].[Grade] (
    [CourseId]  VARCHAR (30) NOT NULL,
    [StudentId] INT          NOT NULL,
    [Grade1]    VARCHAR (5)  NOT NULL,
    [IsActive] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [PK_Grade] PRIMARY KEY CLUSTERED ([CourseId] ASC, [StudentId] ASC),
    CONSTRAINT [FK_GRADE_STUDENT] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId]),
    CONSTRAINT [FK_GRADE_TEACHER] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([CourseId])
);




GO
CREATE NONCLUSTERED INDEX [IX_FK_GRADE_STUDENT]
    ON [dbo].[Grade]([StudentId] ASC);

