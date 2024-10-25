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

namespace AnalsisNumerico.Unidades.Unidad4
{
    public partial class Unidad4 : Form
    {
        public Unidad4()
        {
            InitializeComponent();
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

            // Construye la URL para GeoGebra con la función ingresada
            string urlGeoGebra = $"https://www.geogebra.org/graphing?command=f(x)={funcion}";

            // Navega a la URL generada
            webView21.CoreWebView2.Navigate(urlGeoGebra);

            U4Entrada datosEntrada = new U4Entrada()
            {
                Funcion = funcion,
                PuntoA = double.Parse(txbXi.Text),
                PuntoB = double.Parse(txbXd.Text),
                CantidadSubintervalos = int.Parse(txbCantidadSubintervales.Text),
                Metodo = ComboBoxMetodo.SelectedIndex
            };
            U4Salida resultado = Procedimientos.Resolucion(datosEntrada);

            txbArea.Text = resultado.Resultado.ToString();
            txbObservacion.Text = resultado._Error.ToString();

        }
    }
}
