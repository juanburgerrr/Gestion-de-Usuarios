using Datos.UsuarioDTO;
using Datos.Usuario;
using System;

namespace Logica.Usuario
{
    public class LUsuario
    {
        private readonly DObtenerUsuarioDetalle datos = new DObtenerUsuarioDetalle();

        public UsuarioDTO ObtenerUsuario(int id)
        {
            return datos.ObtenerDetallesUsuarioPorId(id);
        }

    }
}
