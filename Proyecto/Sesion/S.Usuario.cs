using System;

namespace Sesion.Usuario
{

    public static class SesionUsuario
    {
        public static int IdUsuario { get; private set; } = 0;
        public static string Rol { get; private set; } = string.Empty;
        public static string NombreCompleto { get; private set; } = string.Empty;
        public static string Email { get; private set; } = string.Empty;

   
        public static void IniciarSesion(int idUsuario, string rol, string nombreCompleto, string email)
        {
            if (idUsuario <= 0) throw new ArgumentException("ID de usuario inválido");
            IdUsuario = idUsuario;
            Rol = rol ?? string.Empty;
            NombreCompleto = nombreCompleto ?? string.Empty;
            Email = email ?? string.Empty;
        }


        public static void CerrarSesion()
        {
            IdUsuario = 0;
            Rol = string.Empty;
            NombreCompleto = string.Empty;
            Email = string.Empty;
        }

  
        public static bool EstaLogueado() => IdUsuario > 0;
    }
}
