namespace AnalsisNumerico.Unidades.Unidad2
{
    partial class Unidad2
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
            lblDimension = new Label();
            lblIteracion = new Label();
            lblMetodo = new Label();
            lblTolerancia = new Label();
            comboBoxDimension = new ComboBox();
            comboBoxMetodo = new ComboBox();
            txbIteraciones = new TextBox();
            txbTolerancia = new TextBox();
            btnGenerar = new Button();
            btnCalcular = new Button();
            groupBoxMetodo = new GroupBox();
            lblResultados = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBoxResultados = new GroupBox();
            richTextBoxResultados = new RichTextBox();
            groupBoxResultados.SuspendLayout();
            SuspendLayout();
            // 
            // lblDimension
            // 
            lblDimension.AutoSize = true;
            lblDimension.Location = new Point(50, 41);
            lblDimension.Name = "lblDimension";
            lblDimension.Size = new Size(83, 15);
            lblDimension.TabIndex = 0;
            lblDimension.Text = "DIMENSIONES";
            lblDimension.Click += lblDimension_Click;
            // 
            // lblIteracion
            // 
            lblIteracion.AutoSize = true;
            lblIteracion.Location = new Point(50, 100);
            lblIteracion.Name = "lblIteracion";
            lblIteracion.Size = new Size(78, 15);
            lblIteracion.TabIndex = 1;
            lblIteracion.Text = "ITERACIONES";
            // 
            // lblMetodo
            // 
            lblMetodo.AutoSize = true;
            lblMetodo.Location = new Point(330, 36);
            lblMetodo.Name = "lblMetodo";
            lblMetodo.Size = new Size(56, 15);
            lblMetodo.TabIndex = 2;
            lblMetodo.Text = "MÉTODO";
            lblMetodo.Click += lblMetodo_Click;
            // 
            // lblTolerancia
            // 
            lblTolerancia.AutoSize = true;
            lblTolerancia.Location = new Point(330, 100);
            lblTolerancia.Name = "lblTolerancia";
            lblTolerancia.Size = new Size(77, 15);
            lblTolerancia.TabIndex = 3;
            lblTolerancia.Text = "TOLERANCIA";
            // 
            // comboBoxDimension
            // 
            comboBoxDimension.FormattingEnabled = true;
            comboBoxDimension.Location = new Point(167, 33);
            comboBoxDimension.Name = "comboBoxDimension";
            comboBoxDimension.Size = new Size(121, 23);
            comboBoxDimension.TabIndex = 4;
            comboBoxDimension.SelectedIndexChanged += comboBoxDimension_SelectedIndexChanged;
            // 
            // comboBoxMetodo
            // 
            comboBoxMetodo.FormattingEnabled = true;
            comboBoxMetodo.Location = new Point(426, 33);
            comboBoxMetodo.Name = "comboBoxMetodo";
            comboBoxMetodo.Size = new Size(121, 23);
            comboBoxMetodo.TabIndex = 5;
            comboBoxMetodo.SelectedIndexChanged += comboBoxMetodo_SelectedIndexChanged_1;
            // 
            // txbIteraciones
            // 
            txbIteraciones.Location = new Point(167, 95);
            txbIteraciones.Name = "txbIteraciones";
            txbIteraciones.Size = new Size(100, 23);
            txbIteraciones.TabIndex = 6;
            // 
            // txbTolerancia
            // 
            txbTolerancia.Location = new Point(436, 95);
            txbTolerancia.Name = "txbTolerancia";
            txbTolerancia.Size = new Size(100, 23);
            txbTolerancia.TabIndex = 7;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(610, 27);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(84, 32);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "GENERAR";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click_1;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 12F);
            btnCalcular.Location = new Point(601, 85);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(103, 40);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // groupBoxMetodo
            // 
            groupBoxMetodo.Location = new Point(21, 166);
            groupBoxMetodo.Name = "groupBoxMetodo";
            groupBoxMetodo.Size = new Size(476, 252);
            groupBoxMetodo.TabIndex = 10;
            groupBoxMetodo.TabStop = false;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Font = new Font("Palatino Linotype", 20F, FontStyle.Italic);
            lblResultados.Location = new Point(552, 166);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(194, 37);
            lblResultados.TabIndex = 11;
            lblResultados.Text = "RESULTADOS";
            lblResultados.Click += label1_Click;
            // 
            // groupBoxResultados
            // 
            groupBoxResultados.Controls.Add(richTextBoxResultados);
            groupBoxResultados.Location = new Point(530, 206);
            groupBoxResultados.Name = "groupBoxResultados";
            groupBoxResultados.Size = new Size(243, 212);
            groupBoxResultados.TabIndex = 12;
            groupBoxResultados.TabStop = false;
            // 
            // richTextBoxResultados
            // 
            richTextBoxResultados.Location = new Point(6, 11);
            richTextBoxResultados.Name = "richTextBoxResultados";
            richTextBoxResultados.Size = new Size(231, 195);
            richTextBoxResultados.TabIndex = 0;
            richTextBoxResultados.Text = "";
            // 
            // Unidad2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResultados);
            Controls.Add(lblResultados);
            Controls.Add(txbTolerancia);
            Controls.Add(lblTolerancia);
            Controls.Add(txbIteraciones);
            Controls.Add(lblIteracion);
            Controls.Add(comboBoxDimension);
            Controls.Add(comboBoxMetodo);
            Controls.Add(btnCalcular);
            Controls.Add(btnGenerar);
            Controls.Add(lblMetodo);
            Controls.Add(lblDimension);
            Controls.Add(groupBoxMetodo);
            Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            Name = "Unidad2";
            Text = "Unidad2";
            Load += Unidad2_Load;
            groupBoxResultados.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDimension;
        private Label lblIteracion;
        private Label lblMetodo;
        private Label lblTolerancia;
        private ComboBox comboBoxDimension;
        private ComboBox comboBoxMetodo;
        private TextBox txbIteraciones;
        private TextBox txbTolerancia;
        private Button btnGenerar;
        private Button btnCalcular;
        private GroupBox groupBoxMetodo;
        private Label lblResultados;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBoxResultados;
        private RichTextBox richTextBoxResultados;
    }
}