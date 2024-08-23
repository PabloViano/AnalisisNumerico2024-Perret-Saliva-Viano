using Entidades;
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

namespace AnalsisNumerico.Unidades.Unidad1.Metodos
{
    public partial class Biseccion : Form
    {
        public Biseccion()
        {
            InitializeComponent();
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            EntradaMC datosEntrada = new();
            datosEntrada.metodo = "Biseccion";
            datosEntrada.Funcion = textBox_funcion.Text;
            datosEntrada.Xi = double.Parse(textBox_li.Text);
            datosEntrada.Xd = double.Parse(textBox_ld.Text);
            datosEntrada.Iter = int.Parse(textBox_iteraciones.Text);

            SalidaMC datosSalida = Procedimientos.MetodoCerrados(datosEntrada);

            string numero = string.Format("{0:F6}", datosSalida.ErrRelativo); ;

            label_salida_err.Text = numero.ToString();
            label_salida_iteraciones.Text = datosSalida.IterTotales.ToString();
            label_salida_solucion.Text = datosSalida.Raiz.ToString();
            label_BI_Salida_Converge.Text = datosSalida.Converge.ToString();
        }
    }
}
