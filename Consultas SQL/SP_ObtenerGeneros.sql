use sistema;
GO
CREATE PROCEDURE SP_ObtenerGeneros
AS
BEGIN
    SELECT Id_Genero, Genero FROM Genero ORDER BY Genero;
END;
