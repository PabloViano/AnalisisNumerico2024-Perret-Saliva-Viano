using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculus;
using Entidades.Unidad4;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AnalsisNumerico.Unidades.Unidad4
{
    public static class Procedimientos
    {
        public static U4Salida Resolucion(U4Entrada entrada)
        {
            Calculo Analizador = new Calculo();
            U4Salida response = null;

            if (Analizador.Sintaxis(entrada.Funcion, 'x'))
            {
                switch (entrada.Metodo)
                {
                    case 0:
                        response = CalcularTrapecioSimple(entrada); 
                        break;
                    case 1:
                        response = CalcularTrapecioMultiple(entrada);
                        break;
                    case 2:
                        response = CalcularSimpsonUnTercioSimple(entrada);
                        break;
                    case 3:
                        response = CalcularSimpsonCombinado(entrada);
                        break;
                    case 4:
                        response = CalcularSimpsonTresOctavos(entrada);
                        break;
                    default:
                        MessageBox.Show("El int del metodo ingresado no corresponde con ninguno codificado");
                        break;
                }
            }
            else
            {
                MessageBox.Show("La sintaxis de la función no es correcta");
            }
            return response;
        }

        public static U4Salida CalcularTrapecioSimple(U4Entrada entrada)
        {
            Calculo calculo = new Calculo();

            if (calculo.Sintaxis(entrada.Funcion, 'x'))
            {
                double resultado = ((calculo.EvaluaFx(entrada.PuntoA) + calculo.EvaluaFx(entrada.PuntoB)) * (entrada.PuntoB - entrada.PuntoA)) / 2;
                return new U4Salida(resultado, string.Empty);
            }
            else
            {
                return new U4Salida(0, "La sintaxis de la funcion es incorrecta");
            }
        }
        public static U4Salida CalcularTrapecioMultiple(U4Entrada entrada)
        {
            Calculo calculo = new Calculo();

            if (calculo.Sintaxis(entrada.Funcion, 'x'))
            {
                double h = (entrada.PuntoB - entrada.PuntoA) / entrada.CantidadSubintervalos;
                double sum = 0;

                for (int i = 1; i < entrada.CantidadSubintervalos; i++)
                {
                    sum += calculo.EvaluaFx(entrada.PuntoA + h * i);
                }

                double area = (h / 2) * (calculo.EvaluaFx(entrada.PuntoA) + 2 * sum + calculo.EvaluaFx(entrada.PuntoB));
                return new U4Salida(area, string.Empty);
            }
            else
            {
                return new U4Salida(0, "La sintaxis de la funcion es incorrecta");
            }
        }
        public static U4Salida CalcularSimpsonUnTercioSimple(U4Entrada entrada)
        {
            Calculo calculo = new Calculo();

            if (calculo.Sintaxis(entrada.Funcion, 'x'))
            {
                double h = (entrada.PuntoB - entrada.PuntoA) / 2;
                double resultado = (h / 3) * (calculo.EvaluaFx(entrada.PuntoA) + 4 * calculo.EvaluaFx(entrada.PuntoA + h) + calculo.EvaluaFx(entrada.PuntoB));
                return new U4Salida(resultado, string.Empty);
            }
            else
            {
                return new U4Salida(0, "La sintaxis de la funcion es incorrecta");
            }
        }
        public static U4Salida CalcularSimpsonTresOctavos(U4Entrada entrada)
        {
            Calculo calculo = new Calculo();

            if (calculo.Sintaxis(entrada.Funcion, 'x'))
            {
                double h = (entrada.PuntoB - entrada.PuntoA) / 3;
                double resultado = (3 * h / 8) * (calculo.EvaluaFx(entrada.PuntoA) + 3 * calculo.EvaluaFx(entrada.PuntoA + h) + 3 * calculo.EvaluaFx(entrada.PuntoA + 2 * h) + calculo.EvaluaFx(entrada.PuntoB));

                return new U4Salida(resultado, string.Empty);
            }
            else
            {
                return new U4Salida(0, "La sintaxis de la funcion es incorrecta");
            }
        }
        public static U4Salida CalcularSimpsonCombinado(U4Entrada entrada)
        {
            Calculo calculo = new Calculo();

            if (calculo.Sintaxis(entrada.Funcion, 'x'))
            {
                double h = (entrada.PuntoB - entrada.PuntoA) / entrada.CantidadSubintervalos;

                double sumPares = 0;
                double sumImpares = 0;

                //Agregamos una variable para sumar ambos resultados
                double resultadoTotal = 0;

                //Bandera para saber si se aplico simpsonTresOctavos
                bool simpsonTresOctavosHecho = false;

                for (int i = 1; i < entrada.CantidadSubintervalos; i++)
                {
                    //Si la cantidad de intervalos es impar
                    if ((entrada.CantidadSubintervalos % 2) != 0 && !simpsonTresOctavosHecho)
                    {
                        //El intervalo seran los ultimos 3 subintervalos
                        double nuevoXi = entrada.PuntoA + h * (entrada.CantidadSubintervalos - 3);
                        U4Entrada entradaTresOctavos = new U4Entrada
                        {
                            Funcion = entrada.Funcion,
                            PuntoA = nuevoXi,
                            PuntoB = entrada.PuntoB
                        };
                        
                        resultadoTotal = CalcularSimpsonTresOctavos(entradaTresOctavos).Area;

                        //Como ya obtuvimos la ultima parte, ajustamos la cantidad de subintervalos
                        entrada.CantidadSubintervalos -= 3;

                        simpsonTresOctavosHecho = true;
                    }

                    //Calcula el resto del area usando simpson 1/3 multiple
                    if (i % 2 == 0)
                    {
                        sumPares += calculo.EvaluaFx(entrada.PuntoA + h * i);
                    }
                    else
                    {
                        sumImpares += calculo.EvaluaFx(entrada.PuntoA + h * i);
                    }
                }

                //Aplicamos la formula de simpson 1/3 multiple
                //Si no se hizo 3/8, entonces el reusltado total es el de 1/3 multiple
                resultadoTotal += (h / 3) * (calculo.EvaluaFx(entrada.PuntoA) + 4 * sumImpares + 2 * sumPares + calculo.EvaluaFx(entrada.PuntoB));

                //Preguntamos si se aplico simpson 3/8 unicamente para el resultado devuelto
                if (simpsonTresOctavosHecho)
                {
                    return new U4Salida(resultadoTotal, "Area calculada por ambos metodos.");
                }
                else
                {
                    return new U4Salida(resultadoTotal, "Area calculada solo por metodo Simpson 1/3 multiple.");
                }
            }
            else
            {
                return new U4Salida(0, "La sintaxis de la funcion es incorrecta");
            }
        }
    }
}
