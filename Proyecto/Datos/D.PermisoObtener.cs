using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class PermisosObtener
    {
        private readonly Conexion.Conexion _conexion;

        public PermisosObtener()
        {
            _conexion = new Conexion.Conexion();
        }

        public DataTable ObtenerPermisos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection con = _conexion.AbrirConexion())
            using (SqlCommand cmd = new SqlCommand("sp_ObtenerPermisos", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(tabla);
                }
            }

            _conexion.CerrarConexion();
            return tabla;
        }
    }

   
}
