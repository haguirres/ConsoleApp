CREATE TABLE [dbo].[School] (
    [SchoolId]   VARCHAR (50)  NOT NULL,
    [AddressId]  INT           NOT NULL,
    [SchoolName] VARCHAR (100) NOT NULL,
    [SchoolType] CHAR (1)      NOT NULL,
    [MinToPass]  INT           NULL,
    PRIMARY KEY CLUSTERED ([SchoolId] ASC),
    CONSTRAINT [FK_SCHOOL_ADDRESS] FOREIGN KEY ([AddressId]) REFERENCES [dbo].[Address] ([AddressId])
);

