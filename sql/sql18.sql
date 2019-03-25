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
insert into Customers values(2,'Ana Trujillo Emparedados y helados','Ana Trujillo','Avda. de la Constitución 2222','México D.F.','05021','Mexico')
insert into Customers values(3,'Antonio Moreno Taquería','Antonio Moreno','Mataderos 2312','México D.F.','05023','Mexico')
insert into Customers values(4,'Around the Horn','Thomas Hardy','120 Hanover Sq.','London','WA1 1DP	','UK')
insert into Customers values(5,'Berglunds snabbköp','Christina Berglund','Berguvsvägen 8','Luleå','	S-958 22','Sweden')

drop table Supplier
create table Supplier(
	Id int,
	Name nvarchar(50),
	Country nvarchar(50)
)

insert into Supplier values(1,'Suplier 1','Germany')
insert into Supplier values(2,'Suplier 2','France')

--query in
select * from Customers
where Country in ('Germany','UK')

select * from Customers
where Country in (select Country from Supplier)

--between
drop table Products
create table Products
(
	ProductId int primary key,
	ProductName nvarchar(50),
	SupplierId int,
	CategoryId int,
	Unit nvarchar(50),
	Price decimal
)
go

insert into Products values(1,'Chais',1,1,'10 boxes x 20 bags',18);
insert into Products values(2,'Chang',1,1,'24 - 12 oz bottles',19);
insert into Products values(3,'Aniseed Syrup',1,2,'12 - 550 ml bottles',10);
insert into Products values(4,'Chef Anton''s Cajun Seasoning',2,2,'48 - 6 oz jars',22);
insert into Products values(5,'Chef Anton''s Gumbo Mix',2,2,'36 boxes',21.25);
insert into Products values(6,'Chef Anton''s Gumbo Mix',2,2,'36 boxes',21.25);

--Query between

select * from Products
where Price Between 10 and 20

--Exists
select Name from Supplier
where Exists (
select ProductName from Products 
where SupplierId = Supplier.Id and Price < 20
)


create table OrderDetails
(
	Id int,
	OrderId int,
	ProductId int,
	Quantity int
)
insert into OrderDetails values(1,10248,11,12)
insert into OrderDetails values(2,10248,42,10)
insert into OrderDetails values(3,10248,72,5)
insert into OrderDetails values(4,10248,14,9)
insert into OrderDetails values(5,10248,51,40)
insert into OrderDetails values(6,10248,6,10)
select * from OrderDetails

update OrderDetails set ProductId = 6 where Id = 2
select * from Products
where ProductId = 
any (select ProductId from OrderDetails where Quantity = 10)

select * from Products
where ProductId = 
all (select ProductId from OrderDetails where Quantity = 10)