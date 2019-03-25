insert into Customers values(6,'Name 1','Contat name 1',null,'City 1','10000','Vietnam')
insert into Customers(CustomerId,CustomerName) values(7,'Name 2')

insert into Customers(CustomerId,CustomerName) values(8,'Name 2'),(9,'Name 3')

insert into Products2(ProductId,ProductName)
select ProductId,ProductName from Products