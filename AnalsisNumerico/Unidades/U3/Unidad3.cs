using Analisis_Numerico;
using Entidades.Unidad3;
using Entidades.Unidad4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnalsisNumerico.Unidades.U3
{
    public partial class Unidad3 : Form
    {
        private List<double[]> PuntosCargados = new List<double[]>();
        public Graficador graficador { get; set; }
        public Unidad3()
        {
            InitializeComponent();
            // SetPanelGrafica();
            CargarComboBoxMetodoUtilizar();
            CargarComboBoxGrado();
            btnBorrarTodos.Enabled = false;
            btnBorrarUltimo.Enabled = false;
        }

        private void Unidad3_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Cargar los puntos al panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBoxX.Text, out double x) && double.TryParse(txtBoxY.Text, out double y))
            {
                CargarPunto(x, y);

                Label puntoIngresado = new Label();
                puntoIngresado.Text = $"({x} , {y})";
                puntoIngresado.ForeColor = Color.Blue;

                // Cambia la fuente a una más moderna y de tamaño adecuado.
                puntoIngresado.Font = new Font("Segoe UI", 12, FontStyle.Regular);

                // Ajusta automáticamente el tamaño del Label al contenido
                puntoIngresado.AutoSize = true;

                // Elimina el fondo y el borde para un estilo más limpio.
                puntoIngresado.BackColor = Color.Transparent;
                puntoIngresado.BorderStyle = BorderStyle.None;

                // Calcula la ubicación del Label con un espacio moderado entre ellos.
                int cantElementos = PuntosCargados.Count();
                int puntoY = (cantElementos - 1) * 22; // Ajusta el espacio entre los Labels
                puntoIngresado.Location = new Point(5, puntoY); // Añade un pequeño margen izquierdo

                panelCargaDePuntos.Controls.Add(puntoIngresado);
                panelCargaDePuntos.Show();

                txtBoxX.Clear();
                txtBoxY.Clear();

                if (PuntosCargados.Count > 0)
                {
                    btnBorrarTodos.Enabled = true;
                    btnBorrarUltimo.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores válidos para x e y.");
            }
        }

        private void btnBorrarUltimo_Click(object sender, EventArgs e)
        {
            if (PuntosCargados.Count > 0)
            {
                PuntosCargados.RemoveAt(PuntosCargados.Count - 1);
                panelCargaDePuntos.Controls.RemoveAt(panelCargaDePuntos.Controls.Count - 1);
            }
            if (PuntosCargados.Count == 0)
            {
                btnBorrarTodos.Enabled = false;
                btnBorrarUltimo.Enabled = false;
            }
        }

        private void btnBorrarTodos_Click(object sender, EventArgs e)
        {
            PuntosCargados.Clear();
            panelCargaDePuntos.Controls.Clear();
            btnBorrarTodos.Enabled = false;
            btnBorrarUltimo.Enabled = false;
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            // Validaciones previas antes de realizar el cálculo
            if (this.PuntosCargados == null || this.PuntosCargados.Count == 0)
            {
                MessageBox.Show("Debe ingresar puntos para realizar el cálculo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double tolerancia;
            int grado;

            // Validar la entrada de la tolerancia
            if (!double.TryParse(txtBoxTolerancia.Text, out tolerancia))
            {
                MessageBox.Show("La tolerancia debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que el usuario ha seleccionado un grado solo si se trata de regresión polinomial
            if (comboBoxMetodo.SelectedItem.ToString() == "Regresion Polinomial")
            {
                if (comboBoxGrado.SelectedItem == null || !int.TryParse(comboBoxGrado.SelectedItem.ToString(), out grado))
                {
                    MessageBox.Show("Debe seleccionar un grado válido (entre 1 y 10) para la regresión polinomial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            } else
            {
                grado = 1;
            }

            // Crear objeto U3Entrada con los puntos cargados, tolerancia y grado
            U3Entrada entrada = new U3Entrada
            {
                PuntosCargados = this.PuntosCargados,
                Tolerancia = tolerancia,
                Grado = grado
            };

            U3Salida resultado = null;

            try
            {
                // Determinar el método seleccionado y ejecutar el cálculo correspondiente
                switch (comboBoxMetodo.SelectedItem.ToString())
                {
                    case "Regresion Lineal":
                        // Llamar al método estático de la clase Procedimientos
                        resultado = Procedimientos.Resolucion(entrada, 0);
                        break;

                    case "Regresion Polinomial":
                        // Llamar al método estático de la clase Procedimientos
                        resultado = Procedimientos.Resolucion(entrada, 1);
                        break;

                    default:
                        throw new InvalidOperationException("Método no soportado.");
                }

                // Verificar si hubo algún error en el cálculo
                if (resultado._Error)
                {
                    MessageBox.Show(resultado._MsjError, "Error en cálculo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Mostrar los resultados en los TextBox del formulario
                txbFuncion.Text = resultado.Funcion;
                txtBoxCorrelacion.Text = resultado.PorcentajeEfectividad.ToString("F2") + "%";
                txtBoxEfectividad.Text = "El ajuste no es aceptable.";
                if (resultado.EfectividadAjuste)
                {
                    txtBoxEfectividad.Text = "El ajuste es aceptable.";
                }

                // Inicializa el WebView2 si no está ya inicializado
                await webView21.EnsureCoreWebView2Async(null);

                string funcion = txbFuncion.Text; // Supón que el TextBox se llama txbFuncion
                funcion = Regex.Replace(funcion, @"y\s*=\s*", "");
                funcion = funcion.Replace(",", "."); // Asegúrate de que ya esté en formato de punto
                string funcionModificada = Regex.Replace(funcion, @"\+", "%2B");


                // Construir la cadena para los puntos
                string puntosComando = string.Join("%3B", PuntosCargados.Select((p, index) =>
                    $"A{index}%3D({p[0].ToString("G", System.Globalization.CultureInfo.InvariantCulture)},{p[1].ToString("G", System.Globalization.CultureInfo.InvariantCulture)})"
                ));

                // Construye la URL para GeoGebra con la función ingresada y los puntos
                string urlGeoGebra = $"https://www.geogebra.org/graphing?command=f(x)={funcionModificada}%3B{puntosComando}";

                // Navega a la URL generada
                webView21.CoreWebView2.Navigate(urlGeoGebra);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error durante el cálculo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPunto(double x, double y)
        {
            double[] punto = new double[2] { x, y };
            PuntosCargados.Add(punto);
        }

        private void CargarComboBoxMetodoUtilizar()
        {
            string[] metodos = { "Regresion Lineal", "Regresion Polinomial" };

            comboBoxMetodo.Items.AddRange(metodos);
            comboBoxMetodo.SelectedItem = metodos[0];
            comboBoxMetodo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboBoxGrado()
        {
            // Limpia el ComboBox antes de cargar los nuevos valores
            comboBoxGrado.Items.Clear();

            // Agrega los números del 1 al 10 al ComboBox
            for (int i = 1; i <= 10; i++)
            {
                comboBoxGrado.Items.Add(i);
            }

            // Si deseas seleccionar el primer elemento por defecto
            if (comboBoxGrado.Items.Count > 0)
            {
                comboBoxGrado.SelectedIndex = 0; // Selecciona el primer elemento
            }
        }

        // NO ELIMINAR
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxEntrada_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxEfectividad_Click(object sender, EventArgs e)
        {

        }
    }
}
