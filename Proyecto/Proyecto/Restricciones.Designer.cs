namespace Proyecto
{
    partial class Restricciones
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
            panel16 = new Panel();
            groupBox2 = new GroupBox();
            chkMayuscula = new CheckBox();
            chkNumero = new CheckBox();
            chkEspecial = new CheckBox();
            chkLongitudMinima = new CheckBox();
            btnGuardar = new Button();
            label16 = new Label();
            panel16.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel16
            // 
            panel16.Anchor = AnchorStyles.None;
            panel16.BackColor = Color.LightCyan;
            panel16.Controls.Add(groupBox2);
            panel16.Controls.Add(btnGuardar);
            panel16.Controls.Add(label16);
            panel16.Location = new Point(166, 46);
            panel16.Margin = new Padding(4, 3, 4, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(600, 427);
            panel16.TabIndex = 109;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkMayuscula);
            groupBox2.Controls.Add(chkNumero);
            groupBox2.Controls.Add(chkEspecial);
            groupBox2.Controls.Add(chkLongitudMinima);
            groupBox2.Location = new Point(178, 129);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 135);
            groupBox2.TabIndex = 109;
            groupBox2.TabStop = false;
            groupBox2.Text = "Restricciones contraseña";
            // 
            // chkMayuscula
            // 
            chkMayuscula.AutoSize = true;
            chkMayuscula.Location = new Point(7, 24);
            chkMayuscula.Margin = new Padding(4, 3, 4, 3);
            chkMayuscula.Name = "chkMayuscula";
            chkMayuscula.Size = new Size(132, 19);
            chkMayuscula.TabIndex = 3;
            chkMayuscula.Text = "Requiere mayúscula";
            chkMayuscula.UseVisualStyleBackColor = true;
            // 
            // chkNumero
            // 
            chkNumero.AutoSize = true;
            chkNumero.Location = new Point(7, 49);
            chkNumero.Margin = new Padding(4, 3, 4, 3);
            chkNumero.Name = "chkNumero";
            chkNumero.Size = new Size(117, 19);
            chkNumero.TabIndex = 4;
            chkNumero.Text = "Requiere número";
            chkNumero.UseVisualStyleBackColor = true;
            // 
            // chkEspecial
            // 
            chkEspecial.AutoSize = true;
            chkEspecial.Location = new Point(7, 74);
            chkEspecial.Margin = new Padding(4, 3, 4, 3);
            chkEspecial.Name = "chkEspecial";
            chkEspecial.Size = new Size(162, 19);
            chkEspecial.TabIndex = 6;
            chkEspecial.Text = "Requiere carácter especial";
            chkEspecial.UseVisualStyleBackColor = true;
            // 
            // chkLongitudMinima
            // 
            chkLongitudMinima.AutoSize = true;
            chkLongitudMinima.Location = new Point(7, 99);
            chkLongitudMinima.Margin = new Padding(4, 3, 4, 3);
            chkLongitudMinima.Name = "chkLongitudMinima";
            chkLongitudMinima.Size = new Size(135, 19);
            chkLongitudMinima.TabIndex = 7;
            chkLongitudMinima.Text = "Longitud minima (8)";
            chkLongitudMinima.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.CornflowerBlue;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.Control;
            btnGuardar.Location = new Point(202, 315);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(197, 31);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar configuracion";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("SimSun", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16.Location = new Point(73, 68);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(466, 21);
            label16.TabIndex = 95;
            label16.Text = "Restricciones a designar en el sistema";
            // 
            // Restricciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(panel16);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Restricciones";
            Text = "Restricciones";
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Panel panel16;
        private GroupBox groupBox2;
        private CheckBox chkMayuscula;
        private CheckBox chkNumero;
        private CheckBox chkEspecial;
        private CheckBox chkLongitudMinima;
        private Button btnGuardar;
        private Label label16;
    }
}