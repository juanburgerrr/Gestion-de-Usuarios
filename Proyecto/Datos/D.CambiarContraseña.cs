using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Conexion;
using Microsoft.Data.SqlClient;

namespace Datos.CambiarContraseña
{
    public class SP_CambiarContraseña
    {
        private readonly Conexion.Conexion conexion = new();

        public string CambiarContrasena(int idUsuario, string nuevaPass)
        {
            string resultadoEstado = "ERROR_DESCONOCIDO";
            SqlConnection con = null;

            try
            {
                con = conexion.AbrirConexion();
                using (SqlCommand cmd = new SqlCommand("SP_CambiarContraseña", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@nuevaPass", nuevaPass);

                    SqlDataReader lector = cmd.ExecuteReader();
                    if (lector.Read())
                    {
                        resultadoEstado = lector["Estado"]?.ToString() ?? "ERROR_DESCONOCIDO";
                    }
                    lector.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL al cambiar contraseña: " + ex.Message);
                resultadoEstado = "ERROR_SQL: " + ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al cambiar contraseña: " + ex.Message);
                resultadoEstado = "ERROR_GENERAL: " + ex.Message;
            }
            finally
            {
                if (con != null)
                {
                    conexion.CerrarConexion();
                }
            }
            return resultadoEstado;
        }
    }
}
