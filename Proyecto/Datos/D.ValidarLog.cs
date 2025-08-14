using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Datos.Login
{
    public class DSP_ValidarLogin
    {
        private Conexion.Conexion conexion = new Conexion.Conexion();

        public (string? estado, int? idUsuario) ValidarLogin(string usuario, string password)
        {
            string? estado = null;
            int? idUsuario = null;
            SqlConnection con = null;

            try
            {
                con = conexion.AbrirConexion();

                using (SqlCommand comando = new SqlCommand("SP_ValidarLogin", con))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@password", password);

                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            estado = lector["Estado"]?.ToString();

                            if (lector.FieldCount > 1 && lector["Id_Usuario"] != DBNull.Value)
                            {
                                idUsuario = Convert.ToInt32(lector["Id_Usuario"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error en ValidarLogin: " + ex.Message);
                estado = "ERROR";
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                    con.Close();
            }


            return (estado, idUsuario);
        }
    }
}
