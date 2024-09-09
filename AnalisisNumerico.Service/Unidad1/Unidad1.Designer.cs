namespace AnalsisNumerico.Unidades.Unidad1
{
    partial class Unidad1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(51, 25);
            label1.Name = "label1";
            label1.Size = new Size(221, 35);
            label1.TabIndex = 0;
            label1.Text = "Metodos Cerrados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(481, 25);
            label2.Name = "label2";
            label2.Size = new Size(214, 35);
            label2.TabIndex = 1;
            label2.Text = "Metodos Abiertos";
            // 
            // button1
            // 
            button1.Location = new Point(51, 104);
            button1.Name = "button1";
            button1.Size = new Size(220, 47);
            button1.TabIndex = 2;
            button1.Text = "Bisección";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(51, 188);
            button2.Name = "button2";
            button2.Size = new Size(220, 47);
            button2.TabIndex = 3;
            button2.Text = "Regla Falsa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(481, 104);
            button3.Name = "button3";
            button3.Size = new Size(220, 47);
            button3.TabIndex = 4;
            button3.Text = "Newton - Rapshon";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(481, 188);
            button4.Name = "button4";
            button4.Size = new Size(220, 47);
            button4.TabIndex = 5;
            button4.Text = "Secante";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Unidad1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Unidad1";
            Text = "Unidad1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}