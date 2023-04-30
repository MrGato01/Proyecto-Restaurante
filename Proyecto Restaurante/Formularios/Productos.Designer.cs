namespace Formularios
{
    partial class Productos
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
            txtCodigoProducto = new TextBox();
            txtTipoProducto = new TextBox();
            txtNombre = new TextBox();
            txtExistencia = new TextBox();
            txtFechaVencimiento = new TextBox();
            txtFoto = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 70);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 0;
            label1.Text = "Codigo de producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 126);
            label2.Name = "label2";
            label2.Size = new Size(151, 25);
            label2.TabIndex = 1;
            label2.Text = "Tipo de producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 172);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 229);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 3;
            label4.Text = "Exitsencia";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 293);
            label5.Name = "label5";
            label5.Size = new Size(183, 25);
            label5.TabIndex = 4;
            label5.Text = "Fecha de vencimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 357);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 5;
            label6.Text = "Foto";
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(307, 70);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(150, 31);
            txtCodigoProducto.TabIndex = 6;
            // 
            // txtTipoProducto
            // 
            txtTipoProducto.Location = new Point(307, 126);
            txtTipoProducto.Name = "txtTipoProducto";
            txtTipoProducto.Size = new Size(150, 31);
            txtTipoProducto.TabIndex = 7;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(307, 190);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(150, 31);
            txtNombre.TabIndex = 8;
            // 
            // txtExistencia
            // 
            txtExistencia.Location = new Point(307, 240);
            txtExistencia.Name = "txtExistencia";
            txtExistencia.Size = new Size(150, 31);
            txtExistencia.TabIndex = 9;
            // 
            // txtFechaVencimiento
            // 
            txtFechaVencimiento.Location = new Point(307, 293);
            txtFechaVencimiento.Name = "txtFechaVencimiento";
            txtFechaVencimiento.Size = new Size(150, 31);
            txtFechaVencimiento.TabIndex = 10;
            // 
            // txtFoto
            // 
            txtFoto.Location = new Point(307, 354);
            txtFoto.Name = "txtFoto";
            txtFoto.Size = new Size(150, 31);
            txtFoto.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(177, 451);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 12;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(376, 450);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 13;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(576, 451);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 14;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 533);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtFoto);
            Controls.Add(txtFechaVencimiento);
            Controls.Add(txtExistencia);
            Controls.Add(txtNombre);
            Controls.Add(txtTipoProducto);
            Controls.Add(txtCodigoProducto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Productos";
            Text = "Productos";
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
        private TextBox txtCodigoProducto;
        private TextBox txtTipoProducto;
        private TextBox txtNombre;
        private TextBox txtExistencia;
        private TextBox txtFechaVencimiento;
        private TextBox txtFoto;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}