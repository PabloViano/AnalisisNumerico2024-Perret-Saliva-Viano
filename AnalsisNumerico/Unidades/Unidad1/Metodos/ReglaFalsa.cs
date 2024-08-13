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
    public partial class ReglaFalsa : Form
    {
        public ReglaFalsa()
        {
            InitializeComponent();
        }

        private void button_Calcular_RF_Click(object sender, EventArgs e)
        {
            BiEntrada datosEntrada = new();
            datosEntrada.metodo = "Regla falsa";
            datosEntrada.Funcion = textBox_RF_Funcion.Text;
            datosEntrada.Xi = double.Parse(textBox_RF_LI.Text);
            datosEntrada.Xd = double.Parse(textBox_RF_LD.Text);
            datosEntrada.Iter = int.Parse(textBox_RF_Iteraciones.Text);

            BiSalida datosSalida = Procedimientos.MetodoCerrados(datosEntrada);
            label_RF_salida_Err.Text = datosSalida.ErrRelativo.ToString();
            label_RF_salida_Iter.Text = datosSalida.IterTotales.ToString();
            label_RF_salida_Solu.Text = datosSalida.Raiz.ToString();
        }
    }
}
