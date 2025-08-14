using System;
using System.Data;
using System.Windows.Forms;
using Logica;

namespace Proyecto
{
    public partial class Restricciones : Form
    {
        private readonly L_Restricciones _logicaRestricciones;

        public Restricciones()
        {
            InitializeComponent();
            _logicaRestricciones = new L_Restricciones("TU_CONNECTION_STRING");
            CargarRestricciones();
        }

        private void CargarRestricciones()
        {
            try
            {
                DataTable dt = _logicaRestricciones.ObtenerRestricciones(1); // ID fijo o según tu necesidad

                foreach (DataRow row in dt.Rows)
                {
                    string codigo = row["Cod_Restriccion"].ToString().Trim().ToUpper();
                    bool activa = Convert.ToBoolean(row["Actividad"]);

                    switch (codigo)
                    {
                        case "MAYUS":
                            chkMayuscula.Checked = activa;
                            break;
                        case "NUMERO":
                            chkNumero.Checked = activa;
                            break;
                        case "ESPECIAL":
                            chkEspecial.Checked = activa;
                            break;
                        case "LONG_MIN":
                            chkLongitudMinima.Checked = activa;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar restricciones: " + ex.Message);
            }
        }

        private void GuardarRestricciones()
        {
            try
            {
                _logicaRestricciones.ActualizarRestriccion("MAYUS", chkMayuscula.Checked);
                _logicaRestricciones.ActualizarRestriccion("NUMERO", chkNumero.Checked);
                _logicaRestricciones.ActualizarRestriccion("ESPECIAL", chkEspecial.Checked);
                _logicaRestricciones.ActualizarRestriccion("LONG_MIN", chkLongitudMinima.Checked);

                MessageBox.Show("Restricciones actualizadas correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarRestricciones();
        }

        // NO TOCAR ESTO PORQUE DEJA DE ANDAR EL DISEÑO
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
