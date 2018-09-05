CREATE TABLE [dbo].[Roles] (
    [RolId]   INT          IDENTITY (1, 1) NOT NULL,
    [RolName] VARCHAR (50) NOT NULL,
    [IsActive] BIT NOT NULL DEFAULT 1, 
    PRIMARY KEY CLUSTERED ([RolId] ASC)
);

