namespace AnalsisNumerico.Unidades.Unidad1.Metodos
{
    partial class NewtonRapshon
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
            groupBox2 = new GroupBox();
            label_salida_NW_Converge = new Label();
            label9 = new Label();
            label_NW_salida_Solu = new Label();
            label_NW_salida_Err = new Label();
            label_NW_salida_Iter = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            button_Calcular_NW = new Button();
            textBox_NW_LI = new TextBox();
            textBox_NW_Tolerancia = new TextBox();
            textBox_NW_Iteraciones = new TextBox();
            textBox_NW_Funcion = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label_salida_NW_Converge);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label_NW_salida_Solu);
            groupBox2.Controls.Add(label_NW_salida_Err);
            groupBox2.Controls.Add(label_NW_salida_Iter);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(12, 236);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 202);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Salida";
            // 
            // label_salida_NW_Converge
            // 
            label_salida_NW_Converge.AutoSize = true;
            label_salida_NW_Converge.Location = new Point(462, 53);
            label_salida_NW_Converge.Name = "label_salida_NW_Converge";
            label_salida_NW_Converge.Size = new Size(15, 20);
            label_salida_NW_Converge.TabIndex = 17;
            label_salida_NW_Converge.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(370, 53);
            label9.Name = "label9";
            label9.Size = new Size(86, 20);
            label9.TabIndex = 16;
            label9.Text = "Converge =";
            // 
            // label_NW_salida_Solu
            // 
            label_NW_salida_Solu.AutoSize = true;
            label_NW_salida_Solu.Location = new Point(115, 156);
            label_NW_salida_Solu.Name = "label_NW_salida_Solu";
            label_NW_salida_Solu.Size = new Size(15, 20);
            label_NW_salida_Solu.TabIndex = 15;
            label_NW_salida_Solu.Text = "-";
            // 
            // label_NW_salida_Err
            // 
            label_NW_salida_Err.AutoSize = true;
            label_NW_salida_Err.Location = new Point(151, 106);
            label_NW_salida_Err.Name = "label_NW_salida_Err";
            label_NW_salida_Err.Size = new Size(15, 20);
            label_NW_salida_Err.TabIndex = 14;
            label_NW_salida_Err.Text = "-";
            // 
            // label_NW_salida_Iter
            // 
            label_NW_salida_Iter.AutoSize = true;
            label_NW_salida_Iter.Location = new Point(207, 53);
            label_NW_salida_Iter.Name = "label_NW_salida_Iter";
            label_NW_salida_Iter.Size = new Size(15, 20);
            label_NW_salida_Iter.TabIndex = 13;
            label_NW_salida_Iter.Text = "-";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(34, 154);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 12;
            label8.Text = "Solución =";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 106);
            label7.Name = "label7";
            label7.Size = new Size(113, 20);
            label7.TabIndex = 11;
            label7.Text = "Error Relativo =";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 53);
            label6.Name = "label6";
            label6.Size = new Size(167, 20);
            label6.TabIndex = 10;
            label6.Text = "Iteraciones necesarias =";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button_Calcular_NW);
            groupBox1.Controls.Add(textBox_NW_LI);
            groupBox1.Controls.Add(textBox_NW_Tolerancia);
            groupBox1.Controls.Add(textBox_NW_Iteraciones);
            groupBox1.Controls.Add(textBox_NW_Funcion);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 212);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // button_Calcular_NW
            // 
            button_Calcular_NW.Location = new Point(565, 160);
            button_Calcular_NW.Name = "button_Calcular_NW";
            button_Calcular_NW.Size = new Size(108, 29);
            button_Calcular_NW.TabIndex = 10;
            button_Calcular_NW.Text = "Calcular";
            button_Calcular_NW.UseVisualStyleBackColor = true;
            button_Calcular_NW.Click += button_Calcular_NW_Click;
            // 
            // textBox_NW_LI
            // 
            textBox_NW_LI.Location = new Point(570, 37);
            textBox_NW_LI.Name = "textBox_NW_LI";
            textBox_NW_LI.Size = new Size(103, 27);
            textBox_NW_LI.TabIndex = 8;
            // 
            // textBox_NW_Tolerancia
            // 
            textBox_NW_Tolerancia.Location = new Point(118, 147);
            textBox_NW_Tolerancia.Name = "textBox_NW_Tolerancia";
            textBox_NW_Tolerancia.Size = new Size(102, 27);
            textBox_NW_Tolerancia.TabIndex = 7;
            // 
            // textBox_NW_Iteraciones
            // 
            textBox_NW_Iteraciones.Location = new Point(122, 90);
            textBox_NW_Iteraciones.Name = "textBox_NW_Iteraciones";
            textBox_NW_Iteraciones.Size = new Size(98, 27);
            textBox_NW_Iteraciones.TabIndex = 6;
            // 
            // textBox_NW_Funcion
            // 
            textBox_NW_Funcion.Location = new Point(101, 37);
            textBox_NW_Funcion.Name = "textBox_NW_Funcion";
            textBox_NW_Funcion.Size = new Size(177, 27);
            textBox_NW_Funcion.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(433, 40);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 3;
            label4.Text = "Límite Izquierdo =";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 147);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 2;
            label3.Text = "Tolerancia =";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 93);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Iteraciones =";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Función =";
            // 
            // NewtonRapshon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "NewtonRapshon";
            Text = "NewtonRapshon";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label_salida_NW_Converge;
        private Label label9;
        private Label label_NW_salida_Solu;
        private Label label_NW_salida_Err;
        private Label label_NW_salida_Iter;
        private Label label8;
        private Label label7;
        private Label label6;
        private GroupBox groupBox1;
        private Button button_Calcular_NW;
        private TextBox textBox_NW_LI;
        private TextBox textBox_NW_Tolerancia;
        private TextBox textBox_NW_Iteraciones;
        private TextBox textBox_NW_Funcion;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}