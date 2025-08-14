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
            button1 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            checkBox14 = new CheckBox();
            panel16 = new Panel();
            groupBox2 = new GroupBox();
            label16 = new Label();
            groupBox1.SuspendLayout();
            panel16.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(37, 334);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(238, 61);
            button1.TabIndex = 2;
            button1.Text = "Guardar configuracion";
            button1.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(7, 22);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(135, 19);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Longitud minima (8)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(7, 49);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(143, 19);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Longitud maxima (20)";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(7, 124);
            checkBox3.Margin = new Padding(4, 3, 4, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(132, 19);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Requiere mayuscula";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(7, 74);
            checkBox4.Margin = new Padding(4, 3, 4, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(226, 19);
            checkBox4.TabIndex = 6;
            checkBox4.Text = "Combinacion mayusculas minusculas";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(7, 99);
            checkBox5.Margin = new Padding(4, 3, 4, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(168, 19);
            checkBox5.TabIndex = 7;
            checkBox5.Text = "Contenga numeros y letras";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(7, 174);
            checkBox7.Margin = new Padding(4, 3, 4, 3);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(183, 19);
            checkBox7.TabIndex = 9;
            checkBox7.Text = "No contener datos personales";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(7, 224);
            checkBox8.Margin = new Padding(4, 3, 4, 3);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(145, 19);
            checkBox8.TabIndex = 10;
            checkBox8.Text = "No repetir contraseñas";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(7, 199);
            checkBox9.Margin = new Padding(4, 3, 4, 3);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(125, 19);
            checkBox9.TabIndex = 11;
            checkBox9.Text = "Expira cada 30 dias";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(7, 249);
            checkBox10.Margin = new Padding(4, 3, 4, 3);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(158, 19);
            checkBox10.TabIndex = 12;
            checkBox10.Text = "Verificacion de dos pasos";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 42);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(270, 15);
            label2.TabIndex = 13;
            label2.Text = "Cantidad de preguntas a responder por el usuario:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(309, 65);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(233, 115);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cantidad de preguntas a responder por el usuario:";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(0, 88);
            radioButton3.Margin = new Padding(4, 3, 4, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(31, 19);
            radioButton3.TabIndex = 21;
            radioButton3.TabStop = true;
            radioButton3.Text = "5";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(0, 35);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(31, 19);
            radioButton1.TabIndex = 19;
            radioButton1.TabStop = true;
            radioButton1.Text = "2";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(0, 61);
            radioButton2.Margin = new Padding(4, 3, 4, 3);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(31, 19);
            radioButton2.TabIndex = 20;
            radioButton2.TabStop = true;
            radioButton2.Text = "3";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(7, 149);
            checkBox14.Margin = new Padding(4, 3, 4, 3);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(162, 19);
            checkBox14.TabIndex = 18;
            checkBox14.Text = "Requiere caracter especial";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // panel16
            // 
            panel16.Anchor = AnchorStyles.None;
            panel16.BackColor = Color.LightCyan;
            panel16.Controls.Add(groupBox2);
            panel16.Controls.Add(button1);
            panel16.Controls.Add(label16);
            panel16.Controls.Add(groupBox1);
            panel16.Controls.Add(label2);
            panel16.Location = new Point(191, 45);
            panel16.Margin = new Padding(4, 3, 4, 3);
            panel16.Name = "panel16";
            panel16.Size = new Size(600, 427);
            panel16.TabIndex = 108;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(checkBox14);
            groupBox2.Controls.Add(checkBox4);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox10);
            groupBox2.Controls.Add(checkBox5);
            groupBox2.Controls.Add(checkBox8);
            groupBox2.Controls.Add(checkBox9);
            groupBox2.Controls.Add(checkBox7);
            groupBox2.Location = new Point(37, 37);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(238, 291);
            groupBox2.TabIndex = 109;
            groupBox2.TabStop = false;
            groupBox2.Text = "Restricciones contraseña";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("SimSun", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label16.Location = new Point(6, 3);
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
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private Panel panel16;
        private Label label16;
        private GroupBox groupBox2;
    }
}