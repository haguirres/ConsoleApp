CREATE TABLE [dbo].[Course] (
    [CourseId]     VARCHAR (30) NOT NULL,
    [SignaturesId] INT          NOT NULL,
    [SchoolId]     VARCHAR (50) NOT NULL,
    [TeacherId]  INT NOT NULL,
    [MinToPass]    INT          NULL,
    [Year]         INT          NOT NULL,
    [Credits]      INT          NULL,
    [StartDate] DATE NOT NULL, 
    [EndDate] DATE NOT NULL, 
    [IsActive] BIT NOT NULL DEFAULT 1, 
    [ScheduleId] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([CourseId] ASC),
    CONSTRAINT [FK_COURSE_SCHOOL] FOREIGN KEY ([SchoolId]) REFERENCES [dbo].[School] ([SchoolId]),
    CONSTRAINT [FK_COURSE_SIGNATURES] FOREIGN KEY ([SignaturesId]) REFERENCES [dbo].[Signatures] ([SignaturesId]),
    CONSTRAINT [FK_COURSE_TEACHER] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[Teacher] ([TeacherId]), 
    CONSTRAINT [FK_Course_Schedule] FOREIGN KEY ([ScheduleID]) REFERENCES [Schedule]([ScheduleId])
);

