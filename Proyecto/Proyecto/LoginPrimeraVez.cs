using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Logica.CambiarContra;
using Logica.Usuario;
using Sesion.Usuario;

namespace Proyecto
{
    public partial class LoginPrimeraVez : Form
    {
        private readonly L_CambiarContra cambiarcontra;
        private readonly int _idUsuario; // ID del usuario que se pasa desde Login

        // Constructor recibe el ID del usuario directamente
        public LoginPrimeraVez(int idUsuario)
        {
            InitializeComponent();
            _idUsuario = idUsuario;

            cambiarcontra = new L_CambiarContra();

            txtContraseña.UseSystemPasswordChar = true;
            txtContraseñaRepetida.UseSystemPasswordChar = true;

            txtContraseña.TextChanged += txtContraseña_TextChanged;
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

            string resultado = cambiarcontra.CambiarContra(_idUsuario, nuevaContrasena);

            if (resultado == "CAMBIO_OK")
            {
                MessageBox.Show("Contraseña cambiada exitosamente. Ahora puede iniciar sesión con su nueva contraseña.", "Cambio Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Aquí iniciamos sesión correctamente
                LUsuario usuarioLogica = new LUsuario();
                var usuarioDetalles = usuarioLogica.ObtenerUsuario(_idUsuario);

                if (usuarioDetalles != null)
                {
                    SesionUsuario.IniciarSesion(
                        _idUsuario,
                        usuarioDetalles.Rol,
                        $"{usuarioDetalles.Nombre} {usuarioDetalles.Apellido}",
                        usuarioDetalles.Correo
                    );
                }

                new Inicio().Show();
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
