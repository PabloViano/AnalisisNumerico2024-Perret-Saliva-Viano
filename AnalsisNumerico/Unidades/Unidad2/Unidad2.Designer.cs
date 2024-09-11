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
            lblMetodo.Size = new Size(55, 15);
            lblMetodo.TabIndex = 2;
            lblMetodo.Text = "MÉTODO";
            lblMetodo.Click += lblMetodo_Click;
            // 
            // lblTolerancia
            // 
            lblTolerancia.AutoSize = true;
            lblTolerancia.Location = new Point(330, 100);
            lblTolerancia.Name = "lblTolerancia";
            lblTolerancia.Size = new Size(76, 15);
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
            btnCalcular.Location = new Point(610, 95);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(111, 43);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click_1;
            // 
            // groupBoxMetodo
            // 
            groupBoxMetodo.Location = new Point(35, 173);
            groupBoxMetodo.Name = "groupBoxMetodo";
            groupBoxMetodo.Size = new Size(735, 252);
            groupBoxMetodo.TabIndex = 10;
            groupBoxMetodo.TabStop = false;
            // 
            // Unidad2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
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
            Name = "Unidad2";
            Text = "Unidad2";
            Load += Unidad2_Load;
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
    }
}