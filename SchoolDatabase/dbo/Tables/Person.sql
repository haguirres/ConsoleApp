CREATE TABLE [dbo].[Person]
(
	[PersonId] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PersonFirstName] VARCHAR(50) NOT NULL,
	[PersonLastName] VARCHAR(50) NOT NULL,	
    [PersonAge] INT NOT NULL, 
    [AddressId] INT NOT NULL, 
    [CURP] VARCHAR(18) NOT NULL, 
    [Phone] VARCHAR(12) NULL, 
    [Email] VARCHAR(50) NULL, 
    [RolId] INT NOT NULL, 
    CONSTRAINT [FK_PERSON_ADDRESS] FOREIGN KEY ([AddressId]) REFERENCES Address([AddressId]), 
    CONSTRAINT [FK_PERSON_ROL] FOREIGN KEY ([RolId]) REFERENCES [Roles]([RolId]) 
)
