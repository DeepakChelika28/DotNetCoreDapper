CREATE PROCEDURE [dbo].[spGetProductById]
	@ProductId int
AS
BEGIN
	select * 
	from dbo.[Products]
	where ProductId = @ProductId;
END
