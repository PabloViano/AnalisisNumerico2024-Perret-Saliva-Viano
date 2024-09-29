﻿using Entidades;
using Entidades.Unidad2;
using Entidades.Unidad3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalsisNumerico.Unidades.U3
{
    public static class Procedimientos
    {
        public class Datos
        {
            public int CantPuntos { get; set; }
            public double SumX { get; set; }
            public double SumY { get; set; }
            public double SumXY { get; set; }
            public double SumX2 { get; set; }
        }
        public static U3Salida Resolucion(U3Entrada entrada, int metodo)
        {
            double sumX = 0;
            double sumY = 0;
            double sumXY = 0;
            double sumX2 = 0;

            foreach (double[] item in entrada.PuntosCargados)
            {
                sumX += item[0];
                sumY += item[1];
                sumXY += item[0] * item[1];
                sumX2 += item[0] * item[0];
            }

            Datos datos = new Datos()
            {
                CantPuntos = entrada.PuntosCargados.Count,
                SumX = sumX,
                SumY = sumY,
                SumXY = sumXY,
                SumX2 = sumX2
            };

            if (metodo == 0)
                return RegresionLineal(datos, entrada);
            return RegresionPolinomial(datos, entrada);
        }
        public static U3Salida RegresionLineal(Datos datos, U3Entrada entrada)
        {
            double a1 = (datos.CantPuntos * datos.SumXY - datos.SumX * datos.SumY) / (datos.CantPuntos * datos.SumX2 - Math.Pow(datos.SumX, 2)); //ver si calcula bien
            double a0 = (datos.SumY / datos.CantPuntos) - a1 * (datos.SumX / datos.CantPuntos);

            double St = 0;
            double Sr = 0;

            foreach (double[] item in entrada.PuntosCargados)
            {
                St += Math.Pow(datos.SumY / datos.CantPuntos - item[1], 2);
                Sr += Math.Pow(a1 * item[0] + a0 - item[1], 2);
            }

            double coefCorrelacion = Math.Sqrt((St - Sr) / St);

            return new U3Salida
            {
                Funcion = $"y = {Math.Round(a1, 3)}.x {(a0 > 0 ? "+" : "")}{Math.Round(a0, 3)}",
                FuncionGraficador = $"{a1}*x{(a0 > 0 ? "+" : "")}{a0}",
                PorcentajeEfectividad = coefCorrelacion * 100,
                EfectividadAjuste = coefCorrelacion > entrada.Tolerancia
            };
        }
        public static U3Salida RegresionPolinomial(Datos datos, U3Entrada entrada)
        {
            U3Salida u3Salida = new U3Salida();

            double[,] MatrizPolinomial = GenerarMatrizPolinomial(entrada);
            U2Entrada methodData = new U2Entrada { Matriz = MatrizPolinomial, Dimension = entrada.Grado + 1, MaxIter = 100, Tolerancia = 0.0001, Decimales = 10 };

            U2Salida data = Unidad2.Procedimientos.MetodoGaussJordan(methodData);
            if (data._Error)
            {
                MessageBox.Show(data._MsjError);
            }

            string[] funciones = EscribirFuncionPolinomial(data);

            double Sr = 0;
            double St = 0;
            foreach (double[] punto in entrada.PuntosCargados)
            {
                double x = punto[0];
                double y = punto[1];
                double suma = 0;
                for (int i = 0; i < data.Resultado.Count(); i++)
                {
                    suma += data.Resultado[i] * Math.Pow(x, i);
                }
                Sr += Math.Pow(suma - y, 2);
                St += Math.Pow(datos.SumY / datos.CantPuntos - y, 2);
            }

            double coefCorrelacion = Math.Sqrt((St - Sr) / St);

            return new U3Salida
            {
                Funcion = funciones[0],
                FuncionGraficador = funciones[1],
                PorcentajeEfectividad = Math.Round(coefCorrelacion * 100, 4),
                EfectividadAjuste = coefCorrelacion > entrada.Tolerancia
            };
        }
        public static double[,] GenerarMatrizPolinomial(U3Entrada datos)
        {
            int dimension = datos.Grado + 1;
            double[,] matriz = new double[dimension, dimension + 1];
            foreach (double[] punto in datos.PuntosCargados)
            {
                double x = punto[0];
                double y = punto[1];
                for (int row = 0; row < dimension; row++)
                {
                    for (int col = 0; col < dimension; col++)
                    {
                        matriz[row, col] += Math.Pow(x, row + col);
                    }
                    matriz[row, dimension] += y * Math.Pow(x, row);
                }
            }
            return matriz;
        }
        public static string[] EscribirFuncionPolinomial(U2Salida data)
        {
            string funcion = "y =";
            string funcionGraf = string.Empty;
            string signo = string.Empty;
            for (int i = data.Resultado.Count() - 1; i >= 0; i--)
            {
                double ai = Math.Round(data.Resultado[i], 4);

                if (i == data.Resultado.Count() - 1)
                    signo = ai > 0 ? "" : "-";
                else
                    signo = ai > 0 ? "+" : "-";

                if (i == 0 && ai != 0)
                {
                    funcion += $" {signo} {Math.Abs(ai)}";
                    funcionGraf += $"{signo}{Math.Abs(ai)}";
                }
                else if (i == 1 && ai != 0)
                {
                    funcion += $"{signo} {Math.Abs(ai)}x ";
                    funcionGraf += $"{signo}{Math.Abs(ai)}*x";
                }
                else
                {
                    if (ai != 0)
                    {
                        funcion += $"{signo} {Math.Abs(ai)}x^{i} ";
                        funcionGraf += $"{signo}{Math.Abs(ai)}*x^{i}";
                    }
                }
            }
            return new string[] { funcion, funcionGraf };
        }
    }
}
