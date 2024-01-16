CREATE TABLE film (
  id INT PRIMARY KEY,
  naziv VARCHAR(255),
  trajanje INT,
  dvorana INT,
);

CREATE TABLE kupac (
  id INT PRIMARY KEY,
  ime VARCHAR(255),
  prezime VARCHAR(255),
  email VARCHAR(255),
  broj_telefona VARCHAR(255)
);

CREATE TABLE rezervacija (
  id INT PRIMARY KEY,
  film_id INT,
  kupac_id INT,
  broj_sjedala INT,
  datum DATE,
  FOREIGN KEY (film_id) REFERENCES film(id),
  FOREIGN KEY (kupac_id) REFERENCES kupac(id)
);
