CREATE TABLE [dbo].[Course] (
    [CourseId]     VARCHAR (30) NOT NULL,
    [SignaturesId] INT          NOT NULL,
    [SchoolId]     VARCHAR (50) NOT NULL,
    [TeacherCURP]  VARCHAR (30) NOT NULL,
    [Schedule]     VARCHAR (20) NOT NULL,
    [MinToPass]    INT          NULL,
    [Year]         INT          NOT NULL,
    [Credits]      INT          NULL,
    PRIMARY KEY CLUSTERED ([CourseId] ASC),
    CONSTRAINT [FK_COURSE_SCHOOL] FOREIGN KEY ([SchoolId]) REFERENCES [dbo].[School] ([SchoolId]),
    CONSTRAINT [FK_COURSE_SIGNATURES] FOREIGN KEY ([SignaturesId]) REFERENCES [dbo].[Signatures] ([SignaturesId]),
    CONSTRAINT [FK_COURSE_TEACHER] FOREIGN KEY ([TeacherCURP]) REFERENCES [dbo].[Teacher] ([CURP])
);

