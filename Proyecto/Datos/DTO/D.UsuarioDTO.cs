using System;
using System.Data;

namespace Datos.DTO
    {
        public class UsuarioDTO
        {
            // Inicializar propiedades para evitar warnings de nulabilidad
            public string Nombre { get; set; } = string.Empty;
            public string Apellido { get; set; } = string.Empty;
            public char Sexo { get; set; } = 'O'; // 'M', 'F', 'O' - default 'O' (Otro)
            public DateTime FechaNacimiento { get; set; } = DateTime.MinValue; // O DateTime.Now;
            public int NroDoc { get; set; } = 0;
            public string Cuil { get; set; } = string.Empty; // NVARCHAR(11) en tu BD
            public string Calle { get; set; } = string.Empty;
            public int Nro { get; set; } = 0;
            public int? Piso { get; set; } = null; // int? para permitir valores nulos
            public string? Depto { get; set; } = null; // string? para permitir valores nulos
            public int Telefono { get; set; } = 0;
            public string Correo { get; set; } = string.Empty;
            public string NombreUsuario { get; set; } = string.Empty; // Usuario de Login
            public string Password { get; set; } = string.Empty; // Contraseña genérica
            public int Legajo { get; set; } = 0; // Legajo generado

            // Propiedades para las descripciones de los ComboBoxes (para el SP_RegistroPersonalCompleto)
            public string TipoDocDescripcion { get; set; } = string.Empty;
            public string Rol { get; set; } = string.Empty;
            public string LocalidadDescripcion { get; set; } = string.Empty;
            public string GeneroDescripcion { get; set; } = string.Empty; // 'Masculino', 'Femenino', 'Otro'
        }
    }
