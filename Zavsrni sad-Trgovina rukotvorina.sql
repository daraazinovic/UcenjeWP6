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

create table vrste(
sifra int not null primary key identity(1,1),
sastav varchar(50)not null
);

create table materijali(
sifra int not null primary key identity(1,1),
naziv varchar(30)not null,
vrsta int not null references vrste(sifra)
);

create table sastavnice(
sifra int not null primary key identity(1,1),
proizvod int not null references proizvodi(sifra),
materijal int not null references materijali(sifra)
);




insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Zahvalnice za svatove', 'vosak', 15, 'Zahvalnica za uzvanike svatova');

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Kućica sa crkvom','beton',15,'Ukras za domove');

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Kapela sa mirisnom svijećom','beton i svijeća',10,'Ukras za razne prigode');

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Mini vaza','beton i umjetno cvijeće',10,'Ukras za prigode i domove');

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Posudice za lučice', 'beton i lučica', 15, 'Ukras za dom')

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Figura bicikli', 'beton', 15, 'Ukras za dom')

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Set kućice i vaze sa lučicom', 'beton,vosak i cvijeće', 20,'Ukras za dom')



insert into vrste(sastav)
values('Drvo hrast');

insert into vrste(sastav)
values('Keramički prah');

insert into vrste(sastav)
values('Vosak');

insert into vrste(sastav)
values('Umjetno cvijeće');
