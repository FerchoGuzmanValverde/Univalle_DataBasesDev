--Dora Solares Alarcon
--Fernando Guzman Valverde

--1
CREATE DATABASE prueba

GO
IF EXISTS (SELECT * FROM Empleados)
	BEGIN
		DROP TABLE Empleados
	END
GO

CREATE TABLE Empleados(id INT IDENTITY(1,1) PRIMARY KEY, nombre VARCHAR(30), apellido VARCHAR(30), edad TINYINT)

--2
INSERT INTO Empleados (nombre, apellido, edad)
VALUES ('Ana', 'Acosta', 80)

INSERT INTO Empleados (nombre, apellido, edad)
VALUES ('Carlos', 'Caceres', 40)

INSERT INTO Empleados (nombre, apellido, edad)
VALUES ('Federico', 'Fuentes', 20)

INSERT INTO Empleados (nombre, apellido, edad)
VALUES ('Gastón', 'Guzman', 30)

INSERT INTO Empleados (nombre, apellido, edad)
VALUES ('Hector', 'Herrero', 50)

INSERT INTO Empleados (nombre, apellido, edad)
VALUES ('Luis', 'Luna', 100)

INSERT INTO Empleados (nombre, apellido, edad)
VALUES ('Juan', 'Morales', NULL)

--3
SELECT CONCAT(nombre,' ', apellido) AS 'Nombre Empleado', edad AS 'Edad', (CASE WHEN edad=0 OR edad=10 OR edad=20 OR edad=30 THEN 'Joven'  
																				WHEN edad=40 OR edad=50 OR edad=60 THEN 'Maduro'  
																				WHEN edad=70 OR edad=80 OR edad=90 OR edad=100 THEN 'Adulto' END) AS 'Descripcion' 
FROM Empleados


--4
SELECT nombre AS 'Nombre', apellido AS 'Apellido', (CASE WHEN edad BETWEEN 0 AND 39 THEN 'Menor a 40 años'  
														WHEN edad BETWEEN 40 AND 70 THEN 'Entre 40 y 70'  
														WHEN edad > 70 THEN 'Mayor a 70 años'  END) AS 'Resultado' 
FROM Empleados

--5
ALTER TABLE dbo.Empleados 
ADD condicion VARCHAR(20);

--6
UPDATE Empleados
SET condicion='Joven'
WHERE edad=20 OR edad=30

UPDATE Empleados
SET condicion='Adulto'
WHERE edad=70 OR edad=80 OR edad=90 OR edad=100

UPDATE Empleados
SET condicion='Maduro'
WHERE edad=40 OR edad=50 OR edad=60


SELECT COUNT(condicion) AS 'Cantidad', (CASE WHEN condicion='Joven' THEN 'Fuertes'  
										WHEN condicion='Maduro'THEN 'Inteligentes'  
										WHEN condicion='Adulto' THEN 'Sabios'  END) AS 'Resultado'
FROM Empleados
GROUP BY condicion
ORDER BY 1

--7
ALTER TABLE dbo.Empleados 
ADD indice TINYINT;

DECLARE @con INT
SET @con = 1
WHILE (@con < 8)
 BEGIN
 UPDATE Empleados
 SET indice=@con
 WHERE @con=id
 SET @con = @con +1
 END


SELECT * FROM Empleados