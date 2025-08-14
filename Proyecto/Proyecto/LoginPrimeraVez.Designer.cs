namespace Proyecto
{
    partial class LoginPrimeraVez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPrimeraVez));
            txtContraseña = new TextBox();
            txtContraseñaRepetida = new TextBox();
            btnGuardarCambios = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnMinimize = new Button();
            btnClose = new Button();
            panel3 = new Panel();
            label13 = new Label();
            label12 = new Label();
            textBox10 = new TextBox();
            label11 = new Label();
            textBox9 = new TextBox();
            label10 = new Label();
            textBox8 = new TextBox();
            label9 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            lblLongitud = new Label();
            lblEspecial = new Label();
            lblNumero = new Label();
            lblMayuscula = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(102, 273);
            txtContraseña.Margin = new Padding(4, 3, 4, 3);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(307, 23);
            txtContraseña.TabIndex = 3;
            // 
            // txtContraseñaRepetida
            // 
            txtContraseñaRepetida.Location = new Point(102, 430);
            txtContraseñaRepetida.Margin = new Padding(4, 3, 4, 3);
            txtContraseñaRepetida.Name = "txtContraseñaRepetida";
            txtContraseñaRepetida.Size = new Size(307, 23);
            txtContraseñaRepetida.TabIndex = 4;
            // 
            // btnGuardarCambios
            // 
            btnGuardarCambios.BackColor = Color.CornflowerBlue;
            btnGuardarCambios.FlatAppearance.BorderSize = 0;
            btnGuardarCambios.FlatStyle = FlatStyle.Flat;
            btnGuardarCambios.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarCambios.ForeColor = SystemColors.Control;
            btnGuardarCambios.Location = new Point(157, 466);
            btnGuardarCambios.Margin = new Padding(4, 3, 4, 3);
            btnGuardarCambios.Name = "btnGuardarCambios";
            btnGuardarCambios.Size = new Size(198, 51);
            btnGuardarCambios.TabIndex = 5;
            btnGuardarCambios.Text = "Guardar cambios";
            btnGuardarCambios.UseVisualStyleBackColor = false;
            btnGuardarCambios.Click += btnGuardarCambios_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(102, 251);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 19);
            label1.TabIndex = 6;
            label1.Text = "Nueva contraseña";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(102, 408);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 19);
            label2.TabIndex = 7;
            label2.Text = "Repetir contraseña";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnMinimize);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1176, 36);
            panel1.TabIndex = 8;
            // 
            // btnMinimize
            // 
            btnMinimize.BackgroundImage = Vista.Properties.Resources.Subtract;
            btnMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Location = new Point(1083, 1);
            btnMinimize.Margin = new Padding(4, 3, 4, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(43, 36);
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
            btnClose.Location = new Point(1133, 0);
            btnClose.Margin = new Padding(4, 3, 4, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(43, 36);
            btnClose.TabIndex = 0;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SkyBlue;
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(textBox9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(textBox8);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 36);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(390, 592);
            panel3.TabIndex = 9;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("SimSun", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(44, 32);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(274, 21);
            label13.TabIndex = 30;
            label13.Text = "preguntas de seguridad";
            label13.UseWaitCursor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("SimSun", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.Location = new Point(29, 11);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(322, 21);
            label12.TabIndex = 29;
            label12.Text = "Responda a las siguientes ";
            label12.UseWaitCursor = true;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(44, 556);
            textBox10.Margin = new Padding(4, 3, 4, 3);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(307, 23);
            textBox10.TabIndex = 28;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(41, 538);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(155, 15);
            label11.TabIndex = 27;
            label11.Text = "¿Cuál es tu comida favorita?";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(44, 511);
            textBox9.Margin = new Padding(4, 3, 4, 3);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(307, 23);
            textBox9.TabIndex = 26;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 493);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(149, 15);
            label10.TabIndex = 25;
            label10.Text = "¿Cuál es su artista favorito?";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(44, 466);
            textBox8.Margin = new Padding(4, 3, 4, 3);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(307, 23);
            textBox8.TabIndex = 24;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 448);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(106, 15);
            label9.TabIndex = 23;
            label9.Text = "¿Cual es tu apodo?";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(44, 421);
            textBox7.Margin = new Padding(4, 3, 4, 3);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(307, 23);
            textBox7.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(41, 403);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(272, 15);
            label8.TabIndex = 21;
            label8.Text = "¿Cómo se llamaba su primer amigo de la infancia?";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(44, 376);
            textBox6.Margin = new Padding(4, 3, 4, 3);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(307, 23);
            textBox6.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(44, 331);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(307, 23);
            textBox5.TabIndex = 19;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(44, 286);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(307, 23);
            textBox4.TabIndex = 18;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(44, 241);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 23);
            textBox3.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 358);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(158, 15);
            label7.TabIndex = 16;
            label7.Text = "¿Cuál es su deporte favorito?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 313);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(143, 15);
            label6.TabIndex = 15;
            label6.Text = "¿Cual es tu color favorito?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 268);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(239, 15);
            label5.TabIndex = 14;
            label5.Text = "¿Cuál era el nombre de tu primera mascota?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 223);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 15);
            label4.TabIndex = 13;
            label4.Text = "¿En qué ciudad naciste?";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(92, 70);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.None;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(157, 12);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(198, 216);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(lblLongitud);
            panel2.Controls.Add(lblEspecial);
            panel2.Controls.Add(lblNumero);
            panel2.Controls.Add(lblMayuscula);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(txtContraseña);
            panel2.Controls.Add(txtContraseñaRepetida);
            panel2.Controls.Add(btnGuardarCambios);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(554, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(522, 592);
            panel2.TabIndex = 13;
            // 
            // lblLongitud
            // 
            lblLongitud.AutoSize = true;
            lblLongitud.Location = new Point(108, 360);
            lblLongitud.Name = "lblLongitud";
            lblLongitud.Size = new Size(0, 15);
            lblLongitud.TabIndex = 20;
            // 
            // lblEspecial
            // 
            lblEspecial.AutoSize = true;
            lblEspecial.Location = new Point(108, 345);
            lblEspecial.Name = "lblEspecial";
            lblEspecial.Size = new Size(0, 15);
            lblEspecial.TabIndex = 19;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(108, 330);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(0, 15);
            lblNumero.TabIndex = 18;
            // 
            // lblMayuscula
            // 
            lblMayuscula.AutoSize = true;
            lblMayuscula.Location = new Point(108, 314);
            lblMayuscula.Name = "lblMayuscula";
            lblMayuscula.Size = new Size(0, 15);
            lblMayuscula.TabIndex = 17;
            // 
            // LoginPrimeraVez
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 628);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginPrimeraVez";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginPrimeraVez";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtContraseñaRepetida;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private Panel panel2;
        private Label lblLongitud;
        private Label lblEspecial;
        private Label lblNumero;
        private Label lblMayuscula;
    }
}