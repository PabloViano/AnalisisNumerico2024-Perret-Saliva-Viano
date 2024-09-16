using Entidades.Unidad2;
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
            string[] dimensionesPosibles = { "2", "3", "4", "5" };

            comboBoxDimension.Items.AddRange(dimensionesPosibles);

            //Indica que por default la eleccion es 2
            comboBoxDimension.SelectedItem = "2";

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

        private void btnGenerar_Click_1(object sender, EventArgs e)
        {
            int dimension = int.Parse(comboBoxDimension.SelectedItem.ToString()!);
            int puntoX = 30;
            int puntoY = 30;

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
                    textBox.Location = new Point(puntoX, puntoY);
                    textBox.Size = new Size(80, 30);

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
                    puntoX += 90;
                }
                puntoX = 30;
                puntoY += 30;
            }
            btnCalcular.Enabled = true;
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            int dimension = int.Parse(comboBoxDimension.SelectedItem.ToString()!);
            double[,] matriz = GuardarMatriz(dimension);

            //Muestro un mensaje en pantalla
            MessageBox.Show("Matriz cargada con exito");

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

            if(response != null)
            {
                string resultados = "";
                for (int i = 0; i < response.VectorRespuesta!.Length; i++)
                {
                    double valorRedondeado = Math.Ceiling(response.VectorRespuesta[i] * 100000) / 100000;
                    resultados += $"X{i + 1} = {valorRedondeado:F5}\n"; // Mostrar con 5 decimales
                }

                resultados += "\n";
                resultados += $"Se realizaron {response.Iteraciones} iteraciones.";

                // Mostrar los resultados en un Form personalizado
                MostrarResultados(resultados); // Mostrar el Form como un diálogo modal
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
            // Crear un nuevo formulario
            Form resultForm = new Form
            {
                Text = "Valores Resultantes",
                Size = new Size(400, 300),
                StartPosition = FormStartPosition.CenterScreen // Centrar la ventana en la pantalla
            };

            // Crear un RichTextBox para mostrar los resultados
            RichTextBox richTextBoxResultados = new RichTextBox
            {
                Text = resultados,
                Dock = DockStyle.Fill,                        // Ocupa todo el espacio del Form
                Font = new Font("Segoe UI", 10),              // Cambiar la fuente
                BackColor = Color.LightGray,                  // Fondo gris claro
                ForeColor = Color.DarkBlue,                   // Texto en azul oscuro
                ReadOnly = true                               // Solo lectura
            };

            // Añadir el RichTextBox al Form
            resultForm.Controls.Add(richTextBoxResultados);

            // Mostrar el formulario como diálogo modal
            resultForm.ShowDialog();
        }
    }
}
