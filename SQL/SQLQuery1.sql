SELECT name, collation_name FROM sys.databases;
GO
ALTER DATABASE db_ab2831_trgovinarukotvorin SET SINGLE_USER WITH
ROLLBACK IMMEDIATE;
GO
ALTER DATABASE db_ab2831_trgovinarukotvorin COLLATE Croatian_CI_AS;
GO
ALTER DATABASE db_ab2831_trgovinarukotvorin SET MULTI_USER;
GO
SELECT name, collation_name FROM sys.databases;
GO



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
values('Ku�ica sa crkvom','beton',15,'Ukras za domove');

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Kapela sa mirisnom svije�om','beton i svije�a',10,'Ukras za razne prigode');

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Mini vaza','beton i umjetno cvije�e',10,'Ukras za prigode i domove');

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Posudice za lu�ice', 'beton i lu�ica', 15, 'Ukras za dom')

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Figura bicikli', 'beton', 15, 'Ukras za dom')

insert into proizvodi(naziv,izradujeseod,cijena,namjena)
values('Set ku�ice i vaze sa lu�icom', 'beton,vosak i cvije�e', 20,'Ukras za dom')



insert into vrste(sastav)
values('Drvo hrast');

insert into vrste(sastav)
values('Kerami�ki prah');

insert into vrste(sastav)
values('Vosak');

insert into vrste(sastav)
values('Umjetno cvije�e');



insert into materijali(naziv,vrsta)
values('Lamele parketa',1);

insert into materijali(naziv,vrsta)
values('Kerami�ki beton', 2);

insert into materijali(naziv,vrsta)
values('Svije�a',3);

insert into materijali(naziv,vrsta)
values('Cvije�e',4);



insert into sastavnice(proizvod,materijal)
values(1,3);

insert into sastavnice(proizvod,materijal)
values(2,2);

insert into sastavnice(proizvod,materijal)
values(3,2);

insert into sastavnice(proizvod,materijal)
values(4,2);

insert into sastavnice(proizvod,materijal)
values(5,2);

insert into sastavnice(proizvod,materijal)
values(6,2);

insert into sastavnice(proizvod,materijal)
values(7,2);