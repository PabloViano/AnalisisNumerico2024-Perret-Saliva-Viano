using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SalidaMA
    {
        public bool Converge { get; set; }
        public int IterTotales { get; set; }
        public double ErrRelativo { get; set; }
        public double? Raiz { get; set; }

        //sirve para ver una vez ejecutado si termino por error o termino correctamente
        public bool HuboError { get; set; }
    }
}
