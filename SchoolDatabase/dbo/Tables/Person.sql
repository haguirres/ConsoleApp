CREATE TABLE [dbo].[Person]
(
	[PersonId] INT NOT NULL PRIMARY KEY, 
    [PersonName] VARCHAR(50) NOT NULL, 
    [PersonAge] INT NOT NULL, 
    [AddressId] INT NOT NULL, 
    [CURP] VARBINARY(18) NOT NULL, 
    [Phone] VARCHAR(12) NULL, 
    [Email] VARCHAR(50) NULL 
)
