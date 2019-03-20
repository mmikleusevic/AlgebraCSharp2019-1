CREATE DATABASE videoteka
GO

USE videoteka
GO

CREATE TABLE clanovi(
	id					INT NOT NULL PRIMARY KEY,
	ime					NCHAR(30),
	prezime				NCHAR(30),
	adresa				NCHAR(30),
	telefon				NCHAR(30),
	datum_uclanjenja	DATETIME
)
GO

CREATE TABLE zanr(
	id					INT NOT NULL PRIMARY KEY,
	naziv				NCHAR(50)
)
GO

CREATE TABLE filmovi(
	id					INT NOT NULL PRIMARY KEY,
	naziv				NCHAR(30),
	reziser				NCHAR(30),
	glavni_glumci		NCHAR(30),
	godina_izdanja		INT,
	kolicina_DVD		INT,
	kolicina_VHS		INT,
	slika_naslovnice	IMAGE,
	sifra_zanra			INT FOREIGN KEY REFERENCES zanr(id)
)
GO

CREATE TABLE cjenik(
	id					INT NOT NULL PRIMARY KEY,
	kategorija			NCHAR(30),
	cijena				SMALLMONEY
)
GO

CREATE TABLE posudba(
	id_clan					INT NOT NULL FOREIGN KEY REFERENCES clanovi(id),
	id_filma				INT NOT NULL FOREIGN KEY REFERENCES filmovi(id),
	datum_posudbe			DATETIME,
	datum_povratka			DATETIME,
	id_cjenika				INT NOT NULL FOREIGN KEY REFERENCES cjenik(id),
	CONSTRAINT				PK_sifre PRIMARY KEY(id_clan,id_filma,datum_posudbe)
)
GO