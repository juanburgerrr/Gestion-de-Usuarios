using Sesion.Usuario;
using Datos.SesionDTO;

namespace Logica.Sesion
{
    public class L_Sesion
    {
        public SesionDTO ObtenerSesionActual()
        {
            if (!SesionUsuario.EstaLogueado())
                return null;

            return new SesionDTO
            {
                Id = SesionUsuario.IdUsuario,
                Nombre = SesionUsuario.NombreCompleto,
                Correo = SesionUsuario.Email,
                Rol = SesionUsuario.Rol
            };
        }

        public void CerrarSesion()
        {
            SesionUsuario.CerrarSesion();
        }
    }
}
