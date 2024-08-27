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
    public partial class Secante : Form
    {
        public Secante()
        {
            InitializeComponent();
        }

        private void button_Calcular_NW_Click(object sender, EventArgs e)
        {
            EntradaMA datosEntrada = new();
            datosEntrada.Metodo = "Secante";
            datosEntrada.Funcion = textBox_SEC_Funcion.Text;
            datosEntrada.Xini = double.Parse(textBox_SEC_LI.Text);
            datosEntrada.Xd = double.Parse(textBox_SEC_LD.Text);
            datosEntrada.Iter = int.Parse(textBox_SEC_Iteraciones.Text);
            datosEntrada.Tole = 0.0004;

            SalidaMA datosSalida = Procedimientos.MetodoAbierto(datosEntrada);

            float numero = (float)datosSalida.ErrRelativo;

            label_SEC_salida_Err.Text = numero.ToString("F7");
            label_SEC_salida_Iter.Text = datosSalida.IterTotales.ToString();
            label_SEC_salida_Solu.Text = datosSalida.Raiz.ToString();
            label_salida_SEC_Converge.Text = datosSalida.Converge.ToString();
        }
    }
}
