using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Unidad2
{
    public class ResponseUnidad2
    {
        public double[]? VectorRespuesta { get; set; }
        public int Iteraciones { get; set; }
        public ResponseUnidad2(double[] vectorRespuesta, int iteraciones)
        {
            VectorRespuesta = vectorRespuesta;
            Iteraciones = iteraciones;
        }
    }
}
