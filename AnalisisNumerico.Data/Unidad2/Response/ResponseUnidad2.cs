namespace Entidades.Unidad2.Response;

public class ResponseUnidad2
{
    public double[]? VectorRespuesta { get; set; }
    public int Iteraciones { get; set; }
 

    public ResponseUnidad2(double[] vectorRespuesta, int iteraciones)
    {
        VectorRespuesta = vectorRespuesta;
        Iteraciones = iteraciones;
    }
}