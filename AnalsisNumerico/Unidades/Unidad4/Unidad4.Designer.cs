namespace AnalsisNumerico.Unidades.Unidad4
{
    partial class Unidad4
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
            groupBox1 = new GroupBox();
            button1 = new Button();
            ComboBoxMetodo = new ComboBox();
            txbCantidadSubintervales = new TextBox();
            txbXd = new TextBox();
            txbXi = new TextBox();
            txbFuncion = new TextBox();
            lblMetodo = new Label();
            lblCantidadIntervalos = new Label();
            lblXd = new Label();
            lblXi = new Label();
            lblFuncion = new Label();
            groupBox2 = new GroupBox();
            txbObservacion = new TextBox();
            lblObservación = new Label();
            txbArea = new TextBox();
            lblArea = new Label();
            pictureBox1 = new PictureBox();
            groupBoxGrafico = new GroupBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 16);
            label1.Name = "label1";
            label1.Size = new Size(639, 48);
            label1.TabIndex = 2;
            label1.Text = "UNIDAD 4 - INTEGRACIÓN NUMÉRICA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(825, 633);
            label2.Name = "label2";
            label2.Size = new Size(257, 28);
            label2.TabIndex = 3;
            label2.Text = "SALIVA - PERRET - VIANO";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(ComboBoxMetodo);
            groupBox1.Controls.Add(txbCantidadSubintervales);
            groupBox1.Controls.Add(txbXd);
            groupBox1.Controls.Add(txbXi);
            groupBox1.Controls.Add(txbFuncion);
            groupBox1.Controls.Add(lblMetodo);
            groupBox1.Controls.Add(lblCantidadIntervalos);
            groupBox1.Controls.Add(lblXd);
            groupBox1.Controls.Add(lblXi);
            groupBox1.Controls.Add(lblFuncion);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(24, 96);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(471, 259);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Salida";
            // 
            // button1
            // 
            button1.Location = new Point(319, 209);
            button1.Name = "button1";
            button1.Size = new Size(146, 28);
            button1.TabIndex = 11;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ComboBoxMetodo
            // 
            ComboBoxMetodo.DisplayMember = "dfsd";
            ComboBoxMetodo.FormattingEnabled = true;
            ComboBoxMetodo.Items.AddRange(new object[] { "Trapezoidal Simple", "Trapezoidal Múltiple", "Simpson 1/3 Simple", "Simpson 1/3 Múltiple", "Simpson 3/8" });
            ComboBoxMetodo.Location = new Point(105, 209);
            ComboBoxMetodo.Name = "ComboBoxMetodo";
            ComboBoxMetodo.Size = new Size(185, 28);
            ComboBoxMetodo.TabIndex = 10;
            ComboBoxMetodo.ValueMember = "fdsfds";
            // 
            // txbCantidadSubintervales
            // 
            txbCantidadSubintervales.Location = new Point(227, 153);
            txbCantidadSubintervales.Name = "txbCantidadSubintervales";
            txbCantidadSubintervales.Size = new Size(85, 27);
            txbCantidadSubintervales.TabIndex = 8;
            // 
            // txbXd
            // 
            txbXd.Location = new Point(239, 96);
            txbXd.Name = "txbXd";
            txbXd.Size = new Size(74, 27);
            txbXd.TabIndex = 7;
            // 
            // txbXi
            // 
            txbXi.Location = new Point(83, 96);
            txbXi.Name = "txbXi";
            txbXi.Size = new Size(62, 27);
            txbXi.TabIndex = 6;
            // 
            // txbFuncion
            // 
            txbFuncion.Location = new Point(83, 45);
            txbFuncion.Name = "txbFuncion";
            txbFuncion.Size = new Size(229, 27);
            txbFuncion.TabIndex = 5;
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Segoe UI", 9.75F);
            lblMetodo.Location = new Point(18, 213);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(70, 23);
            lblMetodo.TabIndex = 4;
            lblMetodo.Text = "Método";
            // 
            // lblCantidadIntervalos
            // 
            lblCantidadIntervalos.AutoSize = true;
            lblCantidadIntervalos.Font = new Font("Segoe UI", 9.75F);
            lblCantidadIntervalos.Location = new Point(18, 157);
            lblCantidadIntervalos.Name = "lblCantidadIntervalos";
            lblCantidadIntervalos.Size = new Size(235, 23);
            lblCantidadIntervalos.TabIndex = 3;
            lblCantidadIntervalos.Text = "Canditad de Subintervalos (n)";
            // 
            // lblXd
            // 
            lblXd.AutoSize = true;
            lblXd.Font = new Font("Segoe UI", 9.75F);
            lblXd.Location = new Point(197, 104);
            lblXd.Name = "lblXd";
            lblXd.Size = new Size(30, 23);
            lblXd.TabIndex = 2;
            lblXd.Text = "Xd";
            // 
            // lblXi
            // 
            lblXi.AutoSize = true;
            lblXi.Font = new Font("Segoe UI", 9.75F);
            lblXi.Location = new Point(31, 104);
            lblXi.Name = "lblXi";
            lblXi.Size = new Size(24, 23);
            lblXi.TabIndex = 1;
            lblXi.Text = "Xi";
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncion.Location = new Point(31, 47);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(36, 23);
            lblFuncion.TabIndex = 0;
            lblFuncion.Text = "F(x)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txbObservacion);
            groupBox2.Controls.Add(lblObservación);
            groupBox2.Controls.Add(txbArea);
            groupBox2.Controls.Add(lblArea);
            groupBox2.Location = new Point(23, 376);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(472, 253);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultado";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // txbObservacion
            // 
            txbObservacion.Location = new Point(136, 97);
            txbObservacion.Multiline = true;
            txbObservacion.Name = "txbObservacion";
            txbObservacion.ReadOnly = true;
            txbObservacion.Size = new Size(252, 137);
            txbObservacion.TabIndex = 8;
            // 
            // lblObservación
            // 
            lblObservación.AutoSize = true;
            lblObservación.Font = new Font("Segoe UI", 9.75F);
            lblObservación.Location = new Point(32, 97);
            lblObservación.Name = "lblObservación";
            lblObservación.Size = new Size(104, 23);
            lblObservación.TabIndex = 7;
            lblObservación.Text = "Observación";
            // 
            // txbArea
            // 
            txbArea.Location = new Point(136, 44);
            txbArea.Name = "txbArea";
            txbArea.Size = new Size(252, 27);
            txbArea.TabIndex = 6;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 9.75F);
            lblArea.Location = new Point(79, 45);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(45, 23);
            lblArea.TabIndex = 1;
            lblArea.Text = "Área";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoUcse;
            pictureBox1.Location = new Point(991, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 68);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // groupBoxGrafico
            // 
            groupBoxGrafico.Controls.Add(webView21);
            groupBoxGrafico.Controls.Add(label6);
            groupBoxGrafico.Location = new Point(529, 96);
            groupBoxGrafico.Margin = new Padding(3, 4, 3, 4);
            groupBoxGrafico.Name = "groupBoxGrafico";
            groupBoxGrafico.Padding = new Padding(3, 4, 3, 4);
            groupBoxGrafico.Size = new Size(525, 533);
            groupBoxGrafico.TabIndex = 7;
            groupBoxGrafico.TabStop = false;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(17, 56);
            webView21.Name = "webView21";
            webView21.Size = new Size(524, 470);
            webView21.TabIndex = 7;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(17, 25);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 6;
            label6.Text = "GRÁFICO";
            // 
            // Unidad4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1082, 673);
            Controls.Add(groupBoxGrafico);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Unidad4";
            Text = "Unidad4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxGrafico.ResumeLayout(false);
            groupBoxGrafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label lblCantidadIntervalos;
        private Label lblXd;
        private Label lblXi;
        private Label lblFuncion;
        private TextBox txbFuncion;
        private Label lblMetodo;
        private ComboBox ComboBoxMetodo;
        private TextBox txbCantidadSubintervales;
        private TextBox txbXd;
        private TextBox txbXi;
        private TextBox txbArea;
        private Label lblArea;
        private TextBox txbObservacion;
        private Label lblObservación;
        private GroupBox groupBoxGrafico;
        private Label label6;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button1;
    }
}