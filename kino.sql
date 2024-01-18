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