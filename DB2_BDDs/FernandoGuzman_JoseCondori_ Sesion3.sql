-- Fernando Guzman Valverde
-- Jose Condori Sejas


-- EJercicio 1
GO
CREATE FUNCTION Ciudad(@num INT)
RETURNS VARCHAR(60)
BEGIN
    DECLARE @resultado VARCHAR(60)
    SET @resultado=(SELECT RegionDescription AS 'Ciudad'
    FROM Region R
    WHERE R.RegionID = @num)
    RETURN @resultado
END
GO
PRINT dbo.Ciudad (3)


-- Ejercicio 2
GO
CREATE PROCEDURE Agregar (@nombre VARCHAR(60), @apellido VARCHAR(60), @ciudad INT, @salario INT)
AS
    IF object_id('Persona') EXISTS
    BEGIN
        CREATE TABLE Persona(idPersona INT NOT NULL PRIMARY KEY, nombre VARCHAR(60), apellido VARCHAR(60), ciudad VARCHAR(60));
        CREATE TABLE Docente(idPersona INT NOT NULL, salario INT)
    END
RETURN
GO

EXEC Agregar 'Luis', 'Ponce', 1, 200

DROP PROCEDURE Agregar
