CREATE TABLE [dbo].[ZipCode] (
    [Neighborhood] INT          NOT NULL,
    [CityId]       INT          NOT NULL,
    [ZCName]       VARCHAR (59) NOT NULL,
    CONSTRAINT [PK_ZipCode] PRIMARY KEY CLUSTERED ([Neighborhood] ASC),
    CONSTRAINT [FK_ZIPCODE_CITY] FOREIGN KEY ([CityId]) REFERENCES [dbo].[City] ([CityId])
);




GO
CREATE NONCLUSTERED INDEX [IX_FK_ZIPCODE_CITY]
    ON [dbo].[ZipCode]([CityId] ASC);

