namespace Proyecto
{
    partial class Permisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permisos));
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button1 = new Button();
            panel16 = new Panel();
            button2 = new Button();
            button6 = new Button();
            btnBuscarUsuario = new Button();
            label7 = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button4 = new Button();
            btnClose = new Button();
            label5 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label16 = new Label();
            panel16.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(86, 65);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(175, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Modulo cambiar contraseña";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(86, 107);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(220, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Modulo cambiar pregunta seguridad";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(86, 156);
            checkBox3.Margin = new Padding(4, 3, 4, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(137, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Modulo restricciones";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(86, 202);
            checkBox4.Margin = new Padding(4, 3, 4, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(114, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Modulo reportes";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(777, 479);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(142, 27);
            button1.TabIndex = 7;
            button1.Text = "Guardar cambios";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            panel16.Anchor = AnchorStyles.None;
            panel16.BackColor = Color.LightCyan;
            panel16.Controls.Add(button2);
            panel16.Controls.Add(button6);
            panel16.Controls.Add(btnBuscarUsuario);
            panel16.Controls.Add(label7);
            panel16.Controls.Add(label6);
            panel16.Controls.Add(textBox3);
            panel16.Controls.Add(textBox2);
            panel16.Controls.Add(button4);
            panel16.Controls.Add(btnClose);
            panel16.Controls.Add(label5);
            panel16.Controls.Add(panel3);
            panel16.Controls.Add(label16);
            panel16.Location = new Point(250, 127);
            panel16.Margin = new Padding(4, 3, 4, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(750, 427);
            panel16.TabIndex = 109;
            // 
            // button2
            // 
            button2.BackColor = Color.CornflowerBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(158, 89);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 123;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.CornflowerBlue;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = SystemColors.Control;
            button6.Location = new Point(64, 287);
            button6.Margin = new Padding(4, 3, 4, 3);
            button6.Name = "button6";
            button6.Size = new Size(213, 61);
            button6.TabIndex = 122;
            button6.Text = "Guardar cambios";
            button6.UseVisualStyleBackColor = false;
            // 
            // btnBuscarUsuario
            // 
            btnBuscarUsuario.BackColor = Color.CornflowerBlue;
            btnBuscarUsuario.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscarUsuario.FlatStyle = FlatStyle.Flat;
            btnBuscarUsuario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarUsuario.ForeColor = Color.Honeydew;
            btnBuscarUsuario.Image = (Image)resources.GetObject("btnBuscarUsuario.Image");
            btnBuscarUsuario.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscarUsuario.Location = new Point(162, 214);
            btnBuscarUsuario.Name = "btnBuscarUsuario";
            btnBuscarUsuario.Size = new Size(115, 54);
            btnBuscarUsuario.TabIndex = 121;
            btnBuscarUsuario.Text = "Buscar";
            btnBuscarUsuario.TextAlign = ContentAlignment.MiddleRight;
            btnBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(64, 163);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(159, 19);
            label7.TabIndex = 120;
            label7.Text = "Nombre completo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SimSun", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(64, 115);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 19);
            label6.TabIndex = 119;
            label6.Text = "Usuario";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(64, 185);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(213, 23);
            textBox3.TabIndex = 118;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(64, 137);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(169, 23);
            textBox2.TabIndex = 117;
            // 
            // button4
            // 
            button4.BackColor = Color.CornflowerBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(64, 89);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 115;
            button4.Text = "Nuevo";
            button4.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = SystemColors.ControlText;
            btnClose.Location = new Point(240, 132);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(37, 31);
            btnClose.TabIndex = 114;
            btnClose.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SimSun", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(64, 43);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(236, 27);
            label5.TabIndex = 112;
            label5.Text = "Conceder permiso";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.SkyBlue;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(checkBox1);
            panel3.Controls.Add(checkBox2);
            panel3.Controls.Add(checkBox3);
            panel3.Controls.Add(checkBox4);
            panel3.Location = new Point(367, 67);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(348, 321);
            panel3.TabIndex = 110;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(33, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(297, 27);
            label4.TabIndex = 111;
            label4.Text = "Permisos a designar";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(704, 142);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 149);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 48;
            pictureBox1.TabStop = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("SimSun", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16.Location = new Point(6, 3);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(427, 19);
            label16.TabIndex = 95;
            label16.Text = "Restricciones a designar en el sistema";
            // 
            // Permisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 684);
            Controls.Add(panel16);
            Controls.Add(button1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Permisos";
            Text = "Permisos";
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.Button button1;
        private Panel panel16;
        private Label label16;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label7;
        private Label label6;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button4;
        private Button btnClose;
        private Button btnBuscarUsuario;
        private Button button6;
        private Button button2;
    }
}