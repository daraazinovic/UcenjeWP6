use master

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
materijal int not null references materijali(sifra),
sastav varchar(50)not null
);


insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Zahvalnice za svatove', 'vosak', 15, 'Zahvalnica za uzvanike svatova');

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Kuæica sa crkvom','beton',15,'Ukras za domove');

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Kapela sa mirisnom svijeæom','beton i svijeæa',10,'Ukras za razne prigode');

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Mini vaza','beton i umjetno cvijeæe',10,'Ukras za prigode i domove');

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Posudice za luèice', 'beton i luèica', 15, 'Ukras za dom')

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Figura bicikli', 'beton', 15, 'Ukras za dom')

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Set kuæice i vaze sa luèicom', 'beton,vosak i cvijeæe', 20,'Ukras za dom')

