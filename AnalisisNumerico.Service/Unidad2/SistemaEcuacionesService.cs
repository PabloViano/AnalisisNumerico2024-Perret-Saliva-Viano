using Entidades.Unidad2.Request;
using Entidades.Unidad2.Response;

namespace AnalsisNumerico.Unidad2;

public class SistemaEcuacionesService
{
    public ResponseUnidad2 CalcularGaussSeidel(MatrizModel matrizModel)
    {
        int dimension = matrizModel.Dimension;
        double[,] matriz = matrizModel.Matriz;
        double tolerancia = matrizModel.Tolerancia;
        int iteraciones = matrizModel.Iteraciones;

        // Comprobamos que la matriz tiene las dimensiones correctas
        if (matriz.GetLength(0) != dimension || matriz.GetLength(1) != dimension + 1)
        {
            throw new ArgumentException("La matriz debe tener tamaño [dimension, dimension + 1] para incluir los términos independientes.");
        }

        // Comprobamos que el número de iteraciones es positivo
        if (iteraciones <= 0)
        {
            throw new ArgumentException("El número de iteraciones debe ser mayor que cero.");
        }

        // Comprobamos que la tolerancia es positiva
        if (tolerancia <= 0)
        {
            throw new ArgumentException("La tolerancia debe ser un valor positivo.");
        }

        // Verificamos que los elementos de la diagonal no sean cero
        for (int i = 0; i < dimension; i++)
        {
            if (matriz[i, i] == 0)
            {
                throw new ArgumentException($"El elemento en la diagonal [{i}, {i}] no puede ser cero. El sistema no se puede resolver.");
            }
        }

        int contador = 0;
        double[] vectorResultado = new double[dimension];
        vectorResultado.Initialize();  // Inicializa el vector de resultados en 0
        bool convergencia = false;

        //Bucle principal de iteraciones
        while (contador <= iteraciones && !convergencia)
        {
            contador++;
            convergencia = true; // Se asume convergencia hasta demostrar lo contrario

            // Para cada fila (cada ecuación del sistema)
            for (int row = 0; row < dimension; row++)
            {
                double suma = matriz[row, dimension]; // Término independiente
                double valorAnterior = vectorResultado[row]; // Guardamos el valor anterior de la incógnita

                // Calcular la suma, excluyendo el valor de la incógnita actual
                for (int col = 0; col < dimension; col++)
                {
                    if (col != row)
                    {
                        suma -= matriz[row, col] * vectorResultado[col];
                    }
                }

                // Calcular el nuevo valor de la incógnita
                vectorResultado[row] = suma / matriz[row, row];

                // Verificar si la diferencia es menor a la tolerancia
                if (Math.Abs(vectorResultado[row] - valorAnterior) > tolerancia)
                {
                    convergencia = false; // Si alguna variable no ha convergido, seguir iterando
                }
            }
        }

        // Si ha convergido dentro del número de iteraciones, devolver el resultado
        if (convergencia)
        {
            return new ResponseUnidad2(vectorResultado, contador);
        }

        // Si no ha convergido después del número máximo de iteraciones, devolver null
        return null;
    }

    public ResponseUnidad2 CalcularGaussJordan(MatrizModel matrizModel)
    {
        int iteraciones = 0;
        int dimension = matrizModel.Dimension;
        double[,] matriz = matrizModel.Matriz;

        // Validamos que la matriz tenga el tamaño correcto
        if (matriz.GetLength(0) != dimension || matriz.GetLength(1) != dimension + 1)
        {
            throw new ArgumentException("La matriz debe tener tamaño [dimension, dimension + 1] para incluir los términos independientes.");
        }

        // Bucle principal para recorrer las filas de la matriz
        for (int i = 0; i < dimension; i++)
        {
            // Validación 2: Asegurarse de que el coeficiente de la diagonal no sea cero
            double coeficienteDiagonal = matriz[i, i];
            if (coeficienteDiagonal == 0)
            {
                throw new InvalidOperationException($"El coeficiente en la diagonal [{i}, {i}] es cero. No se puede resolver el metodo.");
            }

            // Dividimos la fila completa por el coeficiente de la diagonal para que el coeficiente diagonal sea 1
            // Cuando recorro columnas es (dimension + 1) porque tengo en cuenta el termino independiente
            for (int j = 0; j < dimension + 1; j++)
            {
                matriz[i, j] /= coeficienteDiagonal;
            }

            // Ahora itero sobre los elementos de la columna del coeficienteDiagonal
            // Hacemos ceros por encima y por debajo del coeficiente diagonal
            for (int k = 0; k < dimension; k++)
            {
                //Salteamos al coeficiente de la diagonal
                if (k != i)
                {
                    double coeficienteParaAnular = matriz[k, i];

                    // Restamos la fila actual multiplicada por el coeficiente para anular el valor
                    //La misma formula para anular se la tenemos que aplicar a todos los elementos de la fila
                    //Entonces recorremos las columnas
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

        return new ResponseUnidad2(vectorResultado, iteraciones);
    }
}