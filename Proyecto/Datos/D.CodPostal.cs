using Microsoft.Data.SqlClient;
using System.Data;
using System;

namespace Datos.CodigoPostal
{
    public class CodigoPostal
    {
        private Conexion.Conexion conexion = new Conexion.Conexion();

        /// <summary>
        /// Obtiene los datos de Localidad, Partido y Provincia
        /// basándose en el Código Postal proporcionado.
        /// </summary>
        /// <param name="codigoPostal">El Código Postal a buscar.</param>
        /// <returns>Un DataTable con la Localidad, Partido y Provincia si se encuentran, o una tabla vacía.</returns>
        public DataTable CodPostal(int codigoPostal)
        {
            SqlConnection con = null;
            try
            {
                con = conexion.AbrirConexion();
                using (SqlCommand cmd = new SqlCommand("SP_CodigoPostal", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CodigoPostal", codigoPostal);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener datos por código postal: {ex.Message}");
                return new DataTable(); // Devolver tabla vacía en caso de error
            }
            finally
            {
                if (con != null)
                {
                    conexion.CerrarConexion();
                }
            }
        }
    }
}
