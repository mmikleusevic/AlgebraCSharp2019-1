CREATE DATABASE zbirka
GO
USE zbirka
GO

CREATE TABLE prijatelji(
	id				INT NOT NULL PRIMARY KEY,
	ime				VARCHAR(50) NOT NULL,
	prezime			VARCHAR(50) NOT NULL
)
GO

CREATE TABLE posudba(
	id				INT NOT NULL PRIMARY KEY,
	datum_posudbe	DATETIME,
	datum_povratka	DATETIME,
	id_prijatelja	INT NOT NULL FOREIGN KEY REFERENCES prijatelji(id),
	id_medija		INT NOT NULL FOREIGN KEY REFERENCES medij(id)
)
GO

CREATE TABLE medij(
	id				INT NOT NULL PRIMARY KEY,
	naziv			varchar(50) NOT NULL,
	vrsta			varchar(50) NOT NULL,
)
GO

INSERT INTO prijatelji VALUES(1,'Petar','Pranjiæ');
INSERT INTO prijatelji VALUES(2,'Alen','Terziæ');
INSERT INTO prijatelji VALUES(3,'Filip','Šæuka');

INSERT INTO medij VALUES(1,'Queen','Glazba CD');
INSERT INTO medij VALUES(2,'King Crimson','Glazba DVD');
INSERT INTO medij VALUES(3,'The Strokes','Glazba CD');

INSERT INTO posudba VALUES(1,'2019-03-20','2019-03-22',1,2);
INSERT INTO posudba VALUES(2,'2019-03-20',NULL,2,1);
INSERT INTO posudba VALUES(3,'2019-03-20',NULL,3,3);

SELECT ime AS 'Ime', prezime AS 'Prezime', DATEDIFF(day, datum_posudbe, GETDATE()) AS 'Dana Posuðeno'
FROM prijatelji
LEFT JOIN posudba ON prijatelji.id=posudba.id_prijatelja
LEFT JOIN medij ON posudba.id_medija=medij.id
WHERE datum_povratka IS NULL

UPDATE posudba SET datum_povratka = GETDATE() WHERE datum_povratka IS NULL


