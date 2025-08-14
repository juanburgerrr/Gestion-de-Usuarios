using Microsoft.Data.SqlClient;
using System.Data;
using System;

namespace Datos.Registro
{
    public class DRegistro
    {
        private readonly Conexion.Conexion conexion = new Conexion.Conexion();

        public bool RegistrarPersonalYUsuario(int legajo, string nombre, string apellido, string Sexo, string genero, DateTime fecha_nac,
            string Tipo_doc, int nrodoc, string cuil, string correo, int telefono, string localidad, string calle,
            int num, int? piso, string? depto, string n_usuario, string password, string rol)
        {
            SqlConnection con = null;
            try
            {
                con = conexion.AbrirConexion();
                using (SqlCommand cmd = new SqlCommand("SP_RegistroPersonalCompleto", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@legajo_generado", legajo);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@sexo", Sexo);
                    cmd.Parameters.AddWithValue("@genero", genero);
                    cmd.Parameters.AddWithValue("@fecha_nac", fecha_nac);
                    cmd.Parameters.AddWithValue("@tipo_doc_desc", Tipo_doc);
                    cmd.Parameters.AddWithValue("@nrodoc", nrodoc);
                    cmd.Parameters.AddWithValue("@cuil", cuil); // <-- CUIL como string
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@localidad_desc", localidad);
                    cmd.Parameters.AddWithValue("@calle", calle);
                    cmd.Parameters.AddWithValue("@nro", num);
                    cmd.Parameters.AddWithValue("@piso", piso ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@depto", string.IsNullOrEmpty(depto) ? (object)DBNull.Value : depto);
                    cmd.Parameters.AddWithValue("@nombre_usuario_login", n_usuario);
                    cmd.Parameters.AddWithValue("@password_generica", password);
                    cmd.Parameters.AddWithValue("@rol_desc", rol);

                    SqlParameter registrado = new SqlParameter("@registrado", SqlDbType.Bit)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(registrado);

                    cmd.ExecuteNonQuery();

                    bool registradoBool = Convert.ToBoolean(registrado.Value);
                    Console.WriteLine("Valor parámetro @registrado = " + registradoBool);
                    return registradoBool;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL al registrar personal: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general al registrar personal: " + ex.Message);
                return false;
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