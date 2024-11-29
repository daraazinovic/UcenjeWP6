use master;
go

drop database if exists webshop;
go

create database webshop;
go

use webshop;
go

create table proizvodi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
datumnabave datetime,
cijena decimal(18,2),
aktivan varchar (30)
);

