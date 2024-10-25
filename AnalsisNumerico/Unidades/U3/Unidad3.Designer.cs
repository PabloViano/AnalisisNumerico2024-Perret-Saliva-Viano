
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
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            lblGrafico = new Label();
            pictureBox1 = new PictureBox();
            groupBoxEntrada.SuspendLayout();
            groupBoxSalida.SuspendLayout();
            groupBoxGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            groupBoxEntrada.Location = new Point(14, 81);
            groupBoxEntrada.Margin = new Padding(3, 4, 3, 4);
            groupBoxEntrada.Name = "groupBoxEntrada";
            groupBoxEntrada.Padding = new Padding(3, 4, 3, 4);
            groupBoxEntrada.Size = new Size(461, 709);
            groupBoxEntrada.TabIndex = 0;
            groupBoxEntrada.TabStop = false;
            groupBoxEntrada.Text = "Datos de Entrada";
            groupBoxEntrada.Enter += groupBoxEntrada_Enter;
            // 
            // comboBoxGrado
            // 
            comboBoxGrado.FormattingEnabled = true;
            comboBoxGrado.Location = new Point(327, 92);
            comboBoxGrado.Margin = new Padding(3, 4, 3, 4);
            comboBoxGrado.Name = "comboBoxGrado";
            comboBoxGrado.Size = new Size(101, 28);
            comboBoxGrado.TabIndex = 15;
            // 
            // lblGrado
            // 
            lblGrado.AutoSize = true;
            lblGrado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGrado.Location = new Point(247, 93);
            lblGrado.Name = "lblGrado";
            lblGrado.Size = new Size(57, 23);
            lblGrado.TabIndex = 14;
            lblGrado.Text = "Grado";
            // 
            // txtBoxY
            // 
            txtBoxY.Location = new Point(219, 31);
            txtBoxY.Margin = new Padding(3, 4, 3, 4);
            txtBoxY.Name = "txtBoxY";
            txtBoxY.Size = new Size(57, 27);
            txtBoxY.TabIndex = 13;
            // 
            // panelCargaDePuntos
            // 
            panelCargaDePuntos.BackColor = SystemColors.Menu;
            panelCargaDePuntos.BorderStyle = BorderStyle.None;
            panelCargaDePuntos.Location = new Point(155, 215);
            panelCargaDePuntos.Margin = new Padding(3, 4, 3, 4);
            panelCargaDePuntos.Name = "panelCargaDePuntos";
            panelCargaDePuntos.Size = new Size(154, 293);
            panelCargaDePuntos.TabIndex = 12;
            panelCargaDePuntos.Text = "";
            // 
            // comboBoxMetodo
            // 
            comboBoxMetodo.FormattingEnabled = true;
            comboBoxMetodo.Location = new Point(155, 141);
            comboBoxMetodo.Margin = new Padding(3, 4, 3, 4);
            comboBoxMetodo.Name = "comboBoxMetodo";
            comboBoxMetodo.Size = new Size(154, 28);
            comboBoxMetodo.TabIndex = 11;
            comboBoxMetodo.SelectedIndexChanged += comboBoxMetodo_SelectedIndexChanged;
            // 
            // btnBorrarTodos
            // 
            btnBorrarTodos.ForeColor = SystemColors.HotTrack;
            btnBorrarTodos.Location = new Point(327, 267);
            btnBorrarTodos.Margin = new Padding(3, 4, 3, 4);
            btnBorrarTodos.Name = "btnBorrarTodos";
            btnBorrarTodos.Size = new Size(126, 32);
            btnBorrarTodos.TabIndex = 10;
            btnBorrarTodos.Text = "BORRAR TODOS";
            btnBorrarTodos.UseVisualStyleBackColor = true;
            btnBorrarTodos.Click += btnBorrarTodos_Click;
            // 
            // btnBorrarUltimo
            // 
            btnBorrarUltimo.ForeColor = SystemColors.HotTrack;
            btnBorrarUltimo.Location = new Point(327, 215);
            btnBorrarUltimo.Margin = new Padding(3, 4, 3, 4);
            btnBorrarUltimo.Name = "btnBorrarUltimo";
            btnBorrarUltimo.Size = new Size(126, 32);
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
            btnCalcular.Location = new Point(327, 141);
            btnCalcular.Margin = new Padding(3, 4, 3, 4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(126, 53);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblPuntosIngresados
            // 
            lblPuntosIngresados.AutoSize = true;
            lblPuntosIngresados.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntosIngresados.Location = new Point(14, 215);
            lblPuntosIngresados.Name = "lblPuntosIngresados";
            lblPuntosIngresados.Size = new Size(155, 23);
            lblPuntosIngresados.TabIndex = 6;
            lblPuntosIngresados.Text = "Puntos Ingresados:";
            // 
            // btnCargar
            // 
            btnCargar.BackColor = Color.LightSkyBlue;
            btnCargar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCargar.ForeColor = Color.White;
            btnCargar.Location = new Point(327, 28);
            btnCargar.Margin = new Padding(3, 4, 3, 4);
            btnCargar.Name = "btnCargar";
            btnCargar.Size = new Size(110, 40);
            btnCargar.TabIndex = 7;
            btnCargar.Text = "CARGAR";
            btnCargar.UseVisualStyleBackColor = false;
            btnCargar.Click += btnCargar_Click;
            // 
            // lblMetodos
            // 
            lblMetodos.AutoSize = true;
            lblMetodos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMetodos.Location = new Point(14, 145);
            lblMetodos.Name = "lblMetodos";
            lblMetodos.Size = new Size(147, 23);
            lblMetodos.TabIndex = 5;
            lblMetodos.Text = "Métodos a utilizar";
            // 
            // txtBoxTolerancia
            // 
            txtBoxTolerancia.Location = new Point(111, 88);
            txtBoxTolerancia.Margin = new Padding(3, 4, 3, 4);
            txtBoxTolerancia.Name = "txtBoxTolerancia";
            txtBoxTolerancia.Size = new Size(101, 27);
            txtBoxTolerancia.TabIndex = 4;
            // 
            // lblTolerancia
            // 
            lblTolerancia.AutoSize = true;
            lblTolerancia.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTolerancia.Location = new Point(14, 91);
            lblTolerancia.Name = "lblTolerancia";
            lblTolerancia.Size = new Size(86, 23);
            lblTolerancia.TabIndex = 3;
            lblTolerancia.Text = "Tolerancia";
            // 
            // txtBoxX
            // 
            txtBoxX.Location = new Point(155, 31);
            txtBoxX.Margin = new Padding(3, 4, 3, 4);
            txtBoxX.Name = "txtBoxX";
            txtBoxX.Size = new Size(57, 27);
            txtBoxX.TabIndex = 1;
            // 
            // lblPuntos
            // 
            lblPuntos.AutoSize = true;
            lblPuntos.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuntos.Location = new Point(7, 36);
            lblPuntos.Name = "lblPuntos";
            lblPuntos.Size = new Size(161, 23);
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
            label1.Location = new Point(320, 12);
            label1.Name = "label1";
            label1.Size = new Size(529, 48);
            label1.TabIndex = 1;
            label1.Text = "UNIDAD 3 - REGRESIÓN LINEAL";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(1050, 763);
            label2.Name = "label2";
            label2.Size = new Size(257, 28);
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
            groupBoxSalida.Location = new Point(491, 81);
            groupBoxSalida.Margin = new Padding(3, 4, 3, 4);
            groupBoxSalida.Name = "groupBoxSalida";
            groupBoxSalida.Padding = new Padding(3, 4, 3, 4);
            groupBoxSalida.Size = new Size(546, 149);
            groupBoxSalida.TabIndex = 3;
            groupBoxSalida.TabStop = false;
            groupBoxSalida.Text = "Datos de Salida";
            // 
            // txtBoxEfectividad
            // 
            txtBoxEfectividad.AutoSize = true;
            txtBoxEfectividad.Location = new Point(163, 121);
            txtBoxEfectividad.Name = "txtBoxEfectividad";
            txtBoxEfectividad.Size = new Size(18, 20);
            txtBoxEfectividad.TabIndex = 12;
            txtBoxEfectividad.Text = "...";
            // 
            // txtBoxCorrelacion
            // 
            txtBoxCorrelacion.AutoSize = true;
            txtBoxCorrelacion.Location = new Point(163, 93);
            txtBoxCorrelacion.Name = "txtBoxCorrelacion";
            txtBoxCorrelacion.Size = new Size(18, 20);
            txtBoxCorrelacion.TabIndex = 6;
            txtBoxCorrelacion.Text = "...";
            // 
            // txbFuncion
            // 
            txbFuncion.Location = new Point(163, 31);
            txbFuncion.Margin = new Padding(3, 4, 3, 4);
            txbFuncion.Multiline = true;
            txbFuncion.Name = "txbFuncion";
            txbFuncion.ReadOnly = true;
            txbFuncion.Size = new Size(222, 53);
            txbFuncion.TabIndex = 11;
            // 
            // lblEfectividadAjuste
            // 
            lblEfectividadAjuste.AutoSize = true;
            lblEfectividadAjuste.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEfectividadAjuste.Location = new Point(17, 119);
            lblEfectividadAjuste.Name = "lblEfectividadAjuste";
            lblEfectividadAjuste.Size = new Size(144, 23);
            lblEfectividadAjuste.TabIndex = 2;
            lblEfectividadAjuste.Text = "Efectividad Ajuste";
            // 
            // lblCorrelacion
            // 
            lblCorrelacion.AutoSize = true;
            lblCorrelacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorrelacion.Location = new Point(17, 89);
            lblCorrelacion.Name = "lblCorrelacion";
            lblCorrelacion.Size = new Size(118, 23);
            lblCorrelacion.TabIndex = 1;
            lblCorrelacion.Text = "Correlación (r)";
            // 
            // lblFuncionObtenida
            // 
            lblFuncionObtenida.AutoSize = true;
            lblFuncionObtenida.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncionObtenida.Location = new Point(17, 36);
            lblFuncionObtenida.Name = "lblFuncionObtenida";
            lblFuncionObtenida.Size = new Size(146, 23);
            lblFuncionObtenida.TabIndex = 0;
            lblFuncionObtenida.Text = "Función Obtenida";
            // 
            // groupBoxGrafico
            // 
            groupBoxGrafico.Controls.Add(webView21);
            groupBoxGrafico.Controls.Add(lblGrafico);
            groupBoxGrafico.Location = new Point(493, 239);
            groupBoxGrafico.Margin = new Padding(3, 4, 3, 4);
            groupBoxGrafico.Name = "groupBoxGrafico";
            groupBoxGrafico.Padding = new Padding(3, 4, 3, 4);
            groupBoxGrafico.Size = new Size(786, 520);
            groupBoxGrafico.TabIndex = 4;
            groupBoxGrafico.TabStop = false;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(9, 63);
            webView21.Margin = new Padding(3, 4, 3, 4);
            webView21.Name = "webView21";
            webView21.Size = new Size(770, 449);
            webView21.TabIndex = 6;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // lblGrafico
            // 
            lblGrafico.AutoSize = true;
            lblGrafico.FlatStyle = FlatStyle.Popup;
            lblGrafico.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblGrafico.Location = new Point(7, 25);
            lblGrafico.Name = "lblGrafico";
            lblGrafico.Size = new Size(95, 28);
            lblGrafico.TabIndex = 5;
            lblGrafico.Text = "GRÁFICO";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoUcse;
            pictureBox1.Location = new Point(977, 12);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Unidad3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1293, 807);
            Controls.Add(pictureBox1);
            Controls.Add(groupBoxGrafico);
            Controls.Add(groupBoxSalida);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBoxEntrada);
            Name = "Unidad3";
            Text = "Unidad3";
            Load += Unidad3_Load;
            groupBoxEntrada.ResumeLayout(false);
            groupBoxEntrada.PerformLayout();
            groupBoxSalida.ResumeLayout(false);
            groupBoxSalida.PerformLayout();
            groupBoxGrafico.ResumeLayout(false);
            groupBoxGrafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
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