using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Calculus;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AnalsisNumerico.Unidades.Unidad1
{
    public class Procedimientos
    {
        private static double CalcularMetodo(string metodo, double Xi, double Xd)
        {
            Calculo AnalizadorFunciones = new();
            switch (metodo)
            {
                case "Biseccion":
                    return (Xi + Xd) / 2;
                case "Regla falsa":
                    {
                        double fxi = AnalizadorFunciones.EvaluaFx(Xi);
                        double fxd = AnalizadorFunciones.EvaluaFx(Xd);
                        return ((fxi * Xd) - (fxd * Xi)) / (fxi - fxd);
                    }
                case "Newton-Raphson":
                    double Xini = Xi;
                    double Deriv = Xd;
                    return (Xini - (AnalizadorFunciones.EvaluaFx(Xini) / Deriv));
                case "Secante":
                    double uno = AnalizadorFunciones.EvaluaFx(Xi);
                    double dos = AnalizadorFunciones.EvaluaFx(Xd);
                    return ((AnalizadorFunciones.EvaluaFx(Xd) * Xi) - (AnalizadorFunciones.EvaluaFx(Xi) * Xd)) /
                        (AnalizadorFunciones.EvaluaFx(Xd) - AnalizadorFunciones.EvaluaFx(Xi));
                default: throw new NotImplementedException();
            }
        }

        //Con este metodo podemos calcular el metodo de la Biseccion y la Regla Falsa
        public static BiSalida MetodoCerrados(BiEntrada datosEntrada)
        {
            //Inicializamos Calculus
            Calculo AnalizadorFunciones = new();

            BiSalida salida = new BiSalida();

            //Primero verificamos que la funcion ingresada este bien escrita
            if (AnalizadorFunciones.Sintaxis(datosEntrada.Funcion, 'x'))
            {
                int cont = 0;
                double xr = 0;
                double xrAnterior = 0;
                double Err = 0;

                while (cont < datosEntrada.Iter)
                {
                    //Miramos si alguno de los datos ingresados en Raiz
                    if (AnalizadorFunciones.EvaluaFx(datosEntrada.Xi) * AnalizadorFunciones.EvaluaFx(datosEntrada.Xd) == 0)
                    {
                        salida.IterTotales = cont;
                        salida.ErrRelativo = Err;
                        salida.Converge = true;

                        if (AnalizadorFunciones.EvaluaFx(datosEntrada.Xi) == 0)
                        {
                            salida.Raiz = datosEntrada.Xi;
                            MessageBox.Show("El valor ingresado en el Limite izquierdo es la raiz");
                            return salida;
                        }
                        salida.Raiz = datosEntrada.Xd;
                        MessageBox.Show("El valor ingresado en el Limite derecho es la raiz");
                        return salida;
                    }
                    //Verificamos que el intervalo contenga la raiz
                    else if (AnalizadorFunciones.EvaluaFx(datosEntrada.Xi) * AnalizadorFunciones.EvaluaFx(datosEntrada.Xd) > 0)
                    {
                        double funcXi = AnalizadorFunciones.EvaluaFx(datosEntrada.Xi);
                        double funXd = AnalizadorFunciones.EvaluaFx(datosEntrada.Xd);
                        //MessageBox.Show($"funcion en xi = {funcXi} y funcion en xd = {funXd}");
                        MessageBox.Show("La raiz no se encuentra en el intervalo ingresado");
                        break;
                    }
                    else if (AnalizadorFunciones.EvaluaFx(datosEntrada.Xi) * AnalizadorFunciones.EvaluaFx(datosEntrada.Xd) < 0)
                    {
                        cont++;
                        xr = CalcularMetodo(datosEntrada.metodo, datosEntrada.Xi, datosEntrada.Xd);
                        Err = Math.Abs((xr - xrAnterior) / xr);

                        if (Math.Abs(AnalizadorFunciones.EvaluaFx(xr)) < datosEntrada.Tole || Err < datosEntrada.Tole)
                            break;
                    }

                    //Vemos cual de los 2 limites va a intercambiar valor por xr
                    if (AnalizadorFunciones.EvaluaFx(datosEntrada.Xi) * AnalizadorFunciones.EvaluaFx(xr) < 0)
                        datosEntrada.Xd = xr;
                    else
                        datosEntrada.Xi = xr;
                    xrAnterior = xr;
                }
                if (!salida.HuboError)
                {
                    salida.IterTotales = cont;
                    salida.ErrRelativo = Math.Round(Err, 6);

                    if (cont > datosEntrada.Iter)
                    {
                        MessageBox.Show("Se han completado las iteraciones");
                        salida.Converge = false;
                    }
                    else
                    {
                        salida.Converge = true;
                    }
                    salida.Raiz = Math.Round(xr, 6);
                    return salida;
                }
            }
            else
            {
                MessageBox.Show("La funcion ingresada no es valida");
                return salida;
            }

            return salida;
        }

        //Este es el metodo para poder calcular los metodos de Newton-Rapshon y Secante
        public static SalidaMA MetodosAbiertos( EntradaMA datosEntrada)
        {
            Calculo AnalizadorFunciones = new();

            SalidaMA resultado = new();

            if (AnalizadorFunciones.Sintaxis(datosEntrada.Funcion, 'x'))
            {
                //Inicializamos todas las variables necesarias
                int cont = 0;
                double xi = datosEntrada.Xini;
                double xr = 0;
                double xAnt = 0;
                double ErrorRelativo = 0;
                double derivada = 0;

                while (cont < datosEntrada.Iter)
                {
                    //Verificamos que el XIni no sea raiz
                    if (AnalizadorFunciones.EvaluaFx(datosEntrada.Xini) <= datosEntrada.Tole)
                    {
                        resultado.IterTotales = cont;
                        resultado.ErrRelativo = ErrorRelativo;
                        resultado.Converge = true;
                        resultado.HuboError = false;
                        resultado.Raiz = datosEntrada.Xini;

                        MessageBox.Show("El punto de inicio ingresado es la Raiz (pura suerte)");

                        return resultado;
                    }

                    derivada = AnalizadorFunciones.Dx(xi);

                    if (derivada == 0)
                    {
                        resultado.IterTotales = cont;
                        resultado.ErrRelativo = ErrorRelativo;
                        resultado.Converge = false;
                        resultado.HuboError = false;
                        resultado.Raiz = null;

                        MessageBox.Show("No hay raiz");

                        return resultado;
                    }

                    xr = CalcularMetodo("Newton-Raphson",xi,derivada);
                    ErrorRelativo = Math.Abs(xr - xAnt);

                    if (AnalizadorFunciones.EvaluaFx(xr) <= datosEntrada.Tole || datosEntrada.Tole > ErrorRelativo) 
                    {
                        resultado.IterTotales = cont;
                        resultado.ErrRelativo = ErrorRelativo;
                        resultado.Converge = true;
                        resultado.HuboError = false;
                        resultado.Raiz = xr;

                        return resultado;
                    }
                    else
                    {
                        xAnt = xr;
                        xi = xr;
                    }

                }
            }
            else
            {
                resultado.IterTotales = 0;
                resultado.ErrRelativo = 0;
                resultado.Converge = false;
                resultado.HuboError = true;

                MessageBox.Show("Ingrese una función válida");

                return resultado;
            }

            return resultado;
        }
    }
}
