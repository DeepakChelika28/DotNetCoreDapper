CREATE PROCEDURE [dbo].[spDeleteProduct]
	@ProductId int
AS
BEGIN

	Delete
	from dbo.[Products] 
	where ProductId = @ProductId
END
