create clustered index IX_Products_Id
on Products(ProductId)

--select * into Products_NoIndex from Products
select * from Products where ProductId = 2
select * from Products_NoIndex where ProductId = 2

--select * from Products where substring(Name,0,3) ='Name1' and Price  = 18

--insert into Products_NoIndex values(1,'Name 1',100)
--insert into Products_NoIndex values(2,'Name 2',200)
--insert into Products_NoIndex values(3,'Name 3',300)

drop index IX_Products_Id
on Products

create nonclustered index IX_Products_NamePice 
on Products (ProductName,Price)

select * from Products where ProductName ='Chang' and Price  = 19
select * from Products_NoIndex where ProductName ='Chang' and Price  = 19