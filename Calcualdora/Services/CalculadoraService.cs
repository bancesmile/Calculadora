namespace Calcualdora.Services
{
    /// <summary>
    /// Servicio con las operaciones matemáticas de la calculadora.
    /// Separado del controller para poder ser probado unitariamente.
    /// </summary>
    public class CalculadoraService
    {
        public double Suma(double a, double b) => a + b;
        public double Resta(double a, double b) => a - b;

public double Multiplicacion(double a, double b) => a * b;
    }
}
