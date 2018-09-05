CREATE TABLE [dbo].[Address] (
    [AddressId] INT           IDENTITY (1, 1) NOT NULL,
    [Address]   VARCHAR (200) NOT NULL,
    [Neighborhood]   INT           NOT NULL,
    [ExtNum] INT NOT NULL, 
    [IntNum] NCHAR(10) NULL, 
    PRIMARY KEY CLUSTERED ([AddressId] ASC),
    CONSTRAINT [FK_ADDRESS_ZIPCODE] FOREIGN KEY ([Neighborhood]) REFERENCES [dbo].[ZipCode] ([Neighborhood])
);

