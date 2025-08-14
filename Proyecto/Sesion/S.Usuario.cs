using System;

namespace Sesion.Usuario
{
    // Clase estática para almacenar y acceder a los datos de la sesión del usuario
    public static class SesionUsuario
    {
        public static int IdUsuarioLogueado { get; private set; } // ID del usuario
        public static string RolUsuarioLogueado { get; private set; } = string.Empty; // Rol del usuario
        public static string NombreCompletoUsuario { get; private set; } = string.Empty; // Nombre y Apellido
        public static string EmailUsuario { get; private set; } = string.Empty; // Email del usuario

        /// <summary>
        /// Establece los datos de la sesión del usuario.
        /// Se llama después de un login exitoso o un cambio de contraseña.
        /// </summary>
        public static void EstablecerSesion(int idUsuario, string rol, string nombreCompleto, string email)
        {
            IdUsuarioLogueado = idUsuario;
            RolUsuarioLogueado = rol;
            NombreCompletoUsuario = nombreCompleto;
            EmailUsuario = email;
        }

        /// <summary>
        /// Limpia todos los datos de la sesión.
        /// Se llama al cerrar sesión.
        /// </summary>
        public static void LimpiarSesion()
        {
            IdUsuarioLogueado = 0; // O algún valor que indique "no logueado"
            RolUsuarioLogueado = string.Empty;
            NombreCompletoUsuario = string.Empty;
            EmailUsuario = string.Empty;
        }

        /// <summary>
        /// Verifica si hay un usuario logueado en la sesión.
        /// </summary>
        public static bool EstaLogueado()
        {
            return IdUsuarioLogueado != 0; // Asumiendo que 0 es un ID inválido/no logueado
        }
    }
}
