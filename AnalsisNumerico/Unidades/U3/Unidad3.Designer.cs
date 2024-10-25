
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
            comboBoxGrado = new ComboBox();
            lblGrado = new Label();
            txtBoxY = new TextBox();
            panelCargaDePuntos = new RichTextBox();
            comboBoxMetodo = new ComboBox();
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
            txtBoxEfectividad = new Label();
            txtBoxCorrelacion = new Label();
            txbFuncion = new TextBox();
            lblEfectividadAjuste = new Label();
            lblCorrelacion = new Label();
            lblFuncionObtenida = new Label();
            groupBoxGrafico = new GroupBox();
            lblGrafico = new Label();
            pictureBox1 = new PictureBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            groupBoxEntrada.SuspendLayout();
            groupBoxSalida.SuspendLayout();
            groupBoxGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // groupBoxEntrada
            // 
            groupBoxEntrada.Controls.Add(comboBoxGrado);
            groupBoxEntrada.Controls.Add(lblGrado);
            groupBoxEntrada.Controls.Add(txtBoxY);
            groupBoxEntrada.Controls.Add(panelCargaDePuntos);
            groupBoxEntrada.Controls.Add(comboBoxMetodo);
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
            groupBoxEntrada.Size = new Size(403, 532);
            groupBoxEntrada.TabIndex = 0;
            groupBoxEntrada.TabStop = false;
            groupBoxEntrada.Text = "Datos de Entrada";
            groupBoxEntrada.Enter += groupBoxEntrada_Enter;
            // 
            // comboBoxGrado
            // 
            comboBoxGrado.FormattingEnabled = true;
            comboBoxGrado.Location = new Point(286, 69);
            comboBoxGrado.Name = "comboBoxGrado";
            comboBoxGrado.Size = new Size(89, 23);
            comboBoxGrado.TabIndex = 15;
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrado.Location = new Point(216, 70);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(45, 17);
            lblGrado.TabIndex = 14;
            lblGrado.Text = "Grado";
            // 
            // txtBoxY
            // 
            txtBoxY.Location = new Point(192, 23);
            txtBoxY.Name = "txtBoxY";
            txtBoxY.Size = new Size(50, 23);
            txtBoxY.TabIndex = 13;
            // 
            // panelCargaDePuntos
            // 
            panelCargaDePuntos.BackColor = SystemColors.Menu;
            panelCargaDePuntos.BorderStyle = BorderStyle.None;
            panelCargaDePuntos.Location = new Point(136, 161);
            panelCargaDePuntos.Name = "panelCargaDePuntos";
            panelCargaDePuntos.Size = new Size(135, 220);
            panelCargaDePuntos.TabIndex = 12;
            panelCargaDePuntos.Text = "";
            // 
            // comboBoxMetodo
            // 
            comboBoxMetodo.FormattingEnabled = true;
            comboBoxMetodo.Location = new Point(136, 106);
            comboBoxMetodo.Name = "comboBoxMetodo";
            comboBoxMetodo.Size = new Size(135, 23);
            comboBoxMetodo.TabIndex = 11;
            comboBoxMetodo.SelectedIndexChanged += comboBoxMetodo_SelectedIndexChanged;
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
            btnBorrarTodos.Click += btnBorrarTodos_Click;
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
            btnBorrarUltimo.Click += btnBorrarUltimo_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightSkyBlue;
            btnCalcular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.White;
            btnCalcular.Location = new Point(286, 106);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(110, 40);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
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
            btnCargar.Location = new Point(286, 21);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(96, 30);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "CARGAR";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
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
            txtBoxTolerancia.Location = new Point(97, 66);
            txtBoxTolerancia.Name = "txtBoxTolerancia";
            txtBoxTolerancia.Size = new Size(89, 23);
            txtBoxTolerancia.TabIndex = 4;
            // 
            // lblTolerancia
            // 
            lblTolerancia.AutoSize = true;
            lblTolerancia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTolerancia.Location = new Point(12, 68);
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
            label2.Location = new Point(919, 572);
            label2.Name = "label2";
            label2.Size = new Size(200, 21);
            label2.TabIndex = 2;
            label2.Text = "SALIVA - PERRET - VIANO";
            // 
            // groupBoxSalida
            // 
            groupBoxSalida.Controls.Add(txtBoxEfectividad);
            groupBoxSalida.Controls.Add(txtBoxCorrelacion);
            groupBoxSalida.Controls.Add(txbFuncion);
            groupBoxSalida.Controls.Add(lblEfectividadAjuste);
            groupBoxSalida.Controls.Add(lblCorrelacion);
            groupBoxSalida.Controls.Add(lblFuncionObtenida);
            groupBoxSalida.Location = new Point(430, 61);
            groupBoxSalida.Name = "groupBoxSalida";
            groupBoxSalida.Size = new Size(478, 112);
            groupBoxSalida.TabIndex = 3;
            groupBoxSalida.TabStop = false;
            groupBoxSalida.Text = "Datos de Salida";
            // 
            // txtBoxEfectividad
            // 
            txtBoxEfectividad.AutoSize = true;
            txtBoxEfectividad.Location = new Point(143, 91);
            txtBoxEfectividad.Name = "txtBoxEfectividad";
            txtBoxEfectividad.Size = new Size(16, 15);
            txtBoxEfectividad.TabIndex = 12;
            txtBoxEfectividad.Text = "...";
            // 
            // txtBoxCorrelacion
            // 
            txtBoxCorrelacion.AutoSize = true;
            txtBoxCorrelacion.Location = new Point(143, 70);
            txtBoxCorrelacion.Name = "txtBoxCorrelacion";
            txtBoxCorrelacion.Size = new Size(16, 15);
            txtBoxCorrelacion.TabIndex = 6;
            txtBoxCorrelacion.Text = "...";
            // 
            // txbFuncion
            // 
            txbFuncion.Location = new Point(143, 23);
            txbFuncion.Multiline = true;
            txbFuncion.Name = "txbFuncion";
            txbFuncion.ReadOnly = true;
            txbFuncion.Size = new Size(195, 41);
            txbFuncion.TabIndex = 11;
            // 
            // lblEfectividadAjuste
            // 
            lblEfectividadAjuste.AutoSize = true;
            lblEfectividadAjuste.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEfectividadAjuste.Location = new Point(15, 89);
            lblEfectividadAjuste.Name = "lblEfectividadAjuste";
            lblEfectividadAjuste.Size = new Size(110, 17);
            lblEfectividadAjuste.TabIndex = 2;
            lblEfectividadAjuste.Text = "Efectividad Ajuste";
            // 
            // lblCorrelacion
            // 
            lblCorrelacion.AutoSize = true;
            lblCorrelacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorrelacion.Location = new Point(15, 67);
            lblCorrelacion.Name = "lblCorrelacion";
            lblCorrelacion.Size = new Size(92, 17);
            lblCorrelacion.TabIndex = 1;
            lblCorrelacion.Text = "Correlación (r)";
            // 
            // lblFuncionObtenida
            // 
            lblFuncionObtenida.AutoSize = true;
            lblFuncionObtenida.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncionObtenida.Location = new Point(15, 27);
            lblFuncionObtenida.Name = "lblFuncionObtenida";
            lblFuncionObtenida.Size = new Size(110, 17);
            lblFuncionObtenida.TabIndex = 0;
            lblFuncionObtenida.Text = "Función Obtenida";
            // 
            // groupBoxGrafico
            // 
            groupBoxGrafico.Controls.Add(webView21);
            groupBoxGrafico.Controls.Add(lblGrafico);
            groupBoxGrafico.Location = new Point(431, 179);
            groupBoxGrafico.Name = "groupBoxGrafico";
            groupBoxGrafico.Size = new Size(688, 390);
            groupBoxGrafico.TabIndex = 4;
            groupBoxGrafico.TabStop = false;
            // 
            // lblGrafico
            // 
            lblGrafico.AutoSize = true;
            lblGrafico.FlatStyle = FlatStyle.Popup;
            lblGrafico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGrafico.Location = new Point(6, 19);
            lblGrafico.Name = "lblGrafico";
            lblGrafico.Size = new Size(77, 21);
            lblGrafico.TabIndex = 5;
            lblGrafico.Text = "GRÁFICO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoUcse;
            pictureBox1.Location = new Point(855, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(8, 47);
            webView21.Name = "webView21";
            webView21.Size = new Size(674, 337);
            webView21.TabIndex = 6;
            webView21.ZoomFactor = 1D;
            // 
            // Unidad3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1131, 605);
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
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
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
        private ComboBox comboBoxMetodo;
        private RichTextBox panelCargaDePuntos;
        private TextBox txtBoxY;
        private GroupBox groupBoxSalida;
        private GroupBox groupBoxGrafico;
        private Label lblEfectividadAjuste;
        private Label lblCorrelacion;
        private Label lblFuncionObtenida;
        private Label lblGrafico;
        private PictureBox pictureBox1;
        private TextBox txbFuncion;
        private Label txtBoxEfectividad;
        private Label txtBoxCorrelacion;
        private Label lblGrado;
        private ComboBox comboBoxGrado;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
    }
}