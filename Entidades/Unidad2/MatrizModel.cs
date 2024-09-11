using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Unidad2
{
    public class MatrizModel
    {
        public int Dimension { get; set; }
        public double[,] Matriz { get; set; }
        public double Tolerancia { get; set; } // Solo para Gauss-Seidel
        public int Iteraciones { get; set; }   // Solo para Gauss-Seidel
    }
}
