use TEDU

select * from Customers 
where CustomerName like 'a%'

select * from Customers
where CustomerName like '%a'

select * from Customers
where CustomerName like '%or%'

select * from Customers
where CustomerName like '_r%'

select * from Customers
where CustomerName like 'a_%_%'

select * from Customers
where CustomerName like 'a%e'

select * from Customers
where CustomerName not like 'a%e'