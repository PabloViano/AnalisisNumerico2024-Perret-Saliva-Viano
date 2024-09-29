﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Unidad3
{
    public sealed class U3Entrada
    {
        public List<double[]> PuntosCargados { get; set; }
        public double Tolerancia { get; set; }
        public int Grado { get; set; } //Siempre es 2 o más para la regresion polinomial
    }

}
