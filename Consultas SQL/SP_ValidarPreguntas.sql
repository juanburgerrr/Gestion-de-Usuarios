use sistema;
GO
--preguntas de seguridad
CREATE PROCEDURE SP_ValidarPreguntas
    @idUsuario INT,
    @idPregunta INT,
    @respuesta NVARCHAR(50)
AS
BEGIN
    DECLARE @respuestaCorrecta NVARCHAR(50);

    SELECT @respuestaCorrecta = Respuesta
    FROM Respuestas
    WHERE Id_Usuario = @idUsuario AND Id_Pregunta = @idPregunta;

    IF @respuestaCorrecta = @respuesta
        SELECT 'OK' AS Estado;
    ELSE
        SELECT 'ERROR' AS Estado;
END
