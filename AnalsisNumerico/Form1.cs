using AnalsisNumerico.Unidades.Unidad1;
using AnalsisNumerico.Unidades.Unidad2;

namespace AnalsisNumerico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_menu_U1_Click(object sender, EventArgs e)
        {
            Unidad1 unidad1 = new Unidad1();
            unidad1.ShowDialog();
        }

        private void button_menu_U2_Click(object sender, EventArgs e)
        {
            Unidad2 unidad2 = new Unidad2();
            unidad2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
