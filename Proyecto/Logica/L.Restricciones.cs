using System;
using System.Data;
using System.Text.RegularExpressions;
using Datos;

namespace Logica
{
    public class L_Restricciones
    {
        private readonly D_Restricciones _datos;

        public L_Restricciones(string connectionString)
        {
            _datos = new D_Restricciones(connectionString);
        }

        public DataTable ObtenerRestricciones(int idTipoRestric)
        {
            return _datos.ObtenerRestricciones(idTipoRestric);
        }

        public void ActualizarRestriccion(string codigo, bool activa, int? cantidad = null)
        {
            _datos.ActualizarRestriccion(codigo, activa, cantidad);
        }

        public bool ValidarContraseña(string contraseña, int idTipoRestric, out string mensajeError)
        {
            mensajeError = "";
            DataTable restricciones = _datos.ObtenerRestricciones(idTipoRestric);

            foreach (DataRow row in restricciones.Rows)
            {
                string codigo = row["Cod_Restriccion"].ToString().Trim();
                bool activa = Convert.ToBoolean(row["Actividad"]);
                int? cantidad = row["Cantidad"] != DBNull.Value ? Convert.ToInt32(row["Cantidad"]) : (int?)null;

                if (!activa) continue;

                switch (codigo.ToUpper())
                {
                    case "MAYUS":
                        if (!Regex.IsMatch(contraseña, "[A-Z]"))
                            mensajeError = "La contraseña debe contener al menos una letra mayúscula.";
                        break;

                    case "NUMERO":
                        if (!Regex.IsMatch(contraseña, "[0-9]"))
                            mensajeError = "La contraseña debe contener al menos un número.";
                        break;

                    case "ESPECIAL":
                        if (!Regex.IsMatch(contraseña, "[^a-zA-Z0-9]"))
                            mensajeError = "La contraseña debe contener al menos un carácter especial.";
                        break;

                    case "LONG_MIN":
                        if (contraseña.Length < (cantidad ?? 8))
                            mensajeError = $"La contraseña debe tener al menos {(cantidad ?? 8)} caracteres.";
                        break;
                }

                if (!string.IsNullOrEmpty(mensajeError))
                    return false;
            }

            return true;
        }
    }
}
