using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.CambiarContraseña;

namespace Logica
{
    public class CambiarContraseña
    {
        private readonly SP_CambiarContraseña _cambiarContraseña;
        public CambiarContraseña()
        {
            _cambiarContraseña = new SP_CambiarContraseña();
        }
        public string CambiarContrasenaUsuario(int idUsuario, string nuevaPass)
        {
            return _cambiarContraseña.CambiarContrasena(idUsuario, nuevaPass);
        }
    }
}

