CREATE TABLE [dbo].[Schedule]
(
	[ScheduleId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [WdId] INT NOT NULL, 
    [StartTime] TIME NOT NULL, 
    [EndTime] TIME NOT NULL, 
    CONSTRAINT [FK_Schedule_WeekDay] FOREIGN KEY ([WdId]) REFERENCES [WeekDay]([WdId])
)
