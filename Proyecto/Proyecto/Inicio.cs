using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica; 
using Sesion.Usuario;  
using Logica.Sesion;

namespace Proyecto
{
    public partial class Inicio : Form
    {
        // Archivos
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        // Constructor único sin parámetros
        public Inicio()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;

            // Carga la información del usuario y configura los botones al iniciar el formulario
            CargarInfoUsuario();
            ConfigurarBotonesPorRol();
        }

        // Método para cargar la información del usuario en los labels
               private void CargarInfoUsuario()
        {
            var logicaSesion = new L_Sesion();
            var sesion = logicaSesion.ObtenerSesionActual();

            if (sesion != null)
            {
                lblNombreUsuario.Text = $"Usuario: {sesion.Nombre}";
                lblRolUsuario.Text = $"Rol: {sesion.Rol}";
                lblEmailUsuario.Text = $"Email: {sesion.Correo}";
            }
            else
            {
                lblNombreUsuario.Text = "Usuario: No encontrado";
                lblRolUsuario.Text = "Rol: Desconocido";
                lblEmailUsuario.Text = "Email: Desconocido";
                MessageBox.Show("No se pudo cargar la información del usuario. Sesión no establecida.", 
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarBotonesPorRol()
        {
            var logicaSesion = new L_Sesion();
            var sesion = logicaSesion.ObtenerSesionActual();

            btnRegister.Visible = false;
            btnRestriccion.Visible = false;
            btnPermiso.Visible = false;
            btnCambiarContraseña.Visible = false;
            btnCambiarPreguntaSeguridad.Visible = false;

            if (sesion == null) return;

            switch (sesion.Rol)
            {
                case "Administrador":
                    btnRegister.Visible = true;
                    btnRestriccion.Visible = true;
                    btnPermiso.Visible = true;
                    btnCambiarContraseña.Visible = true;
                    btnCambiarPreguntaSeguridad.Visible = true;
                    break;
                case "Personal":
                    btnCambiarContraseña.Visible = true;
                    btnCambiarPreguntaSeguridad.Visible = true;
                    break;
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var logicaSesion = new L_Sesion();
            logicaSesion.CerrarSesion();

            this.Hide();
            Login login = new Login();
            login.Show();
        }


        // Otros métodos de diseño, etc.
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                DisableButton();
                if (currentButton != (Button)btnSender)
                {
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChild(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            OpenChild(new Register(), sender);
        }

        private void btnRestriccion_Click(object sender, EventArgs e)
        {
            OpenChild(new Restricciones(), sender);
        }

        private void btnPermiso_Click(object sender, EventArgs e)
        {
            OpenChild(new Permisos(), sender);
        }
       

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            OpenChild(new CambiarContraseña(), sender);
        }

        private void btnCambiarPreguntaSeguridad_Click(object sender, EventArgs e)
        {
            OpenChild(new CambiarPreguntaSeguridad(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Inicio";
            panelTitleBar.BackColor = Color.Black;
            panelLogo.BackColor = Color.Black;
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Este es el label que probablemente quieras usar para el nombre de usuario
            // Asegúrate de cambiar su nombre en el diseñador a lblNombreUsuario
        }
    }
}
