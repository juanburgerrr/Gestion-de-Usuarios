using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.TipoDoc;
using Datos.Roles;
using Datos.Genero;

namespace Logica.DatosCbox
{
    public class DatosCbox
    {
        private readonly DTipoDoc _tipodoc;
        private readonly DGenero _genero;
        private readonly DRoles _roles;

        public DatosCbox()
        {
            _tipodoc = new DTipoDoc();
            _genero = new DGenero();
            _roles = new DRoles();
        }
        public DataTable GetTiposDocumento()
        {
            return _tipodoc.ObtenerTipoDoc();
        }

        public DataTable GetGeneros()
        {
            return _genero.ObtenerGenero();
        }

        public DataTable GetRoles()
        {
            return _roles.ObtenerRoles();
        }
    }
}
