using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using Datos.Conexion;


namespace Datos.Genero
{
    public class DGenero
    {
        private readonly Conexion.Conexion conexion = new Conexion.Conexion();

        public DataTable ObtenerGenero()
        {
            SqlConnection con = null;
            DataTable dt = new DataTable();

            try
            {
                con = conexion.AbrirConexion();

                using (SqlCommand cmd = new SqlCommand("SP_ObtenerGeneros", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

                return dt;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL al obtener tipos de documento: " + ex.Message);
                throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al obtener tipos de documento: " + ex.Message);
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
