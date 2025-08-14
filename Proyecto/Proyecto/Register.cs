using Logica.Registro; // Para PersonalLogica
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Servicios.RandomPass;
using Logica.DatosCbox;
using Servicios.Email;
namespace Proyecto
{
    public partial class Register : Form
    {
        // Instancias de las clases de la capa de Lógica que se usarán
        private PersonalLogica _personalLogica; // Solo para registrar nuevo personal
        private DatosCbox _datosCboxLogica; // Para obtener datos de ComboBoxes
        private Logica.DatosDomicilio _datosDomicilioLogica; // Para obtener datos de domicilio por CP

        public Register()
        {
            InitializeComponent();

            // Inicializar las instancias de las clases de lógica
            _personalLogica = new PersonalLogica(); // Solo para RegistrarNuevoPersonal
            _datosCboxLogica = new Logica.DatosCbox.DatosCbox();
            _datosDomicilioLogica = new Logica.DatosDomicilio();

            CargarCombosIniciales(); // Carga solo los combos que no dependen del CP
            ConfigurarEventosCodigoPostal(); // Nuevo evento para el txtCodigoPostal

            // Asegurarse de que los campos de domicilio no sean editables manualmente
            txtLocalidad.ReadOnly = true;
            txtPartido.ReadOnly = true;
            txtProvincia.ReadOnly = true;

            // Asociar el evento KeyPress al campo DNI
            this.txtNroDoc.KeyPress += new KeyPressEventHandler(txtNroDoc_KeyPress);
        }

        // Carga los ComboBoxes iniciales (Tipo de Documento, Género, Rol)
        private void CargarCombosIniciales()
        {
            cmbSexo.Items.Add("M");
            cmbSexo.Items.Add("F");
            cmbSexo.Items.Add("Otro");
            cmbSexo.SelectedIndex = 0;


            cmbGenero.DataSource = _datosCboxLogica.GetGeneros();
            cmbGenero.DisplayMember = "Genero";
            cmbGenero.ValueMember = "Id_Genero";
            cmbGenero.SelectedIndex = -1;


            cmbTipoDoc.DataSource = _datosCboxLogica.GetTiposDocumento();
            cmbTipoDoc.DisplayMember = "TipoDoc";
            cmbTipoDoc.ValueMember = "Id_TipoDoc";
            cmbTipoDoc.SelectedIndex = -1;


            cmbRol.DataSource = _datosCboxLogica.GetRoles();
            cmbRol.DisplayMember = "Rol";
            cmbRol.ValueMember = "Id_Rol";
            cmbRol.SelectedIndex = -1;

        }

        // Configura el evento para el TextBox de Código Postal
        private void ConfigurarEventosCodigoPostal()
        {
            txtCodigoPostal.Leave += new EventHandler(txtCodigoPostal_Leave);
        }

