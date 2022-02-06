-- Fernando Guzman y Dora Solares 

-- Ejercicio 1
GO
CREATE FUNCTION ufcNombres (@id INT)
RETURNS VARCHAR(30) 
AS
BEGIN
	DECLARE @nombre VARCHAR(30)
	IF((@id % 3) = 0)
	BEGIN
		SET @nombre = (SELECT UPPER(CONCAT(FirstName, ' ', LastName)) FROM Employees WHERE @id = EmployeeID) 
	END
	ELSE
	BEGIN
		SET @nombre = (SELECT LOWER(CONCAT(FirstName, ' ', LastName)) FROM Employees WHERE @id = EmployeeID)
	END
RETURN @nombre
END
GO

PRINT dbo.ufcNombres(3)

-- Ejercicio 2
GO
CREATE FUNCTION ufcEdad (@id INT)
RETURNS INT 
AS
BEGIN
	DECLARE @edad INT
		SET @edad = YEAR(GETDATE())-(SELECT YEAR(BirthDate) FROM Employees WHERE @id = EmployeeID) 
RETURN @edad
END
GO

PRINT dbo.ufcEdad (4)


-- Ejercicio 3
GO
CREATE FUNCTION ufcLista ()
RETURNS TABLE
AS
	RETURN (SELECT dbo.ufcNombres (EmployeeID) AS 'Nombre Completo',dbo.ufcEdad(EmployeeID) AS 'Edad',(CASE WHEN dbo.ufcEdad (EmployeeID) BETWEEN 0 AND 15 THEN 'Ninio' WHEN dbo.ufcEdad (EmployeeID) BETWEEN 16 AND 60 THEN 'Adulto' WHEN dbo.ufcEdad (EmployeeID) >= 61 THEN 'Adulto Mayor' ELSE 'Sin Edad' END)AS 'Descripcion' FROM Employees)
GO

SELECT * FROM dbo.ufcLista ()

DROP FUNCTION dbo.ufcLista