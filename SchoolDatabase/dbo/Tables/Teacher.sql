CREATE TABLE [dbo].[Teacher] (
    [PersonId]   INT          NOT NULL,
    [TeacherId] INT NOT NULL IDENTITY, 
    [RFC] VARCHAR(13) NOT NULL, 
    [IsActive] BIT NOT NULL DEFAULT 1, 
    CONSTRAINT [FK_TEACHER_PERSON] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId]),
    UNIQUE NONCLUSTERED ([PersonId] ASC), 
    CONSTRAINT [PK_Teacher] PRIMARY KEY ([TeacherId])
);

