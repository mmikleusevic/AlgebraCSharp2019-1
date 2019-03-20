CREATE DATABASE skladiste
GO
USE skladiste
GO

CREATE TABLE radnik(
	id				BIGINT NOT NULL PRIMARY KEY,
	ime				NCHAR(30),
	prezime			NCHAR(30),
	id_skladista	BIGINT FOREIGN KEY REFERENCES skladisno_mjesto(id)
)
GO

CREATE TABLE skladisno_mjesto(
	id				BIGINT NOT NULL PRIMARY KEY,
	naziv			NCHAR(50),
	mjesto			NCHAR(50)
)
GO

CREATE TABLE proizvod(
	id				BIGINT NOT NULL PRIMARY KEY,
	naziv			NCHAR(30),
	id_skladista	BIGINT FOREIGN KEY REFERENCES skladisno_mjesto(id)
)
GO

CREATE TABLE voditelji(
	id_radnika				BIGINT NOT NULL FOREIGN KEY REFERENCES radnik(id),
	id_skladista			BIGINT NOT NULL FOREIGN KEY REFERENCES skladisno_mjesto(id),
	CONSTRAINT				PK_sifre PRIMARY KEY(id_radnika,id_skladista)
)
GO

-- Zadatak 2.5
ALTER TABLE skladisno_mjesto
ADD
	CONSTRAINT		ck_provjera CHECK (mjesto IN('ZAGREB','RIJEKA','SISAK'))
GO
