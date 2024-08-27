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

namespace AnalsisNumerico.Unidades.Unidad1.Metodos
{
    public partial class NewtonRapshon : Form
    {
        public NewtonRapshon()
        {
            InitializeComponent();
        }

        private void button_Calcular_NW_Click(object sender, EventArgs e)
        {
            EntradaMA datosEntrada = new();
            datosEntrada.Metodo = "Newton-Raphson";
            datosEntrada.Funcion = textBox_NW_Funcion.Text;
            datosEntrada.Xini = double.Parse(textBox_NW_LI.Text);
            datosEntrada.Xd = 0;
            datosEntrada.Iter = int.Parse(textBox_NW_Iteraciones.Text);
            datosEntrada.Tole = 0.0004;

            SalidaMA datosSalida = Procedimientos.MetodoAbierto(datosEntrada);

            float numero = (float)datosSalida.ErrRelativo;

            label_NW_salida_Err.Text = numero.ToString("F7");
            label_NW_salida_Iter.Text = datosSalida.IterTotales.ToString();
            label_NW_salida_Solu.Text = datosSalida.Raiz.ToString();
            label_salida_NW_Converge.Text = datosSalida.Converge.ToString();
        }
    }
}
