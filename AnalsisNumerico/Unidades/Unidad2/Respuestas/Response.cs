using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalsisNumerico.Unidades.Unidad2.Respuestas
{
    public class Response
    {
        public double[]? VectorRespuesta { get; set; }
        public int Iteraciones { get; set; }

        public Response(double[] vectorRespuesta, int iteraciones)
        {
            VectorRespuesta = vectorRespuesta;
            Iteraciones = iteraciones;
        }
    }
}
