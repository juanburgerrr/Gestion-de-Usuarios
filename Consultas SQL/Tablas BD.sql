use sistema;
GO
CREATE TABLE Tipo_Doc (
    Id_TipoDoc INT PRIMARY KEY identity(1,1) not null,
    TipoDoc NVARCHAR(30) not null	
);

CREATE TABLE Genero (
    Id_Genero INT PRIMARY KEY identity(1,1) not null,
    Genero NVARCHAR(20) not null
);

CREATE TABLE Provincia (
    Id_Provincia INT PRIMARY KEY identity(1,1) not null,
    Provincia NVARCHAR(30) not null
);

CREATE TABLE Partido (
    Id_Partido INT PRIMARY KEY identity(1,1) not null,
    Partido NVARCHAR(30) not null,
    Id_Provincia INT,
    FOREIGN KEY (Id_Provincia) REFERENCES Provincia(Id_Provincia)
);

CREATE TABLE Localidad (
    Id_Localidad INT PRIMARY KEY identity(1,1) not null,
    Localidad NVARCHAR(30) not null,
	Cod_Postal INT not null,
	Id_Partido INT,
	FOREIGN KEY (Id_Partido) REFERENCES Partido(Id_Partido)
);


CREATE TABLE Personal (
    Id_Personal INT PRIMARY KEY identity(1,1) not null,
    Legajo INT not null,
    Nombre NVARCHAR(50) not null,
    Apellido NVARCHAR(50) not null,
    Id_TipoDoc INT,
    NroDoc INT not null,
    Calle NVARCHAR(30),
    Nro INT,
    Piso INT,
    Depto NVARCHAR(20),
    Id_Localidad INT,
    Id_Genero INT,
    Sexo CHAR(1) not null,
    Correo NVARCHAR(50) not null,
    CUIL NVARCHAR(11) not null,
	Fecha_Nacimiento DATE,
    Fecha_Alta DATE,
    Telefono INT not null,
    FOREIGN KEY (Id_TipoDoc) REFERENCES Tipo_Doc(Id_TipoDoc),
    FOREIGN KEY (Id_Localidad) REFERENCES Localidad(Id_Localidad),
    FOREIGN KEY (Id_Genero) REFERENCES Genero(Id_Genero)
);

CREATE TABLE Roles (
    Id_Rol INT PRIMARY KEY identity(1,1) not null,
    Rol NVARCHAR(30) not null
);

CREATE TABLE Usuarios (
    Id_Usuario INT PRIMARY KEY identity(1,1) not null,
    usuario NVARCHAR(20) not null,
    Password NVARCHAR(256) not null,
    Id_Personal INT,
	Intentos_Fallidos INT,
    Usuario_Bloqueado BIT,
    Fecha_Hora_Bloqueo DATE,
    CambiaCada NVARCHAR(20),
    Fecha_Ult_Cambio DATE,
    Id_Rol INT,
    FOREIGN KEY (Id_Personal) REFERENCES Personal(Id_Personal),
    FOREIGN KEY (Id_Rol) REFERENCES Roles(Id_Rol)
);

CREATE TABLE Permisos (
    Id_Permiso INT PRIMARY KEY identity(1,1) not null,
    Permiso INT not null,
    Descrip NVARCHAR(50) not null
);

CREATE TABLE Permiso_Usuarios(
    Id_Usuario INT,
    Id_Permiso INT,
    Fecha_Vto DATE,
    PRIMARY KEY (Id_Usuario, Id_Permiso),
    FOREIGN KEY (Id_Usuario) REFERENCES Usuarios(Id_Usuario),
	FOREIGN KEY (Id_Permiso) REFERENCES Permisos(Id_Permiso)
);

CREATE TABLE Rol_Permiso (
    Id_Rol INT,
    Id_Permiso INT,
    PRIMARY KEY (Id_Rol, Id_Permiso),
    FOREIGN KEY (Id_Rol) REFERENCES Roles(Id_Rol),
    FOREIGN KEY (Id_Permiso) REFERENCES Permisos(Id_Permiso)
);

CREATE TABLE Preguntas (
    Id_Pregunta INT PRIMARY KEY identity(1,1) not null,
    Pregunta NVARCHAR(50) not null
);

CREATE TABLE Respuestas (
    Id_Pregunta INT,
    Id_Usuario INT,
    Respuesta NVARCHAR(50) not null,
    PRIMARY KEY (Id_Pregunta, Id_Usuario),
    FOREIGN KEY (Id_Pregunta) REFERENCES Preguntas(Id_Pregunta),
    FOREIGN KEY (Id_Usuario) REFERENCES Usuarios(Id_Usuario)
);

CREATE TABLE Historial_Contraseñas(
    Id_Hcontra INT PRIMARY KEY identity(1,1) not null,
    Id_Usuario INT,
    Fecha_Cambio DATE,
    Password NVARCHAR(20) not null,
    FOREIGN KEY (Id_Usuario) REFERENCES Usuarios(Id_Usuario)
);

CREATE TABLE Telefono (
    Id_Telefono INT PRIMARY KEY identity(1,1) not null,
    Telefono NVARCHAR(20) not null,
    Descrip NVARCHAR(50) not null,
    Id_Personal INT,
    FOREIGN KEY (Id_Personal) REFERENCES Personal(Id_Personal)
);

CREATE TABLE Tipo_Restriccion(
    Id_TipoRestric INT PRIMARY KEY identity(1,1) not null,
    Tipo INT not null
);

CREATE TABLE Restricciones (
    Id_Restriccion INT PRIMARY KEY identity(1,1) not null,
    Cod_Restriccion NVARCHAR(20) not null,
    Descrip NVARCHAR(50) not null,
    Id_TipoRestric INT,
    Actividad BIT,
    Cantidad INT not null,
    FOREIGN KEY (Id_TipoRestric) REFERENCES Tipo_Restriccion(Id_TipoRestric)
);