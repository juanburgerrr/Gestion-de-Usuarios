using System;
using Microsoft.Data.SqlClient;

namespace Datos
{
    public class PermisosAsignar
    {
        private readonly Conexion.Conexion _conexion;

        public PermisosAsignar()
        {
            _conexion = new Conexion.Conexion();
        }

        public void AsignarPermiso(int idUsuario, int idPermiso, DateTime fechaVto)
        {
            using (SqlConnection con = _conexion.AbrirConexion())
            using (SqlCommand cmd = new SqlCommand("sp_AsignarPermisoUsuario", con))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@idPermiso", idPermiso);
                cmd.Parameters.AddWithValue("@fechaVto", fechaVto);
                cmd.ExecuteNonQuery();
            }

            _conexion.CerrarConexion();
        }
    }
}
