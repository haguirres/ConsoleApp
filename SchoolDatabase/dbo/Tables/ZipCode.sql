CREATE TABLE [dbo].[ZipCode] (
    [Neighborhood] INT          NOT NULL,
    [CityId]  INT          NOT NULL,
    [ZCName]  VARCHAR (59) NOT NULL,
    PRIMARY KEY CLUSTERED ([Neighborhood] ASC),
    CONSTRAINT [FK_ZIPCODE_CITY] FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([CityId])
);

