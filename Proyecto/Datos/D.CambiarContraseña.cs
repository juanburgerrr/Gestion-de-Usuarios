using System;
using Microsoft.Data.SqlClient;
using Datos.Conexion;

namespace Datos.CambiarContra
{
    public class D_CambiarContra
    {
        private Conexion.Conexion conexion = new Conexion.Conexion();

        public D_CambiarContra()
        {
            conexion = new Conexion.Conexion();
        }

        public string CambiarContra(int idUsuario, string nuevaPass)
        {
            string estado = string.Empty;
            SqlConnection conn = conexion.AbrirConexion();

            try
            {
                SqlCommand cmd = new SqlCommand("SP_CambiarContraseña", conn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@nuevaPass", nuevaPass);

                
                var result = cmd.ExecuteScalar();
                if (result != null)
                    estado = result.ToString();
            }
            catch (Exception ex)
            {
                estado = "ERROR_" + ex.Message;
            }
            finally
            {
                conexion.CerrarConexion();
            }

            return estado;
        }
    }
}
