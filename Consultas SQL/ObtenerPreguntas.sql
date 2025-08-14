CREATE PROCEDURE ObtenerPreguntas
AS
BEGIN
    SELECT 
        Id_Pregunta,
        Pregunta
    FROM 
        dbo.Preguntas
    ORDER BY 
        Id_Pregunta;
END;
