﻿namespace Entidades
{
    public class EntradaMC
    {
        public string metodo {  get; set; } //nombre del metodo que hay que aplicar
        public string Funcion { get; set; }
        public double Xi { get; set; } // En caso de ser un método abierto, se usa como "XIni"
        public double Xd { get; set; }
        public int Iter { get; set; }

        public double Tole = 0.0001;
    }
}
