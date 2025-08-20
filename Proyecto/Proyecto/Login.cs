using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.Login;    
using Logica.Usuario;
using Sesion.Usuario; 
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true; // Asegurarse de que la contraseña esté oculta al inicio
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Evento click del PictureBox (si tiene alguna funcionalidad)
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Verifica si el CheckBox está marcado
            if (checkBox1.Checked)
            {
                // Si está marcado, mostramos la contraseña
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                // Si no está marcado, censuramos la contraseña con asteriscos
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // Evento Paint del Panel (si tiene alguna funcionalidad de dibujo)
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            LLogin loginLogica = new LLogin();
            var (estado, idUsuario, nombre, apellido, correo, rol) = loginLogica.Validar(textBox1.Text, textBox2.Text);

            if (idUsuario.HasValue)
            {
                SesionUsuario.IniciarSesion(
                    idUsuario.Value,
                    rol,
                    $"{nombre} {apellido}",
                    correo
                );
            }

            switch (estado)
            {
                case "OK":
                    new Inicio().Show();
                    this.Hide();
                    break;
                case "CAMBIO_OBLIGATORIO":
                case "VENCIDA":
                    new LoginPrimeraVez(idUsuario.Value).Show();
                    this.Hide();
                    break;

                case "BLOQUEADO":
                    MessageBox.Show("Usuario bloqueado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show("Error de autenticación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }





        private void linkRecuperarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RecuperarContraseña recuperar = new RecuperarContraseña();
            recuperar.ShowDialog();
        }
    }
}
