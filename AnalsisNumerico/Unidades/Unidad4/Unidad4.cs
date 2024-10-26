using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AnalsisNumerico.Unidades.Unidad4;
using Entidades.Unidad4;
using System.Text.RegularExpressions;

namespace AnalsisNumerico.Unidades.Unidad4
{
    public partial class Unidad4 : Form
    {
        private object or;

        public Unidad4()
        {
            InitializeComponent();
        }

        private void ComboBoxMetodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxMetodo.Text == "Trapezoidal Múltiple" || ComboBoxMetodo.Text == "Simpson 1/3 Múltiple" || ComboBoxMetodo.Text == "Simpson 3/8")
            {
                lblCantidadIntervalos.Visible = true;
                txbCantidadSubintervales.Visible = true;
            }
            else
            {
                lblCantidadIntervalos.Visible = false;
                txbCantidadSubintervales.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private async void webView21_Click(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Inicializa el WebView2 si no está ya inicializado
            await webView21.EnsureCoreWebView2Async(null);

            // Obtén la función del TextBox
            string funcion = txbFuncion.Text; // Supón que el TextBox se llama textBox1
            string funcionModificada = Regex.Replace(funcion, @"\+", "%2B");

            // Construye la URL para GeoGebra con la función ingresada
            string urlGeoGebra = $"https://www.geogebra.org/graphing?command=f(x)={funcionModificada}";

            // Navega a la URL generada
            webView21.CoreWebView2.Navigate(urlGeoGebra);
            
            U4Entrada datosEntrada = new U4Entrada();
            datosEntrada.Funcion = funcion;
            datosEntrada.PuntoA = double.Parse(txbXi.Text);
            datosEntrada.PuntoB = double.Parse(txbXd.Text);
            datosEntrada.Metodo = ComboBoxMetodo.SelectedIndex;

            if (datosEntrada.Metodo == 0 || datosEntrada.Metodo == 2)
            {
                datosEntrada.CantidadSubintervalos = 1;
            } else
            {
                datosEntrada.CantidadSubintervalos = int.Parse(txbCantidadSubintervales.Text);
            }
            U4Salida resultado = Procedimientos.Resolucion(datosEntrada);

            txbArea.Text = resultado.Resultado.ToString();
            txbObservacion.Text = "Área calculada con éxito.";
            txbObservacion.ForeColor = Color.Green; // Color para mensaje de éxito

            // Verificar si hay un error
            if (resultado._Error == true)
            {
                // Si hay un error, cambiar el mensaje y el color
                txbObservacion.Text = resultado._MsjError;
                txbObservacion.ForeColor = Color.Red; // Color para mensaje de error
            }
        }

        private void groupBoxGrafico_Enter(object sender, EventArgs e)
        {

        }
    }
}
