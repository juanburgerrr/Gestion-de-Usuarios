using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Conexion;
using Microsoft.Data.SqlClient;

namespace Datos.Legajo
{
    public class DLegajo
    {
        private readonly Conexion.Conexion conexion = new Conexion.Conexion();

        public int ObtenerSiguienteLegajo()
        {
            SqlConnection con = null;
            try
            {
                con = conexion.AbrirConexion();
                using (SqlCommand cmd = new SqlCommand("SP_Legajo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // No enviar parámetros porque el SP no los recibe

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32(0); // Primer columna: el legajo calculado
                        }
                        else
                        {
                            throw new Exception("El SP_Legajo no devolvió un legajo válido.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al obtener legajo: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al obtener legajo: " + ex.Message);
                throw;
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