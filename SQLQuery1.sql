select * from Customers as c
WHERE c.ContactName like 'A%' 
	or ContactName like 'D%' 
	or ContactName like 'E%' 

select * from Customers as c
WHERE c.ContactName like '[B-H]%'