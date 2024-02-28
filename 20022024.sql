create database OrnekDb collate Turkish_CS_AS 
go

use OrnekDb
go

create table OrnekTable(
	id int,
	adi nvarchar(50),
	soyadi nvarchar(50),
	yas int,
	sehir nvarchar(50)
)
create table OrnekTable_1(
	id int,
	adi nvarchar(50),
	soyadi nvarchar(50),
	yas int,
	sehir nvarchar(50)
)

--not null
alter table OrnekTable_1 alter column adi nvarchar(50) not null 




create database FilmDb
go

use FilmDb 
go

create table Filmler(
	FilmId int primary key,
	FilmAdi nvarchar(100)
) 

create table Oyuncular(
	OyuncuId int primary key,
	OyuncuAdi nvarchar(100)
)

create table Oyuncular_Filmler(
	FilmID int foreign key references Filmler(FilmId),
	OyuncuID int foreign key references Oyuncular(OyuncuId)
)

create table Kategoriler(
	KategoriId int primary key,
	KategoriAdi nvarchar(100)
)

create table Kategoriler_Filmler(
	FilmID int foreign key references Filmler(FilmId),
	KategoriID int foreign key references Kategoriler(KategoriId)
)

create table Yonetmenler(
	YonetmenId int primary key,
	YonetmenAdi nvarchar(100)
)

create table Yonetmenler_Filmler(
	FilmID int foreign key references Filmler(FÝlmId),
	YonetmenID int foreign key references Yonetmenler(YonetmenId)
)




create database KutuphaneDb
go

use KutuphaneDb
go

create table Kitaplar(
	KitapId int primary key,
	KitapAdi nvarchar(50)
)

create table Kategoriler(
	KategoriId int primary key,
	KategoriAdi nvarchar(50)
)

create table Kategoriler_Kitaplar(
	KitapID int foreign key references Kitaplar(KitapId),
	KategoriID int foreign key references Kategoriler(KategoriId)
)

create table Salonlar(
	SalonId int primary key,
	SalonAdi nvarchar(50)
)

create table Kitaplar_Salonlar(
	KitapID int foreign key references Kitaplar(KitapId),
	SalonID int foreign key references Salonlar(SalonId)
)

create table Kullanicilar(
	KullaniciId  int primary key,
	KullaniciAdi nvarchar(50)
)

create table Kullanicilar_Kitaplar(
	KullaniciID int foreign key references Kullanicilar(KullaniciId),
	KitapID int foreign key references Kitaplar(KÝtapId)
)



create database MovieDb
go

use MovieDb 
go

create table Movies(
	MovieId int primary key,
	MovieName nvarchar(50)
)




