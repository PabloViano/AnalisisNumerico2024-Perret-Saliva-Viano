using AnalsisNumerico.Unidades.Unidad2.Respuestas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalsisNumerico.Unidades.Unidad2
{
    public class GaussJordan
    {
        public Response Calcular(int dimension, double[,] matriz)
        {
            int iteraciones = 0;
            //Recorremos las filas de la matriz
            for (int i = 0; i < dimension; i++)
            {
                double coeficienteDiagonal = matriz[i, i];

                //Recorremos las columnas dividiendo los coeficientes por el de la diagonal principal
                //Cuando recorro columnas es (dimension + 1) porque tengo en cuenta el termino independiente
                for (int j = 0; j < dimension + 1; j++)
                {
                    matriz[i, j] /= coeficienteDiagonal;
                }

                //Ahora itero sobre los elementos de la columna del coeficienteDiagonal
                for (int k = 0; k < dimension; k++)
                {
                    //Salteamos al coeficiente de la diagonal
                    if (k != i)
                    {
                        double coeficienteParaAnular = matriz[k, i];

                        //La misma formula para anular se la tenemos que aplicar a todos los elementos de la fila
                        //Entonces ecorremos las columnas
                        for (int l = i; l <= dimension; l++)
                        {
                            matriz[k, l] -= coeficienteParaAnular * matriz[i, l];
                        }

                        iteraciones++;
                    }
                }
            }

            double[] vectorResultado = new double[dimension];

            //Vuelco los terminos independientes en el vectorResultado
            for (int i = 0; i < dimension; i++)
            {
                vectorResultado[i] = matriz[i, dimension];
            }

            return new Response(vectorResultado, iteraciones);
        }
    }
}
