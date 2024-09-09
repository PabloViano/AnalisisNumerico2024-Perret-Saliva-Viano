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
        private static double CalcularMetodo(string metodo, double Xi, double Xd, string funcion)
        {
            Calculo AnalizadorFunciones = new();


            AnalizadorFunciones.Sintaxis(funcion, 'x');
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
        public static SalidaMC MetodoCerrados(EntradaMC datosEntrada)
        {
            //Inicializamos Calculus
            Calculo AnalizadorFunciones = new();

            SalidaMC salida = new SalidaMC();

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
                    if (AnalizadorFunciones.EvaluaFx(datosEntrada.Xi) * AnalizadorFunciones.EvaluaFx(datosEntrada.Xd) > 0)
                    {
                        double funcXi = AnalizadorFunciones.EvaluaFx(datosEntrada.Xi);
                        double funXd = AnalizadorFunciones.EvaluaFx(datosEntrada.Xd);
                        //MessageBox.Show($"funcion en xi = {funcXi} y funcion en xd = {funXd}");
                        MessageBox.Show("La raiz no se encuentra en el intervalo ingresado");
                        break;
                    }
                    
                    if (AnalizadorFunciones.EvaluaFx(datosEntrada.Xi) * AnalizadorFunciones.EvaluaFx(datosEntrada.Xd) < 0)
                    {
                        cont++;
                        xr = CalcularMetodo(datosEntrada.metodo, datosEntrada.Xi, datosEntrada.Xd, datosEntrada.Funcion);
                        Err = Math.Abs((xr - xrAnterior) / xr);

                        if (Math.Abs((double)AnalizadorFunciones.EvaluaFx(xr)) < datosEntrada.Tole || Err < datosEntrada.Tole)
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
        
        // Metodo para calcular Newton-Rapshon y Secante
        public static SalidaMA MetodoAbierto(EntradaMA datosEntrada)
        {
            Calculo analizadorFunciones = new();

            SalidaMA Resultado = new();

            string funcion = datosEntrada.Funcion;
            double tolerancia = datosEntrada.Tole;
            int iteraciones  = datosEntrada.Iter;
            double Xi = datosEntrada.Xini;
            double Xd = datosEntrada.Xd;
            string metodo = datosEntrada.Metodo;

            //Verificamos la sintaxis de funcion
            if (analizadorFunciones.Sintaxis(funcion, 'x'))
            {
                double Error = 0;
                double Xr = 0;
                
                //Vemos si el valor ingresado es la raiz
                if (Math.Abs((double)analizadorFunciones.EvaluaFx(Xi)) < tolerancia)
                {
                    Resultado.ErrRelativo = Error;
                    Resultado.Converge = true;
                    Resultado.Raiz = Math.Round(Xi, 6);
                    Resultado.IterTotales = 0;
                    Resultado.HuboError = false;

                    return Resultado;
                }
                
                //Vemos si el valor ingresado es la raiz
                if (Math.Abs((double)analizadorFunciones.EvaluaFx(Xd)) < tolerancia && metodo == "Secante")
                {
                    Resultado.ErrRelativo = Error;
                    Resultado.Converge = true;
                    Resultado.Raiz = Math.Round(Xd, 6);
                    Resultado.IterTotales = 0;
                    Resultado.HuboError = false;

                    return Resultado;
                }
                double XrAnterior = 0;
                for (int i = 1; i <= iteraciones; i++)
                {
                    //Verificamos si la funcion dirverge en el metodo de la Secante
                    if (metodo == "Secante")
                    {
                        Xr = CalcularMetodo(metodo, Xi, Xd, funcion);
                        if (double.IsNaN(Xr))
                        {
                            Resultado.ErrRelativo = Error;
                            Resultado.Converge = false;
                            Resultado.Raiz = 0;
                            Resultado.IterTotales = 0;
                            Resultado.HuboError = true;

                            MessageBox.Show("ERROR. El metodo diverge, usando Secante como metodo.");
                            return Resultado;
                        }
                    }
                    else
                    {
                        double Deriv = analizadorFunciones.Dx(Xi);

                        //Verificamos si la funcion dirverge en el metodo de Newton-Rapshon
                        if (Math.Abs(Deriv) < tolerancia || double.IsNaN(Deriv))
                        {
                            Resultado.ErrRelativo = Error;
                            Resultado.Converge = false;
                            Resultado.Raiz = 0;
                            Resultado.IterTotales = 0;
                            Resultado.HuboError = true;

                            MessageBox.Show("ERROR. El metodo diverge, usando Newton-Rapshon como metodo");
                            return Resultado;
                        }
                        Xr = CalcularMetodo(metodo, Xi, Deriv, funcion);
                    }
                    Error = Math.Abs((Xr - XrAnterior) / Xr);
                    //Verificamos si encontramos la Raiz
                    if (Math.Abs((double)analizadorFunciones.EvaluaFx(Xr)) < tolerancia || Error < tolerancia)
                    {
                        Resultado.ErrRelativo = Error;
                        Resultado.Converge = true;
                        Resultado.Raiz = Math.Round(Xr, 6);
                        Resultado.IterTotales = i;
                        Resultado.HuboError = false;

                        return Resultado;
                    }
                    else
                    {
                        if (metodo == "Newton-Raphson")
                        {
                            Xi = Xr;
                        }
                        else
                        {
                            Xi = Xd;
                            Xd = Xr;
                        }
                        XrAnterior = Xr;
                    }
                }
                //Verificamos si encontramos la Raiz
                if (Math.Abs((double)analizadorFunciones.EvaluaFx(Xr)) >= tolerancia && Error >= tolerancia)
                {
                    Resultado.ErrRelativo = Error;
                    Resultado.Converge = true;
                    Resultado.Raiz = Math.Round(Xr, 6);
                    Resultado.IterTotales = iteraciones;
                    Resultado.HuboError = false;

                    return Resultado;
                }
            }
            //La sintaxis no es correcta
                MessageBox.Show("Error de sintaxis en la funcion. Verifique.");
                Resultado.ErrRelativo = 0;
                Resultado.Converge = false;
                Resultado.Raiz = 0;
                Resultado.IterTotales = 0;
                Resultado.HuboError = true;
                return Resultado;
        }

    }
}
