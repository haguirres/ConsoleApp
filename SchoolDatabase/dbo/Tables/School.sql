CREATE TABLE [dbo].[School] (
    [SchoolId]   VARCHAR (50)  NOT NULL,
    [AddressId]  INT           NOT NULL,
    [SchoolName] VARCHAR (100) NOT NULL,
    [SchoolType] INT      NOT NULL,
    [MinToPass]  INT           NULL,
    [IsActive] BIT NOT NULL DEFAULT 1, 
    PRIMARY KEY CLUSTERED ([SchoolId] ASC),
	CONSTRAINT [FK_SCHOOL_SCHOOLTYPE] FOREIGN KEY (SchoolType) REFERENCES [dbo].SchoolType (SchoolTypeId),
    CONSTRAINT [FK_SCHOOL_ADDRESS] FOREIGN KEY ([AddressId]) REFERENCES [dbo].[Address] ([AddressId])
);

