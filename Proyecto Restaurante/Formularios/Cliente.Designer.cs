namespace Formularios
{
    partial class Cliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtIdentidad = new TextBox();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtFechaNacimiento = new TextBox();
            txtCorreo = new TextBox();
            txtTelefono = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 43);
            label1.Name = "label1";
            label1.Size = new Size(88, 25);
            label1.TabIndex = 0;
            label1.Text = "Identidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 97);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 140);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 194);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 3;
            label4.Text = "Fecha Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(95, 251);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 4;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 297);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 5;
            label6.Text = "Telefono";
            label6.Click += label6_Click;
            // 
            // txtIdentidad
            // 
            txtIdentidad.Location = new Point(284, 43);
            txtIdentidad.Name = "txtIdentidad";
            txtIdentidad.Size = new Size(150, 31);
            txtIdentidad.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(284, 97);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(284, 137);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(150, 31);
            txtDireccion.TabIndex = 8;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(284, 188);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(150, 31);
            txtFechaNacimiento.TabIndex = 9;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(284, 248);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(150, 31);
            txtCorreo.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(284, 294);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(150, 31);
            txtTelefono.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(174, 376);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "Insertar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(344, 376);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(503, 376);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 14;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 458);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtTelefono);
            Controls.Add(txtCorreo);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(txtDireccion);
            Controls.Add(txtNombre);
            Controls.Add(txtIdentidad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Cliente";
            Text = "Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtIdentidad;
        private TextBox txtNombre;
        private TextBox txtDireccion;
        private TextBox txtFechaNacimiento;
        private TextBox txtCorreo;
        private TextBox txtTelefono;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}