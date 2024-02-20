select * from Personeller
select PersonelID as [ personel numara ], Adi as [ isim ], SoyAdi as [ soyisim ] from Personeller

select p.Adi + '' + p.SoyAdi as [ tam isim ]from Personeller as p

select * from Personeller 
select p.Adi from Personeller as p 
WHERE p.UnvanEki = 'Ms.' or p.UnvanEki = 'Dr.'

select Year(GETDATE());


select * from Personeller as p
WHERE Year(GETDATE()) - YEAR(p.DogumTarihi) > 30 and p.Ulke = 'USA'


select * from Personeller as p
WHERE p.PersonelID IN(2,3,9)



use NewNorthwind
go
create table TestTablo(
 
	
	 Id int primary key,
	 UserName nvarchar(30),
	 Price int 
)

insert TestTablo values(1,'hasan',123)
insert TestTablo values(2,'ali',123)
insert TestTablo values(3,'veli',123)
insert TestTablo values(4,'ayþe',123)
insert TestTablo values(5,'mehmet',123)

select * from TestTablo
delete from TestTablo where Id > 3 and Price >100 

create table Test2Table(
	Id int primary key,
	UserName nvarchar(30) not null,
	Salary int,
	BirthDate date
)


insert Test2Table values(1,'hasan', 123, '2000-08-29')
insert Test2Table values(2,'ali', 1230, '1990-08-29')
insert Test2Table values(3,'veli',12300, '1980-08-29')
insert Test2Table values(4,'ayþe', 123000, '1970-08-29')
insert Test2Table values(5,'mehmet', 1230000, '1960-08-29')

select UserName, year(GETDATE()) - YEAR(BirthDate) as yas from Test2Table

select*from Test2Table
where Year(GETDATE()) - Year(BirthDate) > 30 

select * from Test2Table
where Year(GETDATE()) - YEAR(BirthDate) > 40

select*from Test2Table
where Salary> 1000 

select UrunAdi from Urunler
where BirimFiyati > 10 
order by BirimdekiMiktar

select top(10) UrunAdi, BirimFiyati from Urunler where BirimFiyati > 10
order by BirimFiyati
asc

select Count(*) from Urunler as u where u.BirimFiyati>100

select Sum(u.HedefStokDuzeyi) from Urunler as u where u.BirimFiyati>100

select Sum(u.HedefStokDuzeyi) from Urunler as u
select count(*) from Urunler
select avg(u.HedefStokDuzeyi) from Urunler as u

select * from Urunler as x where x.HedefStokDuzeyi < (select avg(u.HedefStokDuzeyi) from Urunler as u)

select* from Urunler as u where u.BirimFiyati>100

select Adi, PersonelID,  Year(GETDATE()) - Year(DogumTarihi) as Yas from Personeller as u
where year(GETDATE()) - Year(DogumTarihi) <
       (  select avg(Year(GETDATE()) - Year(u.DogumTarihi)) from Personeller as u )


 select*from Personeller