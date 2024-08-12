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
    public partial class Biseccion : Form
    {
        public Biseccion()
        {
            InitializeComponent();
        }

        private void button_Calcular_Click(object sender, EventArgs e)
        {
            BiEntrada datosEntrada = new();
            datosEntrada.Funcion = textBox_funcion.Text;
            datosEntrada.Xi = double.Parse(textBox_li.Text);
            datosEntrada.Xd = double.Parse(textBox_ld.Text);
            datosEntrada.Iter = int.Parse(textBox_iteraciones.Text);

            BiSalida datosSalida = Procedimientos.MetodoBiseccion(datosEntrada);
            label_salida_err.Text = datosSalida.ErrRelativo.ToString();
            label_salida_iteraciones.Text = datosSalida.IterTotales.ToString();
            label_salida_solucion.Text = datosSalida.Raiz.ToString();
        }
    }
}
