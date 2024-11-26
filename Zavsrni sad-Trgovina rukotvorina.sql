--use master

go
drop database if exists trgovinarukotvorina;
go
create database trgovinarukotvorina collate Croatian_CI_AS;
go
use trgovinarukotvorina;
go

create table proizvodi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
izradujeseod varchar(50),
cijena int not null,
namjena varchar(50) not null 
);

create table materijali(
sifra int not null primary key identity(1,1),
naziv varchar(30)not null,
vrsta varchar(50)not null
);

create table sastavnice(
sifra int not null primary key identity(1,1),
proizvodi int not null references proizvodi(sifra),
materijali int not null references materijali(sifra)
);

create table vrste(
sifra int not null primary key identity(1,1),
naziv int not null references materijali(sifra),
sastav varchar(50)not null
);

