CREATE TABLE [dbo].[Products]
(
	[ProductId] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] varchar(50) NOT NULL,
	[Description] varchar(250)  NULL, 
    [UnitPrice] DECIMAL(18, 2) NOT NULL, 
    [CategoryId] INT NOT NULL FOREIGN KEY REFERENCES Categories(CategoryId)
)
