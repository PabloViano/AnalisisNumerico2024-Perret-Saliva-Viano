﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Unidad2
{
    public sealed class U2Entrada
    {
        public int Dimension { get; set; }
        public double[,] Matriz { get; set; }
        public double Tolerancia { get; set; }
        public int MaxIter { get; set; }
        public int Decimales { get; set; }
    }
}
