namespace Entidades
{
    public class BiEntrada
    {
        public string Funcion { get; set; }
        public double Xi { get; set; } // En caso de ser un método abierto, se usa como "XIni"
        public double Xd { get; set; }
        public int Iter { get; set; }
        public double Tole { get; set; }
    }
}
