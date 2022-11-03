create database MyStock
go
use MyStock
go
create table Cars (
	CarID int identity(1,1) primary key,
	CarName nvarchar(50),
	Manufacturer nvarchar(50),
	Price money,
	ReleasedYear int,
)

insert into Cars(CarName,Manufacturer,Price,ReleasedYear) values ('Accord', 'Honda Motor Comp', 2582900000, 2021)
insert into Cars(CarName,Manufacturer,Price,ReleasedYear) values ('Clarity', 'Honda Motor Comp', 3389900000, 2021)
insert into Cars(CarName,Manufacturer,Price,ReleasedYear) values ('BMW 8 Series', 'BMW', 8777700000, 2019)
insert into Cars(CarName,Manufacturer,Price,ReleasedYear) values ('Audi A6', 'Audi', 2582900000, 2020)

select * from Cars