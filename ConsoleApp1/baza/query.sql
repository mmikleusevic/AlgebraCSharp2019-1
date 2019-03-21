USE Fakultet
GO
--3.2
SELECT mbrStud,CONCAT(imeStud,prezStud) AS 'Ime i prezime'
FROM stud

--3.3
SELECT DISTINCT imeStud
FROM stud
ORDER BY imeStud DESC

--3.4
SELECT s.mbrStud,s.imeStud AS 'Ime',s.prezStud AS 'Prezime'
FROM stud s
INNER JOIN ispit i
ON s.mbrStud=i.mbrStud
WHERE i.sifPred=146
AND i.ocjena>1

--3.22
SELECT n.*,
m1.nazMjesto,z1.nazZupanija
FROM nastavnik n
LEFT JOIN ispit i
ON n.sifNastavnik=i.sifNastavnik
INNER JOIN stud s
ON i.mbrStud=s.mbrStud
LEFT JOIN mjesto m1
ON m1.pbr=n.pbrStan
LEFT JOIN zupanija z1
ON z1.sifZupanija=m1.sifZupanija
LEFT JOIN mjesto m2
ON m2.pbr=s.pbrStan
LEFT JOIN zupanija z2
ON z2.sifZupanija=m2.sifZupanija
WHERE m1.sifZupanija=m2.sifZupanija