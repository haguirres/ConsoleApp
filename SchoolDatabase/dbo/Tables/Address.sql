CREATE TABLE [dbo].[Address] (
    [AddressId]    INT           IDENTITY (1, 1) NOT NULL,
    [Address1]     VARCHAR (200) NOT NULL,
    [Neighborhood] INT           NOT NULL,
    [ExtNum]       VARCHAR (10)  NOT NULL,
    [IntNum]       VARCHAR (10)  NULL,
    CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED ([AddressId] ASC),
    CONSTRAINT [FK_ADDRESS_ZIPCODE] FOREIGN KEY ([Neighborhood]) REFERENCES [dbo].[ZipCode] ([Neighborhood])
);




GO
CREATE NONCLUSTERED INDEX [IX_FK_ADDRESS_ZIPCODE]
    ON [dbo].[Address]([Neighborhood] ASC);

