using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Datos.PreguntasSeguridad
{
    public class PreguntasSeguridad
    {
        private Conexion.Conexion conexion = new Conexion.Conexion();

        public DataTable ObtenerPreguntasSeguridad()
        {
            SqlConnection con = null;
            try
            {
                con = conexion.AbrirConexion();
                using (SqlCommand cmd = new SqlCommand("SELECT  FROM Preguntas", con))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener preguntas de seguridad: " + ex.Message);
                return new DataTable();
            }
            finally
            {
                if (con != null)
                {
                    conexion.CerrarConexion();
                }
            }
        }


        public string GuardarRespuestasSeguridad(int idUsuario,
            int id1, string r1, int id2, string r2, int id3, string r3, int id4, string r4,
            int id5, string r5, int id6, string r6, int id7, string r7, int id8, string r8)
        {
            SqlConnection con = null;
            try
            {
                con = conexion.AbrirConexion();

                // Verificar si ya existen respuestas
                bool existenRespuestas = false;
                using (SqlCommand verificarCmd = new SqlCommand("SELECT COUNT(*) FROM Respuestas WHERE Id_usuario = @idUsuario", con))
                {
                    verificarCmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    existenRespuestas = Convert.ToInt32(verificarCmd.ExecuteScalar()) > 0;
                }

                if (existenRespuestas)
                {
                    // Actualizar respuestas existentes
                    using (SqlCommand cmd = new SqlCommand(
                        @"UPDATE Respuestas SET 
                        Id_pregunta1 = @id1, respuesta1 = @r1,
                        Id_pregunta2 = @id2, respuesta2 = @r2,
                        Id_pregunta3 = @id3, respuesta3 = @r3,
                        Id_pregunta4 = @id4, respuesta4 = @r4,
                        Id_pregunta5 = @id5, respuesta5 = @r5,
                        Id_pregunta6 = @id6, respuesta6 = @r6,
                        Id_pregunta7 = @id7, respuesta7 = @r7,
                        Id_pregunta8 = @id8, respuesta8 = @r8,
                        fecha_actualizacion = GETDATE()
                        WHERE Id_usuario = @idUsuario", con))
                    {
                        AgregarParametrosRespuestas(cmd, idUsuario,
                            id1, r1, id2, r2, id3, r3, id4, r4,
                            id5, r5, id6, r6, id7, r7, id8, r8);
                        cmd.ExecuteNonQuery();
                        return "ACTUALIZACION_OK";
                    }
                }
                else
                {
                    // Insertar nuevas respuestas
                    using (SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO Respuestas 
                        (Id_usuario, Id_pregunta1, respuesta1, Id_pregunta2, respuesta2, 
                         Id_pregunta3, respuesta3, Id_pregunta4, respuesta4,
                         Id_pregunta5, respuesta5, Id_pregunta6, respuesta6,
                         Id_pregunta7, respuesta7, Id_pregunta8, respuesta8, fecha_creacion)
                     VALUES 
                        (@idUsuario, @id1, @r1, @id2, @r2,
                         @id3, @r3, @id4, @r4,
                         @id5, @r5, @id6, @r6,
                         @id7, @r7, @id8, @r8, GETDATE())", con))
                    {
                        AgregarParametrosRespuestas(cmd, idUsuario,
                            id1, r1, id2, r2, id3, r3, id4, r4,
                            id5, r5, id6, r6, id7, r7, id8, r8);
                        cmd.ExecuteNonQuery();
                        return "INSERCION_OK";
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL al guardar respuestas: " + ex.Message);
                return "ERROR_SQL: " + ex.Message;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al guardar respuestas: " + ex.Message);
                return "ERROR: " + ex.Message;
            }
            finally
            {
                if (con != null)
                {
                    conexion.CerrarConexion();
                }
            }
        }

        private void AgregarParametrosRespuestas(SqlCommand cmd, int idUsuario,
            int id1, string r1, int id2, string r2, int id3, string r3, int id4, string r4,
            int id5, string r5, int id6, string r6, int id7, string r7, int id8, string r8)
        {
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@id1", id1); cmd.Parameters.AddWithValue("@r1", r1);
            cmd.Parameters.AddWithValue("@id2", id2); cmd.Parameters.AddWithValue("@r2", r2);
            cmd.Parameters.AddWithValue("@id3", id3); cmd.Parameters.AddWithValue("@r3", r3);
            cmd.Parameters.AddWithValue("@id4", id4); cmd.Parameters.AddWithValue("@r4", r4);
            cmd.Parameters.AddWithValue("@id5", id5); cmd.Parameters.AddWithValue("@r5", r5);
            cmd.Parameters.AddWithValue("@id6", id6); cmd.Parameters.AddWithValue("@r6", r6);
            cmd.Parameters.AddWithValue("@id7", id7); cmd.Parameters.AddWithValue("@r7", r7);
            cmd.Parameters.AddWithValue("@id8", id8); cmd.Parameters.AddWithValue("@r8", r8);
        }
    }
}
