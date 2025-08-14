USE sistema;
GO
--;WITH CTE_Legajos hace una lista ordenada con posicion(1,2,3,4) y legajo
--si son <> hay un "hueco", si no hay huecos, sigue sumando de a 1
CREATE OR ALTER PROCEDURE SP_Legajo
AS
BEGIN
    DECLARE @legajo INT;

    ;WITH CTE_Legajos AS (
        SELECT Legajo, ROW_NUMBER() OVER (ORDER BY Legajo) AS Posicion
        FROM Personal
    )
    SELECT TOP 1 @legajo = Posicion
    FROM CTE_Legajos
    WHERE Legajo <> Posicion
    ORDER BY Posicion;

    IF @legajo IS NULL
        SELECT @legajo = ISNULL(MAX(Legajo), 0) + 1 FROM Personal;

    -- Devolver el próximo legajo (como resultado)
    SELECT @legajo AS ProximoLegajo;
END;

