CREATE TABLE [dbo].[Work] (
    [TeacheId]     INT NOT NULL,
    [SchoolId] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_WORK] PRIMARY KEY CLUSTERED ([TeacheId] ASC, [SchoolId] ASC),
    CONSTRAINT [FK_WORK_SCHOOL] FOREIGN KEY ([SchoolId]) REFERENCES [dbo].[School] ([SchoolId]),
    CONSTRAINT [FK_WORK_TEACHER] FOREIGN KEY ([TeacheId]) REFERENCES [dbo].[Teacher] ([TeacherId])
);

