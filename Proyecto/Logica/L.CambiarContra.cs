using Datos.CambiarContra;
using Servicios.Hash256;

namespace Logica.CambiarContra
{
    public class L_CambiarContra
    {
        private readonly D_CambiarContra _datos;

        public L_CambiarContra()
        {
            _datos = new D_CambiarContra();
        }

        public string CambiarContra(int idUsuario, string nuevaPass)
        {
            string passHash = Hashing.HashUserPassword(idUsuario.ToString(), nuevaPass);

            return _datos.CambiarContra(idUsuario, passHash);
        }
    }
}
