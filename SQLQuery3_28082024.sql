--Gorev I
select od.ProductName, od.UnitPrice from Products as od
where od.UnitPrice >
(
select avg(od.UnitPrice) from Products as od
)


-- Gorev II
select p.ProductName, p.UnitPrice from Products as p
where p.UnitPrice = 
(
select max(p.UnitPrice) from Products as p
)

--Gorev III
select distinct( p.ProductName) from Products as p
inner join [Order Details] as od on p.ProductID = od.ProductID

--Gorev IV
select distinct( p.ProductName), p.ProductID from Products as p
inner join [Order Details] as od on p.ProductID = od.ProductID
where p.ProductID is null



--Gorev V
select s.CompanyName, o.ShipVia, count(*) as [Siparis Sayisi] from Orders as o
inner join Shippers as s on s.ShipperID = o.ShipVia
group by o.ShipVia, s.CompanyName 

--Gorev VI
select top(1) c.ContactName, max(Quantity*UnitPrice) as fiyat from Customers as c
inner join Orders as o on o.CustomerID = c.CustomerID
inner join [Order Details] as od on od.OrderID = o.OrderID
where c.Country = 'Brazil'
group by c.ContactName
order by fiyat desc

--Gorev VII
select p.ProductName, c.CategoryName, p.UnitPrice from Products as p
inner join Categories as c on c.CategoryID = p.CategoryID

create function KDVHesapla(@fiyat decimal(5,2))
returns decimal(5,2)
begin
	declare @kdvOrani decimal(5,2)
	declare @kdvFiyat decimal(5,2)
	set @kdvOrani = 0.18
	set @kdvFiyat = @fiyat * (1 + @kdvOrani)

	return @kdvFiyat
end

select p.ProductName, c.CategoryName, p.UnitPrice, dbo.KDVHesapla(p.UnitPrice) from Products as p
inner join Categories as c on c.CategoryID = p.CategoryID



	