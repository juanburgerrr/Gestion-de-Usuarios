use sistema;
GO
CREATE OR ALTER PROCEDURE SP_CodigoPostal
    @CodigoPostal INT
AS
BEGIN
    SELECT 
        l.Cod_Postal,
        l.Localidad,
        p.Partido,
        pr.Provincia
    FROM Localidad l
    INNER JOIN Partido p ON l.Id_Partido = p.Id_Partido
    INNER JOIN Provincia pr ON p.Id_Provincia = pr.Id_Provincia
    WHERE l.Cod_Postal = @CodigoPostal;
END;
