using System.Data;
using Datos.CodigoPostal;


namespace Logica
{
    public class DatosDomicilio
    {
        private readonly CodigoPostal _datosCpDatos;

        public DatosDomicilio()
        {
            _datosCpDatos = new CodigoPostal();
        }

        /// <summary>
        /// Obtiene los datos de Localidad, Partido y Provincia basándose en el Código Postal.
        /// </summary>
        /// <param name="codigoPostal">El Código Postal a buscar.</param>
        /// <returns>DataTable con la información de domicilio.</returns>
        public DataTable CodigoPostal(int codigoPostal)
        {
            return _datosCpDatos.CodPostal(codigoPostal);
        }
    }
}
