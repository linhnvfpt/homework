use TEDU;

select * from Customers

select * from Customers 
where Country = 'Germany' and City = 'Berlin'

select * from Customers
where City = 'Berlin' or City = 'London'

select * from Customers
where Not Country = 'Germany'

--combine And, or and not

insert into Customers values(6,'Berglunds snabbköp','Christina Berglund','Berguvsvägen 8','Munich','S-958 22','Germany')

select * from Customers
where Country='Germany' and (City ='Berlin' or City = 'Munich')

select * from Customers 
where Not Country ='Germany' and Not Country='Mexico'