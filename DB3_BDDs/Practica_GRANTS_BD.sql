-- Vista Total recaudado por año

GO 

CREATE VIEW vwRecaudadoPorGestion
AS
	SELECT YEAR(F.fecha) AS 'Gestion', SUM(F.total) AS 'TOTAL_BS', dbo.ufcCambioDolares(SUM(F.total)) AS 'TOTAL_$us'
	FROM factura F
	WHERE F.estado = 'V'
	GROUP BY YEAR(F.fecha)

GO


-- Vista Por Grupos

GO

CREATE VIEW vwRecaudadoPorGrupoGestion
AS
	SELECT G.idGrupo AS 'ID Grupo', GR.nombreGrupo, YEAR(F.fecha) AS 'Gestion', ISNULL(SUM(F.total), 0) AS 'TOTAL BS', dbo.ufcCambioDolares(SUM(F.total)) AS 'TOTAL $us'
	FROM factura F
	LEFT JOIN detalleFactura DF ON DF.idFactura = F.idFactura
	LEFT JOIN servicio S ON S.idServicio = DF.idServicio
	LEFT JOIN cuenta C ON C.idCuenta = S.idCuenta
	LEFT JOIN subgrupo G ON G.idSubGrupo = C.idSubGrupo
	INNER JOIN grupo GR ON G.idGrupo = GR.idGrupo
	GROUP BY YEAR(F.fecha), GR.nombreGrupo, G.idGrupo

GO

-- Funcion Cambio Dolares

CREATE FUNCTION ufcCambioDolares(@monto DECIMAL)
RETURNS  DECIMAL(10,2)
AS
BEGIN
     RETURN @monto / 6.91
END


-- Crear Sesion

GO

USE master
CREATE LOGIN EvaluacionBDDIII WITH password='EvaluacionBDDIII'

GO

-- Crear Usuario 

GO

USE sigets
CREATE USER EvaluacionBDDIII FROM LOGIN EvaluacionBDDIII

GO

-- Privilegios Vista por GESTION

GO

GRANT  SELECT ([Gestion], [TOTAL/$us]) ON OBJECT::vwRecaudadoPorGestion TO EvaluacionBDDIII
DENY SELECT ([TOTAL/BS]) ON OBJECT::vwRecaudadoPorGestion To EvaluacionBDDIII

GO

-- Privilegios Vista por GESTION y Grupo

GO

GRANT  SELECT ([Gestion], [TOTAL $us]) ON OBJECT::vwRecaudadoPorGrupoGestion TO EvaluacionBDDIII
DENY SELECT ([ID Grupo],[TOTAL BS]) ON OBJECT::vwRecaudadoPorGrupoGestion To EvaluacionBDDIII

GO

-- Asiganar Privilegios
--Clientes
GO

GRANT SELECT ON OBJECT::cliente TO EvaluacionBDDIII
DENY  INSERT, DELETE,  UPDATE ON OBJECT::cliente To EvaluacionBDDIII

GO
--Grupos
GO

GRANT INSERT ON OBJECT::grupo TO EvaluacionBDDIII
DENY  SELECT, DELETE,  UPDATE ON OBJECT::grupo To EvaluacionBDDIII

GO
--Factura Anulada	
GO

GRANT UPDATE ON OBJECT::facturaAnulada TO EvaluacionBDDIII
DENY  SELECT, DELETE, INSERT ON OBJECT::facturaAnulada To EvaluacionBDDIII

GO