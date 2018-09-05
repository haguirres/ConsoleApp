CREATE TABLE [dbo].[Grade] (
    [CourseId] VARCHAR (30) NOT NULL,
    [StudentId]     INT NOT NULL,
    [Grade]    VARCHAR (5)  NOT NULL,
    CONSTRAINT [PK_GRADE] PRIMARY KEY CLUSTERED ([CourseId] ASC, [StudentId] ASC),
    CONSTRAINT [FK_GRADE_STUDENT] FOREIGN KEY ([StudentId]) REFERENCES [dbo].[Student] ([StudentId]),
    CONSTRAINT [FK_GRADE_TEACHER] FOREIGN KEY ([CourseId]) REFERENCES [dbo].[Course] ([CourseId])
);

