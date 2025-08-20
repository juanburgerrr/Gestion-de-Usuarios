using System;
using System.Data;
using Microsoft.Data.SqlClient;
using Datos.SesionDTO;

namespace Datos.Login
{
    public class DSP_ValidarLogin
    {
        private Conexion.Conexion conexion = new Conexion.Conexion();

        public (string estado, SesionDTO.SesionDTO? usuario) ValidarLogin(string usuario, string passwordHash)
        {
            string estado = "ERROR";
            SesionDTO.SesionDTO? dto = null;

            using SqlConnection con = conexion.AbrirConexion();
            using SqlCommand cmd = new SqlCommand("SP_ValidarLogin", con)
            {
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@password", passwordHash);

            using SqlDataReader lector = cmd.ExecuteReader();
            if (lector.Read())
            {
                // Siempre viene Estado
                estado = lector["Estado"]?.ToString() ?? "ERROR";


                if (estado == "OK" || estado == "CAMBIO_OBLIGATORIO" || estado == "VENCIDA")
                {
                    dto = new SesionDTO.SesionDTO
                    {
                        Id = lector["Id_Usuario"] != DBNull.Value ? Convert.ToInt32(lector["Id_Usuario"]) : 0,
                        Nombre = lector["Nombre"]?.ToString() ?? string.Empty,
                        Apellido = lector["Apellido"]?.ToString() ?? string.Empty,
                        Correo = lector["Correo"]?.ToString() ?? string.Empty,
                        Rol = lector["Rol"]?.ToString() ?? string.Empty
                    };
                }
            }

            return (estado, dto);
        }
    }
}
