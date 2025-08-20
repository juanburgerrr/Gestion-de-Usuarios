using Datos.Login;
using Servicios.Hash256;
using Datos.DTO;

namespace Logica.Login
{
    public class LLogin
    {
        private readonly DSP_ValidarLogin _login;

        public LLogin()
        {
            _login = new DSP_ValidarLogin();
        }

        public (string estado, int? idUsuario, string nombre, string apellido, string correo, string rol) Validar(string usuario, string password)
        {
            string passwordHash = Hashing.HashUserPassword(usuario, password);
            var (estado, usuarioDTO) = _login.ValidarLogin(usuario, passwordHash);

            if (usuarioDTO != null)
            {
                return (estado, usuarioDTO.Id, usuarioDTO.Nombre, usuarioDTO.Apellido, usuarioDTO.Correo, usuarioDTO.Rol);
            }
            else
            {
                return (estado, null, string.Empty, string.Empty, string.Empty, string.Empty);
            }
        }
    }
}
