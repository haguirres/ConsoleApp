CREATE TABLE [dbo].[WeekDay] (
    [WdId] INT          IDENTITY (1, 1) NOT NULL,
    [Day]  VARCHAR (10) NOT NULL,
    CONSTRAINT [PK_WeekDay] PRIMARY KEY CLUSTERED ([WdId] ASC)
);


