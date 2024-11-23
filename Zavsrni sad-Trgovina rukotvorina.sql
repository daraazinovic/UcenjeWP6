--use master

go
drop database if exists trgovinarukotvorina;
go
create database trgovinarukotvorina;
go
use trgovinarukotvorina;
go
create table proizvodi(
sifra int,
naziv varchar(50),
izradujeseod varchar(50),
cijena int,
namjena varchar(50)
);

create table materijali(
sifra int,
naziv varchar(30),
vrsta varchar(30)
);

create table vrste(
sifra int,
naziv varchar(50)
);

create table sastavnica(
sifra int,
proizvodi varchar(50),
materijali varchar(50)
);