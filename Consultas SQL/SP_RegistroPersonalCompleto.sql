    use sistema;
    GO
    -- Este SP inserta tanto los datos del personal como los del usuario,
    -- y maneja la inserci�n de datos en tablas de cat�logo (Tipo_Doc, Genero, Localidad)
    -- si las descripciones no existen.
    -- (Este SP no cambia mucho, solo la l�gica de localidad/genero/tipo_doc es un lookup simple por descripci�n)
    CREATE OR ALTER PROCEDURE SP_RegistroPersonalCompleto
        @nombre NVARCHAR(50),
        @apellido NVARCHAR(50),
        @sexo CHAR(1),
        @fecha_nac DATE,
        @tipo_doc_desc NVARCHAR(30),
        @nrodoc INT,
        @cuil NVARCHAR(11),
        @correo NVARCHAR(50),
        @telefono INT,
        @localidad_desc NVARCHAR(30), 
        @calle NVARCHAR(30),
        @nro INT,
        @piso INT = NULL,
        @depto NVARCHAR(20) = NULL,
        @nombre_usuario_login NVARCHAR(20),
        @password_generica NVARCHAR(256),
        @rol_desc NVARCHAR(30),
        @legajo_generado INT,
        @registrado BIT OUTPUT
    AS
    BEGIN
        SET NOCOUNT ON;

        DECLARE @id_tipo_doc INT;
        DECLARE @id_genero INT;
        DECLARE @id_localidad INT;
        DECLARE @id_rol INT;
        DECLARE @id_personal_generado INT;

        -- insertar Id_TipoDoc
        SELECT @id_tipo_doc = Id_TipoDoc FROM Tipo_Doc WHERE TipoDoc = @tipo_doc_desc;
        IF @id_tipo_doc IS NULL
        BEGIN
            INSERT INTO Tipo_Doc (TipoDoc) VALUES (@tipo_doc_desc);
            SET @id_tipo_doc = SCOPE_IDENTITY();
        END

        -- insertar Id_Genero
        SELECT @id_genero = Id_Genero FROM Genero WHERE Genero = @sexo; 
        IF @id_genero IS NULL
        BEGIN
            INSERT INTO Genero (Genero) VALUES (@sexo); 
            SET @id_genero = SCOPE_IDENTITY();
        END

        -- insertar Id_Localidad
        -- la localidad es la base, no depende de partido/provincia para su ID.
        SELECT @id_localidad = Id_Localidad FROM Localidad WHERE Localidad = @localidad_desc;
        IF @id_localidad IS NULL
        BEGIN
            -- Si la localidad no existe, se inserta con un Cod_Postal por defecto (o se pide como par�metro)
            INSERT INTO Localidad (Localidad, Cod_Postal) VALUES (@localidad_desc, 0); -- Cod_Postal requerido
            SET @id_localidad = SCOPE_IDENTITY();
        END

        -- Obtener Id_Rol 
        SELECT @id_rol = Id_Rol FROM Roles WHERE Rol = @rol_desc;
        IF @id_rol IS NULL
        BEGIN
            SET @registrado = 0; -- Indicar fallo si el rol no existe
            RETURN;
        END

        BEGIN TRY
            BEGIN TRANSACTION;

            -- Insertar en la tabla Personal
            INSERT INTO Personal (
                Legajo, Nombre, Apellido, Id_TipoDoc, NroDoc, Calle, Nro, Piso, Depto,
                Id_Localidad, Id_Genero, Sexo, Correo, CUIL, Fecha_Nacimiento, Fecha_Alta, Telefono
            )
            VALUES (
                @legajo_generado, @nombre, @apellido, @id_tipo_doc, @nrodoc, @calle, @nro, @piso, @depto,
                @id_localidad, @id_genero, @sexo, @correo, @cuil, @fecha_nac, GETDATE(), @telefono
            );

            SET @id_personal_generado = SCOPE_IDENTITY();

            -- Insertar en la tabla Usuarios
            INSERT INTO Usuarios (
                usuario, Password, Id_Personal, Intentos_Fallidos, Usuario_Bloqueado, Fecha_Hora_Bloqueo, CambiaCada, Fecha_Ult_Cambio, Id_Rol
            )
            VALUES (
                @nombre_usuario_login, @password_generica, @id_personal_generado, 0, 0, NULL, 30, NULL, @id_rol
            );

            COMMIT TRANSACTION;
            SET @registrado = 1; -- �xito
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION;
            SET @registrado = 0; -- Error
        END CATCH
    END;
    GO
