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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 9);
            label1.Name = "label1";
            label1.Size = new Size(509, 39);
            label1.TabIndex = 2;
            label1.Text = "UNIDAD 4 - INTEGRACIÓN NUMÉRICA";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Perpetua Titling MT", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(562, 421);
            label2.Name = "label2";
            label2.Size = new Size(226, 20);
            label2.TabIndex = 3;
            label2.Text = "SALIVA - PERRET - VIANO";
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(21, 72);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 336);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Salida";
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(407, 72);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 336);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Resultado";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoUcse;
            pictureBox1.Location = new Point(705, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(107, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Unidad4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Unidad4";
            Text = "Unidad4";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
    }
}