CREATE PROCEDURE [dbo].[spInsertProduct]
	@Name varchar(50),
	@Description varchar(250),
	@UnitPrice decimal(18,2),
	@CategoryId int
AS
BEGIN

	Insert into dbo.[Products] (Name,Description,UnitPrice,CategoryId)
	values (@Name,@Description,@UnitPrice,@CategoryId)

END