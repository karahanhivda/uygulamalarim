select e.FirstName as Adi, e.LastName as Soyadi, e.BirthDate as [Dogum Tarihi], e.City as Sehir, e.Country as Ulke, 
a.ShippedDate as SÝparisTarihi,
a.ShipCity as KargoSehri,
a.ShipCountry as KargoUlkesi
from Employees as e
inner join Orders as a on a.EmployeeID = e.EmployeeID
where Year(GETDATE()) - Year(e.BirthDate) <= 75 and e.Country = 'USA' and year(GETDATE()) - year(e.HireDate) between 30 and 40



select e.EmployeeID, count(a.OrderID) as SiparisSayisi, a.ShipCountry from Employees as e
inner join Orders as a on a.EmployeeID = e.EmployeeID
inner join Customers as c on a.CustomerID = c.CustomerID
where Year(GETDATE()) - Year(e.BirthDate) <= 75 and e.Country = 'USA' and year(GETDATE()) - year(e.HireDate) between 30 and 40
group by e.EmployeeID, a.ShipCountry
having count(a.OrderID)>10


select count(*) from Employees as e

select * from [Order Details] as o 
where o.OrderID
(
	select * from 
)





--select a.HireDate from Employees as a where YEAR(GETDATE()) - YEAR(a.HireDate) = 10

--select * from Employees as e where YEAR(DATEADD(YEAR, -30, GETDATE())) = YEAR(e.HireDate) and e.Country = 'USA'

--select e.BirthDate from Employees as e where Year(GETDATE()) - Year(e.BirthDate) <= 75