        // Evento Leave para txtCodigoPostal: Obtiene y rellena los datos de domicilio
        private void txtCodigoPostal_Leave(object? sender, EventArgs e)
        {
            txtLocalidad.Clear();
            txtPartido.Clear();
            txtProvincia.Clear();

            if (string.IsNullOrWhiteSpace(txtCodigoPostal.Text))
            {
                return;
            }

            if (int.TryParse(txtCodigoPostal.Text, out int codigoPostal))
            {
                // Llama a la lógica específica para obtener los datos de domicilio por CP
                DataTable dtDatosDomicilio = _datosDomicilioLogica.CodigoPostal(codigoPostal);

                if (dtDatosDomicilio != null && dtDatosDomicilio.Rows.Count > 0)
                {
                    DataRow row = dtDatosDomicilio.Rows[0];
                    txtLocalidad.Text = row["Localidad"]?.ToString();
                    txtPartido.Text = row["Partido"]?.ToString();
                    txtProvincia.Text = row["Provincia"]?.ToString();
                }
                else
                {
                    MessageBox.Show("Código Postal no encontrado o sin datos asociados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un Código Postal válido (solo números).", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Evento Click del botón Guardar
        private void BtnGuardar_Click(object sender, EventArgs e)
        {


            string contrasena = string.Empty;

            try
            {
                // Validaciones básicas (igual que antes)
                if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    string.IsNullOrWhiteSpace(txtNroDoc.Text) || string.IsNullOrWhiteSpace(txtCUIL.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text) || string.IsNullOrWhiteSpace(txtTeléfono.Text) ||
                    string.IsNullOrWhiteSpace(txtCalle.Text) || string.IsNullOrWhiteSpace(txtNumero.Text) ||
                    string.IsNullOrWhiteSpace(txtCodigoPostal.Text) || string.IsNullOrWhiteSpace(txtLocalidad.Text) ||
                    string.IsNullOrWhiteSpace(txtUsuarioLogin.Text) ||
                    cmbSexo.SelectedItem == null || cmbTipoDoc.SelectedItem == null || cmbRol.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación DNI
                if (!txtNroDoc.Text.All(char.IsDigit) || txtNroDoc.Text.Length > 8)
                {
                    MessageBox.Show("El DNI debe contener solo números y tener como máximo 8 dígitos.", "DNI inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación edad mínima
                DateTime fechaNacimiento = dtpFechaNacimiento.Value;
                int edad = DateTime.Today.Year - fechaNacimiento.Year;
                if (fechaNacimiento > DateTime.Today.AddYears(-edad)) edad--;

                if (edad < 18)
                {
                    MessageBox.Show("El usuario debe tener al menos 18 años.", "Edad inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validación email
                string correo = txtCorreo.Text.Trim();
                if (!correo.Contains("@") || !correo.EndsWith(".com"))
                {
                    MessageBox.Show("Ingrese un correo electrónico válido que contenga '@' y termine en '.com'.", "Correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                contrasena = RandomPass.Aleatorios.Armar(true, 12, 2);


                bool exito = _personalLogica.RegistrarNuevoPersonal(
             txtNombre.Text,
             txtApellido.Text,
             cmbSexo.SelectedItem.ToString()[0],  
             cmbSexo.SelectedItem.ToString(),    
             fechaNacimiento,
             cmbTipoDoc.Text,
             Convert.ToInt32(txtNroDoc.Text),
             txtCUIL.Text,
             correo,
             Convert.ToInt32(txtTeléfono.Text),
             txtLocalidad.Text,
             txtCalle.Text,
             Convert.ToInt32(txtNumero.Text),
             string.IsNullOrEmpty(txtFloor.Text) ? (int?)null : Convert.ToInt32(txtFloor.Text),
             string.IsNullOrEmpty(txtDepto.Text) ? null : txtDepto.Text,
             txtUsuarioLogin.Text,
             contrasena,
             cmbRol.Text                       
         );


                if (exito)
                {
                    try
                    {
                        EmailSender.EnviarBienvenida(
                            txtCorreo.Text,
                            txtNombre.Text,
                            txtUsuarioLogin.Text,
                            contrasena
                        );

                        MessageBox.Show("Registro exitoso. La contraseña fue enviada por email.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new Login().Show();
                    }
                    catch (Exception emailEx)
                    {
                        MessageBox.Show($"Registro exitoso, pero no se pudo enviar el correo: {emailEx.Message}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    LimpiarCampos();
                }

                else
                {
                    MessageBox.Show("Error al registrar personal y usuario. Revise los datos e intente nuevamente.", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores válidos en los campos numéricos (Nro. Documento, Teléfono, Número, Código Postal, Piso).", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}\nDetalle: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Limpiar campos después de registrar
        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cmbSexo.SelectedIndex = 0;
            dtpFechaNacimiento.Value = DateTime.Now;
            cmbTipoDoc.SelectedIndex = -1;
            txtNroDoc.Clear();
            txtCUIL.Clear();
            txtCorreo.Clear();
            txtTeléfono.Clear();

            txtCodigoPostal.Clear();
            txtLocalidad.Clear();
            txtPartido.Clear();
            txtProvincia.Clear();

            txtCalle.Clear();
            txtNumero.Clear();
            txtFloor.Clear();
            txtDepto.Clear();
            cmbRol.SelectedIndex = -1;
            txtUsuarioLogin.Clear();
        }

        // Evento KeyPress para txtNroDoc (bloquear letras y limitar a 8 dígitos)
        private void txtNroDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números y teclas de control (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea letras y símbolos       
                return;
            }

            // Limitar a 8 caracteres
            if (char.IsDigit(e.KeyChar) && txtNroDoc.Text.Length >= 8 && string.IsNullOrEmpty(txtNroDoc.SelectedText))
            {
                e.Handled = true;
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }
    }
}
