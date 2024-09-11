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
                    string nombre = $"({row},{col})"; //"(" + row.ToString() + "," + col.ToString() + ")";
                    TextBox textBox = new TextBox();
                    textBox.Name = nombre;
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(textBox, nombre);
                    textBox.Location = new Point(puntoX, puntoY);
                    textBox.Size = new Size(80, 30);

                    if (col == dimension)
                    {
                        textBox.BackColor = Color.LightSkyBlue;
                    }

                    groupBoxMetodo.Controls.Add(textBox);
                    groupBoxMetodo.Show();
                    puntoX += 90;
                }
                puntoX = 30;
                puntoY += 30;
            }

            //Ahora si activo el boton Calcular
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

            string resultados = "";
            if (response != null)
            {
                for (int i = 0; i < response.VectorRespuesta!.Length; i++)
                {
                    resultados += $"X{i + 1} = {response.VectorRespuesta[i]}\n";
                }
                //Le ingreso la ultima posicion del vectorResultado que es la cantidad de iteraciones que se realizaron
                resultados += $"Se realizaron {response.Iteraciones} iteraciones.";

            }
            else
            {
                resultados = $"Se pasó de las {txbIteraciones.Text} iteraciones.";
            }
            MessageBox.Show(resultados, "Los valores son los siguientes:", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
