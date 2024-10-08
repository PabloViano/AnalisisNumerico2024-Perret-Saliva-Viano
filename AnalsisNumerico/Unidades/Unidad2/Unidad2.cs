﻿using Entidades.Unidad2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalsisNumerico.Unidades.Unidad2
{
    public partial class Unidad2 : Form
    {
        public Unidad2()
        {
            InitializeComponent();
        }

        private void Unidad2_Load(object sender, EventArgs e)
        {
            CargarComboBoxMetodos();
            CargarComboBoxDimension();

            //Desactivo el boton Calcular hasta que se generen los textbox de la matriz
            btnCalcular.Enabled = false;
        }

        private void CargarComboBoxMetodos()
        {
            // Declaramos los metodos para el comboBox
            string[] metodos = { "Gauss Jordan", "Gauss Seidel" };

            // Los agregamos al comboBoxMetodo
            comboBoxMetodo.Items.AddRange(metodos);

            comboBoxMetodo.SelectedItem = metodos[0];

            //Hacemos que no pueda ingresar texto
            comboBoxMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboBoxDimension()
        {
            string[] dimensionesPosibles = { "2", "3", "4", "5", "6", "7" };

            comboBoxDimension.Items.AddRange(dimensionesPosibles);

            //Hacemos que no pueda ingresar texto
            comboBoxDimension.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public double[,] GuardarMatriz(int dimension)
        {
            double[,] matriz = new double[dimension, dimension + 1];

            for (int row = 0; row < dimension; row++)
            {
                for (int col = 0; col < dimension + 1; col++)
                {
                    Control textBox = groupBoxMetodo.Controls.Find($"({row},{col})", true).First();

                    if (!double.TryParse((textBox as TextBox)!.Text, out double numero))
                    {
                        return null!;
                    }

                    matriz[row, col] = numero;
                }
            }

            return matriz;
        }

        private void comboBoxMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIteracion.Visible = true;
            lblTolerancia.Visible = true;
            txbIteraciones.Visible = true;
            txbTolerancia.Visible = true;
        }

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            int dimension = int.Parse(comboBoxDimension.SelectedItem.ToString()!);
            int cellWidth = (groupBoxMetodo.Width - 40) / (dimension + 1); // Resta márgenes
            int cellHeight = 30; // Altura fija

            groupBoxMetodo.Controls.Clear();

            for (int row = 0; row < dimension; row++)
            {
                for (int col = 0; col < dimension + 1; col++)
                {
                    string nombre = $"({row},{col})";
                    TextBox textBox = new TextBox();
                    textBox.Name = nombre;
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(textBox, nombre);
                    textBox.Location = new Point(20 + col * cellWidth, 30 + row * cellHeight);
                    textBox.Size = new Size(cellWidth, cellHeight);

                    if (col == row)
                    {
                        textBox.BackColor = Color.FromArgb(173, 216, 230); // Celeste intermedio
                    }

                    if (col == dimension)
                    {
                        textBox.BackColor = Color.FromArgb(240, 255, 255); // Un celeste muy claro
                    }

                    groupBoxMetodo.Controls.Add(textBox);
                    groupBoxMetodo.Show();
                }
            }
            btnCalcular.Enabled = true;
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int dimension = int.Parse(comboBoxDimension.SelectedItem.ToString()!);
            double[,] matriz = GuardarMatriz(dimension);

            double[] vectorResultado = new double[dimension];

            ResponseUnidad2 response = new ResponseUnidad2(vectorResultado, 0);
            SistemaEcuacionesService sistemaEcuacionesService = new SistemaEcuacionesService();

            switch (comboBoxMetodo.Text)
            {
                case "Gauss Jordan":
                    MatrizModel matrizModelJordan = new MatrizModel
                    {
                        Dimension = dimension,
                        Matriz = matriz
                    };
                    response = sistemaEcuacionesService.CalcularGaussJordan(matrizModelJordan);
                    break;
                case "Gauss Seidel":
                    MatrizModel matrizModelSeidel = new MatrizModel
                    {
                        Dimension = dimension,
                        Matriz = matriz,
                        Tolerancia = double.Parse(txbTolerancia.Text),
                        Iteraciones = int.Parse(txbIteraciones.Text)
                    };
                    response = sistemaEcuacionesService.CalcularGaussSeidel(matrizModelSeidel);
                    break;
            }

            if (response != null)
            {
                string resultados = "";
                for (int i = 0; i < response.VectorRespuesta!.Length; i++)
                {
                    double valorRedondeado = response.VectorRespuesta[i];

                    // Condición para mostrar sin decimales si es entero
                    if (valorRedondeado % 1 == 0)
                    {
                        resultados += $"X{i + 1} = {(int)valorRedondeado}\n"; // Mostrar sin decimales si es un entero
                    }
                    else
                    {
                        resultados += $"X{i + 1} = {valorRedondeado}\n"; 
                    }
                }
                resultados += "\n";

                MostrarResultados(resultados);
            }
            else
            {
                MessageBox.Show($"Se pasó de las {txbIteraciones.Text} iteraciones.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void comboBoxMetodo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxMetodo.Text == "Gauss Seidel")
            {
                lblIteracion.Visible = true;
                lblTolerancia.Visible = true;
                txbIteraciones.Visible = true;
                txbTolerancia.Visible = true;
            }
            else
            {
                lblIteracion.Visible = false;
                lblTolerancia.Visible = false;
                txbIteraciones.Visible = false;
                txbTolerancia.Visible = false;
            }
        }

        private void lblMetodo_Click(object sender, EventArgs e)
        {

        }

        private void MostrarResultados(string resultados)
        {
            // Verifica si el RichTextBox existe dentro del GroupBox de Resultados
            if (groupBoxResultados.Controls.Contains(richTextBoxResultados))
            {
                // Actualiza el contenido del RichTextBox con los resultados
                richTextBoxResultados.Text = resultados;
                richTextBoxResultados.Font = new Font("Segoe UI", 12, FontStyle.Italic); // Configura la fuente
                richTextBoxResultados.BackColor = SystemColors.ActiveCaption;      // Fondo gris claro
                richTextBoxResultados.ForeColor = Color.Black;                     // Texto en azul oscuro
                richTextBoxResultados.ReadOnly = true;                             // Solo lectura
                richTextBoxResultados.BorderStyle = BorderStyle.None;

                // Ajustar propiedades del groupBoxResultados para que no muestre bordes y el fondo sea igual
                groupBoxResultados.BackColor = SystemColors.ActiveCaption; // Fondo similar al RichTextBox
                groupBoxResultados.FlatStyle = FlatStyle.Flat;             // Opcional: reduce la apariencia del borde

                // Añadir el RichTextBox al groupBoxResultados
                groupBoxResultados.Controls.Add(richTextBoxResultados);
            }
            else
            {
                MessageBox.Show("El control para mostrar los resultados no se encontró.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDimension_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDimension_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxResultados_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxMetodo_Enter(object sender, EventArgs e)
        {

        }
    }
}
