use master;
go

drop database if exists tvrtka;
go

create database tvrtka;
go

use tvrtka;

create table zaposlenici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
datumrodenja datetime,
placa decimal(18,2),
invalid varchar (50)
);


create table slika(
sifra int not null primary key identity(1,1),
zaposlenik int not null references zaposlenici(sifra),
rednibroj int not null references zaposlenici(sifra),
putanja varchar(50)
);

