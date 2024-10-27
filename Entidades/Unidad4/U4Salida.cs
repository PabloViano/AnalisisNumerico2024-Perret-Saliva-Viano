using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Unidad4
{
    public class U4Salida
    {
        public double Area{ get; set; }
        public string Error { get; set; }

        public U4Salida(double area, string error)
        {
            this.Area = area;
            this.Error = error;
        }
    }
}
