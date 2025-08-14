using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class D_Restricciones
    {
        private readonly string _connectionString;

        public D_Restricciones(string connectionString)
        {
            _connectionString = connectionString;
        }

        // Obtiene las restricciones desde la base de datos
        public DataTable ObtenerRestricciones(int idTipoRestric)
        {
            var dt = new DataTable();

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand("ObtenerRestriccionesPorTipo", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdTipoRestric", idTipoRestric);

                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        // Actualiza una restricción específica
        public void ActualizarRestriccion(string codigo, bool activa, int? cantidad = null)
        {
            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand("ActualizarRestriccion", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Activa", activa);
                cmd.Parameters.AddWithValue("@Cantidad", (object)cantidad ?? DBNull.Value);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
