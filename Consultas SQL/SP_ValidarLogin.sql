use sistema;
GO
CREATE PROCEDURE SP_ValidarLogin
    @usuario NVARCHAR(20),
    @password NVARCHAR(256)
AS
BEGIN
    DECLARE @idUsuario INT;
    DECLARE @fechaUltCambio DATE;
    DECLARE @fechaAlta DATE;

	-- Verificar de que el usuario exista
    SELECT @idUsuario = Id_Usuario,
           @fechaUltCambio = Fecha_Ult_Cambio,
           @fechaAlta = Fecha_Alta
    FROM Usuarios U
    JOIN Personal P ON U.Id_Personal = P.Id_Personal
    WHERE usuario = @usuario AND Password = @password;

    IF @idUsuario IS NULL
    BEGIN
        SELECT 'ERROR' AS Estado;
        RETURN;
    END


    -- Si la contrase�a no fue cambiada (primer ingreso)
    IF @fechaUltCambio IS NULL
    BEGIN
        SELECT 'CAMBIO_OBLIGATORIO' AS Estado;
        RETURN;
    END

    -- Vencimiento de contrase�a (m�s de 30 d�as)
    IF DATEDIFF(DAY, @fechaUltCambio, GETDATE()) > 30
    BEGIN
        SELECT 'VENCIDA' AS Estado;
        RETURN;
    END

    SELECT 'OK' AS Estado, @idUsuario AS Id_Usuario;
END
