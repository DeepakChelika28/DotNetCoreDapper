CREATE PROCEDURE [dbo].[spUpdateProduct]
	@ProductId int,
	@Name varchar(50),
	@Description varchar(250),
	@UnitPrice decimal(18,2),
	@CategoryId int
AS
BEGIN

	UPDATE dbo.[Products] 
	set Name= @Name, Description= @Description,UnitPrice= @UnitPrice,CategoryId= @CategoryId
	where ProductId = @ProductId
END
