--Jose Condori
--Fernando Guzman

-- Ejercicio 1
DECLARE @Description AS nvarchar(400), @id AS int, @categoria AS int, @cantidad AS nvarchar(20)
DECLARE ProdInfo CURSOR FOR SELECT ProductID, ProductName,CategoryID, QuantityPerUnit FROM Products
OPEN ProdInfo
FETCH NEXT FROM ProdInfo INTO @id, @Description, @categoria, @cantidad
WHILE @@fetch_status = 0
BEGIN
    PRINT CONCAT(@id, ' ', @Description, ' ', @categoria, ' ', @cantidad)
    FETCH NEXT FROM ProdInfo INTO @id, @Description, @categoria, @cantidad
END
CLOSE ProdInfo
DEALLOCATE ProdInfo


--Ejercicio 2 y 3
GO
DECLARE @Description AS nvarchar(400), @cantidad AS nvarchar(200)
DECLARE ProdInfo CURSOR FOR SELECT ProductName,QuantityPerUnit FROM Products
OPEN ProdInfo
FETCH NEXT FROM ProdInfo INTO @Description, @cantidad
WHILE @@fetch_status = 0
BEGIN
    UPDATE Products
    SET ProductName = @Description + '-Modificado',
        QuantityPerUnit = @cantidad + '-Modificado'
    WHERE Current OF ProdInfo
    FETCH NEXT FROM ProdInfo INTO @Description, @cantidad

END
CLOSE ProdInfo
DEALLOCATE ProdInfo
GO