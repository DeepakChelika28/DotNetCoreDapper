CREATE PROCEDURE [dbo].[spGetCategoryById]
	@CategoryId int
AS
BEGIN
	select * 
	from dbo.[Categories]
	where CategoryId = @CategoryId;
END