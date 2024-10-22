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
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            lblFuncion = new Label();
            lblXi = new Label();
            lblXd = new Label();
            lblCantidadIntervalos = new Label();
            lblMetodo = new Label();
            txbFuncion = new TextBox();
            txbXi = new TextBox();
            txbXd = new TextBox();
            txbCantidadSubintervales = new TextBox();
            ComboBoxMetodo = new ComboBox();
            lblArea = new Label();
            txbArea = new TextBox();
            lblObservación = new Label();
            txbObservacion = new TextBox();
            groupBoxGrafico = new GroupBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBoxGrafico.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(220, 12);
            label1.Name = "label1";
            label1.Size = new Size(510, 39);
            label1.TabIndex = 2;
            label1.Text = "UNIDAD 4 - INTEGRACIÓN NUMÉRICA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(722, 475);
            label2.Name = "label2";
            label2.Size = new Size(200, 21);
            label2.TabIndex = 3;
            label2.Text = "SALIVA - PERRET - VIANO";
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(21, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 194);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Salida";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txbObservacion);
            groupBox2.Controls.Add(lblObservación);
            groupBox2.Controls.Add(txbArea);
            groupBox2.Controls.Add(lblArea);
            groupBox2.Location = new Point(20, 282);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(413, 192);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultado";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoUcse;
            pictureBox1.Location = new Point(867, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFuncion.Location = new Point(27, 35);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(28, 17);
            lblFuncion.TabIndex = 0;
            lblFuncion.Text = "F(x)";
            // 
            // lblXi
            // 
            lblXi.AutoSize = true;
            lblXi.Font = new Font("Segoe UI", 9.75F);
            lblXi.Location = new Point(27, 78);
            lblXi.Name = "lblXi";
            lblXi.Size = new Size(19, 17);
            lblXi.TabIndex = 1;
            lblXi.Text = "Xi";
            // 
            // lblXd
            // 
            lblXd.AutoSize = true;
            lblXd.Font = new Font("Segoe UI", 9.75F);
            lblXd.Location = new Point(172, 78);
            lblXd.Name = "lblXd";
            lblXd.Size = new Size(24, 17);
            lblXd.TabIndex = 2;
            lblXd.Text = "Xd";
            // 
            // lblCantidadIntervalos
            // 
            lblCantidadIntervalos.AutoSize = true;
            lblCantidadIntervalos.Font = new Font("Segoe UI", 9.75F);
            lblCantidadIntervalos.Location = new Point(16, 118);
            lblCantidadIntervalos.Name = "lblCantidadIntervalos";
            lblCantidadIntervalos.Size = new Size(180, 17);
            lblCantidadIntervalos.TabIndex = 3;
            lblCantidadIntervalos.Text = "Canditad de Subintervalos (n)";
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Font = new Font("Segoe UI", 9.75F);
            lblMetodo.Location = new Point(16, 160);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(55, 17);
            lblMetodo.TabIndex = 4;
            lblMetodo.Text = "Método";
            // 
            // txbFuncion
            // 
            txbFuncion.Location = new Point(73, 34);
            txbFuncion.Margin = new Padding(3, 2, 3, 2);
            txbFuncion.Name = "txbFuncion";
            txbFuncion.Size = new Size(201, 23);
            txbFuncion.TabIndex = 5;
            // 
            // txbXi
            // 
            txbXi.Location = new Point(73, 72);
            txbXi.Margin = new Padding(3, 2, 3, 2);
            txbXi.Name = "txbXi";
            txbXi.Size = new Size(55, 23);
            txbXi.TabIndex = 6;
            // 
            // txbXd
            // 
            txbXd.Location = new Point(209, 72);
            txbXd.Margin = new Padding(3, 2, 3, 2);
            txbXd.Name = "txbXd";
            txbXd.Size = new Size(65, 23);
            txbXd.TabIndex = 7;
            // 
            // txbCantidadSubintervales
            // 
            txbCantidadSubintervales.Location = new Point(199, 115);
            txbCantidadSubintervales.Margin = new Padding(3, 2, 3, 2);
            txbCantidadSubintervales.Name = "txbCantidadSubintervales";
            txbCantidadSubintervales.Size = new Size(75, 23);
            txbCantidadSubintervales.TabIndex = 8;
            // 
            // ComboBoxMetodo
            // 
            ComboBoxMetodo.FormattingEnabled = true;
            ComboBoxMetodo.Location = new Point(92, 157);
            ComboBoxMetodo.Margin = new Padding(3, 2, 3, 2);
            ComboBoxMetodo.Name = "ComboBoxMetodo";
            ComboBoxMetodo.Size = new Size(162, 23);
            ComboBoxMetodo.TabIndex = 10;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 9.75F);
            lblArea.Location = new Point(69, 34);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(35, 17);
            lblArea.TabIndex = 1;
            lblArea.Text = "Área";
            // 
            // txbArea
            // 
            txbArea.Location = new Point(119, 33);
            txbArea.Margin = new Padding(3, 2, 3, 2);
            txbArea.Name = "txbArea";
            txbArea.Size = new Size(221, 23);
            txbArea.TabIndex = 6;
            // 
            // lblObservación
            // 
            lblObservación.AutoSize = true;
            lblObservación.Font = new Font("Segoe UI", 9.75F);
            lblObservación.Location = new Point(28, 73);
            lblObservación.Name = "lblObservación";
            lblObservación.Size = new Size(81, 17);
            lblObservación.TabIndex = 7;
            lblObservación.Text = "Observación";
            // 
            // txbObservacion
            // 
            txbObservacion.Location = new Point(119, 73);
            txbObservacion.Margin = new Padding(3, 2, 3, 2);
            txbObservacion.Multiline = true;
            txbObservacion.Name = "txbObservacion";
            txbObservacion.ReadOnly = true;
            txbObservacion.Size = new Size(221, 104);
            txbObservacion.TabIndex = 8;
            // 
            // groupBoxGrafico
            // 
            groupBoxGrafico.Controls.Add(label6);
            groupBoxGrafico.Location = new Point(463, 72);
            groupBoxGrafico.Name = "groupBoxGrafico";
            groupBoxGrafico.Size = new Size(459, 400);
            groupBoxGrafico.TabIndex = 7;
            groupBoxGrafico.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Popup;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 19);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 6;
            label6.Text = "GRÁFICO";
            // 
            // Unidad4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(947, 505);
            Controls.Add(groupBoxGrafico);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Unidad4";
            Text = "Unidad4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBoxGrafico.ResumeLayout(false);
            groupBoxGrafico.PerformLayout();
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
    }
}