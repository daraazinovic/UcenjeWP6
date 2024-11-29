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



insert into zaposlenici(ime,prezime,datumrodenja,placa,invalid)
values('Marko','Marić', '1995-09-25',1230.58,'ne');

insert into zaposlenici(ime,prezime,datumrodenja,placa,invalid)
values('Ivan','Horvat','1993-05-15',1156.43,'ne');

insert into zaposlenici(ime,prezime,datumrodenja,placa,invalid)
values('Filip','Knežević','1998-02-09',1130.20,'ne');