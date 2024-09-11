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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            boton_menu_U1 = new Button();
            button_menu_U2 = new Button();
            button_menu_U3 = new Button();
            button_menu_U4 = new Button();
            SuspendLayout();
            // 
            // boton_menu_U1
            // 
            boton_menu_U1.BackColor = SystemColors.ControlLight;
            boton_menu_U1.FlatAppearance.BorderColor = Color.Bisque;
            boton_menu_U1.FlatAppearance.BorderSize = 3;
            boton_menu_U1.FlatStyle = FlatStyle.Flat;
            boton_menu_U1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            boton_menu_U1.Location = new Point(45, 39);
            boton_menu_U1.Margin = new Padding(3, 2, 3, 2);
            boton_menu_U1.Name = "boton_menu_U1";
            boton_menu_U1.Size = new Size(206, 37);
            boton_menu_U1.TabIndex = 0;
            boton_menu_U1.Text = "Unidad 1";
            boton_menu_U1.UseVisualStyleBackColor = false;
            boton_menu_U1.Click += boton_menu_U1_Click;
            // 
            // button_menu_U2
            // 
            button_menu_U2.BackColor = SystemColors.ControlLight;
            button_menu_U2.FlatAppearance.BorderColor = Color.Bisque;
            button_menu_U2.FlatAppearance.BorderSize = 3;
            button_menu_U2.FlatStyle = FlatStyle.Flat;
            button_menu_U2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_menu_U2.Location = new Point(45, 116);
            button_menu_U2.Margin = new Padding(3, 2, 3, 2);
            button_menu_U2.Name = "button_menu_U2";
            button_menu_U2.Size = new Size(206, 37);
            button_menu_U2.TabIndex = 1;
            button_menu_U2.Text = "Unidad 2";
            button_menu_U2.UseVisualStyleBackColor = false;
            button_menu_U2.Click += button_menu_U2_Click;
            // 
            // button_menu_U3
            // 
            button_menu_U3.BackColor = SystemColors.ControlLight;
            button_menu_U3.FlatAppearance.BorderColor = Color.Bisque;
            button_menu_U3.FlatAppearance.BorderSize = 3;
            button_menu_U3.FlatStyle = FlatStyle.Flat;
            button_menu_U3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_menu_U3.Location = new Point(45, 195);
            button_menu_U3.Margin = new Padding(3, 2, 3, 2);
            button_menu_U3.Name = "button_menu_U3";
            button_menu_U3.Size = new Size(206, 37);
            button_menu_U3.TabIndex = 2;
            button_menu_U3.Text = "Unidad 3";
            button_menu_U3.UseVisualStyleBackColor = false;
            // 
            // button_menu_U4
            // 
            button_menu_U4.BackColor = SystemColors.ControlLight;
            button_menu_U4.FlatAppearance.BorderColor = Color.Bisque;
            button_menu_U4.FlatAppearance.BorderSize = 3;
            button_menu_U4.FlatStyle = FlatStyle.Flat;
            button_menu_U4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_menu_U4.ForeColor = SystemColors.ActiveCaptionText;
            button_menu_U4.Location = new Point(45, 276);
            button_menu_U4.Margin = new Padding(3, 2, 3, 2);
            button_menu_U4.Name = "button_menu_U4";
            button_menu_U4.Size = new Size(206, 37);
            button_menu_U4.TabIndex = 3;
            button_menu_U4.Text = "Unidad 4";
            button_menu_U4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(717, 350);
            Controls.Add(button_menu_U4);
            Controls.Add(button_menu_U3);
            Controls.Add(button_menu_U2);
            Controls.Add(boton_menu_U1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Análisis Numérico";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button boton_menu_U1;
        private Button button_menu_U2;
        private Button button_menu_U3;
        private Button button_menu_U4;
    }
}
