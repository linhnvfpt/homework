use TEDU

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

--select min
select * from Products

select min(Price) from Products

--select max
select max(Price) from Products

--count

select * from Products

select count(*) as TotalProduct from Products where Price > 20

select avg(Price) as AveragePrice from Products

select sum(Price) from Products

select ProductId as Id from Products

--select union

select * from Products
--union all
--select * from Products1

--update Products1 set Unit = null where ProductId = 3

--select ProductId,isnull(Unit,'No unit') from Products1

--select into
select * into Products2
from Products where Price > 20

select * from Products2
