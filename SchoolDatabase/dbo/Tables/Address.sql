CREATE TABLE [dbo].[Address] (
    [AddressId] INT           IDENTITY (1, 1) NOT NULL,
    [Address]   VARCHAR (200) NOT NULL,
    [ZipCode]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([AddressId] ASC),
    CONSTRAINT [FK_ADDRESS_ZIPCODE] FOREIGN KEY ([ZipCode]) REFERENCES [dbo].[ZipCode] ([ZipCode])
);

