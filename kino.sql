CREATE TABLE film (
  id INT NOT NULL PRIMARY INDETITY(1,1),
  naziv VARCHAR(255) NOT NULL,
  trajanje INT NOT NULL,
  dvorana VARCHAR(255) NOT NULL,
);

CREATE TABLE kupac (
  id INT NOT NULL PRIMARY INDETITY(1,1),
  ime VARCHAR(255) NOT NULL,
  prezime VARCHAR(255) NOT NULL,
  email VARCHAR(255) NOT NULL,
  broj_telefona VARCHAR(255) NOT NULL,
);

CREATE TABLE rezervacija (
  id INT NOT NULL PRIMARY INDETITY(1,1),
  film_id INT NOT NULL,
  kupac_id INT NOT NULL,
  broj_sjedala INT NOT NULL,
  datum DATE NOT NULL,
  FOREIGN KEY (film_id) REFERENCES film(id),
  FOREIGN KEY (kupac_id) REFERENCES kupac(id)
);



insert into film (naziv,trajanje,dvorana) 
values 
('Vrisak',120,5),('Krug',120,7),('Osvetnici',150,3);



insert into kupac (ime,prezime,email,broj_telefona) 
values 
('Tomislav','Tomić','to@fr.hr','098765432'),('Omislav','Omić','ko@fr.hr','099765432'),('Mislav','Mić','loo@fr.hr','095765432');


insert into rezervacija (film_id,kupac_id,broj_sjedala,datum) 
values (1,1,55,'2023-11-29 19:00:00'),
(2,2,56,'2023-11-29 18:00:00'),(3,3,57,'2023-11-29 17:00:00');


select * from rezervacija;
select * from kupac;
select * from film;