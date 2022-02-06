-- Fernando Guzman Valverde

-- EJercicio 1
GO
CREATE FUNCTION ufcCiudad(@num INT)
RETURNS VARCHAR(20)
AS
BEGIN
	RETURN (SELECT CASE @num 
			WHEN 1 THEN 'Cochabamba'
			WHEN 2 THEN 'La Paz'
			WHEN 3 THEN 'Santa Cruz'
			WHEN 4 THEN 'Tarija'
			WHEN 5 THEN 'Sucre'
			ELSE 'Sin Ciudad'
			END)
END
GO
PRINT dbo.ufcCiudad (3)


-- Ejercicio 2
GO
CREATE PROCEDURE AgregarDocente (@nombre VARCHAR(50), @apellido VARCHAR(50), @ciudad VARCHAR(20), @salario MONEY)
AS
BEGIN
BEGIN TRANSACTION

	DECLARE @errorCount INT
	SET @errorCount = 0
    IF (OBJECT_ID('Persona') IS NULL)
    BEGIN
        CREATE TABLE Persona(idPersona INT NOT NULL PRIMARY KEY IDENTITY(1, 1), nombre VARCHAR(50) NOT NULL, 
							 apellido VARCHAR(50) NOT NULL, ciudad VARCHAR(20) NOT NULL);
		IF (@@ERROR <> 0)
		BEGIN
			SET @errorCount = @errorCount + 1;
		END
	END
    IF (OBJECT_ID('Docente') IS NULL)
    BEGIN
        CREATE TABLE Docente(idPersona INT NOT NULL PRIMARY KEY, salario MONEY, 
							 FOREIGN KEY (idPersona) REFERENCES Persona(idPersona));
		IF (@@ERROR <> 0)
		BEGIN
			SET @errorCount = @errorCount + 1;
		END
	END
	INSERT INTO Persona VALUES (@nombre, @apellido,dbo.ufcCiudad(@ciudad))
	IF (@@ERROR <> 0)
	BEGIN
		SET @errorCount = @errorCount + 1;
	END
	INSERT INTO Docente VALUES (@@IDENTITY, @salario)
	IF (@@ERROR <> 0)
	BEGIN
		SET @errorCount = @errorCount + 1;
	END

	IF (@errorCount <> 0)
	BEGIN
		ROLLBACK TRANSACTION;
		PRINT 'No se pudo realizar la transaccion';
	END
	ELSE
	BEGIN
		COMMIT TRANSACTION;
		PRINT 'Se realizo la transaccion exitosamente.';
	END
END
GO

EXEC dbo.AgregarDocente 'Luis', 'Ponce', 1, 200
