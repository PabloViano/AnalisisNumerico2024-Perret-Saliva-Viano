using AnalsisNumerico.Unidades.Unidad1;

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
    }
}
