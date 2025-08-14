USE sistema;
GO

-- 1. TIPOS DE DOCUMENTO
INSERT INTO Tipo_Doc (TipoDoc) VALUES
('DNI'),
('Pasaporte');
GO

-- 2. GÉNEROS
INSERT INTO Genero (Genero) VALUES
('Masculino'),
('Femenino'),
('Otro'),
('Prefiero no decirlo');
GO

-- 3. ROLES
INSERT INTO Roles (Rol) VALUES
('Administrador'),
('Usuario');
GO

-- 4. PROVINCIAS (padre de Partido)
INSERT INTO Provincia (Provincia) VALUES
('Buenos Aires'),
('Córdoba'),
('Santa Fe');
GO

-- 5. PARTIDOS (padre de Localidad) — Id_Provincia debe existir
SET IDENTITY_INSERT Partido ON;
INSERT INTO Partido (Id_Partido, Partido, Id_Provincia) VALUES
(1, 'Lomas de Zamora', 1),  -- Buenos Aires
(2, 'Lanús', 1),            -- Buenos Aires
(3, 'Rosario', 3),          -- Santa Fe
(4, 'Córdoba Capital', 2);  -- Córdoba
SET IDENTITY_INSERT Partido OFF;
GO

-- 6. LOCALIDADES — Id_Partido debe existir
SET IDENTITY_INSERT Localidad ON;
INSERT INTO Localidad (Id_Localidad, Localidad, Cod_Postal, Id_Partido) VALUES
(1, 'Ingeniero Budge', 1832, 1),
(2, 'Lanús Oeste', 1824, 2),
(3, 'Rosario Centro', 2000, 3),
(4, 'Córdoba Capital', 5000, 4);
SET IDENTITY_INSERT Localidad OFF;
GO
