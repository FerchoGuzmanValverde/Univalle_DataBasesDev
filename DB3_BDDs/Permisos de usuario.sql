Go

USE master
CREATE LOGIN invitado WITH password='12345'

Go


GO
USE ComprasHelpDesk
CREATE USER invitado FROM LOGIN invitado
GO


GO
GRANT SELECT, INSERT, UPDATE ON DATABASE::ComprasHelpDesk TO invitado
DENY  DELETE ON DATABASE::ComprasHelpDesk To invitado
GO

GO
GRANT INSERT, SELECT ON OBJECT::Categoria TO invitado
DENY  DELETE,  UPDATE ON OBJECT::Categoria To invitado
GO

GO
GRANT  SELECT (nombreCategoria) ON OBJECT::Categoria TO invitado
DENY  SELECT (CategoriaID) ON OBJECT::Categoria To invitado
GO

GO
GRANT  EXECUTE ON OBJECT::uspInsertCategoria TO invitado
DENY  DELETE, INSERT, UPDATE ON OBJECT::uspInsertCategoria To invitado
GO