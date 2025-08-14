using System.Data;
using Datos;

namespace Logica
{
    public class PermisosObtener
    {
        private readonly Datos.PermisosObtener _datos;

        public PermisosObtener()
        {
            _datos = new Datos.PermisosObtener();
        }

        public DataTable Obtener()
        {
            return _datos.ObtenerPermisos();
        }
    }
}
