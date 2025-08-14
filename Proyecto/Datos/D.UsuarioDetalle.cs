using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Datos.UsuarioDTO;
using Datos.Conexion;

namespace Datos.Usuario
{
    public class DObtenerUsuarioDetalle
    {
        private readonly Conexion.Conexion conexion = new Conexion.Conexion();

        /// <summary>  
        /// Obtiene los detalles de un usuario (nombre, apellido, rol, correo) por su Id_Usuario.  
        /// </summary>  
        /// <param name="idUsuario">El ID del usuario a buscar.</param>  
        /// <returns>Un objeto UsuarioDTO con los detalles, o null si no se encuentra.</returns>  
        public Datos.UsuarioDTO.UsuarioDTO? ObtenerDetallesUsuarioPorId(int idUsuario)
        {
            Datos.UsuarioDTO.UsuarioDTO? usuarioDetalle = null;
            SqlConnection con = null;

            try
            {
                con = conexion.AbrirConexion();
                using (SqlCommand cmd = new SqlCommand("SP_ObtenerDetallesUsuarioPorId", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);

                    using (SqlDataReader lector = cmd.ExecuteReader())
                    {
                        if (lector.Read())
                        {
                            Console.WriteLine($"[DEBUG] Se encontró usuario con Id: {idUsuario}");

                            usuarioDetalle = new Datos.UsuarioDTO.UsuarioDTO()
                            {
                                Nombre = lector["Nombre"]?.ToString() ?? string.Empty,
                                Apellido = lector["Apellido"]?.ToString() ?? string.Empty,
                                Rol = lector["Rol"]?.ToString() ?? string.Empty,
                                Correo = lector["Correo"]?.ToString() ?? string.Empty
                            };
                        }
                        else
                        {
                            Console.WriteLine($"[DEBUG] No se encontró usuario con Id: {idUsuario}");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL al obtener detalles de usuario: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al obtener detalles de usuario: " + ex.Message);
            }
            finally
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return usuarioDetalle;
        }
    }
}
