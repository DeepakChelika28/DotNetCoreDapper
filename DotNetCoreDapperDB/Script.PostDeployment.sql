if not exists (select 1 from dbo.[Categories])
begin

	insert into dbo.[Categories] (Name,Description) 
	values ('Books','written or printed work consisting of pages');

end

if not exists (select 1 from dbo.[Products])
begin

	insert into dbo.[Products] (Name, Description, UnitPrice, CategoryId)
	values ('Mathematics Tricks', 'Detail Study of Mathematics', 20.20, 1),
	('HWPO', 'Biography of Mat Fraser', 10.10, 1);

end