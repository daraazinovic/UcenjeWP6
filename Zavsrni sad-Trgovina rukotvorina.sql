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
izradujeseod varchar(50) references materijali(sifra),
cijena int not null,
namjena varchar(50) not null 
);

create table materijali(
sifra int not null primary key identity(1,1),
naziv varchar(30)not null,
vrsta varchar(30) references vrste(sifra)
);

create table vrste(
sifra int not null primary key identity(1,1),
naziv varchar(50) references materijali(sifra)
);

create table sastavnica(
sifra int not null primary key identity(1,1),
proizvodi varchar(50) references proizvodi(sifra),
materijali varchar(50) references materijali(sifra)
);