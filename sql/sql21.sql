select * from Products

update Products set Price = 17
where ProductId = 1

update Products set Price = 17,CategoryId = 2, ProductName = 'Chais 1'
where ProductId = 1

delete from Products 
where ProductId = 1