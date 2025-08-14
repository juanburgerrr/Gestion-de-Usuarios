Create procedure EnviarRespuesta

@Id_Pregunta INT,
    @Id_Usuario INT,
    @Respuesta NVARCHAR(50)
as 

begin

insert into dbo.Respuestas (Id_Pregunta,Id_Usuario, Respuesta)
values (@Id_Pregunta, @Id_Usuario, @Respuesta);

SELECT 
        P.Id_Pregunta, 
        P.Pregunta, 
        R.Id_Usuario, 
        R.Respuesta
    FROM dbo.Preguntas P
    INNER JOIN dbo.Respuestas R
        ON P.Id_Pregunta = R.Id_Pregunta
    WHERE R.Id_Pregunta = @Id_Pregunta AND R.Id_Usuario = @Id_Usuario;

end;
