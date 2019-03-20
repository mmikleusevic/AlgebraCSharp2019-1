CREATE DATABASE zaposlenici
GO

USE zaposlenici
GO

CREATE TABLE zaposlenici (
	id				BIGINT NOT NULL PRIMARY KEY,
	ime				varchar(50) NOT NULL,
	prezime				varchar(50) NOT NULL,
	id_odjela			nchar(10) NOT NULL REFERENCES odjeli(id) 	
)
GO

CREATE TABLE odjeli (
	id				nchar(10) NOT NULL PRIMARY KEY,
	naziv_odjela			nvarchar(50) NOT NULL,
	lokacija_odjela			nvarchar(50) NOT NULL
)
GO

CREATE TABLE sefovi (
	id_zaposlenika			BIGINT FOREIGN KEY REFERENCES zaposlenici(id),
	id_odjela			nchar(10) FOREIGN KEY REFERENCES odjeli(id),
	CONSTRAINT			PK_id PRIMARY KEY (id_zaposlenika, id_odjela)
)
GO