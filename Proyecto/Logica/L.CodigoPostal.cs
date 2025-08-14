using System;
using System.Data;
using Datos.CPostal;


namespace Logica.CPostal
{
    public class LCodigoPostal
    {
        private readonly DCodigoPostal _datosCpDatos;

        public LCodigoPostal()
        {
            _datosCpDatos = new DCodigoPostal();
        }

        /// <summary>
        /// Obtiene los datos de Localidad, Partido y Provincia basándose en el Código Postal.
        /// </summary>
        /// <param name="codigoPostal">El Código Postal a buscar.</param>
        /// <returns>DataTable con la información de domicilio.</returns>
        public DataTable GetDatosPorCodigoPostal(int codigoPostal)
        {
            return _datosCpDatos.ObtenerDatos(codigoPostal);
        }
    }
}
