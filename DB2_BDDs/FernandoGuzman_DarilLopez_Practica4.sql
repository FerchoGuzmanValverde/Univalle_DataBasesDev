-- Fernando Guzman
--Daril Lopez

--Ejercicio 2

IF OBJECT_ID ('Empleados') IS NULL 
BEGIN
create table empleados(
  id int identity primary key, 
  nombre varchar(30),
  descripcion VARCHAR(30),
  fechacum DATE)
END
--Ejercicio 3
IF OBJECT_ID ('AuditoriaEmpleados') IS NULL 
BEGIN
CREATE TABLE AuditoriaEmpleados(
  idAuditoria int identity primary key,   
    nombre VARCHAR(25),
    operacion VARCHAR(15),
    fecha DATE)
END
--Ejercicio 4
GO
CREATE TRIGGER TRAuditoria
ON dbo.Empleados
AFTER UPDATE
AS 

       DECLARE @NombreTabla NVARCHAR(80)
       SET @NombreTabla = 'Empleados'

       DECLARE @operacion NVARCHAR(80)
       SET @operacion = 'Update'

       INSERT INTO AuditoriaEmpleados
       VALUES (@NombreTabla,@operacion,SYSDATETIME())

GO
CREATE TRIGGER TRAuditoriaI
ON dbo.Empleados
AFTER INSERT
AS 

       DECLARE @NombreTabla NVARCHAR(80)
       SET @NombreTabla = 'Empleados'

       DECLARE @operacion NVARCHAR(80)
       SET @operacion = 'Insert'

       INSERT INTO AuditoriaEmpleados
       VALUES (@NombreTabla,@operacion,SYSDATETIME())


GO
CREATE TRIGGER TRAuditoriaD
ON dbo.Empleados
AFTER DELETE
AS 

       DECLARE @NombreTabla NVARCHAR(80)
       SET @NombreTabla = 'Empleados'

       DECLARE @operacion NVARCHAR(80)
       SET @operacion = 'Delete'

       INSERT INTO AuditoriaEmpleados
       VALUES (@NombreTabla,@operacion,SYSDATETIME())

GO
--Ejercicio 5
--Insertando Valores
INSERT INTO empleados(
    nombre,descripcion
)VALUES('juan','Administrador'),
('jose','Empleado'),
('luis','Empleado')
--Actualizando
UPDATE empleados
SET nombre='pedro'
WHERE id=1; 

UPDATE empleados
SET nombre='luis'
WHERE id=2; 
--Borrando
DELETE FROM empleados WHERE id=1;