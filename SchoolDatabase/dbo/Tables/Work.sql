CREATE TABLE [dbo].[Work] (
    [TeacherId]     INT NOT NULL,
    [SchoolId] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_WORK] PRIMARY KEY CLUSTERED ([TeacherId] ASC, [SchoolId] ASC),
    CONSTRAINT [FK_WORK_SCHOOL] FOREIGN KEY ([SchoolId]) REFERENCES [dbo].[School] ([SchoolId]),
    CONSTRAINT [FK_WORK_TEACHER] FOREIGN KEY ([TeacherId]) REFERENCES [dbo].[Teacher] ([TeacherId])
);

