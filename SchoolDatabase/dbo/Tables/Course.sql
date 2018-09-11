CREATE TABLE [dbo].[Course] (
    [CourseId]     VARCHAR (30) NOT NULL,
    [SignaturesId] INT          NOT NULL,
    [SchoolId]     VARCHAR (50) NOT NULL,
    [TeacherId]    INT          NOT NULL,
    [MinToPass]    INT          NULL,
    [Year]         INT          NOT NULL,
    [Credits]      INT          NULL,
    [StartDate]    DATETIME     NOT NULL,
    [EndDate]      DATETIME     NOT NULL,
    [IsActive]     BIT          NOT NULL,
    [ScheduleId]   INT          NOT NULL,
    CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED ([CourseId] ASC),
    CONSTRAINT [FK_Course_Schedule] FOREIGN KEY ([ScheduleId]) REFERENCES [dbo].[Schedule] ([ScheduleId]),
    CONSTRAINT [FK_COURSE_SCHOOL] FOREIGN KEY ([SchoolId]) REFERENCES [dbo].[School] ([SchoolId]),
    CONSTRAINT [FK_COURSE_SIGNATURES] FOREIGN KEY ([SignaturesId]) REFERENCES [dbo].[Signatures] ([SignaturesId]),
    CONSTRAINT [FK_COURSE_TEACHER] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[Teacher] ([TeacherId])
);




GO
CREATE NONCLUSTERED INDEX [IX_FK_COURSE_TEACHER]
    ON [dbo].[Course]([TeacherId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_COURSE_SIGNATURES]
    ON [dbo].[Course]([SignaturesId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_COURSE_SCHOOL]
    ON [dbo].[Course]([SchoolId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_FK_Course_Schedule]
    ON [dbo].[Course]([ScheduleId] ASC);

