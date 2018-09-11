CREATE TABLE [dbo].[State] (
    [StateId]   INT          IDENTITY (1, 1) NOT NULL,
    [StateName] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED ([StateId] ASC)
);



