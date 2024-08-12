namespace AnalsisNumerico.Unidades.Unidad1.Metodos
{
    partial class Biseccion
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox_funcion = new TextBox();
            label2 = new Label();
            textBox_iteraciones = new TextBox();
            label3 = new Label();
            textBox_tolerancia = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox_li = new TextBox();
            textBox_ld = new TextBox();
            button_Calcular = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            label_salida_iteraciones = new Label();
            label_err = new Label();
            label_salida_err = new Label();
            label_solucion = new Label();
            label_salida_solucion = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_Calcular);
            groupBox1.Controls.Add(textBox_ld);
            groupBox1.Controls.Add(textBox_li);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox_tolerancia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox_iteraciones);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox_funcion);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 206);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 40);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "Función = ";
            // 
            // textBox_funcion
            // 
            textBox_funcion.Location = new Point(118, 37);
            textBox_funcion.Name = "textBox_funcion";
            textBox_funcion.Size = new Size(186, 27);
            textBox_funcion.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 89);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "Iteraciones = ";
            // 
            // textBox_iteraciones
            // 
            textBox_iteraciones.Location = new Point(118, 89);
            textBox_iteraciones.Name = "textBox_iteraciones";
            textBox_iteraciones.Size = new Size(186, 27);
            textBox_iteraciones.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 147);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 4;
            label3.Text = "Tolerancia = ";
            // 
            // textBox_tolerancia
            // 
            textBox_tolerancia.Location = new Point(118, 147);
            textBox_tolerancia.Name = "textBox_tolerancia";
            textBox_tolerancia.Size = new Size(186, 27);
            textBox_tolerancia.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(399, 40);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 6;
            label4.Text = "Límite Izquierdo = ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(399, 96);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 7;
            label5.Text = "Límite Derecho = ";
            // 
            // textBox_li
            // 
            textBox_li.Location = new Point(540, 37);
            textBox_li.Name = "textBox_li";
            textBox_li.Size = new Size(94, 27);
            textBox_li.TabIndex = 8;
            // 
            // textBox_ld
            // 
            textBox_ld.Location = new Point(540, 93);
            textBox_ld.Name = "textBox_ld";
            textBox_ld.Size = new Size(94, 27);
            textBox_ld.TabIndex = 9;
            // 
            // button_Calcular
            // 
            button_Calcular.Location = new Point(540, 160);
            button_Calcular.Name = "button_Calcular";
            button_Calcular.Size = new Size(94, 29);
            button_Calcular.TabIndex = 10;
            button_Calcular.Text = "Calcular";
            button_Calcular.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label_salida_solucion);
            groupBox2.Controls.Add(label_solucion);
            groupBox2.Controls.Add(label_salida_err);
            groupBox2.Controls.Add(label_err);
            groupBox2.Controls.Add(label_salida_iteraciones);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(14, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(774, 204);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 45);
            label6.Name = "label6";
            label6.Size = new Size(171, 20);
            label6.TabIndex = 11;
            label6.Text = "Iteraciones necesarias = ";
            // 
            // label_salida_iteraciones
            // 
            label_salida_iteraciones.AutoSize = true;
            label_salida_iteraciones.Location = new Point(209, 45);
            label_salida_iteraciones.Name = "label_salida_iteraciones";
            label_salida_iteraciones.Size = new Size(15, 20);
            label_salida_iteraciones.TabIndex = 12;
            label_salida_iteraciones.Text = "-";
            // 
            // label_err
            // 
            label_err.AutoSize = true;
            label_err.Location = new Point(32, 96);
            label_err.Name = "label_err";
            label_err.Size = new Size(113, 20);
            label_err.TabIndex = 13;
            label_err.Text = "Error Relativo =";
            // 
            // label_salida_err
            // 
            label_salida_err.AutoSize = true;
            label_salida_err.Location = new Point(151, 96);
            label_salida_err.Name = "label_salida_err";
            label_salida_err.Size = new Size(15, 20);
            label_salida_err.TabIndex = 14;
            label_salida_err.Text = "-";
            // 
            // label_solucion
            // 
            label_solucion.AutoSize = true;
            label_solucion.Location = new Point(32, 154);
            label_solucion.Name = "label_solucion";
            label_solucion.Size = new Size(84, 20);
            label_solucion.TabIndex = 15;
            label_solucion.Text = "Solución = ";
            // 
            // label_salida_solucion
            // 
            label_salida_solucion.AutoSize = true;
            label_salida_solucion.Location = new Point(122, 154);
            label_salida_solucion.Name = "label_salida_solucion";
            label_salida_solucion.Size = new Size(15, 20);
            label_salida_solucion.TabIndex = 16;
            label_salida_solucion.Text = "-";
            // 
            // Biseccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Biseccion";
            Text = "Biseccion";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_Calcular;
        private TextBox textBox_ld;
        private TextBox textBox_li;
        private Label label5;
        private Label label4;
        private TextBox textBox_tolerancia;
        private Label label3;
        private TextBox textBox_iteraciones;
        private Label label2;
        private TextBox textBox_funcion;
        private Label label1;
        private GroupBox groupBox2;
        private Label label_salida_iteraciones;
        private Label label6;
        private Label label_salida_solucion;
        private Label label_solucion;
        private Label label_salida_err;
        private Label label_err;
    }
}