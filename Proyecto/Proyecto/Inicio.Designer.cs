namespace Proyecto
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            panelMenu = new Panel();
            panel123 = new Panel();
            pictureBox4 = new PictureBox();
            lblRolUsuario = new Label();
            lblEmailUsuario = new Label();
            lblNombreUsuario = new Label();
            btnCambiarPreguntaSeguridad = new Button();
            btnCambiarContraseña = new Button();
            btnCerrarSesion = new Button();
            btnRegister = new Button();
            panelLogo = new Panel();
            label5 = new Label();
            btnRestriccion = new Button();
            btnPermiso = new Button();
            panelDesktopPanel = new Panel();
            panelTitleBar = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            btnCloseChildForm = new Button();
            lblTitle = new Label();
            pictureBox1 = new PictureBox();
            panelMenu.SuspendLayout();
            panel123.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelLogo.SuspendLayout();
            panelDesktopPanel.SuspendLayout();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.DimGray;
            panelMenu.Controls.Add(panel123);
            panelMenu.Controls.Add(btnCambiarPreguntaSeguridad);
            panelMenu.Controls.Add(btnCambiarContraseña);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Controls.Add(btnRegister);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(btnRestriccion);
            panelMenu.Controls.Add(btnPermiso);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(4, 3, 4, 3);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 813);
            panelMenu.TabIndex = 7;
            // 
            // panel123
            // 
            panel123.Controls.Add(pictureBox4);
            panel123.Controls.Add(lblRolUsuario);
            panel123.Controls.Add(lblEmailUsuario);
            panel123.Controls.Add(lblNombreUsuario);
            panel123.Dock = DockStyle.Bottom;
            panel123.Location = new Point(0, 545);
            panel123.Name = "panel123";
            panel123.Size = new Size(220, 205);
            panel123.TabIndex = 33;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom;
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(43, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 121);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // lblRolUsuario
            // 
            lblRolUsuario.AutoSize = true;
            lblRolUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRolUsuario.ForeColor = Color.LightGray;
            lblRolUsuario.Location = new Point(41, 148);
            lblRolUsuario.Name = "lblRolUsuario";
            lblRolUsuario.Size = new Size(54, 21);
            lblRolUsuario.TabIndex = 31;
            lblRolUsuario.Text = "LblRol";
            // 
            // lblEmailUsuario
            // 
            lblEmailUsuario.AutoSize = true;
            lblEmailUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmailUsuario.ForeColor = Color.LightGray;
            lblEmailUsuario.Location = new Point(41, 169);
            lblEmailUsuario.Name = "lblEmailUsuario";
            lblEmailUsuario.Size = new Size(73, 21);
            lblEmailUsuario.TabIndex = 32;
            lblEmailUsuario.Text = "Lbl Email";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombreUsuario.ForeColor = Color.LightGray;
            lblNombreUsuario.Location = new Point(41, 127);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(89, 21);
            lblNombreUsuario.TabIndex = 30;
            lblNombreUsuario.Text = "LblNombre";
            // 
            // btnCambiarPreguntaSeguridad
            // 
            btnCambiarPreguntaSeguridad.FlatStyle = FlatStyle.Flat;
            btnCambiarPreguntaSeguridad.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambiarPreguntaSeguridad.ForeColor = Color.Gainsboro;
            btnCambiarPreguntaSeguridad.Image = (Image)resources.GetObject("btnCambiarPreguntaSeguridad.Image");
            btnCambiarPreguntaSeguridad.ImageAlign = ContentAlignment.MiddleLeft;
            btnCambiarPreguntaSeguridad.Location = new Point(0, 350);
            btnCambiarPreguntaSeguridad.Name = "btnCambiarPreguntaSeguridad";
            btnCambiarPreguntaSeguridad.Size = new Size(220, 60);
            btnCambiarPreguntaSeguridad.TabIndex = 25;
            btnCambiarPreguntaSeguridad.Text = "Cambiar pregSeg";
            btnCambiarPreguntaSeguridad.UseVisualStyleBackColor = true;
            btnCambiarPreguntaSeguridad.Click += btnCambiarPreguntaSeguridad_Click;
            // 
            // btnCambiarContraseña
            // 
            btnCambiarContraseña.BackgroundImageLayout = ImageLayout.Zoom;
            btnCambiarContraseña.FlatStyle = FlatStyle.Flat;
            btnCambiarContraseña.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCambiarContraseña.ForeColor = Color.Gainsboro;
            btnCambiarContraseña.Image = (Image)resources.GetObject("btnCambiarContraseña.Image");
            btnCambiarContraseña.ImageAlign = ContentAlignment.MiddleLeft;
            btnCambiarContraseña.Location = new Point(3, 284);
            btnCambiarContraseña.Name = "btnCambiarContraseña";
            btnCambiarContraseña.Size = new Size(220, 60);
            btnCambiarContraseña.TabIndex = 24;
            btnCambiarContraseña.Text = "Cambiar contra";
            btnCambiarContraseña.UseVisualStyleBackColor = true;
            btnCambiarContraseña.Click += btnCambiarContraseña_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.Transparent;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(0, 750);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(220, 63);
            btnCerrarSesion.TabIndex = 22;
            btnCerrarSesion.Text = "Cerrar sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnRegister
            // 
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.Gainsboro;
            btnRegister.Image = (Image)resources.GetObject("btnRegister.Image");
            btnRegister.ImageAlign = ContentAlignment.MiddleLeft;
            btnRegister.Location = new Point(0, 86);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(220, 60);
            btnRegister.TabIndex = 17;
            btnRegister.Text = "Registrar Personal";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(64, 64, 64);
            panelLogo.Controls.Add(label5);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(220, 80);
            panelLogo.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(35, 26);
            label5.Name = "label5";
            label5.Size = new Size(143, 21);
            label5.TabIndex = 0;
            label5.Text = "Gestor De Empresa";
            label5.Click += label5_Click;
            // 
            // btnRestriccion
            // 
            btnRestriccion.FlatStyle = FlatStyle.Flat;
            btnRestriccion.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestriccion.ForeColor = Color.Gainsboro;
            btnRestriccion.Image = (Image)resources.GetObject("btnRestriccion.Image");
            btnRestriccion.ImageAlign = ContentAlignment.MiddleLeft;
            btnRestriccion.Location = new Point(3, 152);
            btnRestriccion.Name = "btnRestriccion";
            btnRestriccion.Size = new Size(220, 60);
            btnRestriccion.TabIndex = 14;
            btnRestriccion.Text = "Restricciones";
            btnRestriccion.UseVisualStyleBackColor = true;
            btnRestriccion.Click += btnRestriccion_Click;
            // 
            // btnPermiso
            // 
            btnPermiso.FlatStyle = FlatStyle.Flat;
            btnPermiso.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPermiso.ForeColor = Color.Gainsboro;
            btnPermiso.Image = (Image)resources.GetObject("btnPermiso.Image");
            btnPermiso.ImageAlign = ContentAlignment.MiddleLeft;
            btnPermiso.Location = new Point(0, 218);
            btnPermiso.Name = "btnPermiso";
            btnPermiso.Size = new Size(220, 60);
            btnPermiso.TabIndex = 13;
            btnPermiso.Text = "Permisos";
            btnPermiso.UseVisualStyleBackColor = true;
            btnPermiso.Click += btnPermiso_Click;
            // 
            // panelDesktopPanel
            // 
            panelDesktopPanel.BackColor = Color.White;
            panelDesktopPanel.Controls.Add(panelTitleBar);
            panelDesktopPanel.Controls.Add(pictureBox1);
            panelDesktopPanel.Dock = DockStyle.Fill;
            panelDesktopPanel.Location = new Point(220, 0);
            panelDesktopPanel.Name = "panelDesktopPanel";
            panelDesktopPanel.Size = new Size(1248, 813);
            panelDesktopPanel.TabIndex = 29;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.Black;
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Controls.Add(btnCloseChildForm);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(1248, 80);
            panelTitleBar.TabIndex = 29;
            // 
            // btnMinimize
            // 
            btnMinimize.BackgroundImage = Vista.Properties.Resources.Subtract;
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(1201, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(23, 80);
            btnMinimize.TabIndex = 19;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click_1;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(1224, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(24, 80);
            btnClose.TabIndex = 18;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click_2;
            // 
            // btnCloseChildForm
            // 
            btnCloseChildForm.BackgroundImage = Vista.Properties.Resources.Close;
            btnCloseChildForm.BackgroundImageLayout = ImageLayout.Center;
            btnCloseChildForm.Dock = DockStyle.Left;
            btnCloseChildForm.FlatAppearance.BorderSize = 0;
            btnCloseChildForm.FlatStyle = FlatStyle.Flat;
            btnCloseChildForm.Location = new Point(0, 0);
            btnCloseChildForm.Name = "btnCloseChildForm";
            btnCloseChildForm.Size = new Size(75, 80);
            btnCloseChildForm.TabIndex = 0;
            btnCloseChildForm.Click += btnCloseChildForm_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(589, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(93, 30);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "INICIO";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Vista.Properties.Resources._20250601_0012_Logo_Gestor_de_Empresa_simple_compose_01jwmqhpb9ev6t8pekkhjx8ehq;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1248, 813);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1468, 813);
            Controls.Add(panelDesktopPanel);
            Controls.Add(panelMenu);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(900, 450);
            Name = "Inicio";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panelMenu.ResumeLayout(false);
            panel123.ResumeLayout(false);
            panel123.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelDesktopPanel.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnRestriccion;
        private System.Windows.Forms.Button btnPermiso;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Label lblTitle;
        
        private System.Windows.Forms.Button btnCambiarPreguntaSeguridad;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private Label lblNombreUsuario;
        private Label lblEmailUsuario;
        private Label lblRolUsuario;
        private Panel panel123;
    }
}