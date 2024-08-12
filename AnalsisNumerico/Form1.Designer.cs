namespace AnalsisNumerico
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            boton_menu_U1 = new Button();
            button_menu_U2 = new Button();
            button_menu_U3 = new Button();
            button_menu_U4 = new Button();
            SuspendLayout();
            // 
            // boton_menu_U1
            // 
            boton_menu_U1.Location = new Point(25, 22);
            boton_menu_U1.Name = "boton_menu_U1";
            boton_menu_U1.Size = new Size(235, 49);
            boton_menu_U1.TabIndex = 0;
            boton_menu_U1.Text = "Unidad 1";
            boton_menu_U1.UseVisualStyleBackColor = true;
            boton_menu_U1.Click += boton_menu_U1_Click;
            // 
            // button_menu_U2
            // 
            button_menu_U2.Location = new Point(25, 133);
            button_menu_U2.Name = "button_menu_U2";
            button_menu_U2.Size = new Size(235, 49);
            button_menu_U2.TabIndex = 1;
            button_menu_U2.Text = "Unidad 2";
            button_menu_U2.UseVisualStyleBackColor = true;
            // 
            // button_menu_U3
            // 
            button_menu_U3.Location = new Point(25, 251);
            button_menu_U3.Name = "button_menu_U3";
            button_menu_U3.Size = new Size(235, 49);
            button_menu_U3.TabIndex = 2;
            button_menu_U3.Text = "Unidad 3";
            button_menu_U3.UseVisualStyleBackColor = true;
            // 
            // button_menu_U4
            // 
            button_menu_U4.Location = new Point(25, 371);
            button_menu_U4.Name = "button_menu_U4";
            button_menu_U4.Size = new Size(235, 49);
            button_menu_U4.TabIndex = 3;
            button_menu_U4.Text = "Unidad 4";
            button_menu_U4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_menu_U4);
            Controls.Add(button_menu_U3);
            Controls.Add(button_menu_U2);
            Controls.Add(boton_menu_U1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button boton_menu_U1;
        private Button button_menu_U2;
        private Button button_menu_U3;
        private Button button_menu_U4;
    }
}
