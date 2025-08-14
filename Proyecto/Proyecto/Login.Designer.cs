namespace Proyecto
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            label5 = new Label();
            label6 = new Label();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            linkRecuperarContraseña = new LinkLabel();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 31);
            panel1.TabIndex = 0;
            // 
            // btnMinimize
            // 
            btnMinimize.BackgroundImage = Vista.Properties.Resources.Subtract;
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(928, 1);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(37, 31);
            btnMinimize.TabIndex = 20;
            btnMinimize.UseVisualStyleBackColor = true;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(971, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 31);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(92, 245);
            label5.Name = "label5";
            label5.Size = new Size(149, 37);
            label5.TabIndex = 12;
            label5.Text = "Bienvenido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(27, 347);
            label6.Name = "label6";
            label6.Size = new Size(283, 25);
            label6.TabIndex = 13;
            label6.Text = "Ingrese su usuario y contraseña ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(0, 30);
            panel3.Name = "panel3";
            panel3.Size = new Size(334, 515);
            panel3.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(82, 41);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(170, 187);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 11;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SkyBlue;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(linkRecuperarContraseña);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(506, 119);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 342);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(206, 185);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(128, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Mostrar contraseña";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(11, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 55);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 55);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // linkRecuperarContraseña
            // 
            linkRecuperarContraseña.AutoSize = true;
            linkRecuperarContraseña.BackColor = Color.Transparent;
            linkRecuperarContraseña.DisabledLinkColor = Color.Black;
            linkRecuperarContraseña.LinkColor = Color.Black;
            linkRecuperarContraseña.Location = new Point(115, 223);
            linkRecuperarContraseña.Name = "linkRecuperarContraseña";
            linkRecuperarContraseña.Size = new Size(141, 15);
            linkRecuperarContraseña.TabIndex = 6;
            linkRecuperarContraseña.TabStop = true;
            linkRecuperarContraseña.Text = "¿Olvidaste tu contraseña?";
            linkRecuperarContraseña.LinkClicked += linkRecuperarContraseña_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(67, 124);
            label4.Name = "label4";
            label4.Size = new Size(189, 19);
            label4.TabIndex = 5;
            label4.Text = "Ingrese contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(67, 53);
            label3.Name = "label3";
            label3.Size = new Size(159, 19);
            label3.TabIndex = 4;
            label3.Text = "Ingrese Usuario";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(70, 156);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 23);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("SimSun", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 3;
            label1.Text = "Inicie sesion";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.WaitCursor;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(105, 241);
            button2.Name = "button2";
            button2.Size = new Size(161, 54);
            button2.TabIndex = 1;
            button2.Text = "Iniciar sesion";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnIniciarSesion_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 23);
            textBox1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.LightCyan;
            pictureBox3.Location = new Point(330, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(678, 545);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 544);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkRecuperarContraseña;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
    }
}

