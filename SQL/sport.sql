use master
go

drop database if exists zoo;
go
 
create database sport;
go

use sport;
go

create table klub(
sifra int not null primary key identity(1,1),
naziv varchar(30) not null,
osnovan datetime not null,
stadion varchar(30) not null,
predsjednik varchar(30) not null,
liga varchar(30) not null 
);

create table igrac(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
datum_rodenja datetime not null,
pozicija varchar(30) not null,
broj_dresa int not null,
klub int not null references klub(sifra)
);

create table trener(
sifra int not null primary key identity(1,1),
ime varchar(30)not null,
prezime varchar(30)not null,
klub int not null references klub(sifra), 
nacionalnost varchar(30)not null,
iskustvo int not null
);

create table utakmica(
sifra int not null primary key identity(1,1),
datum datetime not null,
vrijeme time not null,
lokacija varchar(50) not null,
stadion int not null references klub(sifra),
domaci_klub int not null references klub(sifra),
gostujuci_klub int not null references klub(sifra)
);