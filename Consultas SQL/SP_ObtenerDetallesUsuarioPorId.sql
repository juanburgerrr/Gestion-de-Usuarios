
use sistema; 
GO
CREATE OR ALTER PROCEDURE SP_ObtenerDetallesUsuarioPorId
    @idUsuario INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT
        P.Nombre,
        P.Apellido,
        R.Rol AS Rol, 
        P.Correo
    FROM Usuarios U
    JOIN Personal P ON U.Id_Personal = P.Id_Personal
    JOIN Roles R ON U.Id_Rol = R.Id_Rol 
    WHERE U.Id_Usuario = @idUsuario;
END
