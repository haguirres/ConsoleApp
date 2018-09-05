CREATE TABLE [dbo].[Student] (
    [PersonId]   INT          NOT NULL,
    [StudentId] INT NOT NULL IDENTITY, 
    [Account] VARCHAR(15) NULL, 
    [IsActive] BIT NOT NULL, 
    CONSTRAINT [FK_STUDENT_PERSON] FOREIGN KEY ([PersonId]) REFERENCES [dbo].[Person] ([PersonId]),
    UNIQUE NONCLUSTERED ([PersonId] ASC), 
    CONSTRAINT [PK_Student] PRIMARY KEY ([StudentId])
);

