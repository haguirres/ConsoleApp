CREATE TABLE [dbo].[SchoolType] (
    [SchoolTypeId] INT          IDENTITY (1, 1) NOT NULL,
    [Type]         VARCHAR (20) NOT NULL,
    CONSTRAINT [PK_SchoolType] PRIMARY KEY CLUSTERED ([SchoolTypeId] ASC)
);


