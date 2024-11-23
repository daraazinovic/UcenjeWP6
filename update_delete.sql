select * from smjerovi

update smjerovi set cijena=1100
where sifra=2; -- ako mjenjamo po PK tada mjenjamo 1 red

update smjerovi set izvodiseod='2024-12-05',
vaucer=0
where sifra=2;

select * from polaznici where sifra=16;

update polaznici set prezime='Franjić' where sifra=16;

select * from polaznici where sifra=16;

select * from smjerovi

insert into smjerovi (naziv,cijena,izvodiseod,vaucer)
values 
('Web dizajn', 1512,null,null),
('PHP programiranje', 1240, null,null),
('asfsdfsd', 1350, null, null),
('asdfasd', 2222, null, null),
('sdfsd', 3456, null, null)


select * from smjerovi;
update smjerovi set cijena= cijena * 0.9;
select * from smjerovi;

--uvećajte sve cijene za 35%

select * from smjerovi
update smjerovi  set cijena=cijena * 1.35;
select * from smjerovi;

select * from smjerovi;
update smjerovi set cijena=cijena -10;
select * from smjerovi;


-- uvjet vanjskog ključa
update grupe set smjer=8 where sifra=1;

--DELETE naredba

select * from smjerovi;
delete from smjerovi where sifra>8;;
select * from smjerovi;


select * from grupe;
update grupe set smjer=1 where sifra=1;

delete grupe where sifra=1;

select * from clanovi;

update clanovi set grupa=2 where grupa=1;