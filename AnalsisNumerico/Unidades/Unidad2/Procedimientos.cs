using Entidades.Unidad2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalsisNumerico.Unidades.Unidad2
{
    public static class Procedimientos
    {
        public static U2Salida MetodoGaussJordan(U2Entrada datos)
        {
            U2Salida salida = new U2Salida();
            salida._Metodo = "Gauss-Jordan";

            for (int x = 0; x < datos.Dimension; x++)
            {
                for (int y = 0; y < datos.Dimension; y++)
                {
                    if (x == y)
                    {
                        double coeficienteDiagonal = datos.Matriz[x, y];
                        for (int col = 0; col < datos.Dimension + 1; col++) //Divido todos los coeficientes de la ecuación por el coeficiente de la DP
                        {
                            datos.Matriz[x, col] = datos.Matriz[x, col] / coeficienteDiagonal;
                        }
                        for (int row = 0; row < datos.Dimension; row++)//Fuera de ese renglón tengo que hacer 0 todos los coeficientes de arriba y abajo
                        {                                                //Tmb modificando los demás coeficientes de renglones ajenos.
                            if (row != x)
                            {
                                double coeficienteCero = datos.Matriz[row, y];
                                for (int col = 0; col < datos.Dimension + 1; col++)
                                {
                                    datos.Matriz[row, col] = datos.Matriz[row, col] - (coeficienteCero * datos.Matriz[x, col]);
                                }
                            }
                        }
                    }
                }
            }
            double[] vectorResultado = new double[datos.Dimension];
            for (int i = 0; i < datos.Dimension; i++) //En algunos pongo dimensión+1 y en otros no porque solamente hay una columna extra (los valores b resultados)
            {
                vectorResultado[i] = Math.Round(datos.Matriz[i, datos.Dimension], datos.Decimales);
            }
            salida.Resultado = vectorResultado;
            return salida;
        }
        public static U2Salida MetodoGaussSeidel(U2Entrada datos)//Transcribo lo que mandó el profe (as good as I can)
        {
            double tolerancia = datos.Tolerancia;
            bool menorTolerancia = false;
            int contador = 0;
            int maxIteraciones = datos.MaxIter;
            double[] vectorResultado = new double[datos.Dimension];

            double[] vectorAnterior = new double[datos.Dimension];
            double resultado = 0;
            U2Salida salida = new U2Salida();
            salida._Metodo = "Gauss-Seidel";

            vectorResultado.Initialize(); //Rellena el vector con 0s
            while (contador <= maxIteraciones && !menorTolerancia)
            {
                contador++;
                if (contador > 1)
                    vectorResultado.CopyTo(vectorAnterior, 0);
                for (int row = 0; row < datos.Dimension; row++)
                {
                    resultado = datos.Matriz[row, datos.Dimension];
                    double coefIncog = datos.Matriz[row, row];
                    for (int col = 0; col < datos.Dimension; col++)
                    {
                        if (row != col)
                            resultado = resultado - (datos.Matriz[row, col] * vectorResultado[col]);
                    }
                    coefIncog = resultado / coefIncog; //Ver si en ese punto coefIncog puede llegar a ser 0
                    vectorResultado[row] = Math.Round(coefIncog, datos.Decimales);

                }
                int contarMismoResultado = 0;
                for (int i = 0; i < datos.Dimension; i++)
                {
                    if (Math.Abs(vectorResultado[i] - vectorAnterior[i]) < tolerancia)
                    {
                        contarMismoResultado++;
                    }
                }
                menorTolerancia = contarMismoResultado == datos.Dimension;
            }
            if (contador > maxIteraciones)
                MessageBox.Show("Se superó el número máximo de iteraciones antes de llegar a un resultado tolerable");
            salida.Resultado = vectorResultado;
            salida.Iteraciones = contador;
            return salida;
        }
    }
}
