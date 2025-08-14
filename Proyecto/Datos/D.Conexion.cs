using Microsoft.Data.SqlClient;

namespace Datos.Conexion
{
    public class Conexion
    {
        private SqlConnection? conexion;

        private string cadenaConexion = "Data Source=DESKTOP-KRHC4II\\;Initial Catalog=sistema;Integrated Security=True;TrustServerCertificate=True";

        public SqlConnection AbrirConexion()
        {
            if (conexion == null)
            {
                conexion = new SqlConnection(cadenaConexion);
            }

            if (conexion.State == System.Data.ConnectionState.Closed)
            {
                conexion.Open();
            }
                
            return conexion;
        }

        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }
        }
    }
}
