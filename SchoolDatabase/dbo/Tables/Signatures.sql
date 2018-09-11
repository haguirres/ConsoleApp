CREATE TABLE [dbo].[Signatures] (
    [SignaturesId]   INT          IDENTITY (1, 1) NOT NULL,
    [SignaturesName] VARCHAR (20) NOT NULL,
    [IsActive]       BIT          NOT NULL,
    CONSTRAINT [PK_Signatures] PRIMARY KEY CLUSTERED ([SignaturesId] ASC)
);



