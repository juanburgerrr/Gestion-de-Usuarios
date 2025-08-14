--Cambia la contrase�a si no tiene datos del personal(nombre, apellido, legajo)
--y tampoco debe ser igual que la anterior contrase�a
--Guarda los datos de la nueva contrase�a en el historial y actualiza la de usuarios
use sistema;
GO
CREATE PROCEDURE SP_CambiarContrase�a
    @idUsuario INT,
    @nuevaPass NVARCHAR(256)
AS
BEGIN
    DECLARE @nombre NVARCHAR(50),
	@apellido NVARCHAR(50), @legajo INT,
	@ultimaPass NVARCHAR(256);

    SELECT TOP 1
	@ultimaPass = Password 
	FROM Historial_Contrase�as 
	WHERE Id_Usuario = @idUsuario 
	ORDER BY Fecha_Cambio DESC;

    SELECT @nombre = Nombre, @apellido = Apellido, @legajo = Legajo
    FROM Personal P
    JOIN Usuarios U ON U.Id_Personal = P.Id_Personal
    WHERE U.Id_Usuario = @idUsuario;

    -- Verificaci�n de restricciones
    IF @nuevaPass LIKE '%' + @nombre + '%'
       OR @nuevaPass LIKE '%' + @apellido + '%'
       OR @nuevaPass LIKE '%' + CAST(@legajo AS NVARCHAR) + '%'
    BEGIN
        SELECT 'ERROR_DATOS_PERSONALES' AS Estado;
        RETURN;
    END

    IF @nuevaPass = @ultimaPass
    BEGIN
        SELECT 'ERROR_REPETIDA' AS Estado;
        RETURN;
    END

    -- Actualiza contrase�a y fecha de cambio
    UPDATE Usuarios SET Password = @nuevaPass, Fecha_Ult_Cambio = GETDATE() WHERE Id_Usuario = @idUsuario;

    -- Guarda en historial
    INSERT INTO Historial_Contrase�as (Id_Usuario, Fecha_Cambio, Password)
    VALUES (@idUsuario, GETDATE(), @nuevaPass);

    SELECT 'CAMBIO_OK' AS Estado;
END
