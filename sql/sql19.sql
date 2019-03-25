drop table Customers
create table Customers
(
	CustomerId int primary key,
	CustomerName nvarchar(50),
	ContactName nvarchar(50),
	Address nvarchar(50),
	City nvarchar(50),
	PostalCode nvarchar(50),
	Country nvarchar(50)
)
go

insert into Customers values(1,'Alfreds Futterkiste','Maria Anders','Obere Str. 57','Berlin','12209','Germany')
insert into Customers values(2,'Ana Trujillo Emparedados y helados','Ana Trujillo','Avda. de la Constituci�n 2222','M�xico D.F.','05021','Mexico')
insert into Customers values(3,'Antonio Moreno Taquer�a','Antonio Moreno','Mataderos 2312','M�xico D.F.','05023','Mexico')
insert into Customers values(4,'Around the Horn','Thomas Hardy','120 Hanover Sq.','London','WA1 1DP	','UK')
insert into Customers values(5,'Berglunds snabbk�p','Christina Berglund','Berguvsv�gen 8','Lule�','	S-958 22','Sweden')

--select order
select * from Customers 
where Country ='Mexico'
order by Country asc,CustomerName desc