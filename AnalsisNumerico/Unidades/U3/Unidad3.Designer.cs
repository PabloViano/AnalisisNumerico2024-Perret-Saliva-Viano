
namespace AnalsisNumerico.Unidades.U3
{
    partial class Unidad3
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
            groupBoxEntrada = new GroupBox();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            btnBorrarTodos = new Button();
            btnBorrarUltimo = new Button();
            btnCalcular = new Button();
            lblPuntosIngresados = new Label();
            btnCargar = new Button();
            lblMetodos = new Label();
            txtBoxTolerancia = new TextBox();
            lblTolerancia = new Label();
            txtBoxX = new TextBox();
            lblPuntos = new Label();
            label1 = new Label();
            label2 = new Label();
            groupBoxSalida = new GroupBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBoxGrafico = new GroupBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            groupBoxEntrada.SuspendLayout();
            groupBoxSalida.SuspendLayout();
            groupBoxGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxEntrada
            // 
            groupBoxEntrada.Controls.Add(textBox1);
            groupBoxEntrada.Controls.Add(richTextBox1);
            groupBoxEntrada.Controls.Add(comboBox1);
            groupBoxEntrada.Controls.Add(btnBorrarTodos);
            groupBoxEntrada.Controls.Add(btnBorrarUltimo);
            groupBoxEntrada.Controls.Add(btnCalcular);
            groupBoxEntrada.Controls.Add(lblPuntosIngresados);
            groupBoxEntrada.Controls.Add(btnCargar);
            groupBoxEntrada.Controls.Add(lblMetodos);
            groupBoxEntrada.Controls.Add(txtBoxTolerancia);
            groupBoxEntrada.Controls.Add(lblTolerancia);
            groupBoxEntrada.Controls.Add(txtBoxX);
            groupBoxEntrada.Controls.Add(lblPuntos);
            groupBoxEntrada.Location = new Point(12, 61);
            groupBoxEntrada.Name = "groupBoxEntrada";
            groupBoxEntrada.Size = new Size(403, 405);
            groupBoxEntrada.TabIndex = 0;
            groupBoxEntrada.TabStop = false;
            groupBoxEntrada.Text = "Datos de Entrada";
            groupBoxEntrada.Enter += groupBoxEntrada_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(50, 23);
            textBox1.TabIndex = 13;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.Menu;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Location = new Point(136, 161);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(135, 220);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(136, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(89, 23);
            comboBox1.TabIndex = 11;
            // 
            // btnBorrarTodos
            // 
            btnBorrarTodos.ForeColor = SystemColors.HotTrack;
            btnBorrarTodos.Location = new Point(286, 200);
            btnBorrarTodos.Name = "btnBorrarTodos";
            btnBorrarTodos.Size = new Size(110, 24);
            btnBorrarTodos.TabIndex = 10;
            btnBorrarTodos.Text = "BORRAR TODOS";
            btnBorrarTodos.UseVisualStyleBackColor = true;
            // 
            // btnBorrarUltimo
            // 
            btnBorrarUltimo.ForeColor = SystemColors.HotTrack;
            btnBorrarUltimo.Location = new Point(286, 161);
            btnBorrarUltimo.Name = "btnBorrarUltimo";
            btnBorrarUltimo.Size = new Size(110, 24);
            btnBorrarUltimo.TabIndex = 9;
            btnBorrarUltimo.Text = "BORRAR ÚLTIMO";
            btnBorrarUltimo.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightSkyBlue;
            btnCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(286, 89);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(96, 40);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // lblPuntosIngresados
            // 
            lblPuntosIngresados.AutoSize = true;
            lblPuntosIngresados.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntosIngresados.Location = new Point(12, 161);
            lblPuntosIngresados.Name = "lblPuntosIngresados";
            lblPuntosIngresados.Size = new Size(119, 17);
            lblPuntosIngresados.TabIndex = 6;
            lblPuntosIngresados.Text = "Puntos Ingresados:";
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.LightSkyBlue;
            btnCargar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.ForeColor = Color.White;
            btnCargar.Location = new Point(286, 23);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(96, 30);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "CARGAR";
            btnCargar.UseVisualStyleBackColor = false;
            // 
            // lblMetodos
            // 
            lblMetodos.AutoSize = true;
            lblMetodos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMetodos.Location = new Point(12, 109);
            lblMetodos.Name = "lblMetodos";
            lblMetodos.Size = new Size(114, 17);
            lblMetodos.TabIndex = 5;
            lblMetodos.Text = "Métodos a utilizar";
            // 
            // txtBoxTolerancia
            // 
            txtBoxTolerancia.Location = new Point(136, 67);
            txtBoxTolerancia.Name = "txtBoxTolerancia";
            txtBoxTolerancia.Size = new Size(89, 23);
            txtBoxTolerancia.TabIndex = 4;
            // 
            // lblTolerancia
            // 
            lblTolerancia.AutoSize = true;
            lblTolerancia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTolerancia.Location = new Point(59, 68);
            lblTolerancia.Name = "lblTolerancia";
            lblTolerancia.Size = new Size(67, 17);
            lblTolerancia.TabIndex = 3;
            lblTolerancia.Text = "Tolerancia";
            // 
            // txtBoxX
            // 
            txtBoxX.Location = new Point(136, 23);
            txtBoxX.Name = "txtBoxX";
            txtBoxX.Size = new Size(50, 23);
            txtBoxX.TabIndex = 1;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntos.Location = new Point(6, 27);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(123, 17);
            lblPuntos.TabIndex = 0;
            lblPuntos.Text = "Ingresar Punto (X,Y)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 9);
            label1.Name = "label1";
            label1.Size = new Size(422, 39);
            label1.TabIndex = 1;
            label1.Text = "UNIDAD 3 - REGRESIÓN LINEAL";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(708, 478);
            label2.Name = "label2";
            label2.Size = new Size(200, 21);
            label2.TabIndex = 2;
            label2.Text = "SALIVA - PERRET - VIANO";
            // 
            // groupBoxSalida
            // 
            groupBoxSalida.Controls.Add(label5);
            groupBoxSalida.Controls.Add(label4);
            groupBoxSalida.Controls.Add(label3);
            groupBoxSalida.Location = new Point(430, 61);
            groupBoxSalida.Name = "groupBoxSalida";
            groupBoxSalida.Size = new Size(478, 112);
            groupBoxSalida.TabIndex = 3;
            groupBoxSalida.TabStop = false;
            groupBoxSalida.Text = "Datos de Salida";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 75);
            label5.Name = "label5";
            label5.Size = new Size(110, 17);
            label5.TabIndex = 2;
            label5.Text = "Efectividad Ajuste";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 52);
            label4.Name = "label4";
            label4.Size = new Size(92, 17);
            label4.TabIndex = 1;
            label4.Text = "Correlación (r)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 28);
            label3.Name = "label3";
            label3.Size = new Size(110, 17);
            label3.TabIndex = 0;
            label3.Text = "Función Obtenida";
            // 
            // groupBoxGrafico
            // 
            groupBoxGrafico.Controls.Add(label6);
            groupBoxGrafico.Location = new Point(431, 179);
            groupBoxGrafico.Name = "groupBoxGrafico";
            groupBoxGrafico.Size = new Size(477, 286);
            groupBoxGrafico.TabIndex = 4;
            groupBoxGrafico.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 5;
            label6.Text = "GRÁFICO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoUcse;
            pictureBox1.Location = new Point(821, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Unidad3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(920, 508);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxGrafico);
            Controls.Add(groupBoxSalida);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBoxEntrada);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Unidad3";
            Text = "Unidad3";
            Load += Unidad3_Load;
            groupBoxEntrada.ResumeLayout(false);
            groupBoxEntrada.PerformLayout();
            groupBoxSalida.ResumeLayout(false);
            groupBoxSalida.PerformLayout();
            groupBoxGrafico.ResumeLayout(false);
            groupBoxGrafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxEntrada;
        private Label lblPuntosIngresados;
        private Label lblMetodos;
        private TextBox txtBoxTolerancia;
        private Label lblTolerancia;
        private TextBox txtBoxX;
        private Label lblPuntos;
        private Button btnBorrarTodos;
        private Button btnBorrarUltimo;
        private Button btnCalcular;
        private Button btnCargar;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private GroupBox groupBoxSalida;
        private GroupBox groupBoxGrafico;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private PictureBox pictureBox1;
    }
}