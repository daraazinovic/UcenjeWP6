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

create table kupci(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
ulica varchar(30) not null,
mjesto varchar(30) not null
);


create table racuni(
sifra int not null primary key identity(1,1),
datum datetime,
kupac int not null references kupci(sifra),
status varchar(30) not null
);

create table stavke(
racun int not null references racuni(sifra),
proizvod int not null references proizvodi(sifra),
kolicina int not null,
cijena decimal(18,2)
);

