CREATE TABLE [dbo].[Work] (
    [School_SchoolId]   VARCHAR (50) NOT NULL,
    [Teacher_TeacherId] INT          NOT NULL,
    CONSTRAINT [PK_Work] PRIMARY KEY CLUSTERED ([School_SchoolId] ASC, [Teacher_TeacherId] ASC),
    CONSTRAINT [FK_Work_School] FOREIGN KEY ([School_SchoolId]) REFERENCES [dbo].[School] ([SchoolId]),
    CONSTRAINT [FK_Work_Teacher] FOREIGN KEY ([Teacher_TeacherId]) REFERENCES [dbo].[Teacher] ([TeacherId])
);




GO
CREATE NONCLUSTERED INDEX [IX_FK_Work_Teacher]
    ON [dbo].[Work]([Teacher_TeacherId] ASC);

