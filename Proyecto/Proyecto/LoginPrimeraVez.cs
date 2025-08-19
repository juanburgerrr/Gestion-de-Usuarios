using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Usuario;
using Logica.Login; // Para la clase CambiarContraseña y SesionUsuario
using Sesion.Usuario;
using System.Text.RegularExpressions;

namespace Proyecto
{
    public partial class LoginPrimeraVez : Form
    {
        // El _idUsuario ya no necesita pasarse como parámetro al constructor
        // Se obtendrá desde SesionUsuario.IdUsuarioLogueado
        private Logica.CambiarContraseña _cambiarContrasenaLogica;

        // Constructor sin parámetros, ya que el ID viene de la sesión
        public LoginPrimeraVez()
        {
            InitializeComponent();
            _cambiarContrasenaLogica = new Logica.CambiarContraseña();
            txtContraseña.UseSystemPasswordChar = true;
            txtContraseñaRepetida.UseSystemPasswordChar = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            // Obtener el ID del usuario desde la sesión
            int idUsuario = SesionUsuario.IdUsuarioLogueado;

            if (idUsuario == 0) // Si por alguna razón no hay ID en la sesión
            {
                MessageBox.Show("Sesión de usuario no encontrada. Por favor, inicie sesión nuevamente.", "Error de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Opcional: Redirigir al login
                Login loginForm = new Login();
                loginForm.Show();
                this.Hide();
                return;
            }

            string nuevaContrasena = txtContraseña.Text;
            string confirmarContrasena = txtContraseñaRepetida.Text;

            if (string.IsNullOrWhiteSpace(nuevaContrasena) || string.IsNullOrWhiteSpace(confirmarContrasena))
            {
                MessageBox.Show("Por favor, ingrese y confirme la nueva contraseña.", "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nuevaContrasena != confirmarContrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifique.", "Error de Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!EsContrasenaSegura(nuevaContrasena))
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres, una mayúscula, una minúscula, un número y un carácter especial.", "Contraseña Débil", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string resultado = _cambiarContrasenaLogica.CambiarContrasenaUsuario(idUsuario, nuevaContrasena);

            if (resultado == "CAMBIO_OK")
            {
                MessageBox.Show("Contraseña cambiada exitosamente. Ahora puede iniciar sesión con su nueva contraseña.", "Cambio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LUsuario usuarioLogica = new LUsuario();
                var usuarioDetalles = usuarioLogica.ObtenerUsuario(idUsuario);

                if (usuarioDetalles != null)
                {
                    SesionUsuario.EstablecerSesion(
                        idUsuario,
                        usuarioDetalles.Rol,
                        $"{usuarioDetalles.Nombre} {usuarioDetalles.Apellido}",
                        usuarioDetalles.Correo
                    );
                }

                Inicio formInicio = new Inicio(); 
                formInicio.Show();
                this.Hide();
            }
            else if (resultado == "ERROR_DATOS_PERSONALES")
            {
                MessageBox.Show("La nueva contraseña no puede contener su nombre, apellido o legajo.", "Contraseña Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resultado == "ERROR_REPETIDA")
            {
                MessageBox.Show("La nueva contraseña no puede ser igual a su última contraseña.", "Contraseña Repetida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Ocurrió un error al cambiar la contraseña: {resultado}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsContrasenaSegura(string contrasena)
        {
            // Al menos 8 caracteres, una mayúscula, una minúscula, un número y un símbolo
            var regex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{8,}$");
            return regex.IsMatch(contrasena);
        }
        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            string contraseña = txtContraseña.Text;

            bool tieneMayuscula = contraseña.Any(char.IsUpper);
            bool tieneNumero = contraseña.Any(char.IsDigit);
            bool tieneEspecial = contraseña.Any(ch => !char.IsLetterOrDigit(ch));
            bool longitudCorrecta = contraseña.Length >= 8;

            // Cambiar texto y color según se cumpla o no cada condición
            lblMayuscula.Text = (tieneMayuscula ? "✅" : "❌") + " Al menos una mayúscula";
            lblNumero.Text = (tieneNumero ? "✅" : "❌") + " Al menos un número";
            lblEspecial.Text = (tieneEspecial ? "✅" : "❌") + " Al menos un carácter especial";
            lblLongitud.Text = (longitudCorrecta ? "✅" : "❌") + " Mínimo 8 caracteres";

            lblMayuscula.ForeColor = tieneMayuscula ? Color.Green : Color.Red;
            lblNumero.ForeColor = tieneNumero ? Color.Green : Color.Red;
            lblEspecial.ForeColor = tieneEspecial ? Color.Green : Color.Red;
            lblLongitud.ForeColor = longitudCorrecta ? Color.Green : Color.Red;
        }
    }
}
