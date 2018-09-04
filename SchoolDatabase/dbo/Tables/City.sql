CREATE TABLE [dbo].[City] (
    [CityId]   INT          IDENTITY (1, 1) NOT NULL,
    [StateId]  INT          NOT NULL,
    [CityName] VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([CityId] ASC),
    CONSTRAINT [FK_CITY_STATE] FOREIGN KEY ([StateId]) REFERENCES [dbo].[State] ([StateId])
);

