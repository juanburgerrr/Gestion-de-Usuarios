using Datos;

namespace Logica
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
            return _datos.CambiarContra(idUsuario, nuevaPass);
        }
    }
}
