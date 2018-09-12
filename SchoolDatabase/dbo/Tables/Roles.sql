CREATE TABLE [dbo].[Roles] (
    [RolId]    INT          IDENTITY (1, 1) NOT NULL,
    [RolName]  VARCHAR (50) NOT NULL,
    [IsActive] BIT          DEFAULT ('true')NOT NULL,
    CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED ([RolId] ASC)
);



