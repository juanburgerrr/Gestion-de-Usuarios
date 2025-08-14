use sistema;
go
CREATE PROCEDURE SP_ObtenerTipoDoc
AS
BEGIN
    SELECT Id_TipoDoc, TipoDoc FROM Tipo_Doc ORDER BY TipoDoc;
END;
