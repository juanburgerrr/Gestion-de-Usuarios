using System;
using System.Windows.Forms;
using Logica;

namespace Proyecto
{
    public partial class CambiarContraseña : Form
    {
        private readonly L_CambiarContra logica;

        public CambiarContraseña()
        {
            InitializeComponent();
            logica = new L_CambiarContra();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // Evento del botón (button1)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtengo valores de los TextBox
                int idUsuario = int.Parse(textBox1.Text); // ID de usuario
                string nuevaPass = textBox2.Text;         // Nueva contraseña

                // Llamo a la capa lógica
                string resultado = logica.CambiarContra(idUsuario, nuevaPass);

                // Muestro el resultado al usuario
                if (resultado == "CAMBIO_OK")
                {
                    MessageBox.Show("La contraseña fue cambiada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (resultado == "ERROR_DATOS_PERSONALES")
                {
                    MessageBox.Show("La contraseña no puede contener nombre, apellido o legajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (resultado == "ERROR_REPETIDA")
                {
                    MessageBox.Show("La nueva contraseña no puede ser igual a la última.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error desconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Excepción", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
