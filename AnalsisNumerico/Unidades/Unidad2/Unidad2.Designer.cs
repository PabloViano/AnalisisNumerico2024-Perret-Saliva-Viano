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
            LabelDimension = new Label();
            TextBoxTamanoMatriz = new TextBox();
            ButtonGenerar = new Button();
            LabelMetodo = new Label();
            TextBoxMetodo = new TextBox();
            ButtonCalcularMetodo = new Button();
            SuspendLayout();
            // 
            // LabelDimension
            // 
            LabelDimension.AutoSize = true;
            LabelDimension.Location = new Point(33, 22);
            LabelDimension.Name = "LabelDimension";
            LabelDimension.Size = new Size(83, 15);
            LabelDimension.TabIndex = 0;
            LabelDimension.Text = "DIMENSIONES";
            LabelDimension.Click += label1_Click;
            // 
            // TextBoxTamanoMatriz
            // 
            TextBoxTamanoMatriz.Location = new Point(149, 19);
            TextBoxTamanoMatriz.Name = "TextBoxTamanoMatriz";
            TextBoxTamanoMatriz.Size = new Size(100, 23);
            TextBoxTamanoMatriz.TabIndex = 1;
            // 
            // ButtonGenerar
            // 
            ButtonGenerar.Location = new Point(320, 19);
            ButtonGenerar.Name = "ButtonGenerar";
            ButtonGenerar.Size = new Size(75, 23);
            ButtonGenerar.TabIndex = 2;
            ButtonGenerar.Text = "GENERAR";
            ButtonGenerar.UseVisualStyleBackColor = true;
            // 
            // LabelMetodo
            // 
            LabelMetodo.AutoSize = true;
            LabelMetodo.Location = new Point(33, 177);
            LabelMetodo.Name = "LabelMetodo";
            LabelMetodo.Size = new Size(55, 15);
            LabelMetodo.TabIndex = 3;
            LabelMetodo.Text = "MÉTODO";
            LabelMetodo.Click += label1_Click_1;
            // 
            // TextBoxMetodo
            // 
            TextBoxMetodo.Location = new Point(149, 174);
            TextBoxMetodo.Name = "TextBoxMetodo";
            TextBoxMetodo.Size = new Size(100, 23);
            TextBoxMetodo.TabIndex = 4;
            // 
            // ButtonCalcularMetodo
            // 
            ButtonCalcularMetodo.Location = new Point(320, 173);
            ButtonCalcularMetodo.Name = "ButtonCalcularMetodo";
            ButtonCalcularMetodo.Size = new Size(75, 23);
            ButtonCalcularMetodo.TabIndex = 5;
            ButtonCalcularMetodo.Text = "CALCULAR";
            ButtonCalcularMetodo.UseVisualStyleBackColor = true;
            // 
            // Unidad2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ButtonCalcularMetodo);
            Controls.Add(TextBoxMetodo);
            Controls.Add(LabelMetodo);
            Controls.Add(ButtonGenerar);
            Controls.Add(TextBoxTamanoMatriz);
            Controls.Add(LabelDimension);
            Name = "Unidad2";
            Text = "Unidad2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelDimension;
        private TextBox TextBoxTamanoMatriz;
        private Button ButtonGenerar;
        private Label LabelMetodo;
        private TextBox TextBoxMetodo;
        private Button ButtonCalcularMetodo;
    }
}