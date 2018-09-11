CREATE TABLE [dbo].[Schedule] (
    [ScheduleId] INT      IDENTITY (1, 1) NOT NULL,
    [WdId]       INT      NOT NULL,
    [StartTime]  TIME (7) NOT NULL,
    [EndTime]    TIME (7) NOT NULL,
    CONSTRAINT [PK_Schedule] PRIMARY KEY CLUSTERED ([ScheduleId] ASC),
    CONSTRAINT [FK_Schedule_WeekDay] FOREIGN KEY ([WdId]) REFERENCES [dbo].[WeekDay] ([WdId])
);



GO
CREATE NONCLUSTERED INDEX [IX_FK_Schedule_WeekDay]
    ON [dbo].[Schedule]([WdId] ASC);

