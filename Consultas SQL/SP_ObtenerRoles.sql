USE sistema;
go
CREATE PROCEDURE SP_ObtenerRol
AS
BEGIN
    SELECT Id_Rol, Rol FROM Roles ORDER BY Rol;
END;
